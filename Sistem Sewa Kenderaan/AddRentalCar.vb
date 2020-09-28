Imports System.IO
Imports MySql.Data.MySqlClient

Public Class AddRentalCar
    Public CarSessionID As Integer
    Dim ms As New MemoryStream
    Dim Switch As Boolean = False

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TxtNamaKenderaan.Text = "" Or TxtKeterangan.Text = "" Or TxtJenama.Text = "" Or TxtTahun.Text = "" Or CmBoxTransmisi.Text = "" Or TxtHarga.Text = "" Or CmBoxStatus.Text = "" Then
            MessageBox.Show("Please do not leave anything blank", "Add Rental Car Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If Not Switch Then
                If CarPictureBox.Image.ToString = "" Then
                    MessageBox.Show("Please enter your car image", "Add Rental Car Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    CarPictureBox.Image.Save(ms, Drawing.Imaging.ImageFormat.Jpeg)
                    Dim arrImage() As Byte = ms.GetBuffer()

                    Call Connect()
                    cmd = New MySqlCommand("INSERT INTO rental_car(user_id, car_title, car_desc, car_brand, car_year, car_transmission, price_per_hour, car_status, car_image) VALUES(@user_id, @car_title, @car_desc, @car_brand, @car_year, @car_transmission, @price_per_hour, @car_status, @car_image)", conn)
                    cmd.Parameters.AddWithValue("@user_id", PemberiSewaForm.GetSessionID())
                    cmd.Parameters.AddWithValue("@car_title", TxtNamaKenderaan.Text)
                    cmd.Parameters.AddWithValue("@car_desc", TxtKeterangan.Text)
                    cmd.Parameters.AddWithValue("@car_brand", TxtJenama.Text)
                    cmd.Parameters.AddWithValue("@car_year", TxtTahun.Text)
                    cmd.Parameters.AddWithValue("@car_transmission", CmBoxTransmisi.Text)
                    cmd.Parameters.AddWithValue("@price_per_hour", TxtHarga.Text)
                    cmd.Parameters.AddWithValue("@car_status", CmBoxStatus.Text)
                    cmd.Parameters.AddWithValue("@car_image", arrImage)
                    If cmd.ExecuteNonQuery() Then
                        conn.Close()
                        PemberiSewaForm.GetLoadCarRentData()
                        Me.Close()
                    End If
                End If
            Else
                If CarPictureBox.Image.ToString = "" Then
                    MessageBox.Show("Please enter your car image", "Edit Rental Car Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    CarPictureBox.Image.Save(ms, Drawing.Imaging.ImageFormat.Jpeg)
                    Dim arrImage() As Byte = ms.GetBuffer()
                    Dim dateNow As Date = New Date.Now

                    Call Connect()
                    cmd = New MySqlCommand("UPDATE rental_car SET car_title=@car_title, car_desc=@car_desc, car_brand=@car_brand, car_year=@car_year, car_transmission=@car_transmission, car_status=@car_status, price_per_hour=@price, car_image=@car_image, car_edited_date=@car_edited_date WHERE car_id=@car_id", conn)
                    cmd.Parameters.AddWithValue("@car_id", CarSessionID)
                    cmd.Parameters.AddWithValue("@car_title", TxtNamaKenderaan.Text)
                    cmd.Parameters.AddWithValue("@car_desc", TxtKeterangan.Text)
                    cmd.Parameters.AddWithValue("@car_brand", TxtJenama.Text)
                    cmd.Parameters.AddWithValue("@car_year", TxtTahun.Text)
                    cmd.Parameters.AddWithValue("@car_transmission", CmBoxTransmisi.Text)
                    cmd.Parameters.AddWithValue("@price", TxtHarga.Text)
                    cmd.Parameters.AddWithValue("@car_status", CmBoxStatus.Text)
                    cmd.Parameters.AddWithValue("@car_edited_date", dateNow.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@car_image", arrImage)
                    If cmd.ExecuteNonQuery() Then
                        conn.Close()
                        PemberiSewaForm.GetLoadCarRentData()
                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BtnFileUpload_Click(sender As Object, e As EventArgs) Handles BtnFileUpload.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.Filter = "Choose Image(*.JPG; *.PNG; *.GIF)|*.jpg; *.png; *.gif"

        If DialogResult.OK = OpenFileDialog.ShowDialog() Then
            CarPictureBox.Image = Image.FromFile(OpenFileDialog.FileName)
        End If

    End Sub

    Private Sub AddRentalCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If BtnAdd.Text = "EDIT" Then
            Switch = True
            LoadCarRentData()
        Else
            Switch = False
            ClearAll()
        End If
    End Sub

    Private Sub LoadCarRentData()
        Dim newComponent = New RentalCarComponentForPemberiSewa()
        Call Connect()
        cmd = New MySqlCommand("SELECT * FROM rental_car WHERE car_id=@car_id", conn)
        cmd.Parameters.AddWithValue("@car_id", CarSessionID)
        da = New MySqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)

        For Each Rows As DataRow In dt.Rows()

            Dim Arr() As Byte = Rows("car_image")
            Dim ms As New MemoryStream(Arr)

            TxtNamaKenderaan.Text = Rows("car_title")
            TxtKeterangan.Text = Rows("car_desc")
            TxtJenama.Text = Rows("car_brand")
            TxtTahun.Text = Rows("car_year")
            CmBoxTransmisi.Text = Rows("car_transmission")
            CmBoxStatus.Text = Rows("car_status")
            TxtEditedDate.Text = Rows("car_edited_date")
            TxtHarga.Text = Rows("price_per_hour")
            CarPictureBox.Image = Image.FromStream(ms)
        Next

    End Sub

    Private Sub ClearAll()
        TxtNamaKenderaan.Text = String.Empty
        TxtKeterangan.Text = String.Empty
        TxtJenama.Text = String.Empty
        TxtTahun.Text = String.Empty
        CmBoxTransmisi.Text = String.Empty
        CmBoxStatus.Text = String.Empty
        TxtHarga.Text = String.Empty
        TxtEditedDate.Text = String.Empty
        CarPictureBox.Image = Nothing
    End Sub

End Class