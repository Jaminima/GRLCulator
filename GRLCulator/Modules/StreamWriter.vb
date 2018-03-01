Imports System.IO
Module StreamWriter

    Public CSV As New ClassCSV

    Sub Write(Content As String, FileName As String, Directory As String)

        Dim Writer = My.Computer.FileSystem.OpenTextFileWriter(Directory & "/" & FileName, False)
        Writer.Write(Content)
        Writer.Close()

    End Sub

    Sub Append(Content As String, FileName As String, Directory As String)

        Dim Writer = My.Computer.FileSystem.OpenTextFileWriter(Directory & "/" & FileName, True)
        Writer.Write(Content)
        Writer.Close()

    End Sub

    Function Read(FileName As String, Directory As String) As String

        Dim Reader = My.Computer.FileSystem.OpenTextFileReader(Directory & "/" & FileName)
        Return Reader.ReadToEnd

    End Function

    Class ClassCSV

        Sub Write2DArray(Arr As String(,), FileName As String, Directory As String)

            Dim Writer = My.Computer.FileSystem.OpenTextFileWriter(Directory & "/" & FileName & ".csv", False)

            For Row = 0 To Arr.GetLength(0) - 1
                For Col = 0 To Arr.GetLength(1) - 1
                    Writer.Write(Arr(Row, Col) & ",")
                Next
                Writer.Write(vbNewLine)
            Next

            Writer.Close()

        End Sub

        Function Read2DArray(FileName As String, Directory As String) As String(,)

            Dim Reader = My.Computer.FileSystem.OpenTextFileReader(Directory & "/" & FileName & ".csv"),
                Content = Reader.ReadToEnd,
                Retrn As String(,) = New String(Content.Split(vbNewLine).Count - 1, Content.Split(vbNewLine)(0).Split(",").Count) {}

            For Row = 0 To File.ReadAllLines(Directory & "/" & FileName & ".csv").Count
                Dim RowContent = Content.Split(vbNewLine)(Row)
                For Column = 0 To RowContent.Split(",").Count - 1
                    Retrn(Row, Column) = RowContent.Split(",")(Column)
                Next
            Next

            Return Retrn

        End Function

    End Class

End Module
