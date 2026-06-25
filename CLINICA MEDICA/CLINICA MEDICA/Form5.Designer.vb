<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        btnRegresar = New Button()
        txtIdCita = New TextBox()
        txtBuscar = New TextBox()
        cmbPaciente = New ComboBox()
        cmbMedico = New ComboBox()
        cmbEstado = New ComboBox()
        dtpFecha = New DateTimePicker()
        dtpHora = New DateTimePicker()
        dgvCitas = New DataGridView()
        btnSalir = New Button()
        btnUltimo = New Button()
        btnSiguiente = New Button()
        btnAnterior = New Button()
        btnPrimero = New Button()
        btnLimpiar = New Button()
        btnEliminar = New Button()
        btnEditar = New Button()
        btnGuardar = New Button()
        btnNuevo = New Button()
        lblIdCita = New Label()
        lblPaciente = New Label()
        lblMedico = New Label()
        lblFecha = New Label()
        lblHora = New Label()
        lblEstado = New Label()
        lblBuscar = New Label()
        CType(dgvCitas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(305, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(318, 26)
        Label1.TabIndex = 3
        Label1.Text = "Formulario de Citas Medicas"
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(14, 517)
        btnRegresar.Margin = New Padding(3, 4, 3, 4)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(123, 67)
        btnRegresar.TabIndex = 16
        btnRegresar.Text = "Menú Principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' txtIdCita
        ' 
        txtIdCita.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtIdCita.Location = New Point(190, 104)
        txtIdCita.Margin = New Padding(3, 4, 3, 4)
        txtIdCita.Name = "txtIdCita"
        txtIdCita.ReadOnly = True
        txtIdCita.Size = New Size(220, 27)
        txtIdCita.TabIndex = 17
        txtIdCita.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtBuscar.Location = New Point(190, 336)
        txtBuscar.Margin = New Padding(3, 4, 3, 4)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(220, 27)
        txtBuscar.TabIndex = 18
        txtBuscar.TextAlign = HorizontalAlignment.Center
        ' 
        ' cmbPaciente
        ' 
        cmbPaciente.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cmbPaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbPaciente.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbPaciente.FormattingEnabled = True
        cmbPaciente.Location = New Point(190, 143)
        cmbPaciente.Margin = New Padding(3, 4, 3, 4)
        cmbPaciente.Name = "cmbPaciente"
        cmbPaciente.Size = New Size(220, 28)
        cmbPaciente.TabIndex = 19
        ' 
        ' cmbMedico
        ' 
        cmbMedico.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMedico.FormattingEnabled = True
        cmbMedico.Location = New Point(190, 181)
        cmbMedico.Margin = New Padding(3, 4, 3, 4)
        cmbMedico.Name = "cmbMedico"
        cmbMedico.Size = New Size(220, 28)
        cmbMedico.TabIndex = 20
        ' 
        ' cmbEstado
        ' 
        cmbEstado.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cmbEstado.FormattingEnabled = True
        cmbEstado.Items.AddRange(New Object() {"Programada", "Completada", "Cancelada"})
        cmbEstado.Location = New Point(190, 297)
        cmbEstado.Margin = New Padding(3, 4, 3, 4)
        cmbEstado.Name = "cmbEstado"
        cmbEstado.Size = New Size(220, 28)
        cmbEstado.TabIndex = 21
        ' 
        ' dtpFecha
        ' 
        dtpFecha.Format = DateTimePickerFormat.Short
        dtpFecha.Location = New Point(190, 220)
        dtpFecha.Margin = New Padding(3, 4, 3, 4)
        dtpFecha.Name = "dtpFecha"
        dtpFecha.Size = New Size(138, 27)
        dtpFecha.TabIndex = 22
        ' 
        ' dtpHora
        ' 
        dtpHora.Format = DateTimePickerFormat.Time
        dtpHora.Location = New Point(190, 259)
        dtpHora.Margin = New Padding(3, 4, 3, 4)
        dtpHora.Name = "dtpHora"
        dtpHora.ShowUpDown = True
        dtpHora.Size = New Size(138, 27)
        dtpHora.TabIndex = 23
        ' 
        ' dgvCitas
        ' 
        dgvCitas.AllowUserToAddRows = False
        dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCitas.Location = New Point(416, 122)
        dgvCitas.Margin = New Padding(3, 4, 3, 4)
        dgvCitas.Name = "dgvCitas"
        dgvCitas.RowHeadersWidth = 51
        dgvCitas.Size = New Size(761, 263)
        dgvCitas.TabIndex = 24
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(429, 453)
        btnSalir.Margin = New Padding(3, 4, 3, 4)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(86, 31)
        btnSalir.TabIndex = 34
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(815, 553)
        btnUltimo.Margin = New Padding(3, 4, 3, 4)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(86, 31)
        btnUltimo.TabIndex = 33
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(722, 553)
        btnSiguiente.Margin = New Padding(3, 4, 3, 4)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(86, 31)
        btnSiguiente.TabIndex = 32
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(630, 553)
        btnAnterior.Margin = New Padding(3, 4, 3, 4)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(86, 31)
        btnAnterior.TabIndex = 31
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(537, 553)
        btnPrimero.Margin = New Padding(3, 4, 3, 4)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(86, 31)
        btnPrimero.TabIndex = 30
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(815, 393)
        btnLimpiar.Margin = New Padding(3, 4, 3, 4)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(86, 31)
        btnLimpiar.TabIndex = 29
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(630, 393)
        btnEliminar.Margin = New Padding(3, 4, 3, 4)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(86, 31)
        btnEliminar.TabIndex = 28
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(429, 393)
        btnEditar.Margin = New Padding(3, 4, 3, 4)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(86, 31)
        btnEditar.TabIndex = 27
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(210, 393)
        btnGuardar.Margin = New Padding(3, 4, 3, 4)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(86, 31)
        btnGuardar.TabIndex = 26
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(14, 393)
        btnNuevo.Margin = New Padding(3, 4, 3, 4)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(86, 31)
        btnNuevo.TabIndex = 25
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' lblIdCita
        ' 
        lblIdCita.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblIdCita.AutoSize = True
        lblIdCita.Location = New Point(58, 108)
        lblIdCita.Name = "lblIdCita"
        lblIdCita.Size = New Size(92, 20)
        lblIdCita.TabIndex = 35
        lblIdCita.Text = "ID de la cita:"
        lblIdCita.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPaciente
        ' 
        lblPaciente.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblPaciente.AutoSize = True
        lblPaciente.Location = New Point(64, 147)
        lblPaciente.Name = "lblPaciente"
        lblPaciente.Size = New Size(67, 20)
        lblPaciente.TabIndex = 36
        lblPaciente.Text = "Paciente:"
        lblPaciente.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblMedico
        ' 
        lblMedico.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblMedico.AutoSize = True
        lblMedico.Location = New Point(70, 185)
        lblMedico.Name = "lblMedico"
        lblMedico.Size = New Size(62, 20)
        lblMedico.TabIndex = 37
        lblMedico.Text = "Médico:"
        lblMedico.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblFecha
        ' 
        lblFecha.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblFecha.AutoSize = True
        lblFecha.Location = New Point(46, 228)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(115, 20)
        lblFecha.TabIndex = 38
        lblFecha.Text = "Fecha de la cita:"
        lblFecha.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblHora
        ' 
        lblHora.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblHora.AutoSize = True
        lblHora.Location = New Point(51, 267)
        lblHora.Name = "lblHora"
        lblHora.Size = New Size(110, 20)
        lblHora.TabIndex = 39
        lblHora.Text = "Hora de la cita:"
        lblHora.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblEstado
        ' 
        lblEstado.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblEstado.AutoSize = True
        lblEstado.Location = New Point(46, 301)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(122, 20)
        lblEstado.TabIndex = 40
        lblEstado.Text = "Estado de la cita:"
        lblEstado.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblBuscar
        ' 
        lblBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblBuscar.AutoSize = True
        lblBuscar.Location = New Point(64, 340)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(77, 20)
        lblBuscar.TabIndex = 41
        lblBuscar.Text = "Búsqueda:"
        lblBuscar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1189, 600)
        Controls.Add(lblBuscar)
        Controls.Add(lblEstado)
        Controls.Add(lblHora)
        Controls.Add(lblFecha)
        Controls.Add(lblMedico)
        Controls.Add(lblPaciente)
        Controls.Add(lblIdCita)
        Controls.Add(btnSalir)
        Controls.Add(btnUltimo)
        Controls.Add(btnSiguiente)
        Controls.Add(btnAnterior)
        Controls.Add(btnPrimero)
        Controls.Add(btnLimpiar)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnGuardar)
        Controls.Add(btnNuevo)
        Controls.Add(dgvCitas)
        Controls.Add(dtpHora)
        Controls.Add(dtpFecha)
        Controls.Add(cmbEstado)
        Controls.Add(cmbMedico)
        Controls.Add(cmbPaciente)
        Controls.Add(txtBuscar)
        Controls.Add(txtIdCita)
        Controls.Add(btnRegresar)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form5"
        Text = "Form5"
        CType(dgvCitas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents txtIdCita As TextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cmbPaciente As ComboBox
    Friend WithEvents cmbMedico As ComboBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents dtpHora As DateTimePicker
    Friend WithEvents dgvCitas As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents lblIdCita As Label
    Friend WithEvents lblPaciente As Label
    Friend WithEvents lblMedico As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblBuscar As Label
End Class
