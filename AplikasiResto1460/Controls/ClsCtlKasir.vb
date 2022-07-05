Imports System.Data.Odbc
Public Class ClsCtlKasir : Implements InfProsess

    Public Function InsertData(Ob As Object) As OdbcCommand Implements InfProsess.InsertData
        Throw New NotImplementedException()
    End Function

    Public Function UpdateData(Ob As Object) As OdbcCommand Implements InfProsess.UpdateData
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As OdbcCommand Implements InfProsess.deleteData
        Throw New NotImplementedException()
    End Function

    Public Function tampilData() As DataView Implements InfProsess.tampilData
        Try
            DTA = New OdbcDataAdapter("select * from kasir", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Kasir")
            Dim grid As New DataView(DTS.Tables("Tabel_Kasir"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProsess.cariData
        Throw New NotImplementedException()
    End Function
End Class
