<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtIdDisponibilidad = New TextBox()
        cmbMedico = New ComboBox()
        dtpHoraInicio = New DateTimePicker()
        dtpHoraFin = New DateTimePicker()
        dgvDisponibilidad = New DataGridView()
        Label1 = New Label()
        btnUltimo = New Button()
        btnSiguiente = New Button()
        btnAnterior = New Button()
        btnPrimero = New Button()
        btnLimpiar = New Button()
        btnEliminar = New Button()
        btnEditar = New Button()
        btnGuardar = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnSalir = New Button()
        btnRegresar = New Button()
        Label7 = New Label()
        CType(dgvDisponibilidad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtIdDisponibilidad
        ' 
        txtIdDisponibilidad.Location = New Point(237, 206)
        txtIdDisponibilidad.Margin = New Padding(3, 2, 3, 2)
        txtIdDisponibilidad.Name = "txtIdDisponibilidad"
        txtIdDisponibilidad.Size = New Size(151, 27)
        txtIdDisponibilidad.TabIndex = 0
        txtIdDisponibilidad.TextAlign = HorizontalAlignment.Center
        ' 
        ' cmbMedico
        ' 
        cmbMedico.FormattingEnabled = True
        cmbMedico.Location = New Point(237, 237)
        cmbMedico.Margin = New Padding(3, 2, 3, 2)
        cmbMedico.Name = "cmbMedico"
        cmbMedico.Size = New Size(151, 24)
        cmbMedico.TabIndex = 1
        ' 
        ' dtpHoraInicio
        ' 
        dtpHoraInicio.Format = DateTimePickerFormat.Time
        dtpHoraInicio.Location = New Point(237, 265)
        dtpHoraInicio.Margin = New Padding(3, 2, 3, 2)
        dtpHoraInicio.Name = "dtpHoraInicio"
        dtpHoraInicio.ShowUpDown = True
        dtpHoraInicio.Size = New Size(151, 27)
        dtpHoraInicio.TabIndex = 2
        ' 
        ' dtpHoraFin
        ' 
        dtpHoraFin.Format = DateTimePickerFormat.Time
        dtpHoraFin.Location = New Point(237, 296)
        dtpHoraFin.Margin = New Padding(3, 2, 3, 2)
        dtpHoraFin.Name = "dtpHoraFin"
        dtpHoraFin.ShowUpDown = True
        dtpHoraFin.Size = New Size(151, 27)
        dtpHoraFin.TabIndex = 3
        ' 
        ' dgvDisponibilidad
        ' 
        dgvDisponibilidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDisponibilidad.Location = New Point(12, 27)
        dgvDisponibilidad.Margin = New Padding(3, 2, 3, 2)
        dgvDisponibilidad.Name = "dgvDisponibilidad"
        dgvDisponibilidad.RowHeadersWidth = 51
        dgvDisponibilidad.Size = New Size(1110, 175)
        dgvDisponibilidad.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 209)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 16)
        Label1.TabIndex = 11
        Label1.Text = "Identificador de la disponibilidad:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(1036, 267)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(86, 56)
        btnUltimo.TabIndex = 50
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(1036, 207)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(86, 54)
        btnSiguiente.TabIndex = 49
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(944, 207)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(86, 54)
        btnAnterior.TabIndex = 48
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(944, 267)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(86, 56)
        btnPrimero.TabIndex = 47
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(680, 207)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(86, 54)
        btnLimpiar.TabIndex = 46
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(588, 207)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(86, 54)
        btnEliminar.TabIndex = 45
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(491, 207)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(91, 54)
        btnEditar.TabIndex = 44
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(394, 207)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(91, 54)
        btnGuardar.TabIndex = 43
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 240)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 16)
        Label2.TabIndex = 51
        Label2.Text = "Médico:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 303)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 16)
        Label3.TabIndex = 52
        Label3.Text = "Hora de fin:"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 272)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 16)
        Label4.TabIndex = 53
        Label4.Text = "Hora de inicio:"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(588, 267)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(178, 56)
        btnSalir.TabIndex = 55
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(394, 267)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(188, 56)
        btnRegresar.TabIndex = 54
        btnRegresar.Text = "Menú principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(14, 9)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(278, 16)
        Label7.TabIndex = 56
        Label7.Text = "Módulo de disponibilidad de médicos"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form11
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1134, 338)
        Controls.Add(Label7)
        Controls.Add(btnSalir)
        Controls.Add(btnRegresar)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnUltimo)
        Controls.Add(btnSiguiente)
        Controls.Add(btnAnterior)
        Controls.Add(btnPrimero)
        Controls.Add(btnLimpiar)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnGuardar)
        Controls.Add(Label1)
        Controls.Add(dgvDisponibilidad)
        Controls.Add(dtpHoraFin)
        Controls.Add(dtpHoraInicio)
        Controls.Add(cmbMedico)
        Controls.Add(txtIdDisponibilidad)
        Font = New Font("Lucida Sans Unicode", 9.75F)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form11"
        Text = "Disponibilidad de médicos"
        CType(dgvDisponibilidad, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIdDisponibilidad As TextBox
    Friend WithEvents cmbMedico As ComboBox
    Friend WithEvents dtpHoraInicio As DateTimePicker
    Friend WithEvents dtpHoraFin As DateTimePicker
    Friend WithEvents dgvDisponibilidad As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents Label7 As Label
End Class
