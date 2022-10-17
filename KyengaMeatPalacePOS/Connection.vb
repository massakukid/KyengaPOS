Imports System.Data
Imports System.Data.OleDb
Module Connection
    Public strcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\TopShelf.accdb"
    Public sqlcon As OleDbConnection
    Public datast As New DataSet
    Public adapter As New OleDbDataAdapter
    Public bindingsrc As BindingSource
    Public reader As OleDbDataReader
    Public sql As String
    Public cmd As New OleDbCommand
    Public tables As DataTableCollection
    Public source1 As New BindingSource
End Module
