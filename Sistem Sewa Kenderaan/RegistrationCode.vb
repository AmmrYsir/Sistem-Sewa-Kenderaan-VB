Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class RegistrationCode

    Private Sub BtnRegisterCompleted_Click(sender As Object, e As EventArgs) Handles BtnRegisterCompleted.Click
        If TxtRegistrationCode.Text <> String.Empty Then
            Call Connect()
            cmd = New MySqlCommand("SELECT key_code, key_usability FROM registration_code WHERE key_code=@key_code", conn)
            cmd.Parameters.AddWithValue("@key_code", TxtRegistrationCode.Text)
            da = New MySqlDataAdapter(cmd)
            dr = cmd.ExecuteReader()

            If dr.HasRows() Then
                dr.Close()

                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                Dim keyCode As String = dt.Rows(0).Item(0)
                Dim keyUseability As Integer = dt.Rows(0).Item(1)

                If keyUseability <> 0 Then
                    cmd = New MySqlCommand("INSERT INTO user_table(ic_number, nama_penuh, password, number_phone, umur, alamat_penuh, email_address, rank) VALUES(@ic_number, @nama_penuh, @password, @number_phone, @umur, @alamat_penuh, @email_address, @rank)", conn)
                    cmd.Parameters.AddWithValue("@ic_number", RegisterForm.TxtICNumber.Text)
                    cmd.Parameters.AddWithValue("@nama_penuh", RegisterForm.TxtFullName.Text)
                    cmd.Parameters.AddWithValue("@password", RegisterForm.TxtPassword.Text)
                    cmd.Parameters.AddWithValue("@number_phone", RegisterForm.TxtNomborTelefon.Text)
                    cmd.Parameters.AddWithValue("@umur", RegisterForm.TxtUmur.Text)
                    cmd.Parameters.AddWithValue("@alamat_penuh", RegisterForm.TxtAlamatPenuh.Text)
                    cmd.Parameters.AddWithValue("@email_address", RegisterForm.TxtEmailAddress.Text)
                    cmd.Parameters.AddWithValue("@rank", 2)
                    If cmd.ExecuteNonQuery() Then
                        If RegisterForm.RBtnStudent.Checked Then
                            cmd = New MySqlCommand("INSERT INTO pelajar_table(ic_number, kad_matrik, jurusan) VALUES(@ic_number, @kad_matrik, @jurusan)", conn)
                            cmd.Parameters.AddWithValue("@ic_number", RegisterForm.TxtICNumber.Text)
                            cmd.Parameters.AddWithValue("@kad_matrik", RegisterForm.TxtKadMatrik.Text)
                            cmd.Parameters.AddWithValue("@jurusan", RegisterForm.TxtJurusan.Text)
                            cmd.ExecuteNonQuery()
                        End If

                        cmd = New MySqlCommand("UPDATE registration_code SET key_usability=@key_usability, key_user=@key_user WHERE key_code=@key_code", conn)
                        cmd.Parameters.AddWithValue("@key_code", keyCode)
                        cmd.Parameters.AddWithValue("@key_user", RegisterForm.TxtICNumber.Text)
                        cmd.Parameters.AddWithValue("@key_usability", keyUseability = keyUseability - 1)
                        cmd.ExecuteNonQuery()

                        With LoginForm
                            .Show()
                            .Location = Me.Location
                            RegisterForm.Close()
                            RegisterConfirmationForm.Close()
                            Me.Close()
                        End With
                        MessageBox.Show("You have successfully registered as Pemberi Sewa", "Register Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Key already been used", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Please enter valid Registration Code", "Invalid Registration Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            conn.Close()
        End If
    End Sub

    Private Sub RegistrationCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RegistrationCode_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        With RegisterConfirmationForm
            .Show()
            .Location = Me.Location
        End With
    End Sub

End Class