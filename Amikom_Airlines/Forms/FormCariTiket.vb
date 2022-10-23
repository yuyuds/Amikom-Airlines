Public Class FormCariTiket

    Dim modeProses As Integer
    Dim baris As Integer
    Private e As Object

    Private Sub AturButton(st As Boolean)
        'btnBayar.Enabled = Not st
        'btnCancel.Enabled = Not st
        'btnCariId.Enabled = st

    End Sub

    Private Sub IsiBox(br As Integer)
        If 0 < DTGrid.Rows.Count Then
            With DGCekTiket.Rows(br)
                DGCekTiket.DataSource = DTGrid
            End With
        End If
    End Sub


    Private Sub TampilCari(kunci As String)

        DTGrid = KontrolCariTiket.cariData(kunci).ToTable
        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGCekTiket.DataSource = DTGrid
            DGCekTiket.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGCekTiket.CurrentCell = DGCekTiket.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Kode Tiket Anda Salah")
        End If

    End Sub

    Private Sub FormCariTiket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCekKDPemesanan.Text = ""
        txtCekKDPemesanan.Focus()
        MdiParent = FormUtama
    End Sub
    Private Sub btnCariId_Click_1(sender As Object, e As EventArgs) Handles btnCariId.Click
        If txtCekKDPemesanan.Text = "" Then
            MsgBox("Kode Tiket Belum diisi", MsgBoxStyle.Information, "Info")
        Else
            Call TampilCari(txtCekKDPemesanan.Text)
            txtCekKDPemesanan.Focus()
        End If
    End Sub
End Class