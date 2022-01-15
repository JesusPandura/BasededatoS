Public Class LLibros

    Dim Titulo, Ubicacion As String
    Dim Clave_Libro, Clave_Autor, CodGenero, Clave_Editorial, Cantidad As Integer
    Public Property _ClaveLibro
        Set(value)
            Clave_Libro = value
        End Set
        Get
            Return Clave_Libro
        End Get
    End Property
    Public Property _Titulo
        Set(value)
            Titulo = value
        End Set
        Get
            Return Titulo
        End Get
    End Property

    Public Property _Ubicacion
        Set(value)
            Ubicacion = value
        End Set
        Get
            Return Ubicacion
        End Get
    End Property

    Public Property _ClaveAutor
        Set(value)
            Clave_Autor = value
        End Set
        Get
            Return Clave_Autor
        End Get
    End Property

    Public Property _CodGenero
        Set(value)
            CodGenero = value
        End Set
        Get
            Return CodGenero
        End Get
    End Property


    Public Property _CodEditorial
        Set(value)
            Clave_Editorial = value
        End Set
        Get
            Return Clave_Editorial
        End Get
    End Property


    Public Property _Cantidad
        Set(value)
            Cantidad = value
        End Set
        Get
            Return Cantidad
        End Get
    End Property
End Class
