<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductoEdicion
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblCosto = New System.Windows.Forms.Label()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblBarra = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtBarra = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtNombreCategoria = New System.Windows.Forms.TextBox()
        Me.txtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.txtNombreMarca = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(137, 44)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(505, 46)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Registro de Productos - Nuevos"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 143)
        Me.Panel1.TabIndex = 2
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(50, 159)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(68, 24)
        Me.lblCodigo.TabIndex = 2
        Me.lblCodigo.Text = "Codigo"
        Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 222)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(106, 24)
        Me.lblDescripcion.TabIndex = 3
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.Location = New System.Drawing.Point(28, 286)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(90, 24)
        Me.lblCategoria.TabIndex = 4
        Me.lblCategoria.Text = "Categoria"
        Me.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCosto
        '
        Me.lblCosto.AutoSize = True
        Me.lblCosto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCosto.Location = New System.Drawing.Point(60, 482)
        Me.lblCosto.Name = "lblCosto"
        Me.lblCosto.Size = New System.Drawing.Size(58, 24)
        Me.lblCosto.TabIndex = 7
        Me.lblCosto.Text = "Costo"
        Me.lblCosto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.Location = New System.Drawing.Point(22, 412)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(96, 24)
        Me.lblProveedor.TabIndex = 6
        Me.lblProveedor.Text = "Proveedor"
        Me.lblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(56, 346)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(62, 24)
        Me.lblMarca.TabIndex = 5
        Me.lblMarca.Text = "Marca"
        Me.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBarra
        '
        Me.lblBarra.AutoSize = True
        Me.lblBarra.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarra.Location = New System.Drawing.Point(428, 159)
        Me.lblBarra.Name = "lblBarra"
        Me.lblBarra.Size = New System.Drawing.Size(55, 24)
        Me.lblBarra.TabIndex = 10
        Me.lblBarra.Text = "Barra"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.Location = New System.Drawing.Point(64, 610)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(54, 24)
        Me.lblStock.TabIndex = 9
        Me.lblStock.Text = "Stock"
        Me.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(57, 548)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(61, 24)
        Me.lblPrecio.TabIndex = 8
        Me.lblPrecio.Text = "Precio"
        Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(124, 162)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(298, 22)
        Me.txtCodigo.TabIndex = 11
        '
        'txtBarra
        '
        Me.txtBarra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBarra.Location = New System.Drawing.Point(489, 162)
        Me.txtBarra.Name = "txtBarra"
        Me.txtBarra.Size = New System.Drawing.Size(299, 22)
        Me.txtBarra.TabIndex = 12
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.Location = New System.Drawing.Point(124, 222)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(664, 22)
        Me.txtDescripcion.TabIndex = 13
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(124, 286)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(186, 22)
        Me.txtCategoria.TabIndex = 14
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(124, 348)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(186, 22)
        Me.txtMarca.TabIndex = 15
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(124, 414)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(186, 22)
        Me.txtProveedor.TabIndex = 16
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(124, 482)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(186, 22)
        Me.txtCosto.TabIndex = 17
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(124, 550)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(186, 22)
        Me.txtPrecio.TabIndex = 18
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(124, 613)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(186, 22)
        Me.txtStock.TabIndex = 19
        '
        'txtNombreCategoria
        '
        Me.txtNombreCategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreCategoria.Location = New System.Drawing.Point(332, 286)
        Me.txtNombreCategoria.Name = "txtNombreCategoria"
        Me.txtNombreCategoria.Size = New System.Drawing.Size(456, 22)
        Me.txtNombreCategoria.TabIndex = 20
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreProveedor.Location = New System.Drawing.Point(332, 414)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Size = New System.Drawing.Size(456, 22)
        Me.txtNombreProveedor.TabIndex = 21
        '
        'txtNombreMarca
        '
        Me.txtNombreMarca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreMarca.Location = New System.Drawing.Point(332, 348)
        Me.txtNombreMarca.Name = "txtNombreMarca"
        Me.txtNombreMarca.Size = New System.Drawing.Size(456, 22)
        Me.txtNombreMarca.TabIndex = 22
        '
        'FrmProductoEdicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 653)
        Me.Controls.Add(Me.txtNombreMarca)
        Me.Controls.Add(Me.txtNombreProveedor)
        Me.Controls.Add(Me.txtNombreCategoria)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtBarra)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblBarra)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblCosto)
        Me.Controls.Add(Me.lblProveedor)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmProductoEdicion"
        Me.Text = "FrmProductoEdicion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblCosto As Label
    Friend WithEvents lblProveedor As Label
    Friend WithEvents lblMarca As Label
    Friend WithEvents lblBarra As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtBarra As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtNombreCategoria As TextBox
    Friend WithEvents txtNombreProveedor As TextBox
    Friend WithEvents txtNombreMarca As TextBox
End Class
