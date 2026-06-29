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
        btnNuevo = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnSalir = New Button()
        btnRegresar = New Button()
        CType(dgvDisponibilidad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtIdDisponibilidad
        ' 
        txtIdDisponibilidad.Location = New Point(58, 70)
        txtIdDisponibilidad.Name = "txtIdDisponibilidad"
        txtIdDisponibilidad.Size = New Size(125, 27)
        txtIdDisponibilidad.TabIndex = 0
        ' 
        ' cmbMedico
        ' 
        cmbMedico.FormattingEnabled = True
        cmbMedico.Location = New Point(47, 147)
        cmbMedico.Name = "cmbMedico"
        cmbMedico.Size = New Size(151, 28)
        cmbMedico.TabIndex = 1
        ' 
        ' dtpHoraInicio
        ' 
        dtpHoraInicio.Format = DateTimePickerFormat.Time
        dtpHoraInicio.Location = New Point(58, 238)
        dtpHoraInicio.Name = "dtpHoraInicio"
        dtpHoraInicio.ShowUpDown = True
        dtpHoraInicio.Size = New Size(112, 27)
        dtpHoraInicio.TabIndex = 2
        ' 
        ' dtpHoraFin
        ' 
        dtpHoraFin.Format = DateTimePickerFormat.Time
        dtpHoraFin.Location = New Point(58, 301)
        dtpHoraFin.Name = "dtpHoraFin"
        dtpHoraFin.ShowUpDown = True
        dtpHoraFin.Size = New Size(113, 27)
        dtpHoraFin.TabIndex = 3
        ' 
        ' dgvDisponibilidad
        ' 
        dgvDisponibilidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDisponibilidad.Location = New Point(442, 70)
        dgvDisponibilidad.Name = "dgvDisponibilidad"
        dgvDisponibilidad.RowHeadersWidth = 51
        dgvDisponibilidad.Size = New Size(538, 218)
        dgvDisponibilidad.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(59, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 20)
        Label1.TabIndex = 11
        Label1.Text = "Id Disponibilidad"
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(673, 362)
        btnUltimo.Margin = New Padding(3, 4, 3, 4)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(86, 31)
        btnUltimo.TabIndex = 50
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(581, 362)
        btnSiguiente.Margin = New Padding(3, 4, 3, 4)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(86, 31)
        btnSiguiente.TabIndex = 49
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(489, 362)
        btnAnterior.Margin = New Padding(3, 4, 3, 4)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(86, 31)
        btnAnterior.TabIndex = 48
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(397, 362)
        btnPrimero.Margin = New Padding(3, 4, 3, 4)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(86, 31)
        btnPrimero.TabIndex = 47
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(151, 409)
        btnLimpiar.Margin = New Padding(3, 4, 3, 4)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(86, 31)
        btnLimpiar.TabIndex = 46
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(243, 409)
        btnEliminar.Margin = New Padding(3, 4, 3, 4)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(86, 31)
        btnEliminar.TabIndex = 45
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(264, 363)
        btnEditar.Margin = New Padding(3, 4, 3, 4)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(91, 29)
        btnEditar.TabIndex = 44
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(167, 363)
        btnGuardar.Margin = New Padding(3, 4, 3, 4)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(91, 31)
        btnGuardar.TabIndex = 43
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(75, 363)
        btnNuevo.Margin = New Padding(3, 4, 3, 4)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(86, 31)
        btnNuevo.TabIndex = 42
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(90, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 20)
        Label2.TabIndex = 51
        Label2.Text = "Medico"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(86, 278)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 20)
        Label3.TabIndex = 52
        Label3.Text = "Hora fin"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(79, 215)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 20)
        Label4.TabIndex = 53
        Label4.Text = "Hora inicio"
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(714, 463)
        btnSalir.Margin = New Padding(3, 4, 3, 4)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(123, 32)
        btnSalir.TabIndex = 55
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(530, 463)
        btnRegresar.Margin = New Padding(3, 4, 3, 4)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(123, 32)
        btnRegresar.TabIndex = 54
        btnRegresar.Text = "Menú principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' Form11
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1134, 508)
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
        Controls.Add(btnNuevo)
        Controls.Add(Label1)
        Controls.Add(dgvDisponibilidad)
        Controls.Add(dtpHoraFin)
        Controls.Add(dtpHoraInicio)
        Controls.Add(cmbMedico)
        Controls.Add(txtIdDisponibilidad)
        Name = "Form11"
        Text = "Form11"
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
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnRegresar As Button
End Class
