Module MemoryHandler

    Sub Save(FileName As String)

        Dim Data = Form1.MemoryGrid.Rows,
            RowsContent As New List(Of List(Of String)),
            StoreFormat As String

        For Each Row As DataGridViewRow In Data
            Dim RowContent As New List(Of String)({})
            For Each Cell As DataGridViewCell In Row.Cells
                RowContent.Add(Cell.Value)
            Next
            RowsContent.Add(RowContent)
        Next

        For Each Row In RowsContent
            For Each Cell In Row
                StoreFormat = StoreFormat & Cell & "+"
            Next
            StoreFormat = StoreFormat & "&"
        Next
        StoreFormat = StoreFormat.Replace("+&", "&")
        StoreFormat = StoreFormat.TrimEnd("&")

        Dim FileStore As System.IO.FileStream = System.IO.File.Create("./" & FileName & ".Yeet")
        FileStore.Close()
        My.Computer.FileSystem.WriteAllText("./" & FileName & ".Yeet", StoreFormat, False)

    End Sub

    Sub Load(FileName As String)

        Form1.MemoryGrid.Rows.Clear()

        Dim StoreFormat = My.Computer.FileSystem.ReadAllText("./" & FileName & ".Yeet"),
            Rows = StoreFormat.Split("&"),
            RowI = 0, ColI = 0

        For Each Row In Rows
            Dim Cols = Row.Split("+")
            Form1.MemoryGrid.Rows.Add()
            For Each Col In Cols
                Form1.MemoryGrid.Item(ColI, RowI).Value = Col
                ColI += 1
            Next
            ColI = 0
            RowI += 1
        Next

    End Sub

    Sub Reset()
        Form1.MemoryGrid.Rows.Clear()
        SharedCode.AddLine(48)
    End Sub

End Module
