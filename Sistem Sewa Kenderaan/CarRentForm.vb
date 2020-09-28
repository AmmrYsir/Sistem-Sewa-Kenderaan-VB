Imports System.IO
Imports MySql.Data.MySqlClient

Public Class CarRentForm
    Public CarSessionID As String
    Dim price_per_hour As String

    Private Sub HourTrackBar_Scroll(sender As Object, e As EventArgs) Handles HourTrackBar.Scroll
        LblJamSewa.Text = HourTrackBar.Value & " JAM = RM" & (HourTrackBar.Value * Integer.Parse(price_per_hour))
    End Sub

    Private Sub ClearData()
        TxtNumberPhone.Text = String.Empty
        TxtKeteranganLanjut.Text = String.Empty
    End Sub

    Private Sub LoadData()
        ClearData()
        Call Connect()

        Dim ic_number As String
        Dim car_desc As String
        Dim Arr() As Byte

        cmd = New MySqlCommand("SELECT user_id, car_desc, price_per_hour, car_image FROM rental_car WHERE car_id=@car_id", conn)
        cmd.Parameters.AddWithValue("@car_id", CarSessionID)
        da = New MySqlDataAdapter(cmd)
        Dim dt = New DataTable
        da.Fill(dt)

        For Each rows As DataRow In dt.Rows()
            ic_number = rows("user_id")
            car_desc = rows("car_desc")
            price_per_hour = rows("price_per_hour")
            Arr = rows("car_image")
        Next

        cmd = New MySqlCommand("SELECT number_phone FROM user_table WHERE ic_number=@ic_number", conn)
        cmd.Parameters.AddWithValue("@ic_number", ic_number)
        Dim phoneNumber As String = cmd.ExecuteScalar()
        conn.Close()

        Dim ms As New MemoryStream(Arr)

        TxtNumberPhone.Text = phoneNumber
        TxtKeteranganLanjut.Text = car_desc
        CarPictureBox.Image = Image.FromStream(ms)
        LblHarga.Text = "RM" & price_per_hour & " PER JAM"

    End Sub

    Private Sub BtnSewa_Click(sender As Object, e As EventArgs) Handles BtnSewa.Click
        If HourTrackBar.Value <> 0 Then
            If DialogResult.Yes = MessageBox.Show("Are you sure you want to rent at " & DateTimePickerForSewaan.Value, "Rent A Car Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) Then
                Call Connect()

                cmd = New MySqlCommand("UPDATE rental_car SET rental_time_start=@rental_time_start, rental_time_end=@rental_time_end, car_status=@car_status WHERE car_id=@car_id", conn)
                cmd.Parameters.AddWithValue("@car_id", CarSessionID)
                cmd.Parameters.AddWithValue("@rental_time_start", DateTimePickerForSewaan.Value)
                cmd.Parameters.AddWithValue("@rental_time_end", DateTimePickerForSewaan.Value.AddHours(HourTrackBar.Value))
                cmd.Parameters.AddWithValue("@car_status", "Unavailable")

                If cmd.ExecuteNonQuery() Then
                    conn.Close()
                    MessageBox.Show("You have successfully rent the car", "Rent A Car Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

            End If
        End If
    End Sub

    Private Sub CarRentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub CarRentForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        PenyewaForm.GetLoadSarchCar()
    End Sub

End Class