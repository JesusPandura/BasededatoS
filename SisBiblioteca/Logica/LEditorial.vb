Public Class LEditorial
    Dim Clave_Editorial As Integer
    Dim Editorial As String
    Public Property _CodEditorial
        Set(value)
            Clave_Editorial = value
        End Set
        Get
            Return Clave_Editorial
        End Get
    End Property

    Public Property _Editorial
        Set(value)
            Editorial = value
        End Set
        Get
            Return Editorial
        End Get
    End Property

End Class
