Imports System.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection(My.Settings.Conexion)
    Public cmd As SqlCommand
    'Verificar a que rol corresponden los usuarios ingresados
    Function Verificacion(ByVal sql)
        con.Open()
        cmd = New SqlCommand(sql, con)
        Dim i As Integer = cmd.ExecuteNonQuery
        con.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt_contraseña.TextChanged

    End Sub

    Private Sub btn_Ingresar_Click(sender As Object, e As EventArgs) Handles btn_Ingresar.Click
        'Variable del Form2
        Dim f2 = Form2
        'Cual Es El Rol Del Usuario
        Dim verificar1 As String = "UPDATE REGISTROS SET usuario=usuario WHERE usuario= '" + txt_usuario.Text + "' AND contraseña = '" + txt_contraseña.Text + "' AND rol='administrador'"
        Dim verificar2 As String = "UPDATE REGISTROS SET usuario=usuario WHERE usuario= '" + txt_usuario.Text + "' AND contraseña = '" + txt_contraseña.Text + "' AND rol='secretaria'"
        Dim verificar3 As String = "UPDATE REGISTROS SET usuario=usuario WHERE usuario= '" + txt_usuario.Text + "' AND contraseña = '" + txt_contraseña.Text + "' AND rol='usuario'"


        If txt_usuario.Text = "" And txt_contraseña.Text = "" Then
            MsgBox("Ingrese los datos que se le solicitan")
        ElseIf txt_usuario.Text = "" Then
            MsgBox("Ingrese su nombre de usuario")
        ElseIf txt_contraseña.Text = "" Then
            MsgBox("Ingrese su contraseña")
        Else
            If Verificacion(verificar1) Then
                Hide()
                Form2.Show()
                '----------------------------------------------------------------------------------------
                'Codigo De Administrador
                f2.lbl_mensaje.Text = "Bienvenido Administrador"
                'Desabilitar Botones
                f2.btn_edit.Visible = True
                f2.btn_insertar.Visible = True
                f2.btn_bor.Visible = True
                'Localizacion De Botones
                f2.btn_car.Location = New Point(495, 187)
                f2.btn_bus.Location = New Point(632, 186)
                f2.btn_insertar.Location = New Point(100, 187)
                '----------------------------------------------------------------------------------------
                'Habilitar labels
                f2.lbl_ID.Visible = True
                f2.lbl_Correo.Visible = True
                f2.lbl_Pais.Visible = True
                f2.lbl_Ocu.Visible = True
                'Localizacion De labels
                f2.lbl_Nombre.Location = New Point(196, 92)
                'Habilitar texbox
                f2.txt_id.Visible = True
                f2.txt_co.Visible = True
                f2.txt_pa.Visible = True
                f2.txt_ocu.Visible = True
                'Localizacion Del texbox
                f2.txt_nom.Location = New Point(293, 96)
            ElseIf Verificacion(verificar2) Then
                Hide()
                Form2.Show()
                '----------------------------------------------------------------------------------------
                'Codigo De Secretaria
                f2.lbl_mensaje.Text = "Bienvenido Secretaria"
                'Desabilitar Botones
                f2.btn_bor.Visible = False
                f2.btn_edit.Visible = False
                'Localizacon De Botones
                f2.btn_insertar.Location = New Point(249, 185)
                f2.btn_car.Location = New Point(392, 185)
                f2.btn_bus.Location = New Point(530, 185)
                '----------------------------------------------------------------------------------------
                'Habilitar Botones
                f2.btn_car.Visible = True
                f2.btn_insertar.Visible = True
                f2.btn_bus.Visible = True
                'Habilitar labels
                f2.lbl_ID.Visible = True
                f2.lbl_Correo.Visible = True
                f2.lbl_Pais.Visible = True
                f2.lbl_Ocu.Visible = True
                'Localizacion De labels
                f2.lbl_Nombre.Location = New Point(196, 92)
                'Habilitar texbox
                f2.txt_id.Visible = True
                f2.txt_co.Visible = True
                f2.txt_pa.Visible = True
                f2.txt_ocu.Visible = True
                'Localizacion Del texbox
                f2.txt_nom.Location = New Point(293, 96)
            ElseIf Verificacion(verificar3) Then
                Hide()
                Form2.Show()
                '------------------------------------------------------------------------------------------
                'Codigo De Usuario
                f2.lbl_mensaje.Text = "Bienvenido Usuario"
                'Desabilitar Botones
                f2.btn_edit.Visible = False
                f2.btn_insertar.Visible = False
                f2.btn_bor.Visible = False
                'Localizacion De Botones
                f2.btn_car.Location = New Point(308, 188)
                f2.btn_bus.Location = New Point(441, 188)
                'Desabilitar labels
                f2.lbl_ID.Visible = False
                f2.lbl_Correo.Visible = False
                f2.lbl_Pais.Visible = False
                f2.lbl_Ocu.Visible = False
                'Localizacion De labels
                f2.lbl_Nombre.Location = New Point(285, 115)
                'Desabilitar texbox
                f2.txt_id.Visible = False
                f2.txt_co.Visible = False
                f2.txt_pa.Visible = False
                f2.txt_ocu.Visible = False
                'Localizacion Del texbox
                f2.txt_nom.Location = New Point(382, 119)

            Else
                MsgBox("El usuario ingresado no existe")

            End If


        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub
End Class
