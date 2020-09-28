<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationCode
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
        Me.TxtRegistrationCode = New System.Windows.Forms.TextBox()
        Me.LblRegistrationCode = New System.Windows.Forms.Label()
        Me.BtnRegisterCompleted = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtRegistrationCode
        '
        Me.TxtRegistrationCode.BackColor = System.Drawing.Color.White
        Me.TxtRegistrationCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtRegistrationCode.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRegistrationCode.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TxtRegistrationCode.Location = New System.Drawing.Point(3, 3)
        Me.TxtRegistrationCode.Name = "TxtRegistrationCode"
        Me.TxtRegistrationCode.Size = New System.Drawing.Size(267, 22)
        Me.TxtRegistrationCode.TabIndex = 0
        '
        'LblRegistrationCode
        '
        Me.LblRegistrationCode.AutoSize = True
        Me.LblRegistrationCode.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegistrationCode.ForeColor = System.Drawing.SystemColors.Control
        Me.LblRegistrationCode.Location = New System.Drawing.Point(103, 31)
        Me.LblRegistrationCode.Name = "LblRegistrationCode"
        Me.LblRegistrationCode.Size = New System.Drawing.Size(156, 23)
        Me.LblRegistrationCode.TabIndex = 1
        Me.LblRegistrationCode.Text = "Registration Code"
        '
        'BtnRegisterCompleted
        '
        Me.BtnRegisterCompleted.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.BtnRegisterCompleted.FlatAppearance.BorderSize = 0
        Me.BtnRegisterCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegisterCompleted.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 9.0!)
        Me.BtnRegisterCompleted.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnRegisterCompleted.Location = New System.Drawing.Point(107, 110)
        Me.BtnRegisterCompleted.Name = "BtnRegisterCompleted"
        Me.BtnRegisterCompleted.Size = New System.Drawing.Size(152, 34)
        Me.BtnRegisterCompleted.TabIndex = 19
        Me.BtnRegisterCompleted.Text = "Register Complete"
        Me.BtnRegisterCompleted.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TxtRegistrationCode)
        Me.Panel1.Location = New System.Drawing.Point(42, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(273, 31)
        Me.Panel1.TabIndex = 20
        '
        'RegistrationCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(372, 169)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnRegisterCompleted)
        Me.Controls.Add(Me.LblRegistrationCode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "RegistrationCode"
        Me.Text = "Code Registration"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtRegistrationCode As TextBox
    Friend WithEvents LblRegistrationCode As Label
    Friend WithEvents BtnRegisterCompleted As Button
    Friend WithEvents Panel1 As Panel
End Class
