Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms.DataGridView
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Text
Imports System.Drawing.Printing
Public Class Sales
    Dim WithEvents ReceiptPD As New PrintDocument
    Dim WithEvents KitchenPD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Dim ReceiptImage As Bitmap
    Private Count_control As Integer = 0
    Private Location_control As New Point(10, 50)

    Private Sub create_button()

        Dim TA As New TopShelfDataSetTableAdapters.MenuTableAdapter
        Dim TB = TA.GetData()

        If TB.Rows.Count = 0 Then
        Else
            FlowLayoutPanel1.Controls.Clear()
            For Each row As TopShelfDataSet.MenuRow In TB.Rows

                'SET NEW BUTTON
                Dim new_Button As New TheEmpireButton
                'ADD THE PROPER TIES OF THE BUTTON
                new_Button.Name = row.Name
                new_Button.Text = row.Name
                Dim sahii As New Font("Segoe UI", 11, FontStyle.Bold)
                new_Button.Font = sahii
                new_Button.Location = New Point(Location_control.X + 10, Location_control.Y)
                new_Button.Width = 170
                new_Button.Height = 60
                Location_control.Y += new_Button.Height + 10

                'CREATE THE EVENT HANDLER
                AddHandler new_Button.Click, AddressOf myButtonHandler_Click
                'ADD THE NEW BUTTON TO THE COLLECTION OF CONTROLS
                FlowLayoutPanel1.Controls.Add(new_Button)
            Next

        End If
    End Sub

    Private Sub create_Categorybutton()

        Dim TA As New TopShelfDataSetTableAdapters.MenuCategoryTableAdapter
        Dim TB = TA.GetData()

        If TB.Rows.Count = 0 Then
        Else
            FlowLayoutPanel2.Controls.Clear()
            For Each row As TopShelfDataSet.MenuCategoryRow In TB.Rows

                'SET NEW BUTTON
                Dim new_Button As New TheEmpireButton
                'ADD THE PROPER TIES OF THE BUTTON
                new_Button.Name = row.Category
                new_Button.Text = row.Category
                Dim sahii As New Font("Segoe UI", 11, FontStyle.Bold)
                new_Button.Font = sahii
                new_Button.Location = New Point(Location_control.X + 10, Location_control.Y)
                new_Button.Width = 170
                new_Button.Height = 60
                Location_control.Y += new_Button.Height + 10

                'CREATE THE EVENT HANDLER
                AddHandler new_Button.Click, AddressOf myCategoryButtonHandler_Click
                'ADD THE NEW BUTTON TO THE COLLECTION OF CONTROLS
                FlowLayoutPanel2.Controls.Add(new_Button)
            Next

        End If
    End Sub

    Private Sub myButtonHandler_Click(ByVal sender As Object, ByVal e As EventArgs)
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        'VERIFYING THE BUTTONS
        If TypeOf sender Is TheEmpireButton Then
            Dim TA As New TopShelfDataSetTableAdapters.MenuTableAdapter
            Dim TB = TA.GetDataByName(sender.Text)

            If TB.Rows.Count = 0 Then
                MsgBox("ITEM NOT FOUND IN MENU RECORDS. PLEASE TRY AGAIN", MsgBoxStyle.Information)
                Exit Sub
            Else
                Dim R As TopShelfDataSet.MenuRow = TB.Rows(0)

                Dim D As Integer
                Dim ItemLoc As Integer = -1
                For D = 0 To DataGridView1.Rows.Count - 1
                    If R.ID = DataGridView1.Rows(D).Cells(0).Value Then
                        'Item Found
                        ItemLoc = D
                        Exit For
                    End If

                Next

                'Item not found add it to dgv
                If ItemLoc = -1 Then
                    Dim k As Object = InputBox("PLEASE ENTER THE QUANTITY ORDERED?")

                    If k.Trim().Length = 0 Then
                        'Dim Result As String = MsgBox("Aborted by the User.", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)
                        Exit Sub
                    Else
                        Dim cp As Decimal = k * R.Cost
                        DataGridView1.Rows.Add(R.ID, k, sender.text, R.Cost, k * R.Cost, R.Category)
                        Label2.Text = Val(Format(Label2.Text, "General Number")) + cp
                        Label2.Text = Format(Label2.Text, "standard")
                    End If
                Else
                    Dim UnitPrice As Decimal = DataGridView1.Rows(ItemLoc).Cells(3).Value
                    Dim Qty As Long = DataGridView1.Rows(ItemLoc).Cells(1).Value
                    Qty += 1
                    Dim amt As Decimal = UnitPrice * Qty
                    DataGridView1.Rows(ItemLoc).Cells(1).Value = Qty
                    DataGridView1.Rows(ItemLoc).Cells(4).Value = amt

                    Label2.Text = Val(Format(Label2.Text, "General Number")) + UnitPrice
                    Label2.Text = Format(Label2.Text, "standard")


                End If
            End If
        End If
    End Sub

    Private Sub myCategoryButtonHandler_Click(ByVal sender As Object, ByVal e As EventArgs)
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TypeOf sender Is TheEmpireButton Then
            'VERIFYING THE BUTTONS
            Dim TA As New TopShelfDataSetTableAdapters.MenuTableAdapter
            Dim TB = TA.GetDataByCategory(sender.Text)

            If TB.Rows.Count = 0 Then
            Else
                FlowLayoutPanel1.Controls.Clear()
                For Each row As TopShelfDataSet.MenuRow In TB.Rows

                    'SET NEW BUTTON
                    Dim new_Button As New TheEmpireButton
                    'ADD THE PROPER TIES OF THE BUTTON
                    new_Button.Name = row.Name
                    new_Button.Text = row.Name
                    Dim sahii As New Font("Segoe UI", 11, FontStyle.Bold)
                    new_Button.Font = sahii
                    new_Button.Location = New Point(Location_control.X + 10, Location_control.Y)
                    new_Button.Width = 170
                    new_Button.Height = 60
                    Location_control.Y += new_Button.Height + 10

                    'CREATE THE EVENT HANDLER
                    AddHandler new_Button.Click, AddressOf myButtonHandler_Click
                    'ADD THE NEW BUTTON TO THE COLLECTION OF CONTROLS
                    FlowLayoutPanel1.Controls.Add(new_Button)
                Next

            End If
        End If

    End Sub

    Private Sub Sales_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        Me.Dispose()
        MainWindow.Show()
        MainWindow.Label1.Visible = True
        MainWindow.Label2.Visible = True
        MainWindow.Panel1.Visible = True
        MainWindow.PictureBox1.Visible = True
        MainWindow.PictureBox2.Visible = True
        MainWindow.PictureBox3.Visible = True
        MainWindow.PictureBox4.Visible = True
        MainWindow.TheEmpireButton1.Visible = True
        MainWindow.TheEmpireButton2.Visible = True
    End Sub

    Private Sub Sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TopShelfDataSet.Receipt' table. You can move, or remove it, as needed.
        Me.ReceiptTableAdapter.Fill(Me.TopShelfDataSet.Receipt)
        'TODO: This line of code loads data into the 'TopShelfDataSet.ProductName' table. You can move, or remove it, as needed.
        Me.ProductNameTableAdapter.Fill(Me.TopShelfDataSet.ProductName)
        'TODO: This line of code loads data into the 'TopShelfDataSet.Waiter' table. You can move, or remove it, as needed.
        Me.WaiterTableAdapter.Fill(Me.TopShelfDataSet.Waiter)
        create_button()
        create_Categorybutton()

        Dim CurrentDate As Date = Date.Now
        Dim Interval As Integer = -3
        Dim result As Date = CurrentDate.AddDays(Interval)
        'DateAdd(DateInterval.Day, -3, Date.Now)
        Try
            sqlcon = New OleDbConnection(strcon)
            sqlcon.Open()

            If sqlcon.State = ConnectionState.Open Then
                Dim TKHA As New TopShelfDataSetTableAdapters.SalesTableAdapter
                Dim DKHS As New TopShelfDataSet.SalesDataTable
                TKHA.FillByDate(DKHS, result, Date.Now)

                source1.DataSource = DKHS
                DataGridView2.DataSource = DKHS
            Else
                MsgBox("DATABASE CONNECTION UNSUCCESSFUL.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ERROR")
        End Try

        Try
            sqlcon = New OleDbConnection(strcon)
            sqlcon.Open()

            If sqlcon.State = ConnectionState.Open Then
                Dim TKHA As New TopShelfDataSetTableAdapters.DrawerExpenditureTableAdapter
                Dim DKHS As New TopShelfDataSet.DrawerExpenditureDataTable
                TKHA.FillByDate(DKHS, result, Date.Now)

                source1.DataSource = DKHS
                DataGridView3.DataSource = DKHS
            Else
                MsgBox("DATABASE CONNECTION UNSUCCESSFUL.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ERROR")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        sqlcon = New OleDbConnection(strcon)
        sqlcon.Open()

        If sqlcon.State = ConnectionState.Open Then
            datast = New DataSet
            tables = datast.Tables
            sql = "SELECT Name FROM Menu WHERE Name LIKE '%" & TextBox1.Text & "%'"
            adapter = New OleDbDataAdapter(sql, sqlcon)
            adapter.Fill(datast, sql)

            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView4.DataSource = view

            FlowLayoutPanel1.Controls.Clear()
            For Each row As DataGridViewRow In DataGridView4.Rows
                If row.Cells(0).FormattedValue <> "" Then
                    'For Each row As TopShelfDataSet.MenuRow In view

                    'SET NEW BUTTON
                    Dim new_Button As New TheEmpireButton
                    'ADD THE PROPER TIES OF THE BUTTON
                    new_Button.Name = CStr(row.Cells(0).FormattedValue)
                    new_Button.Text = CStr(row.Cells(0).FormattedValue)
                    Dim sahii As New Font("Segoe UI", 11, FontStyle.Bold)
                    new_Button.Font = sahii
                    new_Button.Location = New Point(Location_control.X + 10, Location_control.Y)
                    new_Button.Width = 170
                    new_Button.Height = 60
                    Location_control.Y += new_Button.Height + 10

                    'CREATE THE EVENT HANDLER
                    AddHandler new_Button.Click, AddressOf myButtonHandler_Click
                    'ADD THE NEW BUTTON TO THE COLLECTION OF CONTROLS
                    FlowLayoutPanel1.Controls.Add(new_Button)
                End If
            Next
        Else
            MsgBox("DATABASE CONNECTION UNSUCCESSFUL.", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub ALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALL.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        create_button()
    End Sub

    Private Sub TheEmpireButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton3.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        'Remove item from dgv
        If DataGridView1.CurrentRow.IsNewRow Then
            MsgBox("NO RECORD FOUND. PLEASE SELECT A VALID ROW.", MsgBoxStyle.Information)
            Exit Sub
        Else
            Dim total As Decimal = DataGridView1.SelectedRows(0).Cells(4).Value
            Dim Salettl As Decimal = Label2.Text
            Dim newsalettl As Decimal = Salettl - total
            Label2.Text = newsalettl
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        End If

    End Sub

    Private Sub TheEmpireButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton1.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        DataGridView1.Rows.Clear()
        Label2.Text = 0.0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
        MainWindow.Show()
        MainWindow.Label1.Visible = True
        MainWindow.Label2.Visible = True
        MainWindow.Panel1.Visible = True
        MainWindow.PictureBox1.Visible = True
        MainWindow.PictureBox2.Visible = True
        MainWindow.PictureBox3.Visible = True
        MainWindow.PictureBox4.Visible = True
        MainWindow.TheEmpireButton1.Visible = True
        MainWindow.TheEmpireButton2.Visible = True
    End Sub

    Private Sub TheEmpireButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton2.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If DataGridView1.Rows.Count = 1 Then
            MsgBox("NO ORDERS HAVE BEEN MADE. PLEASE SELECT ITEMS FOR SALE.", MsgBoxStyle.Information)
            Exit Sub
        Else
            Dim TotalCost As Decimal = Label2.Text
            SalesPay.Label4.Text = TotalCost
            SalesPay.DataGridView1.Rows.Clear()
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(0).FormattedValue <> "" Then
                    SalesPay.DataGridView1.Rows.Add(CStr(row.Cells(0).FormattedValue), CStr(row.Cells(2).FormattedValue), CStr(row.Cells(3).FormattedValue), CStr(row.Cells(1).FormattedValue), CStr(row.Cells(4).FormattedValue), CStr(row.Cells(5).FormattedValue))
                End If
            Next
            SalesPay.TextBox1.Focus()
            SalesPay.Show()
        End If

    End Sub

    Private Sub TheEmpireButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton5.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If DataGridView2.RowCount = Nothing Then
            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = DataGridView2.RowCount - 1
            colsTotal = DataGridView2.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView2.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView2.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TextBox2.Text.Trim().Length = 0 Then

            Dim finalday As Date
            Dim filterdate As Date = Date.Now
            finalday = DateAdd(DateInterval.Day, 5, filterdate)

            Try
                sqlcon = New OleDbConnection(strcon)
                sqlcon.Open()

                If sqlcon.State = ConnectionState.Open Then
                    Dim TSA As New TopShelfDataSetTableAdapters.SalesTableAdapter
                    Dim DSS As New TopShelfDataSet.SalesDataTable
                    TSA.FillByDate(DSS, Date.Now, finalday)

                    source1.DataSource = DSS
                    DataGridView2.DataSource = DSS
                Else
                    MsgBox("DATABASE CONNECTION UNSUCCESSFUL.", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ERROR")
            End Try
        Else
            Try
                sqlcon = New OleDbConnection(strcon)
                sqlcon.Open()

                If sqlcon.State = ConnectionState.Open Then
                    datast = New DataSet
                    tables = datast.Tables
                    sql = "SELECT SalesID, Barcode, [Date], ProductName, PUnit, Quantity, TotalCost, ReceiptID, Cashier, Category, Waiter, DayID, PaymentMethod FROM Sales WHERE ReceiptID LIKE '%" & TextBox2.Text & "%'"
                    adapter = New OleDbDataAdapter(sql, sqlcon)
                    adapter.Fill(datast, sql)

                    Dim view As New DataView(tables(0))
                    source1.DataSource = view
                    DataGridView2.DataSource = view
                Else
                    MsgBox("DATABASE CONNECTION UNSUCCESSFUL.", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ERROR")
            End Try
            sqlcon.Close()
            sqlcon.Dispose()
            sqlcon = Nothing
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        Dim CurrentDate As Date = CDate(DateTimePicker2.Text)
        Dim Interval As Integer = 1
        Dim result As Date = CurrentDate.AddDays(Interval)
        'DateAdd(DateInterval.Day, -3, Date.Now)
        'Try
        '    sqlcon = New OleDbConnection(strcon)
        '    sqlcon.Open()

        '    If sqlcon.State = ConnectionState.Open Then
        '        Dim TKHA As New TopShelfDataSetTableAdapters.SalesTableAdapter
        '        Dim DKHS As New TopShelfDataSet.SalesDataTable
        '        TKHA.FillByDate(DKHS, result, Date.Now)

        '        source1.DataSource = DKHS
        '        DataGridView2.DataSource = DKHS
        '    Else
        '        MsgBox("DATABASE CONNECTION UNSUCCESSFUL.", MsgBoxStyle.Exclamation)
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ERROR")
        'End Try

        Try
            sqlcon = New OleDbConnection(strcon)
            sqlcon.Open()

            If sqlcon.State = ConnectionState.Open Then
                Dim TSA As New TopShelfDataSetTableAdapters.SalesTableAdapter
                Dim DSS As New TopShelfDataSet.SalesDataTable
                TSA.FillByDate(DSS, DateTimePicker1.Text, result)

                source1.DataSource = DSS
                DataGridView2.DataSource = DSS
            Else
                MsgBox("DATABASE CONNECTION UNSUCCESSFUL.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ERROR")
        End Try

        'Try
        '    sqlcon = New OleDbConnection(strcon)
        '    sqlcon.Open()

        '    If sqlcon.State = ConnectionState.Open Then
        '        datast = New DataSet
        '        tables = datast.Tables
        '        sql = "SELECT SalesID, Barcode, [Date], ProductName, PUnit, Quantity, TotalCost, ReceiptID, Cashier, Category, Waiter, DayID, PaymentMethod FROM Sales WHERE [Date] BETWEEN '%" & CDate(DateTimePicker1.Text) & "%' AND '%" & CDate(DateTimePicker2.Text) & "%'"
        '        adapter = New OleDbDataAdapter(sql, sqlcon)
        '        adapter.Fill(datast, sql)

        '        Dim view As New DataView(tables(0))
        '        source1.DataSource = view
        '        DataGridView2.DataSource = view
        '    Else
        '        MsgBox("DATABASE CONNECTION UNSUCCESSFUL.", MsgBoxStyle.Exclamation)
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ERROR")
        'End Try
        'sqlcon.Close()
        'sqlcon.Dispose()
        'sqlcon = Nothing
    End Sub

    Private Sub ComboBox1_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.DropDownClosed
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        Try
            sqlcon = New OleDbConnection(strcon)
            sqlcon.Open()

            If sqlcon.State = ConnectionState.Open Then
                datast = New DataSet
                tables = datast.Tables
                sql = "SELECT SalesID, Barcode, [Date], ProductName, PUnit, Quantity, TotalCost, ReceiptID, Cashier, Category, Waiter, DayID, PaymentMethod FROM Sales WHERE Waiter LIKE '%" & ComboBox1.Text & "%'"
                adapter = New OleDbDataAdapter(sql, sqlcon)
                adapter.Fill(datast, sql)

                Dim view As New DataView(tables(0))
                source1.DataSource = view
                DataGridView2.DataSource = view
            Else
                MsgBox("DATABASE CONNECTION UNSUCCESSFUL.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ERROR")
        End Try
        sqlcon.Close()
        sqlcon.Dispose()
        sqlcon = Nothing
    End Sub

    Private Sub TheEmpireButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton7.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        'TODO: This line of code loads data into the 'TopShelfDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.TopShelfDataSet.Sales)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
        MainWindow.Show()
        MainWindow.Label1.Visible = True
        MainWindow.Label2.Visible = True
        MainWindow.Panel1.Visible = True
        MainWindow.PictureBox1.Visible = True
        MainWindow.PictureBox2.Visible = True
        MainWindow.PictureBox3.Visible = True
        MainWindow.PictureBox4.Visible = True
        MainWindow.TheEmpireButton1.Visible = True
        MainWindow.TheEmpireButton2.Visible = True
    End Sub

    Private Sub TheEmpireButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton6.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        Try
            If DataGridView2.CurrentRow.IsNewRow Then
                MsgBox("NO RECORD FOUND. PLEASE SELECT A VALID ROW.", MsgBoxStyle.Information)
                Exit Sub
            Else
                If MessageBox.Show("ARE YOU SURE YOU'D LIKE TO DELETE THIS RECORD?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

                    'create the adapter
                    Dim TDC As New TopShelfDataSetTableAdapters.ReceiptTableAdapter

                    'Delete the item
                    TDC.DeleteByID(DataGridView2.SelectedRows(0).Cells(2).Value)
                    TDC.Fill(TopShelfDataSet.Receipt)

                    'create the adapter
                    Dim TC As New TopShelfDataSetTableAdapters.SalesTableAdapter

                    'Delete the item
                    TC.DeleteByReceiptID(DataGridView2.SelectedRows(0).Cells(2).Value)
                    TC.Fill(TopShelfDataSet.Sales)

                    'close window and return ok
                    MsgBox("DELETE SUCCESSFUL.", MsgBoxStyle.Information)

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Dispose()
        MainWindow.Show()
        MainWindow.Label1.Visible = True
        MainWindow.Label2.Visible = True
        MainWindow.Panel1.Visible = True
        MainWindow.PictureBox1.Visible = True
        MainWindow.PictureBox2.Visible = True
        MainWindow.PictureBox3.Visible = True
        MainWindow.PictureBox4.Visible = True
        MainWindow.TheEmpireButton1.Visible = True
        MainWindow.TheEmpireButton2.Visible = True
    End Sub

    Private Sub TheEmpireButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton9.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If DataGridView3.RowCount = Nothing Then
            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = DataGridView3.RowCount - 1
            colsTotal = DataGridView3.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView3.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView3.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        Dim Prompt As String = String.Empty
        Dim Title As String = String.Empty

        Dim ProductName As Object
        'set prompt
        Prompt = "PLEASE ENTER THE NEW EXPENSE ITEM."
        'set title
        Title = "NEW EXPENDITURE ITEM."

        ProductName = InputBox(Prompt, Title)

        Try
            sqlcon = New OleDbConnection(strcon)
            sqlcon.Open()

            If sqlcon.State = ConnectionState.Open Then
                cmd.CommandType = System.Data.CommandType.Text
                cmd.CommandText = "INSERT INTO ProductName (ProductName) VALUES (?)"

                cmd = New OleDbCommand(cmd.CommandText, sqlcon)
                'If ProductName.Trim().Length > 47 Then
                '    MsgBox("The number of characters used are too many. Please enter a product name with less than 47 characters(including spacing between words.)", MsgBoxStyle.Information)
                '    Exit Sub
                'End If
                'If ProductName.Contains("'") Then
                '    MsgBox("Apostrophe key is diabled. Please use the slash(/) key." & vbNewLine & "Product Name NOT SAVED!!", MsgBoxStyle.Information)
                '    Exit Sub
                'End If
                If ProductName.Trim().Length = 0 Then
                    Dim Result As String = MsgBox("PROCESS ABORTED.", MsgBoxStyle.OkOnly)
                    Exit Sub
                Else
                    cmd.Parameters.Add("@ProductName", OleDbType.Char).Value = ProductName.ToUpper
                End If

                cmd.ExecuteNonQuery()
                MessageBox.Show("Data is Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'TODO: This line of code loads data into the 'TopShelfDataSet.Menu' table. You can move, or remove it, as needed.
                Me.ProductNameTableAdapter.Fill(Me.TopShelfDataSet.ProductName)
            Else
                MsgBox("DATABASE CONNECTION UNSUCCESSFUL.", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        sqlcon.Close()
        sqlcon.Dispose()
        sqlcon = Nothing
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        Try
            sqlcon = New OleDbConnection(strcon)
            sqlcon.Open()

            If sqlcon.State = ConnectionState.Open Then
                datast = New DataSet
                tables = datast.Tables
                sql = "SELECT ID, ProductName, TotalCost, [Date], Cashier, DayID FROM DrawerExpenditure WHERE ProductName LIKE '%" & TextBox5.Text & "%'"
                adapter = New OleDbDataAdapter(sql, sqlcon)
                adapter.Fill(datast, sql)

                Dim view As New DataView(tables(0))
                source1.DataSource = view
                DataGridView3.DataSource = view
            Else
                MsgBox("DATABASE CONNECTION UNSUCCESSFUL.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ERROR")
        End Try
        sqlcon.Close()
        sqlcon.Dispose()
        sqlcon = Nothing
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        Try
            sqlcon = New OleDbConnection(strcon)
            sqlcon.Open()

            If sqlcon.State = ConnectionState.Open Then
                datast = New DataSet
                tables = datast.Tables
                sql = "SELECT ID, ProductName, TotalCost, [Date], Cashier, DayID FROM DrawerExpenditure WHERE DayID  LIKE '%" & TextBox5.Text & "%'"
                adapter = New OleDbDataAdapter(sql, sqlcon)
                adapter.Fill(datast, sql)

                Dim view As New DataView(tables(0))
                source1.DataSource = view
                DataGridView3.DataSource = view
            Else
                MsgBox("DATABASE CONNECTION UNSUCCESSFUL.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ERROR")
        End Try
        sqlcon.Close()
        sqlcon.Dispose()
        sqlcon = Nothing
    End Sub

    Private Sub TheEmpireButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton8.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TextBox3.Text.Trim().Length = 0 Then
            MsgBox("PLEASE ENTER THE RECEIPT NUMBER.", MsgBoxStyle.Information)
            Exit Sub
        ElseIf TextBox4.Text.Trim().Length = 0 Then
            MsgBox("PLEASE ENTER THE TOTAL COST.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Try
            sqlcon = New OleDbConnection(strcon)
            sqlcon.Open()
            If sqlcon.State = ConnectionState.Open Then
            Else
                MsgBox("DATABASE CONNECTION UN-SUCCESSFUL.", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dim TA As New TopShelfDataSetTableAdapters.EndDayTableAdapter
            Dim TB = TA.GetDataByOpen("OPEN")

            If TB.Rows.Count = 0 Then
                MsgBox("DAY ID NOT ACTIVATED. PLEASE START THE DAY.", MsgBoxStyle.Information)
                Exit Sub
            Else
                Dim R As TopShelfDataSet.EndDayRow = TB.Rows(0)

                Dim xCharArray() As Char = "ABCDEFGHKLMNPQRSTUVWXYZ".ToCharArray
                Dim xNoArray() As Char = "123456789".ToCharArray
                Dim xGenerator As System.Random = New System.Random()
                Dim xStr As String = String.Empty

                While xStr.Length < 5
                    If xGenerator.Next(0, 2) = 0 Then
                        xStr &= xCharArray(xGenerator.Next(0, xCharArray.Length))
                    Else
                        xStr &= xNoArray(xGenerator.Next(0, xNoArray.Length))
                    End If
                End While

                'Insert the new receipt details
                Dim Sql As String = "INSERT INTO DrawerExpenditure (ID, ProductName, TotalCost, [Date], Cashier, DayID) VALUES ('" & xStr & "', '" & ComboBox2.Text & "', '" & TextBox4.Text & "', '" & DateTime.Now & "', '" & MainWindow.Label1.Text & "', '" & R.ID & "')"
                Dim cmd1 As New OleDbCommand
                cmd1.Connection = sqlcon
                cmd1.CommandText = Sql

                cmd1.ExecuteNonQuery()
                cmd1.Dispose()

            End If

            MsgBox("SAVED SUCCESSFULLY.", MsgBoxStyle.Information)

            TextBox3.Clear()
            TextBox4.Clear()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
        If sqlcon IsNot Nothing Then
            If sqlcon.State = ConnectionState.Open Then
                sqlcon.Close()
            End If
        End If
    End Sub

    Private Sub TheEmpireButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton10.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        Try
            If DataGridView3.CurrentRow.IsNewRow Then
                MsgBox("NO RECORD FOUND. PLEASE SELECT A VALID ROW.", MsgBoxStyle.Information)
                Exit Sub
            Else
                If MessageBox.Show("ARE YOU SURE YOU'D LIKE TO DELETE THIS RECORD?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

                    'create the adapter
                    Dim TDC As New TopShelfDataSetTableAdapters.DrawerExpenditureTableAdapter

                    'Delete the item
                    TDC.DeleteByID(DataGridView3.SelectedRows(0).Cells(0).Value)
                    TDC.Fill(TopShelfDataSet.DrawerExpenditure)

                    'close window and return ok
                    MsgBox("DELETE SUCCESSFUL.", MsgBoxStyle.Information)

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TheEmpireButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton4.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        Custom_Menu.Show()
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
            e.RowIndex >= 0 Then
            Dim buttonName As String = DataGridView2.Columns(e.ColumnIndex).Name
            If buttonName = "Column1" Then
                'perform validation for dgv by making sure an item is selected for editing
                If DataGridView2.CurrentRow.IsNewRow Then
                    MsgBox("NO RECORD FOUND. PLEASE SELECT A VALID ROW.", MsgBoxStyle.Information)
                    Exit Sub
                Else
                    If MessageBox.Show("WOULD YOU LIKE TO RE-PRINT THE RECEIPT FOR THE SELECTED RECORD?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                        DataGridView12.Rows.Clear()
                        Dim DER As New TopShelfDataSetTableAdapters.SalesTableAdapter
                        Dim THT = DER.GetDataByReceiptID(DataGridView2.Item(3, e.RowIndex).Value)
                        Dim TotalCost As Decimal = 0
                        If THT.Rows.Count = 0 Then
                        Else
                            For Each row As TopShelfDataSet.SalesRow In THT.Rows
                                'DataGridView12.Rows.Clear()

                                DataGridView12.Rows.Add(row.ProductName, row.Quantity, row.PUnit, row.TotalCost, row.ReceiptID, row._Date, row.Cashier)

                                TotalCost += row.TotalCost

                            Next
                            Label13.Text = TotalCost
                        End If


                        'Draw the receipt
                        'ReceiptImage = DrawReceipt(DataGridView12.Rows(), DataGridView2.Item(3, e.RowIndex).Value, DataGridView2.Item(2, e.RowIndex).Value, TotalCost, TotalCost, 0, DataGridView2.Item(10, e.RowIndex).Value)

                        Dim TAP As New TopShelfDataSetTableAdapters.PrinterTableAdapter
                        Dim TBP = TAP.GetDataByModule("RESTAURANT")

                        If TBP.Rows.Count = 0 Then
                            'Select a printer
                            If PrintDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                                ReceiptPD.PrinterSettings = PrintDlg.PrinterSettings
                                ReceiptPD.Print()
                            End If
                        End If

                        Dim RP As TopShelfDataSet.PrinterRow = TBP.Rows(0)
                        ReceiptPD.PrinterSettings.PrinterName = RP.PrinterName
                        ReceiptPD.Print()

                        'PPD.Document = KitchenPD
                        'PPD.ShowDialog()

                        'Restaurant print
                        'ReceiptImage = DrawKitchenReceipt(DataGridView12.Rows(), DataGridView2.Item(3, e.RowIndex).Value, DataGridView2.Item(2, e.RowIndex).Value, DataGridView2.Item(10, e.RowIndex).Value)

                        Dim QTAP As New TopShelfDataSetTableAdapters.PrinterTableAdapter
                        Dim QTBP = QTAP.GetDataByModule("KITCHEN")

                        If QTBP.Rows.Count = 0 Then
                            'Select a printer
                            If PrintDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                                KitchenPD.PrinterSettings = PrintDlg.PrinterSettings
                                KitchenPD.Print()
                            End If
                        End If

                        Dim QRP As TopShelfDataSet.PrinterRow = QTBP.Rows(0)
                        KitchenPD.PrinterSettings.PrinterName = QRP.PrinterName
                        KitchenPD.Print()
                        'PPD.Document = ReceiptPD
                        'PPD.ShowDialog()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PrintDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage
        e.Graphics.DrawImage(ReceiptImage, 0, 0, ReceiptImage.Width, ReceiptImage.Height)
        e.HasMorePages = False
    End Sub

    'function draw Kitchen RECEIPT
    Public Function DrawKitchenReceipt(ByVal Rows As DataGridViewRowCollection, ByVal ReceiptNo As String, ByVal ReceiptDate As Date, ByVal USERNAME As String) As Bitmap
        ' Set the basic RECEIPT size
        Dim UnitHeight As Integer = 13 'Text Height/Height ya each single letter yenye ina-appear kwa receipt 
        Dim UnitWidth As Integer = 23  'Text Width

        Dim rai = 2 * Rows.Count - 1
        Dim ReceiptWidth As Integer = 13 * UnitWidth
        Dim ReceiptDetailsHeight As Integer = rai * UnitHeight
        Dim ReceiptHeight As Integer = 10 * UnitWidth + ReceiptDetailsHeight ' + 160

        ' Create the Bitmap
        Dim BMP As New Bitmap(ReceiptWidth + 1, ReceiptHeight, Imaging.PixelFormat.Format24bppRgb)

        ' Create The Graphics Object
        Dim GR As Graphics = Graphics.FromImage(BMP)

        ' Fill the image with color white
        GR.Clear(Color.White)

        'Draw the Headers
        Dim LNHeaderYStart = 7 * UnitHeight
        GR.DrawRectangle(Pens.Black, UnitWidth * -2, LNHeaderYStart, UnitWidth * 15, UnitHeight + 2)

        'Draw the details part
        Dim LNDetailsStart = LNHeaderYStart + UnitHeight + 2
        GR.DrawRectangle(Pens.Black, UnitWidth * -2, LNDetailsStart, UnitWidth * 15, ReceiptDetailsHeight)

        'Draw footer statement1
        Dim footer1 = LNDetailsStart + UnitHeight * 3 'ReceiptHeight - 270
        GR.DrawRectangle(Pens.Black, UnitWidth * -2, footer1, UnitWidth * 15, UnitHeight * 2)

        'fill the header with some text 

        Dim FNT As New Font("Calibri", 10, FontStyle.Regular)
        Dim sahii As New Font("Calibri", 12, FontStyle.Bold)
        Dim sahii1 As New Font("Calibri", 10, FontStyle.Bold)
        Dim karatasi As New Font("Calibri", 10, FontStyle.Bold)
        Dim fnt1 As New Font("Calibri", 8, FontStyle.Bold)
        GR.DrawString("KYENGA MEAT PALACE.", sahii, New SolidBrush(Color.Black), UnitWidth * 2.8, 1)
        GR.DrawString("KITCHEN RECEIPT.", FNT, New SolidBrush(Color.Black), UnitWidth * 3.1, UnitHeight * 1)
        GR.DrawString("NEW ORDER", FNT, New SolidBrush(Color.Black), UnitWidth * 3.7, UnitHeight * 2)

        GR.DrawString("Date: ", FNT, New SolidBrush(Color.Black), 0, UnitHeight * 4)
        GR.DrawString("Receipt No: ", FNT, New SolidBrush(Color.Black), 0, UnitHeight * 5)

        GR.DrawString("DISH/DRINK", FNT, New SolidBrush(Color.Black), UnitWidth * 0, LNHeaderYStart)
        GR.DrawString("PORTION", FNT, New SolidBrush(Color.Black), UnitWidth * 7, LNHeaderYStart)

        'Render the text on the receipt
        Dim YLOCi = UnitHeight * 0 + LNDetailsStart
        Dim YLOCi2 = YLOCi + UnitHeight

        GR.DrawString(Rows(0).Cells(0).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 0, YLOCi)  'MEAL/DRINK
        GR.DrawString(Rows(0).Cells(1).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 7, YLOCi2)  'Units
        Dim i As Integer
        For i = 1 To Rows.Count - 1

            Dim YLOC = YLOCi + UnitHeight * i
            Dim YLOC2 = YLOC + (UnitHeight * i)
            Dim YLOC3 = YLOC2 + UnitHeight
            'render the Values
            GR.DrawString(Rows(i).Cells(0).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 0, YLOC2)  'MEAL/DRINK
            GR.DrawString(Rows(i).Cells(1).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 7, YLOC3)  'units
        Next

        'Render footer1
        GR.DrawString("        SERVER: " & USERNAME, FNT, New SolidBrush(Color.Black), UnitWidth * 0, footer1)

        'Write the receipt number and date
        GR.DrawString("Date: " & ReceiptDate, FNT, New SolidBrush(Color.Black), 0, UnitHeight * 4)
        GR.DrawString("Receipt No: " & ReceiptNo, FNT, New SolidBrush(Color.Black), 0, UnitHeight * 5)

        Return BMP

    End Function

    'function draw RECEIPT
    Public Function DrawReceipt(ByVal Rows As DataGridViewRowCollection, ByVal ReceiptNo As String, ByVal ReceiptDate As Date, ByVal ReceiptTotal As Decimal, ByVal Paid As Decimal, ByVal Balance As Decimal, ByVal USERNAME As String) As Bitmap
        ' Set the basic RECEIPT size
        Dim UnitHeight As Integer = 13 'Text Height/Height ya each single letter yenye ina-appear kwa receipt 
        Dim UnitWidth As Integer = 23  'Text Width

        Dim rai = 2 * Rows.Count - 1
        Dim ReceiptWidth As Integer = 13 * UnitWidth
        Dim ReceiptDetailsHeight As Integer = rai * UnitHeight
        Dim ReceiptHeight As Integer = 13 * UnitWidth + ReceiptDetailsHeight ' + 160


        ' Create the Bitmap
        Dim BMP As New Bitmap(ReceiptWidth + 1, ReceiptHeight, Imaging.PixelFormat.Format24bppRgb)

        ' Create The Graphics Object
        Dim GR As Graphics = Graphics.FromImage(BMP)

        ' Fill the image with color white
        GR.Clear(Color.White)

        'Draw the Headers
        Dim LNHeaderYStart = 8 * UnitHeight
        GR.DrawRectangle(Pens.Black, UnitWidth * -2, LNHeaderYStart, UnitWidth * 15, UnitHeight + 2)

        'Draw the details part
        Dim LNDetailsStart = LNHeaderYStart + UnitHeight + 2
        GR.DrawRectangle(Pens.Black, UnitWidth * -2, LNDetailsStart, UnitWidth * 15, ReceiptDetailsHeight)

        'Draw Totals details part
        Dim TotalDetailsHeight = LNDetailsStart + ReceiptDetailsHeight + 2
        GR.DrawRectangle(Pens.Black, UnitWidth * -2, TotalDetailsHeight, UnitWidth * 15, UnitHeight * 4) 'ReceiptHeight - 260)

        'Draw footer statement1
        Dim footer1 = TotalDetailsHeight + UnitHeight * 4 'ReceiptHeight - 270
        GR.DrawRectangle(Pens.Black, UnitWidth * -2, footer1, UnitWidth * 15, UnitHeight * 5)

        'fill the header with some text 

        Dim FNT As New Font("Calibri", 10, FontStyle.Regular)
        Dim sahii As New Font("Calibri", 12, FontStyle.Bold)
        Dim sahii1 As New Font("Calibri", 10, FontStyle.Bold)
        Dim karatasi As New Font("Calibri", 10, FontStyle.Bold)
        Dim fnt1 As New Font("Calibri", 8, FontStyle.Bold)
        GR.DrawString("KYENGA MEAT PALACE.", sahii, New SolidBrush(Color.Black), UnitWidth * 3.1, 1)
        GR.DrawString("TILL NUMBER 9014211.", FNT, New SolidBrush(Color.Black), UnitWidth * 3.4, UnitHeight * 1)
        GR.DrawString("Tel: 0726452241", FNT, New SolidBrush(Color.Black), UnitWidth * 4, UnitHeight * 2)
        GR.DrawString("CUSTOMERS BILL RECEIPT", sahii, New SolidBrush(Color.Black), UnitWidth * 3.1, UnitHeight * 3)
        GR.DrawString("Receipt No: ", FNT, New SolidBrush(Color.Black), 0, UnitHeight * 5)
        GR.DrawString("Date: ", FNT, New SolidBrush(Color.Black), 0, UnitHeight * 6)

        GR.DrawString("ITEM", FNT, New SolidBrush(Color.Black), UnitWidth * 0, LNHeaderYStart)
        GR.DrawString("PRICE", FNT, New SolidBrush(Color.Black), UnitWidth * 4, LNHeaderYStart)
        GR.DrawString("UNITS", FNT, New SolidBrush(Color.Black), UnitWidth * 7, LNHeaderYStart)
        GR.DrawString("TOTAL", FNT, New SolidBrush(Color.Black), UnitWidth * 10, LNHeaderYStart)

        'GR.DrawString("CODE", FNT, New SolidBrush(Color.Black), UnitWidth * 0, TaxHeaderHeight)
        'GR.DrawString("RATE", FNT, New SolidBrush(Color.Black), UnitWidth * 2, TaxHeaderHeight)
        'GR.DrawString("VATABLE AMT", FNT, New SolidBrush(Color.Black), UnitWidth * 4.5, TaxHeaderHeight)
        'GR.DrawString("VAT AMT", FNT, New SolidBrush(Color.Black), UnitWidth * 10, TaxHeaderHeight)

        'Render the text on the receipt
        Dim YLOCi = UnitHeight * 0 + LNDetailsStart
        Dim YLOCi2 = YLOCi + UnitHeight

        GR.DrawString(Rows(0).Cells(0).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 0, YLOCi)  'MEAL/DRINK
        GR.DrawString(Rows(0).Cells(2).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 4, YLOCi2)  'punit
        GR.DrawString(Rows(0).Cells(1).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 7, YLOCi2)  'Units
        GR.DrawString(Rows(0).Cells(3).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 10, YLOCi2)  'tc/sum
        'GR.DrawString(Rows(0).Cells(7).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 11.5, YLOCi2)  'taxcode
        Dim i As Integer
        For i = 1 To Rows.Count - 1

            ' find the y
            '    Dim YLOC = UnitHeight * i + LNDetailsStart
            '    Dim YLOC2 = YLOC + UnitHeight * i
            Dim YLOC = YLOCi + UnitHeight * i
            Dim YLOC2 = YLOC + (UnitHeight * i)
            Dim YLOC3 = YLOC2 + UnitHeight
            'render the Values

            '    'GR.DrawString(i + 1, FNT, New SolidBrush(Color.Black), UnitWidth * 0, YLOC)
            '    'GR.DrawString(Rows(i).Cells(0).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 0, YLOC)
            GR.DrawString(Rows(i).Cells(0).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 0, YLOC2)  'MEAL/DRINK
            GR.DrawString(Rows(i).Cells(2).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 4, YLOC3)  'punit
            GR.DrawString(Rows(i).Cells(1).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 7, YLOC3)  'units
            GR.DrawString(Rows(i).Cells(3).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 10, YLOC3)  'tc/sum
            'GR.DrawString(Rows(i).Cells(7).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 11.5, YLOC3)  'taxcode

        Next


        'render the total
        Dim TLOC = TotalDetailsHeight 'UnitHeight * 4 + TotalDetailsHeight
        GR.DrawString("TOTAL                                             " & ReceiptTotal, sahii, New SolidBrush(Color.Black), UnitWidth * 0, TLOC + 5)
        GR.DrawString("CASH                                                                 " & Paid, FNT, New SolidBrush(Color.Black), UnitWidth * 0, TLOC + 20)
        GR.DrawString("BALANCE                                                           " & Balance, FNT, New SolidBrush(Color.Black), UnitWidth * 0, TLOC + 30)

        'Render footer1
        GR.DrawString("THANK YOU FOR DINING WITH US." & vbNewLine & "               YOU WERE SERVED BY: " & USERNAME, FNT, New SolidBrush(Color.Black), UnitWidth * 0, footer1)

        'Write the receipt number and date
        GR.DrawString("Receipt No: " & ReceiptNo, FNT, New SolidBrush(Color.Black), 0, UnitHeight * 5)
        GR.DrawString("Date: " & ReceiptDate, FNT, New SolidBrush(Color.Black), 0, UnitHeight * 6)

        'End the Drawing
        Return BMP

    End Function

    Private Sub ReceiptPD_BeginPrint(ByVal sender As Object, ByVal e As Printing.PrintEventArgs) Handles ReceiptPD.BeginPrint
        Dim pagesetup As New PageSettings
        Dim rai = 2 * DataGridView12.Rows.Count - 1
        Dim ReceiptDetailsHeight As Integer = rai * 15
        Dim ReceiptHeight As Integer = 450 + ReceiptDetailsHeight ' + 160
        'Dim rai = 2 * DataGridView3.Rows.Count - 1
        pagesetup.PaperSize = New PaperSize("Custom", 299, ReceiptHeight)
        ReceiptPD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub ReceiptPD_Printpage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles ReceiptPD.PrintPage
        Dim FNT As New Font("Calibri", 10, FontStyle.Regular)
        Dim sahii As New Font("Calibri", 10, FontStyle.Bold)
        Dim sahii1 As New Font("Calibri", 12, FontStyle.Bold)
        Dim karatasi As New Font("Calibri", 10, FontStyle.Bold)
        Dim fnt1 As New Font("Calibri", 8, FontStyle.Bold)

        Dim leftmargin As Integer = ReceiptPD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = ReceiptPD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = ReceiptPD.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat
        Dim left As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center
        left.Alignment = StringAlignment.Near

        Dim line As String
        line = "---------------------------------------------------------"

        Dim line2 As String
        line2 = "________________________________________________________"

        e.Graphics.DrawString("KYENGA MEAT PALACE.", sahii1, New SolidBrush(Color.Black), centermargin, 5, center)
        e.Graphics.DrawString("TILL NUMBER 9014211.", FNT, New SolidBrush(Color.Black), centermargin, 25, center)
        e.Graphics.DrawString("Tel: 0726452241", FNT, New SolidBrush(Color.Black), centermargin, 45, center)
        e.Graphics.DrawString("CUSTOMERS RECEIPT", sahii1, New SolidBrush(Color.Black), centermargin, 65, center)
        'e.Graphics.DrawString("Print Date: " & DateTime.Now, FNT, New SolidBrush(Color.Black), centermargin, 85, center)

        e.Graphics.DrawString("RECEIPT NO. " & DataGridView12.Rows(0).Cells(4).Value, FNT, New SolidBrush(Color.Black), 5, 105)
        e.Graphics.DrawString("DATE: " & CDate(DataGridView12.Rows(0).Cells(5).Value), FNT, New SolidBrush(Color.Black), 5, 120)

        e.Graphics.DrawString(line2, sahii, New SolidBrush(Color.Black), 0, 125)

        e.Graphics.DrawString("FOOD", sahii, New SolidBrush(Color.Black), 5, 140)
        e.Graphics.DrawString("PRICE", sahii, New SolidBrush(Color.Black), 85, 140)
        e.Graphics.DrawString("QTY", sahii, New SolidBrush(Color.Black), 145, 140)
        e.Graphics.DrawString("TOTAL", sahii, New SolidBrush(Color.Black), 215, 140)

        e.Graphics.DrawString(line2, sahii, New SolidBrush(Color.Black), 0, 150)

        Dim height As Integer 'DGV pOSITION

        'Render the text on the receipt
        Dim YLOCi = 170
        Dim YLOCi2 = YLOCi + 15

        e.Graphics.DrawString(DataGridView12.Rows(0).Cells(0).Value.ToString, FNT, New SolidBrush(Color.Black), 5, YLOCi)  'FOOD/DRINK
        e.Graphics.DrawString(Format(DataGridView12.Rows(0).Cells(2).Value, "standard"), FNT, New SolidBrush(Color.Black), 90, YLOCi2)  'PRICE
        e.Graphics.DrawString(DataGridView12.Rows(0).Cells(1).Value, FNT, New SolidBrush(Color.Black), 160, YLOCi2)  'UNITS
        e.Graphics.DrawString(Format(DataGridView12.Rows(0).Cells(3).Value, "standard"), FNT, New SolidBrush(Color.Black), 215, YLOCi2)  'TOTAL COST

        Dim i As Integer
        For i = 1 To DataGridView12.Rows.Count - 1
            height += 30
            Dim YLOC = YLOCi + 15 * i
            Dim YLOC2 = YLOC + (15 * i)
            Dim YLOC3 = YLOC2 + 15

            'render the Values
            e.Graphics.DrawString(DataGridView12.Rows(i).Cells(0).Value, FNT, New SolidBrush(Color.Black), 5, YLOC2)  'FOOD/DRINK
            e.Graphics.DrawString(Format(DataGridView12.Rows(i).Cells(2).Value, "standard"), FNT, New SolidBrush(Color.Black), 90, YLOC3)  'PRICE
            e.Graphics.DrawString(DataGridView12.Rows(i).Cells(1).Value, FNT, New SolidBrush(Color.Black), 160, YLOC3)  'UNITS
            e.Graphics.DrawString(Format(DataGridView12.Rows(i).Cells(3).Value, "standard"), FNT, New SolidBrush(Color.Black), 215, YLOC3)  'TOTAL COST
        Next

        Dim height2 As Integer
        height2 = 200 + height

        e.Graphics.DrawString(line, sahii, New SolidBrush(Color.Black), 0, height2 + 5)
        e.Graphics.DrawString(line, sahii, New SolidBrush(Color.Black), 0, height2 + 2)

        e.Graphics.DrawString("TOTAL COST: ", sahii, New SolidBrush(Color.Black), 5, height2 + 20)
        e.Graphics.DrawString("" & Format(DataGridView12.Rows(0).Cells(3).Value, "standard"), sahii, New SolidBrush(Color.Black), centermargin, height2 + 20)
        e.Graphics.DrawString("CASH PAID: ", sahii, New SolidBrush(Color.Black), 5, height2 + 40)
        e.Graphics.DrawString("" & Format(DataGridView12.Rows(0).Cells(3).Value, "standard"), sahii, New SolidBrush(Color.Black), centermargin, height2 + 40)
        e.Graphics.DrawString("BALANCE: ", sahii, New SolidBrush(Color.Black), 5, height2 + 60)
        e.Graphics.DrawString("" & Format(0, "standard"), sahii, New SolidBrush(Color.Black), centermargin, height2 + 60)

        e.Graphics.DrawString(line, sahii, New SolidBrush(Color.Black), 0, height2 + 75)
        e.Graphics.DrawString(line, sahii, New SolidBrush(Color.Black), 0, height2 + 77)

        e.Graphics.DrawString("THANK YOU FOR DINING WITH US.", sahii, New SolidBrush(Color.Black), 5, height2 + 90)
        e.Graphics.DrawString("YOU WERE SERVED BY: " & DataGridView12.Rows(0).Cells(6).Value, sahii, New SolidBrush(Color.Black), 5, height2 + 110)
    End Sub

    Private Sub KitchenPD_BeginPrint(ByVal sender As Object, ByVal e As Printing.PrintEventArgs) Handles KitchenPD.BeginPrint
        Dim pagesetup As New PageSettings
        Dim rai = DataGridView12.Rows.Count - 1
        Dim ReceiptDetailsHeight As Integer = rai * 15
        Dim ReceiptHeight As Integer = 450 + ReceiptDetailsHeight ' + 160
        pagesetup.PaperSize = New PaperSize("Custom", 299, ReceiptHeight)
        KitchenPD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub KitchenPD_Printpage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles KitchenPD.PrintPage
        Dim FNT As New Font("Calibri", 10, FontStyle.Regular)
        Dim sahii As New Font("Calibri", 12, FontStyle.Bold)
        Dim sahii1 As New Font("Calibri", 10, FontStyle.Bold)
        Dim karatasi As New Font("Calibri", 10, FontStyle.Bold)
        Dim fnt1 As New Font("Calibri", 8, FontStyle.Bold)

        Dim leftmargin As Integer = KitchenPD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = KitchenPD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = KitchenPD.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat
        Dim left As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center
        left.Alignment = StringAlignment.Near

        Dim line As String
        line = "---------------------------------------------------------"

        Dim line2 As String
        line2 = "________________________________________________________"

        e.Graphics.DrawString("KYENGA MEAT PALACE.", sahii1, New SolidBrush(Color.Black), centermargin, 5, center)
        e.Graphics.DrawString("TILL NUMBER 9014211.", FNT, New SolidBrush(Color.Black), centermargin, 25, center)
        e.Graphics.DrawString("Tel: 0726452241", FNT, New SolidBrush(Color.Black), centermargin, 45, center)
        e.Graphics.DrawString("KITCHEN RECEIPT", sahii1, New SolidBrush(Color.Black), centermargin, 65, center)
        'e.Graphics.DrawString("Print Date: " & DateTime.Now, FNT, New SolidBrush(Color.Black), centermargin, 85, center)

        e.Graphics.DrawString("RECEIPT NO. " & DataGridView12.Rows(0).Cells(4).Value, FNT, New SolidBrush(Color.Black), 5, 105)
        e.Graphics.DrawString("DATE: " & CDate(DataGridView12.Rows(0).Cells(5).Value), FNT, New SolidBrush(Color.Black), 5, 120)

        e.Graphics.DrawString(line2, sahii, New SolidBrush(Color.Black), 0, 135)

        e.Graphics.DrawString("FOOD/DRINK", sahii, New SolidBrush(Color.Black), 5, 150)
        e.Graphics.DrawString("QUANTITY", sahii, New SolidBrush(Color.Black), 215, 150)

        e.Graphics.DrawString(line2, sahii, New SolidBrush(Color.Black), 0, 160)

        Dim height As Integer 'DGV pOSITION

        'Render the text on the receipt
        Dim YLOCi = 180
        'Dim YLOCi2 = YLOCi + 15
        'For Each row As DataGridViewRow In DataGridView12.Rows
        '    If row.Cells(0).FormattedValue <> "" Then

        '    End If
        'Next
        e.Graphics.DrawString(DataGridView12.Rows(0).Cells(0).Value.ToString, FNT, New SolidBrush(Color.Black), 5, YLOCi)  'FOOD/DRINK
        e.Graphics.DrawString(DataGridView12.Rows(0).Cells(1).Value, FNT, New SolidBrush(Color.Black), 160, YLOCi)  'UNITS

        Dim i As Integer
        For i = 1 To DataGridView12.Rows.Count - 1
            height += 15
            Dim YLOC = YLOCi + 15 * i
            'Dim YLOC2 = YLOC + (15 * i)
            'Dim YLOC3 = YLOC2 + 15

            'render the Values
            e.Graphics.DrawString(DataGridView12.Rows(i).Cells(0).Value, FNT, New SolidBrush(Color.Black), 5, YLOC)  'FOOD/DRINK
            e.Graphics.DrawString(DataGridView12.Rows(i).Cells(1).Value, FNT, New SolidBrush(Color.Black), 160, YLOC)  'UNITS
        Next

        Dim height2 As Integer
        height2 = 195 + height

        e.Graphics.DrawString(line, sahii, New SolidBrush(Color.Black), 0, height2 + 5)
        e.Graphics.DrawString(line, sahii, New SolidBrush(Color.Black), 0, height2 + 2)

        e.Graphics.DrawString("SERVICE BY: " & MainWindow.Label1.Text, sahii, New SolidBrush(Color.Black), 5, height2 + 20)

    End Sub

    Private Sub ElegantThemeTabControlVertical1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ElegantThemeTabControlVertical1.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
    End Sub

    Private Sub ElegantThemeTabControlVertical1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElegantThemeTabControlVertical1.SelectedIndexChanged
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
    End Sub

    Private Sub DataGridView4_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick

    End Sub
End Class