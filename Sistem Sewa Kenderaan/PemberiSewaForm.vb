Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient

Public Class PemberiSewaForm
    Private SessionID As String
    Private NotificationCount As Integer

    Private Sub PemberiSewaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SessionID = LoginForm.IC
        LoadCarRentData()
        CountNotification()
        LoadNotification()
    End Sub

    Private Sub CountNotification()
        Call Connect()
        cmd = New MySqlCommand("SELECT COUNT(*) FROM booking_table INNER JOIN rental_car WHERE booking_table.car_id = rental_car.car_id AND rental_car.user_id=@user_id  ", conn)
        cmd.Parameters.AddWithValue("@user_id", SessionID)
        NotificationCount = cmd.ExecuteScalar()
        conn.Close()

        If NotificationCount > 0 Then
            LblNotification.Visible = True
            LblNotification.Text = NotificationCount
        Else
            LblNotification.Visible = False
        End If

    End Sub

    Private Sub LoadNotification()
        FlowLayoutPanelHistory.Controls.Clear()
        Call Connect()
        Dim newComponent = New RentalCarComponentForPemberiSewa2()
        cmd = New MySqlCommand("SELECT * FROM booking_table INNER JOIN rental_car WHERE booking_table.car_id = rental_car.car_id AND rental_car.user_id=@user_id", conn)
        cmd.Parameters.AddWithValue("@user_id", SessionID)
        Dim dt As New DataTable
        da = New MySqlDataAdapter(cmd)
        da.Fill(dt)

        For Each Rows As DataRow In dt.Rows()
            Dim Arr() As Byte = Rows("car_image")
            Dim ms As New MemoryStream(Arr)

            newComponent = New RentalCarComponentForPemberiSewa2()
            newComponent.Name = Rows("booking_id")
            newComponent.Label4.Text = Rows("rental_user_ic") & " has rent your rental car"
            newComponent.Label5.Text = "Start: " & Rows("rental_time_start")
            newComponent.Label6.Text = "End: " & Rows("rental_time_end")
            newComponent.BackColor = ColorTranslator.FromHtml("#ecf0f1")
            newComponent.LblNamaKenderaan.Text = Rows("car_title")
            newComponent.LblJenama.Text = Rows("car_brand")
            newComponent.LblTahun.Text = Rows("car_year")
            newComponent.LblTransmisi.Text = Rows("car_transmission")
            newComponent.PictureBoxCar.Image = Image.FromStream(ms)

            AddHandler newComponent.BtnCancel.Click, AddressOf BtnCancel_Click
            AddHandler newComponent.BtnComplete.Click, AddressOf BtnComplete_Click

            FlowLayoutPanelHistory.Controls.Add(newComponent)
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
                LoadCarRentData()
                CountNotification()
                LoadNotification()
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
                LoadCarRentData()
                CountNotification()
                LoadNotification()
                conn.Close()
            End If
        End If
    End Sub

    Private Sub LoadCarRentData()
        FlowLayoutPanelCarRent.Controls.Clear()
        Dim newComponent = New RentalCarComponentForPemberiSewa()
        Call Connect()
        cmd = New MySqlCommand("SELECT * FROM rental_car WHERE user_id=@user_id", conn)
        cmd.Parameters.AddWithValue("@user_id", SessionID)
        da = New MySqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)

        For Each Rows As DataRow In dt.Rows()

            Dim Arr() As Byte = Rows("car_image")
            Dim ms As New MemoryStream(Arr)

            newComponent = New RentalCarComponentForPemberiSewa()
            newComponent.Name = Rows("car_id")
            newComponent.BackColor = ColorTranslator.FromHtml("#ecf0f1")
            newComponent.LblNamaKenderaan.Text = Rows("car_title")
            newComponent.LblJenama.Text = Rows("car_brand")
            newComponent.LblTahun.Text = Rows("car_year")
            newComponent.LblTransmisi.Text = Rows("car_transmission")
            newComponent.LblStatus.Text = Rows("car_status")
            newComponent.PictureBoxCar.Image = Image.FromStream(ms)

            AddHandler newComponent.BtnEdit.Click, AddressOf BtnEdit_Click
            AddHandler newComponent.BtnDelete.Click, AddressOf BtnDelete_Click

            FlowLayoutPanelCarRent.Controls.Add(newComponent)
        Next

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs)
        CountNotification()
        LoadCarRentData()
        LoadNotification()
        Dim Btn As Button = CType(sender, Button)

        With AddRentalCar
            .CarSessionID = Btn.Parent.Name
            .BtnAdd.Text = "EDIT"
            .BtnAdd.BackColor = ColorTranslator.FromHtml("#2980b9")
            .LabelSeparator.Visible = True
            .LblEditedDate.Visible = True
            .PanelTxt6.Visible = True
            .ShowDialog()
        End With

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs)
        CountNotification()
        LoadCarRentData()
        LoadNotification()
        Dim Btn As Button = CType(sender, Button)

        If DialogResult.Yes = MessageBox.Show("Do you really want to delete this rental car?", "Delete Rental Car", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) Then
            Call Connect()
            cmd = New MySqlCommand("DELETE FROM rental_car WHERE car_id=@car_id", conn)
            cmd.Parameters.AddWithValue("@car_id", Btn.Parent.Name)
            If cmd.ExecuteNonQuery() Then
                LoadCarRentData()
                MessageBox.Show("Successfully deleted Rental Car", "Delete Rental Car Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Public Function GetSessionID()
        Return Me.SessionID
    End Function

    Public Function GetLoadCarRentData()
        Me.LoadCarRentData()
        CountNotification()
        LoadNotification()
    End Function

    Private Sub BtnAddRentalCar_Click(sender As Object, e As EventArgs) Handles BtnAddRentalCar.Click
        CountNotification()
        LoadCarRentData()
        LoadNotification()
        With AddRentalCar
            .BtnAdd.Text = "ADD"
            .BtnAdd.BackColor = ColorTranslator.FromHtml("#27ae60")
            .LabelSeparator.Visible = False
            .LblEditedDate.Visible = False
            .PanelTxt6.Visible = False
            .ShowDialog()
        End With
    End Sub

    Private Sub BtnYourRentalCar_Click(sender As Object, e As EventArgs) Handles BtnYourRentalCar.Click
        CountNotification()
        LoadCarRentData()
        LoadNotification()
        LblYourRentalCar.Visible = True
        FlowLayoutPanelCarRent.Visible = True
        LblHistory.Visible = False
        FlowLayoutPanelHistory.Visible = False
    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles BtnHistory.Click
        CountNotification()
        LoadCarRentData()
        LoadNotification()
        LblYourRentalCar.Visible = False
        FlowLayoutPanelCarRent.Visible = False
        LblHistory.Visible = True
        FlowLayoutPanelHistory.Visible = True
    End Sub

    Private Sub PemberiSewaForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        With LoginForm
            .Show()
            .Location = Me.Location
        End With
    End Sub

End Class