<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm2
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
        txtIdPaciente = New TextBox()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        txtDireccion = New TextBox()
        txtTelefono = New TextBox()
        txtCorreo = New TextBox()
        txtBuscar = New TextBox()
        dtpFechaNac = New DateTimePicker()
        cmbSexo = New ComboBox()
        dgvPacientes = New DataGridView()
        btnGuardar = New Button()
        btnEditar = New Button()
        btnEliminar = New Button()
        btnLimpiar = New Button()
        btnPrimero = New Button()
        btnAnterior = New Button()
        btnSiguiente = New Button()
        btnUltimo = New Button()
        btnRegresar = New Button()
        btnSalir = New Button()
        lblIdPaciente = New Label()
        lblNombre = New Label()
        lblApellido = New Label()
        lblFechaNac = New Label()
        lblSexo = New Label()
        lblDireccion = New Label()
        lblTelefono = New Label()
        lblCorreo = New Label()
        lblBuscar = New Label()
        CType(dgvPacientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 21)
        Label1.TabIndex = 2
        Label1.Text = "Módulo de pacientes"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtIdPaciente
        ' 
        txtIdPaciente.Location = New Point(189, 319)
        txtIdPaciente.Name = "txtIdPaciente"
        txtIdPaciente.ReadOnly = True
        txtIdPaciente.Size = New Size(165, 32)
        txtIdPaciente.TabIndex = 3
        txtIdPaciente.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(189, 352)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(165, 32)
        txtNombre.TabIndex = 4
        txtNombre.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(189, 385)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(165, 32)
        txtApellido.TabIndex = 5
        txtApellido.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(189, 481)
        txtDireccion.Multiline = True
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(165, 24)
        txtDireccion.TabIndex = 6
        txtDireccion.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(189, 511)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(165, 32)
        txtTelefono.TabIndex = 7
        txtTelefono.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(189, 544)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(165, 32)
        txtCorreo.TabIndex = 8
        txtCorreo.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(189, 577)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(165, 32)
        txtBuscar.TabIndex = 9
        txtBuscar.TextAlign = HorizontalAlignment.Center
        ' 
        ' dtpFechaNac
        ' 
        dtpFechaNac.Format = DateTimePickerFormat.Short
        dtpFechaNac.Location = New Point(189, 418)
        dtpFechaNac.Name = "dtpFechaNac"
        dtpFechaNac.Size = New Size(165, 32)
        dtpFechaNac.TabIndex = 10
        ' 
        ' cmbSexo
        ' 
        cmbSexo.FormattingEnabled = True
        cmbSexo.Items.AddRange(New Object() {"M", "F"})
        cmbSexo.Location = New Point(189, 451)
        cmbSexo.Name = "cmbSexo"
        cmbSexo.Size = New Size(165, 28)
        cmbSexo.TabIndex = 11
        ' 
        ' dgvPacientes
        ' 
        dgvPacientes.AllowUserToAddRows = False
        dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPacientes.Location = New Point(12, 28)
        dgvPacientes.Name = "dgvPacientes"
        dgvPacientes.RowHeadersWidth = 51
        dgvPacientes.Size = New Size(1139, 285)
        dgvPacientes.TabIndex = 12
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(360, 319)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(112, 53)
        btnGuardar.TabIndex = 14
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(478, 319)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(112, 53)
        btnEditar.TabIndex = 15
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(596, 319)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(112, 53)
        btnEliminar.TabIndex = 16
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(714, 319)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(112, 53)
        btnLimpiar.TabIndex = 17
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(921, 378)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(112, 53)
        btnPrimero.TabIndex = 18
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(921, 319)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(112, 53)
        btnAnterior.TabIndex = 19
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(1039, 319)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(112, 53)
        btnSiguiente.TabIndex = 20
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(1039, 378)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(112, 53)
        btnUltimo.TabIndex = 21
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(360, 378)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(230, 53)
        btnRegresar.TabIndex = 22
        btnRegresar.Text = "Menú principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(596, 378)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(230, 53)
        btnSalir.TabIndex = 23
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' lblIdPaciente
        ' 
        lblIdPaciente.AutoSize = True
        lblIdPaciente.Location = New Point(12, 322)
        lblIdPaciente.Name = "lblIdPaciente"
        lblIdPaciente.Size = New Size(138, 21)
        lblIdPaciente.TabIndex = 24
        lblIdPaciente.Text = "Id del paciente:"
        lblIdPaciente.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(12, 355)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(83, 21)
        lblNombre.TabIndex = 25
        lblNombre.Text = "Nombre:"
        lblNombre.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblApellido
        ' 
        lblApellido.AutoSize = True
        lblApellido.Location = New Point(12, 388)
        lblApellido.Name = "lblApellido"
        lblApellido.Size = New Size(85, 21)
        lblApellido.TabIndex = 26
        lblApellido.Text = "Apellido:"
        lblApellido.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblFechaNac
        ' 
        lblFechaNac.AutoSize = True
        lblFechaNac.Location = New Point(-3, 426)
        lblFechaNac.Name = "lblFechaNac"
        lblFechaNac.Size = New Size(186, 21)
        lblFechaNac.TabIndex = 27
        lblFechaNac.Text = "Fecha de nacimiento:"
        lblFechaNac.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSexo
        ' 
        lblSexo.AutoSize = True
        lblSexo.Location = New Point(12, 454)
        lblSexo.Name = "lblSexo"
        lblSexo.Size = New Size(55, 21)
        lblSexo.TabIndex = 28
        lblSexo.Text = "Sexo:"
        lblSexo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDireccion
        ' 
        lblDireccion.AutoSize = True
        lblDireccion.Location = New Point(12, 484)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(94, 21)
        lblDireccion.TabIndex = 29
        lblDireccion.Text = "Dirección:"
        lblDireccion.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTelefono
        ' 
        lblTelefono.AutoSize = True
        lblTelefono.Location = New Point(12, 514)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New Size(89, 21)
        lblTelefono.TabIndex = 30
        lblTelefono.Text = "Teléfono:"
        lblTelefono.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCorreo
        ' 
        lblCorreo.AutoSize = True
        lblCorreo.Location = New Point(12, 547)
        lblCorreo.Name = "lblCorreo"
        lblCorreo.Size = New Size(171, 21)
        lblCorreo.TabIndex = 31
        lblCorreo.Text = "Correo electrónico:"
        lblCorreo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Location = New Point(12, 580)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(95, 21)
        lblBuscar.TabIndex = 32
        lblBuscar.Text = "Búsqueda:"
        lblBuscar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frm2
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1163, 619)
        Controls.Add(lblBuscar)
        Controls.Add(lblCorreo)
        Controls.Add(lblTelefono)
        Controls.Add(lblDireccion)
        Controls.Add(lblSexo)
        Controls.Add(lblFechaNac)
        Controls.Add(lblApellido)
        Controls.Add(lblNombre)
        Controls.Add(lblIdPaciente)
        Controls.Add(btnSalir)
        Controls.Add(btnRegresar)
        Controls.Add(btnUltimo)
        Controls.Add(btnSiguiente)
        Controls.Add(btnAnterior)
        Controls.Add(btnPrimero)
        Controls.Add(btnLimpiar)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnGuardar)
        Controls.Add(dgvPacientes)
        Controls.Add(cmbSexo)
        Controls.Add(dtpFechaNac)
        Controls.Add(txtBuscar)
        Controls.Add(txtCorreo)
        Controls.Add(txtTelefono)
        Controls.Add(txtDireccion)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Controls.Add(txtIdPaciente)
        Controls.Add(Label1)
        Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frm2"
        Text = "Pacientes"
        CType(dgvPacientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdPaciente As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents dgvPacientes As DataGridView
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblIdPaciente As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblBuscar As Label
End Class
