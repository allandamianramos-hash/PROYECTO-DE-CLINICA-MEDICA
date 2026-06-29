Imports Npgsql

Public Class Form12

    Dim conexionString As String = "Server=ep-holy-sea-atf4gaz7-pooler.c-9.us-east-1.aws.neon.tech; Port=5432; Database=neondb; User Id=neondb_owner; Password=npg_8KIjvXm6uzAi; SSL Mode=Require; Trust Server Certificate=True;"
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUsuario.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingrese su usuario y contraseña.", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "SELECT rol FROM usuarios WHERE username = @user AND password_hash = @pass AND estado = 'Activo'"

        Using conn As New NpgsqlConnection(conexionString)
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("user", txtUsuario.Text.Trim())
                    cmd.Parameters.AddWithValue("pass", txtPassword.Text.Trim())

                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then

                            SesionGlobal.UsuarioActual = txtUsuario.Text.Trim()
                            SesionGlobal.RolActual = reader("rol").ToString()

                            ' Le damos la bienvenida y abrimos el Menú Principal (Form1)
                            MessageBox.Show("¡Bienvenido al sistema, " & SesionGlobal.UsuarioActual & "!", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Form1.Show()
                            Me.Hide()
                        Else
                            ' Si el reader no leyó nada, el usuario, la contraseña, o el estado están mal
                            MessageBox.Show("Usuario o contraseña incorrectos, o el usuario está inactivo.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtPassword.Clear()
                            txtPassword.Focus()
                        End If
                    End Using ' Aquí muere el reader
                End Using
            Catch ex As Exception
                MessageBox.Show("Error de conexión al verificar usuario: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


End Class