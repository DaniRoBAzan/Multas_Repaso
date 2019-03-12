Public Class Registro
    Shared _multas As List(Of Multa)
    Shared Function GetMultasByMultado(value As IMultado) As List(Of Multa)
        Return value.GetAllMultas()
    End Function
    Shared Function GetAllPropietariosMultados() As List(Of Propietario)
        Dim listaPropietarios As New List(Of Propietario)
        For Each multa In _multas
            If listaPropietarios.Contains(multa.Vehiculo.Propietario) Then
            Else
                listaPropietarios.Add(multa.Vehiculo.Propietario)
            End If

        Next
        Return listaPropietarios
    End Function
    Shared Function GetPersonaByDNI(dni As UInteger) As Persona
        For Each multa In _multas.OfType(Of Persona)
            If multa.DNI = dni Then
                Return multa
            End If
        Next
        Throw New Exception("Exception: Dni " & dni & " no pertenece a ningún autor")
    End Function
    Shared Sub AddMulta(Multa As Multa)
        _multas.Add(Multa)
    End Sub
End Class
