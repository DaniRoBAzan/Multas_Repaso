Public Class Multa
    Private _fecha As Date
    Private _latitud As Decimal
    Private _longitud As Decimal
    Private _unidades As UShort
    Shared _montoUnidad As UShort
    Private _vehiculo As Vehiculo
    Public Property Vehiculo As Vehiculo
        Get
            Return _vehiculo
        End Get
        Set(value As Vehiculo)
            _vehiculo = value
        End Set
    End Property
    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    Public Property Longitud As Decimal
        Get
            Return _longitud
        End Get
        Set(value As Decimal)
            _longitud = value
        End Set
    End Property
    Public Property Latitud As Decimal
        Get
            Return _latitud
        End Get
        Set(value As Decimal)
            _latitud = value
        End Set
    End Property
    Public Property Unidades As UShort
        Get
            Return _unidades
        End Get
        Set(value As UShort)
            _unidades = value
        End Set
    End Property
    Shared Property MontoUnidad As UShort
        Get
            Return _montoUnidad
        End Get
        Set(value As UShort)
            _montoUnidad = value
        End Set
    End Property
    Public Function CalcularMonto() As Decimal
        Return Unidades * MontoUnidad
    End Function
    Public Overrides Function ToString() As String
        Return Vehiculo.ToString() & " - " & Fecha
    End Function
    Sub New(vehiculo As Vehiculo, fecha As Date, latitud As Decimal, longitud As Decimal, unidades As UShort)
        Me.Vehiculo = vehiculo
        Me.Fecha = fecha
        Me.Latitud = latitud
        Me.Longitud = longitud
        Me.Unidades = unidades
    End Sub
End Class
