<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJadwal_Keberangkatan
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
        Me.DGJadwalBerangkat = New System.Windows.Forms.DataGridView()
        CType(Me.DGJadwalBerangkat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGJadwalBerangkat
        '
        Me.DGJadwalBerangkat.BackgroundColor = System.Drawing.Color.White
        Me.DGJadwalBerangkat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGJadwalBerangkat.Location = New System.Drawing.Point(4, 65)
        Me.DGJadwalBerangkat.Name = "DGJadwalBerangkat"
        Me.DGJadwalBerangkat.Size = New System.Drawing.Size(253, 443)
        Me.DGJadwalBerangkat.TabIndex = 93
        '
        'FormJadwal_Keberangkatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(260, 512)
        Me.Controls.Add(Me.DGJadwalBerangkat)
        Me.Name = "FormJadwal_Keberangkatan"
        Me.Text = "Jadwal Keberangkatan"
        CType(Me.DGJadwalBerangkat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGJadwalBerangkat As DataGridView
End Class
