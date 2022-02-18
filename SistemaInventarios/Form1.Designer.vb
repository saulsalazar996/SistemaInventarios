<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnEntradas = New System.Windows.Forms.Button()
        Me.BtnPartes = New System.Windows.Forms.Button()
        Me.BtnAlmacenes = New System.Windows.Forms.Button()
        Me.BtnRegistro = New System.Windows.Forms.Button()
        Me.LblAlmacen = New System.Windows.Forms.Label()
        Me.LblSucursal = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.BtnSalidas = New System.Windows.Forms.Button()
        Me.BtnReportes = New System.Windows.Forms.Button()
        Me.BtnMovimientos = New System.Windows.Forms.Button()
        Me.BtnPassword = New System.Windows.Forms.Button()
        Me.BtnAdministrador = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
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
        Me.Panel1.Controls.Add(Me.BtnMovimientos)
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
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(188, 517)
        Me.Panel1.TabIndex = 5
        '
        'BtnEntradas
        '
        Me.BtnEntradas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEntradas.Location = New System.Drawing.Point(0, 189)
        Me.BtnEntradas.Name = "BtnEntradas"
        Me.BtnEntradas.Size = New System.Drawing.Size(188, 23)
        Me.BtnEntradas.TabIndex = 6
        Me.BtnEntradas.Text = "Entradas"
        Me.BtnEntradas.UseVisualStyleBackColor = True
        '
        'BtnPartes
        '
        Me.BtnPartes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPartes.Location = New System.Drawing.Point(0, 166)
        Me.BtnPartes.Name = "BtnPartes"
        Me.BtnPartes.Size = New System.Drawing.Size(188, 23)
        Me.BtnPartes.TabIndex = 5
        Me.BtnPartes.Text = "Partes"
        Me.BtnPartes.UseVisualStyleBackColor = True
        '
        'BtnAlmacenes
        '
        Me.BtnAlmacenes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAlmacenes.Location = New System.Drawing.Point(0, 143)
        Me.BtnAlmacenes.Name = "BtnAlmacenes"
        Me.BtnAlmacenes.Size = New System.Drawing.Size(188, 23)
        Me.BtnAlmacenes.TabIndex = 4
        Me.BtnAlmacenes.Text = "Almacenes"
        Me.BtnAlmacenes.UseVisualStyleBackColor = True
        '
        'BtnRegistro
        '
        Me.BtnRegistro.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRegistro.Location = New System.Drawing.Point(0, 120)
        Me.BtnRegistro.Name = "BtnRegistro"
        Me.BtnRegistro.Size = New System.Drawing.Size(188, 23)
        Me.BtnRegistro.TabIndex = 3
        Me.BtnRegistro.Text = "Registro"
        Me.BtnRegistro.UseVisualStyleBackColor = True
        '
        'LblAlmacen
        '
        Me.LblAlmacen.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblAlmacen.Location = New System.Drawing.Point(0, 80)
        Me.LblAlmacen.Name = "LblAlmacen"
        Me.LblAlmacen.Size = New System.Drawing.Size(188, 40)
        Me.LblAlmacen.TabIndex = 2
        Me.LblAlmacen.Text = "Almacen"
        '
        'LblSucursal
        '
        Me.LblSucursal.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblSucursal.Location = New System.Drawing.Point(0, 40)
        Me.LblSucursal.Name = "LblSucursal"
        Me.LblSucursal.Size = New System.Drawing.Size(188, 40)
        Me.LblSucursal.TabIndex = 1
        Me.LblSucursal.Text = "Sucursal"
        '
        'LblUsuario
        '
        Me.LblUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblUsuario.Location = New System.Drawing.Point(0, 0)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(188, 40)
        Me.LblUsuario.TabIndex = 0
        Me.LblUsuario.Text = "Nombre de Usuario"
        '
        'BtnSalidas
        '
        Me.BtnSalidas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSalidas.Location = New System.Drawing.Point(0, 212)
        Me.BtnSalidas.Name = "BtnSalidas"
        Me.BtnSalidas.Size = New System.Drawing.Size(188, 23)
        Me.BtnSalidas.TabIndex = 7
        Me.BtnSalidas.Text = "Salidas"
        Me.BtnSalidas.UseVisualStyleBackColor = True
        '
        'BtnReportes
        '
        Me.BtnReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReportes.Location = New System.Drawing.Point(0, 235)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Size = New System.Drawing.Size(188, 23)
        Me.BtnReportes.TabIndex = 8
        Me.BtnReportes.Text = "Visor Reportes"
        Me.BtnReportes.UseVisualStyleBackColor = True
        '
        'BtnMovimientos
        '
        Me.BtnMovimientos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMovimientos.Location = New System.Drawing.Point(0, 258)
        Me.BtnMovimientos.Name = "BtnMovimientos"
        Me.BtnMovimientos.Size = New System.Drawing.Size(188, 23)
        Me.BtnMovimientos.TabIndex = 9
        Me.BtnMovimientos.Text = "Movimientos"
        Me.BtnMovimientos.UseVisualStyleBackColor = True
        '
        'BtnPassword
        '
        Me.BtnPassword.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPassword.Location = New System.Drawing.Point(0, 281)
        Me.BtnPassword.Name = "BtnPassword"
        Me.BtnPassword.Size = New System.Drawing.Size(188, 23)
        Me.BtnPassword.TabIndex = 10
        Me.BtnPassword.Text = "Cambio Contraseña"
        Me.BtnPassword.UseVisualStyleBackColor = True
        '
        'BtnAdministrador
        '
        Me.BtnAdministrador.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAdministrador.Location = New System.Drawing.Point(0, 304)
        Me.BtnAdministrador.Name = "BtnAdministrador"
        Me.BtnAdministrador.Size = New System.Drawing.Size(188, 23)
        Me.BtnAdministrador.TabIndex = 11
        Me.BtnAdministrador.Text = "AdmUsuarios"
        Me.BtnAdministrador.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnCerrar.Location = New System.Drawing.Point(0, 494)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(188, 23)
        Me.BtnCerrar.TabIndex = 12
        Me.BtnCerrar.Text = "Cerrar Sesion"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 517)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
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
    Friend WithEvents BtnMovimientos As Button
    Friend WithEvents BtnReportes As Button
    Friend WithEvents BtnSalidas As Button
    Friend WithEvents BtnCerrar As Button
End Class
