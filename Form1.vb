Public Class Form1
    Private Sub BKeluar_Click(sender As Object, e As EventArgs) Handles BKeluar.Click
        Me.Close()
        End
    End Sub

    Private Sub BClear_Click(sender As Object, e As EventArgs) Handles BClear.Click
        List1.Items.Clear()
        TxtJumlah.Text = String.Empty
        TxtTeks.Text = String.Empty
    End Sub

    Private Sub BProses_Click(sender As Object, e As EventArgs) Handles BProses.Click
        Dim text As String = TxtTeks.Text
        Dim jumlah As Integer = TxtJumlah.Text

        For i As Integer = 1 To jumlah
            List1.Items.Add(text)
        Next
    End Sub
End Class
