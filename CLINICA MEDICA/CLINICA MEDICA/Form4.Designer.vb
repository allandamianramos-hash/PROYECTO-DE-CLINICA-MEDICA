<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        txtIdEspecialidad = New TextBox()
        txtNombre = New TextBox()
        txtDescripcion = New TextBox()
        txtBuscar = New TextBox()
        dgvEspecialidades = New DataGridView()
        btnSalir = New Button()
        btnUltimo = New Button()
        btnSiguiente = New Button()
        btnAnterior = New Button()
        btnPrimero = New Button()
        btnLimpiar = New Button()
        btnEliminar = New Button()
        btnEditar = New Button()
        btnGuardar = New Button()
        lblBuscar = New Label()
        lblDescripcion = New Label()
        lblNombre = New Label()
        lblIdEspecialidad = New Label()
        CType(dgvEspecialidades, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 16)
        Label1.TabIndex = 3
        Label1.Text = "Módulo de especialidades"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(12, 208)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(336, 25)
        btnRegresar.TabIndex = 16
        btnRegresar.Text = "Menú principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' txtIdEspecialidad
        ' 
        txtIdEspecialidad.Location = New Point(225, 47)
        txtIdEspecialidad.Name = "txtIdEspecialidad"
        txtIdEspecialidad.ReadOnly = True
        txtIdEspecialidad.Size = New Size(114, 27)
        txtIdEspecialidad.TabIndex = 17
        txtIdEspecialidad.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(225, 80)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(114, 27)
        txtNombre.TabIndex = 18
        txtNombre.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(225, 113)
        txtDescripcion.Multiline = True
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(114, 24)
        txtDescripcion.TabIndex = 19
        txtDescripcion.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(225, 143)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(114, 27)
        txtBuscar.TabIndex = 20
        txtBuscar.TextAlign = HorizontalAlignment.Center
        ' 
        ' dgvEspecialidades
        ' 
        dgvEspecialidades.AllowUserToAddRows = False
        dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEspecialidades.Location = New Point(345, 47)
        dgvEspecialidades.Name = "dgvEspecialidades"
        dgvEspecialidades.RowHeadersWidth = 51
        dgvEspecialidades.Size = New Size(616, 123)
        dgvEspecialidades.TabIndex = 21
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(468, 177)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(108, 25)
        btnSalir.TabIndex = 34
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(853, 208)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(108, 25)
        btnUltimo.TabIndex = 32
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(853, 177)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(108, 25)
        btnSiguiente.TabIndex = 31
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(739, 177)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(108, 25)
        btnAnterior.TabIndex = 30
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(739, 208)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(108, 25)
        btnPrimero.TabIndex = 29
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(354, 177)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(108, 25)
        btnLimpiar.TabIndex = 28
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(240, 177)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(108, 25)
        btnEliminar.TabIndex = 27
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(126, 177)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(108, 25)
        btnEditar.TabIndex = 26
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(12, 177)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(108, 25)
        btnGuardar.TabIndex = 25
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Location = New Point(12, 146)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(71, 16)
        lblBuscar.TabIndex = 38
        lblBuscar.Text = "Búsqueda:"
        lblBuscar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.AutoSize = True
        lblDescripcion.Location = New Point(12, 116)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(86, 16)
        lblDescripcion.TabIndex = 37
        lblDescripcion.Text = "Descripción:"
        lblDescripcion.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(12, 83)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(61, 16)
        lblNombre.TabIndex = 36
        lblNombre.Text = "Nombre:"
        lblNombre.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblIdEspecialidad
        ' 
        lblIdEspecialidad.AutoSize = True
        lblIdEspecialidad.Location = New Point(12, 50)
        lblIdEspecialidad.Name = "lblIdEspecialidad"
        lblIdEspecialidad.Size = New Size(207, 16)
        lblIdEspecialidad.TabIndex = 35
        lblIdEspecialidad.Text = "Identificador de la especialidad:"
        lblIdEspecialidad.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(973, 242)
        Controls.Add(lblBuscar)
        Controls.Add(lblDescripcion)
        Controls.Add(lblNombre)
        Controls.Add(lblIdEspecialidad)
        Controls.Add(btnSalir)
        Controls.Add(btnUltimo)
        Controls.Add(btnSiguiente)
        Controls.Add(btnAnterior)
        Controls.Add(btnPrimero)
        Controls.Add(btnLimpiar)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnGuardar)
        Controls.Add(dgvEspecialidades)
        Controls.Add(txtBuscar)
        Controls.Add(txtDescripcion)
        Controls.Add(txtNombre)
        Controls.Add(txtIdEspecialidad)
        Controls.Add(btnRegresar)
        Controls.Add(Label1)
        Font = New Font("Lucida Sans Unicode", 9.75F)
        Name = "Form4"
        Text = "Especialidades"
        CType(dgvEspecialidades, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents txtIdEspecialidad As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvEspecialidades As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblBuscar As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblIdEspecialidad As Label
End Class
