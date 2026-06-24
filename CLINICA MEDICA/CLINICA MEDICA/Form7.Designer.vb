<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        txtIdReceta = New TextBox()
        txtDosis = New TextBox()
        txtIndicaciones = New TextBox()
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
        cmbIdConsulta = New ComboBox()
        dgvRecetas = New DataGridView()
        cmbMedicamento = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtBuscar = New TextBox()
        CType(dgvRecetas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(234, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(310, 20)
        Label1.TabIndex = 3
        Label1.Text = "Formulario de Control de Recetas"
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(12, 427)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(108, 50)
        btnRegresar.TabIndex = 16
        btnRegresar.Text = "Menú Principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' txtIdReceta
        ' 
        txtIdReceta.Location = New Point(26, 56)
        txtIdReceta.Name = "txtIdReceta"
        txtIdReceta.Size = New Size(100, 23)
        txtIdReceta.TabIndex = 17
        ' 
        ' txtDosis
        ' 
        txtDosis.Location = New Point(26, 111)
        txtDosis.Name = "txtDosis"
        txtDosis.Size = New Size(100, 23)
        txtDosis.TabIndex = 19
        ' 
        ' txtIndicaciones
        ' 
        txtIndicaciones.Location = New Point(26, 168)
        txtIndicaciones.Name = "txtIndicaciones"
        txtIndicaciones.Size = New Size(100, 23)
        txtIndicaciones.TabIndex = 20
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(1126, 427)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(108, 50)
        btnSalir.TabIndex = 33
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(406, 381)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(75, 23)
        btnUltimo.TabIndex = 32
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(325, 382)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(75, 23)
        btnSiguiente.TabIndex = 31
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(244, 382)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(75, 23)
        btnAnterior.TabIndex = 30
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(163, 382)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(75, 23)
        btnPrimero.TabIndex = 29
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(244, 431)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(75, 23)
        btnLimpiar.TabIndex = 28
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(325, 431)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 27
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(347, 291)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(80, 22)
        btnEditar.TabIndex = 26
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(274, 339)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(80, 23)
        btnGuardar.TabIndex = 25
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(209, 290)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(75, 23)
        btnNuevo.TabIndex = 24
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' cmbIdConsulta
        ' 
        cmbIdConsulta.FormattingEnabled = True
        cmbIdConsulta.Location = New Point(171, 56)
        cmbIdConsulta.Name = "cmbIdConsulta"
        cmbIdConsulta.Size = New Size(121, 23)
        cmbIdConsulta.TabIndex = 34
        ' 
        ' dgvRecetas
        ' 
        dgvRecetas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecetas.Location = New Point(511, 56)
        dgvRecetas.Name = "dgvRecetas"
        dgvRecetas.Size = New Size(723, 237)
        dgvRecetas.TabIndex = 35
        ' 
        ' cmbMedicamento
        ' 
        cmbMedicamento.FormattingEnabled = True
        cmbMedicamento.Location = New Point(352, 56)
        cmbMedicamento.Name = "cmbMedicamento"
        cmbMedicamento.Size = New Size(121, 23)
        cmbMedicamento.TabIndex = 37
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(352, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 15)
        Label2.TabIndex = 38
        Label2.Text = "Medicamentos"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 15)
        Label3.TabIndex = 39
        Label3.Text = "Receta"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(26, 93)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 15)
        Label4.TabIndex = 40
        Label4.Text = "Dosis"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(26, 150)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 15)
        Label5.TabIndex = 41
        Label5.Text = "Indicaciones"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(171, 38)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 15)
        Label6.TabIndex = 42
        Label6.Text = "Consulta"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(26, 213)
        Label7.Name = "Label7"
        Label7.Size = New Size(42, 15)
        Label7.TabIndex = 43
        Label7.Text = "Buscar"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(26, 232)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(100, 23)
        txtBuscar.TabIndex = 44
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1246, 489)
        Controls.Add(txtBuscar)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(cmbMedicamento)
        Controls.Add(dgvRecetas)
        Controls.Add(cmbIdConsulta)
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
        Controls.Add(txtIndicaciones)
        Controls.Add(txtDosis)
        Controls.Add(txtIdReceta)
        Controls.Add(btnRegresar)
        Controls.Add(Label1)
        Name = "Form7"
        Text = "Form7"
        CType(dgvRecetas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents txtIdReceta As TextBox
    Friend WithEvents txtDosis As TextBox
    Friend WithEvents txtIndicaciones As TextBox
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
    Friend WithEvents cmbIdConsulta As ComboBox
    Friend WithEvents dgvRecetas As DataGridView
    Friend WithEvents cmbMedicamento As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBuscar As TextBox
End Class
