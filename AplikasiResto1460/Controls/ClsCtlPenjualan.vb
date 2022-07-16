﻿Imports System.Data.Odbc


Public Class ClsCtlPenjualan
    Private SQL As String

    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OdbcDataAdapter("select max(right(id_jual,3)) from penjualan", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "PJ" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function SIMPAN_DATA(ByVal _pbl As ClsEntPenjualan, ByVal _item As List(Of ClsEntDetailJual)) As String
        Dim IDJ As String
        IDJ = ""
        TUTUPKONEKSI()
        With _pbl
            SQL = "CALL SP_INSERTPENJUALAN(" & .Total & ",'" & Format(.Tgljual, "yyyy/MM/dd") & "','" & .IdKasir & "');"
            MsgBox(SQL)
            Try
                DTA = New OdbcDataAdapter(SQL, BUKAKONEKSI)
                DTS = New DataSet
                DTA.Fill(DTS, "TABEL_ID_JUAL")
                IDJ = DTS.Tables("TABEL_ID_JUAL").Rows(0)(0).ToString
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End With
        TUTUPKONEKSI()
        For i = 0 To _item.Count - 1
            With _item(i)
                SQL = "insert into detailjual values ('" & IDJ & "','" & .IdMenu & "'," & .HargaJual & "," & .Qty & ")"
                MsgBox(SQL)
                CMD = New OdbcCommand(SQL, BUKAKONEKSI)
                CMD.CommandType = CommandType.Text
                CMD.ExecuteNonQuery()
                CMD = New OdbcCommand("", TUTUPKONEKSI)
            End With
        Next
        Return IDJ
    End Function
End Class
