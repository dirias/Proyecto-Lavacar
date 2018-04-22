Public Class Cls_Citas
    Public Function reservarCita(pNombre As String, pApellidos As String, pPlaca As String, pMarca As String, pFecha As String, pHora As String, pTel As String, pDes As String)
        Try

            citas.citNombre = pNombre
            citas.citApellidos = pApellidos
            citas.citPlaca = pPlaca
            citas.citMarca = pMarca
            citas.citFecha = pFecha
            citas.citHora = pHora
            citas.citTelefono = pTel
            citas.citDescrip = pDes
            DB.tblCitas.Add(citas)

            DB.SaveChanges()

            Return True
        Catch ex As Exception
            ''Mensaje de error
            MsgBox("Error al reservar los datos" & vbCrLf & ex.Message)
            Return False
        End Try
    End Function
    Public Function buscarCita(pNombre As String)
        Try

            citas = (From temp In DB.tblCitas
                     Where temp.citNombre = pNombre
                     Select temp).First()

            Dim placa = citas.citPlaca
            Dim marca = citas.citMarca

            Dim lista As New Collection
            lista.Add(placa)
            lista.Add(marca)

            Return lista

        Catch ex As Exception
            ''Mensaje de error
            MsgBox("Debe digitar el nombre del cliente que quiere buscar" & vbCrLf & ex.Message)

        End Try
    End Function
    Public Function modificarCita(pId As String, pNombre As String, pApellidos As String, pPlaca As String, pMarca As String, pFecha As String, pHora As String, pTel As String, pDes As String)
        Try
            citas = (From temp In DB.tblCitas
                     Where temp.citId = pId
                     Select temp).First()

            citas.citNombre = pNombre
            citas.citApellidos = pApellidos
            citas.citPlaca = pPlaca
            citas.citMarca = pMarca
            citas.citFecha = pFecha
            citas.citHora = pHora
            citas.citTelefono = pTel
            citas.citDescrip = pDes

            DB.SaveChanges()

            Return True
        Catch ex As Exception
            ''Mensaje de error
            MsgBox("Error al modificar los datos" & vbCrLf & ex.Message)
            Return False
        End Try
    End Function
End Class
