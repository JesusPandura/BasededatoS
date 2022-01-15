Public Class Estados
    Dim FuncLibro As New DLibros
    Dim DatLibros As New LLibros
    Dim Busqueda As New DataView


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListaP()

    End Sub


    Public Sub CargarListaP()
        Dim CantRegistros As Integer
        Try
            dgvP.DataSource = FuncLibro.MostraPe

            CantRegistros = dgvP.RowCount

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dgvP.ClearSelection()
        End Try
    End Sub



End Class