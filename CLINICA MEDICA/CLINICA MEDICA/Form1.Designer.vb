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
        Button1 = New Button()
        Label1 = New Label()
        btn2 = New Button()
        txb1 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(278, 146)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(82, 22)
        Button1.TabIndex = 0
        Button1.Text = "Salir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(274, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 1
        Label1.Text = "EJEMPLO"
        ' 
        ' btn2
        ' 
        btn2.Location = New Point(518, 63)
        btn2.Name = "btn2"
        btn2.Size = New Size(75, 23)
        btn2.TabIndex = 2
        btn2.Text = "clean"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' txb1
        ' 
        txb1.Location = New Point(504, 110)
        txb1.Name = "txb1"
        txb1.Size = New Size(100, 23)
        txb1.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
        Controls.Add(txb1)
        Controls.Add(btn2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Ejemplo"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn2 As Button
    Friend WithEvents txb1 As TextBox

End Class
