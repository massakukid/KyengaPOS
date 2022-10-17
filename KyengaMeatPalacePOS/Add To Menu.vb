Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms.DataGridView
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Add_To_Menu

    Private Sub Add_To_Menu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub Add_To_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TopShelfDataSet.MenuCategory' table. You can move, or remove it, as needed.
        Me.MenuCategoryTableAdapter.Fill(Me.TopShelfDataSet.MenuCategory)
        'TODO: This line of code loads data into the 'TopShelfDataSet.Menu' table. You can move, or remove it, as needed.
        Me.MenuTableAdapter.Fill(Me.TopShelfDataSet.Menu)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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

    Private Sub TheEmpireButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton2.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If DataGridView1.RowCount = Nothing Then
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

            rowsTotal = DataGridView1.RowCount - 1
            colsTotal = DataGridView1.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView1.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView1.Rows(I).Cells(j).Value
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

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        Try
            sqlcon = New OleDbConnection(strcon)
            sqlcon.Open()

            If sqlcon.State = ConnectionState.Open Then
                datast = New DataSet
                tables = datast.Tables
                sql = "SELECT ID, Name, Category, Cost FROM Menu WHERE Name LIKE '%" & TextBox1.Text & "%'"
                adapter = New OleDbDataAdapter(sql, sqlcon)
                adapter.Fill(datast, sql)

                Dim view As New DataView(tables(0))
                source1.DataSource = view
                DataGridView1.DataSource = view
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

    Private Sub TheEmpireButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton3.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        Try
            If DataGridView1.CurrentRow.IsNewRow Then
                MsgBox("NO RECORD FOUND. PLEASE SELECT A VALID ROW.", MsgBoxStyle.Information)
                Exit Sub
            Else
                If MessageBox.Show("ARE YOU SURE YOU'D LIKE TO DELETE THIS RECORD?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

                    'create the adapter
                    Dim TDC As New TopShelfDataSetTableAdapters.MenuTableAdapter

                    'Delete the item
                    TDC.DeleteByID(DataGridView1.SelectedRows(0).Cells(0).Value)
                    TDC.Fill(TopShelfDataSet.Menu)

                    'close window and return ok
                    MsgBox("DELETE SUCCESSFUL.", MsgBoxStyle.Information)

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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
                cmd.CommandText = "INSERT INTO MenuCategory (Category) VALUES (?)"

                cmd = New OleDbCommand(cmd.CommandText, sqlcon)

                If ProductName.Trim().Length = 0 Then
                    Dim Result As String = MsgBox("PROCESS ABORTED.", MsgBoxStyle.OkOnly)
                    Exit Sub
                Else
                    cmd.Parameters.Add("@Category", OleDbType.Char).Value = ProductName.ToUpper
                End If

                cmd.ExecuteNonQuery()
                MessageBox.Show("Data is Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox("DATABASE CONNECTION UNSUCCESSFUL.", MsgBoxStyle.Exclamation)
            End If
            'TODO: This line of code loads data into the 'TopShelfDataSet.Menu' table. You can move, or remove it, as needed.
            Me.MenuCategoryTableAdapter.Fill(Me.TopShelfDataSet.MenuCategory)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        sqlcon.Close()
        sqlcon.Dispose()
        sqlcon = Nothing
    End Sub

    Private Sub TheEmpireButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton1.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TextBox2.Text.Trim().Length = 0 Then
            MsgBox("PLEASE ENTER THE FOOD/DRINK.", MsgBoxStyle.Information)
            Exit Sub
        ElseIf TextBox3.Text.Trim().Length = 0 Then
            MsgBox("PLEASE ENTER THE COST/QUANTITY.", MsgBoxStyle.Information)
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
            Dim Sql As String = "INSERT INTO Menu (ID, Name, Category, Cost) VALUES ('" & xStr & "', '" & TextBox2.Text & "', '" & ComboBox1.Text & "', '" & TextBox3.Text & "')"
            Dim cmd1 As New OleDbCommand
            cmd1.Connection = sqlcon
            cmd1.CommandText = Sql

            cmd1.ExecuteNonQuery()
            cmd1.Dispose()


            MsgBox("SAVED SUCCESSFULLY.", MsgBoxStyle.Information)

            TextBox3.Clear()
            TextBox2.Clear()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
        If sqlcon IsNot Nothing Then
            If sqlcon.State = ConnectionState.Open Then
                sqlcon.Close()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If DataGridView1.CurrentRow.IsNewRow Then
            MsgBox("NO RECORD FOUND. PLEASE SELECT A VALID ROW.", MsgBoxStyle.Information)
            Exit Sub
        Else
            Try

                Dim TA As New TopShelfDataSetTableAdapters.MenuTableAdapter
                Dim TB = TA.GetDataByID(DataGridView1.SelectedRows(0).Cells(0).Value)

                If TB.Rows.Count = 0 Then
                Else
                    Dim R As TopShelfDataSet.MenuRow = TB.Rows(0)

                    Edit_Restaurant_Menu.ComboBox1.Text = R.Category
                    Edit_Restaurant_Menu.TextBox1.Text = R.Name
                    Edit_Restaurant_Menu.TextBox2.Text = R.Cost

                    Edit_Restaurant_Menu.TheEmpireButton1.Tag = R
                    Edit_Restaurant_Menu.Show()
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If DataGridView1.CurrentRow.IsNewRow Then
            MsgBox("NO RECORD FOUND. PLEASE SELECT A VALID ROW.", MsgBoxStyle.Information)
            Exit Sub
        Else
            Try

                Dim TA As New TopShelfDataSetTableAdapters.MenuTableAdapter
                Dim TB = TA.GetDataByID(DataGridView1.SelectedRows(0).Cells(0).Value)

                If TB.Rows.Count = 0 Then
                Else
                    Dim R As TopShelfDataSet.MenuRow = TB.Rows(0)

                    Edit_Restaurant_Menu.ComboBox1.Text = R.Category
                    Edit_Restaurant_Menu.TextBox1.Text = R.Name
                    Edit_Restaurant_Menu.TextBox2.Text = R.Cost

                    Edit_Restaurant_Menu.TheEmpireButton1.Tag = R
                    Edit_Restaurant_Menu.Show()
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            End Try
        End If
    End Sub
End Class