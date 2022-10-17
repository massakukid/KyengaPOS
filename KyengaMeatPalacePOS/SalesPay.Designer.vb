<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesPay
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PrintDlg = New System.Windows.Forms.PrintDialog()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.TheEmpireThemeContainer1 = New KyengaMeatPalacePOS.TheEmpireThemeContainer()
        Me.TheEmpireButton14 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TheEmpireButton13 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.TheEmpireButton12 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.TheEmpireButton11 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.TheEmpireButton10 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.TheEmpireButton9 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.TheEmpireButton8 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.TheEmpireButton7 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.TheEmpireButton6 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.TheEmpireButton5 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.TheEmpireButton4 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.TheEmpireButton3 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.TheEmpireButton2 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.TheEmpireButton1 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.TheEmpireThemeContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDlg
        '
        Me.PrintDlg.UseEXDialog = True
        '
        'PrintDoc
        '
        '
        'TheEmpireThemeContainer1
        '
        Me.TheEmpireThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TheEmpireButton14)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.DataGridView1)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.Label8)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.Label7)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.Label6)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.Label5)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.Label4)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.Label3)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.Label2)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TextBox1)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.Label1)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TheEmpireButton13)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TheEmpireButton12)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TheEmpireButton11)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TheEmpireButton10)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TheEmpireButton9)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TheEmpireButton8)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TheEmpireButton7)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TheEmpireButton6)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TheEmpireButton5)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TheEmpireButton4)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TheEmpireButton3)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TheEmpireButton2)
        Me.TheEmpireThemeContainer1.Controls.Add(Me.TheEmpireButton1)
        Me.TheEmpireThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TheEmpireThemeContainer1.ForeColor = System.Drawing.Color.White
        Me.TheEmpireThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.TheEmpireThemeContainer1.Name = "TheEmpireThemeContainer1"
        Me.TheEmpireThemeContainer1.Size = New System.Drawing.Size(767, 520)
        Me.TheEmpireThemeContainer1.TabIndex = 77
        Me.TheEmpireThemeContainer1.Text = "Transaction Payment"
        '
        'TheEmpireButton14
        '
        Me.TheEmpireButton14.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton14.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton14.Image = Nothing
        Me.TheEmpireButton14.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton14.Location = New System.Drawing.Point(550, 409)
        Me.TheEmpireButton14.Name = "TheEmpireButton14"
        Me.TheEmpireButton14.Size = New System.Drawing.Size(205, 71)
        Me.TheEmpireButton14.TabIndex = 23
        Me.TheEmpireButton14.Text = "Exit"
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(339, 185)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(10, 10)
        Me.DataGridView1.TabIndex = 22
        Me.DataGridView1.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "ProductCode"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "ProductName"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "PUnit"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Units"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "TotalCost"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Category"
        Me.Column6.Name = "Column6"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(288, 350)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Label8"
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(545, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 30)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Ksh."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(286, 299)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 30)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Ksh."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(606, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 30)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "00.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(347, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 30)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "00.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(560, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 37)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "BALANCE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(292, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 37)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "TOTAL COST"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(465, 119)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(243, 37)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(293, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 37)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "CASH PAID:"
        '
        'TheEmpireButton13
        '
        Me.TheEmpireButton13.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton13.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton13.Image = Nothing
        Me.TheEmpireButton13.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton13.Location = New System.Drawing.Point(27, 409)
        Me.TheEmpireButton13.Name = "TheEmpireButton13"
        Me.TheEmpireButton13.Size = New System.Drawing.Size(237, 71)
        Me.TheEmpireButton13.TabIndex = 12
        Me.TheEmpireButton13.Text = "ENTER"
        '
        'TheEmpireButton12
        '
        Me.TheEmpireButton12.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton12.Image = Global.KyengaMeatPalacePOS.My.Resources.Resources.icons8_double_tick_24__1_
        Me.TheEmpireButton12.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton12.Location = New System.Drawing.Point(189, 306)
        Me.TheEmpireButton12.Name = "TheEmpireButton12"
        Me.TheEmpireButton12.Size = New System.Drawing.Size(75, 71)
        Me.TheEmpireButton12.TabIndex = 11
        '
        'TheEmpireButton11
        '
        Me.TheEmpireButton11.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton11.Image = Nothing
        Me.TheEmpireButton11.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton11.Location = New System.Drawing.Point(27, 306)
        Me.TheEmpireButton11.Name = "TheEmpireButton11"
        Me.TheEmpireButton11.Size = New System.Drawing.Size(75, 71)
        Me.TheEmpireButton11.TabIndex = 10
        Me.TheEmpireButton11.Text = "C"
        '
        'TheEmpireButton10
        '
        Me.TheEmpireButton10.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton10.Image = Nothing
        Me.TheEmpireButton10.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton10.Location = New System.Drawing.Point(108, 306)
        Me.TheEmpireButton10.Name = "TheEmpireButton10"
        Me.TheEmpireButton10.Size = New System.Drawing.Size(75, 71)
        Me.TheEmpireButton10.TabIndex = 9
        Me.TheEmpireButton10.Text = "0"
        '
        'TheEmpireButton9
        '
        Me.TheEmpireButton9.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton9.Image = Nothing
        Me.TheEmpireButton9.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton9.Location = New System.Drawing.Point(189, 229)
        Me.TheEmpireButton9.Name = "TheEmpireButton9"
        Me.TheEmpireButton9.Size = New System.Drawing.Size(75, 71)
        Me.TheEmpireButton9.TabIndex = 8
        Me.TheEmpireButton9.Text = "9"
        '
        'TheEmpireButton8
        '
        Me.TheEmpireButton8.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton8.Image = Nothing
        Me.TheEmpireButton8.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton8.Location = New System.Drawing.Point(108, 229)
        Me.TheEmpireButton8.Name = "TheEmpireButton8"
        Me.TheEmpireButton8.Size = New System.Drawing.Size(75, 71)
        Me.TheEmpireButton8.TabIndex = 7
        Me.TheEmpireButton8.Text = "8"
        '
        'TheEmpireButton7
        '
        Me.TheEmpireButton7.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton7.Image = Nothing
        Me.TheEmpireButton7.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton7.Location = New System.Drawing.Point(27, 229)
        Me.TheEmpireButton7.Name = "TheEmpireButton7"
        Me.TheEmpireButton7.Size = New System.Drawing.Size(75, 71)
        Me.TheEmpireButton7.TabIndex = 6
        Me.TheEmpireButton7.Text = "7"
        '
        'TheEmpireButton6
        '
        Me.TheEmpireButton6.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton6.Image = Nothing
        Me.TheEmpireButton6.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton6.Location = New System.Drawing.Point(189, 152)
        Me.TheEmpireButton6.Name = "TheEmpireButton6"
        Me.TheEmpireButton6.Size = New System.Drawing.Size(75, 71)
        Me.TheEmpireButton6.TabIndex = 5
        Me.TheEmpireButton6.Text = "6"
        '
        'TheEmpireButton5
        '
        Me.TheEmpireButton5.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton5.Image = Nothing
        Me.TheEmpireButton5.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton5.Location = New System.Drawing.Point(108, 152)
        Me.TheEmpireButton5.Name = "TheEmpireButton5"
        Me.TheEmpireButton5.Size = New System.Drawing.Size(75, 71)
        Me.TheEmpireButton5.TabIndex = 4
        Me.TheEmpireButton5.Text = "5"
        '
        'TheEmpireButton4
        '
        Me.TheEmpireButton4.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton4.Image = Nothing
        Me.TheEmpireButton4.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton4.Location = New System.Drawing.Point(27, 152)
        Me.TheEmpireButton4.Name = "TheEmpireButton4"
        Me.TheEmpireButton4.Size = New System.Drawing.Size(75, 71)
        Me.TheEmpireButton4.TabIndex = 3
        Me.TheEmpireButton4.Text = "4"
        '
        'TheEmpireButton3
        '
        Me.TheEmpireButton3.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton3.Image = Nothing
        Me.TheEmpireButton3.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton3.Location = New System.Drawing.Point(189, 75)
        Me.TheEmpireButton3.Name = "TheEmpireButton3"
        Me.TheEmpireButton3.Size = New System.Drawing.Size(75, 71)
        Me.TheEmpireButton3.TabIndex = 2
        Me.TheEmpireButton3.Text = "3"
        '
        'TheEmpireButton2
        '
        Me.TheEmpireButton2.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton2.Image = Nothing
        Me.TheEmpireButton2.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton2.Location = New System.Drawing.Point(108, 75)
        Me.TheEmpireButton2.Name = "TheEmpireButton2"
        Me.TheEmpireButton2.Size = New System.Drawing.Size(75, 71)
        Me.TheEmpireButton2.TabIndex = 14
        Me.TheEmpireButton2.Text = "2"
        '
        'TheEmpireButton1
        '
        Me.TheEmpireButton1.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton1.Image = Nothing
        Me.TheEmpireButton1.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton1.Location = New System.Drawing.Point(27, 75)
        Me.TheEmpireButton1.Name = "TheEmpireButton1"
        Me.TheEmpireButton1.Size = New System.Drawing.Size(75, 71)
        Me.TheEmpireButton1.TabIndex = 0
        Me.TheEmpireButton1.Text = "1"
        '
        'SalesPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 520)
        Me.Controls.Add(Me.TheEmpireThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SalesPay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SalesPay"
        Me.TransparencyKey = System.Drawing.Color.DodgerBlue
        Me.TheEmpireThemeContainer1.ResumeLayout(False)
        Me.TheEmpireThemeContainer1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TheEmpireThemeContainer1 As KyengaMeatPalacePOS.TheEmpireThemeContainer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TheEmpireButton13 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents TheEmpireButton12 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents TheEmpireButton11 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents TheEmpireButton10 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents TheEmpireButton9 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents TheEmpireButton8 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents TheEmpireButton7 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents TheEmpireButton6 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents TheEmpireButton5 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents TheEmpireButton4 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents TheEmpireButton3 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents TheEmpireButton2 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents TheEmpireButton1 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PrintDlg As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TheEmpireButton14 As KyengaMeatPalacePOS.TheEmpireButton
End Class
