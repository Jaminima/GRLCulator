Module SharedCode

    Function _GetControl(KnownName As String) As Control
        For Each Control In Form1.Controls
            If Control.Name.Contains(KnownName) Then
                Return Control
            End If
        Next
    End Function

End Module
