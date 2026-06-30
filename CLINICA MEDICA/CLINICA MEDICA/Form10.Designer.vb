<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtIdFactura = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        cmbConsulta = New ComboBox()
        dtpFechaPago = New DateTimePicker()
        Label3 = New Label()
        cmbMetodoPago = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        cmbEstadoPago = New ComboBox()
        txtMontoTotal = New TextBox()
        Label6 = New Label()
        dgvFacturas = New DataGridView()
        clbMedicamentos = New CheckedListBox()
        Label7 = New Label()
        Label8 = New Label()
        btnUltimo = New Button()
        btnSiguiente = New Button()
        btnAnterior = New Button()
        btnPrimero = New Button()
        btnSalir = New Button()
        btnLimpiar = New Button()
        btnEliminar = New Button()
        btnEditar = New Button()
        btnGuardar = New Button()
        btnRegresar = New Button()
        txtBuscarMedicamento = New TextBox()
        Label9 = New Label()
        CType(dgvFacturas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtIdFactura
        ' 
        txtIdFactura.Location = New Point(194, 323)
        txtIdFactura.Margin = New Padding(4, 2, 4, 2)
        txtIdFactura.Name = "txtIdFactura"
        txtIdFactura.ReadOnly = True
        txtIdFactura.Size = New Size(189, 27)
        txtIdFactura.TabIndex = 0
        txtIdFactura.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 326)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(173, 16)
        Label1.TabIndex = 1
        Label1.Text = "Identificador de la factura:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 418)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 16)
        Label2.TabIndex = 2
        Label2.Text = "Consulta:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cmbConsulta
        ' 
        cmbConsulta.FormattingEnabled = True
        cmbConsulta.Location = New Point(194, 415)
        cmbConsulta.Margin = New Padding(4, 2, 4, 2)
        cmbConsulta.Name = "cmbConsulta"
        cmbConsulta.Size = New Size(189, 24)
        cmbConsulta.TabIndex = 4
        ' 
        ' dtpFechaPago
        ' 
        dtpFechaPago.CustomFormat = "dd/MM/yyyy - HH:mm:ss"
        dtpFechaPago.Format = DateTimePickerFormat.Custom
        dtpFechaPago.Location = New Point(194, 499)
        dtpFechaPago.Margin = New Padding(4, 2, 4, 2)
        dtpFechaPago.Name = "dtpFechaPago"
        dtpFechaPago.Size = New Size(189, 27)
        dtpFechaPago.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 506)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 16)
        Label3.TabIndex = 6
        Label3.Text = "Fecha de pago:"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cmbMetodoPago
        ' 
        cmbMetodoPago.FormattingEnabled = True
        cmbMetodoPago.Location = New Point(194, 443)
        cmbMetodoPago.Margin = New Padding(4, 2, 4, 2)
        cmbMetodoPago.Name = "cmbMetodoPago"
        cmbMetodoPago.Size = New Size(189, 24)
        cmbMetodoPago.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 446)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 16)
        Label4.TabIndex = 8
        Label4.Text = "Método de pago:"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 474)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(107, 16)
        Label5.TabIndex = 9
        Label5.Text = "Estado de pago:"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cmbEstadoPago
        ' 
        cmbEstadoPago.FormattingEnabled = True
        cmbEstadoPago.Location = New Point(194, 471)
        cmbEstadoPago.Margin = New Padding(4, 2, 4, 2)
        cmbEstadoPago.Name = "cmbEstadoPago"
        cmbEstadoPago.Size = New Size(189, 24)
        cmbEstadoPago.TabIndex = 10
        ' 
        ' txtMontoTotal
        ' 
        txtMontoTotal.Location = New Point(194, 530)
        txtMontoTotal.Margin = New Padding(4, 2, 4, 2)
        txtMontoTotal.Name = "txtMontoTotal"
        txtMontoTotal.ReadOnly = True
        txtMontoTotal.Size = New Size(189, 27)
        txtMontoTotal.TabIndex = 12
        txtMontoTotal.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(13, 533)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 16)
        Label6.TabIndex = 13
        Label6.Text = "Monto total:"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvFacturas
        ' 
        dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFacturas.Location = New Point(13, 27)
        dgvFacturas.Margin = New Padding(4, 2, 4, 2)
        dgvFacturas.Name = "dgvFacturas"
        dgvFacturas.RowHeadersWidth = 51
        dgvFacturas.Size = New Size(1161, 292)
        dgvFacturas.TabIndex = 14
        ' 
        ' clbMedicamentos
        ' 
        clbMedicamentos.FormattingEnabled = True
        clbMedicamentos.Location = New Point(194, 354)
        clbMedicamentos.Margin = New Padding(4, 2, 4, 2)
        clbMedicamentos.Name = "clbMedicamentos"
        clbMedicamentos.Size = New Size(189, 26)
        clbMedicamentos.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(13, 9)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(146, 16)
        Label7.TabIndex = 16
        Label7.Text = "Módulo de facturas"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(13, 359)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(173, 16)
        Label8.TabIndex = 17
        Label8.Text = "Medicamentos adquiridos:"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(1075, 388)
        btnUltimo.Margin = New Padding(4, 4, 4, 4)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(99, 55)
        btnUltimo.TabIndex = 54
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(1075, 325)
        btnSiguiente.Margin = New Padding(4, 4, 4, 4)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(99, 55)
        btnSiguiente.TabIndex = 53
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(968, 325)
        btnAnterior.Margin = New Padding(4, 4, 4, 4)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(99, 55)
        btnAnterior.TabIndex = 52
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(968, 388)
        btnPrimero.Margin = New Padding(4, 4, 4, 4)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(99, 55)
        btnPrimero.TabIndex = 51
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(605, 388)
        btnSalir.Margin = New Padding(4, 4, 4, 4)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(206, 55)
        btnSalir.TabIndex = 50
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(712, 325)
        btnLimpiar.Margin = New Padding(4, 4, 4, 4)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(99, 55)
        btnLimpiar.TabIndex = 49
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(605, 325)
        btnEliminar.Margin = New Padding(4, 4, 4, 4)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(99, 55)
        btnEliminar.TabIndex = 48
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(498, 325)
        btnEditar.Margin = New Padding(4, 4, 4, 4)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(99, 55)
        btnEditar.TabIndex = 47
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(391, 325)
        btnGuardar.Margin = New Padding(4, 4, 4, 4)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(99, 55)
        btnGuardar.TabIndex = 46
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(391, 388)
        btnRegresar.Margin = New Padding(4, 4, 4, 4)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(206, 55)
        btnRegresar.TabIndex = 45
        btnRegresar.Text = "Menú principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' txtBuscarMedicamento
        ' 
        txtBuscarMedicamento.Location = New Point(194, 384)
        txtBuscarMedicamento.Margin = New Padding(4, 2, 4, 2)
        txtBuscarMedicamento.Name = "txtBuscarMedicamento"
        txtBuscarMedicamento.Size = New Size(189, 27)
        txtBuscarMedicamento.TabIndex = 55
        txtBuscarMedicamento.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(13, 393)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(141, 16)
        Label9.TabIndex = 56
        Label9.Text = "Buscar medicamento:"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form10
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1187, 573)
        Controls.Add(Label9)
        Controls.Add(txtBuscarMedicamento)
        Controls.Add(btnUltimo)
        Controls.Add(btnSiguiente)
        Controls.Add(btnAnterior)
        Controls.Add(btnPrimero)
        Controls.Add(btnSalir)
        Controls.Add(btnLimpiar)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnGuardar)
        Controls.Add(btnRegresar)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(clbMedicamentos)
        Controls.Add(dgvFacturas)
        Controls.Add(Label6)
        Controls.Add(txtMontoTotal)
        Controls.Add(cmbEstadoPago)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(cmbMetodoPago)
        Controls.Add(Label3)
        Controls.Add(dtpFechaPago)
        Controls.Add(cmbConsulta)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtIdFactura)
        Font = New Font("Lucida Sans Unicode", 9.75F)
        Margin = New Padding(4, 2, 4, 2)
        Name = "Form10"
        Text = "Facturas"
        CType(dgvFacturas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIdFactura As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbConsulta As ComboBox
    Friend WithEvents dtpFechaPago As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbMetodoPago As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbEstadoPago As ComboBox
    Friend WithEvents txtMontoTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvFacturas As DataGridView
    Friend WithEvents clbMedicamentos As CheckedListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents txtBuscarMedicamento As TextBox
    Friend WithEvents Label9 As Label
End Class
