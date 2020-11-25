<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarRentForm
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
        Me.CarPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtNumberPhone = New System.Windows.Forms.TextBox()
        Me.BtnSewa = New System.Windows.Forms.Button()
        Me.HourTrackBar = New System.Windows.Forms.TrackBar()
        Me.LblJamSewa = New System.Windows.Forms.Label()
        Me.LblHarga = New System.Windows.Forms.Label()
        Me.DateTimePickerForSewaan = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtKeteranganLanjut = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.CarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.HourTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(-2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(675, 467)
        Me.Label2.TabIndex = 4
        '
        'CarPictureBox
        '
        Me.CarPictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CarPictureBox.Location = New System.Drawing.Point(28, 48)
        Me.CarPictureBox.Name = "CarPictureBox"
        Me.CarPictureBox.Size = New System.Drawing.Size(621, 390)
        Me.CarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CarPictureBox.TabIndex = 5
        Me.CarPictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(713, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 27)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "OWNER'S NUMBER PHONE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TxtNumberPhone)
        Me.Panel1.Location = New System.Drawing.Point(706, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(385, 44)
        Me.Panel1.TabIndex = 7
        '
        'TxtNumberPhone
        '
        Me.TxtNumberPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtNumberPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNumberPhone.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumberPhone.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtNumberPhone.Location = New System.Drawing.Point(0, 7)
        Me.TxtNumberPhone.Name = "TxtNumberPhone"
        Me.TxtNumberPhone.Size = New System.Drawing.Size(385, 30)
        Me.TxtNumberPhone.TabIndex = 8
        Me.TxtNumberPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSewa
        '
        Me.BtnSewa.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSewa.FlatAppearance.BorderSize = 0
        Me.BtnSewa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSewa.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSewa.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSewa.Location = New System.Drawing.Point(1013, 411)
        Me.BtnSewa.Name = "BtnSewa"
        Me.BtnSewa.Size = New System.Drawing.Size(78, 44)
        Me.BtnSewa.TabIndex = 11
        Me.BtnSewa.Text = "SEWA"
        Me.BtnSewa.UseVisualStyleBackColor = False
        '
        'HourTrackBar
        '
        Me.HourTrackBar.Location = New System.Drawing.Point(706, 349)
        Me.HourTrackBar.Name = "HourTrackBar"
        Me.HourTrackBar.Size = New System.Drawing.Size(385, 56)
        Me.HourTrackBar.TabIndex = 12
        '
        'LblJamSewa
        '
        Me.LblJamSewa.AutoSize = True
        Me.LblJamSewa.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.LblJamSewa.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJamSewa.ForeColor = System.Drawing.SystemColors.Control
        Me.LblJamSewa.Location = New System.Drawing.Point(713, 304)
        Me.LblJamSewa.Name = "LblJamSewa"
        Me.LblJamSewa.Size = New System.Drawing.Size(135, 27)
        Me.LblJamSewa.TabIndex = 13
        Me.LblJamSewa.Text = "0 JAM = RM0"
        '
        'LblHarga
        '
        Me.LblHarga.AutoSize = True
        Me.LblHarga.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.LblHarga.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHarga.ForeColor = System.Drawing.SystemColors.Control
        Me.LblHarga.Location = New System.Drawing.Point(713, 418)
        Me.LblHarga.Name = "LblHarga"
        Me.LblHarga.Size = New System.Drawing.Size(147, 27)
        Me.LblHarga.TabIndex = 14
        Me.LblHarga.Text = "RM12 PER JAM"
        '
        'DateTimePickerForSewaan
        '
        Me.DateTimePickerForSewaan.CalendarFont = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerForSewaan.CalendarForeColor = System.Drawing.SystemColors.Control
        Me.DateTimePickerForSewaan.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DateTimePickerForSewaan.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DateTimePickerForSewaan.CalendarTitleForeColor = System.Drawing.SystemColors.Control
        Me.DateTimePickerForSewaan.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DateTimePickerForSewaan.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerForSewaan.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerForSewaan.Location = New System.Drawing.Point(914, 299)
        Me.DateTimePickerForSewaan.Margin = New System.Windows.Forms.Padding(14)
        Me.DateTimePickerForSewaan.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerForSewaan.MinDate = New Date(2020, 10, 12, 0, 0, 0, 0)
        Me.DateTimePickerForSewaan.Name = "DateTimePickerForSewaan"
        Me.DateTimePickerForSewaan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePickerForSewaan.RightToLeftLayout = True
        Me.DateTimePickerForSewaan.Size = New System.Drawing.Size(177, 33)
        Me.DateTimePickerForSewaan.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(921, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 27)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "TARIKH SEWAAN"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TxtKeteranganLanjut)
        Me.Panel2.Location = New System.Drawing.Point(706, 134)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(385, 117)
        Me.Panel2.TabIndex = 10
        '
        'TxtKeteranganLanjut
        '
        Me.TxtKeteranganLanjut.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TxtKeteranganLanjut.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtKeteranganLanjut.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKeteranganLanjut.ForeColor = System.Drawing.SystemColors.Control
        Me.TxtKeteranganLanjut.Location = New System.Drawing.Point(0, 11)
        Me.TxtKeteranganLanjut.Multiline = True
        Me.TxtKeteranganLanjut.Name = "TxtKeteranganLanjut"
        Me.TxtKeteranganLanjut.Size = New System.Drawing.Size(385, 93)
        Me.TxtKeteranganLanjut.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(713, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 27)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "KETERANGAN LANJUT"
        '
        'CarRentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1137, 467)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePickerForSewaan)
        Me.Controls.Add(Me.LblHarga)
        Me.Controls.Add(Me.LblJamSewa)
        Me.Controls.Add(Me.HourTrackBar)
        Me.Controls.Add(Me.BtnSewa)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CarPictureBox)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "CarRentForm"
        Me.Text = "Rent A Car "
        CType(Me.CarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.HourTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents CarPictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtNumberPhone As TextBox
    Friend WithEvents BtnSewa As Button
    Friend WithEvents HourTrackBar As TrackBar
    Friend WithEvents LblJamSewa As Label
    Friend WithEvents LblHarga As Label
    Friend WithEvents DateTimePickerForSewaan As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtKeteranganLanjut As TextBox
    Friend WithEvents Label3 As Label
End Class
