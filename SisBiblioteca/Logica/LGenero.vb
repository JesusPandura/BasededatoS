Public Class LGenero
    Dim Ckave_Genero As Integer
    Dim Genero As String
    Public Property _Genero
        Set(value)
            Genero = value
        End Set
        Get
            Return Genero
        End Get
    End Property

    Public Property _CodGenero
        Set(value)
            Ckave_Genero = value
        End Set
        Get
            Return Ckave_Genero
        End Get
    End Property
End Class
