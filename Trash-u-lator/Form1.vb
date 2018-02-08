Public Class Form1

    Public Run As Boolean = False

    Private Sub Btn_Run_Click(sender As Object, e As EventArgs) Handles Btn_Run.Click
        ProgramHandler.HandleInstruction()
    End Sub

    Private Sub MemoryGrid_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles MemoryGrid.RowsAdded
        For i = 1 To MemoryGrid.Rows.Count
            Try
                MemoryGrid.Item("Line", i - 1).Value = i
            Catch
            End Try
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'SharedCode.AddLine(48)
    End Sub

    Private Sub Btn_Auto_Click(sender As Object, e As EventArgs) Handles Btn_Auto.Click
        If Run = False Then
            Run = True
            Tmr_Auto.Start()
            Btn_Auto.BackColor = Color.Green
        Else
            Run = False
            Tmr_Auto.Stop()
            Btn_Auto.BackColor = Color.Red
        End If
    End Sub

    Private Sub Tmr_Auto_Tick(sender As Object, e As EventArgs) Handles Tmr_Auto.Tick
        Tmr_Auto.Interval = Txt_Step.Text
        ProgramHandler.HandleInstruction()
    End Sub

    Private Sub Btn_AddRows_Click(sender As Object, e As EventArgs) Handles Btn_AddRows.Click
        SharedCode.AddLine(Txt_AddRows.Text)
    End Sub

    Private Sub BtnLoadTable_Click(sender As Object, e As EventArgs) Handles BtnLoadTable.Click
        MemoryHandler.Load(InputBox("File Name:", "Load", "Default"))
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        MemoryHandler.Save(InputBox("File Name:", "Save", "Default"))
    End Sub
End Class
