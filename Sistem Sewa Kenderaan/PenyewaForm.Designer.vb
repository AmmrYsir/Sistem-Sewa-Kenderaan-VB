<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PenyewaForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanelCarRent = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtSearchBar = New System.Windows.Forms.TextBox()
        Me.CmBoxStatus = New System.Windows.Forms.ComboBox()
        Me.CmBoxTransmission = New System.Windows.Forms.ComboBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(-2, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 740)
        Me.Label2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 24.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(20, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 52)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "CARRENT"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(-2, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(244, 76)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "SEARCH CAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanelCarRent
        '
        Me.FlowLayoutPanelCarRent.Location = New System.Drawing.Point(268, 70)
        Me.FlowLayoutPanelCarRent.Name = "FlowLayoutPanelCarRent"
        Me.FlowLayoutPanelCarRent.Size = New System.Drawing.Size(950, 647)
        Me.FlowLayoutPanelCarRent.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TxtSearchBar)
        Me.Panel1.Location = New System.Drawing.Point(627, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(485, 37)
        Me.Panel1.TabIndex = 12
        '
        'TxtSearchBar
        '
        Me.TxtSearchBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSearchBar.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchBar.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtSearchBar.Location = New System.Drawing.Point(3, 4)
        Me.TxtSearchBar.Name = "TxtSearchBar"
        Me.TxtSearchBar.Size = New System.Drawing.Size(479, 30)
        Me.TxtSearchBar.TabIndex = 13
        '
        'CmBoxStatus
        '
        Me.CmBoxStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CmBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmBoxStatus.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmBoxStatus.ForeColor = System.Drawing.SystemColors.Control
        Me.CmBoxStatus.FormattingEnabled = True
        Me.CmBoxStatus.Items.AddRange(New Object() {"Both", "Available", "Unavailable"})
        Me.CmBoxStatus.Location = New System.Drawing.Point(412, 11)
        Me.CmBoxStatus.Name = "CmBoxStatus"
        Me.CmBoxStatus.Size = New System.Drawing.Size(209, 38)
        Me.CmBoxStatus.TabIndex = 13
        Me.CmBoxStatus.Text = "Available"
        '
        'CmBoxTransmission
        '
        Me.CmBoxTransmission.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CmBoxTransmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmBoxTransmission.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmBoxTransmission.ForeColor = System.Drawing.SystemColors.Control
        Me.CmBoxTransmission.FormattingEnabled = True
        Me.CmBoxTransmission.Items.AddRange(New Object() {"Both", "Auto", "Manual"})
        Me.CmBoxTransmission.Location = New System.Drawing.Point(268, 12)
        Me.CmBoxTransmission.Name = "CmBoxTransmission"
        Me.CmBoxTransmission.Size = New System.Drawing.Size(138, 38)
        Me.CmBoxTransmission.TabIndex = 14
        Me.CmBoxTransmission.Text = "Both"
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSearch.Location = New System.Drawing.Point(1118, 11)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(100, 39)
        Me.BtnSearch.TabIndex = 15
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'PenyewaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1237, 738)
        Me.Controls.Add(Me.CmBoxTransmission)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.CmBoxStatus)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanelCarRent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.Name = "PenyewaForm"
        Me.Text = "Penyewa | Search Now"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents FlowLayoutPanelCarRent As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtSearchBar As TextBox
    Friend WithEvents CmBoxStatus As ComboBox
    Friend WithEvents CmBoxTransmission As ComboBox
    Friend WithEvents BtnSearch As Button
End Class
