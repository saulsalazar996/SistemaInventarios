<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnAdministrador = New System.Windows.Forms.Button()
        Me.BtnPassword = New System.Windows.Forms.Button()
        Me.BtnMovimientos = New System.Windows.Forms.Button()
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 689)
        Me.Panel1.TabIndex = 5
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnCerrar.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCerrar.Location = New System.Drawing.Point(0, 658)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(215, 31)
        Me.BtnCerrar.TabIndex = 12
        Me.BtnCerrar.Text = "Cerrar Sesion"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnAdministrador
        '
        Me.BtnAdministrador.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAdministrador.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnAdministrador.Location = New System.Drawing.Point(0, 407)
        Me.BtnAdministrador.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAdministrador.Name = "BtnAdministrador"
        Me.BtnAdministrador.Size = New System.Drawing.Size(215, 31)
        Me.BtnAdministrador.TabIndex = 11
        Me.BtnAdministrador.Text = "AdmUsuarios"
        Me.BtnAdministrador.UseVisualStyleBackColor = True
        '
        'BtnPassword
        '
        Me.BtnPassword.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPassword.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnPassword.Location = New System.Drawing.Point(0, 376)
        Me.BtnPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnPassword.Name = "BtnPassword"
        Me.BtnPassword.Size = New System.Drawing.Size(215, 31)
        Me.BtnPassword.TabIndex = 10
        Me.BtnPassword.Text = "Cambio Contraseña"
        Me.BtnPassword.UseVisualStyleBackColor = True
        '
        'BtnMovimientos
        '
        Me.BtnMovimientos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMovimientos.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnMovimientos.Location = New System.Drawing.Point(0, 345)
        Me.BtnMovimientos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnMovimientos.Name = "BtnMovimientos"
        Me.BtnMovimientos.Size = New System.Drawing.Size(215, 31)
        Me.BtnMovimientos.TabIndex = 9
        Me.BtnMovimientos.Text = "Movimientos"
        Me.BtnMovimientos.UseVisualStyleBackColor = True
        '
        'BtnReportes
        '
        Me.BtnReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReportes.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnReportes.Location = New System.Drawing.Point(0, 314)
        Me.BtnReportes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Size = New System.Drawing.Size(215, 31)
        Me.BtnReportes.TabIndex = 8
        Me.BtnReportes.Text = "Visor Reportes"
        Me.BtnReportes.UseVisualStyleBackColor = True
        '
        'BtnSalidas
        '
        Me.BtnSalidas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSalidas.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSalidas.Location = New System.Drawing.Point(0, 283)
        Me.BtnSalidas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSalidas.Name = "BtnSalidas"
        Me.BtnSalidas.Size = New System.Drawing.Size(215, 31)
        Me.BtnSalidas.TabIndex = 7
        Me.BtnSalidas.Text = "Salidas"
        Me.BtnSalidas.UseVisualStyleBackColor = True
        '
        'BtnEntradas
        '
        Me.BtnEntradas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEntradas.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnEntradas.Location = New System.Drawing.Point(0, 252)
        Me.BtnEntradas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnEntradas.Name = "BtnEntradas"
        Me.BtnEntradas.Size = New System.Drawing.Size(215, 31)
        Me.BtnEntradas.TabIndex = 6
        Me.BtnEntradas.Text = "Entradas"
        Me.BtnEntradas.UseVisualStyleBackColor = True
        '
        'BtnPartes
        '
        Me.BtnPartes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPartes.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnPartes.Location = New System.Drawing.Point(0, 221)
        Me.BtnPartes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnPartes.Name = "BtnPartes"
        Me.BtnPartes.Size = New System.Drawing.Size(215, 31)
        Me.BtnPartes.TabIndex = 5
        Me.BtnPartes.Text = "Partes"
        Me.BtnPartes.UseVisualStyleBackColor = True
        '
        'BtnAlmacenes
        '
        Me.BtnAlmacenes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAlmacenes.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnAlmacenes.Location = New System.Drawing.Point(0, 190)
        Me.BtnAlmacenes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAlmacenes.Name = "BtnAlmacenes"
        Me.BtnAlmacenes.Size = New System.Drawing.Size(215, 31)
        Me.BtnAlmacenes.TabIndex = 4
        Me.BtnAlmacenes.Text = "Almacenes"
        Me.BtnAlmacenes.UseVisualStyleBackColor = True
        '
        'BtnRegistro
        '
        Me.BtnRegistro.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRegistro.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnRegistro.Location = New System.Drawing.Point(0, 159)
        Me.BtnRegistro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnRegistro.Name = "BtnRegistro"
        Me.BtnRegistro.Size = New System.Drawing.Size(215, 31)
        Me.BtnRegistro.TabIndex = 3
        Me.BtnRegistro.Text = "Registro"
        Me.BtnRegistro.UseVisualStyleBackColor = True
        '
        'LblAlmacen
        '
        Me.LblAlmacen.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblAlmacen.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblAlmacen.Location = New System.Drawing.Point(0, 106)
        Me.LblAlmacen.Name = "LblAlmacen"
        Me.LblAlmacen.Size = New System.Drawing.Size(215, 53)
        Me.LblAlmacen.TabIndex = 2
        Me.LblAlmacen.Text = "Almacen"
        '
        'LblSucursal
        '
        Me.LblSucursal.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblSucursal.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblSucursal.Location = New System.Drawing.Point(0, 53)
        Me.LblSucursal.Name = "LblSucursal"
        Me.LblSucursal.Size = New System.Drawing.Size(215, 53)
        Me.LblSucursal.TabIndex = 1
        Me.LblSucursal.Text = "Sucursal"
        '
        'LblUsuario
        '
        Me.LblUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblUsuario.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblUsuario.Location = New System.Drawing.Point(0, 0)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(215, 53)
        Me.LblUsuario.TabIndex = 0
        Me.LblUsuario.Text = "Nombre de Usuario"
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
    Friend WithEvents BtnMovimientos As Button
    Friend WithEvents BtnReportes As Button
    Friend WithEvents BtnSalidas As Button
    Friend WithEvents BtnCerrar As Button
End Class
