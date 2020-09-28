<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Lbl_IC_Number = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.PanelTextBox2 = New System.Windows.Forms.Panel()
        Me.TxtICNumber = New System.Windows.Forms.TextBox()
        Me.PanelTextBox1 = New System.Windows.Forms.Panel()
        Me.BtnLogIn = New System.Windows.Forms.Button()
        Me.LinkLabelRegister = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelTextBox2.SuspendLayout()
        Me.PanelTextBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtPassword.Location = New System.Drawing.Point(12, 12)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(282, 30)
        Me.TxtPassword.TabIndex = 1
        '
        'Lbl_IC_Number
        '
        Me.Lbl_IC_Number.AutoSize = True
        Me.Lbl_IC_Number.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_IC_Number.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Lbl_IC_Number.Location = New System.Drawing.Point(164, 114)
        Me.Lbl_IC_Number.Name = "Lbl_IC_Number"
        Me.Lbl_IC_Number.Size = New System.Drawing.Size(133, 31)
        Me.Lbl_IC_Number.TabIndex = 3
        Me.Lbl_IC_Number.Text = "IC Number"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LblPassword.Location = New System.Drawing.Point(164, 227)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(118, 31)
        Me.LblPassword.TabIndex = 4
        Me.LblPassword.Text = "Password"
        '
        'PanelTextBox2
        '
        Me.PanelTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelTextBox2.Controls.Add(Me.TxtPassword)
        Me.PanelTextBox2.Location = New System.Drawing.Point(170, 261)
        Me.PanelTextBox2.Name = "PanelTextBox2"
        Me.PanelTextBox2.Size = New System.Drawing.Size(309, 58)
        Me.PanelTextBox2.TabIndex = 5
        '
        'TxtICNumber
        '
        Me.TxtICNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtICNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtICNumber.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtICNumber.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtICNumber.Location = New System.Drawing.Point(12, 12)
        Me.TxtICNumber.Name = "TxtICNumber"
        Me.TxtICNumber.Size = New System.Drawing.Size(282, 30)
        Me.TxtICNumber.TabIndex = 0
        '
        'PanelTextBox1
        '
        Me.PanelTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelTextBox1.Controls.Add(Me.TxtICNumber)
        Me.PanelTextBox1.Location = New System.Drawing.Point(170, 148)
        Me.PanelTextBox1.Name = "PanelTextBox1"
        Me.PanelTextBox1.Size = New System.Drawing.Size(309, 58)
        Me.PanelTextBox1.TabIndex = 6
        '
        'BtnLogIn
        '
        Me.BtnLogIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnLogIn.FlatAppearance.BorderSize = 0
        Me.BtnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogIn.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogIn.Location = New System.Drawing.Point(170, 365)
        Me.BtnLogIn.Name = "BtnLogIn"
        Me.BtnLogIn.Size = New System.Drawing.Size(309, 62)
        Me.BtnLogIn.TabIndex = 2
        Me.BtnLogIn.Text = "LOG IN"
        Me.BtnLogIn.UseVisualStyleBackColor = False
        '
        'LinkLabelRegister
        '
        Me.LinkLabelRegister.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LinkLabelRegister.AutoSize = True
        Me.LinkLabelRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LinkLabelRegister.LinkColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LinkLabelRegister.Location = New System.Drawing.Point(167, 336)
        Me.LinkLabelRegister.Name = "LinkLabelRegister"
        Me.LinkLabelRegister.Size = New System.Drawing.Size(251, 17)
        Me.LinkLabelRegister.TabIndex = 8
        Me.LinkLabelRegister.TabStop = True
        Me.LinkLabelRegister.Text = "You haven't registered yet? Click here!"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(170, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 35)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CARRent"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(662, 439)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabelRegister)
        Me.Controls.Add(Me.BtnLogIn)
        Me.Controls.Add(Me.PanelTextBox1)
        Me.Controls.Add(Me.PanelTextBox2)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.Lbl_IC_Number)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.Text = "CARRENT | Login "
        Me.PanelTextBox2.ResumeLayout(False)
        Me.PanelTextBox2.PerformLayout()
        Me.PanelTextBox1.ResumeLayout(False)
        Me.PanelTextBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Lbl_IC_Number As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents PanelTextBox2 As Panel
    Friend WithEvents TxtICNumber As TextBox
    Friend WithEvents PanelTextBox1 As Panel
    Friend WithEvents BtnLogIn As Button
    Friend WithEvents LinkLabelRegister As LinkLabel
    Friend WithEvents Label1 As Label
End Class
