<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Metodo_biseccion
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
        Me.la = New System.Windows.Forms.Label()
        Me.lb = New System.Windows.Forms.Label()
        Me.lcs = New System.Windows.Forms.Label()
        Me.lf = New System.Windows.Forms.Label()
        Me.ta = New System.Windows.Forms.TextBox()
        Me.tb = New System.Windows.Forms.TextBox()
        Me.tcs = New System.Windows.Forms.TextBox()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'la
        '
        Me.la.AutoSize = True
        Me.la.Location = New System.Drawing.Point(104, 34)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(44, 13)
        Me.la.TabIndex = 0
        Me.la.Text = "Dame a"
        '
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.Location = New System.Drawing.Point(104, 68)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(44, 13)
        Me.lb.TabIndex = 1
        Me.lb.Text = "Dame b"
        '
        'lcs
        '
        Me.lcs.AutoSize = True
        Me.lcs.Location = New System.Drawing.Point(104, 110)
        Me.lcs.Name = "lcs"
        Me.lcs.Size = New System.Drawing.Size(126, 13)
        Me.lcs.TabIndex = 2
        Me.lcs.Text = "Dame cifras significativas"
        '
        'lf
        '
        Me.lf.AutoSize = True
        Me.lf.Location = New System.Drawing.Point(104, 149)
        Me.lf.Name = "lf"
        Me.lf.Size = New System.Drawing.Size(73, 13)
        Me.lf.TabIndex = 3
        Me.lf.Text = "Dame función"
        '
        'ta
        '
        Me.ta.Location = New System.Drawing.Point(258, 31)
        Me.ta.Name = "ta"
        Me.ta.Size = New System.Drawing.Size(100, 20)
        Me.ta.TabIndex = 4
        '
        'tb
        '
        Me.tb.Location = New System.Drawing.Point(258, 65)
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(100, 20)
        Me.tb.TabIndex = 5
        '
        'tcs
        '
        Me.tcs.Location = New System.Drawing.Point(258, 107)
        Me.tcs.Name = "tcs"
        Me.tcs.Size = New System.Drawing.Size(100, 20)
        Me.tcs.TabIndex = 6
        '
        'tf
        '
        Me.tf.Location = New System.Drawing.Point(258, 146)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(100, 20)
        Me.tf.TabIndex = 7
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(562, 79)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 8
        Me.Calcular.Text = "&Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(562, 137)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 9
        Me.Salir.Text = "&Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'salida
        '
        Me.salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.salida.Location = New System.Drawing.Point(12, 217)
        Me.salida.Name = "salida"
        Me.salida.Size = New System.Drawing.Size(843, 150)
        Me.salida.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "Iteración i"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "a"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "x(i)"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "b"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "f(a)"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "f(x(i))"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "f(b)"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Error"
        Me.Column8.Name = "Column8"
        '
        'Metodo_biseccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 484)
        Me.Controls.Add(Me.salida)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.tcs)
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.ta)
        Me.Controls.Add(Me.lf)
        Me.Controls.Add(Me.lcs)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.la)
        Me.Name = "Metodo_biseccion"
        Me.Text = "Método de Bisección"
        CType(Me.salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents la As Label
    Friend WithEvents lb As Label
    Friend WithEvents lcs As Label
    Friend WithEvents lf As Label
    Friend WithEvents ta As TextBox
    Friend WithEvents tb As TextBox
    Friend WithEvents tcs As TextBox
    Friend WithEvents tf As TextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Salir As Button
    Friend WithEvents salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
