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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtIdConsulta = New System.Windows.Forms.TextBox()
        Me.txtDiagnostico = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.dgvConsultas = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEstatura = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSintomas = New System.Windows.Forms.TextBox()
        Me.dtpFechaConsulta = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpHoraConsulta = New System.Windows.Forms.DateTimePicker()
        Me.txtCita = New System.Windows.Forms.TextBox()
        CType(Me.dgvConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' Label1
        ' 
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(446, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Módulo de consultas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ' 
        ' btnRegresar
        ' 
        Me.btnRegresar.Location = New System.Drawing.Point(14, 585)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(123, 67)
        Me.btnRegresar.TabIndex = 16
        Me.btnRegresar.Text = "Menú principal"
        Me.btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 
        Me.btnUltimo.Location = New System.Drawing.Point(935, 455)
        Me.btnUltimo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(86, 31)
        Me.btnUltimo.TabIndex = 41
        Me.btnUltimo.Text = ">>"
        Me.btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        Me.btnSiguiente.Location = New System.Drawing.Point(843, 455)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(86, 31)
        Me.btnSiguiente.TabIndex = 40
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        Me.btnAnterior.Location = New System.Drawing.Point(751, 455)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(86, 31)
        Me.btnAnterior.TabIndex = 39
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        Me.btnPrimero.Location = New System.Drawing.Point(659, 455)
        Me.btnPrimero.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(86, 31)
        Me.btnPrimero.TabIndex = 38
        Me.btnPrimero.Text = "<<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        Me.btnLimpiar.Location = New System.Drawing.Point(413, 502)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(86, 31)
        Me.btnLimpiar.TabIndex = 37
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        Me.btnEliminar.Location = New System.Drawing.Point(505, 502)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(86, 31)
        Me.btnEliminar.TabIndex = 36
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        Me.btnEditar.Location = New System.Drawing.Point(526, 456)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(91, 29)
        Me.btnEditar.TabIndex = 35
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        Me.btnGuardar.Location = New System.Drawing.Point(429, 456)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(91, 31)
        Me.btnGuardar.TabIndex = 34
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        Me.btnNuevo.Location = New System.Drawing.Point(337, 456)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(86, 31)
        Me.btnNuevo.TabIndex = 33
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        Me.btnSalir.Location = New System.Drawing.Point(1219, 585)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(123, 67)
        Me.btnSalir.TabIndex = 42
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        ' 
        ' txtIdConsulta
        ' 
        Me.txtIdConsulta.Enabled = False
        Me.txtIdConsulta.Location = New System.Drawing.Point(23, 50)
        Me.txtIdConsulta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdConsulta.Name = "txtIdConsulta"
        Me.txtIdConsulta.Size = New System.Drawing.Size(114, 27)
        Me.txtIdConsulta.TabIndex = 43
        Me.txtIdConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        ' 
        ' txtDiagnostico
        ' 
        Me.txtDiagnostico.Location = New System.Drawing.Point(20, 109)
        Me.txtDiagnostico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDiagnostico.Multiline = True
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDiagnostico.Size = New System.Drawing.Size(114, 29)
        Me.txtDiagnostico.TabIndex = 44
        ' 
        ' txtObservaciones
        ' 
        Me.txtObservaciones.Location = New System.Drawing.Point(20, 177)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(114, 29)
        Me.txtObservaciones.TabIndex = 45
        ' 
        ' dgvConsultas
        ' 
        Me.dgvConsultas.AllowUserToAddRows = False
        Me.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultas.Location = New System.Drawing.Point(303, 75)
        Me.dgvConsultas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvConsultas.MultiSelect = False
        Me.dgvConsultas.Name = "dgvConsultas"
        Me.dgvConsultas.ReadOnly = True
        Me.dgvConsultas.RowHeadersWidth = 51
        Me.dgvConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsultas.Size = New System.Drawing.Size(1050, 332)
        Me.dgvConsultas.TabIndex = 47
        ' 
        ' Label2
        ' 
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Identificador de la consulta:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Diagnóstico:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Observaciones:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(206, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 20)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Identificador de la cita:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 446)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 20)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Búsqueda:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ' 
        ' txtBuscar
        ' 
        Me.txtBuscar.Location = New System.Drawing.Point(23, 470)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(114, 27)
        Me.txtBuscar.TabIndex = 53
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        ' 
        ' txtPeso
        ' 
        Me.txtPeso.Location = New System.Drawing.Point(20, 246)
        Me.txtPeso.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(114, 27)
        Me.txtPeso.TabIndex = 54
        ' 
        ' Label7
        ' 
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 20)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Peso (kg)"
        ' 
        ' Label8
        ' 
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 289)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 20)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Estatura (m)"
        ' 
        ' txtEstatura
        ' 
        Me.txtEstatura.Location = New System.Drawing.Point(20, 313)
        Me.txtEstatura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEstatura.Name = "txtEstatura"
        Me.txtEstatura.Size = New System.Drawing.Size(114, 27)
        Me.txtEstatura.TabIndex = 57
        ' 
        ' Label9
        ' 
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 359)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 20)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Sintomas"
        ' 
        ' txtSintomas
        ' 
        Me.txtSintomas.Location = New System.Drawing.Point(20, 395)
        Me.txtSintomas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSintomas.Multiline = True
        Me.txtSintomas.Name = "txtSintomas"
        Me.txtSintomas.Size = New System.Drawing.Size(114, 27)
        Me.txtSintomas.TabIndex = 59
        ' 
        ' dtpFechaConsulta
        ' 
        Me.dtpFechaConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaConsulta.Location = New System.Drawing.Point(159, 330)
        Me.dtpFechaConsulta.Name = "dtpFechaConsulta"
        Me.dtpFechaConsulta.Size = New System.Drawing.Size(124, 27)
        Me.dtpFechaConsulta.TabIndex = 60
        ' 
        ' Label10
        ' 
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(159, 306)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 20)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Fecha de consulta"
        ' 
        ' Label11
        ' 
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(164, 386)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 20)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Hora de consulta"
        ' 
        ' dtpHoraConsulta
        ' 
        Me.dtpHoraConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraConsulta.Location = New System.Drawing.Point(159, 409)
        Me.dtpHoraConsulta.Name = "dtpHoraConsulta"
        Me.dtpHoraConsulta.ShowUpDown = True
        Me.dtpHoraConsulta.Size = New System.Drawing.Size(124, 27)
        Me.dtpHoraConsulta.TabIndex = 63
        ' 
        ' txtCita
        ' 
        Me.txtCita.Location = New System.Drawing.Point(172, 51)
        Me.txtCita.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCita.Name = "txtCita"
        Me.txtCita.Size = New System.Drawing.Size(114, 27)
        Me.txtCita.TabIndex = 64
        ' 
        ' Form6
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1357, 668)
        Me.Controls.Add(Me.txtCita)
        Me.Controls.Add(Me.dtpHoraConsulta)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpFechaConsulta)
        Me.Controls.Add(Me.txtSintomas)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtEstatura)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvConsultas)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtDiagnostico)
        Me.Controls.Add(Me.txtIdConsulta)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnPrimero)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form6"
        Me.Text = "Consultas"
        CType(Me.dgvConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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