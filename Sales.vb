Imports System.Data.SqlClient
Public Class Sales
    Public con As New SqlConnection("server=.\sqlexpress;integrated security=true;database=Production")
    Dim cmd As New SqlCommand()
    Dim bno As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If con.State = ConnectionState.Closed Then con.Open()
        Try

            cmd = New SqlCommand("insert into sales values('" & TextBox1.Text & "','" & ComboBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox1.Text & "','" & TextBox5.Text & "','" & TextBox2.Text & "','" & DateTimePicker1.Text & "'," & TextBox6.Text & ",'" & TextBox7.Text & "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Saved Successfully")
            con.Close()
            data()
        Catch ex As Exception

        End Try



        If con.State = ConnectionState.Closed Then con.Open()
        Dim cmd1 As New SqlCommand("select * from stock", con)
        Dim cmd2 As New SqlCommand
        Dim dr As SqlDataReader
        dr = cmd1.ExecuteReader
        cmd2.Connection = con
        If dr.Read Then
            dr.Close()
            cmd2.CommandText = "update stock set qty=qty-" & TextBox6.Text & " where icode='" & ComboBox1.Text & "' "
            cmd2.ExecuteNonQuery()
            MsgBox("stock Reduced")
        End If

        con.Close()
        refreshform()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            con.Open()
            Dim cmd As New SqlCommand
            cmd.CommandText = "update sales set cid='" & ComboBox2.Text & "',cname=' " & TextBox3.Text & " ',addr='" & TextBox4.Text & "',icode='" & ComboBox1.Text & "',iname='" & TextBox5.Text & "',price='" & TextBox2.Text & "',sdate='" & DateTimePicker1.Text & "',qty='" & TextBox6.Text & "',amt='" & TextBox7.Text & "' where bno='" & TextBox1.Text & " ' "
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
            Dim cmd As New SqlCommand("delete from sales where bno='" & TextBox1.Text & "' ", con)
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
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub
    Public Sub data()
        Try
            con.Open()
            Dim da As New SqlDataAdapter("select * from sales", con)
            Dim ds As New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
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
                ComboBox1.Items.Add(dr.Item(0))
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Delivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        Dim cmd3 = New SqlCommand("select * from stock where qty<=3", con)
        Dim dr1 As SqlDataReader
        dr1 = cmd3.ExecuteReader
        While dr1.Read
            MsgBox("Reorder: Item Code: " & dr1.Item(0) & "   Item Name : " & dr1.Item(1))
            MsgBox("quantity Low")
        End While
        con.Close()



        itemdata()
        data()
        cusdata()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            con.Open()
            Dim da As New SqlDataAdapter("select iname,price from item where icode='" & ComboBox1.Text & "' ", con)
            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim dr As DataRow
            da.Fill(ds)
            da.Fill(dt)
            con.Close()
            For Each dr In dt.Rows
                TextBox5.Text = dr.Item(0)
                TextBox2.Text = dr.Item(1)

            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        con.Open()
        Dim da As New SqlDataAdapter("select bno,cid,cname,addr,icode,iname,price,sdate,qty,amt" & _
        " from sales where bno='" & bno & "' ", con)
        Dim ds As New DataSet
        Dim dt As New DataTable
        da.Fill(ds)
        da.Fill(dt)

        TextBox1.Text = ds.Tables(0).Rows(0).Item(0)
        ComboBox2.Text = ds.Tables(0).Rows(0).Item(1)
        TextBox3.Text = ds.Tables(0).Rows(0).Item(2)
        TextBox4.Text = ds.Tables(0).Rows(0).Item(3)
        ComboBox1.Text = ds.Tables(0).Rows(0).Item(4)
        TextBox5.Text = ds.Tables(0).Rows(0).Item(5)
        TextBox2.Text = ds.Tables(0).Rows(0).Item(6)
        DateTimePicker1.Text = ds.Tables(0).Rows(0).Item(7)
        TextBox6.Text = ds.Tables(0).Rows(0).Item(8)
        TextBox7.Text = ds.Tables(0).Rows(0).Item(9)
        con.Close()
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        bno = DataGridView1.CurrentRow.Cells(0).Value
    End Sub
    Public Sub cusdata()
        Try
            con.Open()
            Dim da As New SqlDataAdapter("select cid from customer", con)
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

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            con.Open()
            Dim da As New SqlDataAdapter("select cname from customer where cid='" & ComboBox2.Text & "' ", con)
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

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        TextBox7.Text = Val(TextBox2.Text) * Val(TextBox6.Text)
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        TextBox7.Text = Val(TextBox2.Text) * Val(TextBox6.Text)
    End Sub

   
    Private Sub DataGridView1_CellContentDoubleClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        con.Open()
        Dim da As New SqlDataAdapter("select bno,cid,cname,addr,icode,iname,price,sdate,qty,amt" & _
        " from sales where bno='" & bno & "' ", con)
        Dim ds As New DataSet
        Dim dt As New DataTable
        da.Fill(ds)
        da.Fill(dt)

        TextBox1.Text = ds.Tables(0).Rows(0).Item(0)
        ComboBox2.Text = ds.Tables(0).Rows(0).Item(1)
        TextBox3.Text = ds.Tables(0).Rows(0).Item(2)
        TextBox4.Text = ds.Tables(0).Rows(0).Item(3)
        ComboBox1.Text = ds.Tables(0).Rows(0).Item(4)
        TextBox5.Text = ds.Tables(0).Rows(0).Item(5)
        TextBox2.Text = ds.Tables(0).Rows(0).Item(6)
        DateTimePicker1.Text = ds.Tables(0).Rows(0).Item(7)
        TextBox6.Text = ds.Tables(0).Rows(0).Item(8)
        TextBox7.Text = ds.Tables(0).Rows(0).Item(9)
        con.Close()
    End Sub

    Private Sub DataGridView1_SelectionChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        bno = DataGridView1.CurrentRow.Cells(0).Value
    End Sub
End Class