Public Class Cls_Lavados
    Public Function registrarLavado(pTipoCliente As String, pTipoPaquete As String, pPaquete As String, pSize As String,
                                    pFechaPago As String, pUsuario As String, pLavador As String, pFechaLavado As String,
                                    pcliente As String, pMarca As String, pHora As String, pMonto As Decimal)
        Try


            DB.SaveChanges()

            Return True
        Catch ex As Exception
            ''Mensaje de error
            MsgBox("Error al registrar los datos" & vbCrLf & ex.Message)
            Return False
        End Try
    End Function
End Class
