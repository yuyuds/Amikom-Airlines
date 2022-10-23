<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCekKursidanPesawat
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.DGCekKursi = New System.Windows.Forms.DataGridView()
        Me.cbSeat = New System.Windows.Forms.ComboBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.cbCekMaskapai = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbCekTujuan = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbCekJam = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbCekKelas = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbTipe = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        CType(Me.DGCekKursi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGCekKursi
        '
        Me.DGCekKursi.BackgroundColor = System.Drawing.Color.White
        Me.DGCekKursi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCekKursi.Location = New System.Drawing.Point(3, 246)
        Me.DGCekKursi.Name = "DGCekKursi"
        Me.DGCekKursi.Size = New System.Drawing.Size(554, 283)
        Me.DGCekKursi.TabIndex = 19
        '
        'cbSeat
        '
        Me.cbSeat.FormattingEnabled = True
        Me.cbSeat.Location = New System.Drawing.Point(164, 145)
        Me.cbSeat.Name = "cbSeat"
        Me.cbSeat.Size = New System.Drawing.Size(148, 21)
        Me.cbSeat.TabIndex = 23
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.BackColor = System.Drawing.Color.Transparent
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(16, 37)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(141, 16)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "Nama Maskapai          :"
        '
        'cbCekMaskapai
        '
        Me.cbCekMaskapai.FormattingEnabled = True
        Me.cbCekMaskapai.Location = New System.Drawing.Point(164, 37)
        Me.cbCekMaskapai.Name = "cbCekMaskapai"
        Me.cbCekMaskapai.Size = New System.Drawing.Size(207, 21)
        Me.cbCekMaskapai.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tujuan Maskapai         :"
        '
        'cbCekTujuan
        '
        Me.cbCekTujuan.FormattingEnabled = True
        Me.cbCekTujuan.Location = New System.Drawing.Point(164, 64)
        Me.cbCekTujuan.Name = "cbCekTujuan"
        Me.cbCekTujuan.Size = New System.Drawing.Size(207, 21)
        Me.cbCekTujuan.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jam Keberangkatan   :"
        '
        'cbCekJam
        '
        Me.cbCekJam.FormattingEnabled = True
        Me.cbCekJam.Location = New System.Drawing.Point(164, 91)
        Me.cbCekJam.Name = "cbCekJam"
        Me.cbCekJam.Size = New System.Drawing.Size(148, 21)
        Me.cbCekJam.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Kelas                                :"
        '
        'cbCekKelas
        '
        Me.cbCekKelas.FormattingEnabled = True
        Me.cbCekKelas.Location = New System.Drawing.Point(164, 118)
        Me.cbCekKelas.Name = "cbCekKelas"
        Me.cbCekKelas.Size = New System.Drawing.Size(148, 21)
        Me.cbCekKelas.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Tipe                                  :"
        '
        'cbTipe
        '
        Me.cbTipe.FormattingEnabled = True
        Me.cbTipe.Location = New System.Drawing.Point(164, 8)
        Me.cbTipe.Name = "cbTipe"
        Me.cbTipe.Size = New System.Drawing.Size(207, 21)
        Me.cbTipe.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 16)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Seat                                  :"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.SlateGray
        Me.Guna2GradientPanel1.Controls.Add(Me.Label10)
        Me.Guna2GradientPanel1.Controls.Add(Me.cbSeat)
        Me.Guna2GradientPanel1.Controls.Add(Me.cbTipe)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label9)
        Me.Guna2GradientPanel1.Controls.Add(Me.cbCekKelas)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label4)
        Me.Guna2GradientPanel1.Controls.Add(Me.cbCekJam)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label3)
        Me.Guna2GradientPanel1.Controls.Add(Me.cbCekTujuan)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel1.Controls.Add(Me.cbCekMaskapai)
        Me.Guna2GradientPanel1.Controls.Add(Me.lbl)
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(3, 66)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(554, 174)
        Me.Guna2GradientPanel1.TabIndex = 24
        '
        'FormCekKursidanPesawat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 532)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.DGCekKursi)
        Me.Name = "FormCekKursidanPesawat"
        Me.Text = "Cek Ketersediaan Kursi dan Persawat"
        CType(Me.DGCekKursi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGCekKursi As DataGridView
    Friend WithEvents cbSeat As ComboBox
    Friend WithEvents lbl As Label
    Friend WithEvents cbCekMaskapai As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbCekTujuan As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbCekJam As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbCekKelas As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbTipe As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
End Class
