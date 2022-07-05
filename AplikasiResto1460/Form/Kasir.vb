Public Class Kasir
    Private Sub RefreshGrid()
        DTGrid = KontrolKasir.tampilData.ToTable
        DGKasir.DataSource = DTGrid
    End Sub
    Private Sub Kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub
End Class