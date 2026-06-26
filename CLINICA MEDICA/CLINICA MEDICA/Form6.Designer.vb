<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        btnUltimo = New Button()
        btnSiguiente = New Button()
        btnAnterior = New Button()
        btnPrimero = New Button()
        btnLimpiar = New Button()
        btnEliminar = New Button()
        btnEditar = New Button()
        btnGuardar = New Button()
        btnSalir = New Button()
        txtIdConsulta = New TextBox()
        txtDiagnostico = New TextBox()
        txtObservaciones = New TextBox()
        cmbIdCita = New ComboBox()
        dgvConsultas = New DataGridView()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtBuscar = New TextBox()
        CType(dgvConsultas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 16)
        Label1.TabIndex = 3
        Label1.Text = "Módulo de consultas"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(12, 227)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(345, 25)
        btnRegresar.TabIndex = 16
        btnRegresar.Text = "Menú principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(1155, 227)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(111, 25)
        btnUltimo.TabIndex = 41
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(1155, 196)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(111, 25)
        btnSiguiente.TabIndex = 40
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(1038, 196)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(111, 25)
        btnAnterior.TabIndex = 39
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(1038, 227)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(111, 25)
        btnPrimero.TabIndex = 38
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(363, 196)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(111, 25)
        btnLimpiar.TabIndex = 37
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(246, 196)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(111, 25)
        btnEliminar.TabIndex = 36
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(129, 197)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(111, 23)
        btnEditar.TabIndex = 35
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(12, 196)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(111, 25)
        btnGuardar.TabIndex = 34
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(480, 196)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(111, 25)
        btnSalir.TabIndex = 42
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' txtIdConsulta
        ' 
        txtIdConsulta.Enabled = False
        txtIdConsulta.Location = New Point(201, 40)
        txtIdConsulta.Name = "txtIdConsulta"
        txtIdConsulta.Size = New Size(156, 27)
        txtIdConsulta.TabIndex = 43
        txtIdConsulta.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtDiagnostico
        ' 
        txtDiagnostico.Location = New Point(201, 103)
        txtDiagnostico.Multiline = True
        txtDiagnostico.Name = "txtDiagnostico"
        txtDiagnostico.ScrollBars = ScrollBars.Vertical
        txtDiagnostico.Size = New Size(156, 24)
        txtDiagnostico.TabIndex = 44
        ' 
        ' txtObservaciones
        ' 
        txtObservaciones.Location = New Point(201, 133)
        txtObservaciones.Multiline = True
        txtObservaciones.Name = "txtObservaciones"
        txtObservaciones.ScrollBars = ScrollBars.Vertical
        txtObservaciones.Size = New Size(156, 24)
        txtObservaciones.TabIndex = 45
        ' 
        ' cmbIdCita
        ' 
        cmbIdCita.DropDownStyle = ComboBoxStyle.DropDownList
        cmbIdCita.FormattingEnabled = True
        cmbIdCita.Location = New Point(201, 73)
        cmbIdCita.Name = "cmbIdCita"
        cmbIdCita.Size = New Size(156, 24)
        cmbIdCita.TabIndex = 46
        ' 
        ' dgvConsultas
        ' 
        dgvConsultas.AllowUserToAddRows = False
        dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvConsultas.Location = New Point(363, 40)
        dgvConsultas.MultiSelect = False
        dgvConsultas.Name = "dgvConsultas"
        dgvConsultas.ReadOnly = True
        dgvConsultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvConsultas.Size = New Size(903, 150)
        dgvConsultas.TabIndex = 47
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(183, 16)
        Label2.TabIndex = 48
        Label2.Text = "Identificador de la consulta:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 16)
        Label3.TabIndex = 49
        Label3.Text = "Diagnóstico:"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 136)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 16)
        Label4.TabIndex = 50
        Label4.Text = "Observaciones:"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 76)
        Label5.Name = "Label5"
        Label5.Size = New Size(152, 16)
        Label5.TabIndex = 51
        Label5.Text = "Identificador de la cita:"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 166)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 16)
        Label6.TabIndex = 52
        Label6.Text = "Búsqueda:"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(201, 163)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(156, 27)
        txtBuscar.TabIndex = 53
        txtBuscar.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 261)
        Controls.Add(txtBuscar)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(dgvConsultas)
        Controls.Add(cmbIdCita)
        Controls.Add(txtObservaciones)
        Controls.Add(txtDiagnostico)
        Controls.Add(txtIdConsulta)
        Controls.Add(btnSalir)
        Controls.Add(btnUltimo)
        Controls.Add(btnSiguiente)
        Controls.Add(btnAnterior)
        Controls.Add(btnPrimero)
        Controls.Add(btnLimpiar)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnGuardar)
        Controls.Add(btnRegresar)
        Controls.Add(Label1)
        Font = New Font("Lucida Sans Unicode", 9.75F)
        Name = "Form6"
        Text = "Consultas"
        CType(dgvConsultas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtIdConsulta As TextBox
    Friend WithEvents txtDiagnostico As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents cmbIdCita As ComboBox
    Friend WithEvents dgvConsultas As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBuscar As TextBox
End Class
