Public Class Form12

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtPassword.UseSystemPasswordChar = True
        txtUsuario.Focus()

    End Sub

    Private Function ValidarCampos() As Boolean

        If txtUsuario.Text.Trim() = "" Then
            MessageBox.Show("Ingrese su usuario.", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsuario.Focus()
            Return False
        End If

        If txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Ingrese su contraseña.", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return False
        End If

        Return True

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ValidarCampos() = False Then Exit Sub

        Dim dao As New IngresoDAO()

        Dim ingreso As Ingreso = dao.ValidarIngreso(
            txtUsuario.Text.Trim(),
            txtPassword.Text.Trim()
        )

        If ingreso IsNot Nothing Then

            SesionGlobal.UsuarioActual = ingreso.Username
            SesionGlobal.RolActual = ingreso.Rol

            MessageBox.Show("¡Bienvenido al sistema, " & SesionGlobal.UsuarioActual & "!", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Form1.Show()
            Me.Hide()

        Else

            MessageBox.Show("Usuario o contraseña incorrectos, o el usuario está inactivo.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtPassword.Clear()
            txtPassword.Focus()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown

        If e.KeyCode = Keys.Enter Then
            txtPassword.Focus()
        End If

    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown

        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If

    End Sub

End Class