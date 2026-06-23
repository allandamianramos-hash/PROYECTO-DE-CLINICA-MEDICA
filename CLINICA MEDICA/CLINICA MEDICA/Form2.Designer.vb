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
        btnNuevo = New Button()
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
        Label1.Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(410, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(231, 26)
        Label1.TabIndex = 2
        Label1.Text = "GESTIÓN DE PACIENTES"
        ' 
        ' txtIdPaciente
        ' 
        txtIdPaciente.Location = New Point(152, 75)
        txtIdPaciente.Margin = New Padding(3, 4, 3, 4)
        txtIdPaciente.Name = "txtIdPaciente"
        txtIdPaciente.ReadOnly = True
        txtIdPaciente.Size = New Size(114, 27)
        txtIdPaciente.TabIndex = 3
        txtIdPaciente.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(152, 113)
        txtNombre.Margin = New Padding(3, 4, 3, 4)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(114, 27)
        txtNombre.TabIndex = 4
        txtNombre.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(152, 152)
        txtApellido.Margin = New Padding(3, 4, 3, 4)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(114, 27)
        txtApellido.TabIndex = 5
        txtApellido.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(152, 268)
        txtDireccion.Margin = New Padding(3, 4, 3, 4)
        txtDireccion.Multiline = True
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(114, 29)
        txtDireccion.TabIndex = 6
        txtDireccion.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(152, 307)
        txtTelefono.Margin = New Padding(3, 4, 3, 4)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(114, 27)
        txtTelefono.TabIndex = 7
        txtTelefono.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(152, 345)
        txtCorreo.Margin = New Padding(3, 4, 3, 4)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(114, 27)
        txtCorreo.TabIndex = 8
        txtCorreo.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(152, 384)
        txtBuscar.Margin = New Padding(3, 4, 3, 4)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(114, 27)
        txtBuscar.TabIndex = 9
        txtBuscar.TextAlign = HorizontalAlignment.Center
        ' 
        ' dtpFechaNac
        ' 
        dtpFechaNac.Format = DateTimePickerFormat.Short
        dtpFechaNac.Location = New Point(152, 191)
        dtpFechaNac.Margin = New Padding(3, 4, 3, 4)
        dtpFechaNac.Name = "dtpFechaNac"
        dtpFechaNac.Size = New Size(114, 27)
        dtpFechaNac.TabIndex = 10
        ' 
        ' cmbSexo
        ' 
        cmbSexo.FormattingEnabled = True
        cmbSexo.Items.AddRange(New Object() {"M", "F"})
        cmbSexo.Location = New Point(152, 229)
        cmbSexo.Margin = New Padding(3, 4, 3, 4)
        cmbSexo.Name = "cmbSexo"
        cmbSexo.Size = New Size(114, 28)
        cmbSexo.TabIndex = 11
        ' 
        ' dgvPacientes
        ' 
        dgvPacientes.AllowUserToAddRows = False
        dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPacientes.Location = New Point(273, 75)
        dgvPacientes.Margin = New Padding(3, 4, 3, 4)
        dgvPacientes.Name = "dgvPacientes"
        dgvPacientes.RowHeadersWidth = 51
        dgvPacientes.Size = New Size(742, 340)
        dgvPacientes.TabIndex = 12
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(14, 451)
        btnNuevo.Margin = New Padding(3, 4, 3, 4)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(86, 31)
        btnNuevo.TabIndex = 13
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(242, 451)
        btnGuardar.Margin = New Padding(3, 4, 3, 4)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(86, 31)
        btnGuardar.TabIndex = 14
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(487, 451)
        btnEditar.Margin = New Padding(3, 4, 3, 4)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(86, 31)
        btnEditar.TabIndex = 15
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(718, 451)
        btnEliminar.Margin = New Padding(3, 4, 3, 4)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(86, 31)
        btnEliminar.TabIndex = 16
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(929, 451)
        btnLimpiar.Margin = New Padding(3, 4, 3, 4)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(86, 31)
        btnLimpiar.TabIndex = 17
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(651, 635)
        btnPrimero.Margin = New Padding(3, 4, 3, 4)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(86, 31)
        btnPrimero.TabIndex = 18
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(744, 635)
        btnAnterior.Margin = New Padding(3, 4, 3, 4)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(86, 31)
        btnAnterior.TabIndex = 19
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(837, 635)
        btnSiguiente.Margin = New Padding(3, 4, 3, 4)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(86, 31)
        btnSiguiente.TabIndex = 20
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(929, 635)
        btnUltimo.Margin = New Padding(3, 4, 3, 4)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(86, 31)
        btnUltimo.TabIndex = 21
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(225, 551)
        btnRegresar.Margin = New Padding(3, 4, 3, 4)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(125, 31)
        btnRegresar.TabIndex = 22
        btnRegresar.Text = "Menú principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(718, 551)
        btnSalir.Margin = New Padding(3, 4, 3, 4)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(86, 31)
        btnSalir.TabIndex = 23
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' lblIdPaciente
        ' 
        lblIdPaciente.AutoSize = True
        lblIdPaciente.Location = New Point(24, 79)
        lblIdPaciente.Name = "lblIdPaciente"
        lblIdPaciente.Size = New Size(113, 20)
        lblIdPaciente.TabIndex = 24
        lblIdPaciente.Text = "ID del paciente:"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(48, 117)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(67, 20)
        lblNombre.TabIndex = 25
        lblNombre.Text = "Nombre:"
        ' 
        ' lblApellido
        ' 
        lblApellido.AutoSize = True
        lblApellido.Location = New Point(48, 156)
        lblApellido.Name = "lblApellido"
        lblApellido.Size = New Size(69, 20)
        lblApellido.TabIndex = 26
        lblApellido.Text = "Apellido:"
        ' 
        ' lblFechaNac
        ' 
        lblFechaNac.AutoSize = True
        lblFechaNac.Location = New Point(0, 196)
        lblFechaNac.Name = "lblFechaNac"
        lblFechaNac.Size = New Size(149, 20)
        lblFechaNac.TabIndex = 27
        lblFechaNac.Text = "Fecha de nacimiento:"
        ' 
        ' lblSexo
        ' 
        lblSexo.AutoSize = True
        lblSexo.Location = New Point(59, 233)
        lblSexo.Name = "lblSexo"
        lblSexo.Size = New Size(44, 20)
        lblSexo.TabIndex = 28
        lblSexo.Text = "Sexo:"
        ' 
        ' lblDireccion
        ' 
        lblDireccion.AutoSize = True
        lblDireccion.Location = New Point(45, 272)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(75, 20)
        lblDireccion.TabIndex = 29
        lblDireccion.Text = "Dirección:"
        ' 
        ' lblTelefono
        ' 
        lblTelefono.AutoSize = True
        lblTelefono.Location = New Point(48, 311)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New Size(70, 20)
        lblTelefono.TabIndex = 30
        lblTelefono.Text = "Teléfono:"
        ' 
        ' lblCorreo
        ' 
        lblCorreo.AutoSize = True
        lblCorreo.Location = New Point(14, 349)
        lblCorreo.Name = "lblCorreo"
        lblCorreo.Size = New Size(135, 20)
        lblCorreo.TabIndex = 31
        lblCorreo.Text = "Correo electrónico:"
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Location = New Point(48, 388)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(77, 20)
        lblBuscar.TabIndex = 32
        lblBuscar.Text = "Búsqueda:"
        ' 
        ' frm2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 681)
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
        Controls.Add(btnNuevo)
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
        Margin = New Padding(3, 4, 3, 4)
        Name = "frm2"
        Text = "Form2"
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
    Friend WithEvents btnNuevo As Button
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
