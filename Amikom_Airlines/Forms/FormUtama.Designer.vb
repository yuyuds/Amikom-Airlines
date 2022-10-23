<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IDPenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenumpangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputPenumpangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputPemesananTiketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CariTiketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CariTiketToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KetersediaanTiketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CekTersediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JadwalBerangkatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JadwalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IDPenggunaToolStripMenuItem, Me.PenumpangToolStripMenuItem, Me.PemesananToolStripMenuItem, Me.CariTiketToolStripMenuItem, Me.KetersediaanTiketToolStripMenuItem, Me.JadwalBerangkatToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(788, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IDPenggunaToolStripMenuItem
        '
        Me.IDPenggunaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputDataToolStripMenuItem})
        Me.IDPenggunaToolStripMenuItem.Name = "IDPenggunaToolStripMenuItem"
        Me.IDPenggunaToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.IDPenggunaToolStripMenuItem.Text = "ID Pengguna"
        '
        'InputDataToolStripMenuItem
        '
        Me.InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        Me.InputDataToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.InputDataToolStripMenuItem.Text = "Input Data"
        '
        'PenumpangToolStripMenuItem
        '
        Me.PenumpangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputPenumpangToolStripMenuItem})
        Me.PenumpangToolStripMenuItem.Name = "PenumpangToolStripMenuItem"
        Me.PenumpangToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.PenumpangToolStripMenuItem.Text = "penumpang"
        '
        'InputPenumpangToolStripMenuItem
        '
        Me.InputPenumpangToolStripMenuItem.Name = "InputPenumpangToolStripMenuItem"
        Me.InputPenumpangToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.InputPenumpangToolStripMenuItem.Text = "Input penumpang"
        '
        'PemesananToolStripMenuItem
        '
        Me.PemesananToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputPemesananTiketToolStripMenuItem})
        Me.PemesananToolStripMenuItem.Name = "PemesananToolStripMenuItem"
        Me.PemesananToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.PemesananToolStripMenuItem.Text = "Pemesanan"
        '
        'InputPemesananTiketToolStripMenuItem
        '
        Me.InputPemesananTiketToolStripMenuItem.Name = "InputPemesananTiketToolStripMenuItem"
        Me.InputPemesananTiketToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.InputPemesananTiketToolStripMenuItem.Text = "Input PemesananTiket"
        '
        'CariTiketToolStripMenuItem
        '
        Me.CariTiketToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CariTiketToolStripMenuItem1})
        Me.CariTiketToolStripMenuItem.Name = "CariTiketToolStripMenuItem"
        Me.CariTiketToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.CariTiketToolStripMenuItem.Text = "Cari Tiket"
        '
        'CariTiketToolStripMenuItem1
        '
        Me.CariTiketToolStripMenuItem1.Name = "CariTiketToolStripMenuItem1"
        Me.CariTiketToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.CariTiketToolStripMenuItem1.Text = "Cari tiket"
        '
        'KetersediaanTiketToolStripMenuItem
        '
        Me.KetersediaanTiketToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CekTersediaToolStripMenuItem})
        Me.KetersediaanTiketToolStripMenuItem.Name = "KetersediaanTiketToolStripMenuItem"
        Me.KetersediaanTiketToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.KetersediaanTiketToolStripMenuItem.Text = "Ketersediaan Tiket"
        '
        'CekTersediaToolStripMenuItem
        '
        Me.CekTersediaToolStripMenuItem.Name = "CekTersediaToolStripMenuItem"
        Me.CekTersediaToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.CekTersediaToolStripMenuItem.Text = "Cek tersedia"
        '
        'JadwalBerangkatToolStripMenuItem
        '
        Me.JadwalBerangkatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JadwalToolStripMenuItem})
        Me.JadwalBerangkatToolStripMenuItem.Name = "JadwalBerangkatToolStripMenuItem"
        Me.JadwalBerangkatToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.JadwalBerangkatToolStripMenuItem.Text = "Jadwal Berangkat"
        '
        'JadwalToolStripMenuItem
        '
        Me.JadwalToolStripMenuItem.Name = "JadwalToolStripMenuItem"
        Me.JadwalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.JadwalToolStripMenuItem.Text = "Jadwal"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 756)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Control"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KetersediaanTiketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IDPenggunaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CariTiketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JadwalBerangkatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CekTersediaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CariTiketToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents JadwalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PemesananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputPemesananTiketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenumpangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputPenumpangToolStripMenuItem As ToolStripMenuItem
End Class
