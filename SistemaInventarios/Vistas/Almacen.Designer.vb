﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Almacen
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.CmbIdAlmacen = New System.Windows.Forms.ComboBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.PnlAgregarAlmacen = New System.Windows.Forms.Panel()
        Me.GpoAlmacen = New System.Windows.Forms.GroupBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.CmbRacks = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.CmbSucursal = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.BtnGuardarAlmacen = New System.Windows.Forms.Button()
        Me.TxtIdAlmacen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6.SuspendLayout()
        Me.PnlAgregarAlmacen.SuspendLayout()
        Me.GpoAlmacen.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 8)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 336)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(657, 8)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(9, 336)
        Me.Panel4.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(10, 336)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(647, 8)
        Me.Panel5.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.CmbIdAlmacen)
        Me.Panel6.Controls.Add(Me.BtnModificar)
        Me.Panel6.Controls.Add(Me.BtnNuevo)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(10, 8)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(647, 29)
        Me.Panel6.TabIndex = 6
        '
        'CmbIdAlmacen
        '
        Me.CmbIdAlmacen.Dock = System.Windows.Forms.DockStyle.Right
        Me.CmbIdAlmacen.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CmbIdAlmacen.FormattingEnabled = True
        Me.CmbIdAlmacen.Location = New System.Drawing.Point(264, 0)
        Me.CmbIdAlmacen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbIdAlmacen.Name = "CmbIdAlmacen"
        Me.CmbIdAlmacen.Size = New System.Drawing.Size(191, 33)
        Me.CmbIdAlmacen.TabIndex = 3
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnModificar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnModificar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnModificar.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnModificar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnModificar.Location = New System.Drawing.Point(455, 0)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(94, 29)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "Modificiar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnNuevo.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnNuevo.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnNuevo.ForeColor = System.Drawing.Color.White
        Me.BtnNuevo.Location = New System.Drawing.Point(549, 0)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(98, 29)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'PnlAgregarAlmacen
        '
        Me.PnlAgregarAlmacen.Controls.Add(Me.GpoAlmacen)
        Me.PnlAgregarAlmacen.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlAgregarAlmacen.Location = New System.Drawing.Point(10, 37)
        Me.PnlAgregarAlmacen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PnlAgregarAlmacen.Name = "PnlAgregarAlmacen"
        Me.PnlAgregarAlmacen.Size = New System.Drawing.Size(647, 124)
        Me.PnlAgregarAlmacen.TabIndex = 7
        '
        'GpoAlmacen
        '
        Me.GpoAlmacen.Controls.Add(Me.Panel11)
        Me.GpoAlmacen.Controls.Add(Me.Panel10)
        Me.GpoAlmacen.Controls.Add(Me.Panel9)
        Me.GpoAlmacen.Controls.Add(Me.Panel8)
        Me.GpoAlmacen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GpoAlmacen.Location = New System.Drawing.Point(0, 0)
        Me.GpoAlmacen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GpoAlmacen.Name = "GpoAlmacen"
        Me.GpoAlmacen.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GpoAlmacen.Size = New System.Drawing.Size(647, 124)
        Me.GpoAlmacen.TabIndex = 0
        Me.GpoAlmacen.TabStop = False
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.CmbRacks)
        Me.Panel11.Controls.Add(Me.Label4)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(3, 98)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(641, 24)
        Me.Panel11.TabIndex = 3
        '
        'CmbRacks
        '
        Me.CmbRacks.Dock = System.Windows.Forms.DockStyle.Left
        Me.CmbRacks.FormattingEnabled = True
        Me.CmbRacks.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CmbRacks.Location = New System.Drawing.Point(95, 0)
        Me.CmbRacks.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbRacks.Name = "CmbRacks"
        Me.CmbRacks.Size = New System.Drawing.Size(191, 23)
        Me.CmbRacks.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Racks"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.CmbSucursal)
        Me.Panel10.Controls.Add(Me.Label3)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(3, 74)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(641, 24)
        Me.Panel10.TabIndex = 2
        '
        'CmbSucursal
        '
        Me.CmbSucursal.Dock = System.Windows.Forms.DockStyle.Left
        Me.CmbSucursal.FormattingEnabled = True
        Me.CmbSucursal.Location = New System.Drawing.Point(95, 0)
        Me.CmbSucursal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbSucursal.Name = "CmbSucursal"
        Me.CmbSucursal.Size = New System.Drawing.Size(191, 23)
        Me.CmbSucursal.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sucursal"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.BtnSiguiente)
        Me.Panel9.Controls.Add(Me.TxtDescripcion)
        Me.Panel9.Controls.Add(Me.Label2)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(3, 46)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(641, 28)
        Me.Panel9.TabIndex = 1
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSiguiente.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnSiguiente.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnSiguiente.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSiguiente.ForeColor = System.Drawing.Color.White
        Me.BtnSiguiente.Location = New System.Drawing.Point(547, 0)
        Me.BtnSiguiente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(94, 28)
        Me.BtnSiguiente.TabIndex = 6
        Me.BtnSiguiente.Text = "Siguiente"
        Me.BtnSiguiente.UseVisualStyleBackColor = False
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Dock = System.Windows.Forms.DockStyle.Left
        Me.TxtDescripcion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDescripcion.Location = New System.Drawing.Point(95, 0)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(191, 29)
        Me.TxtDescripcion.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Descripcion"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.BtnGuardarAlmacen)
        Me.Panel8.Controls.Add(Me.TxtIdAlmacen)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(3, 18)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(641, 28)
        Me.Panel8.TabIndex = 0
        '
        'BtnGuardarAlmacen
        '
        Me.BtnGuardarAlmacen.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGuardarAlmacen.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnGuardarAlmacen.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnGuardarAlmacen.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnGuardarAlmacen.ForeColor = System.Drawing.Color.White
        Me.BtnGuardarAlmacen.Location = New System.Drawing.Point(547, 0)
        Me.BtnGuardarAlmacen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnGuardarAlmacen.Name = "BtnGuardarAlmacen"
        Me.BtnGuardarAlmacen.Size = New System.Drawing.Size(94, 28)
        Me.BtnGuardarAlmacen.TabIndex = 2
        Me.BtnGuardarAlmacen.Text = "Guardar"
        Me.BtnGuardarAlmacen.UseVisualStyleBackColor = False
        '
        'TxtIdAlmacen
        '
        Me.TxtIdAlmacen.Dock = System.Windows.Forms.DockStyle.Left
        Me.TxtIdAlmacen.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtIdAlmacen.Location = New System.Drawing.Point(95, 0)
        Me.TxtIdAlmacen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtIdAlmacen.Name = "TxtIdAlmacen"
        Me.TxtIdAlmacen.Size = New System.Drawing.Size(191, 29)
        Me.TxtIdAlmacen.TabIndex = 1
        Me.TxtIdAlmacen.Visible = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IdAlmacen"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Panel14)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(10, 161)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(647, 170)
        Me.Panel12.TabIndex = 10
        '
        'Panel14
        '
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(647, 8)
        Me.Panel14.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(666, 8)
        Me.Panel1.TabIndex = 2
        '
        'Almacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 344)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.PnlAgregarAlmacen)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Almacen"
        Me.Text = "Almacen"
        Me.Panel6.ResumeLayout(False)
        Me.PnlAgregarAlmacen.ResumeLayout(False)
        Me.GpoAlmacen.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents PnlAgregarAlmacen As Panel
    Friend WithEvents GpoAlmacen As GroupBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents CmbRacks As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents CmbSucursal As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdAlmacen As TextBox
    Friend WithEvents BtnGuardarAlmacen As Button
    Friend WithEvents BtnSiguiente As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CmbIdAlmacen As ComboBox
End Class
