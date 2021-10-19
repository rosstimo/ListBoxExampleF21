Public Class ListBoxForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        ListBox1.Items.Add(TextBox1.Text)
        ComboBox1.Items.Add(TextBox1.Text)
        If ComboBox1.Items.Count = 1 Then
            ComboBox1.SelectedIndex = 0
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Me.Text = $"The list box selected index is {ListBox1.SelectedIndex} and it contains: {ListBox1.SelectedItem}"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.Text = $"The combo box selected index is {ComboBox1.SelectedIndex} and it contains: {ComboBox1.SelectedItem}"
    End Sub
End Class
