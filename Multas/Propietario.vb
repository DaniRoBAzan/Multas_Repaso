Imports Multas

Public MustInherit Class Propietario
    Implements IMultado
    Private _nombre As String
    Private _vehiculos As List(Of Vehiculo)
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    ''== CARDINALIDAD CON VEHICULO 1-M 
    Friend Sub addVehiculo(variable As Vehiculo)
        _vehiculos.Add(variable)
    End Sub
    Friend Sub removeVehiculo(variable As Vehiculo)
        _vehiculos.Remove(variable)
    End Sub
    Public Function getAllVehiculos() As List(Of Vehiculo)
        Return _vehiculos
    End Function
    Public Function GetAllMultas() As List(Of Multa) Implements IMultado.GetAllMultas
        Dim listaMultas As New List(Of Multa)
        For Each auto In _vehiculos
            For x = 0 To auto.GetAllMultas().Count() - 1
                listaMultas.Add(auto.GetAllMultas().Item(x))
                Console.WriteLine(auto.GetAllMultas().Item(x))
            Next
        Next
        Return listaMultas
    End Function

    Public Function GetTotalMultas() As Decimal Implements IMultado.GetTotalMultas
        Dim total As Decimal
        For Each auto In _vehiculos
            total += auto.GetTotalMultas()
        Next
        Return total
    End Function
    Sub New(Nombre As String)
        Me.Nombre = Nombre
        _vehiculos = New List(Of Vehiculo)
    End Sub
End Class
