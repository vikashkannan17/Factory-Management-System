Public Class Main

    Private Sub SupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierToolStripMenuItem.Click
        Dim frm As New Supplier
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemToolStripMenuItem.Click
        Dim frm As New Item
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseToolStripMenuItem.Click
        Dim frm As New Purchase
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesToolStripMenuItem.Click
        Dim frm As New Sales
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click
        Dim frm As New Stock
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ReorderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReorderToolStripMenuItem.Click
        Dim frm As New CUstomer
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub OrderReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderReportToolStripMenuItem.Click
        Dim frm As New ViewOderReport
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SupplierReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierReportToolStripMenuItem.Click
        Dim frm As New ViewSupplierReport
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DeliveryReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveryReportToolStripMenuItem.Click
        Dim frm As New viewSalesReport
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub StockReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockReportToolStripMenuItem.Click
        Dim frm As New StockReport
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    
End Class