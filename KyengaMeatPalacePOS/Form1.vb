Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration

Public Class Form1
    Private Connection As OleDbConnection
    Dim sql As String

    Private Sub TheEmpireButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton1.Click
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "1"
        Else
            TextBox1.Text = TextBox1.Text + "1"
        End If
    End Sub

    Private Sub TheEmpireButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton2.Click
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "2"
        Else
            TextBox1.Text = TextBox1.Text + "2"
        End If
    End Sub

    Private Sub TheEmpireButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton3.Click
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "3"
        Else
            TextBox1.Text = TextBox1.Text + "3"
        End If
    End Sub

    Private Sub TheEmpireButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton6.Click
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "4"
        Else
            TextBox1.Text = TextBox1.Text + "4"
        End If
    End Sub

    Private Sub TheEmpireButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton5.Click
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "5"
        Else
            TextBox1.Text = TextBox1.Text + "5"
        End If
    End Sub

    Private Sub TheEmpireButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton4.Click
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "6"
        Else
            TextBox1.Text = TextBox1.Text + "6"
        End If
    End Sub

    Private Sub TheEmpireButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton9.Click
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "7"
        Else
            TextBox1.Text = TextBox1.Text + "7"
        End If
    End Sub

    Private Sub TheEmpireButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton8.Click
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "8"
        Else
            TextBox1.Text = TextBox1.Text + "8"
        End If
    End Sub

    Private Sub TheEmpireButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton7.Click
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "9"
        Else
            TextBox1.Text = TextBox1.Text + "9"
        End If
    End Sub

    Private Sub TheEmpireButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton11.Click
        TextBox1.Clear()
    End Sub

    Private Sub TheEmpireButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton10.Click
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text = TextBox1.Text + "0"
        End If
    End Sub

    Private Sub TheEmpireButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton12.Click
        Try

            If (TextBox1.Text = "") Then
                MsgBox("PLEASE ENTER THE PASSWORD.", MsgBoxStyle.Exclamation)
            Else

                Dim strPass = TextBox1.Text

                Connection = New OleDbConnection(strcon)
                Connection.Open()
                If Connection.State = ConnectionState.Open Then

                    datast.Clear()
                    sql = "SELECT UserName, [PassWord], Authorisation FROM(LogIn) WHERE ([PassWord] = '" & TextBox1.Text & "')"
                    'sql = "SELECT UserName, [PassWord], Authorisation FROM LogIn WHERE Password ='" & TextBox1.Text & "'"
                    adapter = New OleDbDataAdapter(sql, Connection)
                    adapter.Fill(datast, "LogIn")

                    If datast.Tables("LogIn").Rows.Count <> 0 Then
                        Dim TA As New TopShelfDataSetTableAdapters.LogInTableAdapter
                        Dim TB = TA.GetDataBypassword(TextBox1.Text)

                        Dim R As TopShelfDataSet.LogInRow = TB.Rows(0)

                        Dim strName = R.UserName
                        'MsgBox("Hello! " + strName + vbNewLine + "Login Successful", MsgBoxStyle.OkOnly, "Welcome " + strName)
                        MainWindow.Show()
                        MainWindow.WindowState = FormWindowState.Maximized
                        MainWindow.Label1.Text = strName
                        Me.Hide()
                    Else
                        MaximizeBox = False
                        MinimizeBox = False
                        MsgBox("THE PASSWORD ENTERED IS NOT VALID." + vbNewLine + "PLEASE TRY AGAIN.", MsgBoxStyle.Exclamation, "INVALID PASSWORD.")
                        TextBox1.Clear()
                        TextBox1.Focus()
                    End If
                Else
                    MsgBox("DATABASE CONNECTION FAILED", MsgBoxStyle.Information)
                    Exit Sub
                End If
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try

                If (TextBox1.Text = "") Then
                    MsgBox("PLEASE ENTER THE PASSWORD.", MsgBoxStyle.Exclamation)
                Else

                    Dim strPass = TextBox1.Text

                    Connection = New OleDbConnection(strcon)
                    Connection.Open()
                    If Connection.State = ConnectionState.Open Then

                        datast.Clear()
                        sql = "SELECT UserName, [PassWord], Authorisation FROM(LogIn) WHERE ([PassWord] = '" & TextBox1.Text & "')"
                        'sql = "SELECT UserName, [PassWord], Authorisation FROM LogIn WHERE Password ='" & TextBox1.Text & "'"
                        adapter = New OleDbDataAdapter(sql, Connection)
                        adapter.Fill(datast, "LogIn")

                        If datast.Tables("LogIn").Rows.Count <> 0 Then
                            Dim TA As New TopShelfDataSetTableAdapters.LogInTableAdapter
                            Dim TB = TA.GetDataByPassword(TextBox1.Text)

                            Dim R As TopShelfDataSet.LogInRow = TB.Rows(0)

                            Dim strName = R.UserName
                            'MsgBox("Hello! " + strName + vbNewLine + "Login Successful", MsgBoxStyle.OkOnly, "Welcome " + strName)
                            MainWindow.Show()
                            MainWindow.WindowState = FormWindowState.Maximized
                            MainWindow.Label1.Text = strName
                            Me.Hide()
                        Else
                            MaximizeBox = False
                            MinimizeBox = False
                            MsgBox("THE PASSWORD ENTERED IS NOT VALID." + vbNewLine + "PLEASE TRY AGAIN.", MsgBoxStyle.Exclamation, "INVALID PASSWORD.")
                            TextBox1.Clear()
                            TextBox1.Focus()
                        End If
                    Else
                        MsgBox("DATABASE CONNECTION FAILED", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            End Try
        End If
    End Sub

End Class
