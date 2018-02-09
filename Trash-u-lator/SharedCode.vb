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

    Function AddressForm(Address As String) As String
        If Address.Contains("#") Then
            Address = Address.TrimStart("#")
            Return Address
        ElseIf Address.ToCharArray()(0) = "R" Then
            Return _GetControl(Address).Text
        Else
            Return Form1.MemoryGrid("Operand1", CInt(Address) - 1).Value
        End If
    End Function

End Module
