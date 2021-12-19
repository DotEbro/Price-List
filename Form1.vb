Public Class Form1

    Dim Total As Double = 0.00
    Dim Average As Double = 0.00
    Dim count As Integer = 0
    Dim input As String
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsNumeric(TextBox1.Text) Then
                ListBox1.Items.Add(TextBox1.Text)
                TextBox1.Clear()
                count = count + 1
            Else
                MessageBox.Show("Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            TextBox1.Clear()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For a As Integer = 0 To count - 1
            Total = Total + ListBox1.Items(a)
        Next

        Average = Total / count
        Math.Round(Total, 2)
        Math.Round(Average, 2)
        TextBox3.Text = Total
        TextBox2.Text = Average
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Total = 0
        Average = 0
        count = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


End Class
