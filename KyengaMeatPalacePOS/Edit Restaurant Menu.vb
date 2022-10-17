Imports System.Data
Imports System.Data.OleDb
Public Class Edit_Restaurant_Menu

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Edit_Restaurant_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TopShelfDataSet.Menu' table. You can move, or remove it, as needed.
        Me.MenuTableAdapter.Fill(Me.TopShelfDataSet.Menu)
        'TODO: This line of code loads data into the 'TopShelfDataSet.MenuCategory' table. You can move, or remove it, as needed.
        Me.MenuCategoryTableAdapter.Fill(Me.TopShelfDataSet.MenuCategory)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
        If TextBox1.Text.Contains("'") Then
            MsgBox("APOSTROPHE KEY IS DISABLED. PLEASE USE THE SLASH (/) KEY FOR THE FOOD/DRINK NAME.", MsgBoxStyle.Information)
            Exit Sub
        ElseIf TextBox1.Text.Trim().Length = 0 Then
            MsgBox("PLEASE ENTER THE FOOD/DRINK.", MsgBoxStyle.Information)
            Exit Sub
        ElseIf TextBox2.Text.Trim().Length = 0 Then
            MsgBox("PLEASE ENTER THE COST/QUANTITY.", MsgBoxStyle.Information)
            Exit Sub
        End If
        sqlcon = New OleDbConnection(strcon)
        sqlcon.Open()

        If sqlcon.State = ConnectionState.Open Then
            'get details of the item
            Dim R As TopShelfDataSet.MenuRow = TheEmpireButton1.Tag

            'create the adapter
            Dim TA As New TopShelfDataSetTableAdapters.MenuTableAdapter

            'Update the item
            MenuBindingSource.EndEdit()
            TA.UpdateByID(TextBox1.Text, ComboBox1.Text, TextBox2.Text, R.ID)

            MsgBox("Saved Successfully", MsgBoxStyle.Information)
            Add_To_Menu.MenuTableAdapter.Fill(Add_To_Menu.TopShelfDataSet.Menu)
            Me.Dispose()
        Else
            MsgBox("DATABASE CONNECTION UNSUCCESSFUL.", MsgBoxStyle.Exclamation)
        End If

        sqlcon.Close()
        sqlcon.Dispose()
        sqlcon = Nothing
    End Sub
End Class