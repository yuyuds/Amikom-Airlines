<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCariTiket
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
        Me.DGCekTiket = New System.Windows.Forms.DataGridView()
        Me.btnCariId = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtCekKDPemesanan = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.DGCekTiket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGCekTiket
        '
        Me.DGCekTiket.BackgroundColor = System.Drawing.Color.White
        Me.DGCekTiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCekTiket.Location = New System.Drawing.Point(19, 3)
        Me.DGCekTiket.Name = "DGCekTiket"
        Me.DGCekTiket.Size = New System.Drawing.Size(723, 371)
        Me.DGCekTiket.TabIndex = 94
        '
        'btnCariId
        '
        Me.btnCariId.AutoSize = True
        Me.btnCariId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCariId.BackColor = System.Drawing.Color.Aquamarine
        Me.btnCariId.Depth = 0
        Me.btnCariId.Location = New System.Drawing.Point(678, 14)
        Me.btnCariId.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCariId.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCariId.Name = "btnCariId"
        Me.btnCariId.Primary = False
        Me.btnCariId.Size = New System.Drawing.Size(64, 36)
        Me.btnCariId.TabIndex = 95
        Me.btnCariId.Text = "Cari KD"
        Me.btnCariId.UseVisualStyleBackColor = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(15, 22)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(126, 19)
        Me.MaterialLabel1.TabIndex = 96
        Me.MaterialLabel1.Text = "KD Pemesanan   :"
        '
        'txtCekKDPemesanan
        '
        Me.txtCekKDPemesanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCekKDPemesanan.Location = New System.Drawing.Point(156, 21)
        Me.txtCekKDPemesanan.Name = "txtCekKDPemesanan"
        Me.txtCekKDPemesanan.Size = New System.Drawing.Size(501, 22)
        Me.txtCekKDPemesanan.TabIndex = 93
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.MaterialLabel1)
        Me.Panel1.Controls.Add(Me.btnCariId)
        Me.Panel1.Controls.Add(Me.txtCekKDPemesanan)
        Me.Panel1.Location = New System.Drawing.Point(1, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(877, 59)
        Me.Panel1.TabIndex = 97
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.DGCekTiket)
        Me.Panel2.Location = New System.Drawing.Point(1, 123)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(877, 382)
        Me.Panel2.TabIndex = 98
        '
        'FormCariTiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 508)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormCariTiket"
        Me.Text = "Cari Tiket"
        CType(Me.DGCekTiket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGCekTiket As DataGridView
    Friend WithEvents btnCariId As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtCekKDPemesanan As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
