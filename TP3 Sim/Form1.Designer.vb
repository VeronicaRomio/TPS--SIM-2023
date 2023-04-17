<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.TxtDesv = New System.Windows.Forms.TextBox()
        Me.TxtMedia = New System.Windows.Forms.TextBox()
        Me.TxtLambda = New System.Windows.Forms.TextBox()
        Me.LblDistribucion = New System.Windows.Forms.Label()
        Me.CmbDistribuciones = New System.Windows.Forms.ComboBox()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.ListaAleatorios = New System.Windows.Forms.ListBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.CmbIntervalos = New System.Windows.Forms.ComboBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.grafico = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TablaDatos = New System.Windows.Forms.DataGridView()
        Me.Inferior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Superior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.grafico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtDesv
        '
        Me.TxtDesv.Enabled = False
        Me.TxtDesv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesv.Location = New System.Drawing.Point(271, 481)
        Me.TxtDesv.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDesv.MaxLength = 5
        Me.TxtDesv.Name = "TxtDesv"
        Me.TxtDesv.Size = New System.Drawing.Size(53, 30)
        Me.TxtDesv.TabIndex = 27
        '
        'TxtMedia
        '
        Me.TxtMedia.Enabled = False
        Me.TxtMedia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMedia.Location = New System.Drawing.Point(335, 428)
        Me.TxtMedia.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMedia.MaxLength = 5
        Me.TxtMedia.Name = "TxtMedia"
        Me.TxtMedia.Size = New System.Drawing.Size(52, 30)
        Me.TxtMedia.TabIndex = 26
        '
        'TxtLambda
        '
        Me.TxtLambda.Enabled = False
        Me.TxtLambda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLambda.Location = New System.Drawing.Point(137, 432)
        Me.TxtLambda.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLambda.MaxLength = 6
        Me.TxtLambda.Name = "TxtLambda"
        Me.TxtLambda.Size = New System.Drawing.Size(52, 30)
        Me.TxtLambda.TabIndex = 24
        '
        'LblDistribucion
        '
        Me.LblDistribucion.AutoSize = True
        Me.LblDistribucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDistribucion.Location = New System.Drawing.Point(67, 144)
        Me.LblDistribucion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDistribucion.Name = "LblDistribucion"
        Me.LblDistribucion.Size = New System.Drawing.Size(153, 25)
        Me.LblDistribucion.TabIndex = 25
        Me.LblDistribucion.Text = "DISTRIBUCION"
        '
        'CmbDistribuciones
        '
        Me.CmbDistribuciones.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.CmbDistribuciones.FormattingEnabled = True
        Me.CmbDistribuciones.Items.AddRange(New Object() {"UNIFORME", "EXPONENCIAL", "NORMAL"})
        Me.CmbDistribuciones.Location = New System.Drawing.Point(241, 145)
        Me.CmbDistribuciones.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbDistribuciones.Name = "CmbDistribuciones"
        Me.CmbDistribuciones.Size = New System.Drawing.Size(122, 24)
        Me.CmbDistribuciones.TabIndex = 21
        '
        'BtnGenerar
        '
        Me.BtnGenerar.BackColor = System.Drawing.Color.Blue
        Me.BtnGenerar.Enabled = False
        Me.BtnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerar.ForeColor = System.Drawing.Color.White
        Me.BtnGenerar.Location = New System.Drawing.Point(137, 772)
        Me.BtnGenerar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(148, 57)
        Me.BtnGenerar.TabIndex = 32
        Me.BtnGenerar.Text = "GENERAR"
        Me.BtnGenerar.UseVisualStyleBackColor = False
        '
        'ListaAleatorios
        '
        Me.ListaAleatorios.FormattingEnabled = True
        Me.ListaAleatorios.ItemHeight = 16
        Me.ListaAleatorios.Location = New System.Drawing.Point(447, 34)
        Me.ListaAleatorios.Margin = New System.Windows.Forms.Padding(4)
        Me.ListaAleatorios.Name = "ListaAleatorios"
        Me.ListaAleatorios.Size = New System.Drawing.Size(197, 228)
        Me.ListaAleatorios.TabIndex = 33
        '
        'txtCantidad
        '
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(237, 618)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(118, 30)
        Me.txtCantidad.TabIndex = 43
        '
        'txtA
        '
        Me.txtA.Enabled = False
        Me.txtA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(137, 378)
        Me.txtA.Margin = New System.Windows.Forms.Padding(4)
        Me.txtA.MaxLength = 6
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(52, 30)
        Me.txtA.TabIndex = 24
        '
        'txtB
        '
        Me.txtB.Enabled = False
        Me.txtB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.Location = New System.Drawing.Point(284, 373)
        Me.txtB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtB.MaxLength = 6
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(52, 30)
        Me.txtB.TabIndex = 24
        '
        'CmbIntervalos
        '
        Me.CmbIntervalos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbIntervalos.FormattingEnabled = True
        Me.CmbIntervalos.Items.AddRange(New Object() {"10", "15", "20", "25"})
        Me.CmbIntervalos.Location = New System.Drawing.Point(281, 672)
        Me.CmbIntervalos.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbIntervalos.Name = "CmbIntervalos"
        Me.CmbIntervalos.Size = New System.Drawing.Size(59, 32)
        Me.CmbIntervalos.TabIndex = 73
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.Location = New System.Drawing.Point(120, 674)
        Me.label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(145, 25)
        Me.label15.TabIndex = 72
        Me.label15.Text = "INTERVALOS:"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(45, 562)
        Me.label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(350, 25)
        Me.label11.TabIndex = 64
        Me.label11.Text = "                 ALEATORIOS:               "
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(49, 305)
        Me.label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(349, 25)
        Me.label9.TabIndex = 62
        Me.label9.Text = "               PARAMETROS:               "
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(81, 621)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(121, 25)
        Me.label7.TabIndex = 61
        Me.label7.Text = "CANTIDAD:"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(232, 432)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(87, 25)
        Me.label8.TabIndex = 60
        Me.label8.Text = "MEDIA:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(236, 378)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(33, 25)
        Me.label5.TabIndex = 59
        Me.label5.Text = "B:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(93, 432)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(30, 25)
        Me.label4.TabIndex = 58
        Me.label4.Text = "λ:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(95, 378)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(34, 25)
        Me.label3.TabIndex = 57
        Me.label3.Text = "A:"
        '
        'grafico
        '
        Me.grafico.BorderlineWidth = 3
        ChartArea2.Name = "ChartArea1"
        Me.grafico.ChartAreas.Add(ChartArea2)
        Me.grafico.Cursor = System.Windows.Forms.Cursors.Default
        Legend2.Name = "Legend1"
        Me.grafico.Legends.Add(Legend2)
        Me.grafico.Location = New System.Drawing.Point(447, 373)
        Me.grafico.Margin = New System.Windows.Forms.Padding(4)
        Me.grafico.Name = "grafico"
        Me.grafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Me.grafico.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "FO"
        Me.grafico.Series.Add(Series2)
        Me.grafico.Size = New System.Drawing.Size(898, 443)
        Me.grafico.TabIndex = 51
        Me.grafico.Text = "Histograma"
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "HISTOGRAMA DE FO"
        Title2.Text = "HISTOGRAMA DE FO"
        Me.grafico.Titles.Add(Title2)
        '
        'TablaDatos
        '
        Me.TablaDatos.AllowUserToAddRows = False
        Me.TablaDatos.AllowUserToDeleteRows = False
        Me.TablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Inferior, Me.Superior, Me.FO, Me.FE})
        Me.TablaDatos.Location = New System.Drawing.Point(653, 36)
        Me.TablaDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.TablaDatos.Name = "TablaDatos"
        Me.TablaDatos.ReadOnly = True
        Me.TablaDatos.RowHeadersWidth = 51
        Me.TablaDatos.Size = New System.Drawing.Size(725, 229)
        Me.TablaDatos.TabIndex = 49
        '
        'Inferior
        '
        Me.Inferior.HeaderText = "Inferior"
        Me.Inferior.MinimumWidth = 6
        Me.Inferior.Name = "Inferior"
        Me.Inferior.ReadOnly = True
        Me.Inferior.Width = 125
        '
        'Superior
        '
        Me.Superior.HeaderText = "Superior"
        Me.Superior.MinimumWidth = 6
        Me.Superior.Name = "Superior"
        Me.Superior.ReadOnly = True
        Me.Superior.Width = 125
        '
        'FO
        '
        Me.FO.HeaderText = "FO"
        Me.FO.MinimumWidth = 6
        Me.FO.Name = "FO"
        Me.FO.ReadOnly = True
        Me.FO.Width = 125
        '
        'FE
        '
        Me.FE.HeaderText = "FE"
        Me.FE.MinimumWidth = 6
        Me.FE.Name = "FE"
        Me.FE.ReadOnly = True
        Me.FE.Width = 125
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(39, 57)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(352, 25)
        Me.label1.TabIndex = 45
        Me.label1.Text = "               DISTRIBUCIÓN:               "
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(45, 356)
        Me.label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(348, 175)
        Me.label10.TabIndex = 63
        Me.label10.Text = " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                                        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(43, 599)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(348, 125)
        Me.label6.TabIndex = 66
        Me.label6.Text = " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                                        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(81, 485)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(156, 25)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "DESV. ESTAN"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(43, 103)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(348, 125)
        Me.Label17.TabIndex = 75
        Me.Label17.Text = " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                                        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1459, 895)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CmbIntervalos)
        Me.Controls.Add(Me.label15)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.grafico)
        Me.Controls.Add(Me.TablaDatos)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.TxtDesv)
        Me.Controls.Add(Me.TxtMedia)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.TxtLambda)
        Me.Controls.Add(Me.LblDistribucion)
        Me.Controls.Add(Me.CmbDistribuciones)
        Me.Controls.Add(Me.BtnGenerar)
        Me.Controls.Add(Me.ListaAleatorios)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.Label17)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.grafico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtDesv As System.Windows.Forms.TextBox
    Friend WithEvents TxtMedia As System.Windows.Forms.TextBox
    Friend WithEvents TxtLambda As System.Windows.Forms.TextBox
    Friend WithEvents LblDistribucion As System.Windows.Forms.Label
    Friend WithEvents CmbDistribuciones As System.Windows.Forms.ComboBox
    Friend WithEvents BtnGenerar As System.Windows.Forms.Button
    Friend WithEvents ListaAleatorios As System.Windows.Forms.ListBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Private WithEvents CmbIntervalos As ComboBox
    Private WithEvents label15 As Label
    Private WithEvents label11 As Label
    Private WithEvents label9 As Label
    Private WithEvents label7 As Label
    Private WithEvents label8 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents grafico As DataVisualization.Charting.Chart
    Private WithEvents TablaDatos As DataGridView
    Private WithEvents label1 As Label
    Private WithEvents label10 As Label
    Private WithEvents label6 As Label
    Private WithEvents Label16 As Label
    Private WithEvents Label17 As Label
    Friend WithEvents Inferior As DataGridViewTextBoxColumn
    Friend WithEvents Superior As DataGridViewTextBoxColumn
    Friend WithEvents FO As DataGridViewTextBoxColumn
    Friend WithEvents FE As DataGridViewTextBoxColumn
End Class
