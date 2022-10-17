Public Class Custom_Menu

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        Me.Dispose()
    End Sub

    Private Sub TheEmpireButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TheEmpireButton1.Click
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TextBox1.Text.Trim().Length = 0 Then
            MsgBox("PLEASE ENTER THE FOOD/DRINK.", MsgBoxStyle.Information)
            Exit Sub
        ElseIf TextBox3.Text.Trim().Length = 0 Then
            MsgBox("PLEASE ENTER THE PRICE/UNIT.", MsgBoxStyle.Information)
            Exit Sub
        ElseIf TextBox2.Text.Trim().Length = 0 Then
            MsgBox("PLEASE ENTER THE QUANTITY.", MsgBoxStyle.Information)
            Exit Sub
        End If
        Try
            Dim D As Integer
            Dim ItemLoc As Integer = -1
            For D = 0 To Sales.DataGridView1.Rows.Count - 1
                If TextBox1.Text = Sales.DataGridView1.Rows(D).Cells(0).Value Then
                    'Item Found
                    ItemLoc = D
                    Exit For
                End If

            Next

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

            Dim cp As Decimal = Label5.Text
            'Item not found add it to dgv
            If ItemLoc = -1 Then

                Sales.DataGridView1.Rows.Add(xStr, TextBox2.Text, TextBox1.Text, TextBox3.Text, Label5.Text, "CUSTOM")
                Sales.Label2.Text = Val(Format(Sales.Label2.Text, "General Number")) + cp
                Sales.Label2.Text = Format(Sales.Label2.Text, "standard")

            Else
                Dim UnitPrice As Decimal = Sales.DataGridView1.Rows(ItemLoc).Cells(3).Value
                Dim Qty As Long = Sales.DataGridView2.Rows(ItemLoc).Cells(1).Value
                Qty += 1
                Dim amt As Decimal = UnitPrice * Qty
                Sales.DataGridView1.Rows(ItemLoc).Cells(1).Value = Qty
                Sales.DataGridView1.Rows(ItemLoc).Cells(4).Value = amt

                Sales.Label2.Text = Val(Format(Sales.Label2.Text, "General Number")) + UnitPrice
                Sales.Label2.Text = Format(Sales.Label2.Text, "standard")


            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        If TextBox2.Text.Trim().Length = 0 Then
            MsgBox("PLEASE ENTER THE QUANTITY.", MsgBoxStyle.Information)
            Exit Sub
        ElseIf TextBox3.Text.Trim().Length = 0 Then
            Label5.Text = 0
            Exit Sub
        End If

        Dim quantity As Integer = TextBox2.Text
        Dim price As Decimal = TextBox3.Text
        Dim tc As Decimal = price * quantity
        Label5.Text = tc
    End Sub

    Private Sub Custom_Menu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainWindow.Timer2.Stop()
        MainWindow.Timer2.Start()
        Me.Dispose()
    End Sub
End Class