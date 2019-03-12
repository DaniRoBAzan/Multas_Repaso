Public NotInheritable Class Empresa
    Inherits Propietario
    Private _cuit As String
    Public Property CUIT As String
        Get
            Return _cuit
        End Get
        Set(value As String)
            _cuit = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
    Sub New(nombre As String, cuit As String)
        MyBase.New(nombre)
        Me.CUIT = cuit
    End Sub
End Class
