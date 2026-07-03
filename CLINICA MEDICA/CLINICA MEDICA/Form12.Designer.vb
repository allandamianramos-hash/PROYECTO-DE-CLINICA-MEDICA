<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        txtUsuario = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(484, 116)
        txtUsuario.Margin = New Padding(3, 2, 3, 2)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(186, 32)
        txtUsuario.TabIndex = 0
        txtUsuario.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(484, 168)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(180, 32)
        txtPassword.TabIndex = 1
        txtPassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(313, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 21)
        Label1.TabIndex = 2
        Label1.Text = "Ingrese su usuario:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(283, 171)
        Label2.Name = "Label2"
        Label2.Size = New Size(195, 21)
        Label2.TabIndex = 3
        Label2.Text = "Ingrese su contraseña:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(378, 240)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(149, 58)
        Button1.TabIndex = 4
        Button1.Text = "Siguiente"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(568, 240)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(169, 58)
        Button2.TabIndex = 5
        Button2.Text = "Salir"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(452, 9)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(178, 21)
        Label7.TabIndex = 57
        Label7.Text = "Ingreso al sistema"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form12
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1082, 463)
        Controls.Add(Label7)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsuario)
        Font = New Font("Lucida Sans Unicode", 9.75F)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form12"
        Text = "Ingreso"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
End Class
