Imports System.Data.SqlClient
Public Class Reorder
    Public con As New SqlConnection("server=.;uid=sa;pwd=;database=Mgt")
    Dim cmd As New SqlCommand()

    Private Sub Reorder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        Dim cmd3 = New SqlCommand("select * from stock where qty<=2", con)
        Dim dr1 As SqlDataReader
        dr1 = cmd3.ExecuteReader
        While dr1.Read
            MsgBox("Reorder: Item Code: " & dr1.Item(0) & "   Item Name : " & dr1.Item(1))
            MsgBox("quantity Low")
        End While
        con.Close()
    End Sub
End Class