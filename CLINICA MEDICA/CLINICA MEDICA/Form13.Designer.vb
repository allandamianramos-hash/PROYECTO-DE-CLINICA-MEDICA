<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
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
        dgvDetalles = New DataGridView()
        Label2 = New Label()
        btnSalir = New Button()
        btnRegresar = New Button()
        btnUltimo = New Button()
        btnSiguiente = New Button()
        btnAnterior = New Button()
        btnPrimero = New Button()
        CType(dgvDetalles, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDetalles
        ' 
        dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDetalles.Location = New Point(100, 58)
        dgvDetalles.Name = "dgvDetalles"
        dgvDetalles.RowHeadersWidth = 51
        dgvDetalles.Size = New Size(772, 188)
        dgvDetalles.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(322, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(301, 21)
        Label2.TabIndex = 3
        Label2.Text = "Módulo de Detalles de Facturas"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(333, 340)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(230, 53)
        btnSalir.TabIndex = 34
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(97, 340)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(230, 53)
        btnRegresar.TabIndex = 33
        btnRegresar.Text = "Menú principal"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' btnUltimo
        ' 
        btnUltimo.Location = New Point(776, 340)
        btnUltimo.Name = "btnUltimo"
        btnUltimo.Size = New Size(112, 53)
        btnUltimo.TabIndex = 32
        btnUltimo.Text = ">>"
        btnUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnSiguiente
        ' 
        btnSiguiente.Location = New Point(776, 281)
        btnSiguiente.Name = "btnSiguiente"
        btnSiguiente.Size = New Size(112, 53)
        btnSiguiente.TabIndex = 31
        btnSiguiente.Text = ">"
        btnSiguiente.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Location = New Point(658, 281)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(112, 53)
        btnAnterior.TabIndex = 30
        btnAnterior.Text = "<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnPrimero
        ' 
        btnPrimero.Location = New Point(658, 340)
        btnPrimero.Name = "btnPrimero"
        btnPrimero.Size = New Size(112, 53)
        btnPrimero.TabIndex = 29
        btnPrimero.Text = "<<"
        btnPrimero.UseVisualStyleBackColor = True
        ' 
        ' Form13
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(932, 450)
        Controls.Add(btnSalir)
        Controls.Add(btnRegresar)
        Controls.Add(btnUltimo)
        Controls.Add(btnSiguiente)
        Controls.Add(btnAnterior)
        Controls.Add(btnPrimero)
        Controls.Add(Label2)
        Controls.Add(dgvDetalles)
        Name = "Form13"
        Text = "Form13"
        CType(dgvDetalles, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvDetalles As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
End Class
