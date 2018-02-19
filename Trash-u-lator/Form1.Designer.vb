<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel_Registers = New System.Windows.Forms.Panel()
        Me.Txt_PC = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txt_R9 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_R8 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_R7 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_R6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_R5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_R4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_R3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_R2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_R1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_R0 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_Settings = New System.Windows.Forms.Panel()
        Me.Txt_AddRows = New System.Windows.Forms.TextBox()
        Me.Btn_AddRows = New System.Windows.Forms.Button()
        Me.Txt_Step = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnLoadTable = New System.Windows.Forms.Button()
        Me.Btn_Auto = New System.Windows.Forms.Button()
        Me.Btn_Run = New System.Windows.Forms.Button()
        Me.MemoryGrid = New System.Windows.Forms.DataGridView()
        Me.Line = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Operand1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Operand2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Operand3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tmr_Auto = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Toolbar = New System.Windows.Forms.Panel()
        Me.BTN_Reset_Memory = New System.Windows.Forms.Button()
        Me.BTN_ShowsSettings = New System.Windows.Forms.Button()
        Me.BTN_ShowRun = New System.Windows.Forms.Button()
        Me.BTN_ShowFile = New System.Windows.Forms.Button()
        Me.Panel_File = New System.Windows.Forms.Panel()
        Me.Panel_Run = New System.Windows.Forms.Panel()
        Me.Txt_Log = New System.Windows.Forms.RichTextBox()
        Me.Panel_Reset = New System.Windows.Forms.Panel()
        Me.BTN_ClearLog = New System.Windows.Forms.Button()
        Me.BTN_ClearReg = New System.Windows.Forms.Button()
        Me.Panel_Registers.SuspendLayout()
        Me.Panel_Settings.SuspendLayout()
        CType(Me.MemoryGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Toolbar.SuspendLayout()
        Me.Panel_File.SuspendLayout()
        Me.Panel_Run.SuspendLayout()
        Me.Panel_Reset.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Registers
        '
        Me.Panel_Registers.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel_Registers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Registers.Controls.Add(Me.Txt_PC)
        Me.Panel_Registers.Controls.Add(Me.Label12)
        Me.Panel_Registers.Controls.Add(Me.Txt_R9)
        Me.Panel_Registers.Controls.Add(Me.Label10)
        Me.Panel_Registers.Controls.Add(Me.Txt_R8)
        Me.Panel_Registers.Controls.Add(Me.Label9)
        Me.Panel_Registers.Controls.Add(Me.Txt_R7)
        Me.Panel_Registers.Controls.Add(Me.Label8)
        Me.Panel_Registers.Controls.Add(Me.Txt_R6)
        Me.Panel_Registers.Controls.Add(Me.Label7)
        Me.Panel_Registers.Controls.Add(Me.Txt_R5)
        Me.Panel_Registers.Controls.Add(Me.Label6)
        Me.Panel_Registers.Controls.Add(Me.Txt_R4)
        Me.Panel_Registers.Controls.Add(Me.Label5)
        Me.Panel_Registers.Controls.Add(Me.Txt_R3)
        Me.Panel_Registers.Controls.Add(Me.Label4)
        Me.Panel_Registers.Controls.Add(Me.Txt_R2)
        Me.Panel_Registers.Controls.Add(Me.Label3)
        Me.Panel_Registers.Controls.Add(Me.Txt_R1)
        Me.Panel_Registers.Controls.Add(Me.Label2)
        Me.Panel_Registers.Controls.Add(Me.Txt_R0)
        Me.Panel_Registers.Controls.Add(Me.Label1)
        Me.Panel_Registers.Location = New System.Drawing.Point(522, 325)
        Me.Panel_Registers.Name = "Panel_Registers"
        Me.Panel_Registers.Size = New System.Drawing.Size(243, 165)
        Me.Panel_Registers.TabIndex = 0
        '
        'Txt_PC
        '
        Me.Txt_PC.Location = New System.Drawing.Point(32, 4)
        Me.Txt_PC.Name = "Txt_PC"
        Me.Txt_PC.Size = New System.Drawing.Size(83, 20)
        Me.Txt_PC.TabIndex = 23
        Me.Txt_PC.Text = "1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "PC"
        '
        'Txt_R9
        '
        Me.Txt_R9.Location = New System.Drawing.Point(32, 134)
        Me.Txt_R9.Name = "Txt_R9"
        Me.Txt_R9.Size = New System.Drawing.Size(83, 20)
        Me.Txt_R9.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "R9"
        '
        'Txt_R8
        '
        Me.Txt_R8.Location = New System.Drawing.Point(148, 108)
        Me.Txt_R8.Name = "Txt_R8"
        Me.Txt_R8.Size = New System.Drawing.Size(83, 20)
        Me.Txt_R8.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(121, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "R8"
        '
        'Txt_R7
        '
        Me.Txt_R7.Location = New System.Drawing.Point(32, 108)
        Me.Txt_R7.Name = "Txt_R7"
        Me.Txt_R7.Size = New System.Drawing.Size(83, 20)
        Me.Txt_R7.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "R7"
        '
        'Txt_R6
        '
        Me.Txt_R6.Location = New System.Drawing.Point(148, 82)
        Me.Txt_R6.Name = "Txt_R6"
        Me.Txt_R6.Size = New System.Drawing.Size(83, 20)
        Me.Txt_R6.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(121, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "R6"
        '
        'Txt_R5
        '
        Me.Txt_R5.Location = New System.Drawing.Point(32, 82)
        Me.Txt_R5.Name = "Txt_R5"
        Me.Txt_R5.Size = New System.Drawing.Size(83, 20)
        Me.Txt_R5.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "R5"
        '
        'Txt_R4
        '
        Me.Txt_R4.Location = New System.Drawing.Point(148, 56)
        Me.Txt_R4.Name = "Txt_R4"
        Me.Txt_R4.Size = New System.Drawing.Size(83, 20)
        Me.Txt_R4.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(121, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "R4"
        '
        'Txt_R3
        '
        Me.Txt_R3.Location = New System.Drawing.Point(32, 56)
        Me.Txt_R3.Name = "Txt_R3"
        Me.Txt_R3.Size = New System.Drawing.Size(83, 20)
        Me.Txt_R3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "R3"
        '
        'Txt_R2
        '
        Me.Txt_R2.Location = New System.Drawing.Point(148, 30)
        Me.Txt_R2.Name = "Txt_R2"
        Me.Txt_R2.Size = New System.Drawing.Size(83, 20)
        Me.Txt_R2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "R2"
        '
        'Txt_R1
        '
        Me.Txt_R1.Location = New System.Drawing.Point(32, 30)
        Me.Txt_R1.Name = "Txt_R1"
        Me.Txt_R1.Size = New System.Drawing.Size(83, 20)
        Me.Txt_R1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "R1"
        '
        'Txt_R0
        '
        Me.Txt_R0.Location = New System.Drawing.Point(148, 4)
        Me.Txt_R0.Name = "Txt_R0"
        Me.Txt_R0.Size = New System.Drawing.Size(83, 20)
        Me.Txt_R0.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "R0"
        '
        'Panel_Settings
        '
        Me.Panel_Settings.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel_Settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Settings.Controls.Add(Me.Txt_AddRows)
        Me.Panel_Settings.Controls.Add(Me.Btn_AddRows)
        Me.Panel_Settings.Controls.Add(Me.Txt_Step)
        Me.Panel_Settings.Controls.Add(Me.Label13)
        Me.Panel_Settings.Location = New System.Drawing.Point(1110, 104)
        Me.Panel_Settings.Name = "Panel_Settings"
        Me.Panel_Settings.Size = New System.Drawing.Size(129, 60)
        Me.Panel_Settings.TabIndex = 2
        '
        'Txt_AddRows
        '
        Me.Txt_AddRows.Location = New System.Drawing.Point(71, 32)
        Me.Txt_AddRows.MaxLength = 4
        Me.Txt_AddRows.Name = "Txt_AddRows"
        Me.Txt_AddRows.Size = New System.Drawing.Size(53, 20)
        Me.Txt_AddRows.TabIndex = 28
        Me.Txt_AddRows.Text = "50"
        '
        'Btn_AddRows
        '
        Me.Btn_AddRows.Location = New System.Drawing.Point(3, 30)
        Me.Btn_AddRows.Name = "Btn_AddRows"
        Me.Btn_AddRows.Size = New System.Drawing.Size(62, 23)
        Me.Btn_AddRows.TabIndex = 29
        Me.Btn_AddRows.Text = "Add Row"
        Me.Btn_AddRows.UseVisualStyleBackColor = True
        '
        'Txt_Step
        '
        Me.Txt_Step.Location = New System.Drawing.Point(71, 6)
        Me.Txt_Step.MaxLength = 4
        Me.Txt_Step.Name = "Txt_Step"
        Me.Txt_Step.Size = New System.Drawing.Size(53, 20)
        Me.Txt_Step.TabIndex = 25
        Me.Txt_Step.Text = "1000"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Step Delay"
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(3, 31)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(53, 22)
        Me.BtnSave.TabIndex = 32
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(3, 3)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(53, 22)
        Me.BtnNew.TabIndex = 31
        Me.BtnNew.Text = "New"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnLoadTable
        '
        Me.BtnLoadTable.Location = New System.Drawing.Point(3, 59)
        Me.BtnLoadTable.Name = "BtnLoadTable"
        Me.BtnLoadTable.Size = New System.Drawing.Size(53, 22)
        Me.BtnLoadTable.TabIndex = 30
        Me.BtnLoadTable.Text = "Load"
        Me.BtnLoadTable.UseVisualStyleBackColor = True
        '
        'Btn_Auto
        '
        Me.Btn_Auto.BackColor = System.Drawing.Color.Red
        Me.Btn_Auto.ForeColor = System.Drawing.Color.Black
        Me.Btn_Auto.Location = New System.Drawing.Point(3, 28)
        Me.Btn_Auto.Name = "Btn_Auto"
        Me.Btn_Auto.Size = New System.Drawing.Size(53, 53)
        Me.Btn_Auto.TabIndex = 26
        Me.Btn_Auto.Text = "Auto Run"
        Me.Btn_Auto.UseVisualStyleBackColor = False
        '
        'Btn_Run
        '
        Me.Btn_Run.Location = New System.Drawing.Point(3, 3)
        Me.Btn_Run.Name = "Btn_Run"
        Me.Btn_Run.Size = New System.Drawing.Size(53, 22)
        Me.Btn_Run.TabIndex = 0
        Me.Btn_Run.Text = "Step"
        Me.Btn_Run.UseVisualStyleBackColor = True
        '
        'MemoryGrid
        '
        Me.MemoryGrid.AllowUserToResizeColumns = False
        Me.MemoryGrid.AllowUserToResizeRows = False
        Me.MemoryGrid.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.MemoryGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.MemoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MemoryGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Line, Me.OpCode, Me.Operand1, Me.Operand2, Me.Operand3})
        Me.MemoryGrid.Location = New System.Drawing.Point(12, 50)
        Me.MemoryGrid.Name = "MemoryGrid"
        Me.MemoryGrid.RowHeadersVisible = False
        Me.MemoryGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MemoryGrid.Size = New System.Drawing.Size(504, 440)
        Me.MemoryGrid.TabIndex = 3
        '
        'Line
        '
        Me.Line.HeaderText = "Line"
        Me.Line.Name = "Line"
        Me.Line.ReadOnly = True
        '
        'OpCode
        '
        Me.OpCode.HeaderText = "OpCode"
        Me.OpCode.MaxInputLength = 3
        Me.OpCode.Name = "OpCode"
        '
        'Operand1
        '
        Me.Operand1.HeaderText = "Operand1"
        Me.Operand1.Name = "Operand1"
        '
        'Operand2
        '
        Me.Operand2.HeaderText = "Operand2"
        Me.Operand2.Name = "Operand2"
        '
        'Operand3
        '
        Me.Operand3.HeaderText = "Operand3"
        Me.Operand3.Name = "Operand3"
        '
        'Tmr_Auto
        '
        '
        'Panel_Toolbar
        '
        Me.Panel_Toolbar.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel_Toolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Toolbar.Controls.Add(Me.BTN_Reset_Memory)
        Me.Panel_Toolbar.Controls.Add(Me.BTN_ShowsSettings)
        Me.Panel_Toolbar.Controls.Add(Me.BTN_ShowRun)
        Me.Panel_Toolbar.Controls.Add(Me.BTN_ShowFile)
        Me.Panel_Toolbar.Location = New System.Drawing.Point(12, 12)
        Me.Panel_Toolbar.Name = "Panel_Toolbar"
        Me.Panel_Toolbar.Size = New System.Drawing.Size(753, 35)
        Me.Panel_Toolbar.TabIndex = 4
        '
        'BTN_Reset_Memory
        '
        Me.BTN_Reset_Memory.Location = New System.Drawing.Point(126, 3)
        Me.BTN_Reset_Memory.Name = "BTN_Reset_Memory"
        Me.BTN_Reset_Memory.Size = New System.Drawing.Size(55, 27)
        Me.BTN_Reset_Memory.TabIndex = 3
        Me.BTN_Reset_Memory.Text = "Reset"
        Me.BTN_Reset_Memory.UseVisualStyleBackColor = True
        '
        'BTN_ShowsSettings
        '
        Me.BTN_ShowsSettings.Location = New System.Drawing.Point(187, 4)
        Me.BTN_ShowsSettings.Name = "BTN_ShowsSettings"
        Me.BTN_ShowsSettings.Size = New System.Drawing.Size(55, 27)
        Me.BTN_ShowsSettings.TabIndex = 2
        Me.BTN_ShowsSettings.Text = "Settings"
        Me.BTN_ShowsSettings.UseVisualStyleBackColor = True
        '
        'BTN_ShowRun
        '
        Me.BTN_ShowRun.Location = New System.Drawing.Point(65, 3)
        Me.BTN_ShowRun.Name = "BTN_ShowRun"
        Me.BTN_ShowRun.Size = New System.Drawing.Size(55, 27)
        Me.BTN_ShowRun.TabIndex = 1
        Me.BTN_ShowRun.Text = "Run"
        Me.BTN_ShowRun.UseVisualStyleBackColor = True
        '
        'BTN_ShowFile
        '
        Me.BTN_ShowFile.Location = New System.Drawing.Point(4, 3)
        Me.BTN_ShowFile.Name = "BTN_ShowFile"
        Me.BTN_ShowFile.Size = New System.Drawing.Size(55, 27)
        Me.BTN_ShowFile.TabIndex = 0
        Me.BTN_ShowFile.Text = "File"
        Me.BTN_ShowFile.UseVisualStyleBackColor = True
        '
        'Panel_File
        '
        Me.Panel_File.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel_File.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_File.Controls.Add(Me.BtnLoadTable)
        Me.Panel_File.Controls.Add(Me.BtnNew)
        Me.Panel_File.Controls.Add(Me.BtnSave)
        Me.Panel_File.Location = New System.Drawing.Point(1179, 12)
        Me.Panel_File.Name = "Panel_File"
        Me.Panel_File.Size = New System.Drawing.Size(60, 86)
        Me.Panel_File.TabIndex = 5
        '
        'Panel_Run
        '
        Me.Panel_Run.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel_Run.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Run.Controls.Add(Me.Btn_Auto)
        Me.Panel_Run.Controls.Add(Me.Btn_Run)
        Me.Panel_Run.Location = New System.Drawing.Point(1110, 12)
        Me.Panel_Run.Name = "Panel_Run"
        Me.Panel_Run.Size = New System.Drawing.Size(61, 86)
        Me.Panel_Run.TabIndex = 6
        '
        'Txt_Log
        '
        Me.Txt_Log.Location = New System.Drawing.Point(522, 50)
        Me.Txt_Log.Name = "Txt_Log"
        Me.Txt_Log.ReadOnly = True
        Me.Txt_Log.Size = New System.Drawing.Size(243, 269)
        Me.Txt_Log.TabIndex = 7
        Me.Txt_Log.Text = ""
        '
        'Panel_Reset
        '
        Me.Panel_Reset.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel_Reset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Reset.Controls.Add(Me.BTN_ClearLog)
        Me.Panel_Reset.Controls.Add(Me.BTN_ClearReg)
        Me.Panel_Reset.Location = New System.Drawing.Point(1031, 12)
        Me.Panel_Reset.Name = "Panel_Reset"
        Me.Panel_Reset.Size = New System.Drawing.Size(73, 57)
        Me.Panel_Reset.TabIndex = 8
        '
        'BTN_ClearLog
        '
        Me.BTN_ClearLog.Location = New System.Drawing.Point(3, 28)
        Me.BTN_ClearLog.Name = "BTN_ClearLog"
        Me.BTN_ClearLog.Size = New System.Drawing.Size(65, 23)
        Me.BTN_ClearLog.TabIndex = 0
        Me.BTN_ClearLog.Text = "Log"
        Me.BTN_ClearLog.UseVisualStyleBackColor = True
        '
        'BTN_ClearReg
        '
        Me.BTN_ClearReg.Location = New System.Drawing.Point(3, 4)
        Me.BTN_ClearReg.Name = "BTN_ClearReg"
        Me.BTN_ClearReg.Size = New System.Drawing.Size(65, 23)
        Me.BTN_ClearReg.TabIndex = 1
        Me.BTN_ClearReg.Text = "Registers"
        Me.BTN_ClearReg.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 502)
        Me.Controls.Add(Me.Panel_Reset)
        Me.Controls.Add(Me.Txt_Log)
        Me.Controls.Add(Me.Panel_Run)
        Me.Controls.Add(Me.Panel_File)
        Me.Controls.Add(Me.Panel_Toolbar)
        Me.Controls.Add(Me.MemoryGrid)
        Me.Controls.Add(Me.Panel_Settings)
        Me.Controls.Add(Me.Panel_Registers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "GRLCulator"
        Me.Panel_Registers.ResumeLayout(False)
        Me.Panel_Registers.PerformLayout()
        Me.Panel_Settings.ResumeLayout(False)
        Me.Panel_Settings.PerformLayout()
        CType(Me.MemoryGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Toolbar.ResumeLayout(False)
        Me.Panel_File.ResumeLayout(False)
        Me.Panel_Run.ResumeLayout(False)
        Me.Panel_Reset.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Registers As Panel
    Friend WithEvents Txt_PC As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Txt_R9 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_R8 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_R7 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_R6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_R5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_R4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_R3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_R2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_R1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_R0 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_Settings As Panel
    Friend WithEvents Txt_Step As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Btn_Run As Button
    Friend WithEvents MemoryGrid As DataGridView
    Friend WithEvents Btn_Auto As Button
    Friend WithEvents Tmr_Auto As Timer
    Friend WithEvents Txt_AddRows As TextBox
    Friend WithEvents Btn_AddRows As Button
    Friend WithEvents BtnLoadTable As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Line As DataGridViewTextBoxColumn
    Friend WithEvents OpCode As DataGridViewTextBoxColumn
    Friend WithEvents Operand1 As DataGridViewTextBoxColumn
    Friend WithEvents Operand2 As DataGridViewTextBoxColumn
    Friend WithEvents Operand3 As DataGridViewTextBoxColumn
    Friend WithEvents Panel_Toolbar As Panel
    Friend WithEvents BTN_ShowFile As Button
    Friend WithEvents Panel_File As Panel
    Friend WithEvents BTN_ShowRun As Button
    Friend WithEvents Panel_Run As Panel
    Friend WithEvents BTN_ShowsSettings As Button
    Friend WithEvents Txt_Log As RichTextBox
    Friend WithEvents BTN_Reset_Memory As Button
    Friend WithEvents Panel_Reset As Panel
    Friend WithEvents BTN_ClearReg As Button
    Friend WithEvents BTN_ClearLog As Button
End Class
