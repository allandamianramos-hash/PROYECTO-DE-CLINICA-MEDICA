<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPacientes
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
        CType(dgvPacientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(359, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(189, 20)
        Label1.TabIndex = 2
        Label1.Text = "GESTIÓN DE PACIENTES"
        ' 
        ' txtIdPaciente
        ' 
        txtIdPaciente.Location = New Point(115, 56)
        txtIdPaciente.Name = "txtIdPaciente"
        txtIdPaciente.ReadOnly = True
        txtIdPaciente.Size = New Size(100, 23)
        txtIdPaciente.TabIndex = 3
        txtIdPaciente.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(115, 85)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 4
        txtNombre.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(115, 114)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(100, 23)
        txtApellido.TabIndex = 5
        txtApellido.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(115, 201)
        txtDireccion.Multiline = True
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(100, 23)
        txtDireccion.TabIndex = 6
        txtDireccion.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(115, 230)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(100, 23)
        txtTelefono.TabIndex = 7
        txtTelefono.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(115, 259)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(100, 23)
        txtCorreo.TabIndex = 8
        txtCorreo.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(115, 288)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(100, 23)
        txtBuscar.TabIndex = 9
        txtBuscar.TextAlign = HorizontalAlignment.Center
        ' 
        ' dtpFechaNac
        ' 
        dtpFechaNac.Format = DateTimePickerFormat.Short
        dtpFechaNac.Location = New Point(115, 143)
        dtpFechaNac.Name = "dtpFechaNac"
        dtpFechaNac.Size = New Size(100, 23)
        dtpFechaNac.TabIndex = 10
        ' 
        ' cmbSexo
        ' 
        cmbSexo.FormattingEnabled = True
        cmbSexo.Items.AddRange(New Object() {"M", "F"})
        cmbSexo.Location = New Point(115, 172)
        cmbSexo.Name = "cmbSexo"
        cmbSexo.Size = New Size(100, 23)
        cmbSexo.TabIndex = 11
        ' 
        ' dgvPacientes
        ' 
        dgvPacientes.AllowUserToAddRows = False
        dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPacientes.Location = New Point(221, 56)
        dgvPacientes.Name = "dgvPacientes"
        dgvPacientes.Size = New Size(667, 255)
        dgvPacientes.TabIndex = 12
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(12, 338)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(75, 23)
        btnNuevo.TabIndex = 13
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(212, 338)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 14
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(426, 338)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(75, 23)
        btnEditar.TabIndex = 15
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(628, 338)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 16
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(813, 338)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(75, 23)
        btnLimpiar.TabIndex = 17
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(570, 476)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(75, 23)
        btnPrimero.TabIndex = 18
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(651, 476)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(75, 23)
        btnAnterior.TabIndex = 19
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(732, 476)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(75, 23)
        btnSiguiente.TabIndex = 20
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(813, 476)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(75, 23)
        btnUltimo.TabIndex = 21
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(197, 413)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(109, 23)
        btnRegresar.TabIndex = 22
        btnRegresar.Text = "Menú principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(628, 413)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(75, 23)
        btnSalir.TabIndex = 23
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' frmPacientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 511)
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
        Name = "frmPacientes"
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
End Class
