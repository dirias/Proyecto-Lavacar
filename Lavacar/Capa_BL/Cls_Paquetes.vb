Imports Lavacar.dbLujan21Entities
Imports Lavacar.Globales

Public Class Cls_Paquetes

    ''Los paquetes estandar no se registran por que vienen por default
    Public Function registrarPaqueteTemporada(pNombre As String, pTipo As String, pDescrip As String, pCosto As Double)
        Try
            paquete.paqNombre = pNombre
            paquete.paqTipo = pTipo
            paquete.paqDescripcion = pDescrip
            paquete.paqCosto = pCosto

            DB.tblPaquetes.Add(paquete)
            DB.SaveChanges()
            Return True

        Catch ex As Exception
            ''Mensaje de error
            MsgBox("Error al registrar los datos" & vbCrLf & ex.Message)
            Return False

        End Try
    End Function

    Public Function modificarPaqueteTemporada(pID As String, pNombre As String, pDescrip As String, pCosto As Decimal)
        Try
            paquete = (From temp In DB.tblPaquetes
                       Where temp.paqId = pID
                       Select temp).First()

            paquete.paqNombre = pNombre
            paquete.paqDescripcion = pDescrip
            paquete.paqCosto = pCosto

            DB.SaveChanges()

            Return True

        Catch ex As Exception
            ''Mensaje de error
            MsgBox("Error al modificar los datos" & vbCrLf & ex.Message)
            Return False
        End Try
    End Function
    Public Function modificarPaqueteEstandar(pNombre As String, pDescrip As String, pCosto As Decimal)
        Try
            paquete = (From temp In DB.tblPaquetes
                       Where temp.paqNombre = pNombre
                       Select temp).First()

            paquete.paqDescripcion = pDescrip
            paquete.paqCosto = pCosto

            DB.SaveChanges()

            Return True

        Catch ex As Exception
            ''Mensaje de error
            MsgBox("Error al modificar los datos" & vbCrLf & ex.Message)
            Return False
        End Try
    End Function

    Public Function borrarPaquete(pNombre As String)
        Try
            paquete = (From temp In DB.tblPaquetes
                       Where temp.paqNombre = pNombre
                       Select temp).First()

            DB.tblPaquetes.Remove(paquete)
            DB.SaveChanges()
            Return True

        Catch ex As Exception
            ''Mensaje de error
            MsgBox("Debe digitar el nombre del paquete que quiere eliminar" & vbCrLf & ex.Message)
            Return False

        End Try
    End Function

    Public Function buscarPaquete(pNombre As String)
        Try

            paquete = (From temp In DB.tblPaquetes
                       Where temp.paqNombre = pNombre
                       Select temp).First()

            pNombre = paquete.paqNombre
            Dim Descripcion = paquete.paqDescripcion
            Dim Costo = paquete.paqCosto

            Dim lista As New Collection
            lista.Add(pNombre)
            lista.Add(Descripcion)
            lista.Add(Costo)

            Return lista

        Catch ex As Exception
            ''Mensaje de error
            MsgBox("Debe digitar el nombre del paquete que quiere buscar" & vbCrLf & ex.Message)
            Return False

        End Try
    End Function
    Public Function extraerPaqueteTemporada()
        Try

            Dim lista As New Collection

            For Each paq In DB.tblPaquetes
                If paq.paqTipo = "Temporada" Then
                    lista.Add(paq.paqNombre)
                End If
            Next
            If lista.Count = 0 Then
                Dim estado As String
                estado = "Nada"
                lista.Add(estado)
                Return lista
            Else
                Return lista
            End If
        Catch ex As Exception
            ''Mensaje de error
            MsgBox("Error" & vbCrLf & ex.Message)
            Return "Nada"
        End Try
    End Function


End Class
