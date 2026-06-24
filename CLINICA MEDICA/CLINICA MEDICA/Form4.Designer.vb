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
        btnNuevo = New Button()
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
        Label1.Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(375, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(333, 26)
        Label1.TabIndex = 3
        Label1.Text = "Formulario de Especialidades"
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
        ' txtIdEspecialidad
        ' 
        txtIdEspecialidad.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtIdEspecialidad.Location = New Point(167, 124)
        txtIdEspecialidad.Margin = New Padding(3, 4, 3, 4)
        txtIdEspecialidad.Name = "txtIdEspecialidad"
        txtIdEspecialidad.ReadOnly = True
        txtIdEspecialidad.Size = New Size(114, 27)
        txtIdEspecialidad.TabIndex = 17
        txtIdEspecialidad.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombre.Location = New Point(167, 196)
        txtNombre.Margin = New Padding(3, 4, 3, 4)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(114, 27)
        txtNombre.TabIndex = 18
        txtNombre.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtDescripcion.Location = New Point(167, 272)
        txtDescripcion.Margin = New Padding(3, 4, 3, 4)
        txtDescripcion.Multiline = True
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(114, 29)
        txtDescripcion.TabIndex = 19
        txtDescripcion.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtBuscar.Location = New Point(167, 340)
        txtBuscar.Margin = New Padding(3, 4, 3, 4)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(114, 27)
        txtBuscar.TabIndex = 20
        txtBuscar.TextAlign = HorizontalAlignment.Center
        ' 
        ' dgvEspecialidades
        ' 
        dgvEspecialidades.AllowUserToAddRows = False
        dgvEspecialidades.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEspecialidades.Location = New Point(375, 104)
        dgvEspecialidades.Margin = New Padding(3, 4, 3, 4)
        dgvEspecialidades.Name = "dgvEspecialidades"
        dgvEspecialidades.RowHeadersWidth = 51
        dgvEspecialidades.Size = New Size(616, 247)
        dgvEspecialidades.TabIndex = 21
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(487, 476)
        btnSalir.Margin = New Padding(3, 4, 3, 4)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(86, 31)
        btnSalir.TabIndex = 34
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(927, 553)
        btnUltimo.Margin = New Padding(3, 4, 3, 4)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(86, 31)
        btnUltimo.TabIndex = 32
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(834, 553)
        btnSiguiente.Margin = New Padding(3, 4, 3, 4)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(86, 31)
        btnSiguiente.TabIndex = 31
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(742, 553)
        btnAnterior.Margin = New Padding(3, 4, 3, 4)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(86, 31)
        btnAnterior.TabIndex = 30
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(649, 553)
        btnPrimero.Margin = New Padding(3, 4, 3, 4)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(86, 31)
        btnPrimero.TabIndex = 29
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(929, 397)
        btnLimpiar.Margin = New Padding(3, 4, 3, 4)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(86, 31)
        btnLimpiar.TabIndex = 28
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(718, 397)
        btnEliminar.Margin = New Padding(3, 4, 3, 4)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(86, 31)
        btnEliminar.TabIndex = 27
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(487, 397)
        btnEditar.Margin = New Padding(3, 4, 3, 4)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(86, 31)
        btnEditar.TabIndex = 26
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(242, 397)
        btnGuardar.Margin = New Padding(3, 4, 3, 4)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(86, 31)
        btnGuardar.TabIndex = 25
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(14, 397)
        btnNuevo.Margin = New Padding(3, 4, 3, 4)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(86, 31)
        btnNuevo.TabIndex = 24
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Location = New Point(50, 344)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(77, 20)
        lblBuscar.TabIndex = 38
        lblBuscar.Text = "Búsqueda:"
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.AutoSize = True
        lblDescripcion.Location = New Point(40, 276)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(90, 20)
        lblDescripcion.TabIndex = 37
        lblDescripcion.Text = "Descripción:"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(50, 200)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(67, 20)
        lblNombre.TabIndex = 36
        lblNombre.Text = "Nombre:"
        ' 
        ' lblIdEspecialidad
        ' 
        lblIdEspecialidad.AutoSize = True
        lblIdEspecialidad.Location = New Point(14, 128)
        lblIdEspecialidad.Name = "lblIdEspecialidad"
        lblIdEspecialidad.Size = New Size(152, 20)
        lblIdEspecialidad.TabIndex = 35
        lblIdEspecialidad.Text = "ID de la especialidad:"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1026, 600)
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
        Controls.Add(btnNuevo)
        Controls.Add(dgvEspecialidades)
        Controls.Add(txtBuscar)
        Controls.Add(txtDescripcion)
        Controls.Add(txtNombre)
        Controls.Add(txtIdEspecialidad)
        Controls.Add(btnRegresar)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form4"
        Text = "Form4"
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
    Friend WithEvents btnNuevo As Button
    Friend WithEvents lblBuscar As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblIdEspecialidad As Label
End Class
