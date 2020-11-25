Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class RegisterConfirmationForm

    Private Sub BtnRegisterPemberiSewa_Click(sender As Object, e As EventArgs) Handles BtnRegisterPemberiSewa.Click

        If ChkBoxTermsAndConditions.Checked Then

            Call Connect()
            cmd = New MySqlCommand("INSERT INTO user_table(ic_number, nama_penuh, password, number_phone, umur, alamat_penuh, email_address, rank) VALUES(@ic_number, @nama_penuh, @password, @number_phone, @umur, @alamat_penuh, @email_address, @rank)", conn)
            cmd.Parameters.AddWithValue("@ic_number", RegisterForm.TxtICNumber.Text)
            cmd.Parameters.AddWithValue("@nama_penuh", RegisterForm.TxtFullName.Text)
            cmd.Parameters.AddWithValue("@password", RegisterForm.TxtPassword.Text)
            cmd.Parameters.AddWithValue("@number_phone", RegisterForm.TxtNomborTelefon.Text)
            cmd.Parameters.AddWithValue("@umur", RegisterForm.TxtUmur.Text)
            cmd.Parameters.AddWithValue("@alamat_penuh", RegisterForm.TxtAlamatPenuh.Text)
            cmd.Parameters.AddWithValue("@email_address", RegisterForm.TxtEmailAddress.Text)

            If RegisterForm.RBtnPenyewa.Checked Then
                cmd.Parameters.AddWithValue("@rank", 1)
                If cmd.ExecuteNonQuery() Then
                    If RegisterForm.RBtnStudent.Checked Then
                        cmd = New MySqlCommand("INSERT INTO pelajar_table(ic_number, kad_matrik, jurusan) VALUES(@ic_number, @kad_matrik, @jurusan)", conn)
                        cmd.Parameters.AddWithValue("@ic_number", RegisterForm.TxtICNumber.Text)
                        cmd.Parameters.AddWithValue("@kad_matrik", RegisterForm.TxtICNumber.Text)
                        cmd.Parameters.AddWithValue("@jurusan", RegisterForm.TxtJurusan.Text)
                        cmd.ExecuteNonQuery()
                    End If

                    With LoginForm
                        .Show()
                        .Location = Me.Location
                        Me.Close()
                    End With

                    RegisterForm.Close()

                    MessageBox.Show("You have successfully registered", "Register Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            If RegisterForm.RBtnPemberiSewa.Checked Then
                With RegistrationCode
                    .Show()
                    .Location = Me.Location
                    Me.Hide()
                End With
            End If

            conn.Close()
        Else
            MessageBox.Show("Please agree to our terms and conditions to register account!", "Terms and Conditions Agreement", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub

    Private Sub RegisterConfirmationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RegisterConfirmationForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        With RegisterForm
            .Show()
            .Location = Me.Location
        End With
    End Sub

End Class