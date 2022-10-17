Public Class MainWindow
    Private Sub MainWindow_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Timer2.Start()
        Timer2.Interval = 60000
    End Sub

    Private Sub MainWindow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub MainWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        Timer2.Interval = 6000000
    End Sub

    Private Sub SalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesToolStripMenuItem.Click
        Timer2.Stop()
        Timer2.Start()
        Try
            Dim TA As New TopShelfDataSetTableAdapters.LogInTableAdapter
            Dim TB = TA.GetDataByUserName(Label1.Text.ToUpper)

            Dim R As TopShelfDataSet.LogInRow = TB.Rows(0)
            If R.Authorisation = "ADMIN" Then

                Sales.MdiParent = Me
                Sales.Show()
                Label1.Visible = False
                Label2.Visible = False
                Panel1.Visible = False
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                TheEmpireButton1.Visible = False
                TheEmpireButton2.Visible = False

            ElseIf R.Authorisation = "PREMIUM USER" Then

                Dim TAD As New TopShelfDataSetTableAdapters.SecuritySettingsTableAdapter
                Dim TBD = TAD.GetDataByModuleandUserType("RESTAURANT SALES", "PREMIUM USER")

                Dim RD As TopShelfDataSet.SecuritySettingsRow = TBD.Rows(0)

                If RD.Access = "TRUE" Then
                    Dim TWD As New TopShelfDataSetTableAdapters.SecuritySettingsTableAdapter
                    Dim TGD = TWD.GetDataByModuleandUserType("RESTAURANT SALES RECORDS", "PREMIUM USER")

                    Dim RW As TopShelfDataSet.SecuritySettingsRow = TGD.Rows(0)

                    If RW.Access = "TRUE" Then
                        Dim HWD As New TopShelfDataSetTableAdapters.SecuritySettingsTableAdapter
                        Dim KGD = HWD.GetDataByModuleandUserType("DRAWER EXPENDITURE", "PREMIUM USER")

                        Dim RKW As TopShelfDataSet.SecuritySettingsRow = KGD.Rows(0)

                        If RKW.Access = "TRUE" Then
                            Sales.MdiParent = Me
                            Sales.Show()
                            Label1.Visible = False
                            Label2.Visible = False
                            Panel1.Visible = False
                            PictureBox1.Visible = False
                            PictureBox2.Visible = False
                            PictureBox3.Visible = False
                            PictureBox4.Visible = False
                            TheEmpireButton1.Visible = False
                            TheEmpireButton2.Visible = False
                        Else
                            Sales.ElegantThemeTabControlVertical1.TabPages.Remove(Sales.TabPage5)
                            Sales.MdiParent = Me
                            Sales.Show()
                            Label1.Visible = False
                            Label2.Visible = False
                            Panel1.Visible = False
                            PictureBox1.Visible = False
                            PictureBox2.Visible = False
                            PictureBox3.Visible = False
                            PictureBox4.Visible = False
                            TheEmpireButton1.Visible = False
                            TheEmpireButton2.Visible = False
                        End If

                    Else
                        Dim HWD As New TopShelfDataSetTableAdapters.SecuritySettingsTableAdapter
                        Dim KGD = HWD.GetDataByModuleandUserType("DRAWER EXPENDITURE", "PREMIUM USER")

                        Dim RKW As TopShelfDataSet.SecuritySettingsRow = KGD.Rows(0)

                        If RKW.Access = "TRUE" Then
                            Sales.ElegantThemeTabControlVertical1.TabPages.Remove(Sales.TabPage3)
                            Sales.MdiParent = Me
                            Sales.Show()
                            Label1.Visible = False
                            Label2.Visible = False
                            Panel1.Visible = False
                            PictureBox1.Visible = False
                            PictureBox2.Visible = False
                            PictureBox3.Visible = False
                            PictureBox4.Visible = False
                            TheEmpireButton1.Visible = False
                            TheEmpireButton2.Visible = False
                        Else
                            Sales.ElegantThemeTabControlVertical1.TabPages.Remove(Sales.TabPage3)
                            Sales.ElegantThemeTabControlVertical1.TabPages.Remove(Sales.TabPage5)
                            Sales.MdiParent = Me
                            Sales.Show()
                            Label1.Visible = False
                            Label2.Visible = False
                            Panel1.Visible = False
                            PictureBox1.Visible = False
                            PictureBox2.Visible = False
                            PictureBox3.Visible = False
                            PictureBox4.Visible = False
                            TheEmpireButton1.Visible = False
                            TheEmpireButton2.Visible = False
                        End If
                    End If

                Else
                    Dim TWD As New TopShelfDataSetTableAdapters.SecuritySettingsTableAdapter
                    Dim TGD = TWD.GetDataByModuleandUserType("RESTAURANT SALES RECORDS", "PREMIUM USER")

                    Dim RW As TopShelfDataSet.SecuritySettingsRow = TGD.Rows(0)

                    If RW.Access = "TRUE" Then

                        Dim HWD As New TopShelfDataSetTableAdapters.SecuritySettingsTableAdapter
                        Dim KGD = HWD.GetDataByModuleandUserType("DRAWER EXPENDITURE", "PREMIUM USER")

                        Dim RKW As TopShelfDataSet.SecuritySettingsRow = KGD.Rows(0)

                        If RKW.Access = "TRUE" Then
                            Sales.ElegantThemeTabControlVertical1.TabPages.Remove(Sales.TabPage1)
                            Sales.MdiParent = Me
                            Sales.Show()
                            Label1.Visible = False
                            Label2.Visible = False
                            Panel1.Visible = False
                            PictureBox1.Visible = False
                            PictureBox2.Visible = False
                            PictureBox3.Visible = False
                            PictureBox4.Visible = False
                            TheEmpireButton1.Visible = False
                            TheEmpireButton2.Visible = False
                        Else
                            Sales.ElegantThemeTabControlVertical1.TabPages.Remove(Sales.TabPage1)
                            Sales.ElegantThemeTabControlVertical1.TabPages.Remove(Sales.TabPage5)
                            Sales.MdiParent = Me
                            Sales.Show()
                            Label1.Visible = False
                            Label2.Visible = False
                            Panel1.Visible = False
                            PictureBox1.Visible = False
                            PictureBox2.Visible = False
                            PictureBox3.Visible = False
                            PictureBox4.Visible = False
                            TheEmpireButton1.Visible = False
                            TheEmpireButton2.Visible = False
                        End If
                    Else

                        Dim HWD As New TopShelfDataSetTableAdapters.SecuritySettingsTableAdapter
                        Dim KGD = HWD.GetDataByModuleandUserType("DRAWER EXPENDITURE", "PREMIUM USER")

                        Dim RKW As TopShelfDataSet.SecuritySettingsRow = KGD.Rows(0)

                        If RKW.Access = "TRUE" Then
                            Sales.ElegantThemeTabControlVertical1.TabPages.Remove(Sales.TabPage3)
                            Sales.ElegantThemeTabControlVertical1.TabPages.Remove(Sales.TabPage1)
                            Sales.MdiParent = Me
                            Sales.Show()
                            Label1.Visible = False
                            Label2.Visible = False
                            Panel1.Visible = False
                            PictureBox1.Visible = False
                            PictureBox2.Visible = False
                            PictureBox3.Visible = False
                            PictureBox4.Visible = False
                            TheEmpireButton1.Visible = False
                            TheEmpireButton2.Visible = False
                        Else
                            MessageBox.Show("ACCESS DENIED!!", "UN-AUTHORISED USER.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    End If


                End If

            ElseIf R.Authorisation = "STANDARD USER" Then

                Dim TAD As New TopShelfDataSetTableAdapters.SecuritySettingsTableAdapter
                Dim TBD = TAD.GetDataByModuleandUserType("RESTAURANT SALES", "STANDARD USER")

                Dim RD As TopShelfDataSet.SecuritySettingsRow = TBD.Rows(0)

                If RD.Access = "TRUE" Then
                    Dim TWD As New TopShelfDataSetTableAdapters.SecuritySettingsTableAdapter
                    Dim TGD = TWD.GetDataByModuleandUserType("RESTAURANT SALES RECORDS", "STANDARD USER")

                    Dim RW As TopShelfDataSet.SecuritySettingsRow = TGD.Rows(0)

                    If RW.Access = "TRUE" Then
                        Dim HWD As New TopShelfDataSetTableAdapters.SecuritySettingsTableAdapter
                        Dim KGD = HWD.GetDataByModuleandUserType("DRAWER EXPENDITURE", "STANDARD USER")

                        Dim RKW As TopShelfDataSet.SecuritySettingsRow = KGD.Rows(0)

                        If RKW.Access = "TRUE" Then
                            Sales.MdiParent = Me
                            Sales.Show()
                            Label1.Visible = False
                            Label2.Visible = False
                            Panel1.Visible = False
                            PictureBox1.Visible = False
                            PictureBox2.Visible = False
                            PictureBox3.Visible = False
                            PictureBox4.Visible = False
                            TheEmpireButton1.Visible = False
                            TheEmpireButton2.Visible = False
                        Else
                            Sales.ElegantThemeTabControlVertical1.TabPages.Remove(Sales.TabPage5)
                            Sales.MdiParent = Me
                            Sales.Show()
                            Label1.Visible = False
                            Label2.Visible = False
                            Panel1.Visible = False
                            PictureBox1.Visible = False
                            PictureBox2.Visible = False
                            PictureBox3.Visible = False
                            PictureBox4.Visible = False
                            TheEmpireButton1.Visible = False
                            TheEmpireButton2.Visible = False
                        End If

                    Else
                        Dim HWD As New TopShelfDataSetTableAdapters.SecuritySettingsTableAdapter
                        Dim KGD = HWD.GetDataByModuleandUserType("DRAWER EXPENDITURE", "STANDARD USER")

                        Dim RKW As TopShelfDataSet.SecuritySettingsRow = KGD.Rows(0)

                        If RKW.Access = "TRUE" Then
                            Sales.ElegantThemeTabControlVertical1.TabPages.Remove(Sales.TabPage3)
                            Sales.MdiParent = Me
                            Sales.Show()
                            Label1.Visible = False
                            Label2.Visible = False
                            Panel1.Visible = False
                            PictureBox1.Visible = False
                            PictureBox2.Visible = False
                            PictureBox3.Visible = False
                            PictureBox4.Visible = False
                            TheEmpireButton1.Visible = False
                            TheEmpireButton2.Visible = False
                        Else
                            Sales.ElegantThemeTabControlVertical1.TabPages.Remove(Sales.TabPage3)
                            Sales.ElegantThemeTabControlVertical1.TabPages.Remove(Sales.TabPage5)
                            Sales.MdiParent = Me
                            Sales.Show()
                            Label1.Visible = False
                            Label2.Visible = False
                            Panel1.Visible = False
                            PictureBox1.Visible = False
                            PictureBox2.Visible = False
                            PictureBox3.Visible = False
                            PictureBox4.Visible = False
                            TheEmpireButton1.Visible = False
                            TheEmpireButton2.Visible = False
                        End If
                    End If

                Else
                    Dim TWD As New TopShelfDataSetTableAdapters.SecuritySettingsTableAdapter
                    Dim TGD = TWD.GetDataByModuleandUserType("RESTAURANT SALES RECORDS", "STANDARD USER")

                    Dim RW As TopShelfDataSet.SecuritySettingsRow = TGD.Rows(0)

                    If RW.Access = "TRUE" Then

                        Dim HWD As New TopShelfDataSetTableAdapters.SecuritySettingsTableAdapter
                        Dim KGD = HWD.GetDataByModuleandUserType("DRAWER EXPENDITURE", "STANDARD USER")

                        Dim RKW As TopShelfDataSet.SecuritySettingsRow = KGD.Rows(0)

                        If RKW.Access = "TRUE" Then
                            Sales.ElegantThemeTabControlVertical1.TabPages.Remove(Sales.TabPage1)
                            Sales.MdiParent = Me
                            Sales.Show()
                            Label1.Visible = False
                            Label2.Visible = False
                            Panel1.Visible = False
                            PictureBox1.Visible = False
                            PictureBox2.Visible = False
                            PictureBox3.Visible = False
                            PictureBox4.Visible = False
                            TheEmpireButton1.Visible = False
                            TheEmpireButton2.Visible = False
                        Else
                            Sales.ElegantThemeTabControlVertical1.TabPages.Remove(Sales.TabPage1)
                            Sales.ElegantThemeTabControlVertical1.TabPages.Remove(Sales.TabPage5)
                            Sales.MdiParent = Me
                            Sales.Show()
                            Label1.Visible = False
                            Label2.Visible = False
                            Panel1.Visible = False
                            PictureBox1.Visible = False
                            PictureBox2.Visible = False
                            PictureBox3.Visible = False
                            PictureBox4.Visible = False
                            TheEmpireButton1.Visible = False
                            TheEmpireButton2.Visible = False
                        End If
                    Else

                        Dim HWD As New TopShelfDataSetTableAdapters.SecuritySettingsTableAdapter
                        Dim KGD = HWD.GetDataByModuleandUserType("DRAWER EXPENDITURE", "STANDARD USER")

                        Dim RKW As TopShelfDataSet.SecuritySettingsRow = KGD.Rows(0)

                        If RKW.Access = "TRUE" Then
                            Sales.ElegantThemeTabControlVertical1.TabPages.Remove(Sales.TabPage3)
                            Sales.ElegantThemeTabControlVertical1.TabPages.Remove(Sales.TabPage1)
                            Sales.MdiParent = Me
                            Sales.Show()
                            Label1.Visible = False
                            Label2.Visible = False
                            Panel1.Visible = False
                            PictureBox1.Visible = False
                            PictureBox2.Visible = False
                            PictureBox3.Visible = False
                            PictureBox4.Visible = False
                            TheEmpireButton1.Visible = False
                            TheEmpireButton2.Visible = False
                        Else
                            MessageBox.Show("ACCESS DENIED!!", "UN-AUTHORISED USER.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    End If

                End If
            Else
                MessageBox.Show("ACCESS DENIED!!", "UN-AUTHORISED USER.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = DateTime.Now.ToString("dd/MMMM/yyyy, H:mm:ss tt")
    End Sub

    Private Sub MenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuToolStripMenuItem.Click
        Timer2.Stop()
        Timer2.Start()
        Try
            Dim TA As New TopShelfDataSetTableAdapters.LogInTableAdapter
            Dim TB = TA.GetDataByUserName(Label1.Text.ToUpper)

            Dim R As TopShelfDataSet.LogInRow = TB.Rows(0)
            If R.Authorisation = "ADMIN" Then

                Add_To_Menu.MdiParent = Me
                Add_To_Menu.Show()
                Label1.Visible = False
                Label2.Visible = False
                Panel1.Visible = False
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                TheEmpireButton1.Visible = False
                TheEmpireButton2.Visible = False

            ElseIf R.Authorisation = "PREMIUM USER" Then
                Dim HWD As New TopShelfDataSetTableAdapters.SecuritySettingsTableAdapter
                Dim KGD = HWD.GetDataByModuleandUserType("MENU", "PREMIUM USER")

                Dim RKW As TopShelfDataSet.SecuritySettingsRow = KGD.Rows(0)

                If RKW.Access = "TRUE" Then
                    Add_To_Menu.MdiParent = Me
                    Add_To_Menu.Show()
                    Label1.Visible = False
                    Label2.Visible = False
                    Panel1.Visible = False
                    PictureBox1.Visible = False
                    PictureBox2.Visible = False
                    PictureBox3.Visible = False
                    PictureBox4.Visible = False
                    TheEmpireButton1.Visible = False
                    TheEmpireButton2.Visible = False
                Else
                    MsgBox("ACCESS DENIED. UN-AUTHORISED USER", MsgBoxStyle.Information)
                    Exit Sub
                End If
            ElseIf R.Authorisation = "STANDARD USER" Then
                Dim HWD As New TopShelfDataSetTableAdapters.SecuritySettingsTableAdapter
                Dim KGD = HWD.GetDataByModuleandUserType("MENU", "STANDARD USER")

                Dim RKW As TopShelfDataSet.SecuritySettingsRow = KGD.Rows(0)

                If RKW.Access = "TRUE" Then
                    Add_To_Menu.MdiParent = Me
                    Add_To_Menu.Show()
                    Label1.Visible = False
                    Label2.Visible = False
                    Panel1.Visible = False
                    PictureBox1.Visible = False
                    PictureBox2.Visible = False
                    PictureBox3.Visible = False
                    PictureBox4.Visible = False
                    TheEmpireButton1.Visible = False
                    TheEmpireButton2.Visible = False
                Else
                    MsgBox("ACCESS DENIED. UN-AUTHORISED USER", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Else
                MessageBox.Show("ACCESS DENIED!!", "UN-AUTHORISED USER.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub UserAccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAccountsToolStripMenuItem.Click
        Timer2.Stop()
        Timer2.Start()
        Try
            Dim TA As New TopShelfDataSetTableAdapters.LogInTableAdapter
            Dim TB = TA.GetDataByUserName(Label1.Text.ToUpper)

            Dim R As TopShelfDataSet.LogInRow = TB.Rows(0)
            If R.Authorisation = "ADMIN" Then

                User_Accounts.MdiParent = Me
                User_Accounts.Show()
                Label1.Visible = False
                Label2.Visible = False
                Panel1.Visible = False
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                TheEmpireButton1.Visible = False
                TheEmpireButton2.Visible = False

            ElseIf R.Authorisation = "PREMIUM USER" Then
                Dim HWD As New TopShelfDataSetTableAdapters.SecuritySettingsTableAdapter
                Dim KGD = HWD.GetDataByModuleandUserType("SIGN UP", "PREMIUM USER")

                Dim RKW As TopShelfDataSet.SecuritySettingsRow = KGD.Rows(0)

                If RKW.Access = "TRUE" Then
                    User_Accounts.MdiParent = Me
                    User_Accounts.Show()
                    Label1.Visible = False
                    Label2.Visible = False
                    Panel1.Visible = False
                    PictureBox1.Visible = False
                    PictureBox2.Visible = False
                    PictureBox3.Visible = False
                    PictureBox4.Visible = False
                    TheEmpireButton1.Visible = False
                    TheEmpireButton2.Visible = False
                Else
                    MsgBox("ACCESS DENIED. UN-AUTHORISED USER", MsgBoxStyle.Information)
                    Exit Sub
                End If
            ElseIf R.Authorisation = "STANDARD USER" Then
                Dim HWD As New TopShelfDataSetTableAdapters.SecuritySettingsTableAdapter
                Dim KGD = HWD.GetDataByModuleandUserType("SIGN UP", "STANDARD USER")

                Dim RKW As TopShelfDataSet.SecuritySettingsRow = KGD.Rows(0)

                If RKW.Access = "TRUE" Then
                    User_Accounts.MdiParent = Me
                    User_Accounts.Show()
                    Label1.Visible = False
                    Label2.Visible = False
                    Panel1.Visible = False
                    PictureBox1.Visible = False
                    PictureBox2.Visible = False
                    PictureBox3.Visible = False
                    PictureBox4.Visible = False
                    TheEmpireButton1.Visible = False
                    TheEmpireButton2.Visible = False
                Else
                    MsgBox("ACCESS DENIED. UN-AUTHORISED USER", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Else
                MessageBox.Show("ACCESS DENIED!!", "UN-AUTHORISED USER.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub TheEmpireButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton1.Click
        Timer2.Stop()
        Timer2.Start()
        Cash_Drawer.Show()
    End Sub

    Private Sub TheEmpireButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton2.Click
        Me.Hide()
        Form1.TextBox1.Clear()
        Form1.TextBox1.Focus()
        Form1.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Timer2.Stop()
        Timer2.Start()
        Panel1.Width = 181
        PictureBox1.Visible = False
        PictureBox2.Visible = True
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Timer2.Stop()
        Timer2.Start()
        Panel1.Width = 59
        PictureBox2.Visible = False
        PictureBox1.Visible = True
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'Dim currentsecond = TimeOfDay.Second.ToString
        'Me.Text = currentsecond
        'If currentsecond = 59 Then

        Me.Hide()
        Form1.TextBox1.Clear()
        Form1.TextBox1.Focus()
        Form1.Show()
        'Else

        'End If
        'Dim CurrentDate As Date = Date.Now
        'Dim Interval As Integer = -3
        'Dim result As Date = CurrentDate.AddDays(Interval)
        'Dim result As DateInterval = DateInterval.Second(

    End Sub
End Class