<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        btnModuloPacientes = New Button()
        btnModuloMedicos = New Button()
        btnModuloEspecialidades = New Button()
        btnModuloCitas = New Button()
        btnModuloConsultas = New Button()
        btnModuloRecetas = New Button()
        btnModuloReportes = New Button()
        btnSalir = New Button()
        lblFechaActual = New Label()
        lblNumPacientes = New Label()
        lblNumMedicos = New Label()
        lblNumCitas = New Label()
        lblNumConsultas = New Label()
        btnProbarConexion = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(325, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 26)
        Label1.TabIndex = 1
        Label1.Text = "MENU"
        ' 
        ' btnModuloPacientes
        ' 
        btnModuloPacientes.Location = New Point(50, 83)
        btnModuloPacientes.Name = "btnModuloPacientes"
        btnModuloPacientes.Size = New Size(169, 29)
        btnModuloPacientes.TabIndex = 2
        btnModuloPacientes.Text = "Gestion de Pacientes"
        btnModuloPacientes.UseVisualStyleBackColor = True
        ' 
        ' btnModuloMedicos
        ' 
        btnModuloMedicos.Location = New Point(296, 83)
        btnModuloMedicos.Name = "btnModuloMedicos"
        btnModuloMedicos.Size = New Size(187, 29)
        btnModuloMedicos.TabIndex = 3
        btnModuloMedicos.Text = "Mantenimiento Medicos"
        btnModuloMedicos.UseVisualStyleBackColor = True
        ' 
        ' btnModuloEspecialidades
        ' 
        btnModuloEspecialidades.Location = New Point(559, 83)
        btnModuloEspecialidades.Name = "btnModuloEspecialidades"
        btnModuloEspecialidades.Size = New Size(179, 29)
        btnModuloEspecialidades.TabIndex = 4
        btnModuloEspecialidades.Text = "Especialidades Medicas"
        btnModuloEspecialidades.UseVisualStyleBackColor = True
        ' 
        ' btnModuloCitas
        ' 
        btnModuloCitas.Location = New Point(50, 164)
        btnModuloCitas.Name = "btnModuloCitas"
        btnModuloCitas.Size = New Size(169, 29)
        btnModuloCitas.TabIndex = 5
        btnModuloCitas.Text = "Agenda de Citas"
        btnModuloCitas.UseVisualStyleBackColor = True
        ' 
        ' btnModuloConsultas
        ' 
        btnModuloConsultas.Location = New Point(296, 164)
        btnModuloConsultas.Name = "btnModuloConsultas"
        btnModuloConsultas.Size = New Size(187, 29)
        btnModuloConsultas.TabIndex = 6
        btnModuloConsultas.Text = "Consultas Clinicas"
        btnModuloConsultas.UseVisualStyleBackColor = True
        ' 
        ' btnModuloRecetas
        ' 
        btnModuloRecetas.Location = New Point(559, 164)
        btnModuloRecetas.Name = "btnModuloRecetas"
        btnModuloRecetas.Size = New Size(179, 29)
        btnModuloRecetas.TabIndex = 7
        btnModuloRecetas.Text = "Control de Recetas"
        btnModuloRecetas.UseVisualStyleBackColor = True
        ' 
        ' btnModuloReportes
        ' 
        btnModuloReportes.Location = New Point(296, 236)
        btnModuloReportes.Name = "btnModuloReportes"
        btnModuloReportes.Size = New Size(187, 29)
        btnModuloReportes.TabIndex = 8
        btnModuloReportes.Text = "Reportes y Estadisticas"
        btnModuloReportes.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(323, 411)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(94, 29)
        btnSalir.TabIndex = 9
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' lblFechaActual
        ' 
        lblFechaActual.AutoSize = True
        lblFechaActual.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFechaActual.Location = New Point(21, 313)
        lblFechaActual.Name = "lblFechaActual"
        lblFechaActual.Size = New Size(20, 23)
        lblFechaActual.TabIndex = 10
        lblFechaActual.Text = "1"
        ' 
        ' lblNumPacientes
        ' 
        lblNumPacientes.AutoSize = True
        lblNumPacientes.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumPacientes.Location = New Point(21, 411)
        lblNumPacientes.Name = "lblNumPacientes"
        lblNumPacientes.Size = New Size(20, 23)
        lblNumPacientes.TabIndex = 11
        lblNumPacientes.Text = "2"
        ' 
        ' lblNumMedicos
        ' 
        lblNumMedicos.AutoSize = True
        lblNumMedicos.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumMedicos.Location = New Point(367, 341)
        lblNumMedicos.Name = "lblNumMedicos"
        lblNumMedicos.Size = New Size(20, 23)
        lblNumMedicos.TabIndex = 12
        lblNumMedicos.Text = "3"
        ' 
        ' lblNumCitas
        ' 
        lblNumCitas.AutoSize = True
        lblNumCitas.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumCitas.Location = New Point(672, 315)
        lblNumCitas.Name = "lblNumCitas"
        lblNumCitas.Size = New Size(20, 23)
        lblNumCitas.TabIndex = 13
        lblNumCitas.Text = "4"
        ' 
        ' lblNumConsultas
        ' 
        lblNumConsultas.AutoSize = True
        lblNumConsultas.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumConsultas.Location = New Point(672, 411)
        lblNumConsultas.Name = "lblNumConsultas"
        lblNumConsultas.Size = New Size(20, 23)
        lblNumConsultas.TabIndex = 14
        lblNumConsultas.Text = "5"
        ' 
        ' btnProbarConexion
        ' 
        btnProbarConexion.Location = New Point(70, 236)
        btnProbarConexion.Name = "btnProbarConexion"
        btnProbarConexion.Size = New Size(138, 29)
        btnProbarConexion.TabIndex = 15
        btnProbarConexion.Text = "Boton de Prueba"
        btnProbarConexion.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 451)
        Controls.Add(btnProbarConexion)
        Controls.Add(lblNumConsultas)
        Controls.Add(lblNumCitas)
        Controls.Add(lblNumMedicos)
        Controls.Add(lblNumPacientes)
        Controls.Add(lblFechaActual)
        Controls.Add(btnSalir)
        Controls.Add(btnModuloReportes)
        Controls.Add(btnModuloRecetas)
        Controls.Add(btnModuloConsultas)
        Controls.Add(btnModuloCitas)
        Controls.Add(btnModuloEspecialidades)
        Controls.Add(btnModuloMedicos)
        Controls.Add(btnModuloPacientes)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Ejemplo"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnModuloPacientes As Button
    Friend WithEvents btnModuloMedicos As Button
    Friend WithEvents btnModuloEspecialidades As Button
    Friend WithEvents btnModuloCitas As Button
    Friend WithEvents btnModuloConsultas As Button
    Friend WithEvents btnModuloRecetas As Button
    Friend WithEvents btnModuloReportes As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblFechaActual As Label
    Friend WithEvents lblNumPacientes As Label
    Friend WithEvents lblNumMedicos As Label
    Friend WithEvents lblNumCitas As Label
    Friend WithEvents lblNumConsultas As Label
    Friend WithEvents btnProbarConexion As Button

End Class
