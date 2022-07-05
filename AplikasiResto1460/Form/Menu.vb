Public Class Menu
    Private Sub RefreshGrid()
        DTGrid = KontrolMenu.tampilData.ToTable
        DGMenu.DataSource = DTGrid
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub
End Class