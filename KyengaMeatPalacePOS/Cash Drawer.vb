Imports System.Data
Imports System.Text
Imports System.IO
Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class Cash_Drawer
    Dim ReceiptImage As Bitmap
    Dim WithEvents DrawerPD As New PrintDocument
    Dim WithEvents INVPD As New PrintDocument
    Dim WithEvents WPD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer

    Private Sub TheEmpireButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton1.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TextBox1.Text.Trim().Length = 0 Then
            MsgBox("PLEASE ENTER THE STARTING CASH.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim TA As New TopShelfDataSetTableAdapters.EndDayTableAdapter
        Dim TB = TA.GetDataByOpen("OPEN")

        If TB.Rows.Count = 0 Then
            Try
                sqlcon = New OleDbConnection(strcon)
                sqlcon.Open()
                If sqlcon.State = ConnectionState.Open Then
                Else
                    MsgBox("DATABASE CONNECTION UN-SUCCESSFUL.", MsgBoxStyle.Information)
                    Exit Sub
                End If

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
                Dim Sql As String = "INSERT INTO EndDay (ID, EndDate, StartingCash, DrawerStartDate, [Open], ClosingAmt, Cashier, ExpectedCash) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
                'Dim Sql As String = "INSERT INTO EndDay (ID, EndDate, StartingCash, DrawerStartDate, [Open], ClosingAmt, Cashier, ExpectedCash) VALUES ('" & xStr & "', '" & "" & "', '" & TextBox1.Text & "', '" & DateTime.Now & "', '" & " OPEN " & "', '" & 0 & "', '" & MainWindow.Label1.Text & "', '" & 0 & "')"
                Dim cmd1 As New OleDbCommand
                cmd1.Parameters.Add("@ID", OleDbType.Char).Value = xStr
                cmd1.Parameters.Add("@EndDate", OleDbType.Date).Value = DBNull.Value
                cmd1.Parameters.Add("@StartingCash", OleDbType.Decimal).Value = TextBox1.Text
                cmd1.Parameters.Add("@DrawerStartDate", OleDbType.Date).Value = DateTime.Now
                cmd1.Parameters.Add("@[Open]", OleDbType.Char).Value = "OPEN"
                cmd1.Parameters.Add("@ClosingAmt", OleDbType.Decimal).Value = 0
                cmd1.Parameters.Add("@Cashier", OleDbType.Char).Value = MainWindow.Label1.Text
                cmd1.Parameters.Add("@ExpectedCash", OleDbType.Decimal).Value = 0
                cmd1.Connection = sqlcon
                cmd1.CommandText = Sql

                cmd1.ExecuteNonQuery()
                cmd1.Dispose()

                Label3.Text = "Drawer Started on: " & DateTime.Now.ToString("dd/MMMM/yyyy, H:mm:ss tt")
                MsgBox("DRAWER STARTED SUCCESSFULLY.", MsgBoxStyle.Information)

                TextBox1.Clear()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            End Try
            If sqlcon IsNot Nothing Then
                If sqlcon.State = ConnectionState.Open Then
                    sqlcon.Close()
                End If
            End If
        Else
            'Dim R As TopShelfDataSet.EndDayRow = TB.Rows(0)
            MsgBox("DRAWER CURRENTLY OPENED.", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Text = DateTime.Now.ToString("dd/MMMM/yyyy, H:mm:ss tt")
    End Sub

    Private Sub Cash_Drawer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'TopShelfDataSet.LogIn' table. You can move, or remove it, as needed.
        Me.LogInTableAdapter.Fill(Me.TopShelfDataSet.LogIn)
        ''TODO: This line of code loads data into the 'TopShelfDataSet.Sales' table. You can move, or remove it, as needed.
        'Me.SalesTableAdapter.Fill(Me.TopShelfDataSet.Sales)
        'Dim CurrentDate As Date = Date.Now
        'Dim Interval As Integer = -3
        'Dim result As Date = CurrentDate.AddDays(Interval)
        ''DateAdd(DateInterval.Day, -3, Date.Now)
        
        'TODO: This line of code loads data into the 'TopShelfDataSet.UnclosedDrawers' table. You can move, or remove it, as needed.
        Me.UnclosedDrawersTableAdapter.Fill(Me.TopShelfDataSet.UnclosedDrawers)
        'TODO: This line of code loads data into the 'TopShelfDataSet.EndDay' table. You can move, or remove it, as needed.
        Me.EndDayTableAdapter.Fill(Me.TopShelfDataSet.EndDay)

        Timer1.Start()
        Dim TA As New TopShelfDataSetTableAdapters.EndDayTableAdapter
        Dim TB = TA.GetDataByOpen("OPEN")

        If TB.Rows.Count = 0 Then

        Else
            Dim R As TopShelfDataSet.EndDayRow = TB.Rows(0)

            Label14.Text = R.ID
            Label15.Text = R.DrawerStartDate.ToString("dd/MMMM/yyyy, H:mm:ss tt")
            Label16.Text = MainWindow.Label1.Text
            Label18.Text = R.StartingCash

            sqlcon = New OleDbConnection(strcon)
            sqlcon.Open()

            If sqlcon.State = ConnectionState.Open Then
                datast = New DataSet
                tables = datast.Tables
                sql = "SELECT TotalCost, ReceiptID, DayID FROM Sales WHERE DayID LIKE '%" & Label14.Text & "%'"
                'sql = "SELECT Name FROM Menu WHERE Name LIKE '%" & TextBox1.Text & "%'"
                adapter = New OleDbDataAdapter(sql, sqlcon)
                adapter.Fill(datast, sql)

                Dim view As New DataView(tables(0))
                source1.DataSource = view
                DataGridView3.DataSource = view
            End If

            Dim GrossCash As Decimal = 0
            For i As Integer = 0 To DataGridView3.Rows.Count - 1
                GrossCash += DataGridView3.Rows(i).Cells(0).Value
                Label20.Text = GrossCash
            Next

            sqlcon = New OleDbConnection(strcon)
            sqlcon.Open()

            If sqlcon.State = ConnectionState.Open Then
                datast = New DataSet
                tables = datast.Tables
                sql = "SELECT TotalCost, DayID FROM DrawerExpenditure WHERE DayID LIKE '%" & Label14.Text & "%'"
                'sql = "SELECT Name FROM Menu WHERE Name LIKE '%" & TextBox1.Text & "%'"
                adapter = New OleDbDataAdapter(sql, sqlcon)
                adapter.Fill(datast, sql)

                Dim view As New DataView(tables(0))
                source1.DataSource = view
                DataGridView4.DataSource = view
            End If

            Dim GrossExpenditure As Decimal = 0
            For i As Integer = 0 To DataGridView4.Rows.Count - 1
                GrossExpenditure += DataGridView4.Rows(i).Cells(0).Value
                Label22.Text = GrossExpenditure
            Next

            Dim sales As Decimal = Label20.Text
            Dim expenditure As Decimal = Label22.Text
            Dim Expected As Decimal = sales - expenditure
            Label23.Text = Expected

            Dim TQA As New TopShelfDataSetTableAdapters.SalesTableAdapter
            Dim TQB = TQA.GetDataByDayID(Label14.Text)

            If TQB.Rows.Count = 0 Then

            Else
                For Each row As TopShelfDataSet.SalesRow In TQB.Rows
                    Dim D As Integer
                    Dim ItemLoc As Integer = -1
                    For D = 0 To DataGridView5.Rows.Count - 1
                        If row.ProductName = DataGridView5.Rows(D).Cells(0).Value Then
                            'Item Found
                            ItemLoc = D
                            Exit For
                        End If

                    Next

                    'Item not found add it to dgv
                    If ItemLoc = -1 Then
                        DataGridView5.Rows.Add(row.ProductName, row.Quantity, row.TotalCost, row.DayID)
                    Else

                        Dim TotalCost As Decimal = DataGridView5.Rows(ItemLoc).Cells(2).Value
                        Dim Qty As Long = DataGridView5.Rows(ItemLoc).Cells(1).Value
                        DataGridView5.Rows(ItemLoc).Cells(1).Value = Qty + row.Quantity
                        DataGridView5.Rows(ItemLoc).Cells(2).Value = TotalCost + row.TotalCost
                    End If
                Next

            End If
            End If
    End Sub

    Private Sub TheEmpireButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton2.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        Try
            Dim TSA As New TopShelfDataSetTableAdapters.EndDayTableAdapter
            Dim TSB = TSA.GetDataByOpen("OPEN")

            If TSB.Rows.Count = 0 Then
                MsgBox("NO DRAWER OPENED.", MsgBoxStyle.Information)
                Exit Sub
            Else
                'Dim R As TopShelfDataSet.EndDayRow = TSB.Rows(0)
                If TextBox2.Text.Trim().Length = 0 Then
                    MsgBox("PLEASE ENTER THE ACTUAL AMOUNT IN DRAWER", MsgBoxStyle.Information)
                    Exit Sub
                End If
                sqlcon = New OleDbConnection(strcon)
                sqlcon.Open()

                If sqlcon.State = ConnectionState.Open Then
                    'get details of the item
                    Dim R As TopShelfDataSet.EndDayRow = TheEmpireButton2.Tag

                    'create the adapter
                    Dim TA As New TopShelfDataSetTableAdapters.EndDayTableAdapter

                    'Update the item
                    EndDayBindingSource.EndEdit()
                    TA.UpdateEndDay(DateTime.Now, "CLOSED", TextBox2.Text, MainWindow.Label1.Text, Label23.Text, Label14.Text)

                    'Draw the receipt
                    'ReceiptImage = DrawDayReport(DataGridView5.Rows(), Label14.Text, Label15.Text, DateTime.Now, Label18.Text)

                    Dim TAP As New TopShelfDataSetTableAdapters.PrinterTableAdapter
                    Dim TBP = TAP.GetDataByModule("ENDDAY")

                    If TBP.Rows.Count = 0 Then
                        'Select a printer
                        If PrintDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                            INVPD.PrinterSettings = PrintDlg.PrinterSettings
                            INVPD.Print()
                        End If
                    End If

                    Dim RP As TopShelfDataSet.PrinterRow = TBP.Rows(0)
                    INVPD.PrinterSettings.PrinterName = RP.PrinterName
                    INVPD.Print()

                    'PPD.Document = INVPD
                    'PPD.ShowDialog()

                    MsgBox("DRAWER CLOSED.", MsgBoxStyle.Information)
                    'Add_To_Menu.MenuTableAdapter.Fill(Add_To_Menu.TopShelfDataSet.Menu)
                    Me.Dispose()
                Else
                    MsgBox("DATABASE CONNECTION UNSUCCESSFUL.", MsgBoxStyle.Exclamation)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
        sqlcon.Close()
        sqlcon.Dispose()
        sqlcon = Nothing
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TextBox2.Text.Trim().Length = 0 Then
            MsgBox("PLEASE ENTER THE ACTUAL AMOUNT IN DRAWER", MsgBoxStyle.Information)
            Exit Sub
        Else
            Dim Expected As Decimal = Label23.Text
            Dim actual As Decimal = TextBox2.Text
            Dim dIFFERENCE As Decimal = Expected - actual
            Label25.Text = dIFFERENCE
        End If
    End Sub

    'function draw RECEIPT
    Public Function DrawDayReport(ByVal Rows As DataGridViewRowCollection, ByVal DAYID As String, ByVal STARTDATE As Date, ByVal ENDDATE As Date, ByVal CASH As Decimal) As Bitmap
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
        Dim LNHeaderYStart = 13 * UnitHeight
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
        GR.DrawString("EOD REPORT", sahii, New SolidBrush(Color.Black), UnitWidth * 3.5, UnitHeight * 3)
        GR.DrawString("Print Date: " & DateTime.Now, FNT, New SolidBrush(Color.Black), UnitWidth * 4, UnitHeight * 4)
        GR.DrawString("DAY ID: " & DAYID, FNT, New SolidBrush(Color.Black), 0, UnitHeight * 6)
        GR.DrawString("START DATE: " & STARTDATE, FNT, New SolidBrush(Color.Black), 0, UnitHeight * 7)
        GR.DrawString("END DATE: " & ENDDATE, FNT, New SolidBrush(Color.Black), 0, UnitHeight * 8)
        GR.DrawString("STARTING CASH: KSH. " & CASH, FNT, New SolidBrush(Color.Black), 0, UnitHeight * 9)

        GR.DrawString("REPORT DETAILS", sahii, New SolidBrush(Color.Black), UnitWidth * 3.5, UnitHeight * 11)

        GR.DrawString("FOOD/DRINK", FNT, New SolidBrush(Color.Black), UnitWidth * 0, LNHeaderYStart)
        'GR.DrawString("PRICE", FNT, New SolidBrush(Color.Black), UnitWidth * 4, LNHeaderYStart)
        GR.DrawString("PORTIONS", FNT, New SolidBrush(Color.Black), UnitWidth * 6.5, LNHeaderYStart)
        GR.DrawString("TOTAL COST", FNT, New SolidBrush(Color.Black), UnitWidth * 9.5, LNHeaderYStart)

        'GR.DrawString("CODE", FNT, New SolidBrush(Color.Black), UnitWidth * 0, TaxHeaderHeight)
        'GR.DrawString("RATE", FNT, New SolidBrush(Color.Black), UnitWidth * 2, TaxHeaderHeight)
        'GR.DrawString("VATABLE AMT", FNT, New SolidBrush(Color.Black), UnitWidth * 4.5, TaxHeaderHeight)
        'GR.DrawString("VAT AMT", FNT, New SolidBrush(Color.Black), UnitWidth * 10, TaxHeaderHeight)

        'Render the text on the receipt
        Dim YLOCi = UnitHeight * 0 + LNDetailsStart
        Dim YLOCi2 = YLOCi + UnitHeight

        GR.DrawString(Rows(0).Cells(0).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 0, YLOCi)  'MEAL/DRINK
        'GR.DrawString(Rows(0).Cells(2).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 4, YLOCi2)  'punit
        GR.DrawString(Rows(0).Cells(1).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 7, YLOCi2)  'Units
        GR.DrawString(Rows(0).Cells(2).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 10, YLOCi2)  'tc/sum
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
            'GR.DrawString(Rows(i).Cells(2).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 4, YLOC3)  'punit
            GR.DrawString(Rows(i).Cells(1).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 7, YLOC3)  'units
            GR.DrawString(Rows(i).Cells(2).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 10, YLOC3)  'tc/sum
            'GR.DrawString(Rows(i).Cells(7).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 11.5, YLOC3)  'taxcode

        Next

        ''render the total
        'Dim TLOC = TotalDetailsHeight 'UnitHeight * 4 + TotalDetailsHeight
        'GR.DrawString("TOTAL PORTIONS                                       " & ReceiptTotal, sahii, New SolidBrush(Color.Black), UnitWidth * 0, TLOC + 5)
        'GR.DrawString("CASH SALES                                           " & Paid, FNT, New SolidBrush(Color.Black), UnitWidth * 0, TLOC + 20)
        'GR.DrawString("MPESA SALES                                          " & Paid, FNT, New SolidBrush(Color.Black), UnitWidth * 0, TLOC + 20)
        'GR.DrawString("DRAWER EXPENDITURE                                   " & Paid, FNT, New SolidBrush(Color.Black), UnitWidth * 0, TLOC + 20)
        'GR.DrawString("TOTAL EXPECTED IN DRAWER                             " & Balance, FNT, New SolidBrush(Color.Black), UnitWidth * 0, TLOC + 30)
        'GR.DrawString("CLOSING AMOUNT                                       " & Paid, FNT, New SolidBrush(Color.Black), UnitWidth * 0, TLOC + 20)
        'Render footer1
        GR.DrawString("END OF DAY REPORT.", FNT, New SolidBrush(Color.Black), UnitWidth * 0, footer1)


        'End the Drawing
        Return BMP

    End Function

    Private Sub PrintDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage
        e.Graphics.DrawImage(ReceiptImage, 0, 0, ReceiptImage.Width, ReceiptImage.Height)
        e.HasMorePages = False
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()

        Label28.Text = DataGridView1.SelectedRows(0).Cells(0).Value

        Try
            Dim TSA As New TopShelfDataSetTableAdapters.SalesTableAdapter
            Dim TSB = TSA.GetDataByDayID(DataGridView1.SelectedRows(0).Cells(0).Value)

            If TSB.Rows.Count = 0 Then

            Else
                For Each row As TopShelfDataSet.SalesRow In TSB.Rows
                    Dim D As Integer
                    Dim ItemLoc As Integer = -1
                    For D = 0 To DataGridView5.Rows.Count - 1
                        If row.ProductName = DataGridView5.Rows(D).Cells(0).Value Then
                            'Item Found
                            ItemLoc = D
                            Exit For
                        End If

                    Next

                    'Item not found add it to dgv
                    If ItemLoc = -1 Then
                        DataGridView5.Rows.Add(row.ProductName, row.Quantity, row.TotalCost, row.DayID)
                    Else

                        Dim TotalCost As Decimal = DataGridView5.Rows(ItemLoc).Cells(2).Value
                        Dim Qty As Long = DataGridView5.Rows(ItemLoc).Cells(1).Value
                        DataGridView5.Rows(ItemLoc).Cells(1).Value = Qty + row.Quantity
                        DataGridView5.Rows(ItemLoc).Cells(2).Value = TotalCost + row.TotalCost
                    End If
                Next
                'Dim R As TopShelfDataSet.SalesRow = TSB.Rows(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()

        Label28.Text = DataGridView1.SelectedRows(0).Cells(0).Value

        Try
            Dim TSA As New TopShelfDataSetTableAdapters.SalesTableAdapter
            Dim TSB = TSA.GetDataByDayID(DataGridView1.SelectedRows(0).Cells(0).Value)

            If TSB.Rows.Count = 0 Then

            Else
                For Each row As TopShelfDataSet.SalesRow In TSB.Rows

                    Dim D As Integer
                    Dim ItemLoc As Integer = -1
                    For D = 0 To DataGridView5.Rows.Count - 1
                        If row.ProductName = DataGridView5.Rows(D).Cells(0).Value Then
                            'Item Found
                            ItemLoc = D
                            Exit For
                        End If

                    Next

                    'Item not found add it to dgv
                    If ItemLoc = -1 Then
                        DataGridView5.Rows.Add(row.ProductName, row.Quantity, row.TotalCost, row.DayID)
                    Else

                        Dim TotalCost As Decimal = DataGridView5.Rows(ItemLoc).Cells(2).Value
                        Dim Qty As Long = DataGridView5.Rows(ItemLoc).Cells(1).Value
                        DataGridView5.Rows(ItemLoc).Cells(1).Value = Qty + row.Quantity
                        DataGridView5.Rows(ItemLoc).Cells(2).Value = TotalCost + row.TotalCost
                    End If
                Next

                sqlcon = New OleDbConnection(strcon)
                sqlcon.Open()

                If sqlcon.State = ConnectionState.Open Then
                    datast = New DataSet
                    tables = datast.Tables
                    sql = "SELECT TotalCost, DayID FROM DrawerExpenditure WHERE DayID LIKE '%" & Label28.Text & "%'"
                    'sql = "SELECT Name FROM Menu WHERE Name LIKE '%" & TextBox1.Text & "%'"
                    adapter = New OleDbDataAdapter(sql, sqlcon)
                    adapter.Fill(datast, sql)

                    Dim view As New DataView(tables(0))
                    source1.DataSource = view
                    DataGridView4.DataSource = view
                End If

                Dim GrossExpenditure As Decimal = 0
                For i As Integer = 0 To DataGridView4.Rows.Count - 1
                    GrossExpenditure += DataGridView4.Rows(i).Cells(0).Value
                    Label29.Text = GrossExpenditure
                Next
                'Dim R As TopShelfDataSet.SalesRow = TSB.Rows(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub TheEmpireButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton3.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()

        If Label28.Text = "00" Then
        Else


            'Draw the receipt
            'ReceiptImage = DrawDayReport(DataGridView5.Rows(), Label28.Text, DataGridView1.SelectedRows(0).Cells(1).Value, DataGridView1.SelectedRows(0).Cells(3).Value, DataGridView1.SelectedRows(0).Cells(2).Value)

            Dim TAP As New TopShelfDataSetTableAdapters.PrinterTableAdapter
            Dim TBP = TAP.GetDataByModule("ENDDAY")

            If TBP.Rows.Count = 0 Then
                'Select a printer
                If PrintDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    DrawerPD.PrinterSettings = PrintDlg.PrinterSettings
                    DrawerPD.Print()
                End If
            End If

            Dim RP As TopShelfDataSet.PrinterRow = TBP.Rows(0)
            DrawerPD.PrinterSettings.PrinterName = RP.PrinterName
            DrawerPD.Print()

            'PPD.Document = DrawerPD
            'PPD.ShowDialog()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()

        Me.Dispose()
    End Sub

    Private Sub DrawerPD_BeginPrint(ByVal sender As Object, ByVal e As Printing.PrintEventArgs) Handles DrawerPD.BeginPrint
        Dim pagesetup As New PageSettings
        Dim rai = DataGridView5.Rows.Count - 1
        Dim ReceiptDetailsHeight As Integer = rai * 15
        Dim ReceiptHeight As Integer = 560 + ReceiptDetailsHeight ' + 160
        'Dim rai = 2 * DataGridView3.Rows.Count - 1
        pagesetup.PaperSize = New PaperSize("Custom", 299, ReceiptHeight)
        DrawerPD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub DrawerPD_Printpage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles DrawerPD.PrintPage
        Dim FNT As New Font("Calibri", 10, FontStyle.Regular)
        Dim sahii As New Font("Calibri", 10, FontStyle.Bold)
        Dim sahii1 As New Font("Calibri", 12, FontStyle.Bold)
        Dim karatasi As New Font("Calibri", 10, FontStyle.Bold)
        Dim fnt1 As New Font("Calibri", 8, FontStyle.Bold)

        Dim leftmargin As Integer = DrawerPD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = DrawerPD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = DrawerPD.DefaultPageSettings.PaperSize.Width

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
        e.Graphics.DrawString("END OF DAY REPORT", sahii1, New SolidBrush(Color.Black), centermargin, 65, center)
        e.Graphics.DrawString("Print Date: " & DateTime.Now, FNT, New SolidBrush(Color.Black), centermargin, 85, center)

        e.Graphics.DrawString("DAY ID: " & Label28.Text, FNT, New SolidBrush(Color.Black), 5, 125)
        e.Graphics.DrawString("START DATE: " & CDate(DataGridView1.SelectedRows(0).Cells(1).Value), FNT, New SolidBrush(Color.Black), 5, 140)
        e.Graphics.DrawString("END DATE: " & CDate(DataGridView1.SelectedRows(0).Cells(3).Value), FNT, New SolidBrush(Color.Black), 5, 155)
        e.Graphics.DrawString("STARTING CASH: KSH. " & Format(DataGridView1.SelectedRows(0).Cells(2).Value, "standard"), FNT, New SolidBrush(Color.Black), 5, 170)
        e.Graphics.DrawString("REPORT DETAILS", sahii, New SolidBrush(Color.Black), centermargin, 200, center)

        e.Graphics.DrawString(line2, sahii, New SolidBrush(Color.Black), 0, 218)

        Dim Portions As Decimal = 0
        For L As Integer = 0 To DataGridView5.Rows.Count - 1
            Portions += DataGridView5.Rows(L).Cells(1).Value
        Next

        e.Graphics.DrawString("TOTAL PORTIONS: ", FNT, New SolidBrush(Color.Black), 5, 235)
        e.Graphics.DrawString("" & Format(Portions, "standard"), FNT, New SolidBrush(Color.Black), centermargin, 235)
        e.Graphics.DrawString("CASH SALES: ", FNT, New SolidBrush(Color.Black), 5, 250)
        e.Graphics.DrawString("" & Format(DataGridView1.SelectedRows(0).Cells(4).Value, "standard"), FNT, New SolidBrush(Color.Black), centermargin, 250)
        e.Graphics.DrawString("DRAWER EXPENDITURE: ", FNT, New SolidBrush(Color.Black), 5, 265)
        e.Graphics.DrawString("" & Format(Label29.Text, "standard"), FNT, New SolidBrush(Color.Black), centermargin, 265)
        e.Graphics.DrawString("TOTAL EXPECTED IN DRAWER: " & Format(DataGridView1.SelectedRows(0).Cells(6).Value, "standard"), FNT, New SolidBrush(Color.Black), 5, 280)
        e.Graphics.DrawString("CLOSING AMOUNT: ", FNT, New SolidBrush(Color.Black), 5, 295)
        e.Graphics.DrawString("" & Format(DataGridView1.SelectedRows(0).Cells(4).Value, "standard"), FNT, New SolidBrush(Color.Black), centermargin, 295)

        e.Graphics.DrawString(line2, sahii, New SolidBrush(Color.Black), 0, 310)

        e.Graphics.DrawString("FOOD", sahii, New SolidBrush(Color.Black), 5, 325)
        e.Graphics.DrawString("QTY", sahii, New SolidBrush(Color.Black), 145, 325)
        e.Graphics.DrawString("TOTAL", sahii, New SolidBrush(Color.Black), 215, 325)

        e.Graphics.DrawString(line2, sahii, New SolidBrush(Color.Black), 0, 335)

        Dim height As Integer 'DGV pOSITION

        'Render the text on the receipt
        Dim YLOCi = 355
        'Dim YLOCi2 = YLOCi + 15

        e.Graphics.DrawString(DataGridView5.Rows(0).Cells(0).Value.ToString, FNT, New SolidBrush(Color.Black), 5, YLOCi)  'FOOD/DRINK
        e.Graphics.DrawString(DataGridView5.Rows(0).Cells(1).Value, FNT, New SolidBrush(Color.Black), 160, YLOCi)  'PORTIONS
        e.Graphics.DrawString(Format(DataGridView5.Rows(0).Cells(2).Value, "standard"), FNT, New SolidBrush(Color.Black), 215, YLOCi)  'TOTAL COST

        Dim i As Integer
        For i = 1 To DataGridView5.Rows.Count - 1
            height += 15
            Dim YLOC = YLOCi + 15 * i
            'Dim YLOC2 = YLOC + (15 * i)
            'Dim YLOC3 = YLOC2 + 15

            'render the Values
            e.Graphics.DrawString(DataGridView5.Rows(i).Cells(0).Value, FNT, New SolidBrush(Color.Black), 5, YLOC)  'FOOD/DRINK
            e.Graphics.DrawString(DataGridView5.Rows(i).Cells(1).Value, FNT, New SolidBrush(Color.Black), 160, YLOC)  'PORTIONS
            e.Graphics.DrawString(Format(DataGridView5.Rows(i).Cells(2).Value, "standard"), FNT, New SolidBrush(Color.Black), 215, YLOC)  'TOTAL COST
        Next

        Dim height2 As Integer
        height2 = 370 + height

        e.Graphics.DrawString(line, sahii, New SolidBrush(Color.Black), 0, height2 + 5)

        e.Graphics.DrawString("END OF DAY REPORT.", sahii, New SolidBrush(Color.Black), centermargin, height2 + 25, center)


    End Sub

    Private Sub INVPD_BeginPrint(ByVal sender As Object, ByVal e As Printing.PrintEventArgs) Handles INVPD.BeginPrint
        Dim pagesetup As New PageSettings
        Dim rai = DataGridView5.Rows.Count - 1
        Dim ReceiptDetailsHeight As Integer = rai * 15
        Dim ReceiptHeight As Integer = 560 + ReceiptDetailsHeight ' + 160
        pagesetup.PaperSize = New PaperSize("Custom", 299, ReceiptHeight)
        INVPD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub INVPD_Printpage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles INVPD.PrintPage
        Dim FNT As New Font("Calibri", 10, FontStyle.Regular)
        Dim sahii As New Font("Calibri", 10, FontStyle.Bold)
        Dim sahii1 As New Font("Calibri", 12, FontStyle.Bold)
        Dim karatasi As New Font("Calibri", 10, FontStyle.Bold)
        Dim fnt1 As New Font("Calibri", 8, FontStyle.Bold)

        Dim leftmargin As Integer = INVPD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = INVPD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = INVPD.DefaultPageSettings.PaperSize.Width

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
        e.Graphics.DrawString("END OF DAY REPORT", sahii1, New SolidBrush(Color.Black), centermargin, 65, center)
        e.Graphics.DrawString("Print Date: " & DateTime.Now, FNT, New SolidBrush(Color.Black), centermargin, 85, center)

        e.Graphics.DrawString("DAY ID: " & Label14.Text, FNT, New SolidBrush(Color.Black), 5, 125)
        e.Graphics.DrawString("START DATE: " & CDate(Label15.Text), FNT, New SolidBrush(Color.Black), 5, 140)
        e.Graphics.DrawString("END DATE: " & DateTime.Now, FNT, New SolidBrush(Color.Black), 5, 155)
        e.Graphics.DrawString("STARTING CASH: KSH. " & Format(Label18.Text, "standard"), FNT, New SolidBrush(Color.Black), 5, 170)
        e.Graphics.DrawString("REPORT DETAILS", sahii, New SolidBrush(Color.Black), centermargin, 200, center)

        e.Graphics.DrawString(line2, sahii, New SolidBrush(Color.Black), 0, 218)

        Dim Portions As Decimal = 0
        For L As Integer = 0 To DataGridView5.Rows.Count - 1
            Portions += DataGridView5.Rows(L).Cells(1).Value
        Next

        e.Graphics.DrawString("TOTAL PORTIONS: ", FNT, New SolidBrush(Color.Black), 5, 235)
        e.Graphics.DrawString("" & Format(Portions, "standard"), FNT, New SolidBrush(Color.Black), centermargin, 235)
        e.Graphics.DrawString("TOTAL SALES: ", FNT, New SolidBrush(Color.Black), 5, 250)
        e.Graphics.DrawString("" & Format(Label20.Text, "standard"), FNT, New SolidBrush(Color.Black), centermargin, 250)
        e.Graphics.DrawString("DRAWER EXPENDITURE: ", FNT, New SolidBrush(Color.Black), 5, 265)
        e.Graphics.DrawString("" & Format(Label22.Text, "standard"), FNT, New SolidBrush(Color.Black), centermargin, 265)
        e.Graphics.DrawString("TOTAL EXPECTED IN DRAWER: " & Format(Label23.Text, "standard"), FNT, New SolidBrush(Color.Black), 5, 280)
        e.Graphics.DrawString("CLOSING AMOUNT: ", FNT, New SolidBrush(Color.Black), 5, 295)
        e.Graphics.DrawString("" & Format(TextBox2.Text, "standard"), FNT, New SolidBrush(Color.Black), centermargin, 295)

        e.Graphics.DrawString(line2, sahii, New SolidBrush(Color.Black), 0, 310)

        e.Graphics.DrawString("FOOD", sahii, New SolidBrush(Color.Black), 5, 325)
        e.Graphics.DrawString("QTY", sahii, New SolidBrush(Color.Black), 145, 325)
        e.Graphics.DrawString("TOTAL", sahii, New SolidBrush(Color.Black), 215, 325)

        e.Graphics.DrawString(line2, sahii, New SolidBrush(Color.Black), 0, 335)

        Dim height As Integer 'DGV pOSITION

        'Render the text on the receipt
        Dim YLOCi = 355
        'Dim YLOCi2 = YLOCi + 15

        e.Graphics.DrawString(DataGridView5.Rows(0).Cells(0).Value.ToString, FNT, New SolidBrush(Color.Black), 5, YLOCi)  'FOOD/DRINK
        e.Graphics.DrawString(DataGridView5.Rows(0).Cells(1).Value, FNT, New SolidBrush(Color.Black), 160, YLOCi)  'PORTIONS
        e.Graphics.DrawString(Format(DataGridView5.Rows(0).Cells(2).Value, "standard"), FNT, New SolidBrush(Color.Black), 215, YLOCi)  'TOTAL COST

        Dim i As Integer
        For i = 1 To DataGridView5.Rows.Count - 1
            height += 15
            Dim YLOC = YLOCi + 15 * i
            'Dim YLOC2 = YLOC + (15 * i)
            'Dim YLOC3 = YLOC2 + 15

            'render the Values
            e.Graphics.DrawString(DataGridView5.Rows(i).Cells(0).Value, FNT, New SolidBrush(Color.Black), 5, YLOC)  'FOOD/DRINK
            e.Graphics.DrawString(DataGridView5.Rows(i).Cells(1).Value, FNT, New SolidBrush(Color.Black), 160, YLOC)  'PORTIONS
            e.Graphics.DrawString(Format(DataGridView5.Rows(i).Cells(2).Value, "standard"), FNT, New SolidBrush(Color.Black), 215, YLOC)  'TOTAL COST
        Next

        Dim height2 As Integer
        height2 = 370 + height

        e.Graphics.DrawString(line, sahii, New SolidBrush(Color.Black), 0, height2 + 5)

        e.Graphics.DrawString("END OF DAY REPORT.", sahii, New SolidBrush(Color.Black), centermargin, height2 + 25, center)

    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        MainWindow.Timer2.Start()
        MainWindow.Timer2.Interval = 10000

    End Sub

    Private Sub ElegantThemeTabControlVertical1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ElegantThemeTabControlVertical1.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
    End Sub

    Private Sub ElegantThemeTabControlVertical1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElegantThemeTabControlVertical1.SelectedIndexChanged
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()

        Dim CurrentDate As Date = CDate(DateTimePicker1.Text)
        Dim Interval As Integer = 1
        Dim result As Date = CurrentDate.AddDays(Interval)

        Try
            sqlcon = New OleDbConnection(strcon)
            sqlcon.Open()

            If sqlcon.State = ConnectionState.Open Then
                Dim TKHA As New TopShelfDataSetTableAdapters.SalesTableAdapter
                Dim DKHS As New TopShelfDataSet.SalesDataTable
                TKHA.FillBy1(DKHS, DateTimePicker1.Text, result, ComboBox1.Text)

                source1.DataSource = DKHS
                DataGridView8.DataSource = DKHS
            Else
                MsgBox("DATABASE CONNECTION UNSUCCESSFUL.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ERROR")
        End Try

        Dim TQA As New TopShelfDataSetTableAdapters.SalesTableAdapter
        Dim TQB = TQA.GetDataByDateANDWaiter(DateTimePicker1.Text, result, ComboBox1.Text)

        If TQB.Rows.Count = 0 Then

        Else
            For Each row As TopShelfDataSet.SalesRow In TQB.Rows
                Dim D As Integer
                Dim ItemLoc As Integer = -1
                For D = 0 To DataGridView9.Rows.Count - 1
                    If row.ProductName = DataGridView9.Rows(D).Cells(0).Value Then
                        'Item Found
                        ItemLoc = D
                        Exit For
                    End If

                Next

                'Item not found add it to dgv
                If ItemLoc = -1 Then
                    DataGridView9.Rows.Add(row.ProductName, row.Quantity, row.TotalCost, row.DayID)
                Else

                    Dim TotalCost As Decimal = DataGridView9.Rows(ItemLoc).Cells(2).Value
                    Dim Qty As Long = DataGridView9.Rows(ItemLoc).Cells(1).Value
                    DataGridView9.Rows(ItemLoc).Cells(1).Value = Qty + row.Quantity
                    DataGridView9.Rows(ItemLoc).Cells(2).Value = TotalCost + row.TotalCost
                End If
            Next

        End If
    End Sub

    Private Sub WPD_BeginPrint(ByVal sender As Object, ByVal e As Printing.PrintEventArgs) Handles WPD.BeginPrint
        Dim pagesetup As New PageSettings
        Dim rai = DataGridView9.Rows.Count - 1
        Dim ReceiptDetailsHeight As Integer = rai * 15
        Dim ReceiptHeight As Integer = 560 + ReceiptDetailsHeight ' + 160
        pagesetup.PaperSize = New PaperSize("Custom", 299, ReceiptHeight)
        WPD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub WPD_Printpage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles WPD.PrintPage
        Dim FNT As New Font("Calibri", 10, FontStyle.Regular)
        Dim sahii As New Font("Calibri", 10, FontStyle.Bold)
        Dim sahii1 As New Font("Calibri", 12, FontStyle.Bold)
        Dim karatasi As New Font("Calibri", 10, FontStyle.Bold)
        Dim fnt1 As New Font("Calibri", 8, FontStyle.Bold)

        Dim leftmargin As Integer = WPD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = WPD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = WPD.DefaultPageSettings.PaperSize.Width

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
        e.Graphics.DrawString("WAITER SALES REPORT", sahii1, New SolidBrush(Color.Black), centermargin, 65, center)
        e.Graphics.DrawString("Print Date: " & DateTime.Now, FNT, New SolidBrush(Color.Black), centermargin, 85, center)

        e.Graphics.DrawString("DATE: " & DateTimePicker1.Text, FNT, New SolidBrush(Color.Black), 5, 125)
        e.Graphics.DrawString("WAITER: " & ComboBox1.Text, FNT, New SolidBrush(Color.Black), 5, 140)
        'e.Graphics.DrawString("END DATE: " & DateTime.Now, FNT, New SolidBrush(Color.Black), 5, 155)
        'e.Graphics.DrawString("STARTING CASH: KSH. " & Format(Label18.Text, "standard"), FNT, New SolidBrush(Color.Black), 5, 170)
        'e.Graphics.DrawString("REPORT DETAILS", sahii, New SolidBrush(Color.Black), centermargin, 200, center)

        e.Graphics.DrawString(line2, sahii, New SolidBrush(Color.Black), 0, 158)

        Dim Portions As Decimal = 0
        For L As Integer = 0 To DataGridView9.Rows.Count - 1
            Portions += DataGridView9.Rows(L).Cells(1).Value
        Next

        Dim TotalSales As Decimal = 0
        For L As Integer = 0 To DataGridView9.Rows.Count - 1
            TotalSales += DataGridView9.Rows(L).Cells(2).Value
        Next

        e.Graphics.DrawString("TOTAL PORTIONS: ", FNT, New SolidBrush(Color.Black), 5, 175)
        e.Graphics.DrawString("" & Format(Portions, "standard"), FNT, New SolidBrush(Color.Black), centermargin, 175)
        e.Graphics.DrawString("TOTAL SALES: ", FNT, New SolidBrush(Color.Black), 5, 190)
        e.Graphics.DrawString("" & Format(TotalSales, "standard"), FNT, New SolidBrush(Color.Black), centermargin, 190)
        'e.Graphics.DrawString("DRAWER EXPENDITURE: ", FNT, New SolidBrush(Color.Black), 5, 265)
        'e.Graphics.DrawString("" & Format(Label22.Text, "standard"), FNT, New SolidBrush(Color.Black), centermargin, 265)
        'e.Graphics.DrawString("TOTAL EXPECTED IN DRAWER: " & Format(Label23.Text, "standard"), FNT, New SolidBrush(Color.Black), 5, 280)
        'e.Graphics.DrawString("CLOSING AMOUNT: ", FNT, New SolidBrush(Color.Black), 5, 295)
        'e.Graphics.DrawString("" & Format(TextBox2.Text, "standard"), FNT, New SolidBrush(Color.Black), centermargin, 295)

        e.Graphics.DrawString(line2, sahii, New SolidBrush(Color.Black), 0, 205)

        e.Graphics.DrawString("FOOD", sahii, New SolidBrush(Color.Black), 5, 220)
        e.Graphics.DrawString("QTY", sahii, New SolidBrush(Color.Black), 145, 220)
        e.Graphics.DrawString("TOTAL", sahii, New SolidBrush(Color.Black), 215, 220)

        e.Graphics.DrawString(line2, sahii, New SolidBrush(Color.Black), 0, 230)

        Dim height As Integer 'DGV pOSITION

        'Render the text on the receipt
        Dim YLOCi = 250
        'Dim YLOCi2 = YLOCi + 15

        e.Graphics.DrawString(DataGridView9.Rows(0).Cells(0).Value.ToString, FNT, New SolidBrush(Color.Black), 5, YLOCi)  'FOOD/DRINK
        e.Graphics.DrawString(DataGridView9.Rows(0).Cells(1).Value, FNT, New SolidBrush(Color.Black), 160, YLOCi)  'PORTIONS
        e.Graphics.DrawString(Format(DataGridView9.Rows(0).Cells(2).Value, "standard"), FNT, New SolidBrush(Color.Black), 215, YLOCi)  'TOTAL COST

        Dim i As Integer
        For i = 1 To DataGridView9.Rows.Count - 1
            height += 15
            Dim YLOC = YLOCi + 15 * i
            'Dim YLOC2 = YLOC + (15 * i)
            'Dim YLOC3 = YLOC2 + 15

            'render the Values
            e.Graphics.DrawString(DataGridView9.Rows(i).Cells(0).Value, FNT, New SolidBrush(Color.Black), 5, YLOC)  'FOOD/DRINK
            e.Graphics.DrawString(DataGridView9.Rows(i).Cells(1).Value, FNT, New SolidBrush(Color.Black), 160, YLOC)  'PORTIONS
            e.Graphics.DrawString(Format(DataGridView9.Rows(i).Cells(2).Value, "standard"), FNT, New SolidBrush(Color.Black), 215, YLOC)  'TOTAL COST
        Next

        Dim height2 As Integer
        height2 = 265 + height

        e.Graphics.DrawString(line, sahii, New SolidBrush(Color.Black), 0, height2 + 5)

        e.Graphics.DrawString("END OF WAITER SALES REPORT.", sahii, New SolidBrush(Color.Black), centermargin, height2 + 25, center)

    End Sub

    Private Sub TheEmpireButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton4.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()

        If DataGridView9.Rows.Count - 1 = 0 Then
            MsgBox("PLEASE SELECT DATE AND WAITER NAME ABOVE.", MsgBoxStyle.Information)
            Exit Sub
        Else

            'Draw the receipt
            'ReceiptImage = DrawDayReport(DataGridView5.Rows(), Label28.Text, DataGridView1.SelectedRows(0).Cells(1).Value, DataGridView1.SelectedRows(0).Cells(3).Value, DataGridView1.SelectedRows(0).Cells(2).Value)

            Dim TAP As New TopShelfDataSetTableAdapters.PrinterTableAdapter
            Dim TBP = TAP.GetDataByModule("ENDDAY")

            If TBP.Rows.Count = 0 Then
                'Select a printer
                If PrintDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    WPD.PrinterSettings = PrintDlg.PrinterSettings
                    WPD.Print()
                End If
            End If

            Dim RP As TopShelfDataSet.PrinterRow = TBP.Rows(0)
            WPD.PrinterSettings.PrinterName = RP.PrinterName
            WPD.Print()

            'PPD.Document = WPD
            'PPD.ShowDialog()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
    End Sub

    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click

    End Sub
End Class