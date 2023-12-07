Imports System.Data.SqlClient

Public Class frmActivityLog
    Private con As SqlConnection
    Private rdr As SqlDataReader
    Private dgw As Object
    Dim cs As String = "Server=DESKTOP-3OMS1N5\SQLEXPRESS;Database=Cavan;Trusted_Connection=True"


    Private Sub frmActivityLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frAdvance.Visible = False
        FillG() 'Fill grid

    End Sub

    Private Sub FillG()
        Try
            con = New SqlConnection(cs)
            con.Open()
            MsgBox("Connection Open")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class
