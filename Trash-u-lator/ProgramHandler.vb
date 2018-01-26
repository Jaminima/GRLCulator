Module ProgramHandler

    Private CurrentLine As Integer = 0


    Sub HandleInstruction()
        Dim CurInstruction = Form1.Txt_Code.Text.Split(";")(CurrentLine),
            OpCode = CurInstruction.Split(" ")(0),
            Operands = CurInstruction.Remove(CurInstruction.Split(" ")(0)).Split(" ")
        If OpCode = "LDR" Then
            OpCodeHandler.LDR(Operands)
        End If
    End Sub

End Module

Module OpCodeHandler

    Sub LDR(Operands As Array)
        SharedCode._GetControl(Operands(0)).Text = 
    End Sub

End Module