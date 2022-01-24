Imports System.Data.SqlClient
Module Module1
    Public conString As String = ("server=Home-PC;Database=TDBNew;integrated security=true")
    Public con As New SqlConnection(conString)
End Module
