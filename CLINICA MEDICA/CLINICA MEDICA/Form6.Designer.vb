<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        dgvConsultas = New DataGridView()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtBuscar = New TextBox()
        txtPeso = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        txtEstatura = New TextBox()
        Label9 = New Label()
        txtSintomas = New TextBox()
        dtpFechaConsulta = New DateTimePicker()
        Label10 = New Label()
        Label11 = New Label()
        dtpHoraConsulta = New DateTimePicker()
        txtCita = New TextBox()
        CType(dgvConsultas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(446, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(243, 26)
        Label1.TabIndex = 3
        Label1.Text = "Módulo de consultas"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(14, 585)
        btnRegresar.Margin = New Padding(3, 4, 3, 4)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(123, 67)
        btnRegresar.TabIndex = 16
        btnRegresar.Text = "Menú principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(935, 455)
        btnUltimo.Margin = New Padding(3, 4, 3, 4)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(86, 31)
        btnUltimo.TabIndex = 41
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(843, 455)
        btnSiguiente.Margin = New Padding(3, 4, 3, 4)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(86, 31)
        btnSiguiente.TabIndex = 40
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(751, 455)
        btnAnterior.Margin = New Padding(3, 4, 3, 4)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(86, 31)
        btnAnterior.TabIndex = 39
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(659, 455)
        btnPrimero.Margin = New Padding(3, 4, 3, 4)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(86, 31)
        btnPrimero.TabIndex = 38
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(413, 502)
        btnLimpiar.Margin = New Padding(3, 4, 3, 4)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(86, 31)
        btnLimpiar.TabIndex = 37
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(505, 502)
        btnEliminar.Margin = New Padding(3, 4, 3, 4)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(86, 31)
        btnEliminar.TabIndex = 36
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(526, 456)
        btnEditar.Margin = New Padding(3, 4, 3, 4)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(91, 29)
        btnEditar.TabIndex = 35
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(429, 456)
        btnGuardar.Margin = New Padding(3, 4, 3, 4)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(91, 31)
        btnGuardar.TabIndex = 34
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(337, 456)
        btnNuevo.Margin = New Padding(3, 4, 3, 4)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(86, 31)
        btnNuevo.TabIndex = 33
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(1219, 585)
        btnSalir.Margin = New Padding(3, 4, 3, 4)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(123, 67)
        btnSalir.TabIndex = 42
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' txtIdConsulta
        ' 
        txtIdConsulta.Enabled = False
        txtIdConsulta.Location = New Point(23, 50)
        txtIdConsulta.Margin = New Padding(3, 4, 3, 4)
        txtIdConsulta.Name = "txtIdConsulta"
        txtIdConsulta.Size = New Size(114, 27)
        txtIdConsulta.TabIndex = 43
        txtIdConsulta.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtDiagnostico
        ' 
        txtDiagnostico.Location = New Point(20, 109)
        txtDiagnostico.Margin = New Padding(3, 4, 3, 4)
        txtDiagnostico.Multiline = True
        txtDiagnostico.Name = "txtDiagnostico"
        txtDiagnostico.ScrollBars = ScrollBars.Vertical
        txtDiagnostico.Size = New Size(114, 29)
        txtDiagnostico.TabIndex = 44
        ' 
        ' txtObservaciones
        ' 
        txtObservaciones.Location = New Point(20, 177)
        txtObservaciones.Margin = New Padding(3, 4, 3, 4)
        txtObservaciones.Multiline = True
        txtObservaciones.Name = "txtObservaciones"
        txtObservaciones.ScrollBars = ScrollBars.Vertical
        txtObservaciones.Size = New Size(114, 29)
        txtObservaciones.TabIndex = 45
        ' 
        ' dgvConsultas
        ' 
        dgvConsultas.AllowUserToAddRows = False
        dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvConsultas.Location = New Point(303, 75)
        dgvConsultas.Margin = New Padding(3, 4, 3, 4)
        dgvConsultas.MultiSelect = False
        dgvConsultas.Name = "dgvConsultas"
        dgvConsultas.ReadOnly = True
        dgvConsultas.RowHeadersWidth = 51
        dgvConsultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvConsultas.Size = New Size(1050, 332)
        dgvConsultas.TabIndex = 47
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(193, 20)
        Label2.TabIndex = 48
        Label2.Text = "Identificador de la consulta:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 20)
        Label3.TabIndex = 49
        Label3.Text = "Diagnóstico:"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 153)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 20)
        Label4.TabIndex = 50
        Label4.Text = "Observaciones:"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(206, 27)
        Label5.Name = "Label5"
        Label5.Size = New Size(162, 20)
        Label5.TabIndex = 51
        Label5.Text = "Identificador de la cita:"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(48, 446)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 20)
        Label6.TabIndex = 52
        Label6.Text = "Búsqueda:"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(23, 470)
        txtBuscar.Margin = New Padding(3, 4, 3, 4)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(114, 27)
        txtBuscar.TabIndex = 53
        txtBuscar.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPeso
        ' 
        txtPeso.Location = New Point(20, 246)
        txtPeso.Margin = New Padding(3, 4, 3, 4)
        txtPeso.Name = "txtPeso"
        txtPeso.Size = New Size(114, 27)
        txtPeso.TabIndex = 54
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(31, 222)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 20)
        Label7.TabIndex = 55
        Label7.Text = "Peso (kg)"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(23, 289)
        Label8.Name = "Label8"
        Label8.Size = New Size(89, 20)
        Label8.TabIndex = 56
        Label8.Text = "Estatura (m)"
        ' 
        ' txtEstatura
        ' 
        txtEstatura.Location = New Point(20, 313)
        txtEstatura.Margin = New Padding(3, 4, 3, 4)
        txtEstatura.Name = "txtEstatura"
        txtEstatura.Size = New Size(114, 27)
        txtEstatura.TabIndex = 57
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(30, 359)
        Label9.Name = "Label9"
        Label9.Size = New Size(70, 20)
        Label9.TabIndex = 58
        Label9.Text = "Sintomas"
        ' 
        ' txtSintomas
        ' 
        txtSintomas.Location = New Point(20, 395)
        txtSintomas.Margin = New Padding(3, 4, 3, 4)
        txtSintomas.Multiline = True
        txtSintomas.Name = "txtSintomas"
        txtSintomas.Size = New Size(114, 27)
        txtSintomas.TabIndex = 59
        ' 
        ' dtpFechaConsulta
        ' 
        dtpFechaConsulta.Format = DateTimePickerFormat.Short
        dtpFechaConsulta.Location = New Point(159, 330)
        dtpFechaConsulta.Name = "dtpFechaConsulta"
        dtpFechaConsulta.Size = New Size(124, 27)
        dtpFechaConsulta.TabIndex = 60
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(159, 306)
        Label10.Name = "Label10"
        Label10.Size = New Size(127, 20)
        Label10.TabIndex = 61
        Label10.Text = "Fecha de consulta"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(164, 386)
        Label11.Name = "Label11"
        Label11.Size = New Size(122, 20)
        Label11.TabIndex = 62
        Label11.Text = "Hora de consulta"
        ' 
        ' dtpHoraConsulta
        ' 
        dtpHoraConsulta.Format = DateTimePickerFormat.Time
        dtpHoraConsulta.Location = New Point(159, 409)
        dtpHoraConsulta.Name = "dtpHoraConsulta"
        dtpHoraConsulta.ShowUpDown = True
        dtpHoraConsulta.Size = New Size(124, 27)
        dtpHoraConsulta.TabIndex = 63
        ' 
        ' txtCita
        ' 
        txtCita.Location = New Point(172, 51)
        txtCita.Margin = New Padding(3, 4, 3, 4)
        txtCita.Name = "txtCita"
        txtCita.Size = New Size(114, 27)
        txtCita.TabIndex = 64
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1357, 668)
        Controls.Add(txtCita)
        Controls.Add(dtpHoraConsulta)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(dtpFechaConsulta)
        Controls.Add(txtSintomas)
        Controls.Add(Label9)
        Controls.Add(txtEstatura)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(txtPeso)
        Controls.Add(txtBuscar)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(dgvConsultas)
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
        Margin = New Padding(3, 4, 3, 4)
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
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtIdConsulta As TextBox
    Friend WithEvents txtDiagnostico As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents dgvConsultas As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEstatura As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSintomas As TextBox
    Friend WithEvents dtpFechaConsulta As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpHoraConsulta As DateTimePicker
    Friend WithEvents txtCita As TextBox
End Class