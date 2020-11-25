<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentalCarComponentForPemberiSewa2
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
        Me.PictureBoxCar = New System.Windows.Forms.PictureBox()
        Me.PanelPictureBox = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblNamaKenderaan = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblTransmisi = New System.Windows.Forms.Label()
        Me.LblTahun = New System.Windows.Forms.Label()
        Me.LblJenama = New System.Windows.Forms.Label()
        Me.BtnComplete = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBoxCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPictureBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBoxCar
        '
        Me.PictureBoxCar.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxCar.Name = "PictureBoxCar"
        Me.PictureBoxCar.Size = New System.Drawing.Size(336, 160)
        Me.PictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxCar.TabIndex = 0
        Me.PictureBoxCar.TabStop = False
        '
        'PanelPictureBox
        '
        Me.PanelPictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelPictureBox.Controls.Add(Me.Label1)
        Me.PanelPictureBox.Controls.Add(Me.PictureBoxCar)
        Me.PanelPictureBox.Controls.Add(Me.Label2)
        Me.PanelPictureBox.Controls.Add(Me.LblNamaKenderaan)
        Me.PanelPictureBox.Controls.Add(Me.Label3)
        Me.PanelPictureBox.Controls.Add(Me.LblTransmisi)
        Me.PanelPictureBox.Controls.Add(Me.LblTahun)
        Me.PanelPictureBox.Controls.Add(Me.LblJenama)
        Me.PanelPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PanelPictureBox.Name = "PanelPictureBox"
        Me.PanelPictureBox.Size = New System.Drawing.Size(649, 160)
        Me.PanelPictureBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(364, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 27)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "JENAMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(364, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 27)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "TRANSMISI"
        '
        'LblNamaKenderaan
        '
        Me.LblNamaKenderaan.AutoSize = True
        Me.LblNamaKenderaan.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LblNamaKenderaan.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaKenderaan.ForeColor = System.Drawing.SystemColors.Control
        Me.LblNamaKenderaan.Location = New System.Drawing.Point(363, 18)
        Me.LblNamaKenderaan.Name = "LblNamaKenderaan"
        Me.LblNamaKenderaan.Size = New System.Drawing.Size(247, 31)
        Me.LblNamaKenderaan.TabIndex = 1
        Me.LblNamaKenderaan.Text = "NAMA KENDERAAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(364, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 27)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "TAHUN"
        '
        'LblTransmisi
        '
        Me.LblTransmisi.AutoSize = True
        Me.LblTransmisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LblTransmisi.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTransmisi.ForeColor = System.Drawing.SystemColors.Control
        Me.LblTransmisi.Location = New System.Drawing.Point(510, 116)
        Me.LblTransmisi.Name = "LblTransmisi"
        Me.LblTransmisi.Size = New System.Drawing.Size(130, 27)
        Me.LblTransmisi.TabIndex = 5
        Me.LblTransmisi.Text = "TRANSMISI"
        '
        'LblTahun
        '
        Me.LblTahun.AutoSize = True
        Me.LblTahun.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LblTahun.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTahun.ForeColor = System.Drawing.SystemColors.Control
        Me.LblTahun.Location = New System.Drawing.Point(510, 90)
        Me.LblTahun.Name = "LblTahun"
        Me.LblTahun.Size = New System.Drawing.Size(89, 27)
        Me.LblTahun.TabIndex = 4
        Me.LblTahun.Text = "TAHUN"
        '
        'LblJenama
        '
        Me.LblJenama.AutoSize = True
        Me.LblJenama.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LblJenama.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenama.ForeColor = System.Drawing.SystemColors.Control
        Me.LblJenama.Location = New System.Drawing.Point(510, 64)
        Me.LblJenama.Name = "LblJenama"
        Me.LblJenama.Size = New System.Drawing.Size(100, 27)
        Me.LblJenama.TabIndex = 3
        Me.LblJenama.Text = "JENAMA"
        '
        'BtnComplete
        '
        Me.BtnComplete.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.BtnComplete.FlatAppearance.BorderSize = 0
        Me.BtnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnComplete.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComplete.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnComplete.Location = New System.Drawing.Point(772, 105)
        Me.BtnComplete.Name = "BtnComplete"
        Me.BtnComplete.Size = New System.Drawing.Size(131, 38)
        Me.BtnComplete.TabIndex = 2
        Me.BtnComplete.Text = "Complete"
        Me.BtnComplete.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnCancel.Location = New System.Drawing.Point(676, 106)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(90, 38)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(654, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(263, 48)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Someone has rent your rental car"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(672, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(231, 25)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Start: "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(672, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(231, 25)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "End: "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RentalCarComponentForPemberiSewa2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnComplete)
        Me.Controls.Add(Me.PanelPictureBox)
        Me.Name = "RentalCarComponentForPemberiSewa2"
        Me.Size = New System.Drawing.Size(920, 160)
        CType(Me.PictureBoxCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPictureBox.ResumeLayout(False)
        Me.PanelPictureBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBoxCar As PictureBox
    Friend WithEvents PanelPictureBox As Panel
    Friend WithEvents LblNamaKenderaan As Label
    Friend WithEvents LblTransmisi As Label
    Friend WithEvents LblTahun As Label
    Friend WithEvents LblJenama As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnComplete As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
