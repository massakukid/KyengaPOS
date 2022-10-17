Imports System.Data
Imports System.Data.OleDb
Public Class User_Accounts

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

    Private Sub User_Accounts_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub User_Accounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TopShelfDataSet.LogIn' table. You can move, or remove it, as needed.
        Me.LogInTableAdapter.Fill(Me.TopShelfDataSet.LogIn)
        Try
            Dim TA As New TopShelfDataSetTableAdapters.LogInTableAdapter
            Dim TB = TA.GetDataByUserName(MainWindow.Label1.Text.ToUpper)

            If TB.Rows.Count = 0 Then
            Else
                Dim R As TopShelfDataSet.LogInRow = TB.Rows(0)
                TextBox4.Text = R.UserName
                TextBox3.Text = R.PassWord
                TheEmpireButton2.Tag = R
            End If

            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub TheEmpireButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton1.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        Try
            sqlcon = New OleDbConnection(strcon)
            sqlcon.Open()

            If sqlcon.State = ConnectionState.Open Then
                cmd.CommandType = System.Data.CommandType.Text
                cmd.CommandText = "INSERT INTO LogIn (UserName, [PassWord], Authorisation) VALUES (?, ?, ?)"

                cmd = New OleDbCommand(cmd.CommandText, sqlcon)
                cmd.Parameters.Add("@UserName", OleDbType.Char).Value = TextBox1.Text
                cmd.Parameters.Add("@[PassWord]", OleDbType.Char).Value = TextBox2.Text
                cmd.Parameters.Add("@Authorisation", OleDbType.Char).Value = ComboBox1.Text

                cmd.ExecuteNonQuery()

                MsgBox("Saved SuccessFully", MsgBoxStyle.Information)

                TextBox1.Clear()
                TextBox2.Clear()
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

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If RadioButton1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
            RadioButton1.ForeColor = Color.Red
            RadioButton2.ForeColor = Color.White
            RadioButton2.Checked = False
        ElseIf RadioButton2.Checked = True Then
            TextBox2.UseSystemPasswordChar = True
            RadioButton2.ForeColor = Color.Red
            RadioButton1.ForeColor = Color.White
            RadioButton1.Checked = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If RadioButton1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
            RadioButton1.ForeColor = Color.Red
            RadioButton2.ForeColor = Color.White
            RadioButton2.Checked = False
        ElseIf RadioButton2.Checked = True Then
            TextBox2.UseSystemPasswordChar = True
            RadioButton2.ForeColor = Color.Red
            RadioButton1.ForeColor = Color.White
            RadioButton1.Checked = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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
        Try

            'Validate new Password
            If TextBox5.Text = "" Then
                MsgBox("PLEASE ENTER THE NEW PASSWORD", MsgBoxStyle.Critical)
                TextBox5.Focus()
                Exit Sub
            End If
            If TextBox5.Text <> TextBox6.Text Then
                MsgBox("The Password does not match its confirmation", MsgBoxStyle.OkOnly)
                TextBox6.Focus()
                Exit Sub
            End If

            'create the adapter
            Dim TA As New TopShelfDataSetTableAdapters.LogInTableAdapter

            'Update the item
            LogInBindingSource.EndEdit()
            TA.UpdatePassword(TextBox5.Text, TextBox4.Text)

            MsgBox("Password Changed", MsgBoxStyle.Information)
            TextBox5.Clear()
            TextBox6.Clear()
            Try
                Dim TAQ As New TopShelfDataSetTableAdapters.LogInTableAdapter
                Dim TBQ = TAQ.GetDataByUserName(MainWindow.Label1.Text.ToUpper)

                If TBQ.Rows.Count = 0 Then
                Else
                    Dim RQ As TopShelfDataSet.LogInRow = TBQ.Rows(0)
                    TextBox4.Text = RQ.UserName
                    TextBox3.Text = RQ.PassWord

                End If


            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            End Try
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If RadioButton4.Checked = True Then
            TextBox3.UseSystemPasswordChar = False
            TextBox5.UseSystemPasswordChar = False
            TextBox6.UseSystemPasswordChar = False
            RadioButton4.ForeColor = Color.Red
            RadioButton3.ForeColor = Color.White
            RadioButton3.Checked = False
        ElseIf RadioButton3.Checked = True Then
            TextBox3.UseSystemPasswordChar = True
            TextBox5.UseSystemPasswordChar = True
            TextBox6.UseSystemPasswordChar = True
            RadioButton3.ForeColor = Color.Red
            RadioButton4.ForeColor = Color.White
            RadioButton4.Checked = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If RadioButton4.Checked = True Then
            TextBox3.UseSystemPasswordChar = False
            TextBox5.UseSystemPasswordChar = False
            TextBox6.UseSystemPasswordChar = False
            RadioButton4.ForeColor = Color.Red
            RadioButton3.ForeColor = Color.White
            RadioButton3.Checked = False
        ElseIf RadioButton3.Checked = True Then
            TextBox3.UseSystemPasswordChar = True
            TextBox5.UseSystemPasswordChar = True
            TextBox6.UseSystemPasswordChar = True
            RadioButton3.ForeColor = Color.Red
            RadioButton4.ForeColor = Color.White
            RadioButton4.Checked = False
        End If
    End Sub

End Class