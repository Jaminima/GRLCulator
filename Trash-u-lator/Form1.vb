Public Class Form1
    Private Sub Btn_Run_Click(sender As Object, e As EventArgs) Handles Btn_Run.Click
        Txt_PC.Text = CInt(Txt_PC.Text) + 1
        ProgramHandler.HandleInstruction()
    End Sub

    Private Sub MemoryGrid_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles MemoryGrid.RowsAdded
        For i = 1 To MemoryGrid.Rows.Count
            Try
                MemoryGrid.Item("Number", i - 1).Value = i
            Catch
            End Try
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        For i = 0 To 48
            MemoryGrid.Rows.Add()
        Next

    End Sub
End Class
