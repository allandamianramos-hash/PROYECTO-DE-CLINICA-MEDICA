<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        txtIdMedico = New TextBox()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        txtTelefono = New TextBox()
        txtCorreo = New TextBox()
        txtBuscar = New TextBox()
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        cmbEspecialidad = New ComboBox()
        dgvMedicos = New DataGridView()
        Label8 = New Label()
        CType(dgvMedicos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtIdMedico
        ' 
        txtIdMedico.Location = New Point(182, 256)
        txtIdMedico.Name = "txtIdMedico"
        txtIdMedico.ReadOnly = True
<<<<<<< HEAD
        txtIdMedico.Size = New Size(118, 32)
=======
        txtIdMedico.Size = New Size(137, 27)
>>>>>>> f7d02d53c961f177c996d8cfda256c97687f45d8
        txtIdMedico.TabIndex = 0
        txtIdMedico.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(182, 289)
        txtNombre.Name = "txtNombre"
<<<<<<< HEAD
        txtNombre.Size = New Size(118, 32)
=======
        txtNombre.Size = New Size(137, 27)
>>>>>>> f7d02d53c961f177c996d8cfda256c97687f45d8
        txtNombre.TabIndex = 1
        txtNombre.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(182, 322)
        txtApellido.Name = "txtApellido"
<<<<<<< HEAD
        txtApellido.Size = New Size(118, 32)
=======
        txtApellido.Size = New Size(137, 27)
>>>>>>> f7d02d53c961f177c996d8cfda256c97687f45d8
        txtApellido.TabIndex = 2
        txtApellido.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(182, 385)
        txtTelefono.Name = "txtTelefono"
<<<<<<< HEAD
        txtTelefono.Size = New Size(118, 32)
=======
        txtTelefono.Size = New Size(137, 27)
>>>>>>> f7d02d53c961f177c996d8cfda256c97687f45d8
        txtTelefono.TabIndex = 3
        txtTelefono.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(182, 418)
        txtCorreo.Name = "txtCorreo"
<<<<<<< HEAD
        txtCorreo.Size = New Size(118, 32)
=======
        txtCorreo.Size = New Size(137, 27)
>>>>>>> f7d02d53c961f177c996d8cfda256c97687f45d8
        txtCorreo.TabIndex = 4
        txtCorreo.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(182, 451)
        txtBuscar.Name = "txtBuscar"
<<<<<<< HEAD
        txtBuscar.Size = New Size(118, 32)
=======
        txtBuscar.Size = New Size(137, 27)
>>>>>>> f7d02d53c961f177c996d8cfda256c97687f45d8
        txtBuscar.TabIndex = 5
        txtBuscar.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(325, 256)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(108, 60)
        btnGuardar.TabIndex = 7
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(439, 256)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(108, 60)
        btnEditar.TabIndex = 8
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(553, 256)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(108, 60)
        btnEliminar.TabIndex = 9
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(667, 256)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(108, 60)
        btnLimpiar.TabIndex = 10
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(812, 322)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(108, 60)
        btnPrimero.TabIndex = 11
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(812, 256)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(108, 60)
        btnAnterior.TabIndex = 12
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(926, 256)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(108, 60)
        btnSiguiente.TabIndex = 13
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(926, 321)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(108, 61)
        btnUltimo.TabIndex = 14
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(325, 322)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(222, 60)
        btnRegresar.TabIndex = 15
        btnRegresar.Text = "Menú principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(553, 322)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(222, 60)
        btnSalir.TabIndex = 16
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 259)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 21)
        Label1.TabIndex = 17
        Label1.Text = "Identificador del médico:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 292)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 21)
        Label2.TabIndex = 18
        Label2.Text = "Nombre:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 325)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 21)
        Label3.TabIndex = 19
        Label3.Text = "Apellido:"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 388)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 21)
        Label4.TabIndex = 20
        Label4.Text = "Teléfono:"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 421)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 21)
        Label5.TabIndex = 21
        Label5.Text = "Correo:"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 454)
        Label6.Name = "Label6"
        Label6.Size = New Size(95, 21)
        Label6.TabIndex = 22
        Label6.Text = "Búsqueda:"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(12, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(191, 21)
        Label7.TabIndex = 23
        Label7.Text = "Módulo de médicos"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cmbEspecialidad
        ' 
        cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEspecialidad.FormattingEnabled = True
        cmbEspecialidad.Location = New Point(182, 355)
        cmbEspecialidad.Name = "cmbEspecialidad"
<<<<<<< HEAD
        cmbEspecialidad.Size = New Size(118, 28)
=======
        cmbEspecialidad.Size = New Size(137, 24)
>>>>>>> f7d02d53c961f177c996d8cfda256c97687f45d8
        cmbEspecialidad.TabIndex = 24
        ' 
        ' dgvMedicos
        ' 
        dgvMedicos.AllowUserToAddRows = False
        dgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMedicos.Location = New Point(12, 28)
        dgvMedicos.MultiSelect = False
        dgvMedicos.Name = "dgvMedicos"
        dgvMedicos.ReadOnly = True
        dgvMedicos.RowHeadersWidth = 51
        dgvMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMedicos.Size = New Size(1022, 222)
        dgvMedicos.TabIndex = 25
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 358)
        Label8.Name = "Label8"
        Label8.Size = New Size(119, 21)
        Label8.TabIndex = 26
        Label8.Text = "Especialidad:"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
<<<<<<< HEAD
        ClientSize = New Size(1046, 376)
=======
        ClientSize = New Size(1046, 491)
>>>>>>> f7d02d53c961f177c996d8cfda256c97687f45d8
        Controls.Add(Label8)
        Controls.Add(dgvMedicos)
        Controls.Add(cmbEspecialidad)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
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
        Controls.Add(txtBuscar)
        Controls.Add(txtCorreo)
        Controls.Add(txtTelefono)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Controls.Add(txtIdMedico)
        Font = New Font("Lucida Sans Unicode", 9.75F)
        Name = "Form3"
        Text = "Médicos"
        CType(dgvMedicos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIdMedico As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtBuscar As TextBox
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbEspecialidad As ComboBox
    Friend WithEvents dgvMedicos As DataGridView
    Friend WithEvents Label8 As Label
End Class
