<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationCodeComponent
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.LblRegistrationCode = New System.Windows.Forms.Label()
        Me.TxtRegistrationCode = New System.Windows.Forms.TextBox()
        Me.BtnDiscard = New System.Windows.Forms.Button()
        Me.LblUsedBy = New System.Windows.Forms.Label()
        Me.LblOwnerName = New System.Windows.Forms.Label()
        Me.PanelRegistrationCode = New System.Windows.Forms.Panel()
        Me.PanelRegistrationCode.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblRegistrationCode
        '
        Me.LblRegistrationCode.AutoSize = True
        Me.LblRegistrationCode.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegistrationCode.ForeColor = System.Drawing.SystemColors.Control
        Me.LblRegistrationCode.Location = New System.Drawing.Point(74, 15)
        Me.LblRegistrationCode.Name = "LblRegistrationCode"
        Me.LblRegistrationCode.Size = New System.Drawing.Size(149, 20)
        Me.LblRegistrationCode.TabIndex = 0
        Me.LblRegistrationCode.Text = "REGISTRATION CODE"
        '
        'TxtRegistrationCode
        '
        Me.TxtRegistrationCode.BackColor = System.Drawing.SystemColors.Control
        Me.TxtRegistrationCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtRegistrationCode.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.0!)
        Me.TxtRegistrationCode.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TxtRegistrationCode.Location = New System.Drawing.Point(0, 8)
        Me.TxtRegistrationCode.MaxLength = 18
        Me.TxtRegistrationCode.Name = "TxtRegistrationCode"
        Me.TxtRegistrationCode.ReadOnly = True
        Me.TxtRegistrationCode.Size = New System.Drawing.Size(258, 32)
        Me.TxtRegistrationCode.TabIndex = 1
        Me.TxtRegistrationCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnDiscard
        '
        Me.BtnDiscard.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BtnDiscard.FlatAppearance.BorderSize = 0
        Me.BtnDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDiscard.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnDiscard.Location = New System.Drawing.Point(190, 91)
        Me.BtnDiscard.Name = "BtnDiscard"
        Me.BtnDiscard.Size = New System.Drawing.Size(85, 63)
        Me.BtnDiscard.TabIndex = 3
        Me.BtnDiscard.Text = "Discard Key"
        Me.BtnDiscard.UseVisualStyleBackColor = False
        '
        'LblUsedBy
        '
        Me.LblUsedBy.AutoSize = True
        Me.LblUsedBy.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsedBy.ForeColor = System.Drawing.SystemColors.Control
        Me.LblUsedBy.Location = New System.Drawing.Point(13, 91)
        Me.LblUsedBy.Name = "LblUsedBy"
        Me.LblUsedBy.Size = New System.Drawing.Size(67, 20)
        Me.LblUsedBy.TabIndex = 4
        Me.LblUsedBy.Text = "Used by: "
        '
        'LblOwnerName
        '
        Me.LblOwnerName.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOwnerName.ForeColor = System.Drawing.SystemColors.Control
        Me.LblOwnerName.Location = New System.Drawing.Point(13, 113)
        Me.LblOwnerName.Name = "LblOwnerName"
        Me.LblOwnerName.Size = New System.Drawing.Size(171, 41)
        Me.LblOwnerName.TabIndex = 5
        Me.LblOwnerName.Text = "None"
        '
        'PanelRegistrationCode
        '
        Me.PanelRegistrationCode.BackColor = System.Drawing.SystemColors.Control
        Me.PanelRegistrationCode.Controls.Add(Me.TxtRegistrationCode)
        Me.PanelRegistrationCode.Location = New System.Drawing.Point(17, 38)
        Me.PanelRegistrationCode.Name = "PanelRegistrationCode"
        Me.PanelRegistrationCode.Size = New System.Drawing.Size(258, 47)
        Me.PanelRegistrationCode.TabIndex = 6
        '
        'RegistrationCodeComponent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Controls.Add(Me.PanelRegistrationCode)
        Me.Controls.Add(Me.LblOwnerName)
        Me.Controls.Add(Me.LblUsedBy)
        Me.Controls.Add(Me.BtnDiscard)
        Me.Controls.Add(Me.LblRegistrationCode)
        Me.Name = "RegistrationCodeComponent"
        Me.Size = New System.Drawing.Size(298, 170)
        Me.PanelRegistrationCode.ResumeLayout(False)
        Me.PanelRegistrationCode.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblRegistrationCode As Label
    Friend WithEvents TxtRegistrationCode As TextBox
    Friend WithEvents BtnDiscard As Button
    Friend WithEvents LblUsedBy As Label
    Friend WithEvents LblOwnerName As Label
    Friend WithEvents PanelRegistrationCode As Panel
End Class
