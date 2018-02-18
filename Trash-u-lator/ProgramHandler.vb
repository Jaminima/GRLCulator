Module ProgramHandler

    Sub HandleInstruction()
        Try
            Dim Opcode = Form1.MemoryGrid.Item("OpCode", CInt(Form1.Txt_PC.Text) - 1).Value,
            Operand1 As String = Form1.MemoryGrid.Item("Operand1", CInt(Form1.Txt_PC.Text) - 1).Value,
            Operand2 As String = Form1.MemoryGrid.Item("Operand2", CInt(Form1.Txt_PC.Text) - 1).Value,
            Operand3 As String = Form1.MemoryGrid.Item("Operand3", CInt(Form1.Txt_PC.Text) - 1).Value

            If Opcode = "LDR" Then OpCodeHandlerNew.LDR(Operand1, Operand2)
            If Opcode = "STR" Then OpCodeHandlerNew.STR(Operand1, Operand2)
            If Opcode = "MOV" Then OpCodeHandlerNew.MOV(Operand1, Operand2)
            If Opcode = "ADD" Then OpCodeHandlerNew.Math_ADD(Operand1, Operand2, Operand3)
            If Opcode = "SUB" Then OpCodeHandlerNew.Math_SUB(Operand1, Operand2, Operand3)
            If Opcode = "JMP" Then OpCodeHandlerNew.JMP(Operand1)
            If Opcode = "B" Then OpCodeHandlerNew.B(Operand1)
            If Opcode = "HLT" Then OpCodeHandlerNew.HALT()
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

Module OpCodeHandlerNew

    Sub LDR(Operand1, Operand2)
        SharedCode._GetControl(Operand1).Text = AddressForm(Operand2)
        Form1.Txt_Log.AppendText(vbNewLine & "Loaded " & Operand2 & " Into " & Operand1)
    End Sub

    Sub STR(Operand1, Operand2)
        Form1.MemoryGrid.Item("Operand1", CInt(Operand2) - 1).Value = AddressForm(Operand1)
        Form1.Txt_Log.AppendText(vbNewLine & "Stored Value In " & Operand1 & " Into " & Operand2)
    End Sub

    Sub MOV(Operand1, Operand2)
        LDR(Operand1, Operand2)
    End Sub

    Sub Math_ADD(Operand1, Operand2, Operand3)
        SharedCode._GetControl(Operand1).Text = CInt(AddressForm(Operand2)) + CInt(AddressForm(Operand3))
        Form1.Txt_Log.AppendText(vbNewLine & "Added " & Operand2 & " To " & Operand3 & " And Stored Into " & Operand1)
    End Sub

    Sub Math_SUB(Operand1, Operand2, Operand3)
        SharedCode._GetControl(Operand1).Text = CInt(AddressForm(Operand2)) - CInt(AddressForm(Operand3))
        Form1.Txt_Log.AppendText(vbNewLine & "Subtracted " & Operand3 & " From " & Operand2 & " And Stored Into " & Operand1)
    End Sub

    Sub JMP(Operand1)
        Form1.Txt_PC.Text = CInt(Operand1) - 1
        Form1.Txt_Log.AppendText(vbNewLine & "Jumped To " & Operand1)
    End Sub

    Sub B(Operand1)
        For Row = 0 To Form1.MemoryGrid.Rows.Count - 1
            If ":" & Operand1 = Form1.MemoryGrid.Item("OpCode", Row).Value Then
                JMP(Row + 1)
                Form1.Txt_Log.AppendText(vbNewLine & "Branched Too " & Operand1)
            End If
        Next
    End Sub

    Sub HALT()
        Form1.Txt_Log.AppendText(vbNewLine & "Halted")
        Form1.Tmr_Auto.Stop()
        Form1.Btn_Auto.BackColor = Color.Red
        Form1.Run = False
    End Sub

End Module