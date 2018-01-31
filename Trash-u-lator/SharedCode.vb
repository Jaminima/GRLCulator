Module SharedCode

    Function _GetControl(KnownName As String) As Control
        For Each Control In Form1.Panel_Registers.Controls
            If Control.Name.Contains(KnownName) Then
                Return Control
            End If
        Next
        Debug.WriteLine("NullFound")
    End Function

End Module
