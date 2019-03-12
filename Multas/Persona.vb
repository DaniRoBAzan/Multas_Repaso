Public Class Persona
    Inherits Propietario
    Private _dni As UInteger
    Public Property DNI As UInteger
        Get
            Return _dni
        End Get
        Set(value As UInteger)
            _dni = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
    Sub New(Nombre As String, dni As UInteger)
        MyBase.New(Nombre)
        Me._dni = dni
    End Sub
End Class
