Public Class FLibrosPrestados
    Dim FuncPrestamo As New DPrestamo
    Dim DatPrestamo As New LPrestamo
    Dim Busqueda As DataView

    Private Sub FLibrosPrestados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarListaPrestamo()

    End Sub


    Public Sub CargarListaPrestamo()
        Dim CantRegistros As Integer
        Try
            Busqueda = FuncPrestamo.MostrarPrestamo.DefaultView
            dgvPrestamo.DataSource = FuncPrestamo.MostrarPrestamo
            dgvPrestamo.DataSource = Busqueda

            dgvPrestamo.Columns(5).Visible = True
            CantRegistros = dgvPrestamo.RowCount
            lblRegistros.Text = Convert.ToString(CantRegistros)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dgvPrestamo.ClearSelection()
            dgvPrestamo.Columns(0).Width = 50
            dgvPrestamo.Columns(3).Width = 80
            dgvPrestamo.Columns(4).Width = 90
            dgvPrestamo.Columns(5).Width = 80

        End Try
    End Sub


    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRetornar_Click(sender As Object, e As EventArgs) Handles btnRetornar.Click
        Try
            If dgvPrestamo.SelectedRows.Count > 0 Then
                RetornarLibro()
                CargarListaPrestamo()
                dgvPrestamo.ClearSelection()
            Else
                MsgBox("Seleccione un Registro", MsgBoxStyle.Information, "Mensaje del Sistema")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub RetornarLibro()
        Try
            DatPrestamo._CodPrestamo = Convert.ToInt32(dgvPrestamo.SelectedCells.Item(0).Value)

            If MsgBox("¿Desea retornar este libro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
                If FuncPrestamo.ModificarLibro(DatPrestamo) Then
                    MsgBox("El libro ha sido devuelto exitosamente.", MsgBoxStyle.Information, "Mensaje del Sistema")
                Else
                    MsgBox("La devolucón no se pudó realizar.", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub dgvPrestamo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrestamo.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class