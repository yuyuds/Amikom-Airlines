<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPemesananTiket
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtIDPemesanan = New System.Windows.Forms.TextBox()
        Me.txtIDPembeli = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIDDetail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKDTiket = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIDPenumpang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSeat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHargaTiket = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.btnSave = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 16)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "KD Pemesanan               :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(175, 126)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(168, 20)
        Me.DateTimePicker1.TabIndex = 72
        '
        'txtIDPemesanan
        '
        Me.txtIDPemesanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDPemesanan.Location = New System.Drawing.Point(175, 209)
        Me.txtIDPemesanan.Name = "txtIDPemesanan"
        Me.txtIDPemesanan.Size = New System.Drawing.Size(168, 22)
        Me.txtIDPemesanan.TabIndex = 71
        '
        'txtIDPembeli
        '
        Me.txtIDPembeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDPembeli.Location = New System.Drawing.Point(175, 71)
        Me.txtIDPembeli.Name = "txtIDPembeli"
        Me.txtIDPembeli.Size = New System.Drawing.Size(168, 22)
        Me.txtIDPembeli.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 16)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "ID Pembeli                        :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 16)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Tanggal Pembayaran  :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 16)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Status                                  :"
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(175, 99)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(168, 21)
        Me.cbStatus.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 16)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "ID Detail                             :"
        '
        'txtIDDetail
        '
        Me.txtIDDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDDetail.Location = New System.Drawing.Point(175, 153)
        Me.txtIDDetail.Name = "txtIDDetail"
        Me.txtIDDetail.Size = New System.Drawing.Size(168, 22)
        Me.txtIDDetail.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 16)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "KD Tiket                             :"
        '
        'txtKDTiket
        '
        Me.txtKDTiket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKDTiket.Location = New System.Drawing.Point(175, 181)
        Me.txtKDTiket.Name = "txtKDTiket"
        Me.txtKDTiket.Size = New System.Drawing.Size(168, 22)
        Me.txtKDTiket.TabIndex = 76
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 16)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "ID Penumpang                 :"
        '
        'txtIDPenumpang
        '
        Me.txtIDPenumpang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDPenumpang.Location = New System.Drawing.Point(175, 237)
        Me.txtIDPenumpang.Name = "txtIDPenumpang"
        Me.txtIDPenumpang.Size = New System.Drawing.Size(168, 22)
        Me.txtIDPenumpang.TabIndex = 78
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 16)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Seat                                     :"
        '
        'txtSeat
        '
        Me.txtSeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeat.Location = New System.Drawing.Point(175, 265)
        Me.txtSeat.Name = "txtSeat"
        Me.txtSeat.Size = New System.Drawing.Size(168, 22)
        Me.txtSeat.TabIndex = 80
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 16)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Harga Tiket                       :"
        '
        'txtHargaTiket
        '
        Me.txtHargaTiket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaTiket.Location = New System.Drawing.Point(175, 293)
        Me.txtHargaTiket.Name = "txtHargaTiket"
        Me.txtHargaTiket.Size = New System.Drawing.Size(168, 22)
        Me.txtHargaTiket.TabIndex = 82
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 324)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 16)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "Sub Total                           :"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(175, 321)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(168, 22)
        Me.txtSubTotal.TabIndex = 84
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Depth = 0
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(363, 171)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Primary = False
        Me.btnSave.Size = New System.Drawing.Size(46, 36)
        Me.btnSave.TabIndex = 86
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'FormPemesananTiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 349)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtHargaTiket)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSeat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIDPenumpang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKDTiket)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIDDetail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtIDPemesanan)
        Me.Controls.Add(Me.txtIDPembeli)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbStatus)
        Me.Name = "FormPemesananTiket"
        Me.Text = "Pemesanan Tiket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtIDPemesanan As TextBox
    Friend WithEvents txtIDPembeli As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIDDetail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKDTiket As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIDPenumpang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSeat As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtHargaTiket As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialFlatButton
End Class
