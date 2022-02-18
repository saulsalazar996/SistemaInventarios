<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearAlmacen
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GpoRacks = New System.Windows.Forms.GroupBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.CmbColumnas = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.CmbFilas = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.BtnAgregarRack = New System.Windows.Forms.Button()
        Me.CmbRack = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GpoCajones = New System.Windows.Forms.GroupBox()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.CmbCajonesExistentes = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.CmbColumnasExistentes = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.CmbFilasExistentes = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.BtnAgregarCajones = New System.Windows.Forms.Button()
        Me.CmbRackExistente = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.GpoRacks.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GpoCajones.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(905, 10)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(11, 371)
        Me.Panel3.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(11, 371)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(884, 10)
        Me.Panel5.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(895, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 371)
        Me.Panel4.TabIndex = 6
        '
        'GpoRacks
        '
        Me.GpoRacks.Controls.Add(Me.Panel14)
        Me.GpoRacks.Controls.Add(Me.Panel15)
        Me.GpoRacks.Controls.Add(Me.Panel16)
        Me.GpoRacks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GpoRacks.Location = New System.Drawing.Point(0, 0)
        Me.GpoRacks.Name = "GpoRacks"
        Me.GpoRacks.Size = New System.Drawing.Size(884, 133)
        Me.GpoRacks.TabIndex = 8
        Me.GpoRacks.TabStop = False
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.CmbColumnas)
        Me.Panel14.Controls.Add(Me.Label6)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(3, 87)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(878, 32)
        Me.Panel14.TabIndex = 2
        '
        'CmbColumnas
        '
        Me.CmbColumnas.Dock = System.Windows.Forms.DockStyle.Left
        Me.CmbColumnas.FormattingEnabled = True
        Me.CmbColumnas.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CmbColumnas.Location = New System.Drawing.Point(109, 0)
        Me.CmbColumnas.Name = "CmbColumnas"
        Me.CmbColumnas.Size = New System.Drawing.Size(218, 28)
        Me.CmbColumnas.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 32)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Columnas"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.CmbFilas)
        Me.Panel15.Controls.Add(Me.Label7)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(3, 55)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(878, 32)
        Me.Panel15.TabIndex = 1
        '
        'CmbFilas
        '
        Me.CmbFilas.Dock = System.Windows.Forms.DockStyle.Left
        Me.CmbFilas.FormattingEnabled = True
        Me.CmbFilas.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CmbFilas.Location = New System.Drawing.Point(109, 0)
        Me.CmbFilas.Name = "CmbFilas"
        Me.CmbFilas.Size = New System.Drawing.Size(218, 28)
        Me.CmbFilas.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 32)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Filas"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.BtnAgregarRack)
        Me.Panel16.Controls.Add(Me.CmbRack)
        Me.Panel16.Controls.Add(Me.Label8)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(3, 23)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(878, 32)
        Me.Panel16.TabIndex = 0
        '
        'BtnAgregarRack
        '
        Me.BtnAgregarRack.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAgregarRack.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnAgregarRack.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnAgregarRack.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnAgregarRack.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarRack.Location = New System.Drawing.Point(771, 0)
        Me.BtnAgregarRack.Name = "BtnAgregarRack"
        Me.BtnAgregarRack.Size = New System.Drawing.Size(107, 32)
        Me.BtnAgregarRack.TabIndex = 5
        Me.BtnAgregarRack.Text = "Agregar"
        Me.BtnAgregarRack.UseVisualStyleBackColor = False
        '
        'CmbRack
        '
        Me.CmbRack.Dock = System.Windows.Forms.DockStyle.Left
        Me.CmbRack.FormattingEnabled = True
        Me.CmbRack.Location = New System.Drawing.Point(109, 0)
        Me.CmbRack.Name = "CmbRack"
        Me.CmbRack.Size = New System.Drawing.Size(218, 28)
        Me.CmbRack.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 32)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Rack"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.GpoCajones)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(11, 143)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(884, 157)
        Me.Panel12.TabIndex = 9
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GpoRacks)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(11, 10)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(884, 133)
        Me.Panel6.TabIndex = 3
        '
        'GpoCajones
        '
        Me.GpoCajones.Controls.Add(Me.Panel18)
        Me.GpoCajones.Controls.Add(Me.Panel7)
        Me.GpoCajones.Controls.Add(Me.Panel13)
        Me.GpoCajones.Controls.Add(Me.Panel17)
        Me.GpoCajones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GpoCajones.Location = New System.Drawing.Point(0, 0)
        Me.GpoCajones.Name = "GpoCajones"
        Me.GpoCajones.Size = New System.Drawing.Size(884, 157)
        Me.GpoCajones.TabIndex = 12
        Me.GpoCajones.TabStop = False
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.CmbCajonesExistentes)
        Me.Panel18.Controls.Add(Me.Label11)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel18.Location = New System.Drawing.Point(3, 119)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(878, 32)
        Me.Panel18.TabIndex = 3
        '
        'CmbCajonesExistentes
        '
        Me.CmbCajonesExistentes.Dock = System.Windows.Forms.DockStyle.Left
        Me.CmbCajonesExistentes.FormattingEnabled = True
        Me.CmbCajonesExistentes.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.CmbCajonesExistentes.Location = New System.Drawing.Point(109, 0)
        Me.CmbCajonesExistentes.Name = "CmbCajonesExistentes"
        Me.CmbCajonesExistentes.Size = New System.Drawing.Size(218, 28)
        Me.CmbCajonesExistentes.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 32)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Cajones"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.CmbColumnasExistentes)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(3, 87)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(878, 32)
        Me.Panel7.TabIndex = 2
        '
        'CmbColumnasExistentes
        '
        Me.CmbColumnasExistentes.Dock = System.Windows.Forms.DockStyle.Left
        Me.CmbColumnasExistentes.FormattingEnabled = True
        Me.CmbColumnasExistentes.Location = New System.Drawing.Point(109, 0)
        Me.CmbColumnasExistentes.Name = "CmbColumnasExistentes"
        Me.CmbColumnasExistentes.Size = New System.Drawing.Size(218, 28)
        Me.CmbColumnasExistentes.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 32)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Columnas"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.CmbFilasExistentes)
        Me.Panel13.Controls.Add(Me.Label9)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(3, 55)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(878, 32)
        Me.Panel13.TabIndex = 1
        '
        'CmbFilasExistentes
        '
        Me.CmbFilasExistentes.Dock = System.Windows.Forms.DockStyle.Left
        Me.CmbFilasExistentes.FormattingEnabled = True
        Me.CmbFilasExistentes.Location = New System.Drawing.Point(109, 0)
        Me.CmbFilasExistentes.Name = "CmbFilasExistentes"
        Me.CmbFilasExistentes.Size = New System.Drawing.Size(218, 28)
        Me.CmbFilasExistentes.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 32)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Filas"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.BtnAgregarCajones)
        Me.Panel17.Controls.Add(Me.CmbRackExistente)
        Me.Panel17.Controls.Add(Me.Label10)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel17.Location = New System.Drawing.Point(3, 23)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(878, 32)
        Me.Panel17.TabIndex = 0
        '
        'BtnAgregarCajones
        '
        Me.BtnAgregarCajones.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAgregarCajones.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnAgregarCajones.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnAgregarCajones.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnAgregarCajones.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarCajones.Location = New System.Drawing.Point(771, 0)
        Me.BtnAgregarCajones.Name = "BtnAgregarCajones"
        Me.BtnAgregarCajones.Size = New System.Drawing.Size(107, 32)
        Me.BtnAgregarCajones.TabIndex = 5
        Me.BtnAgregarCajones.Text = "Agregar"
        Me.BtnAgregarCajones.UseVisualStyleBackColor = False
        '
        'CmbRackExistente
        '
        Me.CmbRackExistente.Dock = System.Windows.Forms.DockStyle.Left
        Me.CmbRackExistente.FormattingEnabled = True
        Me.CmbRackExistente.Location = New System.Drawing.Point(109, 0)
        Me.CmbRackExistente.Name = "CmbRackExistente"
        Me.CmbRackExistente.Size = New System.Drawing.Size(218, 28)
        Me.CmbRackExistente.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 32)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Rack"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(11, 300)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(884, 32)
        Me.Panel1.TabIndex = 10
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnCancelar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCancelar.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(777, 0)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(107, 32)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'CrearAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 381)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "CrearAlmacen"
        Me.Text = "CrearAlmacen"
        Me.GpoRacks.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.GpoCajones.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GpoRacks As GroupBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents CmbColumnas As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents CmbFilas As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents BtnAgregarRack As Button
    Friend WithEvents CmbRack As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents GpoCajones As GroupBox
    Friend WithEvents Panel18 As Panel
    Friend WithEvents CmbCajonesExistentes As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents CmbColumnasExistentes As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents CmbFilasExistentes As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents BtnAgregarCajones As Button
    Friend WithEvents CmbRackExistente As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnCancelar As Button
End Class
