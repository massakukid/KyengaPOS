<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Restaurant_Menu
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
        Me.ThirteenForm1 = New KyengaMeatPalacePOS.ThirteenForm()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TheEmpireButton1 = New KyengaMeatPalacePOS.TheEmpireButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TopShelfDataSet = New KyengaMeatPalacePOS.TopShelfDataSet()
        Me.MenuCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuCategoryTableAdapter = New KyengaMeatPalacePOS.TopShelfDataSetTableAdapters.MenuCategoryTableAdapter()
        Me.MenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuTableAdapter = New KyengaMeatPalacePOS.TopShelfDataSetTableAdapters.MenuTableAdapter()
        Me.ThirteenForm1.SuspendLayout()
        CType(Me.TopShelfDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ThirteenForm1
        '
        Me.ThirteenForm1.AccentColor = System.Drawing.Color.DodgerBlue
        Me.ThirteenForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThirteenForm1.ColorScheme = KyengaMeatPalacePOS.ThirteenForm.ColorSchemes.Dark
        Me.ThirteenForm1.Controls.Add(Me.Button2)
        Me.ThirteenForm1.Controls.Add(Me.TheEmpireButton1)
        Me.ThirteenForm1.Controls.Add(Me.Button1)
        Me.ThirteenForm1.Controls.Add(Me.ComboBox1)
        Me.ThirteenForm1.Controls.Add(Me.TextBox2)
        Me.ThirteenForm1.Controls.Add(Me.TextBox1)
        Me.ThirteenForm1.Controls.Add(Me.Label3)
        Me.ThirteenForm1.Controls.Add(Me.Label2)
        Me.ThirteenForm1.Controls.Add(Me.Label1)
        Me.ThirteenForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThirteenForm1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThirteenForm1.ForeColor = System.Drawing.Color.White
        Me.ThirteenForm1.Location = New System.Drawing.Point(0, 0)
        Me.ThirteenForm1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ThirteenForm1.Name = "ThirteenForm1"
        Me.ThirteenForm1.Size = New System.Drawing.Size(483, 573)
        Me.ThirteenForm1.TabIndex = 0
        Me.ThirteenForm1.Text = "Edit Restaurant Menu"
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(268, 485)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 56)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TheEmpireButton1
        '
        Me.TheEmpireButton1.BackColor = System.Drawing.Color.Transparent
        Me.TheEmpireButton1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheEmpireButton1.Image = Global.KyengaMeatPalacePOS.My.Resources.Resources.icons8_save_48
        Me.TheEmpireButton1.ImageAlignment = KyengaMeatPalacePOS.TheEmpireButton.ImageAlignments.Left
        Me.TheEmpireButton1.Location = New System.Drawing.Point(35, 485)
        Me.TheEmpireButton1.Name = "TheEmpireButton1"
        Me.TheEmpireButton1.Size = New System.Drawing.Size(156, 56)
        Me.TheEmpireButton1.TabIndex = 7
        Me.TheEmpireButton1.Text = "Save"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(387, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MenuBindingSource, "Category", True))
        Me.ComboBox1.DataSource = Me.MenuCategoryBindingSource
        Me.ComboBox1.DisplayMember = "Category"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(26, 239)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(355, 28)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.ValueMember = "Category"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(26, 365)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(355, 57)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(26, 97)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(355, 57)
        Me.TextBox1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 342)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cost/Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Category"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Food/Drink"
        '
        'TopShelfDataSet
        '
        Me.TopShelfDataSet.DataSetName = "TopShelfDataSet"
        Me.TopShelfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuCategoryBindingSource
        '
        Me.MenuCategoryBindingSource.DataMember = "MenuCategory"
        Me.MenuCategoryBindingSource.DataSource = Me.TopShelfDataSet
        '
        'MenuCategoryTableAdapter
        '
        Me.MenuCategoryTableAdapter.ClearBeforeFill = True
        '
        'MenuBindingSource
        '
        Me.MenuBindingSource.DataMember = "Menu"
        Me.MenuBindingSource.DataSource = Me.TopShelfDataSet
        '
        'MenuTableAdapter
        '
        Me.MenuTableAdapter.ClearBeforeFill = True
        '
        'Edit_Restaurant_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 573)
        Me.Controls.Add(Me.ThirteenForm1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Edit_Restaurant_Menu"
        Me.Text = "Edit_Restaurant_Menu"
        Me.ThirteenForm1.ResumeLayout(False)
        Me.ThirteenForm1.PerformLayout()
        CType(Me.TopShelfDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ThirteenForm1 As KyengaMeatPalacePOS.ThirteenForm
    Friend WithEvents TheEmpireButton1 As KyengaMeatPalacePOS.TheEmpireButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TopShelfDataSet As KyengaMeatPalacePOS.TopShelfDataSet
    Friend WithEvents MenuCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuCategoryTableAdapter As KyengaMeatPalacePOS.TopShelfDataSetTableAdapters.MenuCategoryTableAdapter
    Friend WithEvents MenuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuTableAdapter As KyengaMeatPalacePOS.TopShelfDataSetTableAdapters.MenuTableAdapter
End Class
