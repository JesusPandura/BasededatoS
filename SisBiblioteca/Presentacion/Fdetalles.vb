Public Class Fdetalles
    Dim FuncLibro As New DLibros
    Dim FuncBibliotecario As New DBibliotecario
    Dim DatBibliotecario As New LBibliotecario
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarListaD()
    End Sub


    Public Sub CargarListaD()
        Dim CantRegistros As Integer
        Try
            dgd.DataSource = FuncLibro.DetallesPe()

            CantRegistros = dgd.RowCount

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dgd.ClearSelection()
        End Try
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click

        Try
            If dgd.SelectedRows.Count > 0 Then
                ModificarBibliotecario()
                CargarListaD()
            Else
                MsgBox("Seleccione un Registro", MsgBoxStyle.Information, "Mensaje del Sistema")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ModificarBibliotecario()
        Try
            Dim FormModificar As New FMbibliotecario
            FormModificar.CodBibliotecario = dgd.SelectedCells.Item(0).Value
            FormModificar.txtnombre.Text = dgd.SelectedCells.Item(1).Value
            FormModificar.txtapellido.Text = dgd.SelectedCells.Item(2).Value
            FormModificar.txtdireccion.Text = dgd.SelectedCells.Item(3).Value
            FormModificar.txtemail.Text = dgd.SelectedCells.Item(5).Value
            FormModificar.txttelefono.Text = dgd.SelectedCells.Item(4).Value
            FormModificar.txtdni.Text = dgd.SelectedCells.Item(6).Value
            FormModificar.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class