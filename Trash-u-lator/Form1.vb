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
        SharedCode.AddLine(48)
    End Sub

    Private Sub Tmr_Auto_Tick(sender As Object, e As EventArgs) Handles Tmr_Auto.Tick
        Try
            Tmr_Auto.Interval = Txt_Step.Text
        Catch
            Txt_Step.Text = 1000
            Tmr_Auto.Interval = Txt_Step.Text
        End Try
        ProgramHandler.HandleInstruction()
    End Sub
#Region "Buttons"
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

    Private Sub Btn_AddRows_Click(sender As Object, e As EventArgs) Handles Btn_AddRows.Click
        SharedCode.AddLine(Txt_AddRows.Text)
    End Sub

    Private Sub BtnLoadTable_Click(sender As Object, e As EventArgs) Handles BtnLoadTable.Click
        MemoryHandler.Load(InputBox("File Name:", "Load", "Default"))
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        MemoryHandler.Reset()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        MemoryHandler.Save(InputBox("File Name:", "Save", "Default"))
    End Sub
#End Region
#Region "Toolbar Managment"
    'Dropdown panels are hidden on the right of the form.
    Dim OffsetConstant = 12, OC = 12, StorePoint = New Point(1000, 1000),
        FilePanelShow = False, RunPanelShow = False, SettingsPanelShow = False

    Private Sub BTN_ShowFile_Click(sender As Object, e As EventArgs) Handles BTN_ShowFile.Click
        Panel_File.BringToFront()
        If FilePanelShow = False Then
            Panel_File.Location = New Point(BTN_ShowFile.Location.X + OC - 3, BTN_ShowFile.Location.Y + OC + 40)
            FilePanelShow = True
        Else
            FilePanelShow = False
            Panel_File.Location = StorePoint
        End If
    End Sub

    Private Sub BTN_ShowRun_Click(sender As Object, e As EventArgs) Handles BTN_ShowRun.Click
        Panel_Run.BringToFront()
        If RunPanelShow = False Then
            Panel_Run.Location = New Point(BTN_ShowRun.Location.X + OC - 3, BTN_ShowRun.Location.Y + OC + 40)
            RunPanelShow = True
        Else
            RunPanelShow = False
            Panel_Run.Location = StorePoint
        End If
    End Sub

    Private Sub BTN_ShowsSettings_Click(sender As Object, e As EventArgs) Handles BTN_ShowsSettings.Click
        Panel_Settings.BringToFront()
        If SettingsPanelShow = False Then
            Panel_Settings.Location = New Point(BTN_ShowsSettings.Location.X + OC - 3, BTN_ShowsSettings.Location.Y + OC + 40)
            SettingsPanelShow = True
        Else
            RunPanelShow = False
            Panel_Settings.Location = StorePoint
        End If
    End Sub
#End Region
End Class
