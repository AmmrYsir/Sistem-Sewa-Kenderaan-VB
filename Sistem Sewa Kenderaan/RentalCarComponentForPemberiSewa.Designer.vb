<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RentalCarComponentForPemberiSewa
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
        Me.PanelPictureBox = New System.Windows.Forms.Panel()
        Me.PictureBoxCar = New System.Windows.Forms.PictureBox()
        Me.LblNamaKenderaan = New System.Windows.Forms.Label()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.LblJenama = New System.Windows.Forms.Label()
        Me.LblTahun = New System.Windows.Forms.Label()
        Me.LblTransmisi = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelPictureBox.SuspendLayout()
        CType(Me.PictureBoxCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelPictureBox
        '
        Me.PanelPictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelPictureBox.Controls.Add(Me.PictureBoxCar)
        Me.PanelPictureBox.Controls.Add(Me.LblNamaKenderaan)
        Me.PanelPictureBox.Controls.Add(Me.LblTransmisi)
        Me.PanelPictureBox.Controls.Add(Me.LblTahun)
        Me.PanelPictureBox.Controls.Add(Me.LblJenama)
        Me.PanelPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PanelPictureBox.Name = "PanelPictureBox"
        Me.PanelPictureBox.Size = New System.Drawing.Size(649, 160)
        Me.PanelPictureBox.TabIndex = 0
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
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.BackColor = System.Drawing.SystemColors.Control
        Me.LblStatus.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LblStatus.Location = New System.Drawing.Point(663, 84)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(93, 27)
        Me.LblStatus.TabIndex = 2
        Me.LblStatus.Text = "STATUS"
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
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.BtnEdit.FlatAppearance.BorderSize = 0
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnEdit.Location = New System.Drawing.Point(806, 18)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(94, 49)
        Me.BtnEdit.TabIndex = 6
        Me.BtnEdit.Text = "EDIT"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnDelete.Location = New System.Drawing.Point(806, 84)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(94, 49)
        Me.BtnDelete.TabIndex = 7
        Me.BtnDelete.Text = "DELETE"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(672, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 27)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "STATUS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(369, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 27)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "JENAMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(369, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 27)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "TRANSMISI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(369, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 27)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "TAHUN"
        '
        'RentalCarComponentForPemberiSewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.PanelPictureBox)
        Me.Margin = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.Name = "RentalCarComponentForPemberiSewa"
        Me.Size = New System.Drawing.Size(920, 160)
        Me.PanelPictureBox.ResumeLayout(False)
        Me.PanelPictureBox.PerformLayout()
        CType(Me.PictureBoxCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelPictureBox As Panel
    Friend WithEvents PictureBoxCar As PictureBox
    Friend WithEvents LblNamaKenderaan As Label
    Friend WithEvents LblStatus As Label
    Friend WithEvents LblJenama As Label
    Friend WithEvents LblTahun As Label
    Friend WithEvents LblTransmisi As Label
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
