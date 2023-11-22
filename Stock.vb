Imports System.Data.SqlClient
Public Class Stock
    Public con As New SqlConnection("server=.\sqlexpress;integrated security=true;database=Production")
    Dim cmd As New SqlCommand()
    Private Sub Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        data()
    End Sub
    Public Sub data()
        Try
            con.Open()
            Dim da As New SqlDataAdapter("select * from stock", con)
            Dim ds As New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class