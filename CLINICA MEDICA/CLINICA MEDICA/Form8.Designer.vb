<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        rdbCitasDia = New RadioButton()
        rdbHistorial = New RadioButton()
        rdbMedicos = New RadioButton()
        cmbFiltroSeleccion = New ComboBox()
        dgvResultados = New DataGridView()
        btnGenerar = New Button()
        btnLimpiar = New Button()
        btnPrimero = New Button()
        btnAnterior = New Button()
        btnSiguiente = New Button()
        btnUltimo = New Button()
        btnSalir = New Button()
        lblFiltro = New Label()
        CType(dgvResultados, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(242, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(431, 26)
        Label1.TabIndex = 3
        Label1.Text = "Formulario de Reportes y Estadisticas"
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
        ' rdbCitasDia
        ' 
        rdbCitasDia.AutoSize = True
        rdbCitasDia.Location = New Point(14, 66)
        rdbCitasDia.Name = "rdbCitasDia"
        rdbCitasDia.Size = New Size(219, 24)
        rdbCitasDia.TabIndex = 17
        rdbCitasDia.TabStop = True
        rdbCitasDia.Text = "Citas Programadas para Hoy"
        rdbCitasDia.UseVisualStyleBackColor = True
        ' 
        ' rdbHistorial
        ' 
        rdbHistorial.AutoSize = True
        rdbHistorial.Location = New Point(14, 96)
        rdbHistorial.Name = "rdbHistorial"
        rdbHistorial.Size = New Size(221, 24)
        rdbHistorial.TabIndex = 18
        rdbHistorial.TabStop = True
        rdbHistorial.Text = "Historial Clínico por Paciente"
        rdbHistorial.UseVisualStyleBackColor = True
        ' 
        ' rdbMedicos
        ' 
        rdbMedicos.AutoSize = True
        rdbMedicos.Location = New Point(12, 126)
        rdbMedicos.Name = "rdbMedicos"
        rdbMedicos.Size = New Size(203, 24)
        rdbMedicos.TabIndex = 19
        rdbMedicos.TabStop = True
        rdbMedicos.Text = "Productividad de Médicos"
        rdbMedicos.UseVisualStyleBackColor = True
        ' 
        ' cmbFiltroSeleccion
        ' 
        cmbFiltroSeleccion.FormattingEnabled = True
        cmbFiltroSeleccion.Location = New Point(14, 223)
        cmbFiltroSeleccion.Name = "cmbFiltroSeleccion"
        cmbFiltroSeleccion.Size = New Size(151, 28)
        cmbFiltroSeleccion.TabIndex = 20
        ' 
        ' dgvResultados
        ' 
        dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvResultados.Location = New Point(490, 66)
        dgvResultados.Name = "dgvResultados"
        dgvResultados.RowHeadersWidth = 51
        dgvResultados.Size = New Size(678, 295)
        dgvResultados.TabIndex = 21
        ' 
        ' btnGenerar
        ' 
        btnGenerar.Location = New Point(507, 435)
        btnGenerar.Name = "btnGenerar"
        btnGenerar.Size = New Size(137, 29)
        btnGenerar.TabIndex = 22
        btnGenerar.Text = "Generar Reporte"
        btnGenerar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(661, 435)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(94, 29)
        btnLimpiar.TabIndex = 23
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(450, 502)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(94, 29)
        btnPrimero.TabIndex = 24
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(550, 502)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(94, 29)
        btnAnterior.TabIndex = 25
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(650, 502)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(94, 29)
        btnSiguiente.TabIndex = 26
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(750, 502)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(94, 29)
        btnUltimo.TabIndex = 27
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(1089, 521)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(94, 67)
        btnSalir.TabIndex = 28
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' lblFiltro
        ' 
        lblFiltro.AutoSize = True
        lblFiltro.Location = New Point(58, 191)
        lblFiltro.Name = "lblFiltro"
        lblFiltro.Size = New Size(53, 20)
        lblFiltro.TabIndex = 29
        lblFiltro.Text = "Label2"
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1195, 600)
        Controls.Add(lblFiltro)
        Controls.Add(btnSalir)
        Controls.Add(btnUltimo)
        Controls.Add(btnSiguiente)
        Controls.Add(btnAnterior)
        Controls.Add(btnPrimero)
        Controls.Add(btnLimpiar)
        Controls.Add(btnGenerar)
        Controls.Add(dgvResultados)
        Controls.Add(cmbFiltroSeleccion)
        Controls.Add(rdbMedicos)
        Controls.Add(rdbHistorial)
        Controls.Add(rdbCitasDia)
        Controls.Add(btnRegresar)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form8"
        Text = "Form8"
        CType(dgvResultados, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents rdbCitasDia As RadioButton
    Friend WithEvents rdbHistorial As RadioButton
    Friend WithEvents rdbMedicos As RadioButton
    Friend WithEvents cmbFiltroSeleccion As ComboBox
    Friend WithEvents dgvResultados As DataGridView
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblFiltro As Label
End Class
