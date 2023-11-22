Imports System.Data.SqlClient
Public Class Supplier
    Public con As New SqlConnection("server=.\sqlexpress;integrated security=true;database=Production")
    Dim cmd As New SqlCommand()
    Dim sid As String
    Private Sub Supplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        data()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd = New SqlCommand("insert into supplier values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')", con)
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
            cmd.CommandText = "update supplier set supname='" & TextBox2.Text & "',addr=' " & TextBox3.Text & " ',pno='" & TextBox4.Text & "',email='" & TextBox5.Text & "'where supcode='" & TextBox1.Text & " ' "
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
            Dim cmd As New SqlCommand("delete from supplier where supcode='" & TextBox1.Text & "' ", con)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted SucussFully")
            con.Close()
        Catch ex As Exception

        End Try

        refreshform()
        Data()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        refreshform()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
    Private Sub refreshform()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
    Public Sub data()
        Try
            con.Open()
            Dim da As New SqlDataAdapter("select * from supplier", con)
            Dim ds As New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        con.Open()
        Dim da As New SqlDataAdapter("select supcode,supname,addr,pno,email" & _
        " from supplier where supcode='" & sid & "' ", con)
        Dim ds As New DataSet
        Dim dt As New DataTable
        da.Fill(ds)
        da.Fill(dt)

        TextBox1.Text = ds.Tables(0).Rows(0).Item(0)
        TextBox2.Text = ds.Tables(0).Rows(0).Item(1)
        TextBox3.Text = ds.Tables(0).Rows(0).Item(2)
        TextBox4.Text = ds.Tables(0).Rows(0).Item(3)
        TextBox5.Text = ds.Tables(0).Rows(0).Item(4)
        con.Close()
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        sid = DataGridView1.CurrentRow.Cells(0).Value
    End Sub
End Class
