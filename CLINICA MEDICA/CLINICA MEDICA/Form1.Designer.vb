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
        lblMenu = New Label()
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
        lblInstrucciones = New Label()
        Label1 = New Label()
        btnMedicamentos = New Button()
        Button2 = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' lblMenu
        ' 
        lblMenu.AutoSize = True
        lblMenu.Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMenu.Location = New Point(13, 9)
        lblMenu.Margin = New Padding(4, 0, 4, 0)
        lblMenu.Name = "lblMenu"
        lblMenu.Size = New Size(140, 16)
        lblMenu.TabIndex = 1
        lblMenu.Text = "Menú de selección"
        lblMenu.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnModuloPacientes
        ' 
        btnModuloPacientes.Location = New Point(13, 54)
        btnModuloPacientes.Margin = New Padding(4, 3, 4, 3)
        btnModuloPacientes.Name = "btnModuloPacientes"
        btnModuloPacientes.Size = New Size(235, 71)
        btnModuloPacientes.TabIndex = 2
        btnModuloPacientes.Text = "Módulo de pacientes"
        btnModuloPacientes.UseVisualStyleBackColor = True
        ' 
        ' btnModuloMedicos
        ' 
        btnModuloMedicos.Location = New Point(256, 54)
        btnModuloMedicos.Margin = New Padding(4, 3, 4, 3)
        btnModuloMedicos.Name = "btnModuloMedicos"
        btnModuloMedicos.Size = New Size(235, 71)
        btnModuloMedicos.TabIndex = 3
        btnModuloMedicos.Text = "Módulo de médicos"
        btnModuloMedicos.UseVisualStyleBackColor = True
        ' 
        ' btnModuloEspecialidades
        ' 
        btnModuloEspecialidades.Location = New Point(13, 131)
        btnModuloEspecialidades.Margin = New Padding(4, 3, 4, 3)
        btnModuloEspecialidades.Name = "btnModuloEspecialidades"
        btnModuloEspecialidades.Size = New Size(235, 71)
        btnModuloEspecialidades.TabIndex = 4
        btnModuloEspecialidades.Text = "Módulo de especialidades médicas"
        btnModuloEspecialidades.UseVisualStyleBackColor = True
        ' 
        ' btnModuloCitas
        ' 
        btnModuloCitas.Location = New Point(256, 131)
        btnModuloCitas.Margin = New Padding(4, 3, 4, 3)
        btnModuloCitas.Name = "btnModuloCitas"
        btnModuloCitas.Size = New Size(235, 71)
        btnModuloCitas.TabIndex = 5
        btnModuloCitas.Text = "Módulo de citas"
        btnModuloCitas.UseVisualStyleBackColor = True
        ' 
        ' btnModuloConsultas
        ' 
        btnModuloConsultas.Location = New Point(13, 208)
        btnModuloConsultas.Margin = New Padding(4, 3, 4, 3)
        btnModuloConsultas.Name = "btnModuloConsultas"
        btnModuloConsultas.Size = New Size(235, 71)
        btnModuloConsultas.TabIndex = 6
        btnModuloConsultas.Text = "Módulo de consultas clínicas"
        btnModuloConsultas.UseVisualStyleBackColor = True
        ' 
        ' btnModuloRecetas
        ' 
        btnModuloRecetas.Location = New Point(256, 208)
        btnModuloRecetas.Margin = New Padding(4, 3, 4, 3)
        btnModuloRecetas.Name = "btnModuloRecetas"
        btnModuloRecetas.Size = New Size(235, 71)
        btnModuloRecetas.TabIndex = 7
        btnModuloRecetas.Text = "Módulo de recetas"
        btnModuloRecetas.UseVisualStyleBackColor = True
        ' 
        ' btnModuloReportes
        ' 
        btnModuloReportes.Location = New Point(13, 285)
        btnModuloReportes.Margin = New Padding(4, 3, 4, 3)
        btnModuloReportes.Name = "btnModuloReportes"
        btnModuloReportes.Size = New Size(235, 71)
        btnModuloReportes.TabIndex = 8
        btnModuloReportes.Text = "Módulo de reportes y estadísticas"
        btnModuloReportes.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(256, 285)
        btnSalir.Margin = New Padding(4, 3, 4, 3)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(477, 71)
        btnSalir.TabIndex = 9
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' lblFechaActual
        ' 
        lblFechaActual.AutoSize = True
        lblFechaActual.Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold)
        lblFechaActual.Location = New Point(12, 375)
        lblFechaActual.Margin = New Padding(4, 0, 4, 0)
        lblFechaActual.Name = "lblFechaActual"
        lblFechaActual.Size = New Size(16, 16)
        lblFechaActual.TabIndex = 10
        lblFechaActual.Text = "1"
        lblFechaActual.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblNumPacientes
        ' 
        lblNumPacientes.AutoSize = True
        lblNumPacientes.Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold)
        lblNumPacientes.Location = New Point(12, 391)
        lblNumPacientes.Margin = New Padding(4, 0, 4, 0)
        lblNumPacientes.Name = "lblNumPacientes"
        lblNumPacientes.Size = New Size(16, 16)
        lblNumPacientes.TabIndex = 11
        lblNumPacientes.Text = "2"
        lblNumPacientes.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblNumMedicos
        ' 
        lblNumMedicos.AutoSize = True
        lblNumMedicos.Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold)
        lblNumMedicos.Location = New Point(12, 407)
        lblNumMedicos.Margin = New Padding(4, 0, 4, 0)
        lblNumMedicos.Name = "lblNumMedicos"
        lblNumMedicos.Size = New Size(16, 16)
        lblNumMedicos.TabIndex = 12
        lblNumMedicos.Text = "3"
        lblNumMedicos.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblNumCitas
        ' 
        lblNumCitas.AutoSize = True
        lblNumCitas.Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold)
        lblNumCitas.Location = New Point(12, 423)
        lblNumCitas.Margin = New Padding(4, 0, 4, 0)
        lblNumCitas.Name = "lblNumCitas"
        lblNumCitas.Size = New Size(16, 16)
        lblNumCitas.TabIndex = 13
        lblNumCitas.Text = "4"
        lblNumCitas.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblNumConsultas
        ' 
        lblNumConsultas.AutoSize = True
        lblNumConsultas.Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold)
        lblNumConsultas.Location = New Point(12, 439)
        lblNumConsultas.Margin = New Padding(4, 0, 4, 0)
        lblNumConsultas.Name = "lblNumConsultas"
        lblNumConsultas.Size = New Size(16, 16)
        lblNumConsultas.TabIndex = 14
        lblNumConsultas.Text = "5"
        lblNumConsultas.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblInstrucciones
        ' 
        lblInstrucciones.AutoSize = True
        lblInstrucciones.Location = New Point(12, 35)
        lblInstrucciones.Name = "lblInstrucciones"
        lblInstrucciones.Size = New Size(318, 16)
        lblInstrucciones.TabIndex = 15
        lblInstrucciones.Text = "Por favor, ingrese al módulo que desee consultar:"
        lblInstrucciones.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 359)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 16)
        Label1.TabIndex = 15
        Label1.Text = "Datos:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnMedicamentos
        ' 
        btnMedicamentos.Location = New Point(498, 131)
        btnMedicamentos.Name = "btnMedicamentos"
        btnMedicamentos.Size = New Size(235, 71)
        btnMedicamentos.TabIndex = 16
        btnMedicamentos.Text = "Módulo de medicamentos"
        btnMedicamentos.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(498, 54)
        Button2.Margin = New Padding(4, 3, 4, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(235, 71)
        Button2.TabIndex = 18
        Button2.Text = "Módulo de pagos"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(498, 208)
        Button1.Name = "Button1"
        Button1.Size = New Size(235, 71)
        Button1.TabIndex = 19
        Button1.Text = "Módulo de disponibilidad de médicos"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(745, 461)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(btnMedicamentos)
        Controls.Add(Label1)
        Controls.Add(lblInstrucciones)
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
        Controls.Add(lblMenu)
        Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Menú"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblMenu As Label
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
    Friend WithEvents lblInstrucciones As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMedicamentos As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button

End Class
