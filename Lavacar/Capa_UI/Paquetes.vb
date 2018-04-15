Public Class Paquetes
    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupTemporada.Enter

    End Sub

    Private Sub CbxTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxTipo.SelectedIndexChanged
        If CbxTipo.SelectedIndex = 0 Then
            GroupEstandar.Visible = True
            GroupTemporada.Visible = False
            btnCrear.Enabled = False
            btnBorrar.Enabled = False
        Else
            GroupEstandar.Visible = False
            GroupTemporada.Visible = True
            btnCrear.Enabled = True
            btnBorrar.Enabled = True
        End If
    End Sub

    Private Sub Paquetes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CbxTipo.SelectedIndex = 0
    End Sub
End Class