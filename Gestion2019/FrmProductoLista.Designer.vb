<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductoLista
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optProveedor = New System.Windows.Forms.RadioButton()
        Me.optCategoria = New System.Windows.Forms.RadioButton()
        Me.optMarca = New System.Windows.Forms.RadioButton()
        Me.optdescripcion = New System.Windows.Forms.RadioButton()
        Me.optBarra = New System.Windows.Forms.RadioButton()
        Me.optcodigo = New System.Windows.Forms.RadioButton()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optoDescripcion = New System.Windows.Forms.RadioButton()
        Me.optoCodigo = New System.Windows.Forms.RadioButton()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(465, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consulta de Productos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.optProveedor)
        Me.GroupBox1.Controls.Add(Me.optCategoria)
        Me.GroupBox1.Controls.Add(Me.optMarca)
        Me.GroupBox1.Controls.Add(Me.optdescripcion)
        Me.GroupBox1.Controls.Add(Me.optBarra)
        Me.GroupBox1.Controls.Add(Me.optcodigo)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(774, 68)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar producto por"
        '
        'optProveedor
        '
        Me.optProveedor.AutoSize = True
        Me.optProveedor.Location = New System.Drawing.Point(639, 31)
        Me.optProveedor.Name = "optProveedor"
        Me.optProveedor.Size = New System.Drawing.Size(117, 28)
        Me.optProveedor.TabIndex = 10
        Me.optProveedor.TabStop = True
        Me.optProveedor.Text = "Proveedor"
        Me.optProveedor.UseVisualStyleBackColor = True
        '
        'optCategoria
        '
        Me.optCategoria.AutoSize = True
        Me.optCategoria.Location = New System.Drawing.Point(508, 31)
        Me.optCategoria.Name = "optCategoria"
        Me.optCategoria.Size = New System.Drawing.Size(111, 28)
        Me.optCategoria.TabIndex = 9
        Me.optCategoria.TabStop = True
        Me.optCategoria.Text = "Categoria"
        Me.optCategoria.UseVisualStyleBackColor = True
        '
        'optMarca
        '
        Me.optMarca.AutoSize = True
        Me.optMarca.Location = New System.Drawing.Point(399, 31)
        Me.optMarca.Name = "optMarca"
        Me.optMarca.Size = New System.Drawing.Size(83, 28)
        Me.optMarca.TabIndex = 8
        Me.optMarca.TabStop = True
        Me.optMarca.Text = "Marca"
        Me.optMarca.UseVisualStyleBackColor = True
        '
        'optdescripcion
        '
        Me.optdescripcion.AutoSize = True
        Me.optdescripcion.Location = New System.Drawing.Point(247, 31)
        Me.optdescripcion.Name = "optdescripcion"
        Me.optdescripcion.Size = New System.Drawing.Size(127, 28)
        Me.optdescripcion.TabIndex = 7
        Me.optdescripcion.TabStop = True
        Me.optdescripcion.Text = "Descripcion"
        Me.optdescripcion.UseVisualStyleBackColor = True
        '
        'optBarra
        '
        Me.optBarra.AutoSize = True
        Me.optBarra.Location = New System.Drawing.Point(129, 31)
        Me.optBarra.Name = "optBarra"
        Me.optBarra.Size = New System.Drawing.Size(76, 28)
        Me.optBarra.TabIndex = 6
        Me.optBarra.TabStop = True
        Me.optBarra.Text = "Barra"
        Me.optBarra.UseVisualStyleBackColor = True
        '
        'optcodigo
        '
        Me.optcodigo.AutoSize = True
        Me.optcodigo.Location = New System.Drawing.Point(6, 31)
        Me.optcodigo.Name = "optcodigo"
        Me.optcodigo.Size = New System.Drawing.Size(89, 28)
        Me.optcodigo.TabIndex = 5
        Me.optcodigo.TabStop = True
        Me.optcodigo.Text = "Codigo"
        Me.optcodigo.UseVisualStyleBackColor = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbuscar.Location = New System.Drawing.Point(24, 115)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(1008, 22)
        Me.txtbuscar.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.optoDescripcion)
        Me.GroupBox2.Controls.Add(Me.optoCodigo)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(828, 175)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 68)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ordernar registros por"
        '
        'optoDescripcion
        '
        Me.optoDescripcion.AutoSize = True
        Me.optoDescripcion.Location = New System.Drawing.Point(221, 31)
        Me.optoDescripcion.Name = "optoDescripcion"
        Me.optoDescripcion.Size = New System.Drawing.Size(127, 28)
        Me.optoDescripcion.TabIndex = 7
        Me.optoDescripcion.TabStop = True
        Me.optoDescripcion.Text = "Descripcion"
        Me.optoDescripcion.UseVisualStyleBackColor = True
        '
        'optoCodigo
        '
        Me.optoCodigo.AutoSize = True
        Me.optoCodigo.Location = New System.Drawing.Point(6, 31)
        Me.optoCodigo.Name = "optoCodigo"
        Me.optoCodigo.Size = New System.Drawing.Size(89, 28)
        Me.optoCodigo.TabIndex = 6
        Me.optoCodigo.TabStop = True
        Me.optoCodigo.Text = "Codigo"
        Me.optoCodigo.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.Location = New System.Drawing.Point(1038, 114)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(192, 23)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'grilla
        '
        Me.grilla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grilla.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Location = New System.Drawing.Point(24, 262)
        Me.grilla.Name = "grilla"
        Me.grilla.RowTemplate.Height = 24
        Me.grilla.Size = New System.Drawing.Size(1206, 446)
        Me.grilla.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btnSalir)
        Me.GroupBox3.Controls.Add(Me.btnEliminar)
        Me.GroupBox3.Controls.Add(Me.btnModificar)
        Me.GroupBox3.Controls.Add(Me.btnAgregar)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(518, 734)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 84)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Operaciones"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(540, 36)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(139, 27)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(375, 36)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(139, 27)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(206, 36)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(139, 27)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(32, 36)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(144, 27)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'FrmProductoLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 841)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grilla)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmProductoLista"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optProveedor As RadioButton
    Friend WithEvents optCategoria As RadioButton
    Friend WithEvents optMarca As RadioButton
    Friend WithEvents optdescripcion As RadioButton
    Friend WithEvents optBarra As RadioButton
    Friend WithEvents optcodigo As RadioButton
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optoDescripcion As RadioButton
    Friend WithEvents optoCodigo As RadioButton
    Friend WithEvents btnBuscar As Button
    Friend WithEvents grilla As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
End Class
