<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnAdministrador = New System.Windows.Forms.Button()
        Me.BtnPassword = New System.Windows.Forms.Button()
        Me.BtnReportes = New System.Windows.Forms.Button()
        Me.BtnSalidas = New System.Windows.Forms.Button()
        Me.BtnEntradas = New System.Windows.Forms.Button()
        Me.BtnPartes = New System.Windows.Forms.Button()
        Me.BtnAlmacenes = New System.Windows.Forms.Button()
        Me.BtnRegistro = New System.Windows.Forms.Button()
        Me.LblAlmacen = New System.Windows.Forms.Label()
        Me.LblSucursal = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnCerrar)
        Me.Panel1.Controls.Add(Me.BtnAdministrador)
        Me.Panel1.Controls.Add(Me.BtnPassword)
        Me.Panel1.Controls.Add(Me.BtnReportes)
        Me.Panel1.Controls.Add(Me.BtnSalidas)
        Me.Panel1.Controls.Add(Me.BtnEntradas)
        Me.Panel1.Controls.Add(Me.BtnPartes)
        Me.Panel1.Controls.Add(Me.BtnAlmacenes)
        Me.Panel1.Controls.Add(Me.BtnRegistro)
        Me.Panel1.Controls.Add(Me.LblAlmacen)
        Me.Panel1.Controls.Add(Me.LblSucursal)
        Me.Panel1.Controls.Add(Me.LblUsuario)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 689)
        Me.Panel1.TabIndex = 5
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnCerrar.Location = New System.Drawing.Point(0, 666)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(215, 23)
        Me.BtnCerrar.TabIndex = 12
        Me.BtnCerrar.Text = "Cerrar Sesion"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnAdministrador
        '
        Me.BtnAdministrador.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BtnAdministrador.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAdministrador.Location = New System.Drawing.Point(0, 488)
        Me.BtnAdministrador.Name = "BtnAdministrador"
        Me.BtnAdministrador.Size = New System.Drawing.Size(215, 47)
        Me.BtnAdministrador.TabIndex = 11
        Me.BtnAdministrador.Text = "AdmUsuarios"
        Me.BtnAdministrador.UseVisualStyleBackColor = False
        '
        'BtnPassword
        '
        Me.BtnPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BtnPassword.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPassword.Location = New System.Drawing.Point(0, 441)
        Me.BtnPassword.Name = "BtnPassword"
        Me.BtnPassword.Size = New System.Drawing.Size(215, 47)
        Me.BtnPassword.TabIndex = 10
        Me.BtnPassword.Text = "Cambio Contraseña"
        Me.BtnPassword.UseVisualStyleBackColor = False
        '
        'BtnReportes
        '
        Me.BtnReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BtnReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReportes.Location = New System.Drawing.Point(0, 394)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Size = New System.Drawing.Size(215, 47)
        Me.BtnReportes.TabIndex = 8
        Me.BtnReportes.Text = "Visor Reportes"
        Me.BtnReportes.UseVisualStyleBackColor = False
        '
        'BtnSalidas
        '
        Me.BtnSalidas.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BtnSalidas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSalidas.Location = New System.Drawing.Point(0, 347)
        Me.BtnSalidas.Name = "BtnSalidas"
        Me.BtnSalidas.Size = New System.Drawing.Size(215, 47)
        Me.BtnSalidas.TabIndex = 7
        Me.BtnSalidas.Text = "Salidas"
        Me.BtnSalidas.UseVisualStyleBackColor = False
        '
        'BtnEntradas
        '
        Me.BtnEntradas.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BtnEntradas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEntradas.Location = New System.Drawing.Point(0, 300)
        Me.BtnEntradas.Name = "BtnEntradas"
        Me.BtnEntradas.Size = New System.Drawing.Size(215, 47)
        Me.BtnEntradas.TabIndex = 6
        Me.BtnEntradas.Text = "Entradas"
        Me.BtnEntradas.UseVisualStyleBackColor = False
        '
        'BtnPartes
        '
        Me.BtnPartes.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BtnPartes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPartes.Location = New System.Drawing.Point(0, 253)
        Me.BtnPartes.Name = "BtnPartes"
        Me.BtnPartes.Size = New System.Drawing.Size(215, 47)
        Me.BtnPartes.TabIndex = 5
        Me.BtnPartes.Text = "Partes"
        Me.BtnPartes.UseVisualStyleBackColor = False
        '
        'BtnAlmacenes
        '
        Me.BtnAlmacenes.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BtnAlmacenes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAlmacenes.Location = New System.Drawing.Point(0, 206)
        Me.BtnAlmacenes.Name = "BtnAlmacenes"
        Me.BtnAlmacenes.Size = New System.Drawing.Size(215, 47)
        Me.BtnAlmacenes.TabIndex = 4
        Me.BtnAlmacenes.Text = "Almacenes"
        Me.BtnAlmacenes.UseVisualStyleBackColor = False
        '
        'BtnRegistro
        '
        Me.BtnRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BtnRegistro.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRegistro.Location = New System.Drawing.Point(0, 159)
        Me.BtnRegistro.Name = "BtnRegistro"
        Me.BtnRegistro.Size = New System.Drawing.Size(215, 47)
        Me.BtnRegistro.TabIndex = 3
        Me.BtnRegistro.Text = "Registro"
        Me.BtnRegistro.UseVisualStyleBackColor = False
        '
        'LblAlmacen
        '
        Me.LblAlmacen.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblAlmacen.Location = New System.Drawing.Point(0, 106)
        Me.LblAlmacen.Name = "LblAlmacen"
        Me.LblAlmacen.Size = New System.Drawing.Size(215, 53)
        Me.LblAlmacen.TabIndex = 2
        Me.LblAlmacen.Text = "Almacen"
        Me.LblAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSucursal
        '
        Me.LblSucursal.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblSucursal.Location = New System.Drawing.Point(0, 53)
        Me.LblSucursal.Name = "LblSucursal"
        Me.LblSucursal.Size = New System.Drawing.Size(215, 53)
        Me.LblSucursal.TabIndex = 1
        Me.LblSucursal.Text = "Sucursal"
        Me.LblSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblUsuario
        '
        Me.LblUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblUsuario.Location = New System.Drawing.Point(0, 0)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(215, 53)
        Me.LblUsuario.TabIndex = 0
        Me.LblUsuario.Text = "Nombre de Usuario"
        Me.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 689)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MenuPrincipal"
        Me.Text = "Menu Principal"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnEntradas As Button
    Friend WithEvents BtnPartes As Button
    Friend WithEvents BtnAlmacenes As Button
    Friend WithEvents BtnRegistro As Button
    Friend WithEvents LblAlmacen As Label
    Friend WithEvents LblSucursal As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents BtnAdministrador As Button
    Friend WithEvents BtnPassword As Button
    Friend WithEvents BtnReportes As Button
    Friend WithEvents BtnSalidas As Button
    Friend WithEvents BtnCerrar As Button
End Class
