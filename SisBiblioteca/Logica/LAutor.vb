Public Class LAutor
    Dim Autor As String
    Dim Clave_Autor As Integer
    Public Property _Autor
        Set(value)
            Autor = value
        End Set
        Get
            Return Autor
        End Get
    End Property

    Public Property _CodAutor
        Set(value)
            Clave_Autor = value
        End Set
        Get
            Return Clave_Autor
        End Get
    End Property
End Class
