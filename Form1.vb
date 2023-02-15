Public Class frmBurger
    Private Sub lblHeading_Click(sender As Object, e As EventArgs) Handles lblHeading.Click

    End Sub

    Private Sub lblInstructions_Click(sender As Object, e As EventArgs) Handles lblInstructions.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        picPrime.Visible = True
        picVeggie.Visible = False
        btnSelectMeal.Enabled = True
    End Sub

    Private Sub picPrime_Click(sender As Object, e As EventArgs) Handles picPrime.Click

    End Sub

    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        picVeggie.Visible = True
        picPrime.Visible = False
        btnSelectMeal.Enabled = True
    End Sub

    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
        btnVeggie.Enabled = False
        btnPrime.Enabled = False
        btnExit.Enabled = True
        btnSelectMeal.Enabled = False
        lblConfirmation.Visible = True
        lblInstructions.Visible = False
    End Sub
End Class
