<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopShelfDataSet = New KyengaMeatPalacePOS.TopShelfDataSet()
        Me.WaiterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DrawerExpenditureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesTableAdapter = New KyengaMeatPalacePOS.TopShelfDataSetTableAdapters.SalesTableAdapter()
        Me.WaiterTableAdapter = New KyengaMeatPalacePOS.TopShelfDataSetTableAdapters.WaiterTableAdapter()
        Me.DrawerExpenditureTableAdapter = New KyengaMeatPalacePOS.TopShelfDataSetTableAdapters.DrawerExpenditureTableAdapter()
        Me.ProductNameTableAdapter = New KyengaMeatPalacePOS.TopShelfDataSetTableAdapters.ProductNameTableAdapter()
        Me.ReceiptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiptTableAdapter = New KyengaMeatPalacePOS.TopShelfDataSetTableAdapters.ReceiptTableAdapter()
        Me.PrintDlg = New System.Windows.Forms.PrintDialog()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.ThirteenForm1 = New KyengaMeatPalacePOS.ThirteenForm()
        Me.ElegantThemeTabControlVertical1 = New KyengaMeatPalacePOS.ElegantThemeTabControlVertical()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.ALL = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TheEmpireButton4 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TheEmpireButton3 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.TheEmpireButton2 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.TheEmpireButton1 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AscTabControl1 = New KyengaMeatPalacePOS.ascTabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Punit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TheEmpireButton7 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.TheEmpireButton6 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.TheEmpireButton5 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.AscTabControl2 = New KyengaMeatPalacePOS.ascTabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SalesIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaiterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentMethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView12 = New System.Windows.Forms.DataGridView()
        Me.Column25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ElegantThemeGroupBox1 = New KyengaMeatPalacePOS.ElegantThemeGroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.AscTabControl3 = New KyengaMeatPalacePOS.ascTabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCostDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashierDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TheEmpireButton10 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.TheEmpireButton9 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.TheEmpireButton8 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopShelfDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaiterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrawerExpenditureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ThirteenForm1.SuspendLayout()
        Me.ElegantThemeTabControlVertical1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.AscTabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.AscTabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.ElegantThemeGroupBox1.SuspendLayout()
        Me.AscTabControl3.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "Sales"
        Me.SalesBindingSource.DataSource = Me.TopShelfDataSet
        '
        'TopShelfDataSet
        '
        Me.TopShelfDataSet.DataSetName = "TopShelfDataSet"
        Me.TopShelfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WaiterBindingSource
        '
        Me.WaiterBindingSource.DataMember = "Waiter"
        Me.WaiterBindingSource.DataSource = Me.TopShelfDataSet
        '
        'DrawerExpenditureBindingSource
        '
        Me.DrawerExpenditureBindingSource.DataMember = "DrawerExpenditure"
        Me.DrawerExpenditureBindingSource.DataSource = Me.TopShelfDataSet
        '
        'ProductNameBindingSource
        '
        Me.ProductNameBindingSource.DataMember = "ProductName"
        Me.ProductNameBindingSource.DataSource = Me.TopShelfDataSet
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'WaiterTableAdapter
        '
        Me.WaiterTableAdapter.ClearBeforeFill = True
        '
        'DrawerExpenditureTableAdapter
        '
        Me.DrawerExpenditureTableAdapter.ClearBeforeFill = True
        '
        'ProductNameTableAdapter
        '
        Me.ProductNameTableAdapter.ClearBeforeFill = True
        '
        'ReceiptBindingSource
        '
        Me.ReceiptBindingSource.DataMember = "Receipt"
        Me.ReceiptBindingSource.DataSource = Me.TopShelfDataSet
        '
        'ReceiptTableAdapter
        '
        Me.ReceiptTableAdapter.ClearBeforeFill = True
        '
        'PrintDlg
        '
        Me.PrintDlg.UseEXDialog = True
        '
        'PrintDoc
        '
        '
        'ThirteenForm1
        '
        Me.ThirteenForm1.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenForm1.ColorScheme = KyengaMeatPalacePOS.ThirteenForm.ColorSchemes.Dark
        Me.ThirteenForm1.Controls.Add(Me.ElegantThemeTabControlVertical1)
        Me.ThirteenForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThirteenForm1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThirteenForm1.ForeColor = System.Drawing.Color.White
        Me.ThirteenForm1.Location = New System.Drawing.Point(0, 0)
        Me.ThirteenForm1.Name = "ThirteenForm1"
        Me.ThirteenForm1.Size = New System.Drawing.Size(1331, 686)
        Me.ThirteenForm1.TabIndex = 0
        Me.ThirteenForm1.Text = "Restaurant Sales"
        '
        'ElegantThemeTabControlVertical1
        '
        Me.ElegantThemeTabControlVertical1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.ElegantThemeTabControlVertical1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ElegantThemeTabControlVertical1.BorderColour = System.Drawing.Color.DodgerBlue
        Me.ElegantThemeTabControlVertical1.Controls.Add(Me.TabPage1)
        Me.ElegantThemeTabControlVertical1.Controls.Add(Me.TabPage3)
        Me.ElegantThemeTabControlVertical1.Controls.Add(Me.TabPage5)
        Me.ElegantThemeTabControlVertical1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.ElegantThemeTabControlVertical1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElegantThemeTabControlVertical1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ElegantThemeTabControlVertical1.ItemSize = New System.Drawing.Size(100, 95)
        Me.ElegantThemeTabControlVertical1.Location = New System.Drawing.Point(3, 32)
        Me.ElegantThemeTabControlVertical1.Multiline = True
        Me.ElegantThemeTabControlVertical1.Name = "ElegantThemeTabControlVertical1"
        Me.ElegantThemeTabControlVertical1.NormalColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ElegantThemeTabControlVertical1.PressedTabColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ElegantThemeTabControlVertical1.SelectedIndex = 0
        Me.ElegantThemeTabControlVertical1.Size = New System.Drawing.Size(1325, 654)
        Me.ElegantThemeTabControlVertical1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.ElegantThemeTabControlVertical1.TabIndex = 0
        Me.ElegantThemeTabControlVertical1.TextColour = System.Drawing.Color.White
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.DataGridView4)
        Me.TabPage1.Controls.Add(Me.ALL)
        Me.TabPage1.Controls.Add(Me.FlowLayoutPanel2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.FlowLayoutPanel1)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.AscTabControl1)
        Me.TabPage1.Location = New System.Drawing.Point(99, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1222, 646)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Restaurant Sales"
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(638, 15)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(10, 10)
        Me.DataGridView4.TabIndex = 10
        Me.DataGridView4.Visible = False
        '
        'ALL
        '
        Me.ALL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ALL.BackColor = System.Drawing.Color.Transparent
        Me.ALL.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALL.Image = Nothing
        Me.ALL.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.ALL.Location = New System.Drawing.Point(1014, 16)
        Me.ALL.Name = "ALL"
        Me.ALL.Size = New System.Drawing.Size(200, 55)
        Me.ALL.TabIndex = 9
        Me.ALL.Text = "ALL"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.AutoScroll = True
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(1014, 77)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(200, 452)
        Me.FlowLayoutPanel2.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TheEmpireButton4)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TheEmpireButton3)
        Me.Panel1.Controls.Add(Me.TheEmpireButton2)
        Me.Panel1.Controls.Add(Me.TheEmpireButton1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(6, 535)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1208, 105)
        Me.Panel1.TabIndex = 7
        '
        'TheEmpireButton4
        '
        Me.TheEmpireButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TheEmpireButton4.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton4.Image = Nothing
        Me.TheEmpireButton4.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton4.Location = New System.Drawing.Point(1017, 37)
        Me.TheEmpireButton4.Name = "TheEmpireButton4"
        Me.TheEmpireButton4.Size = New System.Drawing.Size(174, 52)
        Me.TheEmpireButton4.TabIndex = 10
        Me.TheEmpireButton4.Text = "OTHER"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(485, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 52)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TheEmpireButton3
        '
        Me.TheEmpireButton3.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton3.Image = Global.KyengaMeatPalacePOS.My.Resources.Resources.icons8_delete_48__1_
        Me.TheEmpireButton3.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton3.Location = New System.Drawing.Point(339, 37)
        Me.TheEmpireButton3.Name = "TheEmpireButton3"
        Me.TheEmpireButton3.Size = New System.Drawing.Size(140, 52)
        Me.TheEmpireButton3.TabIndex = 5
        Me.TheEmpireButton3.Text = "Delete"
        '
        'TheEmpireButton2
        '
        Me.TheEmpireButton2.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton2.Image = Global.KyengaMeatPalacePOS.My.Resources.Resources.icons8_save_48
        Me.TheEmpireButton2.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton2.Location = New System.Drawing.Point(193, 37)
        Me.TheEmpireButton2.Name = "TheEmpireButton2"
        Me.TheEmpireButton2.Size = New System.Drawing.Size(140, 52)
        Me.TheEmpireButton2.TabIndex = 4
        Me.TheEmpireButton2.Text = "Save"
        '
        'TheEmpireButton1
        '
        Me.TheEmpireButton1.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton1.Image = Nothing
        Me.TheEmpireButton1.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton1.Location = New System.Drawing.Point(24, 42)
        Me.TheEmpireButton1.Name = "TheEmpireButton1"
        Me.TheEmpireButton1.Size = New System.Drawing.Size(140, 47)
        Me.TheEmpireButton1.TabIndex = 3
        Me.TheEmpireButton1.Text = "Refresh"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sale Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(170, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "00.00"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(278, 79)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(730, 450)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(250, 16)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(337, 54)
        Me.TextBox1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(146, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dish/Drink:"
        '
        'AscTabControl1
        '
        Me.AscTabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AscTabControl1.Controls.Add(Me.TabPage2)
        Me.AscTabControl1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AscTabControl1.ItemSize = New System.Drawing.Size(0, 34)
        Me.AscTabControl1.Location = New System.Drawing.Point(6, 77)
        Me.AscTabControl1.Name = "AscTabControl1"
        Me.AscTabControl1.Padding = New System.Drawing.Point(24, 0)
        Me.AscTabControl1.SelectedIndex = 0
        Me.AscTabControl1.Size = New System.Drawing.Size(270, 452)
        Me.AscTabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.ForeColor = System.Drawing.Color.Black
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(262, 410)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Order Details"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductCode, Me.Quantity, Me.ITEM, Me.Punit, Me.Amount, Me.Category})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 5
        Me.DataGridView1.RowTemplate.Height = 70
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(256, 404)
        Me.DataGridView1.TabIndex = 0
        '
        'ProductCode
        '
        Me.ProductCode.HeaderText = "ProductCode"
        Me.ProductCode.Name = "ProductCode"
        Me.ProductCode.ReadOnly = True
        Me.ProductCode.Visible = False
        Me.ProductCode.Width = 105
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 95
        '
        'ITEM
        '
        Me.ITEM.HeaderText = "ITEM"
        Me.ITEM.Name = "ITEM"
        Me.ITEM.ReadOnly = True
        Me.ITEM.Width = 70
        '
        'Punit
        '
        Me.Punit.HeaderText = "Unit Price"
        Me.Punit.Name = "Punit"
        Me.Punit.ReadOnly = True
        Me.Punit.Width = 102
        '
        'Amount
        '
        Me.Amount.HeaderText = "Cost"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.Width = 65
        '
        'Category
        '
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        Me.Category.Visible = False
        Me.Category.Width = 98
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Controls.Add(Me.AscTabControl2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(99, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1222, 646)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Restaurant Sales Records"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.TheEmpireButton7)
        Me.Panel2.Controls.Add(Me.TheEmpireButton6)
        Me.Panel2.Controls.Add(Me.TheEmpireButton5)
        Me.Panel2.Location = New System.Drawing.Point(1042, 172)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(175, 409)
        Me.Panel2.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(9, 285)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 50)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TheEmpireButton7
        '
        Me.TheEmpireButton7.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton7.Image = Nothing
        Me.TheEmpireButton7.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton7.Location = New System.Drawing.Point(9, 209)
        Me.TheEmpireButton7.Name = "TheEmpireButton7"
        Me.TheEmpireButton7.Size = New System.Drawing.Size(156, 54)
        Me.TheEmpireButton7.TabIndex = 2
        Me.TheEmpireButton7.Text = "Refresh"
        '
        'TheEmpireButton6
        '
        Me.TheEmpireButton6.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton6.Image = Global.KyengaMeatPalacePOS.My.Resources.Resources.icons8_delete_48__1_
        Me.TheEmpireButton6.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton6.Location = New System.Drawing.Point(9, 135)
        Me.TheEmpireButton6.Name = "TheEmpireButton6"
        Me.TheEmpireButton6.Size = New System.Drawing.Size(156, 54)
        Me.TheEmpireButton6.TabIndex = 1
        Me.TheEmpireButton6.Text = "Delete"
        '
        'TheEmpireButton5
        '
        Me.TheEmpireButton5.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton5.Image = Global.KyengaMeatPalacePOS.My.Resources.Resources.icons8_microsoft_excel_48
        Me.TheEmpireButton5.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton5.Location = New System.Drawing.Point(9, 64)
        Me.TheEmpireButton5.Name = "TheEmpireButton5"
        Me.TheEmpireButton5.Size = New System.Drawing.Size(156, 54)
        Me.TheEmpireButton5.TabIndex = 0
        Me.TheEmpireButton5.Text = "Export To Excel"
        '
        'AscTabControl2
        '
        Me.AscTabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AscTabControl2.Controls.Add(Me.TabPage4)
        Me.AscTabControl2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AscTabControl2.ItemSize = New System.Drawing.Size(0, 34)
        Me.AscTabControl2.Location = New System.Drawing.Point(3, 110)
        Me.AscTabControl2.Name = "AscTabControl2"
        Me.AscTabControl2.Padding = New System.Drawing.Point(24, 0)
        Me.AscTabControl2.SelectedIndex = 0
        Me.AscTabControl2.Size = New System.Drawing.Size(1033, 536)
        Me.AscTabControl2.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.DataGridView2)
        Me.TabPage4.ForeColor = System.Drawing.Color.Black
        Me.TabPage4.Location = New System.Drawing.Point(4, 38)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1025, 494)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Restaurant Sales Records"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.SalesIDDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.ReceiptIDDataGridViewTextBoxColumn, Me.BarcodeDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.PUnitDataGridViewTextBoxColumn, Me.TotalCostDataGridViewTextBoxColumn, Me.CashierDataGridViewTextBoxColumn, Me.WaiterDataGridViewTextBoxColumn, Me.DayIDDataGridViewTextBoxColumn, Me.PaymentMethodDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.SalesBindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(1019, 488)
        Me.DataGridView2.TabIndex = 0
        '
        'Column1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = "Reprint"
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "Reprint"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = "Reprint"
        Me.Column1.Width = 72
        '
        'SalesIDDataGridViewTextBoxColumn
        '
        Me.SalesIDDataGridViewTextBoxColumn.DataPropertyName = "SalesID"
        Me.SalesIDDataGridViewTextBoxColumn.HeaderText = "SalesID"
        Me.SalesIDDataGridViewTextBoxColumn.Name = "SalesIDDataGridViewTextBoxColumn"
        Me.SalesIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SalesIDDataGridViewTextBoxColumn.Visible = False
        Me.SalesIDDataGridViewTextBoxColumn.Width = 85
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateDataGridViewTextBoxColumn.Width = 67
        '
        'ReceiptIDDataGridViewTextBoxColumn
        '
        Me.ReceiptIDDataGridViewTextBoxColumn.DataPropertyName = "ReceiptID"
        Me.ReceiptIDDataGridViewTextBoxColumn.HeaderText = "Receipt NO."
        Me.ReceiptIDDataGridViewTextBoxColumn.Name = "ReceiptIDDataGridViewTextBoxColumn"
        Me.ReceiptIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReceiptIDDataGridViewTextBoxColumn.Width = 106
        '
        'BarcodeDataGridViewTextBoxColumn
        '
        Me.BarcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode"
        Me.BarcodeDataGridViewTextBoxColumn.HeaderText = "Product Code"
        Me.BarcodeDataGridViewTextBoxColumn.Name = "BarcodeDataGridViewTextBoxColumn"
        Me.BarcodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.BarcodeDataGridViewTextBoxColumn.Width = 117
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductNameDataGridViewTextBoxColumn.Width = 123
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoryDataGridViewTextBoxColumn.Width = 98
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuantityDataGridViewTextBoxColumn.Width = 95
        '
        'PUnitDataGridViewTextBoxColumn
        '
        Me.PUnitDataGridViewTextBoxColumn.DataPropertyName = "PUnit"
        Me.PUnitDataGridViewTextBoxColumn.HeaderText = "Price/Unit"
        Me.PUnitDataGridViewTextBoxColumn.Name = "PUnitDataGridViewTextBoxColumn"
        Me.PUnitDataGridViewTextBoxColumn.ReadOnly = True
        Me.PUnitDataGridViewTextBoxColumn.Width = 105
        '
        'TotalCostDataGridViewTextBoxColumn
        '
        Me.TotalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost"
        Me.TotalCostDataGridViewTextBoxColumn.HeaderText = "Total Cost"
        Me.TotalCostDataGridViewTextBoxColumn.Name = "TotalCostDataGridViewTextBoxColumn"
        Me.TotalCostDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalCostDataGridViewTextBoxColumn.Width = 96
        '
        'CashierDataGridViewTextBoxColumn
        '
        Me.CashierDataGridViewTextBoxColumn.DataPropertyName = "Cashier"
        Me.CashierDataGridViewTextBoxColumn.HeaderText = "User"
        Me.CashierDataGridViewTextBoxColumn.Name = "CashierDataGridViewTextBoxColumn"
        Me.CashierDataGridViewTextBoxColumn.ReadOnly = True
        Me.CashierDataGridViewTextBoxColumn.Width = 66
        '
        'WaiterDataGridViewTextBoxColumn
        '
        Me.WaiterDataGridViewTextBoxColumn.DataPropertyName = "Waiter"
        Me.WaiterDataGridViewTextBoxColumn.HeaderText = "Waiter"
        Me.WaiterDataGridViewTextBoxColumn.Name = "WaiterDataGridViewTextBoxColumn"
        Me.WaiterDataGridViewTextBoxColumn.ReadOnly = True
        Me.WaiterDataGridViewTextBoxColumn.Visible = False
        Me.WaiterDataGridViewTextBoxColumn.Width = 80
        '
        'DayIDDataGridViewTextBoxColumn
        '
        Me.DayIDDataGridViewTextBoxColumn.DataPropertyName = "DayID"
        Me.DayIDDataGridViewTextBoxColumn.HeaderText = "Day ID"
        Me.DayIDDataGridViewTextBoxColumn.Name = "DayIDDataGridViewTextBoxColumn"
        Me.DayIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DayIDDataGridViewTextBoxColumn.Width = 75
        '
        'PaymentMethodDataGridViewTextBoxColumn
        '
        Me.PaymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod"
        Me.PaymentMethodDataGridViewTextBoxColumn.HeaderText = "Payment Method"
        Me.PaymentMethodDataGridViewTextBoxColumn.Name = "PaymentMethodDataGridViewTextBoxColumn"
        Me.PaymentMethodDataGridViewTextBoxColumn.ReadOnly = True
        Me.PaymentMethodDataGridViewTextBoxColumn.Width = 141
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGridView12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1209, 101)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search By"
        '
        'DataGridView12
        '
        Me.DataGridView12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView12.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column25, Me.Column26, Me.Column27, Me.Column28, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView12.Location = New System.Drawing.Point(914, 34)
        Me.DataGridView12.Name = "DataGridView12"
        Me.DataGridView12.Size = New System.Drawing.Size(10, 10)
        Me.DataGridView12.TabIndex = 9
        Me.DataGridView12.Visible = False
        '
        'Column25
        '
        Me.Column25.HeaderText = "ProductsName"
        Me.Column25.Name = "Column25"
        '
        'Column26
        '
        Me.Column26.HeaderText = "Units"
        Me.Column26.Name = "Column26"
        '
        'Column27
        '
        Me.Column27.HeaderText = "UnitPrice"
        Me.Column27.Name = "Column27"
        '
        'Column28
        '
        Me.Column28.HeaderText = "TotalCost"
        Me.Column28.Name = "Column28"
        '
        'Column2
        '
        Me.Column2.HeaderText = "ReceiptNo"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Date"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "User"
        Me.Column4.Name = "Column4"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(974, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 10)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Label13"
        Me.Label13.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SalesBindingSource, "Cashier", True))
        Me.ComboBox1.DataSource = Me.WaiterBindingSource
        Me.ComboBox1.DisplayMember = "Names"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(638, 50)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(248, 28)
        Me.ComboBox1.TabIndex = 8
        Me.ComboBox1.ValueMember = "Names"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(634, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Waiter."
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(523, 51)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 27)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MMM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(369, 51)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(148, 27)
        Me.DateTimePicker2.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MMM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(215, 51)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(148, 27)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(365, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "To."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "From."
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(10, 51)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(179, 27)
        Me.TextBox2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Receipt NO."
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.ElegantThemeGroupBox1)
        Me.TabPage5.Controls.Add(Me.AscTabControl3)
        Me.TabPage5.Controls.Add(Me.Panel4)
        Me.TabPage5.Controls.Add(Me.Panel3)
        Me.TabPage5.Location = New System.Drawing.Point(99, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1222, 646)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Drawer Expenditure"
        '
        'ElegantThemeGroupBox1
        '
        Me.ElegantThemeGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ElegantThemeGroupBox1.BorderColour = System.Drawing.Color.DodgerBlue
        Me.ElegantThemeGroupBox1.Controls.Add(Me.TextBox6)
        Me.ElegantThemeGroupBox1.Controls.Add(Me.TextBox5)
        Me.ElegantThemeGroupBox1.Controls.Add(Me.Label12)
        Me.ElegantThemeGroupBox1.Controls.Add(Me.Label11)
        Me.ElegantThemeGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ElegantThemeGroupBox1.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ElegantThemeGroupBox1.Location = New System.Drawing.Point(427, 3)
        Me.ElegantThemeGroupBox1.MainColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ElegantThemeGroupBox1.Name = "ElegantThemeGroupBox1"
        Me.ElegantThemeGroupBox1.Size = New System.Drawing.Size(788, 112)
        Me.ElegantThemeGroupBox1.TabIndex = 5
        Me.ElegantThemeGroupBox1.Text = "Search Box"
        Me.ElegantThemeGroupBox1.TextColour = System.Drawing.Color.White
        '
        'TextBox6
        '
        Me.TextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox6.Location = New System.Drawing.Point(219, 68)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(162, 25)
        Me.TextBox6.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.Location = New System.Drawing.Point(18, 68)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(183, 25)
        Me.TextBox5.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(215, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 19)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Day ID."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 19)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Product Name."
        '
        'AscTabControl3
        '
        Me.AscTabControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AscTabControl3.Controls.Add(Me.TabPage6)
        Me.AscTabControl3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AscTabControl3.ItemSize = New System.Drawing.Size(0, 34)
        Me.AscTabControl3.Location = New System.Drawing.Point(427, 121)
        Me.AscTabControl3.Name = "AscTabControl3"
        Me.AscTabControl3.Padding = New System.Drawing.Point(24, 0)
        Me.AscTabControl3.SelectedIndex = 0
        Me.AscTabControl3.Size = New System.Drawing.Size(792, 416)
        Me.AscTabControl3.TabIndex = 4
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage6.Controls.Add(Me.DataGridView3)
        Me.TabPage6.ForeColor = System.Drawing.Color.Black
        Me.TabPage6.Location = New System.Drawing.Point(4, 38)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(784, 374)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "DataBase Records"
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn1, Me.TotalCostDataGridViewTextBoxColumn1, Me.DateDataGridViewTextBoxColumn1, Me.CashierDataGridViewTextBoxColumn1, Me.DayIDDataGridViewTextBoxColumn1})
        Me.DataGridView3.DataSource = Me.DrawerExpenditureBindingSource
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(778, 368)
        Me.DataGridView3.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductNameDataGridViewTextBoxColumn1
        '
        Me.ProductNameDataGridViewTextBoxColumn1.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn1.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn1.Name = "ProductNameDataGridViewTextBoxColumn1"
        Me.ProductNameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TotalCostDataGridViewTextBoxColumn1
        '
        Me.TotalCostDataGridViewTextBoxColumn1.DataPropertyName = "TotalCost"
        Me.TotalCostDataGridViewTextBoxColumn1.HeaderText = "TotalCost"
        Me.TotalCostDataGridViewTextBoxColumn1.Name = "TotalCostDataGridViewTextBoxColumn1"
        Me.TotalCostDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn1
        '
        Me.DateDataGridViewTextBoxColumn1.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn1.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn1.Name = "DateDataGridViewTextBoxColumn1"
        Me.DateDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CashierDataGridViewTextBoxColumn1
        '
        Me.CashierDataGridViewTextBoxColumn1.DataPropertyName = "Cashier"
        Me.CashierDataGridViewTextBoxColumn1.HeaderText = "Cashier"
        Me.CashierDataGridViewTextBoxColumn1.Name = "CashierDataGridViewTextBoxColumn1"
        Me.CashierDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DayIDDataGridViewTextBoxColumn1
        '
        Me.DayIDDataGridViewTextBoxColumn1.DataPropertyName = "DayID"
        Me.DayIDDataGridViewTextBoxColumn1.HeaderText = "DayID"
        Me.DayIDDataGridViewTextBoxColumn1.Name = "DayIDDataGridViewTextBoxColumn1"
        Me.DayIDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button5)
        Me.Panel4.Controls.Add(Me.TheEmpireButton10)
        Me.Panel4.Controls.Add(Me.TheEmpireButton9)
        Me.Panel4.Controls.Add(Me.TheEmpireButton8)
        Me.Panel4.Location = New System.Drawing.Point(3, 543)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1214, 100)
        Me.Panel4.TabIndex = 3
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(572, 22)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(163, 55)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Exit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TheEmpireButton10
        '
        Me.TheEmpireButton10.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton10.Image = Global.KyengaMeatPalacePOS.My.Resources.Resources.icons8_delete_48__1_
        Me.TheEmpireButton10.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton10.Location = New System.Drawing.Point(403, 22)
        Me.TheEmpireButton10.Name = "TheEmpireButton10"
        Me.TheEmpireButton10.Size = New System.Drawing.Size(163, 55)
        Me.TheEmpireButton10.TabIndex = 2
        Me.TheEmpireButton10.Text = "Delete"
        '
        'TheEmpireButton9
        '
        Me.TheEmpireButton9.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton9.Image = Global.KyengaMeatPalacePOS.My.Resources.Resources.icons8_microsoft_excel_48
        Me.TheEmpireButton9.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton9.Location = New System.Drawing.Point(234, 22)
        Me.TheEmpireButton9.Name = "TheEmpireButton9"
        Me.TheEmpireButton9.Size = New System.Drawing.Size(163, 55)
        Me.TheEmpireButton9.TabIndex = 1
        Me.TheEmpireButton9.Text = "Export To Excel"
        '
        'TheEmpireButton8
        '
        Me.TheEmpireButton8.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton8.Image = Global.KyengaMeatPalacePOS.My.Resources.Resources.icons8_save_48
        Me.TheEmpireButton8.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton8.Location = New System.Drawing.Point(65, 22)
        Me.TheEmpireButton8.Name = "TheEmpireButton8"
        Me.TheEmpireButton8.Size = New System.Drawing.Size(163, 55)
        Me.TheEmpireButton8.TabIndex = 0
        Me.TheEmpireButton8.Text = "Save"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.TextBox4)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.ComboBox2)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(418, 534)
        Me.Panel3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(24, 406)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(300, 27)
        Me.TextBox4.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 373)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 20)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Total Cost"
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(330, 233)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 28)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Add New"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DrawerExpenditureBindingSource, "ProductName", True))
        Me.ComboBox2.DataSource = Me.ProductNameBindingSource
        Me.ComboBox2.DisplayMember = "ProductName"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(24, 233)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(300, 28)
        Me.ComboBox2.TabIndex = 3
        Me.ComboBox2.ValueMember = "ProductName"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Product Name"
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Location = New System.Drawing.Point(24, 102)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(300, 27)
        Me.TextBox3.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Receipt Number."
        '
        'Sales
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1331, 686)
        Me.Controls.Add(Me.ThirteenForm1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Sales"
        Me.Text = "Sales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopShelfDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaiterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrawerExpenditureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ThirteenForm1.ResumeLayout(False)
        Me.ElegantThemeTabControlVertical1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.AscTabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.AscTabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.ElegantThemeGroupBox1.ResumeLayout(False)
        Me.ElegantThemeGroupBox1.PerformLayout()
        Me.AscTabControl3.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ThirteenForm1 As KyengaMeatPalacePOS.ThirteenForm
    Friend WithEvents ElegantThemeTabControlVertical1 As KyengaMeatPalacePOS.ElegantThemeTabControlVertical
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TheEmpireButton4 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents ALL As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TheEmpireButton3 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents TheEmpireButton2 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents TheEmpireButton1 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AscTabControl1 As KyengaMeatPalacePOS.ascTabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents AscTabControl2 As KyengaMeatPalacePOS.ascTabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TheEmpireButton7 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents TheEmpireButton6 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents TheEmpireButton5 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ElegantThemeGroupBox1 As KyengaMeatPalacePOS.ElegantThemeGroupBox
    Friend WithEvents AscTabControl3 As KyengaMeatPalacePOS.ascTabControl
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TheEmpireButton10 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents TheEmpireButton9 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents TheEmpireButton8 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TopShelfDataSet As KyengaMeatPalacePOS.TopShelfDataSet
    Friend WithEvents SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesTableAdapter As KyengaMeatPalacePOS.TopShelfDataSetTableAdapters.SalesTableAdapter
    Friend WithEvents WaiterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WaiterTableAdapter As KyengaMeatPalacePOS.TopShelfDataSetTableAdapters.WaiterTableAdapter
    Friend WithEvents DrawerExpenditureBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DrawerExpenditureTableAdapter As KyengaMeatPalacePOS.TopShelfDataSetTableAdapters.DrawerExpenditureTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCostDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CashierDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DayIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductNameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductNameTableAdapter As KyengaMeatPalacePOS.TopShelfDataSetTableAdapters.ProductNameTableAdapter
    Friend WithEvents ProductsName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceiptTableAdapter As KyengaMeatPalacePOS.TopShelfDataSetTableAdapters.ReceiptTableAdapter
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents SalesIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiptIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BarcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PUnitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CashierDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaiterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DayIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentMethodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintDlg As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents DataGridView12 As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Column25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents ProductCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Punit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
