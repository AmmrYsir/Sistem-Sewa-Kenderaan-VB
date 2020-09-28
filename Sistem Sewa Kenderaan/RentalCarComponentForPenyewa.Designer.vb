<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RentalCarComponentForPenyewa
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CarPictureBox = New System.Windows.Forms.PictureBox()
        Me.PanelPictureBox = New System.Windows.Forms.Panel()
        Me.BtnSemakLanjut = New System.Windows.Forms.Button()
        Me.LblTransmisi = New System.Windows.Forms.Label()
        Me.LblTahun = New System.Windows.Forms.Label()
        Me.LblJenama = New System.Windows.Forms.Label()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.LblNamaKenderaan = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.CarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPictureBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CarPictureBox
        '
        Me.CarPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.CarPictureBox.Name = "CarPictureBox"
        Me.CarPictureBox.Size = New System.Drawing.Size(345, 160)
        Me.CarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CarPictureBox.TabIndex = 0
        Me.CarPictureBox.TabStop = False
        '
        'PanelPictureBox
        '
        Me.PanelPictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelPictureBox.Controls.Add(Me.CarPictureBox)
        Me.PanelPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PanelPictureBox.Name = "PanelPictureBox"
        Me.PanelPictureBox.Size = New System.Drawing.Size(623, 160)
        Me.PanelPictureBox.TabIndex = 1
        '
        'BtnSemakLanjut
        '
        Me.BtnSemakLanjut.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSemakLanjut.FlatAppearance.BorderSize = 0
        Me.BtnSemakLanjut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSemakLanjut.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSemakLanjut.Location = New System.Drawing.Point(782, 21)
        Me.BtnSemakLanjut.Name = "BtnSemakLanjut"
        Me.BtnSemakLanjut.Size = New System.Drawing.Size(120, 115)
        Me.BtnSemakLanjut.TabIndex = 14
        Me.BtnSemakLanjut.Text = "SEMAK LEBIH LANJUT"
        Me.BtnSemakLanjut.UseVisualStyleBackColor = False
        '
        'LblTransmisi
        '
        Me.LblTransmisi.AutoSize = True
        Me.LblTransmisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LblTransmisi.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTransmisi.ForeColor = System.Drawing.SystemColors.Control
        Me.LblTransmisi.Location = New System.Drawing.Point(493, 117)
        Me.LblTransmisi.Name = "LblTransmisi"
        Me.LblTransmisi.Size = New System.Drawing.Size(130, 27)
        Me.LblTransmisi.TabIndex = 12
        Me.LblTransmisi.Text = "TRANSMISI"
        '
        'LblTahun
        '
        Me.LblTahun.AutoSize = True
        Me.LblTahun.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LblTahun.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTahun.ForeColor = System.Drawing.SystemColors.Control
        Me.LblTahun.Location = New System.Drawing.Point(493, 90)
        Me.LblTahun.Name = "LblTahun"
        Me.LblTahun.Size = New System.Drawing.Size(89, 27)
        Me.LblTahun.TabIndex = 11
        Me.LblTahun.Text = "TAHUN"
        '
        'LblJenama
        '
        Me.LblJenama.AutoSize = True
        Me.LblJenama.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LblJenama.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenama.ForeColor = System.Drawing.SystemColors.Control
        Me.LblJenama.Location = New System.Drawing.Point(493, 62)
        Me.LblJenama.Name = "LblJenama"
        Me.LblJenama.Size = New System.Drawing.Size(100, 27)
        Me.LblJenama.TabIndex = 10
        Me.LblJenama.Text = "JENAMA"
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LblStatus.Location = New System.Drawing.Point(643, 89)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(93, 27)
        Me.LblStatus.TabIndex = 9
        Me.LblStatus.Text = "STATUS"
        '
        'LblNamaKenderaan
        '
        Me.LblNamaKenderaan.AutoSize = True
        Me.LblNamaKenderaan.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LblNamaKenderaan.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaKenderaan.ForeColor = System.Drawing.SystemColors.Control
        Me.LblNamaKenderaan.Location = New System.Drawing.Point(365, 21)
        Me.LblNamaKenderaan.Name = "LblNamaKenderaan"
        Me.LblNamaKenderaan.Size = New System.Drawing.Size(247, 31)
        Me.LblNamaKenderaan.TabIndex = 8
        Me.LblNamaKenderaan.Text = "NAMA KENDERAAN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(366, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 27)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "JENAMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(366, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 27)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "TRANSMISI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(366, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 27)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "TAHUN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(652, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 27)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "STATUS"
        '
        'RentalCarComponentForPenyewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblJenama)
        Me.Controls.Add(Me.BtnSemakLanjut)
        Me.Controls.Add(Me.LblTransmisi)
        Me.Controls.Add(Me.LblNamaKenderaan)
        Me.Controls.Add(Me.LblTahun)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.PanelPictureBox)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "RentalCarComponentForPenyewa"
        Me.Size = New System.Drawing.Size(920, 160)
        CType(Me.CarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPictureBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CarPictureBox As PictureBox
    Friend WithEvents PanelPictureBox As Panel
    Friend WithEvents BtnSemakLanjut As Button
    Friend WithEvents LblTransmisi As Label
    Friend WithEvents LblTahun As Label
    Friend WithEvents LblJenama As Label
    Friend WithEvents LblStatus As Label
    Friend WithEvents LblNamaKenderaan As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
