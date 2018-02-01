Module ProgramHandler

    Sub HandleInstruction()
        Try
            Dim Opcode = Form1.MemoryGrid.Item("Instruction", CInt(Form1.Txt_PC.Text) - 1).Value,
            Operand1 As String = Form1.MemoryGrid.Item("Operand1", CInt(Form1.Txt_PC.Text) - 1).Value,
            Operand2 As String = Form1.MemoryGrid.Item("Operand2", CInt(Form1.Txt_PC.Text) - 1).Value,
            Operand3 As String = Form1.MemoryGrid.Item("Operand3", CInt(Form1.Txt_PC.Text) - 1).Value

            If Opcode = "LDR" Then LDR(Operand1, Operand2)
            If Opcode = "STR" Then STR(Operand1, Operand2)
            If Opcode = "MOV" Then MOV(Operand1, Operand2)
            If Opcode = "ADD" Then Math_ADD(Operand1, Operand2, Operand3)
            If Opcode = "SUB" Then Math_SUB(Operand1, Operand2, Operand3)
            If Opcode = "JMP" Then JMP(Operand1)
            If Opcode = "HALT" Then HALT()
        Catch
            Form1.Tmr_Auto.Stop()
            Form1.Btn_Auto.BackColor = Color.Red
            Form1.Run = False
            SharedCode.AddLine(50)
            MsgBox("Out Of Memory ;(" & vbNewLine & "MAKING MORE!!!!!!")
        End Try
        Form1.Txt_PC.Text = CInt(Form1.Txt_PC.Text) + 1
    End Sub

End Module

Module OpCodeHandler

    Sub LDR(Operand1, Operand2)
        SharedCode._GetControl(Operand1).Text = Form1.MemoryGrid.Item("Operand1", CInt(Operand2) - 1).Value
    End Sub

    Sub STR(Operand1, Operand2)
        Form1.MemoryGrid.Item("Operand1", CInt(Operand2) - 1).Value = SharedCode._GetControl(Operand1).Text
    End Sub

    Sub MOV(Operand1, Operand2)
        SharedCode._GetControl(Operand1).Text = Operand2
    End Sub

    Sub Math_ADD(Operand1, Operand2, Operand3)
        SharedCode._GetControl(Operand1).Text = CInt(SharedCode._GetControl(Operand2).Text) + CInt(Form1.MemoryGrid("Operand1", CInt(Operand3) - 1).Value)
    End Sub

    Sub Math_SUB(Operand1, Operand2, Operand3)
        SharedCode._GetControl(Operand1).Text = CInt(SharedCode._GetControl(Operand2).Text) - CInt(Form1.MemoryGrid("Operand1", CInt(Operand3) - 1).Value)
    End Sub

    Sub JMP(Operand1)
        Form1.Txt_PC.Text = CInt(Operand1) - 1
    End Sub

    Sub HALT()
        Form1.Tmr_Auto.Stop()
        Form1.Btn_Auto.BackColor = Color.Red
        Form1.Run = False
    End Sub

End Module