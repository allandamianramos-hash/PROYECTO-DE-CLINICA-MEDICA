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
        Label1.Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(252, 16)
        Label1.TabIndex = 3
        Label1.Text = "Módulo de reportes y estadísticas"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(140, 181)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(124, 23)
        btnRegresar.TabIndex = 16
        btnRegresar.Text = "Menú principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' rdbCitasDia
        ' 
        rdbCitasDia.AutoSize = True
        rdbCitasDia.Location = New Point(12, 43)
        rdbCitasDia.Margin = New Padding(3, 2, 3, 2)
        rdbCitasDia.Name = "rdbCitasDia"
        rdbCitasDia.Size = New Size(227, 20)
        rdbCitasDia.TabIndex = 17
        rdbCitasDia.TabStop = True
        rdbCitasDia.Text = "Citas programadas para este día"
        rdbCitasDia.TextAlign = ContentAlignment.MiddleCenter
        rdbCitasDia.UseVisualStyleBackColor = True
        ' 
        ' rdbHistorial
        ' 
        rdbHistorial.AutoSize = True
        rdbHistorial.Location = New Point(12, 67)
        rdbHistorial.Margin = New Padding(3, 2, 3, 2)
        rdbHistorial.Name = "rdbHistorial"
        rdbHistorial.Size = New Size(207, 20)
        rdbHistorial.TabIndex = 18
        rdbHistorial.TabStop = True
        rdbHistorial.Text = "Historial clínico por paciente"
        rdbHistorial.TextAlign = ContentAlignment.MiddleCenter
        rdbHistorial.UseVisualStyleBackColor = True
        ' 
        ' rdbMedicos
        ' 
        rdbMedicos.AutoSize = True
        rdbMedicos.Location = New Point(12, 91)
        rdbMedicos.Margin = New Padding(3, 2, 3, 2)
        rdbMedicos.Name = "rdbMedicos"
        rdbMedicos.Size = New Size(187, 20)
        rdbMedicos.TabIndex = 19
        rdbMedicos.TabStop = True
        rdbMedicos.Text = "Productividad de médicos"
        rdbMedicos.TextAlign = ContentAlignment.MiddleCenter
        rdbMedicos.UseVisualStyleBackColor = True
        ' 
        ' cmbFiltroSeleccion
        ' 
        cmbFiltroSeleccion.FormattingEnabled = True
        cmbFiltroSeleccion.Location = New Point(142, 115)
        cmbFiltroSeleccion.Margin = New Padding(3, 2, 3, 2)
        cmbFiltroSeleccion.Name = "cmbFiltroSeleccion"
        cmbFiltroSeleccion.Size = New Size(122, 24)
        cmbFiltroSeleccion.TabIndex = 20
        ' 
        ' dgvResultados
        ' 
        dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvResultados.Location = New Point(270, 43)
        dgvResultados.Margin = New Padding(3, 2, 3, 2)
        dgvResultados.Name = "dgvResultados"
        dgvResultados.RowHeadersWidth = 51
        dgvResultados.Size = New Size(678, 215)
        dgvResultados.TabIndex = 21
        ' 
        ' btnGenerar
        ' 
        btnGenerar.Location = New Point(12, 154)
        btnGenerar.Margin = New Padding(3, 2, 3, 2)
        btnGenerar.Name = "btnGenerar"
        btnGenerar.Size = New Size(124, 23)
        btnGenerar.TabIndex = 22
        btnGenerar.Text = "Generar reporte"
        btnGenerar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(140, 154)
        btnLimpiar.Margin = New Padding(3, 2, 3, 2)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(124, 23)
        btnLimpiar.TabIndex = 23
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(12, 235)
        btnPrimero.Margin = New Padding(3, 2, 3, 2)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(124, 23)
        btnPrimero.TabIndex = 24
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(12, 208)
        btnAnterior.Margin = New Padding(3, 2, 3, 2)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(124, 23)
        btnAnterior.TabIndex = 25
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(140, 208)
        btnSiguiente.Margin = New Padding(3, 2, 3, 2)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(124, 23)
        btnSiguiente.TabIndex = 26
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(140, 235)
        btnUltimo.Margin = New Padding(3, 2, 3, 2)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(124, 23)
        btnUltimo.TabIndex = 27
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(12, 181)
        btnSalir.Margin = New Padding(3, 2, 3, 2)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(124, 23)
        btnSalir.TabIndex = 28
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' lblFiltro
        ' 
        lblFiltro.AutoSize = True
        lblFiltro.Location = New Point(12, 118)
        lblFiltro.Name = "lblFiltro"
        lblFiltro.Size = New Size(124, 16)
        lblFiltro.TabIndex = 29
        lblFiltro.Text = "Selección de filtro:"
        lblFiltro.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(960, 269)
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
        Font = New Font("Lucida Sans Unicode", 9.75F)
        Name = "Form8"
        Text = "Reportes y estadísticas"
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
