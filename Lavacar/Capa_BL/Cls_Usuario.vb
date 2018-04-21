Imports Lavacar.dbLujan21Entities
Imports Lavacar.Globales
Public Class Cls_Usuario


    Public Function registrarUsuario(pNombre As String, pApellidos As String, pUser As String, pPw As String, pRights As String)
        Try

            usuario.admiNombre = pNombre
            usuario.admiApellidos = pApellidos
            usuario.admiUsuario = pUser
            usuario.admiPW = pPw
            usuario.admiRights = pRights

            DB.tblAdmi.Add(usuario)
            DB.SaveChanges()

            Return True
        Catch ex As Exception
            ''Mensaje de error
            MsgBox("Error al registrar los datos" & vbCrLf & ex.Message)
            Return False
        End Try
    End Function

    Public Function borrarUsuario(pUser As String)
        Try
            usuario = (From temp In DB.tblAdmi
                       Where temp.admiUsuario = pUser
                       Select temp).First()

            DB.tblAdmi.Remove(usuario)
            DB.SaveChanges()

            Return True

        Catch ex As Exception
            ''Mensaje de error
            MsgBox("Error al borrar los datos" & vbCrLf & ex.Message)
            Return False
        End Try
    End Function

    Public Function modificarUsuario(pNombre As String, pApellidos As String, pUser As String, pPw As String, pRights As String)
        Try
            usuario = (From temp In DB.tblAdmi
                       Where temp.admiUsuario = pUser
                       Select temp).First

            usuario.admiNombre = pNombre
            usuario.admiApellidos = pApellidos
            usuario.admiPW = pPw
            usuario.admiRights = pRights

            DB.SaveChanges()

            Return True

        Catch ex As Exception
            ''Mensaje de error
            MsgBox("Error al modificar los datos" & vbCrLf & ex.Message)
            Return False
        End Try
    End Function

    Public Function inicioSesión(pUser As String, pPW As String)
        Try
            usuario = (From temp In DB.tblAdmi
                       Where temp.admiUsuario = pUser
                       Select temp).First
            If usuario.admiUsuario = pUser And usuario.admiPW = pPW Then
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al inicial sesión, verifique los datos." & vbCrLf & ex.Message)
            Return False
        End Try
    End Function

End Class
