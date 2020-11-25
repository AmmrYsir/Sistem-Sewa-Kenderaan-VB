Imports System.ComponentModel
Imports System.Runtime.Remoting.Channels
Imports System.Xml
Imports MySql.Data.MySqlClient

Public Class AdminForm

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataKey()
    End Sub

    Private Sub CleanDataKey()
        FlowLayoutPanelRegistrationKey.Controls.Clear()
    End Sub

    Private Sub LoadDataKey()
        CleanDataKey()
        Call Connect()
        cmd = New MySqlCommand("SELECT * FROM registration_code", conn)
        da = New MySqlDataAdapter(cmd)
        Dim dt = New DataTable
        da.Fill(dt)

        For Each Rows As DataRow In dt.Rows()

            Dim newComponent = New RegistrationCodeComponent()
            newComponent.Name = Rows("key_id")
            newComponent.BackColor = ColorTranslator.FromHtml("#e74c3c")
            newComponent.TxtRegistrationCode.Text = Rows("key_code")
            newComponent.LblOwnerName.Text = Rows("key_user").ToString()
            AddHandler newComponent.TxtRegistrationCode.Click, AddressOf newComponent_Click
            AddHandler newComponent.BtnDiscard.Click, AddressOf newComponentButton_Click
            FlowLayoutPanelRegistrationKey.Controls.Add(newComponent)

        Next

        conn.Close()

    End Sub

    Private Sub newComponentButton_Click(sender As Object, e As EventArgs)
        Dim ThisBtn As Button
        ThisBtn = CType(sender, Button)
        If DialogResult.Yes = MessageBox.Show("Are you sure you want to discard this key?", "Delete key confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            Call Connect()
            cmd = New MySqlCommand("DELETE FROM registration_code WHERE key_id=@key_id", conn)
            cmd.Parameters.AddWithValue("@key_id", ThisBtn.Parent.Name)
            If cmd.ExecuteNonQuery() Then
                LoadDataKey()
            End If
            conn.Close()
        End If
    End Sub

    Private Sub newComponent_Click(sender As Object, e As EventArgs)
        Dim Txt = CType(sender, TextBox)

        Call Connect()
        cmd = New MySqlCommand("SELECT * FROM registration_code WHERE key_id=@key_id", conn)
        cmd.Parameters.AddWithValue("@key_id", Txt.Parent.Parent.Name)
        da = New MySqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)
        conn.Close()

        Dim Rows As DataRow = dt.Rows(0)

        TxtKeyId.Text = Rows("key_id")
        If IsDBNull(Rows("key_user")) Then
            TxtKeyUser.Text = ""
        Else
            TxtKeyUser.Text = Rows("key_user")
        End If

        TxtKeyCode.Text = Rows("key_code")
        TxtKeyCreatedDate.Text = Rows("key_created_date")
        TxtKeyStatus.Text = Rows("key_status")
        TxtKeyUseability.Text = Rows("key_usability")

    End Sub

    Private Sub BtnGenerateKeyCode_Click(sender As Object, e As EventArgs) Handles BtnGenerateKeyCode.Click

        Call Connect()
        cmd = New MySqlCommand("INSERT INTO registration_code(key_code) VALUES(@key_code)", conn)
        cmd.Parameters.AddWithValue("@key_code", GenerateUUIDCar())
        If cmd.ExecuteNonQuery() Then
            LoadDataKey()
        End If
        conn.Close()

    End Sub

    Private Function GenerateUUIDCar()
        Dim Random = New Random
        Dim Ciphertext As String = ""
        For I As Integer = 0 To 6
            Dim number As Integer = Random.Next(65, 90)
            Dim cipher As Char = Chr(number)
            Ciphertext += cipher
        Next
        Return "KYPJ" & GenerateKey(Random) & Ciphertext
    End Function

    Function GenerateKey(random)
        Dim NumberString As String = "0"
        For I As Integer = 0 To 4
            Dim number = random.Next(0, 9)
            NumberString += number.ToString()
        Next
        Return NumberString
    End Function

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Call Connect()
        cmd = New MySqlCommand("UPDATE registration_code SET key_status=@key_status, key_usability=@key_usability WHERE key_id=@key_id", conn)
        cmd.Parameters.AddWithValue("@key_id", TxtKeyId.Text)
        cmd.Parameters.AddWithValue("@key_status", TxtKeyStatus.Text)
        cmd.Parameters.AddWithValue("@key_usability", TxtKeyUseability.Text)
        If cmd.ExecuteNonQuery() Then
            LoadDataKey()
        End If
        conn.Close()
    End Sub

    Private Sub AdminForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        With LoginForm
            .Show()
            .Location = Me.Location
        End With
    End Sub

End Class