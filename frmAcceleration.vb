Public Class frmAcceleration

    ' Runs when the user clicks Calculate
    ' Reads distance and time from the textboxes, computes acceleration, and shows result in a msgbox
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim distance As Double
        Dim time As Double
        Dim acceleration As Double

        ' Validate data before calculating
        If Double.TryParse(txtDistance.Text, distance) AndAlso Double.TryParse(txtTime.Text, time) Then

            ' Avoid dividing by zero
            If time = 0 Then
                MessageBox.Show("Time cannot be zero.")
            Else
                ' Acceleration = (2 * Distance) / (Time ^ 2)
                acceleration = (2 * distance) / (time ^ 2)
                MessageBox.Show("Acceleration = " & acceleration.ToString("F2") & " ft/s")
            End If

        Else
            ' Invalid data output
            MessageBox.Show("Enter valid numbers for distance and time.")
        End If
    End Sub

    ' Clears textboxes
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDistance.Clear()
        txtTime.Clear()
    End Sub

    ' 
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

End Class