<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_Correo = New System.Windows.Forms.Label()
        Me.lbl_Pais = New System.Windows.Forms.Label()
        Me.lbl_Ocu = New System.Windows.Forms.Label()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.btn_car = New System.Windows.Forms.Button()
        Me.btn_bor = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_bus = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_co = New System.Windows.Forms.TextBox()
        Me.txt_pa = New System.Windows.Forms.TextBox()
        Me.txt_ocu = New System.Windows.Forms.TextBox()
        Me.DTGV = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mensaje.Location = New System.Drawing.Point(219, 30)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(0, 33)
        Me.lbl_mensaje.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(773, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ID.Location = New System.Drawing.Point(23, 94)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(34, 25)
        Me.lbl_ID.TabIndex = 2
        Me.lbl_ID.Text = "ID"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.Location = New System.Drawing.Point(196, 92)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(93, 25)
        Me.lbl_Nombre.TabIndex = 3
        Me.lbl_Nombre.Text = "Nombre"
        '
        'lbl_Correo
        '
        Me.lbl_Correo.AutoSize = True
        Me.lbl_Correo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Correo.Location = New System.Drawing.Point(507, 91)
        Me.lbl_Correo.Name = "lbl_Correo"
        Me.lbl_Correo.Size = New System.Drawing.Size(83, 25)
        Me.lbl_Correo.TabIndex = 4
        Me.lbl_Correo.Text = "Correo"
        '
        'lbl_Pais
        '
        Me.lbl_Pais.AutoSize = True
        Me.lbl_Pais.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pais.Location = New System.Drawing.Point(133, 132)
        Me.lbl_Pais.Name = "lbl_Pais"
        Me.lbl_Pais.Size = New System.Drawing.Size(58, 25)
        Me.lbl_Pais.TabIndex = 5
        Me.lbl_Pais.Text = "Pais"
        '
        'lbl_Ocu
        '
        Me.lbl_Ocu.AutoSize = True
        Me.lbl_Ocu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Ocu.Location = New System.Drawing.Point(406, 132)
        Me.lbl_Ocu.Name = "lbl_Ocu"
        Me.lbl_Ocu.Size = New System.Drawing.Size(124, 25)
        Me.lbl_Ocu.TabIndex = 6
        Me.lbl_Ocu.Text = "Ocupacion"
        '
        'btn_insertar
        '
        Me.btn_insertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertar.Location = New System.Drawing.Point(100, 187)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.Size = New System.Drawing.Size(110, 36)
        Me.btn_insertar.TabIndex = 7
        Me.btn_insertar.Text = "Insertar"
        Me.btn_insertar.UseVisualStyleBackColor = True
        '
        'btn_car
        '
        Me.btn_car.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_car.Location = New System.Drawing.Point(495, 187)
        Me.btn_car.Name = "btn_car"
        Me.btn_car.Size = New System.Drawing.Size(110, 36)
        Me.btn_car.TabIndex = 8
        Me.btn_car.Text = "Cargar"
        Me.btn_car.UseVisualStyleBackColor = True
        '
        'btn_bor
        '
        Me.btn_bor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bor.Location = New System.Drawing.Point(361, 187)
        Me.btn_bor.Name = "btn_bor"
        Me.btn_bor.Size = New System.Drawing.Size(110, 36)
        Me.btn_bor.TabIndex = 9
        Me.btn_bor.Text = "Borrar"
        Me.btn_bor.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(230, 187)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(110, 36)
        Me.btn_edit.TabIndex = 10
        Me.btn_edit.Text = "Editar"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_bus
        '
        Me.btn_bus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bus.Location = New System.Drawing.Point(632, 186)
        Me.btn_bus.Name = "btn_bus"
        Me.btn_bus.Size = New System.Drawing.Size(110, 36)
        Me.btn_bus.TabIndex = 11
        Me.btn_bus.Text = "Buscar"
        Me.btn_bus.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(62, 95)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(129, 20)
        Me.txt_id.TabIndex = 12
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(293, 96)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(208, 20)
        Me.txt_nom.TabIndex = 13
        '
        'txt_co
        '
        Me.txt_co.Location = New System.Drawing.Point(596, 96)
        Me.txt_co.Name = "txt_co"
        Me.txt_co.Size = New System.Drawing.Size(208, 20)
        Me.txt_co.TabIndex = 14
        '
        'txt_pa
        '
        Me.txt_pa.Location = New System.Drawing.Point(192, 137)
        Me.txt_pa.Name = "txt_pa"
        Me.txt_pa.Size = New System.Drawing.Size(208, 20)
        Me.txt_pa.TabIndex = 15
        '
        'txt_ocu
        '
        Me.txt_ocu.Location = New System.Drawing.Point(549, 137)
        Me.txt_ocu.Name = "txt_ocu"
        Me.txt_ocu.Size = New System.Drawing.Size(208, 20)
        Me.txt_ocu.TabIndex = 16
        '
        'DTGV
        '
        Me.DTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGV.Location = New System.Drawing.Point(30, 243)
        Me.DTGV.Name = "DTGV"
        Me.DTGV.Size = New System.Drawing.Size(776, 283)
        Me.DTGV.TabIndex = 17
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 552)
        Me.Controls.Add(Me.DTGV)
        Me.Controls.Add(Me.txt_ocu)
        Me.Controls.Add(Me.txt_pa)
        Me.Controls.Add(Me.txt_co)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.btn_bus)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_bor)
        Me.Controls.Add(Me.btn_car)
        Me.Controls.Add(Me.btn_insertar)
        Me.Controls.Add(Me.lbl_Ocu)
        Me.Controls.Add(Me.lbl_Pais)
        Me.Controls.Add(Me.lbl_Correo)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.lbl_ID)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Editar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_ID As Label
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents lbl_Correo As Label
    Friend WithEvents lbl_Pais As Label
    Friend WithEvents lbl_Ocu As Label
    Friend WithEvents btn_insertar As Button
    Friend WithEvents btn_car As Button
    Friend WithEvents btn_bor As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_bus As Button
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_co As TextBox
    Friend WithEvents txt_pa As TextBox
    Friend WithEvents txt_ocu As TextBox
    Friend WithEvents DTGV As DataGridView
End Class
