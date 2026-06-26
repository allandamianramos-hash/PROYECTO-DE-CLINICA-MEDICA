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
        Label1.Size = New Size(156, 16)
        Label1.TabIndex = 2
        Label1.Text = "Módulo de pacientes"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtIdPaciente
        ' 
        txtIdPaciente.Location = New Point(189, 40)
        txtIdPaciente.Name = "txtIdPaciente"
        txtIdPaciente.ReadOnly = True
        txtIdPaciente.Size = New Size(114, 27)
        txtIdPaciente.TabIndex = 3
        txtIdPaciente.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(189, 73)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(114, 27)
        txtNombre.TabIndex = 4
        txtNombre.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(189, 106)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(114, 27)
        txtApellido.TabIndex = 5
        txtApellido.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(189, 202)
        txtDireccion.Multiline = True
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(114, 24)
        txtDireccion.TabIndex = 6
        txtDireccion.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(189, 232)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(114, 27)
        txtTelefono.TabIndex = 7
        txtTelefono.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(189, 265)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(114, 27)
        txtCorreo.TabIndex = 8
        txtCorreo.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(189, 298)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(114, 27)
        txtBuscar.TabIndex = 9
        txtBuscar.TextAlign = HorizontalAlignment.Center
        ' 
        ' dtpFechaNac
        ' 
        dtpFechaNac.Format = DateTimePickerFormat.Short
        dtpFechaNac.Location = New Point(189, 139)
        dtpFechaNac.Name = "dtpFechaNac"
        dtpFechaNac.Size = New Size(114, 27)
        dtpFechaNac.TabIndex = 10
        ' 
        ' cmbSexo
        ' 
        cmbSexo.FormattingEnabled = True
        cmbSexo.Items.AddRange(New Object() {"M", "F"})
        cmbSexo.Location = New Point(189, 172)
        cmbSexo.Name = "cmbSexo"
        cmbSexo.Size = New Size(114, 24)
        cmbSexo.TabIndex = 11
        ' 
        ' dgvPacientes
        ' 
        dgvPacientes.AllowUserToAddRows = False
        dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPacientes.Location = New Point(317, 40)
        dgvPacientes.Name = "dgvPacientes"
        dgvPacientes.RowHeadersWidth = 51
        dgvPacientes.Size = New Size(834, 285)
        dgvPacientes.TabIndex = 12
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(12, 331)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(112, 25)
        btnGuardar.TabIndex = 14
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(130, 331)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(112, 25)
        btnEditar.TabIndex = 15
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(248, 331)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(112, 25)
        btnEliminar.TabIndex = 16
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(366, 331)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(112, 25)
        btnLimpiar.TabIndex = 17
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(921, 362)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(112, 25)
        btnPrimero.TabIndex = 18
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(921, 331)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(112, 25)
        btnAnterior.TabIndex = 19
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(1039, 331)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(112, 25)
        btnSiguiente.TabIndex = 20
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(1039, 362)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(112, 25)
        btnUltimo.TabIndex = 21
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(12, 362)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(348, 25)
        btnRegresar.TabIndex = 22
        btnRegresar.Text = "Menú principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(484, 331)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(112, 25)
        btnSalir.TabIndex = 23
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' lblIdPaciente
        ' 
        lblIdPaciente.AutoSize = True
        lblIdPaciente.Location = New Point(12, 43)
        lblIdPaciente.Name = "lblIdPaciente"
        lblIdPaciente.Size = New Size(171, 16)
        lblIdPaciente.TabIndex = 24
        lblIdPaciente.Text = "Identificador del paciente:"
        lblIdPaciente.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(12, 76)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(61, 16)
        lblNombre.TabIndex = 25
        lblNombre.Text = "Nombre:"
        lblNombre.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblApellido
        ' 
        lblApellido.AutoSize = True
        lblApellido.Location = New Point(12, 109)
        lblApellido.Name = "lblApellido"
        lblApellido.Size = New Size(63, 16)
        lblApellido.TabIndex = 26
        lblApellido.Text = "Apellido:"
        lblApellido.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblFechaNac
        ' 
        lblFechaNac.AutoSize = True
        lblFechaNac.Location = New Point(12, 146)
        lblFechaNac.Name = "lblFechaNac"
        lblFechaNac.Size = New Size(140, 16)
        lblFechaNac.TabIndex = 27
        lblFechaNac.Text = "Fecha de nacimiento:"
        lblFechaNac.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSexo
        ' 
        lblSexo.AutoSize = True
        lblSexo.Location = New Point(12, 175)
        lblSexo.Name = "lblSexo"
        lblSexo.Size = New Size(41, 16)
        lblSexo.TabIndex = 28
        lblSexo.Text = "Sexo:"
        lblSexo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDireccion
        ' 
        lblDireccion.AutoSize = True
        lblDireccion.Location = New Point(12, 205)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(71, 16)
        lblDireccion.TabIndex = 29
        lblDireccion.Text = "Dirección:"
        lblDireccion.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTelefono
        ' 
        lblTelefono.AutoSize = True
        lblTelefono.Location = New Point(12, 235)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New Size(66, 16)
        lblTelefono.TabIndex = 30
        lblTelefono.Text = "Teléfono:"
        lblTelefono.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCorreo
        ' 
        lblCorreo.AutoSize = True
        lblCorreo.Location = New Point(12, 268)
        lblCorreo.Name = "lblCorreo"
        lblCorreo.Size = New Size(127, 16)
        lblCorreo.TabIndex = 31
        lblCorreo.Text = "Correo electrónico:"
        lblCorreo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Location = New Point(12, 301)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(71, 16)
        lblBuscar.TabIndex = 32
        lblBuscar.Text = "Búsqueda:"
        lblBuscar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frm2
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1163, 398)
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
