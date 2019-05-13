Imports System.Data
Imports System.Data.OleDb
Module Module1
    Public cnnBD As OleDbConnection
    Public cmd As OleDbCommand
    Public dtr As OleDbDataReader
    Public ID_ACCESO As Byte
    Public Seleccion As Integer = 0
    Public CF As Boolean
    Public ELIMINA As Boolean
    Public SER As Boolean
    Public CAD As Boolean
    Public V2D As Boolean
    Public V3D As Boolean
    Public V22D As Boolean
    Public Function fnStrCnn(ByVal parTipoBD As Byte) As String

        Dim sCnn As String = ""
        Dim sBd As String = ""
        Dim oBd As String = ""
        sBd = "C:\BD_Imag\Revisado_D.accdb"
        Dim sUser As String = ""
        Dim sPWD As String = ""

        Select Case parTipoBD
            Case 0
                sCnn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & sBd & _
                        ";User ID=" & sUser & ";Password=" & sPWD & ";"
            Case 1
                sCnn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & sBd & _
                        ";User ID=" & sUser & ";Password=" & sPWD & ";"
        End Select
        Return sCnn
    End Function
End Module
