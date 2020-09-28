Imports System.ComponentModel
Imports System.IO
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class RegisterForm

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        If ValidateAll() Then
            With RegisterConfirmationForm
                .Show()
                .Location = Me.Location
                Me.Hide()
            End With
        End If
    End Sub

    Private Function ValidateAll()
        If Not isEmpty() Then
            If TxtPassword.Text = TxtConfirmationPassword.Text Then
                If NotDuplicateIC() Then
                    Return True
                Else
                    MessageBox.Show("The IC Number have been registered", "Registration Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            Else
                MessageBox.Show("Please check your password carefully", "Registration Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Else
            MessageBox.Show("Please do not leave anything blank", "Registration Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function

    Private Function NotDuplicateIC()
        Call Connect()
        cmd = New MySqlCommand("SELECT ic_number FROM user_table WHERE ic_number=@ic_number", conn)
        cmd.Parameters.AddWithValue("@ic_number", TxtICNumber.Text)
        dr = cmd.ExecuteReader()

        If dr.HasRows() Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function isEmpty()
        If TxtICNumber.Text = "" Or TxtFullName.Text = "" Or TxtPassword.Text = "" Or TxtConfirmationPassword.Text = "" Or TxtNomborTelefon.Text = "" Or TxtUmur.Text = "" Or TxtAlamatPenuh.Text = "" Or TxtEmailAddress.Text = "" Then
            If RBtnStudent.Checked Then
                If TxtKadMatrik.Text = "" Or TxtJurusan.Text = "" Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return True
            End If
        Else Return False
        End If
    End Function

    Private Sub RBtnStudent_Click(sender As Object, e As EventArgs) Handles RBtnStudent.Click, RBtnNotStudent.Click
        Dim RadioButton As RadioButton
        RadioButton = CType(sender, RadioButton)

        Select Case RadioButton.Name
            Case "RBtnStudent"
                RBtnStudent.Checked = True
                GrpBoxMaklumatPelajar.Visible = True
            Case "RBtnNotStudent"
                RBtnNotStudent.Checked = True
                GrpBoxMaklumatPelajar.Visible = False
            Case Else
                RBtnStudent.Checked = True
        End Select
    End Sub

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RBtnPenyewa.Checked = True
        RBtnStudent.Checked = True
    End Sub

    Private Sub RegisterForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        With LoginForm
            .Show()
            .Location = Me.Location
        End With
    End Sub

End Class