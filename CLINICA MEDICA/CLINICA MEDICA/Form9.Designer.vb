<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        txtIdMedicamento = New TextBox()
        txtNombreComercial = New TextBox()
        txtNombreGenerico = New TextBox()
        txtPrecio = New TextBox()
        txtConcentracion = New TextBox()
        txtBuscar = New TextBox()
        btnSalir = New Button()
        btnLimpiar = New Button()
        btnEliminar = New Button()
        btnEditar = New Button()
        btnGuardar = New Button()
        btnRegresar = New Button()
        btnUltimo = New Button()
        btnSiguiente = New Button()
        btnAnterior = New Button()
        btnPrimero = New Button()
        dgvMedicamentos = New DataGridView()
        Label1 = New Label()
        cmbFormaFarmaceutica = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        CType(dgvMedicamentos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtIdMedicamento
        ' 
        txtIdMedicamento.Location = New Point(31, 74)
        txtIdMedicamento.Name = "txtIdMedicamento"
        txtIdMedicamento.ReadOnly = True
        txtIdMedicamento.Size = New Size(100, 23)
        txtIdMedicamento.TabIndex = 0
        ' 
        ' txtNombreComercial
        ' 
        txtNombreComercial.Location = New Point(31, 121)
        txtNombreComercial.Name = "txtNombreComercial"
        txtNombreComercial.Size = New Size(100, 23)
        txtNombreComercial.TabIndex = 1
        ' 
        ' txtNombreGenerico
        ' 
        txtNombreGenerico.Location = New Point(31, 169)
        txtNombreGenerico.Name = "txtNombreGenerico"
        txtNombreGenerico.Size = New Size(100, 23)
        txtNombreGenerico.TabIndex = 2
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(163, 74)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(100, 23)
        txtPrecio.TabIndex = 3
        txtPrecio.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtConcentracion
        ' 
        txtConcentracion.Location = New Point(31, 221)
        txtConcentracion.Name = "txtConcentracion"
        txtConcentracion.Size = New Size(100, 23)
        txtConcentracion.TabIndex = 4
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(31, 271)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(100, 23)
        txtBuscar.TabIndex = 5
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(307, 353)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(86, 25)
        btnSalir.TabIndex = 40
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(307, 322)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(86, 25)
        btnLimpiar.TabIndex = 39
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(215, 322)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(86, 25)
        btnEliminar.TabIndex = 38
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(123, 322)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(86, 25)
        btnEditar.TabIndex = 37
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(31, 322)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(86, 25)
        btnGuardar.TabIndex = 36
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(31, 353)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(270, 25)
        btnRegresar.TabIndex = 35
        btnRegresar.Text = "Menú principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(560, 353)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(69, 25)
        btnUltimo.TabIndex = 44
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(560, 322)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(69, 25)
        btnSiguiente.TabIndex = 43
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(485, 322)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(69, 25)
        btnAnterior.TabIndex = 42
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(485, 353)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(69, 25)
        btnPrimero.TabIndex = 41
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' dgvMedicamentos
        ' 
        dgvMedicamentos.AllowUserToDeleteRows = False
        dgvMedicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMedicamentos.Location = New Point(307, 74)
        dgvMedicamentos.MultiSelect = False
        dgvMedicamentos.Name = "dgvMedicamentos"
        dgvMedicamentos.ReadOnly = True
        dgvMedicamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMedicamentos.Size = New Size(481, 231)
        dgvMedicamentos.TabIndex = 45
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(263, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(248, 30)
        Label1.TabIndex = 46
        Label1.Text = "Modulo de Medicamento"
        ' 
        ' cmbFormaFarmaceutica
        ' 
        cmbFormaFarmaceutica.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFormaFarmaceutica.FormattingEnabled = True
        cmbFormaFarmaceutica.Location = New Point(163, 129)
        cmbFormaFarmaceutica.Name = "cmbFormaFarmaceutica"
        cmbFormaFarmaceutica.Size = New Size(121, 23)
        cmbFormaFarmaceutica.TabIndex = 47
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(163, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 15)
        Label2.TabIndex = 48
        Label2.Text = "Forma farmacéutica"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 15)
        Label3.TabIndex = 49
        Label3.Text = "Concentración"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 103)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 15)
        Label4.TabIndex = 50
        Label4.Text = "Nombre comercial"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(31, 151)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 15)
        Label5.TabIndex = 51
        Label5.Text = "Nombre genérico"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(31, 59)
        Label6.Name = "Label6"
        Label6.Size = New Size(114, 15)
        Label6.TabIndex = 52
        Label6.Text = "ID del medicamento"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(163, 56)
        Label7.Name = "Label7"
        Label7.Size = New Size(43, 15)
        Label7.TabIndex = 53
        Label7.Text = "Precio:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(31, 253)
        Label8.Name = "Label8"
        Label8.Size = New Size(62, 15)
        Label8.TabIndex = 54
        Label8.Text = "Busqueda:"
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(cmbFormaFarmaceutica)
        Controls.Add(Label1)
        Controls.Add(dgvMedicamentos)
        Controls.Add(btnUltimo)
        Controls.Add(btnSiguiente)
        Controls.Add(btnAnterior)
        Controls.Add(btnPrimero)
        Controls.Add(btnSalir)
        Controls.Add(btnLimpiar)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnGuardar)
        Controls.Add(btnRegresar)
        Controls.Add(txtBuscar)
        Controls.Add(txtConcentracion)
        Controls.Add(txtPrecio)
        Controls.Add(txtNombreGenerico)
        Controls.Add(txtNombreComercial)
        Controls.Add(txtIdMedicamento)
        Name = "Form9"
        Text = "Form9"
        CType(dgvMedicamentos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIdMedicamento As TextBox
    Friend WithEvents txtNombreComercial As TextBox
    Friend WithEvents txtNombreGenerico As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtConcentracion As TextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents dgvMedicamentos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbFormaFarmaceutica As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
