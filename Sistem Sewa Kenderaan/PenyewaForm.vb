Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient

Public Class PenyewaForm
    Dim Array() As String = {"Both", "Available"}
    Dim command As String = ""

    Private Sub PenyewaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckTimeIsAlready()
        LoadSearchCar()
        LoadCarRentalHistory()
        CountNotification()
    End Sub

    Private Sub CheckTimeIsAlready()
        Dim DateNow = Date.Now
        Call Connect()

        cmd = New MySqlCommand("SELECT booking_id,car_id,rental_time_start,rental_time_end FROM booking_table", conn)
        Dim dt As New DataTable
        da = New MySqlDataAdapter(cmd)
        da.Fill(dt)

        For Each Rows As DataRow In dt.Rows()
            If DateNow.CompareTo(Rows("rental_time_end")) >= 0 Then
                cmd = New MySqlCommand("DELETE FROM booking_table WHERE booking_id=@booking_id", conn)
                cmd.Parameters.AddWithValue("@booking_id", Rows("booking_id"))
                cmd.ExecuteNonQuery()
                cmd = New MySqlCommand("UPDATE rental_car SET car_status=@car_status WHERE car_id=@car_id", conn)
                cmd.Parameters.AddWithValue("@car_id", Rows("car_id"))
                cmd.Parameters.AddWithValue("@car_status", "Available")
                cmd.ExecuteNonQuery()
            Else
                If DateNow.CompareTo(Rows("rental_time_start")) > 0 Then
                    cmd = New MySqlCommand("UPDATE rental_car SET car_status=@car_status WHERE car_id=@car_id", conn)
                    cmd.Parameters.AddWithValue("@car_id", Rows("car_id"))
                    cmd.Parameters.AddWithValue("@car_status", "Unavailable")
                    cmd.ExecuteNonQuery()
                End If
            End If
        Next

        conn.Close()
    End Sub

    Private Sub LoadCarRentalHistory()
        FlowLayoutPanelRentalHistory.Controls.Clear()
        Call Connect()
        Dim newComponent = New RentalCarComponentForPemberiSewa2()
        cmd = New MySqlCommand("SELECT * FROM booking_table INNER JOIN rental_car WHERE booking_table.car_id = rental_car.car_id AND booking_table.rental_user_ic=@rental_user_ic", conn)
        cmd.Parameters.AddWithValue("@rental_user_ic", LoginForm.IC)
        Dim dt As New DataTable
        da = New MySqlDataAdapter(cmd)
        da.Fill(dt)

        For Each Rows As DataRow In dt.Rows()
            Dim Arr() As Byte = Rows("car_image")
            Dim ms As New MemoryStream(Arr)

            newComponent = New RentalCarComponentForPemberiSewa2()
            newComponent.Name = Rows("booking_id")
            newComponent.BackColor = ColorTranslator.FromHtml("#ecf0f1")
            newComponent.Label4.Text = "You have successfully rent this car"
            newComponent.Label4.ForeColor = ColorTranslator.FromHtml("#2ecc71")
            newComponent.Label5.Text = "Start: " & Rows("rental_time_start")
            newComponent.Label6.Text = "End: " & Rows("rental_time_end")
            newComponent.LblNamaKenderaan.Text = Rows("car_title")
            newComponent.LblJenama.Text = Rows("car_brand")
            newComponent.LblTahun.Text = Rows("car_year")
            newComponent.LblTransmisi.Text = Rows("car_transmission")
            newComponent.PictureBoxCar.Image = Image.FromStream(ms)

            AddHandler newComponent.BtnCancel.Click, AddressOf BtnCancel_Click
            AddHandler newComponent.BtnComplete.Click, AddressOf BtnComplete_Click

            FlowLayoutPanelRentalHistory.Controls.Add(newComponent)
        Next

        conn.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs)
        Dim DateNow As Date = New Date.Now
        Dim ThisBtn = CType(sender, Button)

        If DialogResult.Yes = MessageBox.Show("Are you sure you want to cancel this rental process?", "Rental Car Process", MessageBoxButtons.YesNo, MessageBoxIcon.Information) Then
            Call Connect()
            cmd = New MySqlCommand("DELETE FROM booking_table WHERE booking_id=@booking_id", conn)
            cmd.Parameters.AddWithValue("@booking_id", ThisBtn.Parent.Name)
            If cmd.ExecuteNonQuery() Then
                GetLoadSearchCar()
                CountNotification()
                LoadCarRentalHistory()
                conn.Close()
            End If
        End If
    End Sub

    Private Sub BtnComplete_Click(sender As Object, e As EventArgs)
        Dim ThisBtn = CType(sender, Button)

        If DialogResult.Yes = MessageBox.Show("Are you sure you want to this rental have been completed?", "Rental Car Process", MessageBoxButtons.YesNo, MessageBoxIcon.Information) Then
            Call Connect()
            cmd = New MySqlCommand("DELETE FROM booking_table WHERE booking_id=@booking_id", conn)
            cmd.Parameters.AddWithValue("@booking_id", ThisBtn.Parent.Name)
            If cmd.ExecuteNonQuery() Then
                GetLoadSearchCar()
                CountNotification()
                LoadCarRentalHistory()
                conn.Close()
            End If
        End If
    End Sub

    Private Sub LoadSearchCar()
        FlowLayoutPanelCarRent.Controls.Clear()
        Call Connect()
        Dim newComponent As RentalCarComponentForPenyewa

        If TxtSearchBar.Text <> "" Then
            cmd = New MySqlCommand("SELECT car_id, car_title, car_brand, car_year, car_transmission, car_status, car_image FROM rental_car WHERE car_transmission LIKE " & Array(0) & " AND car_status LIKE " & Array(1) & " AND car_title LIKE '%" & TxtSearchBar.Text & "%'", conn)
        Else
            cmd = New MySqlCommand("SELECT car_id, car_title, car_brand, car_year, car_transmission, car_status, car_image FROM rental_car WHERE car_transmission LIKE " & Array(0) & " AND car_status LIKE " & Array(1), conn)
        End If

        da = New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()

        For Each Rows As DataRow In dt.Rows()

            Dim Arr() As Byte = Rows("car_image")
            Dim ms As New MemoryStream(Arr)

            newComponent = New RentalCarComponentForPenyewa()
            newComponent.Name = Rows("car_id")
            newComponent.BackColor = ColorTranslator.FromHtml("#ecf0f1")
            newComponent.LblNamaKenderaan.Text = Rows("car_title")
            newComponent.LblJenama.Text = Rows("car_brand")
            newComponent.LblTahun.Text = Rows("car_year")
            newComponent.LblTransmisi.Text = Rows("car_transmission")
            newComponent.LblStatus.Text = Rows("car_status")
            newComponent.CarPictureBox.Image = Image.FromStream(ms)

            AddHandler newComponent.BtnSemakLanjut.Click, AddressOf BtnSemakLanjut_Click

            FlowLayoutPanelCarRent.Controls.Add(newComponent)

        Next

    End Sub

    Public Function GetLoadSearchCar()
        CountNotification()
        LoadSearchCar()
        CheckTimeIsAlready()
        LoadCarRentalHistory()
    End Function

    Private Sub BtnSemakLanjut_Click(sender As Object, e As EventArgs)
        CheckTimeIsAlready()
        Dim ThisBtn = CType(sender, Button)

        With CarRentForm
            CarRentForm.CarSessionID = ThisBtn.Parent.Name
            .ShowDialog()
        End With
        GetLoadSearchCar()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        GetLoadSearchCar()
    End Sub

    Private Sub CmBoxTransmission_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmBoxTransmission.SelectedValueChanged
        Dim ThisComboBox As ComboBox = CType(sender, ComboBox)

        Select Case ThisComboBox.Text
            Case "Both"
                Array(0) = "'%'"
            Case "Auto"
                Array(0) = "'Auto%'"
            Case "Manual"
                Array(0) = "'Manual%'"
        End Select

    End Sub

    Private Sub CmBoxStatus_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmBoxStatus.SelectedValueChanged
        Dim ThisComboBox As ComboBox = CType(sender, ComboBox)

        Select Case ThisComboBox.Text
            Case "Both"
                Array(1) = "'%'"
            Case "Available"
                Array(1) = "'Available%'"
            Case "Unavailable"
                Array(1) = "'Unavailable%'"
        End Select
    End Sub

    Private Sub PenyewaForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        With LoginForm
            .Show()
            .Location = Me.Location
        End With
    End Sub

    Private Sub RentHistoryButton_Click(sender As Object, e As EventArgs) Handles RentHistoryButton.Click
        FlowLayoutPanelRentalHistory.Visible = True
        LblRentalHistory.Visible = True
        FlowLayoutPanelCarRent.Visible = False
        CmBoxStatus.Visible = False
        CmBoxTransmission.Visible = False
        PanelSearchBar.Visible = False
        BtnSearch.Visible = False
        GetLoadSearchCar()
    End Sub

    Private Sub SearchCarButton_Click(sender As Object, e As EventArgs) Handles SearchCarButton.Click
        FlowLayoutPanelCarRent.Visible = True
        CmBoxStatus.Visible = True
        CmBoxTransmission.Visible = True
        PanelSearchBar.Visible = True
        BtnSearch.Visible = True
        FlowLayoutPanelRentalHistory.Visible = False
        LblRentalHistory.Visible = False
        GetLoadSearchCar()
    End Sub

    Private Sub CountNotification()
        Call Connect()
        cmd = New MySqlCommand("SELECT COUNT(*) FROM booking_table WHERE rental_user_ic=@rental_user_ic", conn)
        cmd.Parameters.AddWithValue("@rental_user_ic", LoginForm.IC)
        Dim NotificationCount = cmd.ExecuteScalar()
        conn.Close()

        If NotificationCount > 0 Then
            LblNotification.Visible = True
            LblNotification.Text = NotificationCount
        Else
            LblNotification.Visible = False
        End If

    End Sub

End Class