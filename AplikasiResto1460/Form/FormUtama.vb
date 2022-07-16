Public Class FormUtama
    Private Sub OlahDataKategoriToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OlahDataKategoriToolStripMenuItem1.Click
        Kategori.Show()
    End Sub

    Private Sub OlahDataBarangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OlahDataBarangToolStripMenuItem1.Click
        Menu.Show()
    End Sub

    Private Sub TransaksiBaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiBaruToolStripMenuItem.Click
        Penjualan.Show()
    End Sub

    Private Sub OlahDataKasirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OlahDataKasirToolStripMenuItem.Click
        Kasir.Show()
    End Sub
End Class