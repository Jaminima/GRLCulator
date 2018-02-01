Module SharedCode

    Function _GetControl(KnownName As String) As Control
        For Each Control In Form1.Panel_Registers.Controls
            If Control.Name.Contains(KnownName) Then
                Return Control
            End If
        Next
        Debug.WriteLine("NullFound")
    End Function

    Function AddLine(Add As Integer)
        For i = 1 To Add
            Form1.MemoryGrid.Rows.Add()
        Next
    End Function

End Module
