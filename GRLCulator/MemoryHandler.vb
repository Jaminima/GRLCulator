Module MemoryHandler

    Sub Save(FileName As String)

        Dim Arr As String(,) = New String(Form1.MemoryGrid.Rows.Count, 3) {}

        For Row = 0 To Form1.MemoryGrid.Rows.Count - 1
            For Col = 0 To 3
                Arr(Row, Col) = Form1.MemoryGrid.Item(Col + 1, Row).Value
            Next
        Next

        StreamWriter.CSV.Write2DArray(Arr, FileName, "./")

    End Sub

    Sub Load(FileName As String)

        Form1.MemoryGrid.Rows.Clear()

        Dim Content = StreamWriter.CSV.Read2DArray(FileName, "./")

        For Row As Integer = 0 To Content.GetLength(0) - 1
            Form1.MemoryGrid.Rows.Add()
            For Col As Integer = 0 To 3
                Form1.MemoryGrid.Item(Col + 1, Row).Value = Content(Row, Col)
            Next
        Next

    End Sub

    Sub Reset()
        Form1.MemoryGrid.Rows.Clear()
        SharedCode.AddLine(48)
    End Sub

End Module
