Imports System.Data.OleDb
Module databaseConnection
    Public connStr As String = "Provider=Microsoft.Jet.OleDb.4.0; data source=" & Application.StartupPath & "\DBManager.mdb"
    Public conn As New OleDbConnection(connStr)

    Function connect()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Return True
    End Function
End Module
