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
    End Sub

    Private Sub CheckTimeIsAlready()
        Dim DateNow = Date.Now
        Call Connect()

        cmd = New MySqlCommand("SELECT rental_time_end FROM rental_car", conn)
        Dim dt As New DataTable
        da = New MySqlDataAdapter(cmd)
        da.Fill(dt)

        For Each Rows As DataRow In dt.Rows()
            If DateNow.CompareTo(Rows("rental_time_end")) >= 0 Then
                cmd = New MySqlCommand("UPDATE rental_car SET car_status=@car_status, rental_time_start=@rental_time_start, rental_time_end=@rental_time_end WHERE rental_time_end=@rental_time_end_session", conn)
                cmd.Parameters.AddWithValue("@rental_time_end_session", Rows("rental_time_end"))
                cmd.Parameters.AddWithValue("@car_status", "Available")
                cmd.Parameters.AddWithValue("@rental_time_start", DateNow)
                cmd.Parameters.AddWithValue("@rental_time_end", DateNow)
                cmd.ExecuteNonQuery()
            End If
        Next

        conn.Close()
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

    Public Function GetLoadSarchCar()
        LoadSearchCar()
        CheckTimeIsAlready()
    End Function

    Private Sub BtnSemakLanjut_Click(sender As Object, e As EventArgs)
        Dim ThisBtn = CType(sender, Button)
        Dim Today As Date = New Date.Now

        Call Connect()
        cmd = New MySqlCommand("SELECT rental_time_end FROM rental_car WHERE car_id=@car_id", conn)
        cmd.Parameters.AddWithValue("@car_id", ThisBtn.Parent.Name)
        Dim rentalTimeEnd = cmd.ExecuteScalar()
        conn.Close()

        If Today.CompareTo(rentalTimeEnd) < 0 Then
            MessageBox.Show("This car already been booked until " & rentalTimeEnd, "Rent A Car Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            With CarRentForm
                CarRentForm.CarSessionID = ThisBtn.Parent.Name
                .ShowDialog()
            End With
        End If

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        LoadSearchCar()
        CheckTimeIsAlready()
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

End Class