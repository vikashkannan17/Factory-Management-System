<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrderReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SupplierReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeliveryReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StockReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.ReportToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(913, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupplierToolStripMenuItem, Me.ItemToolStripMenuItem, Me.ReorderToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'ItemToolStripMenuItem
        '
        Me.ItemToolStripMenuItem.Name = "ItemToolStripMenuItem"
        Me.ItemToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ItemToolStripMenuItem.Text = "Item"
        '
        'ReorderToolStripMenuItem
        '
        Me.ReorderToolStripMenuItem.Name = "ReorderToolStripMenuItem"
        Me.ReorderToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReorderToolStripMenuItem.Text = "Customer"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseToolStripMenuItem, Me.SalesToolStripMenuItem, Me.StockToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.TransactionToolStripMenuItem.Text = "Product"
        '
        'PurchaseToolStripMenuItem
        '
        Me.PurchaseToolStripMenuItem.Name = "PurchaseToolStripMenuItem"
        Me.PurchaseToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.PurchaseToolStripMenuItem.Text = "Master  Indent Module"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.SalesToolStripMenuItem.Text = "Product sales"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.StockToolStripMenuItem.Text = "Products Stock"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderReportToolStripMenuItem, Me.SupplierReportToolStripMenuItem, Me.DeliveryReportToolStripMenuItem, Me.StockReportToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'OrderReportToolStripMenuItem
        '
        Me.OrderReportToolStripMenuItem.Name = "OrderReportToolStripMenuItem"
        Me.OrderReportToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.OrderReportToolStripMenuItem.Text = "Purchase Report"
        '
        'SupplierReportToolStripMenuItem
        '
        Me.SupplierReportToolStripMenuItem.Name = "SupplierReportToolStripMenuItem"
        Me.SupplierReportToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SupplierReportToolStripMenuItem.Text = "Supplier Report"
        '
        'DeliveryReportToolStripMenuItem
        '
        Me.DeliveryReportToolStripMenuItem.Name = "DeliveryReportToolStripMenuItem"
        Me.DeliveryReportToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.DeliveryReportToolStripMenuItem.Text = "Sales Report"
        '
        'StockReportToolStripMenuItem
        '
        Me.StockReportToolStripMenuItem.Name = "StockReportToolStripMenuItem"
        Me.StockReportToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.StockReportToolStripMenuItem.Text = "Stock Report"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = Global.Factory.My.Resources.Resources.Factory___4___Zaha
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(913, 375)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factory Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeliveryReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
