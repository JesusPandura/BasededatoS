Public Class LPrestamo
    Dim Clave_prestamo, Clave_Lector, Clave_Libro As Integer

    Dim Fec_Devolucion As Date
    Public Property _CodPrestamo
        Set(value)
            Clave_Prestamo = value
        End Set
        Get
            Return Clave_prestamo
        End Get
    End Property
    Public Property _CodLector
        Set(value)
            Clave_Lector = value
        End Set
        Get
            Return Clave_Lector
        End Get
    End Property

    Public Property _CodLibro
        Set(value)
            Clave_Libro = value
        End Set
        Get
            Return Clave_Libro
        End Get
    End Property
    Public Property _FecDevolucion
        Set(value)
            Fec_Devolucion = value
        End Set
        Get
            Return Fec_Devolucion
        End Get
    End Property
End Class
