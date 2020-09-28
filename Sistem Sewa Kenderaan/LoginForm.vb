Imports MySql.Data.MySqlClient

Public Class LoginForm
    Public IC As String
    Private rank As Integer
    Dim dr As MySqlDataReader

    Private Sub BtnLogIn_Click(sender As Object, e As EventArgs) Handles BtnLogIn.Click
        If ValidateLogin() Then
            Select Case rank
                Case 1
                    With PenyewaForm
                        .Show()
                        .Location = Me.Location
                        Me.Hide()
                    End With
                Case 2
                    With PemberiSewaForm
                        .Show()
                        .Location = Me.Location
                        Me.Hide()
                    End With
                Case 3
                    With AdminForm
                        .Show()
                        .Location = Me.Location
                        Me.Hide()
                    End With
            End Select
        Else
            MessageBox.Show("Please enter a valid IC Number Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function ValidateLogin()
        If TxtICNumber.Text = "" Or TxtPassword.Text = "" Then
            Return False
        Else
            Call Connect()
            cmd = New MySqlCommand("SELECT rank FROM user_table WHERE ic_number=@user_id AND password=@password", conn)
            cmd.Parameters.AddWithValue("@user_id", TxtICNumber.Text)
            cmd.Parameters.AddWithValue("@password", TxtPassword.Text)
            dr = cmd.ExecuteReader()
            If dr.HasRows() Then
                dr.Close()
                IC = TxtICNumber.Text
                rank = cmd.ExecuteScalar()
                conn.Close()
                Return True
            End If
        End If
    End Function

    Private Sub LinkLabelRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelRegister.LinkClicked
        With RegisterForm
            .Show()
            .Location = Me.Location
            Me.Hide()
        End With
    End Sub

End Class