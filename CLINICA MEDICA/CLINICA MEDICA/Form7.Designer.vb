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
        btnSalir = New Button()
        btnUltimo = New Button()
        btnSiguiente = New Button()
        btnAnterior = New Button()
        btnPrimero = New Button()
        btnLimpiar = New Button()
        btnEliminar = New Button()
        btnEditar = New Button()
        btnGuardar = New Button()
        cmbIdConsulta = New ComboBox()
        dgvRecetas = New DataGridView()
        Label2 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtBuscar = New TextBox()
        clbMedicamentos = New CheckedListBox()
        CType(dgvRecetas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(218, 16)
        Label1.TabIndex = 3
        Label1.Text = "Módulo de control de recetas"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(368, 283)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(188, 59)
        btnRegresar.TabIndex = 16
        btnRegresar.Text = "Menú principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' txtIdReceta
        ' 
        txtIdReceta.Location = New Point(201, 220)
        txtIdReceta.Name = "txtIdReceta"
        txtIdReceta.Size = New Size(161, 27)
        txtIdReceta.TabIndex = 17
        txtIdReceta.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(562, 283)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(188, 59)
        btnSalir.TabIndex = 33
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(1060, 283)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(91, 59)
        btnUltimo.TabIndex = 32
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(1060, 220)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(91, 57)
        btnSiguiente.TabIndex = 31
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(963, 220)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(91, 57)
        btnAnterior.TabIndex = 30
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(963, 283)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(91, 59)
        btnPrimero.TabIndex = 29
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(659, 220)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(91, 57)
        btnLimpiar.TabIndex = 28
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(562, 220)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(91, 57)
        btnEliminar.TabIndex = 27
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(465, 220)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(91, 57)
        btnEditar.TabIndex = 26
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(368, 220)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(91, 57)
        btnGuardar.TabIndex = 25
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' cmbIdConsulta
        ' 
        cmbIdConsulta.FormattingEnabled = True
        cmbIdConsulta.Location = New Point(201, 253)
        cmbIdConsulta.Name = "cmbIdConsulta"
        cmbIdConsulta.Size = New Size(161, 24)
        cmbIdConsulta.TabIndex = 34
        ' 
        ' dgvRecetas
        ' 
        dgvRecetas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecetas.Location = New Point(12, 28)
        dgvRecetas.Name = "dgvRecetas"
        dgvRecetas.Size = New Size(1139, 186)
        dgvRecetas.TabIndex = 35
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 283)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 16)
        Label2.TabIndex = 38
        Label2.Text = "Medicamentos:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 223)
        Label3.Name = "Label3"
        Label3.Size = New Size(167, 16)
        Label3.TabIndex = 39
        Label3.Text = "Identificador de la receta:"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 256)
        Label6.Name = "Label6"
        Label6.Size = New Size(183, 16)
        Label6.TabIndex = 42
        Label6.Text = "Identificador de la consulta:"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 318)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 16)
        Label7.TabIndex = 43
        Label7.Text = "Búsqueda:"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(201, 315)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(161, 27)
        txtBuscar.TabIndex = 44
        txtBuscar.TextAlign = HorizontalAlignment.Center
        ' 
        ' clbMedicamentos
        ' 
        clbMedicamentos.FormattingEnabled = True
        clbMedicamentos.Location = New Point(201, 283)
        clbMedicamentos.Name = "clbMedicamentos"
        clbMedicamentos.Size = New Size(161, 26)
        clbMedicamentos.TabIndex = 45
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1163, 354)
        Controls.Add(clbMedicamentos)
        Controls.Add(txtBuscar)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
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
        Controls.Add(txtIdReceta)
        Controls.Add(btnRegresar)
        Controls.Add(Label1)
        Font = New Font("Lucida Sans Unicode", 9.75F)
        Name = "Form7"
        Text = "Control de recetas"
        CType(dgvRecetas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents txtIdReceta As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents cmbIdConsulta As ComboBox
    Friend WithEvents dgvRecetas As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents clbMedicamentos As CheckedListBox
End Class
