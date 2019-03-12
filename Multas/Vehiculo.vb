Imports Multas
Public Class Vehiculo
    Implements IMultado
    Private _patente As String
    Private _multas As List(Of Multa)
    Private _propietario As Propietario
    Public Property Patente As String
        Get
            Return _patente
        End Get
        Set(value As String)
            _patente = value
        End Set
    End Property
    Public Property Propietario As Propietario
        Get
            Return _propietario
        End Get
        Set(value As Propietario)
            _propietario = value
        End Set
    End Property
    ''== CARDINALIDAD CON MULTA 1-M 
    Friend Sub addMulta(variable As Multa)
        _multas.Add(variable)
    End Sub
    Public Function GetAllMultas() As List(Of Multa) Implements IMultado.GetAllMultas
        Dim listaMulta As New List(Of Multa)
        For Each multa In _multas
            listaMulta.Add(multa)
        Next
        Return listaMulta
    End Function

    Public Function GetTotalMultas() As Decimal Implements IMultado.GetTotalMultas
        Dim Total As New Decimal
        For Each multa In _multas
            Total += multa.CalcularMonto()
        Next
        Return Total
    End Function
    Public Overrides Function ToString() As String
        Return _patente & Propietario.ToString()
    End Function
    Sub New(patente As String)
        Me.Patente = patente
        _multas = New List(Of Multa)
    End Sub
End Class
