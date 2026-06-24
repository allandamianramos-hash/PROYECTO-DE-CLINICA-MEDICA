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
        txtIdMedico.Location = New Point(45, 87)
        txtIdMedico.Name = "txtIdMedico"
        txtIdMedico.ReadOnly = True
        txtIdMedico.Size = New Size(248, 23)
        txtIdMedico.TabIndex = 0
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(45, 148)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(248, 23)
        txtNombre.TabIndex = 1
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(45, 212)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(248, 23)
        txtApellido.TabIndex = 2
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(45, 330)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(248, 23)
        txtTelefono.TabIndex = 3
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(45, 394)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(248, 23)
        txtCorreo.TabIndex = 4
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(45, 269)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(248, 23)
        txtBuscar.TabIndex = 5
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(364, 451)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(75, 23)
        btnNuevo.TabIndex = 6
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(440, 500)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 7
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(502, 452)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(80, 22)
        btnEditar.TabIndex = 8
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(480, 592)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 9
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(399, 592)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(75, 23)
        btnLimpiar.TabIndex = 10
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(318, 543)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(75, 23)
        btnPrimero.TabIndex = 11
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(399, 543)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(75, 23)
        btnAnterior.TabIndex = 12
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(480, 543)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(75, 23)
        btnSiguiente.TabIndex = 13
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(561, 542)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(75, 23)
        btnUltimo.TabIndex = 14
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(12, 584)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(108, 50)
        btnRegresar.TabIndex = 15
        btnRegresar.Text = "Menú Principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(1108, 584)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(108, 50)
        btnSalir.TabIndex = 16
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 15)
        Label1.TabIndex = 17
        Label1.Text = "Identificador de Medico"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(45, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 18
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(45, 194)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 19
        Label3.Text = "Apellido"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(45, 251)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 15)
        Label4.TabIndex = 20
        Label4.Text = "Telefono"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(45, 312)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 15)
        Label5.TabIndex = 21
        Label5.Text = "Correo"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(45, 376)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 15)
        Label6.TabIndex = 22
        Label6.Text = "Buscar"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Showcard Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(364, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(261, 27)
        Label7.TabIndex = 23
        Label7.Text = "Formulario de Medico"
        ' 
        ' cmbEspecialidad
        ' 
        cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEspecialidad.FormattingEnabled = True
        cmbEspecialidad.Location = New Point(318, 87)
        cmbEspecialidad.Name = "cmbEspecialidad"
        cmbEspecialidad.Size = New Size(121, 23)
        cmbEspecialidad.TabIndex = 24
        ' 
        ' dgvMedicos
        ' 
        dgvMedicos.AllowUserToAddRows = False
        dgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMedicos.Location = New Point(480, 87)
        dgvMedicos.MultiSelect = False
        dgvMedicos.Name = "dgvMedicos"
        dgvMedicos.ReadOnly = True
        dgvMedicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMedicos.Size = New Size(736, 320)
        dgvMedicos.TabIndex = 25
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(318, 69)
        Label8.Name = "Label8"
        Label8.Size = New Size(72, 15)
        Label8.TabIndex = 26
        Label8.Text = "Especialidad"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1228, 646)
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
        Controls.Add(btnNuevo)
        Controls.Add(txtBuscar)
        Controls.Add(txtCorreo)
        Controls.Add(txtTelefono)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Controls.Add(txtIdMedico)
        Name = "Form3"
        Text = "Form3"
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
