<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Label1.Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(239, 21)
        Label1.TabIndex = 3
        Label1.Text = "Módulo de citas médicas"
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(12, 298)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(270, 25)
        btnRegresar.TabIndex = 16
        btnRegresar.Text = "Menú principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' txtIdCita
        ' 
        txtIdCita.Location = New Point(172, 44)
        txtIdCita.Name = "txtIdCita"
        txtIdCita.ReadOnly = True
        txtIdCita.Size = New Size(124, 32)
        txtIdCita.TabIndex = 17
        txtIdCita.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(172, 233)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(124, 32)
        txtBuscar.TabIndex = 18
        txtBuscar.TextAlign = HorizontalAlignment.Center
        ' 
        ' cmbPaciente
        ' 
        cmbPaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbPaciente.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbPaciente.FormattingEnabled = True
        cmbPaciente.Location = New Point(172, 77)
        cmbPaciente.Name = "cmbPaciente"
        cmbPaciente.Size = New Size(124, 28)
        cmbPaciente.TabIndex = 19
        ' 
        ' cmbMedico
        ' 
        cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMedico.FormattingEnabled = True
        cmbMedico.Location = New Point(172, 107)
        cmbMedico.Name = "cmbMedico"
        cmbMedico.Size = New Size(124, 28)
        cmbMedico.TabIndex = 20
        ' 
        ' cmbEstado
        ' 
        cmbEstado.FormattingEnabled = True
        cmbEstado.Items.AddRange(New Object() {"Programada", "Completada", "Cancelada"})
        cmbEstado.Location = New Point(172, 203)
        cmbEstado.Name = "cmbEstado"
        cmbEstado.Size = New Size(124, 28)
        cmbEstado.TabIndex = 21
        ' 
        ' dtpFecha
        ' 
        dtpFecha.Format = DateTimePickerFormat.Short
        dtpFecha.Location = New Point(172, 137)
        dtpFecha.Name = "dtpFecha"
        dtpFecha.Size = New Size(124, 32)
        dtpFecha.TabIndex = 22
        ' 
        ' dtpHora
        ' 
        dtpHora.Format = DateTimePickerFormat.Time
        dtpHora.Location = New Point(172, 170)
        dtpHora.Name = "dtpHora"
        dtpHora.ShowUpDown = True
        dtpHora.Size = New Size(124, 32)
        dtpHora.TabIndex = 23
        ' 
        ' dgvCitas
        ' 
        dgvCitas.AllowUserToAddRows = False
        dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

        dgvCitas.Location = New Point(302, 44)
        dgvCitas.Margin = New Padding(3, 4, 3, 4)
        dgvCitas.Name = "dgvCitas"
        dgvCitas.RowHeadersWidth = 51
        dgvCitas.Size = New Size(725, 216)

        dgvCitas.Location = New Point(472, 47)
        dgvCitas.Margin = New Padding(3, 4, 3, 4)
        dgvCitas.Name = "dgvCitas"
        dgvCitas.RowHeadersWidth = 51
        dgvCitas.Size = New Size(722, 263)

        dgvCitas.TabIndex = 24
        ' 
        ' btnSalir
        ' 

        btnSalir.Location = New Point(288, 298)

        btnSalir.Location = New Point(288, 297)

        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(86, 25)
        btnSalir.TabIndex = 34
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 

        btnUltimo.Location = New Point(958, 298)

        btnUltimo.Location = New Point(898, 423)

        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(69, 25)
        btnUltimo.TabIndex = 33
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 

        btnSiguiente.Location = New Point(958, 267)

        btnSiguiente.Location = New Point(898, 392)

        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(69, 25)
        btnSiguiente.TabIndex = 32
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 

        btnAnterior.Location = New Point(883, 267)

        btnAnterior.Location = New Point(823, 392)

        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(69, 25)
        btnAnterior.TabIndex = 31
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 

        btnPrimero.Location = New Point(883, 298)

        btnPrimero.Location = New Point(823, 423)

        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(69, 25)
        btnPrimero.TabIndex = 30
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(288, 267)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(86, 25)
        btnLimpiar.TabIndex = 29
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(196, 267)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(86, 25)
        btnEliminar.TabIndex = 28
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(104, 267)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(86, 25)
        btnEditar.TabIndex = 27
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(12, 267)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(86, 25)
        btnGuardar.TabIndex = 26
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' lblIdCita
        ' 
        lblIdCita.AutoSize = True
        lblIdCita.Location = New Point(12, 47)
        lblIdCita.Name = "lblIdCita"
        lblIdCita.Size = New Size(202, 21)
        lblIdCita.TabIndex = 35
        lblIdCita.Text = "Identificador de la cita:"
        lblIdCita.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPaciente
        ' 
        lblPaciente.AutoSize = True
        lblPaciente.Location = New Point(12, 80)
        lblPaciente.Name = "lblPaciente"
        lblPaciente.Size = New Size(84, 21)
        lblPaciente.TabIndex = 36
        lblPaciente.Text = "Paciente:"
        lblPaciente.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblMedico
        ' 
        lblMedico.AutoSize = True
        lblMedico.Location = New Point(12, 110)
        lblMedico.Name = "lblMedico"
        lblMedico.Size = New Size(76, 21)
        lblMedico.TabIndex = 37
        lblMedico.Text = "Médico:"
        lblMedico.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.Location = New Point(12, 144)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(144, 21)
        lblFecha.TabIndex = 38
        lblFecha.Text = "Fecha de la cita:"
        lblFecha.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblHora
        ' 
        lblHora.AutoSize = True
        lblHora.Location = New Point(12, 177)
        lblHora.Name = "lblHora"
        lblHora.Size = New Size(137, 21)
        lblHora.TabIndex = 39
        lblHora.Text = "Hora de la cita:"
        lblHora.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblEstado
        ' 
        lblEstado.AutoSize = True
        lblEstado.Location = New Point(12, 206)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(151, 21)
        lblEstado.TabIndex = 40
        lblEstado.Text = "Estado de la cita:"
        lblEstado.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Location = New Point(12, 236)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(95, 21)
        lblBuscar.TabIndex = 41
        lblBuscar.Text = "Búsqueda:"
        lblBuscar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font

        ClientSize = New Size(1039, 334)

        ClientSize = New Size(1206, 600)

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
        Font = New Font("Lucida Sans Unicode", 9.75F)
        Name = "Form5"
        Text = "Citas médicas"
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
    Friend WithEvents lblIdCita As Label
    Friend WithEvents lblPaciente As Label
    Friend WithEvents lblMedico As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblBuscar As Label
End Class