<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.FlowLayoutPanelRegistrationKey = New System.Windows.Forms.FlowLayoutPanel()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnGenerateKeyCode = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtKeyStatus = New System.Windows.Forms.ComboBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.PanelTxt2 = New System.Windows.Forms.Panel()
        Me.TxtKeyUser = New System.Windows.Forms.TextBox()
        Me.LblKeyUser = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelTxt6 = New System.Windows.Forms.Panel()
        Me.TxtKeyUseability = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelTxt4 = New System.Windows.Forms.Panel()
        Me.TxtKeyCreatedDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelTxt3 = New System.Windows.Forms.Panel()
        Me.TxtKeyCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelTxt1 = New System.Windows.Forms.Panel()
        Me.TxtKeyId = New System.Windows.Forms.TextBox()
        Me.LblKeyID = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.PanelTxt2.SuspendLayout()
        Me.PanelTxt6.SuspendLayout()
        Me.PanelTxt4.SuspendLayout()
        Me.PanelTxt3.SuspendLayout()
        Me.PanelTxt1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanelRegistrationKey
        '
        Me.FlowLayoutPanelRegistrationKey.AutoScroll = True
        Me.FlowLayoutPanelRegistrationKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanelRegistrationKey.Location = New System.Drawing.Point(48, 66)
        Me.FlowLayoutPanelRegistrationKey.Name = "FlowLayoutPanelRegistrationKey"
        Me.FlowLayoutPanelRegistrationKey.Size = New System.Drawing.Size(636, 530)
        Me.FlowLayoutPanelRegistrationKey.TabIndex = 0
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.LblTitle.Location = New System.Drawing.Point(51, 27)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(490, 36)
        Me.LblTitle.TabIndex = 1
        Me.LblTitle.Text = "REGISTRATION KEY MANAGEMENT"
        '
        'BtnGenerateKeyCode
        '
        Me.BtnGenerateKeyCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.BtnGenerateKeyCode.FlatAppearance.BorderSize = 0
        Me.BtnGenerateKeyCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGenerateKeyCode.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerateKeyCode.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnGenerateKeyCode.Location = New System.Drawing.Point(720, 66)
        Me.BtnGenerateKeyCode.Name = "BtnGenerateKeyCode"
        Me.BtnGenerateKeyCode.Size = New System.Drawing.Size(132, 147)
        Me.BtnGenerateKeyCode.TabIndex = 2
        Me.BtnGenerateKeyCode.Text = "Generate New Registration key"
        Me.BtnGenerateKeyCode.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtKeyStatus)
        Me.GroupBox1.Controls.Add(Me.BtnUpdate)
        Me.GroupBox1.Controls.Add(Me.PanelTxt2)
        Me.GroupBox1.Controls.Add(Me.LblKeyUser)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.PanelTxt6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PanelTxt4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PanelTxt3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PanelTxt1)
        Me.GroupBox1.Controls.Add(Me.LblKeyID)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(704, 237)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 359)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Key Manager"
        '
        'TxtKeyStatus
        '
        Me.TxtKeyStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtKeyStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TxtKeyStatus.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKeyStatus.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtKeyStatus.FormattingEnabled = True
        Me.TxtKeyStatus.Items.AddRange(New Object() {"On", "Off"})
        Me.TxtKeyStatus.Location = New System.Drawing.Point(234, 219)
        Me.TxtKeyStatus.Name = "TxtKeyStatus"
        Me.TxtKeyStatus.Size = New System.Drawing.Size(115, 31)
        Me.TxtKeyStatus.TabIndex = 0
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnUpdate.FlatAppearance.BorderSize = 0
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnUpdate.Location = New System.Drawing.Point(222, 280)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(127, 63)
        Me.BtnUpdate.TabIndex = 40
        Me.BtnUpdate.Text = "UPDATE"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'PanelTxt2
        '
        Me.PanelTxt2.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelTxt2.Controls.Add(Me.TxtKeyUser)
        Me.PanelTxt2.Location = New System.Drawing.Point(157, 56)
        Me.PanelTxt2.Name = "PanelTxt2"
        Me.PanelTxt2.Size = New System.Drawing.Size(192, 37)
        Me.PanelTxt2.TabIndex = 32
        '
        'TxtKeyUser
        '
        Me.TxtKeyUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtKeyUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtKeyUser.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!)
        Me.TxtKeyUser.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtKeyUser.Location = New System.Drawing.Point(3, 8)
        Me.TxtKeyUser.Name = "TxtKeyUser"
        Me.TxtKeyUser.ReadOnly = True
        Me.TxtKeyUser.Size = New System.Drawing.Size(186, 22)
        Me.TxtKeyUser.TabIndex = 5
        Me.TxtKeyUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblKeyUser
        '
        Me.LblKeyUser.AutoSize = True
        Me.LblKeyUser.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.LblKeyUser.ForeColor = System.Drawing.SystemColors.Control
        Me.LblKeyUser.Location = New System.Drawing.Point(156, 30)
        Me.LblKeyUser.Name = "LblKeyUser"
        Me.LblKeyUser.Size = New System.Drawing.Size(76, 23)
        Me.LblKeyUser.TabIndex = 30
        Me.LblKeyUser.Text = "Key User"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(230, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 23)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Key Status"
        '
        'PanelTxt6
        '
        Me.PanelTxt6.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelTxt6.Controls.Add(Me.TxtKeyUseability)
        Me.PanelTxt6.Location = New System.Drawing.Point(13, 306)
        Me.PanelTxt6.Name = "PanelTxt6"
        Me.PanelTxt6.Size = New System.Drawing.Size(113, 37)
        Me.PanelTxt6.TabIndex = 37
        '
        'TxtKeyUseability
        '
        Me.TxtKeyUseability.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtKeyUseability.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtKeyUseability.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!)
        Me.TxtKeyUseability.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtKeyUseability.Location = New System.Drawing.Point(3, 8)
        Me.TxtKeyUseability.Name = "TxtKeyUseability"
        Me.TxtKeyUseability.Size = New System.Drawing.Size(107, 22)
        Me.TxtKeyUseability.TabIndex = 5
        Me.TxtKeyUseability.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(12, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 23)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Key Useability"
        '
        'PanelTxt4
        '
        Me.PanelTxt4.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelTxt4.Controls.Add(Me.TxtKeyCreatedDate)
        Me.PanelTxt4.Location = New System.Drawing.Point(13, 219)
        Me.PanelTxt4.Name = "PanelTxt4"
        Me.PanelTxt4.Size = New System.Drawing.Size(215, 37)
        Me.PanelTxt4.TabIndex = 35
        '
        'TxtKeyCreatedDate
        '
        Me.TxtKeyCreatedDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtKeyCreatedDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtKeyCreatedDate.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!)
        Me.TxtKeyCreatedDate.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtKeyCreatedDate.Location = New System.Drawing.Point(3, 8)
        Me.TxtKeyCreatedDate.Name = "TxtKeyCreatedDate"
        Me.TxtKeyCreatedDate.ReadOnly = True
        Me.TxtKeyCreatedDate.Size = New System.Drawing.Size(209, 22)
        Me.TxtKeyCreatedDate.TabIndex = 5
        Me.TxtKeyCreatedDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(12, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 23)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Key Created Date"
        '
        'PanelTxt3
        '
        Me.PanelTxt3.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelTxt3.Controls.Add(Me.TxtKeyCode)
        Me.PanelTxt3.Location = New System.Drawing.Point(13, 136)
        Me.PanelTxt3.Name = "PanelTxt3"
        Me.PanelTxt3.Size = New System.Drawing.Size(336, 37)
        Me.PanelTxt3.TabIndex = 33
        '
        'TxtKeyCode
        '
        Me.TxtKeyCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtKeyCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtKeyCode.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!)
        Me.TxtKeyCode.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtKeyCode.Location = New System.Drawing.Point(3, 8)
        Me.TxtKeyCode.Name = "TxtKeyCode"
        Me.TxtKeyCode.ReadOnly = True
        Me.TxtKeyCode.Size = New System.Drawing.Size(330, 22)
        Me.TxtKeyCode.TabIndex = 5
        Me.TxtKeyCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(12, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 23)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Key Code"
        '
        'PanelTxt1
        '
        Me.PanelTxt1.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelTxt1.Controls.Add(Me.TxtKeyId)
        Me.PanelTxt1.Location = New System.Drawing.Point(13, 56)
        Me.PanelTxt1.Name = "PanelTxt1"
        Me.PanelTxt1.Size = New System.Drawing.Size(138, 37)
        Me.PanelTxt1.TabIndex = 29
        '
        'TxtKeyId
        '
        Me.TxtKeyId.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtKeyId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtKeyId.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!)
        Me.TxtKeyId.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtKeyId.Location = New System.Drawing.Point(3, 8)
        Me.TxtKeyId.Name = "TxtKeyId"
        Me.TxtKeyId.ReadOnly = True
        Me.TxtKeyId.Size = New System.Drawing.Size(132, 22)
        Me.TxtKeyId.TabIndex = 5
        Me.TxtKeyId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblKeyID
        '
        Me.LblKeyID.AutoSize = True
        Me.LblKeyID.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.0!)
        Me.LblKeyID.ForeColor = System.Drawing.SystemColors.Control
        Me.LblKeyID.Location = New System.Drawing.Point(12, 30)
        Me.LblKeyID.Name = "LblKeyID"
        Me.LblKeyID.Size = New System.Drawing.Size(58, 23)
        Me.LblKeyID.TabIndex = 28
        Me.LblKeyID.Text = "Key ID"
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1082, 623)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnGenerateKeyCode)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.FlowLayoutPanelRegistrationKey)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AdminForm"
        Me.Text = "HEP Interaction"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelTxt2.ResumeLayout(False)
        Me.PanelTxt2.PerformLayout()
        Me.PanelTxt6.ResumeLayout(False)
        Me.PanelTxt6.PerformLayout()
        Me.PanelTxt4.ResumeLayout(False)
        Me.PanelTxt4.PerformLayout()
        Me.PanelTxt3.ResumeLayout(False)
        Me.PanelTxt3.PerformLayout()
        Me.PanelTxt1.ResumeLayout(False)
        Me.PanelTxt1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanelRegistrationKey As FlowLayoutPanel
    Friend WithEvents LblTitle As Label
    Friend WithEvents BtnGenerateKeyCode As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents PanelTxt2 As Panel
    Friend WithEvents TxtKeyUser As TextBox
    Friend WithEvents LblKeyUser As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PanelTxt6 As Panel
    Friend WithEvents TxtKeyUseability As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelTxt4 As Panel
    Friend WithEvents TxtKeyCreatedDate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelTxt3 As Panel
    Friend WithEvents TxtKeyCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelTxt1 As Panel
    Friend WithEvents TxtKeyId As TextBox
    Friend WithEvents LblKeyID As Label
    Friend WithEvents TxtKeyStatus As ComboBox
End Class
