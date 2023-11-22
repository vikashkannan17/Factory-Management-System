Imports System.Data.SqlClient
Public Class Item
    Public con As New SqlConnection("server=.\sqlexpress;integrated security=true;database=Production")
    Dim cmd As New SqlCommand()
    Dim iid As String
    Private Sub Item_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Data()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd = New SqlCommand("insert into item values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("Saved Successfully")
        con.Close()
        refreshform()
        Data()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            con.Open()
            Dim cmd As New SqlCommand
            cmd.CommandText = "update item set iname='" & TextBox2.Text & "',price='" & TextBox3.Text & "' where icode='" & TextBox1.Text & " ' "
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            MsgBox("Updated SucussFully")
            con.Close()

        Catch ex As Exception

        End Try
        refreshform()
        Data()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            con.Open()
            Dim cmd As New SqlCommand("delete from item where icode='" & TextBox1.Text & "' ", con)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted SucussFully")
            con.Close()
        Catch ex As Exception

        End Try
        Data()
        refreshform()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        refreshform()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        con.Open()
        Dim da As New SqlDataAdapter("select icode,iname,price" & _
        " from item where icode='" & iid & "' ", con)
        Dim ds As New DataSet
        Dim dt As New DataTable
        da.Fill(ds)
        da.Fill(dt)

        TextBox1.Text = ds.Tables(0).Rows(0).Item(0)
        TextBox2.Text = ds.Tables(0).Rows(0).Item(1)
        TextBox3.Text = ds.Tables(0).Rows(0).Item(2)
        con.Close()
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        iid = DataGridView1.CurrentRow.Cells(0).Value
    End Sub
    Private Sub refreshform()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Public Sub data()
        Try
            con.Open()
            Dim da As New SqlDataAdapter("select * from item", con)
            Dim ds As New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class