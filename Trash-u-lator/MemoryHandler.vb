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
        'StoreFormat = StoreFormat.Replace("+&", "&")

        Dim FileStore As System.IO.FileStream = System.IO.File.Create("./" & FileName & ".Yeet")
        FileStore.Close()
        My.Computer.FileSystem.WriteAllText("./" & FileName & ".Yeet", StoreFormat, False)

    End Sub

    Sub Load(FileName As String)

        Form1.MemoryGrid.Rows.Clear()

        Dim StoreFormat = My.Computer.FileSystem.ReadAllText("./" & FileName & ".Yeet"),
            Rows = StoreFormat.Split("&")

        Debug.WriteLine(Rows.Count - 1)

        For Row = 0 To Rows.Count - 2
            Dim Cells = Rows(Row).Split("+")
            For Cell = 0 To Cells.Count - 2
                Form1.MemoryGrid.Item(Cell, Row).Value = Cells(Cell)
                Debug.WriteLine(Cells(Cell))
            Next
            Form1.MemoryGrid.Rows.Add()
        Next


    End Sub

End Module
