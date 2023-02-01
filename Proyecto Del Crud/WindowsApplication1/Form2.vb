Imports System.Data.SqlClient
Public Class Form2
    Dim con As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand

    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, con)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Hide()
        Form1.Show()
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        'Variable Para Hacer La Consulta
        Dim f As String = ""
    End Sub
End Class