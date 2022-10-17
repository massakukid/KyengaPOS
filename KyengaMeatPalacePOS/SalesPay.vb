Imports System.Data
Imports System.Data.OleDb
Imports System.Text
Imports System.IO
Imports System.Drawing.Printing
Public Class SalesPay
    Dim ReceiptImage As Bitmap
    Dim result As Integer
    Dim WithEvents ReceiptPD As New PrintDocument
    Dim WithEvents KitchenPD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Private Sub TheEmpireButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton1.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "1"
        Else
            TextBox1.Text = TextBox1.Text + "1"
        End If
    End Sub

    Private Sub TheEmpireButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton2.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "2"
        Else
            TextBox1.Text = TextBox1.Text + "2"
        End If
    End Sub

    Private Sub TheEmpireButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton3.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "3"
        Else
            TextBox1.Text = TextBox1.Text + "3"
        End If
    End Sub

    Private Sub TheEmpireButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton4.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "4"
        Else
            TextBox1.Text = TextBox1.Text + "4"
        End If
    End Sub

    Private Sub TheEmpireButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton5.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "5"
        Else
            TextBox1.Text = TextBox1.Text + "5"
        End If
    End Sub

    Private Sub TheEmpireButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton6.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "6"
        Else
            TextBox1.Text = TextBox1.Text + "6"
        End If
    End Sub

    Private Sub TheEmpireButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton7.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "7"
        Else
            TextBox1.Text = TextBox1.Text + "7"
        End If
    End Sub

    Private Sub TheEmpireButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton8.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "8"
        Else
            TextBox1.Text = TextBox1.Text + "8"
        End If
    End Sub

    Private Sub TheEmpireButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton9.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "9"
        Else
            TextBox1.Text = TextBox1.Text + "9"
        End If
    End Sub

    Private Sub TheEmpireButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton10.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text = TextBox1.Text + "0"
        End If
    End Sub

    Private Sub TheEmpireButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton11.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        TextBox1.Clear()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text.Trim().Length = 0 Then
                MsgBox("PLEASE ENTER THE CASH PAID.", MsgBoxStyle.Information)
                Exit Sub
            End If
            generate_id()
            Dim Cash As Decimal = TextBox1.Text
            Dim TTC As Decimal = Label4.Text
            If Cash < TTC Then
                MsgBox("NO CREDIT ALLOWED. PLEASE PAY THE FULL AMOUNT.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Try
                sqlcon = New OleDbConnection(strcon)
                sqlcon.Open()
                If sqlcon.State = ConnectionState.Open Then
                Else
                    MsgBox("DataBase Connection Un-Successful.", MsgBoxStyle.Information)
                    Exit Sub
                End If
                Dim TA As New TopShelfDataSetTableAdapters.EndDayTableAdapter
                Dim TB = TA.GetDataByOpen("OPEN")

                If TB.Rows.Count = 0 Then
                    MsgBox("CASH DRAWER NOT ACTIVATED. PLEASE START THE DAY.", MsgBoxStyle.Information)
                    Exit Sub
                Else
                    Dim R As TopShelfDataSet.EndDayRow = TB.Rows(0)

                    'Insert the new receipt details
                    Dim Sql As String = "INSERT INTO Receipt (ReceiptID, ReceiptDate, ReceiptTotal, DayID) VALUES ('" & Label8.Text & "', '" & DateTime.Now & "', '" & Label4.Text & "', '" & R.ID & "')"
                    Dim cmd1 As New OleDbCommand
                    cmd1.Connection = sqlcon
                    cmd1.CommandText = Sql

                    cmd1.ExecuteNonQuery()
                    cmd1.Dispose()

                    For Each row As DataGridViewRow In DataGridView1.Rows
                        If row.Cells(0).FormattedValue <> "" Then
                            Sql = "INSERT INTO Sales (Barcode, [Date], ProductName, PUnit, Quantity, TotalCost, ReceiptID, Cashier, Category, Waiter, DayID, PaymentMethod) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "', '" & DateTime.Now & "', '" & CStr(row.Cells(1).FormattedValue) & "', '" & CDec(row.Cells(2).FormattedValue) & "', '" & CInt(row.Cells(3).FormattedValue) & "', '" & CDec(row.Cells(4).FormattedValue) & "', '" & Label8.Text & "', '" & MainWindow.Label1.Text & "', '" & CStr(row.Cells(5).FormattedValue) & "', '" & MainWindow.Label1.Text & "', '" & R.ID & "', '" & "CASH" & "')"
                            'Sql = "INSERT INTO Sales (Barcode, [Date], ProductName, PUnit, Quantity, TotalCost, ReceiptID, VATAMT, UserName, Category, AccountName) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & Date.Now & "','" & CStr(row.Cells(2).FormattedValue) & "','" & CStr(row.Cells(4).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & CStr(row.Cells(5).FormattedValue) & "','" & Label10.Text & "','" & CStr(row.Cells(6).FormattedValue) & "','" & MainWindow.TextBox1.Text & "','" & CStr(row.Cells(3).FormattedValue) & "', '" & R.Account & "')"
                            With cmd
                                .Connection = sqlcon
                                .CommandText = Sql
                            End With
                            result = cmd.ExecuteNonQuery()
                        End If

                    Next

                    'Draw the receipt
                    'ReceiptImage = DrawKitchenReceipt(DataGridView1.Rows(), Label8.Text, DateTime.Now, MainWindow.Label1.Text)

                    Dim TAP As New TopShelfDataSetTableAdapters.PrinterTableAdapter
                    Dim TBP = TAP.GetDataByModule("KITCHEN")

                    If TBP.Rows.Count = 0 Then
                        'Select a printer
                        If PrintDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                            KitchenPD.PrinterSettings = PrintDlg.PrinterSettings
                            KitchenPD.Print()
                        End If
                    End If

                    Dim RP As TopShelfDataSet.PrinterRow = TBP.Rows(0)
                    KitchenPD.PrinterSettings.PrinterName = RP.PrinterName
                    KitchenPD.Print()


                    'Restaurant print
                    'ReceiptImage = DrawReceipt(DataGridView1.Rows(), Label8.Text, DateTime.Now, Label4.Text, TextBox1.Text, Label5.Text, MainWindow.Label1.Text)

                    Dim QTAP As New TopShelfDataSetTableAdapters.PrinterTableAdapter
                    Dim QTBP = QTAP.GetDataByModule("RESTAURANT")

                    If QTBP.Rows.Count = 0 Then
                        'Select a printer
                        If PrintDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                            ReceiptPD.PrinterSettings = PrintDlg.PrinterSettings
                            ReceiptPD.Print()
                        End If
                    End If

                    Dim QRP As TopShelfDataSet.PrinterRow = QTBP.Rows(0)
                    ReceiptPD.PrinterSettings.PrinterName = QRP.PrinterName
                    ReceiptPD.Print()

                    'PPD.Document = ReceiptPD
                    'PPD.ShowDialog()
                    'Dim IG = ReceiptImage
                    'Dim sfd As New SaveFileDialog
                    'sfd.Filter = "*.bmp|*.bmp"
                    'If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    '    IG.Save(sfd.FileName)
                    '    End If
                End If
                cmd.Dispose()
                If result > 0 Then
                    MsgBox("All Records Saved.", MsgBoxStyle.Information)
                Else
                    MsgBox("No Record saved.", MsgBoxStyle.Information)
                End If

                DataGridView1.Rows.Clear()
                Sales.DataGridView1.Rows.Clear()
                Sales.Label2.Text = "00"
                TextBox1.Clear()
                Label4.Text = "00"
                Label5.Text = "00"
                Me.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            End Try
            If sqlcon IsNot Nothing Then
                If sqlcon.State = ConnectionState.Open Then
                    sqlcon.Close()
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        'AndAlso Not e.KeyChar = "." AndAlso Not e.keyChar = "-"
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TextBox1.Text.Trim().Length = 0 Then
            Label5.Text = 0.0
        Else
            Dim TotalCost As Decimal = Label4.Text
            Dim CashPaid As Decimal = TextBox1.Text
            Dim Balance As Decimal = CashPaid - TotalCost
            Label5.Text = Format(Balance, "standard")
        End If
    End Sub

    Private Sub generate_id()
        sqlcon = New OleDbConnection(strcon)
        sqlcon.Open()
        If sqlcon.State = ConnectionState.Open Then

            Dim TA As New TopShelfDataSetTableAdapters.ReceiptTableAdapter
            Dim TB = TA.GetDataByGenerateID()

            If TB.Rows.Count = 0 Then
                Exit Sub
            Else
                Dim R As TopShelfDataSet.ReceiptRow = TB.Rows(0)
                Label8.Text = R.ReceiptID
            End If
            
        Else

        End If

    End Sub

    Private Sub TheEmpireButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton13.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TextBox1.Text.Trim().Length = 0 Then
            MsgBox("PLEASE ENTER THE CASH PAID.", MsgBoxStyle.Information)
            Exit Sub
        End If
        generate_id()
        Dim Cash As Decimal = TextBox1.Text
        Dim TTC As Decimal = Label4.Text
        If Cash < TTC Then
            MsgBox("NO CREDIT ALLOWED. PLEASE PAY THE FULL AMOUNT.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            sqlcon = New OleDbConnection(strcon)
            sqlcon.Open()
            If sqlcon.State = ConnectionState.Open Then
            Else
                MsgBox("DataBase Connection Un-Successful.", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dim TA As New TopShelfDataSetTableAdapters.EndDayTableAdapter
            Dim TB = TA.GetDataByOpen("OPEN")

            If TB.Rows.Count = 0 Then
                MsgBox("CASH DRAWER NOT ACTIVATED. PLEASE START THE DAY.", MsgBoxStyle.Information)
                Exit Sub
            Else
                Dim R As TopShelfDataSet.EndDayRow = TB.Rows(0)

                'Insert the new receipt details
                Dim Sql As String = "INSERT INTO Receipt (ReceiptID, ReceiptDate, ReceiptTotal, DayID) VALUES ('" & Label8.Text & "', '" & DateTime.Now & "', '" & Label4.Text & "', '" & R.ID & "')"
                Dim cmd1 As New OleDbCommand
                cmd1.Connection = sqlcon
                cmd1.CommandText = Sql

                cmd1.ExecuteNonQuery()
                cmd1.Dispose()

                For Each row As DataGridViewRow In DataGridView1.Rows
                    If row.Cells(0).FormattedValue <> "" Then
                        Sql = "INSERT INTO Sales (Barcode, [Date], ProductName, PUnit, Quantity, TotalCost, ReceiptID, Cashier, Category, Waiter, DayID, PaymentMethod) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "', '" & DateTime.Now & "', '" & CStr(row.Cells(1).FormattedValue) & "', '" & CDec(row.Cells(2).FormattedValue) & "', '" & CInt(row.Cells(3).FormattedValue) & "', '" & CDec(row.Cells(4).FormattedValue) & "', '" & Label8.Text & "', '" & MainWindow.Label1.Text & "', '" & CStr(row.Cells(5).FormattedValue) & "', '" & MainWindow.Label1.Text & "', '" & R.ID & "', '" & "CASH" & "')"
                        'Sql = "INSERT INTO Sales (Barcode, [Date], ProductName, PUnit, Quantity, TotalCost, ReceiptID, VATAMT, UserName, Category, AccountName) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & Date.Now & "','" & CStr(row.Cells(2).FormattedValue) & "','" & CStr(row.Cells(4).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & CStr(row.Cells(5).FormattedValue) & "','" & Label10.Text & "','" & CStr(row.Cells(6).FormattedValue) & "','" & MainWindow.TextBox1.Text & "','" & CStr(row.Cells(3).FormattedValue) & "', '" & R.Account & "')"
                        With cmd
                            .Connection = sqlcon
                            .CommandText = Sql
                        End With
                        result = cmd.ExecuteNonQuery()
                    End If

                Next

                'Draw the receipt
                'ReceiptImage = DrawKitchenReceipt(DataGridView1.Rows(), Label8.Text, DateTime.Now, MainWindow.Label1.Text)

                Dim TAP As New TopShelfDataSetTableAdapters.PrinterTableAdapter
                Dim TBP = TAP.GetDataByModule("KITCHEN")

                If TBP.Rows.Count = 0 Then
                    'Select a printer
                    If PrintDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                        KitchenPD.PrinterSettings = PrintDlg.PrinterSettings
                        KitchenPD.Print()
                    End If
                End If

                Dim RP As TopShelfDataSet.PrinterRow = TBP.Rows(0)
                KitchenPD.PrinterSettings.PrinterName = RP.PrinterName
                KitchenPD.Print()


                'Restaurant print
                'ReceiptImage = DrawReceipt(DataGridView1.Rows(), Label8.Text, DateTime.Now, Label4.Text, TextBox1.Text, Label5.Text, MainWindow.Label1.Text)

                Dim QTAP As New TopShelfDataSetTableAdapters.PrinterTableAdapter
                Dim QTBP = QTAP.GetDataByModule("RESTAURANT")

                If QTBP.Rows.Count = 0 Then
                    'Select a printer
                    If PrintDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                        ReceiptPD.PrinterSettings = PrintDlg.PrinterSettings
                        ReceiptPD.Print()
                    End If
                End If

                Dim QRP As TopShelfDataSet.PrinterRow = QTBP.Rows(0)
                ReceiptPD.PrinterSettings.PrinterName = QRP.PrinterName
                ReceiptPD.Print()

                'PPD.Document = ReceiptPD
                'PPD.ShowDialog()
                'Dim IG = ReceiptImage
                'Dim sfd As New SaveFileDialog
                'sfd.Filter = "*.bmp|*.bmp"
                'If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                '    IG.Save(sfd.FileName)
                '    End If
            End If
            cmd.Dispose()
            If result > 0 Then
                MsgBox("All Records Saved.", MsgBoxStyle.Information)
            Else
                MsgBox("No Record saved.", MsgBoxStyle.Information)
            End If

            DataGridView1.Rows.Clear()
            Sales.DataGridView1.Rows.Clear()
            Sales.Label2.Text = "00"
            TextBox1.Clear()
            Label4.Text = "00"
            Label5.Text = "00"
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
        If sqlcon IsNot Nothing Then
            If sqlcon.State = ConnectionState.Open Then
                sqlcon.Close()
            End If
        End If
    End Sub

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

        GR.DrawString(Rows(0).Cells(1).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 0, YLOCi)  'MEAL/DRINK
        GR.DrawString(Rows(0).Cells(2).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 4, YLOCi2)  'punit
        GR.DrawString(Rows(0).Cells(3).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 7, YLOCi2)  'Units
        GR.DrawString(Rows(0).Cells(4).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 10, YLOCi2)  'tc/sum
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
            GR.DrawString(Rows(i).Cells(1).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 0, YLOC2)  'MEAL/DRINK
            GR.DrawString(Rows(i).Cells(2).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 4, YLOC3)  'punit
            GR.DrawString(Rows(i).Cells(3).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 7, YLOC3)  'units
            GR.DrawString(Rows(i).Cells(4).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 10, YLOC3)  'tc/sum
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

    Private Sub SalesPay_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        generate_id()
        TextBox1.Focus()
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

        GR.DrawString(Rows(0).Cells(1).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 0, YLOCi)  'MEAL/DRINK
        GR.DrawString(Rows(0).Cells(3).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 7, YLOCi2)  'Units
        Dim i As Integer
        For i = 1 To Rows.Count - 1

            Dim YLOC = YLOCi + UnitHeight * i
            Dim YLOC2 = YLOC + (UnitHeight * i)
            Dim YLOC3 = YLOC2 + UnitHeight
            'render the Values
            GR.DrawString(Rows(i).Cells(1).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 0, YLOC2)  'MEAL/DRINK
            GR.DrawString(Rows(i).Cells(3).Value, FNT, New SolidBrush(Color.Black), UnitWidth * 7, YLOC3)  'units
        Next

        'Render footer1
        GR.DrawString("        SERVER: " & USERNAME, FNT, New SolidBrush(Color.Black), UnitWidth * 0, footer1)

        'Write the receipt number and date
        GR.DrawString("Date: " & ReceiptDate, FNT, New SolidBrush(Color.Black), 0, UnitHeight * 4)
        GR.DrawString("Receipt No: " & ReceiptNo, FNT, New SolidBrush(Color.Black), 0, UnitHeight * 5)

        Return BMP

    End Function

    Private Sub TheEmpireButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton12.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TextBox1.Text.Trim().Length = 0 Then
            MsgBox("PLEASE ENTER THE CASH PAID.", MsgBoxStyle.Information)
            Exit Sub
        End If
        generate_id()
        Dim Cash As Decimal = TextBox1.Text
        Dim TTC As Decimal = Label4.Text
        If Cash < TTC Then
            MsgBox("NO CREDIT ALLOWED. PLEASE PAY THE FULL AMOUNT.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            sqlcon = New OleDbConnection(strcon)
            sqlcon.Open()
            If sqlcon.State = ConnectionState.Open Then
            Else
                MsgBox("DataBase Connection Un-Successful.", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dim TA As New TopShelfDataSetTableAdapters.EndDayTableAdapter
            Dim TB = TA.GetDataByOpen("OPEN")

            If TB.Rows.Count = 0 Then
                MsgBox("CASH DRAWER NOT ACTIVATED. PLEASE START THE DAY.", MsgBoxStyle.Information)
                Exit Sub
            Else
                Dim R As TopShelfDataSet.EndDayRow = TB.Rows(0)

                'Insert the new receipt details
                Dim Sql As String = "INSERT INTO Receipt (ReceiptID, ReceiptDate, ReceiptTotal, DayID) VALUES ('" & Label8.Text & "', '" & DateTime.Now & "', '" & Label4.Text & "', '" & R.ID & "')"
                Dim cmd1 As New OleDbCommand
                cmd1.Connection = sqlcon
                cmd1.CommandText = Sql

                cmd1.ExecuteNonQuery()
                cmd1.Dispose()

                For Each row As DataGridViewRow In DataGridView1.Rows
                    If row.Cells(0).FormattedValue <> "" Then
                        Sql = "INSERT INTO Sales (Barcode, [Date], ProductName, PUnit, Quantity, TotalCost, ReceiptID, Cashier, Category, Waiter, DayID, PaymentMethod) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "', '" & DateTime.Now & "', '" & CStr(row.Cells(1).FormattedValue) & "', '" & CDec(row.Cells(2).FormattedValue) & "', '" & CInt(row.Cells(3).FormattedValue) & "', '" & CDec(row.Cells(4).FormattedValue) & "', '" & Label8.Text & "', '" & MainWindow.Label1.Text & "', '" & CStr(row.Cells(5).FormattedValue) & "', '" & MainWindow.Label1.Text & "', '" & R.ID & "', '" & "CASH" & "')"
                        'Sql = "INSERT INTO Sales (Barcode, [Date], ProductName, PUnit, Quantity, TotalCost, ReceiptID, VATAMT, UserName, Category, AccountName) VALUES ('" & CStr(row.Cells(0).FormattedValue) & "','" & Date.Now & "','" & CStr(row.Cells(2).FormattedValue) & "','" & CStr(row.Cells(4).FormattedValue) & "','" & CStr(row.Cells(1).FormattedValue) & "','" & CStr(row.Cells(5).FormattedValue) & "','" & Label10.Text & "','" & CStr(row.Cells(6).FormattedValue) & "','" & MainWindow.TextBox1.Text & "','" & CStr(row.Cells(3).FormattedValue) & "', '" & R.Account & "')"
                        With cmd
                            .Connection = sqlcon
                            .CommandText = Sql
                        End With
                        result = cmd.ExecuteNonQuery()
                    End If

                Next

                'Draw the receipt
                'ReceiptImage = DrawKitchenReceipt(DataGridView1.Rows(), Label8.Text, DateTime.Now, MainWindow.Label1.Text)

                Dim TAP As New TopShelfDataSetTableAdapters.PrinterTableAdapter
                Dim TBP = TAP.GetDataByModule("KITCHEN")

                If TBP.Rows.Count = 0 Then
                    'Select a printer
                    If PrintDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                        KitchenPD.PrinterSettings = PrintDlg.PrinterSettings
                        KitchenPD.Print()
                    End If
                End If

                Dim RP As TopShelfDataSet.PrinterRow = TBP.Rows(0)
                KitchenPD.PrinterSettings.PrinterName = RP.PrinterName
                KitchenPD.Print()


                'Restaurant print
                'ReceiptImage = DrawReceipt(DataGridView1.Rows(), Label8.Text, DateTime.Now, Label4.Text, TextBox1.Text, Label5.Text, MainWindow.Label1.Text)

                Dim QTAP As New TopShelfDataSetTableAdapters.PrinterTableAdapter
                Dim QTBP = QTAP.GetDataByModule("RESTAURANT")

                If QTBP.Rows.Count = 0 Then
                    'Select a printer
                    If PrintDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                        ReceiptPD.PrinterSettings = PrintDlg.PrinterSettings
                        ReceiptPD.Print()
                    End If
                End If

                Dim QRP As TopShelfDataSet.PrinterRow = QTBP.Rows(0)
                ReceiptPD.PrinterSettings.PrinterName = QRP.PrinterName
                ReceiptPD.Print()

                'PPD.Document = ReceiptPD
                'PPD.ShowDialog()
                'Dim IG = ReceiptImage
                'Dim sfd As New SaveFileDialog
                'sfd.Filter = "*.bmp|*.bmp"
                'If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                '    IG.Save(sfd.FileName)
                '    End If
            End If
            cmd.Dispose()
            If result > 0 Then
                MsgBox("All Records Saved.", MsgBoxStyle.Information)
            Else
                MsgBox("No Record saved.", MsgBoxStyle.Information)
            End If

            DataGridView1.Rows.Clear()
            Sales.DataGridView1.Rows.Clear()
            Sales.Label2.Text = "00"
            TextBox1.Clear()
            Label4.Text = "00"
            Label5.Text = "00"
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
        If sqlcon IsNot Nothing Then
            If sqlcon.State = ConnectionState.Open Then
                sqlcon.Close()
            End If
        End If
    End Sub

    Private Sub TheEmpireButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton14.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        Me.Dispose()
    End Sub

    Private Sub ReceiptPD_BeginPrint(ByVal sender As Object, ByVal e As Printing.PrintEventArgs) Handles ReceiptPD.BeginPrint
        Dim pagesetup As New PageSettings
        Dim rai = 2 * DataGridView1.Rows.Count - 1
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

        e.Graphics.DrawString("RECEIPT NO. " & Label8.Text, FNT, New SolidBrush(Color.Black), 5, 105)
        e.Graphics.DrawString("DATE: " & DateTime.Now, FNT, New SolidBrush(Color.Black), 5, 120)

        e.Graphics.DrawString(line2, sahii, New SolidBrush(Color.Black), 0, 125)

        e.Graphics.DrawString("FOOD", FNT, New SolidBrush(Color.Black), 5, 140)
        e.Graphics.DrawString("PRICE", FNT, New SolidBrush(Color.Black), 85, 140)
        e.Graphics.DrawString("QTY", FNT, New SolidBrush(Color.Black), 145, 140)
        e.Graphics.DrawString("TOTAL", FNT, New SolidBrush(Color.Black), 215, 140)

        e.Graphics.DrawString(line2, sahii, New SolidBrush(Color.Black), 0, 150)

        Dim height As Integer 'DGV pOSITION

        'Render the text on the receipt
        Dim YLOCi = 170
        Dim YLOCi2 = YLOCi + 15

        e.Graphics.DrawString(DataGridView1.Rows(0).Cells(1).Value.ToString, FNT, New SolidBrush(Color.Black), 5, YLOCi)  'FOOD/DRINK
        e.Graphics.DrawString(Format(DataGridView1.Rows(0).Cells(2).Value, "standard"), FNT, New SolidBrush(Color.Black), 90, YLOCi2)  'PRICE
        e.Graphics.DrawString(DataGridView1.Rows(0).Cells(3).Value, FNT, New SolidBrush(Color.Black), 160, YLOCi2)  'UNITS
        e.Graphics.DrawString(Format(DataGridView1.Rows(0).Cells(4).Value, "standard"), FNT, New SolidBrush(Color.Black), 215, YLOCi2)  'TOTAL COST

        Dim i As Integer
        For i = 1 To DataGridView1.Rows.Count - 1
            height += 30
            Dim YLOC = YLOCi + 15 * i
            Dim YLOC2 = YLOC + (15 * i)
            Dim YLOC3 = YLOC2 + 15

            'render the Values
            e.Graphics.DrawString(DataGridView1.Rows(i).Cells(1).Value, FNT, New SolidBrush(Color.Black), 5, YLOC2)  'FOOD/DRINK
            e.Graphics.DrawString(Format(DataGridView1.Rows(i).Cells(2).Value, "standard"), FNT, New SolidBrush(Color.Black), 90, YLOC3)  'PRICE
            e.Graphics.DrawString(DataGridView1.Rows(i).Cells(3).Value, FNT, New SolidBrush(Color.Black), 160, YLOC3)  'UNITS
            e.Graphics.DrawString(Format(DataGridView1.Rows(i).Cells(4).Value, "standard"), FNT, New SolidBrush(Color.Black), 215, YLOC3)  'TOTAL COST
        Next

        Dim height2 As Integer
        height2 = 200 + height

        e.Graphics.DrawString(line, sahii, New SolidBrush(Color.Black), 0, height2 + 5)
        e.Graphics.DrawString(line, sahii, New SolidBrush(Color.Black), 0, height2 + 2)

        e.Graphics.DrawString("TOTAL COST: ", sahii, New SolidBrush(Color.Black), 5, height2 + 20)
        e.Graphics.DrawString("" & Format(Label4.Text, "standard"), sahii, New SolidBrush(Color.Black), centermargin, height2 + 20)
        e.Graphics.DrawString("CASH PAID: ", sahii, New SolidBrush(Color.Black), 5, height2 + 40)
        e.Graphics.DrawString("" & Format(TextBox1.Text, "standard"), sahii, New SolidBrush(Color.Black), centermargin, height2 + 40)
        e.Graphics.DrawString("BALANCE: ", sahii, New SolidBrush(Color.Black), 5, height2 + 60)
        e.Graphics.DrawString("" & Format(Label5.Text, "standard"), sahii, New SolidBrush(Color.Black), centermargin, height2 + 60)

        e.Graphics.DrawString(line, sahii, New SolidBrush(Color.Black), 0, height2 + 70)
        e.Graphics.DrawString(line, sahii, New SolidBrush(Color.Black), 0, height2 + 72)

        e.Graphics.DrawString("THANK YOU FOR DINING WITH US.", sahii, New SolidBrush(Color.Black), 5, height2 + 85)
        e.Graphics.DrawString("YOU WERE SERVED BY: " & MainWindow.Label1.Text, sahii, New SolidBrush(Color.Black), 5, height2 + 105)
    End Sub

    Private Sub KitchenPD_BeginPrint(ByVal sender As Object, ByVal e As Printing.PrintEventArgs) Handles KitchenPD.BeginPrint
        Dim pagesetup As New PageSettings
        Dim rai = DataGridView1.Rows.Count - 1
        Dim ReceiptDetailsHeight As Integer = rai * 15
        Dim ReceiptHeight As Integer = 450 + ReceiptDetailsHeight ' + 160
        pagesetup.PaperSize = New PaperSize("Custom", 299, ReceiptHeight)
        KitchenPD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub KitchenPD_Printpage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles KitchenPD.PrintPage
        Dim FNT As New Font("Calibri", 10, FontStyle.Regular)
        Dim sahii As New Font("Calibri", 10, FontStyle.Bold)
        Dim sahii1 As New Font("Calibri", 12, FontStyle.Bold)
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

        e.Graphics.DrawString("RECEIPT NO. " & Label8.Text, FNT, New SolidBrush(Color.Black), 5, 105)
        e.Graphics.DrawString("DATE: " & DateTime.Now, FNT, New SolidBrush(Color.Black), 5, 120)

        e.Graphics.DrawString(line2, sahii, New SolidBrush(Color.Black), 0, 135)

        e.Graphics.DrawString("FOOD/DRINK", sahii, New SolidBrush(Color.Black), 5, 150)
        e.Graphics.DrawString("QUANTITY", sahii, New SolidBrush(Color.Black), 215, 150)

        e.Graphics.DrawString(line2, sahii, New SolidBrush(Color.Black), 0, 160)

        Dim height As Integer 'DGV pOSITION

        'Render the text on the receipt
        Dim YLOCi = 180
        'Dim YLOCi2 = YLOCi + 15

        e.Graphics.DrawString(DataGridView1.Rows(0).Cells(1).Value.ToString, FNT, New SolidBrush(Color.Black), 5, YLOCi)  'FOOD/DRINK
        e.Graphics.DrawString(DataGridView1.Rows(0).Cells(3).Value, FNT, New SolidBrush(Color.Black), 220, YLOCi)  'UNITS

        Dim i As Integer
        For i = 1 To DataGridView1.Rows.Count - 1
            height += 15
            Dim YLOC = YLOCi + 15 * i
            'Dim YLOC2 = YLOC + (15 * i)
            'Dim YLOC3 = YLOC2 + 15

            'render the Values
            e.Graphics.DrawString(DataGridView1.Rows(i).Cells(1).Value, FNT, New SolidBrush(Color.Black), 5, YLOC)  'FOOD/DRINK
            e.Graphics.DrawString(DataGridView1.Rows(i).Cells(3).Value, FNT, New SolidBrush(Color.Black), 220, YLOC)  'UNITS
        Next

        Dim height2 As Integer
        height2 = 195 + height

        e.Graphics.DrawString(line, sahii, New SolidBrush(Color.Black), 0, height2 + 5)
        e.Graphics.DrawString(line, sahii, New SolidBrush(Color.Black), 0, height2 + 2)

        e.Graphics.DrawString("SERVICE BY: " & MainWindow.Label1.Text, sahii, New SolidBrush(Color.Black), 5, height2 + 20)

    End Sub
End Class