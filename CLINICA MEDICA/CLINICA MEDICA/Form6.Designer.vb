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
        btnNuevo = New Button()
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
        Label1.Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(272, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(234, 20)
        Label1.TabIndex = 3
        Label1.Text = "Formulario de Consultas "
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(12, 439)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(108, 50)
        btnRegresar.TabIndex = 16
        btnRegresar.Text = "Menú Principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(497, 413)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(75, 23)
        btnUltimo.TabIndex = 41
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(416, 414)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(75, 23)
        btnSiguiente.TabIndex = 40
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(335, 414)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(75, 23)
        btnAnterior.TabIndex = 39
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(254, 414)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(75, 23)
        btnPrimero.TabIndex = 38
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(335, 463)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(75, 23)
        btnLimpiar.TabIndex = 37
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(416, 463)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 36
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(438, 323)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(80, 22)
        btnEditar.TabIndex = 35
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(371, 372)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(80, 23)
        btnGuardar.TabIndex = 34
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(300, 322)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(75, 23)
        btnNuevo.TabIndex = 33
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(1067, 439)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(108, 50)
        btnSalir.TabIndex = 42
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' txtIdConsulta
        ' 
        txtIdConsulta.Enabled = False
        txtIdConsulta.Location = New Point(20, 58)
        txtIdConsulta.Name = "txtIdConsulta"
        txtIdConsulta.Size = New Size(100, 23)
        txtIdConsulta.TabIndex = 43
        ' 
        ' txtDiagnostico
        ' 
        txtDiagnostico.Location = New Point(20, 108)
        txtDiagnostico.Multiline = True
        txtDiagnostico.Name = "txtDiagnostico"
        txtDiagnostico.ScrollBars = ScrollBars.Vertical
        txtDiagnostico.Size = New Size(100, 23)
        txtDiagnostico.TabIndex = 44
        ' 
        ' txtObservaciones
        ' 
        txtObservaciones.Location = New Point(20, 163)
        txtObservaciones.Multiline = True
        txtObservaciones.Name = "txtObservaciones"
        txtObservaciones.ScrollBars = ScrollBars.Vertical
        txtObservaciones.Size = New Size(100, 23)
        txtObservaciones.TabIndex = 45
        ' 
        ' cmbIdCita
        ' 
        cmbIdCita.DropDownStyle = ComboBoxStyle.DropDownList
        cmbIdCita.FormattingEnabled = True
        cmbIdCita.Location = New Point(198, 58)
        cmbIdCita.Name = "cmbIdCita"
        cmbIdCita.Size = New Size(121, 23)
        cmbIdCita.TabIndex = 46
        ' 
        ' dgvConsultas
        ' 
        dgvConsultas.AllowUserToAddRows = False
        dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvConsultas.Location = New Point(348, 56)
        dgvConsultas.MultiSelect = False
        dgvConsultas.Name = "dgvConsultas"
        dgvConsultas.ReadOnly = True
        dgvConsultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvConsultas.Size = New Size(827, 249)
        dgvConsultas.TabIndex = 47
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 48
        Label2.Text = "Consulta"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 15)
        Label3.TabIndex = 49
        Label3.Text = "Diagnostico"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 145)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 15)
        Label4.TabIndex = 50
        Label4.Text = "Observaciones"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(198, 40)
        Label5.Name = "Label5"
        Label5.Size = New Size(28, 15)
        Label5.TabIndex = 51
        Label5.Text = "Cita"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(27, 208)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 15)
        Label6.TabIndex = 52
        Label6.Text = "Buscar"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(20, 235)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(100, 23)
        txtBuscar.TabIndex = 53
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1187, 501)
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
        Controls.Add(btnNuevo)
        Controls.Add(btnRegresar)
        Controls.Add(Label1)
        Name = "Form6"
        Text = "Form6"
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
    Friend WithEvents btnNuevo As Button
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
