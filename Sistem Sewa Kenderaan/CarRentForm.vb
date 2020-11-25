Imports System.IO
Imports MySql.Data.MySqlClient

Public Class CarRentForm
    Public CarSessionID As String
    Dim price_per_hour As String
    Dim dateValid As Boolean = False
    Dim rentalTimeStart As String
    Dim rentalTimeEnd As String

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

            Call Connect()
            cmd = New MySqlCommand("SELECT rental_time_start, rental_time_end FROM booking_table WHERE car_id=@car_id", conn)
            cmd.Parameters.AddWithValue("@car_id", CarSessionID)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                For Each Rows As DataRow In dt.Rows()
                    If DateTimePickerForSewaan.Value.CompareTo(Rows("rental_time_start")) = -1 And DateTimePickerForSewaan.Value.AddHours(HourTrackBar.Value).CompareTo(Rows("rental_time_start")) = -1 Or DateTimePickerForSewaan.Value.CompareTo(Rows("rental_time_end")) = 1 And DateTimePickerForSewaan.Value.AddHours(HourTrackBar.Value).CompareTo(Rows("rental_time_end")) = 1 Then
                        dateValid = True
                    Else
                        dateValid = False
                        rentalTimeStart = Rows("rental_time_start")
                        rentalTimeEnd = Rows("rental_time_end")
                        Exit For
                    End If
                Next
                If dateValid Then
                    If DialogResult.Yes = MessageBox.Show("Are you sure you want to rent at " & DateTimePickerForSewaan.Value, "Rent A Car Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) Then

                        cmd = New MySqlCommand("INSERT INTO booking_table(car_id, rental_user_ic, rental_time_start, rental_time_end) VALUES(@car_id, @rental_user_ic, @rental_time_start, @rental_time_end)", conn)
                        cmd.Parameters.AddWithValue("@car_id", CarSessionID)
                        cmd.Parameters.AddWithValue("@rental_user_ic", LoginForm.IC)
                        cmd.Parameters.AddWithValue("@rental_time_start", DateTimePickerForSewaan.Value)
                        cmd.Parameters.AddWithValue("@rental_time_end", DateTimePickerForSewaan.Value.AddHours(HourTrackBar.Value))

                        If cmd.ExecuteNonQuery() Then
                            conn.Close()
                            MessageBox.Show("You have successfully rent the car", "Rent A Car Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        End If

                    End If
                Else
                    MessageBox.Show("I'm sorry but there's someone already rent this car at " & rentalTimeStart & " which will be end at " & rentalTimeEnd, "Rental Car Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                If DialogResult.Yes = MessageBox.Show("Are you sure you want to rent at " & DateTimePickerForSewaan.Value, "Rent A Car Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) Then

                    cmd = New MySqlCommand("INSERT INTO booking_table(car_id, rental_user_ic, rental_time_start, rental_time_end) VALUES(@car_id, @rental_user_ic, @rental_time_start, @rental_time_end)", conn)
                    cmd.Parameters.AddWithValue("@car_id", CarSessionID)
                    cmd.Parameters.AddWithValue("@rental_user_ic", LoginForm.IC)
                    cmd.Parameters.AddWithValue("@rental_time_start", DateTimePickerForSewaan.Value)
                    cmd.Parameters.AddWithValue("@rental_time_end", DateTimePickerForSewaan.Value.AddHours(HourTrackBar.Value))

                    If cmd.ExecuteNonQuery() Then
                        conn.Close()
                        MessageBox.Show("You have successfully rent the car", "Rent A Car Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    End If

                End If
            End If
            conn.Close()
        Else
            MessageBox.Show("Please choose valid hour for your rental preference", "Rental Car Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub CarRentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        DateTimePickerForSewaan.MinDate = New Date.Now.ToShortDateString
        DateTimePickerForSewaan.MaxDate = New Date.Now.AddDays(7).ToShortDateString
    End Sub

    Private Sub CarRentForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        PenyewaForm.GetLoadSearchCar()
    End Sub

End Class