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
        txtIdMedico.Location = New Point(182, 47)
        txtIdMedico.Name = "txtIdMedico"
        txtIdMedico.ReadOnly = True
        txtIdMedico.Size = New Size(118, 32)
        txtIdMedico.TabIndex = 0
        txtIdMedico.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(182, 80)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(118, 32)
        txtNombre.TabIndex = 1
        txtNombre.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(182, 113)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(118, 32)
        txtApellido.TabIndex = 2
        txtApellido.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(182, 176)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(118, 32)
        txtTelefono.TabIndex = 3
        txtTelefono.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(182, 209)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(118, 32)
        txtCorreo.TabIndex = 4
        txtCorreo.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(182, 242)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(118, 32)
        txtBuscar.TabIndex = 5
        txtBuscar.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(12, 275)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(108, 25)
        btnGuardar.TabIndex = 7
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(126, 275)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(108, 25)
        btnEditar.TabIndex = 8
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(240, 275)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(108, 25)
        btnEliminar.TabIndex = 9
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(354, 275)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(108, 25)
        btnLimpiar.TabIndex = 10
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(812, 306)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(108, 25)
        btnPrimero.TabIndex = 11
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(812, 275)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(108, 25)
        btnAnterior.TabIndex = 12
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(926, 275)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(108, 25)
        btnSiguiente.TabIndex = 13
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(926, 306)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(108, 25)
        btnUltimo.TabIndex = 14
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(12, 306)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(336, 25)
        btnRegresar.TabIndex = 15
        btnRegresar.Text = "Menú principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(468, 275)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(108, 25)
        btnSalir.TabIndex = 16
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 21)
        Label1.TabIndex = 17
        Label1.Text = "Identificador del médico:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 21)
        Label2.TabIndex = 18
        Label2.Text = "Nombre:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 21)
        Label3.TabIndex = 19
        Label3.Text = "Apellido:"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 21)
        Label4.TabIndex = 20
        Label4.Text = "Teléfono:"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 212)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 21)
        Label5.TabIndex = 21
        Label5.Text = "Correo:"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 245)
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
        cmbEspecialidad.Location = New Point(182, 146)
        cmbEspecialidad.Name = "cmbEspecialidad"
        cmbEspecialidad.Size = New Size(118, 28)
        cmbEspecialidad.TabIndex = 24
        ' 
        ' dgvMedicos
        ' 
        dgvMedicos.AllowUserToAddRows = False
        dgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMedicos.Location = New Point(306, 47)
        dgvMedicos.MultiSelect = False
        dgvMedicos.Name = "dgvMedicos"
        dgvMedicos.ReadOnly = True
        dgvMedicos.RowHeadersWidth = 51
        dgvMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMedicos.Size = New Size(728, 222)
        dgvMedicos.TabIndex = 25
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 149)
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
        ClientSize = New Size(1046, 376)
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
