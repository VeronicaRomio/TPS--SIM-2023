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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.txtV = New System.Windows.Forms.TextBox()
        Me.TxtChiCuadrado = New System.Windows.Forms.TextBox()
        Me.TxtDesv = New System.Windows.Forms.TextBox()
        Me.TxtMedia = New System.Windows.Forms.TextBox()
        Me.TxtLambda = New System.Windows.Forms.TextBox()
        Me.LblDistribucion = New System.Windows.Forms.Label()
        Me.CmbDistribuciones = New System.Windows.Forms.ComboBox()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.LstAleatorios = New System.Windows.Forms.ListBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.CmbIntervalos = New System.Windows.Forms.ComboBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.grafico = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Aleatorios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inferior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Superior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Acumulado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grafico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtV
        '
        Me.txtV.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtV.Enabled = False
        Me.txtV.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtV.Location = New System.Drawing.Point(662, 243)
        Me.txtV.Name = "txtV"
        Me.txtV.Size = New System.Drawing.Size(43, 23)
        Me.txtV.TabIndex = 42
        Me.txtV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtChiCuadrado
        '
        Me.TxtChiCuadrado.BackColor = System.Drawing.Color.Aqua
        Me.TxtChiCuadrado.Enabled = False
        Me.TxtChiCuadrado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtChiCuadrado.Location = New System.Drawing.Point(571, 243)
        Me.TxtChiCuadrado.Name = "TxtChiCuadrado"
        Me.TxtChiCuadrado.Size = New System.Drawing.Size(46, 23)
        Me.TxtChiCuadrado.TabIndex = 36
        Me.TxtChiCuadrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDesv
        '
        Me.TxtDesv.Enabled = False
        Me.TxtDesv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesv.Location = New System.Drawing.Point(203, 391)
        Me.TxtDesv.MaxLength = 5
        Me.TxtDesv.Name = "TxtDesv"
        Me.TxtDesv.Size = New System.Drawing.Size(41, 26)
        Me.TxtDesv.TabIndex = 27
        '
        'TxtMedia
        '
        Me.TxtMedia.Enabled = False
        Me.TxtMedia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMedia.Location = New System.Drawing.Point(251, 348)
        Me.TxtMedia.MaxLength = 5
        Me.TxtMedia.Name = "TxtMedia"
        Me.TxtMedia.Size = New System.Drawing.Size(40, 26)
        Me.TxtMedia.TabIndex = 26
        '
        'TxtLambda
        '
        Me.TxtLambda.Enabled = False
        Me.TxtLambda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLambda.Location = New System.Drawing.Point(103, 351)
        Me.TxtLambda.MaxLength = 6
        Me.TxtLambda.Name = "TxtLambda"
        Me.TxtLambda.Size = New System.Drawing.Size(40, 26)
        Me.TxtLambda.TabIndex = 24
        '
        'LblDistribucion
        '
        Me.LblDistribucion.AutoSize = True
        Me.LblDistribucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDistribucion.Location = New System.Drawing.Point(37, 119)
        Me.LblDistribucion.Name = "LblDistribucion"
        Me.LblDistribucion.Size = New System.Drawing.Size(125, 20)
        Me.LblDistribucion.TabIndex = 25
        Me.LblDistribucion.Text = "DISTRIBUCION"
        '
        'CmbDistribuciones
        '
        Me.CmbDistribuciones.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.CmbDistribuciones.FormattingEnabled = True
        Me.CmbDistribuciones.Items.AddRange(New Object() {"UNIFORME", "EXPONENCIAL", "NORMAL"})
        Me.CmbDistribuciones.Location = New System.Drawing.Point(178, 118)
        Me.CmbDistribuciones.Name = "CmbDistribuciones"
        Me.CmbDistribuciones.Size = New System.Drawing.Size(124, 21)
        Me.CmbDistribuciones.TabIndex = 21
        '
        'BtnGenerar
        '
        Me.BtnGenerar.BackColor = System.Drawing.Color.Blue
        Me.BtnGenerar.Enabled = False
        Me.BtnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerar.ForeColor = System.Drawing.Color.White
        Me.BtnGenerar.Location = New System.Drawing.Point(133, 639)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(111, 46)
        Me.BtnGenerar.TabIndex = 32
        Me.BtnGenerar.Text = "GENERAR"
        Me.BtnGenerar.UseVisualStyleBackColor = False
        '
        'LstAleatorios
        '
        Me.LstAleatorios.FormattingEnabled = True
        Me.LstAleatorios.Location = New System.Drawing.Point(327, 29)
        Me.LstAleatorios.Name = "LstAleatorios"
        Me.LstAleatorios.Size = New System.Drawing.Size(149, 186)
        Me.LstAleatorios.TabIndex = 33
        '
        'txtCantidad
        '
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(191, 502)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(40, 26)
        Me.txtCantidad.TabIndex = 43
        '
        'txtA
        '
        Me.txtA.Enabled = False
        Me.txtA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(103, 307)
        Me.txtA.MaxLength = 6
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(40, 26)
        Me.txtA.TabIndex = 24
        '
        'txtB
        '
        Me.txtB.Enabled = False
        Me.txtB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.Location = New System.Drawing.Point(213, 303)
        Me.txtB.MaxLength = 6
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(40, 26)
        Me.txtB.TabIndex = 24
        '
        'CmbIntervalos
        '
        Me.CmbIntervalos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbIntervalos.FormattingEnabled = True
        Me.CmbIntervalos.Items.AddRange(New Object() {"10", "15", "20", "25"})
        Me.CmbIntervalos.Location = New System.Drawing.Point(211, 546)
        Me.CmbIntervalos.Name = "CmbIntervalos"
        Me.CmbIntervalos.Size = New System.Drawing.Size(45, 26)
        Me.CmbIntervalos.TabIndex = 73
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.Location = New System.Drawing.Point(90, 548)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(115, 20)
        Me.label15.TabIndex = 72
        Me.label15.Text = "INTERVALOS:"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.Location = New System.Drawing.Point(623, 243)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(33, 20)
        Me.label14.TabIndex = 71
        Me.label14.Text = "VS"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.Location = New System.Drawing.Point(709, 243)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(114, 20)
        Me.label13.TabIndex = 70
        Me.label13.Text = "Chi Tabulado"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(446, 243)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(119, 20)
        Me.label12.TabIndex = 68
        Me.label12.Text = "Chi Calculado"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(34, 457)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(287, 20)
        Me.label11.TabIndex = 64
        Me.label11.Text = "                 ALEATORIOS:               "
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(37, 248)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(286, 20)
        Me.label9.TabIndex = 62
        Me.label9.Text = "               PARAMETROS:               "
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(90, 505)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(95, 20)
        Me.label7.TabIndex = 61
        Me.label7.Text = "CANTIDAD:"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(174, 351)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(71, 20)
        Me.label8.TabIndex = 60
        Me.label8.Text = "MEDIA:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(177, 307)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(26, 20)
        Me.label5.TabIndex = 59
        Me.label5.Text = "B:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(70, 351)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(24, 20)
        Me.label4.TabIndex = 58
        Me.label4.Text = "λ:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(71, 307)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(26, 20)
        Me.label3.TabIndex = 57
        Me.label3.Text = "A:"
        '
        'grafico
        '
        ChartArea4.Name = "ChartArea1"
        Me.grafico.ChartAreas.Add(ChartArea4)
        Me.grafico.Cursor = System.Windows.Forms.Cursors.Default
        Legend4.Name = "Legend1"
        Me.grafico.Legends.Add(Legend4)
        Me.grafico.Location = New System.Drawing.Point(345, 305)
        Me.grafico.Name = "grafico"
        Me.grafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "FO"
        Me.grafico.Series.Add(Series4)
        Me.grafico.Size = New System.Drawing.Size(689, 360)
        Me.grafico.TabIndex = 51
        Me.grafico.Text = "Histograma"
        Title4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title4.Name = "HISTOGRAMA DE FO"
        Title4.Text = "HISTOGRAMA DE FO"
        Me.grafico.Titles.Add(Title4)
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Aleatorios, Me.Inferior, Me.Superior, Me.FO, Me.FE, Me.Acumulado})
        Me.dataGridView1.Location = New System.Drawing.Point(477, 29)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(651, 186)
        Me.dataGridView1.TabIndex = 49
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(29, 46)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(292, 20)
        Me.label1.TabIndex = 45
        Me.label1.Text = "               DISTRIBUCIÓN:               "
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(34, 289)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(289, 140)
        Me.label10.TabIndex = 63
        Me.label10.Text = " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                                        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(32, 487)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(289, 100)
        Me.label6.TabIndex = 66
        Me.label6.Text = " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                                        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(61, 394)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(126, 20)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "DESV. ESTAN"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(32, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(289, 100)
        Me.Label17.TabIndex = 75
        Me.Label17.Text = " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                                        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Aleatorios
        '
        Me.Aleatorios.HeaderText = "Aleatorios"
        Me.Aleatorios.Name = "Aleatorios"
        '
        'Inferior
        '
        Me.Inferior.HeaderText = "Inferior"
        Me.Inferior.Name = "Inferior"
        '
        'Superior
        '
        Me.Superior.HeaderText = "Superior"
        Me.Superior.Name = "Superior"
        '
        'FO
        '
        Me.FO.HeaderText = "FO"
        Me.FO.Name = "FO"
        '
        'FE
        '
        Me.FE.HeaderText = "FE"
        Me.FE.Name = "FE"
        '
        'Acumulado
        '
        Me.Acumulado.HeaderText = "Acumulado"
        Me.Acumulado.Name = "Acumulado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 727)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CmbIntervalos)
        Me.Controls.Add(Me.label15)
        Me.Controls.Add(Me.label14)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.grafico)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtV)
        Me.Controls.Add(Me.TxtChiCuadrado)
        Me.Controls.Add(Me.TxtDesv)
        Me.Controls.Add(Me.TxtMedia)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.TxtLambda)
        Me.Controls.Add(Me.LblDistribucion)
        Me.Controls.Add(Me.CmbDistribuciones)
        Me.Controls.Add(Me.BtnGenerar)
        Me.Controls.Add(Me.LstAleatorios)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.Label17)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.grafico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtV As System.Windows.Forms.TextBox
    Friend WithEvents TxtChiCuadrado As System.Windows.Forms.TextBox
    Friend WithEvents TxtDesv As System.Windows.Forms.TextBox
    Friend WithEvents TxtMedia As System.Windows.Forms.TextBox
    Friend WithEvents TxtLambda As System.Windows.Forms.TextBox
    Friend WithEvents LblDistribucion As System.Windows.Forms.Label
    Friend WithEvents CmbDistribuciones As System.Windows.Forms.ComboBox
    Friend WithEvents BtnGenerar As System.Windows.Forms.Button
    Friend WithEvents LstAleatorios As System.Windows.Forms.ListBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Private WithEvents CmbIntervalos As ComboBox
    Private WithEvents label15 As Label
    Private WithEvents label14 As Label
    Private WithEvents label13 As Label
    Private WithEvents label12 As Label
    Private WithEvents label11 As Label
    Private WithEvents label9 As Label
    Private WithEvents label7 As Label
    Private WithEvents label8 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents grafico As DataVisualization.Charting.Chart
    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents label1 As Label
    Private WithEvents label10 As Label
    Private WithEvents label6 As Label
    Private WithEvents Label16 As Label
    Private WithEvents Label17 As Label
    Friend WithEvents Aleatorios As DataGridViewTextBoxColumn
    Friend WithEvents Inferior As DataGridViewTextBoxColumn
    Friend WithEvents Superior As DataGridViewTextBoxColumn
    Friend WithEvents FO As DataGridViewTextBoxColumn
    Friend WithEvents FE As DataGridViewTextBoxColumn
    Friend WithEvents Acumulado As DataGridViewTextBoxColumn
End Class
