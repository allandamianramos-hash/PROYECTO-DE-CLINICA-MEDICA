Imports Npgsql

Public Class Form10

    Dim conexionString As String = "Server=ep-holy-sea-atf4gaz7-pooler.c-9.us-east-1.aws.neon.tech; Port=5432; Database=neondb; User Id=neondb_owner; Password=npg_8KIjvXm6uzAi; SSL Mode=Require; Trust Server Certificate=True;"

    ' El precio fijo de tu consulta clínica
    Dim precioFijoConsulta As Decimal = 500.0
    Dim catalogoMedicamentos As New Dictionary(Of String, Decimal)

    ' Esta lista "invisible" recordará las medicinas que el usuario ya seleccionó
    Dim medicinasSeleccionadas As New List(Of String)
    ' Este candado evita errores cuando la lista se recarga por la búsqueda
    Dim actualizandoLista As Boolean = False

    Private Sub FormPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdFactura.ReadOnly = True
        txtMontoTotal.ReadOnly = True

        ' --- AGREGAR ESTO PARA LLENAR LOS COMBOBOX AUTOMÁTICAMENTE ---
        ' Opciones de Método de Pago
        cmbMetodoPago.Items.Clear()
        cmbMetodoPago.Items.Add("Efectivo")
        cmbMetodoPago.Items.Add("Tarjeta")
        cmbMetodoPago.Items.Add("Transferencia")

        ' Opciones de Estado de Pago
        cmbEstadoPago.Items.Clear()
        cmbEstadoPago.Items.Add("Pagado")
        cmbEstadoPago.Items.Add("Pendiente")
        ' -------------------------------------------------------------

        ' 1. Cargar las facturas en el DataGridView
        Try
            Dim dao As New FacturaDAO()
            dgvFacturas.DataSource = dao.Mostrar()
        Catch ex As Exception
            MessageBox.Show("Error al cargar la tabla facturas: " & ex.Message)
        End Try

        ' 2. Cargar los medicamentos
        CargarMedicamentosDesdeBD()

        ' 3. Mostrar medicamentos visualmente y calcular total base
        ActualizarVistaMedicamentos("")
        CalcularTotal()
    End Sub
    ' 🌟 Magia pura: Leemos de la base de datos y llenamos nuestro catálogo interno
    Private Sub CargarMedicamentosDesdeBD()
        catalogoMedicamentos.Clear()

        Dim query As String = "SELECT nombre_generico, precio FROM medicamentos"

        Using conn As New NpgsqlConnection(conexionString)
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim nombreMedicina As String = reader("nombre_generico").ToString()
                            Dim precioMedicina As Decimal = Convert.ToDecimal(reader("precio"))

                            ' 🛡️ Solo lo agrega al catálogo si no está repetido
                            If Not catalogoMedicamentos.ContainsKey(nombreMedicina) Then
                                catalogoMedicamentos.Add(nombreMedicina, precioMedicina)
                            End If
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al conectar con la tabla de medicamentos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' --- LÓGICA DE BÚSQUEDA Y SELECCIÓN DE MEDICAMENTOS ---

    Private Sub ActualizarVistaMedicamentos(filtro As String)
        ' Activamos el candado para que no se dispare el evento ItemCheck por accidente
        actualizandoLista = True

        clbMedicamentos.Items.Clear()

        ' Revisamos todo nuestro catálogo original
        For Each medicina In catalogoMedicamentos
            If medicina.Key.ToLower().Contains(filtro.ToLower()) Then
                ' Lo agregamos a la cajita visual
                clbMedicamentos.Items.Add(medicina.Key)

                ' Si esta medicina estaba en nuestra memoria de seleccionadas, le ponemos su palomita
                If medicinasSeleccionadas.Contains(medicina.Key) Then
                    clbMedicamentos.SetItemChecked(clbMedicamentos.Items.Count - 1, True)
                End If
            End If
        Next

        actualizandoLista = False
    End Sub

    Private Sub txtBuscarMedicamento_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarMedicamento.TextChanged
        ActualizarVistaMedicamentos(txtBuscarMedicamento.Text.Trim())
    End Sub

    ' Disparador: se ejecuta cada que pones o quitas una palomita
    Private Sub clbMedicamentos_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbMedicamentos.ItemCheck
        ' Si el candado está activo (porque estamos buscando), ignoramos
        If actualizandoLista Then Return

        Dim nombreMedicina As String = clbMedicamentos.Items(e.Index).ToString()

        ' Guardamos o borramos de la memoria invisible
        If e.NewValue = CheckState.Checked Then
            If Not medicinasSeleccionadas.Contains(nombreMedicina) Then
                medicinasSeleccionadas.Add(nombreMedicina)
            End If
        Else
            If medicinasSeleccionadas.Contains(nombreMedicina) Then
                medicinasSeleccionadas.Remove(nombreMedicina)
            End If
        End If

        ' Mandamos recalcular
        BeginInvoke(New MethodInvoker(AddressOf CalcularTotal))
    End Sub

    ' Sumamos leyendo nuestra memoria, no la pantalla
    Private Sub CalcularTotal()
        Dim totalAPagar As Decimal = precioFijoConsulta

        For Each medicina In medicinasSeleccionadas
            totalAPagar += catalogoMedicamentos(medicina)
        Next

        txtMontoTotal.Text = totalAPagar.ToString("0.00")
    End Sub


    ' --- BOTONES PRINCIPALES ---

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim nuevaFactura As New Factura()

            nuevaFactura.IdConsulta = Convert.ToInt32(Val(cmbConsulta.Text))
            nuevaFactura.MontoTotal = Convert.ToDecimal(txtMontoTotal.Text)
            nuevaFactura.FechaPago = dtpFechaPago.Value
            nuevaFactura.MetodoPago = cmbMetodoPago.Text
            nuevaFactura.EstadoPago = cmbEstadoPago.Text

            Dim dao As New FacturaDAO()
            dao.Insertar(nuevaFactura)

            MessageBox.Show("¡Pago registrado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refrescar pantalla
            LimpiarCampos()
            dgvFacturas.DataSource = dao.Mostrar()

        Catch ex As Exception
            MessageBox.Show("Error al guardar la factura: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If String.IsNullOrWhiteSpace(txtIdFactura.Text) Then
            MessageBox.Show("Por favor, seleccione una factura de la tabla inferior para editarla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim f As New Factura()
            f.IdFactura = Convert.ToInt32(txtIdFactura.Text)
            f.IdConsulta = Convert.ToInt32(Val(cmbConsulta.Text))
            f.MontoTotal = Convert.ToDecimal(txtMontoTotal.Text)
            f.FechaPago = dtpFechaPago.Value
            f.MetodoPago = cmbMetodoPago.Text
            f.EstadoPago = cmbEstadoPago.Text

            Dim dao As New FacturaDAO()
            dao.Actualizar(f)

            MessageBox.Show("¡La factura se actualizó correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimpiarCampos()
            dgvFacturas.DataSource = dao.Mostrar()

        Catch ex As Exception
            MessageBox.Show("Error al editar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrWhiteSpace(txtIdFactura.Text) Then
            MessageBox.Show("Por favor, seleccione una factura de la tabla inferior para eliminarla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar permanentemente esta factura?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Try
                Dim idFactura As Integer = Convert.ToInt32(txtIdFactura.Text)

                Dim dao As New FacturaDAO()
                dao.Eliminar(idFactura)

                MessageBox.Show("Factura eliminada del sistema.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LimpiarCampos()
                dgvFacturas.DataSource = dao.Mostrar()

            Catch ex As Exception
                MessageBox.Show("Error al intentar eliminar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        txtIdFactura.Clear()
        cmbConsulta.SelectedIndex = -1
        cmbConsulta.Text = ""
        cmbMetodoPago.SelectedIndex = -1
        cmbEstadoPago.SelectedIndex = -1
        dtpFechaPago.Value = DateTime.Now
        txtBuscarMedicamento.Clear()

        ' Vaciamos la memoria
        medicinasSeleccionadas.Clear()

        ' Refrescamos la vista (esto desmarcará todo porque la memoria está vacía)
        ActualizarVistaMedicamentos("")

        CalcularTotal()

        cmbConsulta.Focus()
    End Sub

    ' --- MANEJO DE LA TABLA ---

    Private Sub dgvFacturas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFacturas.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim fila As DataGridViewRow = dgvFacturas.Rows(e.RowIndex)

                txtIdFactura.Text = fila.Cells("id_factura").Value.ToString()
                cmbConsulta.Text = fila.Cells("id_consulta").Value.ToString()
                cmbMetodoPago.Text = fila.Cells("metodo_pago").Value.ToString()
                cmbEstadoPago.Text = fila.Cells("estado_pago").Value.ToString()

                If Not IsDBNull(fila.Cells("fecha_pago").Value) Then
                    dtpFechaPago.Value = Convert.ToDateTime(fila.Cells("fecha_pago").Value)
                End If

                txtMontoTotal.Text = fila.Cells("monto_total").Value.ToString()

                ' Al seleccionar una factura vieja, limpiamos los medicamentos seleccionados temporalmente
                medicinasSeleccionadas.Clear()
                ActualizarVistaMedicamentos("")

            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub CargarConsultasPendientes()
        cmbConsulta.Items.Clear()

        ' Query que trae los IDs de consultas que NO están en la tabla de facturas
        Dim query As String = "
            SELECT id_consulta 
            FROM consultas 
            WHERE id_consulta NOT IN (SELECT id_consulta FROM pagos_facturas)
            ORDER BY id_consulta ASC"

        Using conn As New NpgsqlConnection(conexionString)
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Agregamos el ID al ComboBox
                            cmbConsulta.Items.Add(reader("id_consulta").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar las consultas pendientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

End Class