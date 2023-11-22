Imports System.Data.SqlClient
Public Class Purchase
    Public con As New SqlConnection("server=.\sqlexpress;integrated security=true;database=Production")
    Dim cmd As New SqlCommand()
    Dim bno As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If con.State = ConnectionState.Closed Then con.Open()
        'Try
        'con.Open()
        cmd = New SqlCommand("insert into porder values('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & TextBox2.Text & "','" & ComboBox2.Text & "','" & TextBox3.Text & "','" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("Saved Successfully")
        con.Close()
        'refreshform()
        data()
        'Catch ex As Exception

        'End Try


        If con.State = ConnectionState.Closed Then con.Open()
        Dim cmd1 As New SqlCommand("select * from stock where icode='" & ComboBox2.Text & "'", con)
        Dim cmd2 As New SqlCommand
        Dim dr As SqlDataReader
        dr = cmd1.ExecuteReader
        cmd2.Connection = con
        If dr.Read Then
            dr.Close()
            cmd2.CommandText = "update stock set qty=qty+" & TextBox4.Text & " where icode='" & ComboBox2.Text & "' "
            cmd2.ExecuteNonQuery()
            MsgBox("Thanks For Your Purchasing")
            MsgBox("stock Updated")

        Else
            dr.Close()
            cmd2.CommandText = "insert into stock values('" & ComboBox2.Text & "','" & TextBox3.Text & "'," & TextBox4.Text & ")"
            cmd2.ExecuteNonQuery()
            MsgBox("Thanks For Your Purchasing")
            MsgBox("Stock added Your Account")

            
        End If

        con.Close()
        refreshform()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            con.Open()
            Dim cmd As New SqlCommand
            cmd.CommandText = "update porder set sid='" & ComboBox1.Text & "',sname=' " & TextBox2.Text & " ',icode='" & ComboBox2.Text & "',iname='" & TextBox3.Text & "',odate='" & DateTimePicker1.Text & "',pdate='" & DateTimePicker2.Text & "',qty='" & TextBox4.Text & "',amt='" & TextBox5.Text & "' where pno='" & TextBox1.Text & " ' "
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
            Dim cmd As New SqlCommand("delete from porder where pno='" & TextBox1.Text & "' ", con)
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

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        con.Open()
        Dim da As New SqlDataAdapter("select pno,sid,sname,icode,iname,odate,pdate,qty,amt" & _
        " from porder where pno='" & bno & "' ", con)
        Dim ds As New DataSet
        Dim dt As New DataTable
        da.Fill(ds)
        da.Fill(dt)

        TextBox1.Text = ds.Tables(0).Rows(0).Item(0)
        ComboBox1.Text = ds.Tables(0).Rows(0).Item(1)
        TextBox2.Text = ds.Tables(0).Rows(0).Item(2)
        ComboBox2.Text = ds.Tables(0).Rows(0).Item(3)
        TextBox3.Text = ds.Tables(0).Rows(0).Item(4)
        DateTimePicker1.Text = ds.Tables(0).Rows(0).Item(5)
        DateTimePicker2.Text = ds.Tables(0).Rows(0).Item(6)
        TextBox4.Text = ds.Tables(0).Rows(0).Item(7)
        TextBox5.Text = ds.Tables(0).Rows(0).Item(8)
        con.Close()
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        bno = DataGridView1.CurrentRow.Cells(0).Value
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
            Dim da As New SqlDataAdapter("select * from porder", con)
            Dim ds As New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub order_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        supdata()
        itemdata()
        data()
    End Sub
    Public Sub supdata()
        Try
            con.Open()
            Dim da As New SqlDataAdapter("select supcode from supplier", con)
            Dim dt As New DataTable
            Dim dr As DataRow
            da.Fill(dt)
            con.Close()
            For Each dr In dt.Rows
                ComboBox1.Items.Add(dr.Item(0))
            Next
        Catch ex As Exception

        End Try

    End Sub
    Public Sub itemdata()
        Try
            con.Open()
            Dim da As New SqlDataAdapter("select icode from item", con)
            Dim dt As New DataTable
            Dim dr As DataRow
            da.Fill(dt)
            con.Close()
            For Each dr In dt.Rows
                ComboBox2.Items.Add(dr.Item(0))
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            con.Open()
            Dim da As New SqlDataAdapter("select supname from supplier where supcode='" & ComboBox1.Text & "' ", con)
            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim dr As DataRow
            da.Fill(ds)
            da.Fill(dt)
            con.Close()
            For Each dr In dt.Rows
                TextBox2.Text = dr.Item(0)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            con.Open()
            Dim da As New SqlDataAdapter("select iname from item where icode='" & ComboBox2.Text & "' ", con)
            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim dr As DataRow
            da.Fill(ds)
            da.Fill(dt)
            con.Close()
            For Each dr In dt.Rows
                TextBox3.Text = dr.Item(0)

            Next
        Catch ex As Exception

        End Try
    End Sub
End Class