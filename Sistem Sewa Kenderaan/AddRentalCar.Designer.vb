<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRentalCar
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CarPictureBox = New System.Windows.Forms.PictureBox()
        Me.LblNamaKenderaan = New System.Windows.Forms.Label()
        Me.PanelTxt1 = New System.Windows.Forms.Panel()
        Me.TxtNamaKenderaan = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnFileUpload = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTahun = New System.Windows.Forms.TextBox()
        Me.PanelTxt4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmBoxTransmisi = New System.Windows.Forms.ComboBox()
        Me.CmBoxStatus = New System.Windows.Forms.ComboBox()
        Me.TxtEditedDate = New System.Windows.Forms.TextBox()
        Me.LblEditedDate = New System.Windows.Forms.Label()
        Me.PanelTxt6 = New System.Windows.Forms.Panel()
        Me.PanelTxt2 = New System.Windows.Forms.Panel()
        Me.TxtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LabelSeparator = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.LblHarga = New System.Windows.Forms.Label()
        Me.PanelTxt5 = New System.Windows.Forms.Panel()
        Me.TxtHarga = New System.Windows.Forms.MaskedTextBox()
        Me.TxtJenama = New System.Windows.Forms.ComboBox()
        CType(Me.CarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTxt1.SuspendLayout()
        Me.PanelTxt4.SuspendLayout()
        Me.PanelTxt6.SuspendLayout()
        Me.PanelTxt2.SuspendLayout()
        Me.PanelTxt5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 24.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(23, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 52)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "CARRENT"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(-1, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(776, 611)
        Me.Label2.TabIndex = 8
        '
        'CarPictureBox
        '
        Me.CarPictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CarPictureBox.Location = New System.Drawing.Point(23, 75)
        Me.CarPictureBox.Name = "CarPictureBox"
        Me.CarPictureBox.Size = New System.Drawing.Size(732, 517)
        Me.CarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CarPictureBox.TabIndex = 12
        Me.CarPictureBox.TabStop = False
        '
        'LblNamaKenderaan
        '
        Me.LblNamaKenderaan.AutoSize = True
        Me.LblNamaKenderaan.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaKenderaan.ForeColor = System.Drawing.SystemColors.Control
        Me.LblNamaKenderaan.Location = New System.Drawing.Point(788, 17)
        Me.LblNamaKenderaan.Name = "LblNamaKenderaan"
        Me.LblNamaKenderaan.Size = New System.Drawing.Size(232, 31)
        Me.LblNamaKenderaan.TabIndex = 13
        Me.LblNamaKenderaan.Text = "NAMA KENDERAAN"
        '
        'PanelTxt1
        '
        Me.PanelTxt1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelTxt1.Controls.Add(Me.TxtNamaKenderaan)
        Me.PanelTxt1.Location = New System.Drawing.Point(794, 51)
        Me.PanelTxt1.Name = "PanelTxt1"
        Me.PanelTxt1.Size = New System.Drawing.Size(512, 49)
        Me.PanelTxt1.TabIndex = 14
        '
        'TxtNamaKenderaan
        '
        Me.TxtNamaKenderaan.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtNamaKenderaan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNamaKenderaan.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNamaKenderaan.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtNamaKenderaan.Location = New System.Drawing.Point(3, 10)
        Me.TxtNamaKenderaan.Name = "TxtNamaKenderaan"
        Me.TxtNamaKenderaan.Size = New System.Drawing.Size(506, 30)
        Me.TxtNamaKenderaan.TabIndex = 0
        Me.TxtNamaKenderaan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnAdd.Location = New System.Drawing.Point(1196, 156)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(107, 318)
        Me.BtnAdd.TabIndex = 15
        Me.BtnAdd.Text = "Add "
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnFileUpload
        '
        Me.BtnFileUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.BtnFileUpload.FlatAppearance.BorderSize = 0
        Me.BtnFileUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFileUpload.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnFileUpload.Location = New System.Drawing.Point(630, 551)
        Me.BtnFileUpload.Name = "BtnFileUpload"
        Me.BtnFileUpload.Size = New System.Drawing.Size(125, 41)
        Me.BtnFileUpload.TabIndex = 16
        Me.BtnFileUpload.Text = "File Upload"
        Me.BtnFileUpload.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(788, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 31)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "JENAMA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(1029, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 31)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "TAHUN"
        '
        'TxtTahun
        '
        Me.TxtTahun.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtTahun.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTahun.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTahun.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtTahun.Location = New System.Drawing.Point(3, 10)
        Me.TxtTahun.Name = "TxtTahun"
        Me.TxtTahun.Size = New System.Drawing.Size(125, 30)
        Me.TxtTahun.TabIndex = 0
        Me.TxtTahun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelTxt4
        '
        Me.PanelTxt4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelTxt4.Controls.Add(Me.TxtTahun)
        Me.PanelTxt4.Location = New System.Drawing.Point(1032, 334)
        Me.PanelTxt4.Name = "PanelTxt4"
        Me.PanelTxt4.Size = New System.Drawing.Size(131, 49)
        Me.PanelTxt4.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(788, 395)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 31)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "TRANSMISI"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(953, 395)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 31)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "STATUS"
        '
        'CmBoxTransmisi
        '
        Me.CmBoxTransmisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CmBoxTransmisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmBoxTransmisi.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!)
        Me.CmBoxTransmisi.ForeColor = System.Drawing.SystemColors.Control
        Me.CmBoxTransmisi.FormattingEnabled = True
        Me.CmBoxTransmisi.Items.AddRange(New Object() {"Auto", "Manual"})
        Me.CmBoxTransmisi.Location = New System.Drawing.Point(794, 436)
        Me.CmBoxTransmisi.Name = "CmBoxTransmisi"
        Me.CmBoxTransmisi.Size = New System.Drawing.Size(123, 38)
        Me.CmBoxTransmisi.TabIndex = 0
        '
        'CmBoxStatus
        '
        Me.CmBoxStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CmBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmBoxStatus.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!)
        Me.CmBoxStatus.ForeColor = System.Drawing.SystemColors.Control
        Me.CmBoxStatus.FormattingEnabled = True
        Me.CmBoxStatus.Items.AddRange(New Object() {"Available", "Unavailable"})
        Me.CmBoxStatus.Location = New System.Drawing.Point(956, 436)
        Me.CmBoxStatus.Name = "CmBoxStatus"
        Me.CmBoxStatus.Size = New System.Drawing.Size(204, 38)
        Me.CmBoxStatus.TabIndex = 0
        '
        'TxtEditedDate
        '
        Me.TxtEditedDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtEditedDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEditedDate.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEditedDate.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtEditedDate.Location = New System.Drawing.Point(3, 10)
        Me.TxtEditedDate.Name = "TxtEditedDate"
        Me.TxtEditedDate.ReadOnly = True
        Me.TxtEditedDate.Size = New System.Drawing.Size(191, 30)
        Me.TxtEditedDate.TabIndex = 0
        Me.TxtEditedDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblEditedDate
        '
        Me.LblEditedDate.AutoSize = True
        Me.LblEditedDate.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEditedDate.ForeColor = System.Drawing.SystemColors.Control
        Me.LblEditedDate.Location = New System.Drawing.Point(1122, 506)
        Me.LblEditedDate.Name = "LblEditedDate"
        Me.LblEditedDate.Size = New System.Drawing.Size(159, 31)
        Me.LblEditedDate.TabIndex = 21
        Me.LblEditedDate.Text = "EDITED DATE"
        Me.LblEditedDate.Visible = False
        '
        'PanelTxt6
        '
        Me.PanelTxt6.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelTxt6.Controls.Add(Me.TxtEditedDate)
        Me.PanelTxt6.Location = New System.Drawing.Point(1109, 540)
        Me.PanelTxt6.Name = "PanelTxt6"
        Me.PanelTxt6.Size = New System.Drawing.Size(197, 49)
        Me.PanelTxt6.TabIndex = 22
        Me.PanelTxt6.Visible = False
        '
        'PanelTxt2
        '
        Me.PanelTxt2.AutoSize = True
        Me.PanelTxt2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelTxt2.Controls.Add(Me.TxtKeterangan)
        Me.PanelTxt2.Location = New System.Drawing.Point(794, 156)
        Me.PanelTxt2.Name = "PanelTxt2"
        Me.PanelTxt2.Size = New System.Drawing.Size(369, 130)
        Me.PanelTxt2.TabIndex = 16
        '
        'TxtKeterangan
        '
        Me.TxtKeterangan.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtKeterangan.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKeterangan.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtKeterangan.Location = New System.Drawing.Point(4, 10)
        Me.TxtKeterangan.Multiline = True
        Me.TxtKeterangan.Name = "TxtKeterangan"
        Me.TxtKeterangan.Size = New System.Drawing.Size(362, 110)
        Me.TxtKeterangan.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(791, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(312, 31)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "KETERANGAN KENDERAAN"
        '
        'LabelSeparator
        '
        Me.LabelSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LabelSeparator.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSeparator.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelSeparator.Location = New System.Drawing.Point(792, 495)
        Me.LabelSeparator.Name = "LabelSeparator"
        Me.LabelSeparator.Size = New System.Drawing.Size(512, 2)
        Me.LabelSeparator.TabIndex = 23
        Me.LabelSeparator.Visible = False
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'LblHarga
        '
        Me.LblHarga.AutoSize = True
        Me.LblHarga.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHarga.ForeColor = System.Drawing.SystemColors.Control
        Me.LblHarga.Location = New System.Drawing.Point(792, 506)
        Me.LblHarga.Name = "LblHarga"
        Me.LblHarga.Size = New System.Drawing.Size(253, 31)
        Me.LblHarga.TabIndex = 21
        Me.LblHarga.Text = "HARGA PER JAM (RM)"
        '
        'PanelTxt5
        '
        Me.PanelTxt5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelTxt5.Controls.Add(Me.TxtHarga)
        Me.PanelTxt5.Location = New System.Drawing.Point(794, 540)
        Me.PanelTxt5.Name = "PanelTxt5"
        Me.PanelTxt5.Size = New System.Drawing.Size(255, 49)
        Me.PanelTxt5.TabIndex = 22
        '
        'TxtHarga
        '
        Me.TxtHarga.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtHarga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtHarga.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!)
        Me.TxtHarga.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtHarga.Location = New System.Drawing.Point(4, 11)
        Me.TxtHarga.Mask = "00"
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(247, 30)
        Me.TxtHarga.TabIndex = 0
        Me.TxtHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtJenama
        '
        Me.TxtJenama.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtJenama.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!)
        Me.TxtJenama.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtJenama.FormattingEnabled = True
        Me.TxtJenama.Items.AddRange(New Object() {"PROTON", "PERODUA", "HONDA", "MAZDA", "MERCEDES BENZ", "KIA", "VOLKSWAGEN", "BMW", "NISSAN", "TOYOTA"})
        Me.TxtJenama.Location = New System.Drawing.Point(794, 334)
        Me.TxtJenama.Name = "TxtJenama"
        Me.TxtJenama.Size = New System.Drawing.Size(206, 38)
        Me.TxtJenama.TabIndex = 1
        '
        'AddRentalCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1318, 610)
        Me.Controls.Add(Me.TxtJenama)
        Me.Controls.Add(Me.LblHarga)
        Me.Controls.Add(Me.LabelSeparator)
        Me.Controls.Add(Me.PanelTxt5)
        Me.Controls.Add(Me.PanelTxt2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblEditedDate)
        Me.Controls.Add(Me.CmBoxStatus)
        Me.Controls.Add(Me.PanelTxt6)
        Me.Controls.Add(Me.CmBoxTransmisi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PanelTxt4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnFileUpload)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.PanelTxt1)
        Me.Controls.Add(Me.LblNamaKenderaan)
        Me.Controls.Add(Me.CarPictureBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AddRentalCar"
        Me.Text = "Add Rental Car | Management"
        CType(Me.CarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTxt1.ResumeLayout(False)
        Me.PanelTxt1.PerformLayout()
        Me.PanelTxt4.ResumeLayout(False)
        Me.PanelTxt4.PerformLayout()
        Me.PanelTxt6.ResumeLayout(False)
        Me.PanelTxt6.PerformLayout()
        Me.PanelTxt2.ResumeLayout(False)
        Me.PanelTxt2.PerformLayout()
        Me.PanelTxt5.ResumeLayout(False)
        Me.PanelTxt5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CarPictureBox As PictureBox
    Friend WithEvents LblNamaKenderaan As Label
    Friend WithEvents PanelTxt1 As Panel
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnFileUpload As Button
    Friend WithEvents TxtNamaKenderaan As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTahun As TextBox
    Friend WithEvents PanelTxt4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CmBoxTransmisi As ComboBox
    Friend WithEvents CmBoxStatus As ComboBox
    Friend WithEvents TxtEditedDate As TextBox
    Friend WithEvents LblEditedDate As Label
    Friend WithEvents PanelTxt6 As Panel
    Friend WithEvents PanelTxt2 As Panel
    Friend WithEvents TxtKeterangan As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LabelSeparator As Label
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents LblHarga As Label
    Friend WithEvents PanelTxt5 As Panel
    Friend WithEvents TxtHarga As MaskedTextBox
    Friend WithEvents TxtJenama As ComboBox
End Class
