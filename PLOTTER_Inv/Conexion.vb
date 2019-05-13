'Imports System.Data
'Imports System.Data.OleDb
'Module Conexion
'    Public cnnBD As OleDbConnection
'    Public cmd As OleDbCommand
'    Public dtr As OleDbDataReader
'    Public CadenaConexion As String
'    Public ID_ACCESO As Byte
'    Public Seleccion As Integer = 0
'    Sub AbrirConexion()
'        Try
'            cnnBD = New OleDbConnection
'            CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + My.Computer.FileSystem.CurrentDirectory + "\Revisado_D.accdb"
'            cnnBD.ConnectionString = CadenaConexion
'            cnnBD.Open()
'        Catch ex As Exception
'            MessageBox.Show("Error " & Err.Number.ToString & vbCrLf & ex.Message)
'        End Try
'    End Sub
'End Module
