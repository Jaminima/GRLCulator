Public Class Form1

    Public Run As Boolean = False

    Private Sub Txt_Log_TextChanged(sender As Object, e As EventArgs) Handles Txt_Log.TextChanged
        Txt_Log.ScrollToCaret()
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
        Txt_Log.AppendText(vbNewLine & "Toggled Autorun")
    End Sub

    Private Sub Btn_Run_Click(sender As Object, e As EventArgs) Handles Btn_Run.Click
        ProgramHandler.HandleInstruction()
        'Txt_Log.AppendText(vbNewLine & "Ran A Step")
    End Sub

    Private Sub Btn_AddRows_Click(sender As Object, e As EventArgs) Handles Btn_AddRows.Click
        SharedCode.AddLine(Txt_AddRows.Text)
        Txt_Log.AppendText(vbNewLine & "Rows Added")
    End Sub

    Private Sub BtnLoadTable_Click(sender As Object, e As EventArgs) Handles BtnLoadTable.Click
        Try
            MemoryHandler.Load(InputBox("File Name:", "Load", "Default"))
            Txt_Log.AppendText(vbNewLine & "Loaded")
        Catch
            Txt_Log.AppendText(vbNewLine & "Invalid File")
        End Try
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        MemoryHandler.Reset()
        Txt_PC.Text = "1"
        For i = 0 To 9
            _GetControl(i).Text = ""
        Next
        Txt_Log.AppendText(vbNewLine & "Created New")
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        MemoryHandler.Save(InputBox("File Name:", "Save", "Default"))
        Txt_Log.AppendText(vbNewLine & "Saved")
    End Sub

    Private Sub BTN_ClearLog_Click(sender As Object, e As EventArgs) Handles BTN_ClearLog.Click
        Txt_Log.Text = ""
        Txt_Log.AppendText(vbNewLine & "Cleared Log")
    End Sub

    Private Sub BTN_ClearReg_Click(sender As Object, e As EventArgs) Handles BTN_ClearReg.Click
        Txt_PC.Text = "1"
        For i = 0 To 9
            _GetControl("Txt_R" & i).Text = ""
        Next
        Txt_Log.AppendText(vbNewLine & "Cleared Registers")
    End Sub

#End Region
#Region "Toolbar Managment"
    'Dropdown panels are hidden on the right of the form.
    Dim OffsetConstant = 12, OC = 12, StorePoint = New Point(1000, 1000),
        FilePanelShow = False, RunPanelShow = False, SettingsPanelShow = False, ResetPanelShow = False

    Private Sub BTN_Reset_Memory_Click(sender As Object, e As EventArgs) Handles BTN_Reset_Memory.Click
        Panel_Reset.BringToFront()
        If ResetPanelShow = False Then
            Panel_Reset.Location = New Point(BTN_Reset_Memory.Location.X + OC, BTN_Reset_Memory.Location.Y + OC + 35)
            ResetPanelShow = True
        Else
            ResetPanelShow = False
            Panel_Reset.Location = StorePoint
        End If
    End Sub

    Private Sub BTN_ShowFile_Click(sender As Object, e As EventArgs) Handles BTN_ShowFile.Click
        Panel_File.BringToFront()
        If FilePanelShow = False Then
            Panel_File.Location = New Point(BTN_ShowFile.Location.X + OC - 3, BTN_ShowFile.Location.Y + OC + 35)
            FilePanelShow = True
        Else
            FilePanelShow = False
            Panel_File.Location = StorePoint
        End If
    End Sub

    Private Sub BTN_ShowRun_Click(sender As Object, e As EventArgs) Handles BTN_ShowRun.Click
        Panel_Run.BringToFront()
        If RunPanelShow = False Then
            Panel_Run.Location = New Point(BTN_ShowRun.Location.X + OC, BTN_ShowRun.Location.Y + OC + 35)
            RunPanelShow = True
        Else
            RunPanelShow = False
            Panel_Run.Location = StorePoint
        End If
    End Sub

    Private Sub BTN_ShowsSettings_Click(sender As Object, e As EventArgs) Handles BTN_ShowsSettings.Click
        Panel_Settings.BringToFront()
        If SettingsPanelShow = False Then
            Panel_Settings.Location = New Point(BTN_ShowsSettings.Location.X + OC, BTN_ShowsSettings.Location.Y + OC + 35)
            SettingsPanelShow = True
        Else
            SettingsPanelShow = False
            Panel_Settings.Location = StorePoint
        End If
    End Sub


#End Region
End Class
