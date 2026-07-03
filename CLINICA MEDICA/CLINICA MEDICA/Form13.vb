Imports System.Data

Public Class Form13

    ' Variable global para manipular los datos en la tabla
    Dim tablaDetalles As New DataTable
    Dim posicion As Integer = 0

    ' 1. EVENTO LOAD: Se dispara al abrir la ventana por primera vez
    Private Sub FormDetalleFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Bloqueamos la tabla para que el usuario no edite directamente (por seguridad financiera)
        dgvDetalles.AllowUserToAddRows = False
        dgvDetalles.ReadOnly = True
        dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDetalles.MultiSelect = False

        CargarTabla()
    End Sub

    ' 2. EVENTO VISIBLE CHANGED: Refresca los datos automáticamente si vienes de otra ventana
    Private Sub FormDetalleFactura_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            CargarTabla()
        End If
    End Sub

    ' 3. MÉTODO PRINCIPAL: Llama a tu DAO y llena el DataGridView
    Private Sub CargarTabla()
        Try
            ' Aquí estamos usando el DAO que TÚ ya creaste
            Dim dao As New DetalleFacturaDAO()

            ' NOTA: Cambia "Mostrar()" por el nombre real de la función en tu DAO si le pusiste diferente (ej. Listar, ObtenerTodos)
            tablaDetalles = dao.Mostrar()

            dgvDetalles.DataSource = tablaDetalles
            FormatearColumnas()
        Catch ex As Exception
            MessageBox.Show("Error crítico al cargar los detalles de facturación: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 4. ESTÉTICA: Nombra bien las columnas y les da formato de dinero
    Private Sub FormatearColumnas()
        If dgvDetalles.Columns.Contains("id_detalle_factura") Then
            dgvDetalles.Columns("id_detalle_factura").HeaderText = "Código Detalle"
            dgvDetalles.Columns("id_detalle_factura").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        End If

        If dgvDetalles.Columns.Contains("id_factura") Then
            dgvDetalles.Columns("id_factura").HeaderText = "N° Factura"
            dgvDetalles.Columns("id_factura").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        End If

        If dgvDetalles.Columns.Contains("id_medicamento") Then
            dgvDetalles.Columns("id_medicamento").HeaderText = "Código Med."
            dgvDetalles.Columns("id_medicamento").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        End If

        If dgvDetalles.Columns.Contains("cantidad") Then
            dgvDetalles.Columns("cantidad").HeaderText = "Cantidad"
            dgvDetalles.Columns("cantidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        End If

        ' Formato C2 le pone automáticamente el símbolo de moneda y dos decimales
        If dgvDetalles.Columns.Contains("precio_unitario") Then
            dgvDetalles.Columns("precio_unitario").HeaderText = "Precio Unitario"
            dgvDetalles.Columns("precio_unitario").DefaultCellStyle.Format = "C2"
        End If

        If dgvDetalles.Columns.Contains("subtotal") Then
            dgvDetalles.Columns("subtotal").HeaderText = "Subtotal Neto"
            dgvDetalles.Columns("subtotal").DefaultCellStyle.Format = "C2"
        End If
    End Sub

    ' 5. NAVEGACIÓN EN LA TABLA
    Private Sub dgvDetalles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalles.CellClick
        If e.RowIndex >= 0 Then
            posicion = e.RowIndex
            dgvDetalles.Rows(posicion).Selected = True
        End If
    End Sub

    ' 6. BOTÓN DE SALIDA OBLIGATORIO
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        ' Regresamos al menú principal (Cambia Form1 por el nombre real de tu menú si es diferente)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalles.CellContentClick

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    ' --- BOTONES DE NAVEGACIÓN ---

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If dgvDetalles.Rows.Count > 0 Then
            posicion = 0
            MostrarRegistro()
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If dgvDetalles.Rows.Count > 0 Then
            If posicion > 0 Then
                posicion -= 1
                MostrarRegistro()
            Else
                MessageBox.Show("Ya está en el primer registro.", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If dgvDetalles.Rows.Count > 0 Then
            If posicion < dgvDetalles.Rows.Count - 1 Then
                posicion += 1
                MostrarRegistro()
            Else
                MessageBox.Show("Ya está en el último registro.", "Navegación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If dgvDetalles.Rows.Count > 0 Then
            posicion = dgvDetalles.Rows.Count - 1
            MostrarRegistro()
        End If
    End Sub

    ' --- MÉTODO PARA ACTUALIZAR LA VISTA ---

    Private Sub MostrarRegistro()

        If dgvDetalles.Rows.Count > 0 AndAlso posicion >= 0 AndAlso posicion < dgvDetalles.Rows.Count Then

            ' 1. Limpiamos cualquier selección previa en la tabla
            dgvDetalles.ClearSelection()

            ' 2. Seleccionamos visualmente la fila en la nueva posición
            dgvDetalles.Rows(posicion).Selected = True

            ' 3. Hacemos que la tabla baje o suba automáticamente hacia la fila seleccionada
            dgvDetalles.FirstDisplayedScrollingRowIndex = posicion


        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class