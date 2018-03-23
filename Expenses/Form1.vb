Public Class Form1
    Private Sub NameBox_Click(sender As Object, e As EventArgs) Handles NameBox.Click
        NameBox.Clear()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        TravelText.Clear()
        IncomeText.Clear()
        RentText.Clear()
        FoodText.Clear()
        TotalExpensesText.Clear()
        RemainingText.Clear()
        NameBox.Text = "Enter name"
    End Sub

    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        Try
            Income = IncomeText.Text
            Travel = TravelText.Text
            Rent = RentText.Text
            Food = FoodText.Text
            TotalExpensesText.Text = "£" + (Travel + Rent + Food).ToString
            RemainingText.Text = "£" + (Income - (Travel + Rent + Food)).ToString
        Catch
            Me.Show()
        End Try
    End Sub
End Class
