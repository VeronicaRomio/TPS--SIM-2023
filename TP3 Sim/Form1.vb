


Imports System.Reflection
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions
Imports TP3_Sim.GeneradorVariables
Public Class Form1
    Dim random As GeneradorVariables
    Dim ancho As Double
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        random = New GeneradorVariables
        'inicializarChart()
        CmbDistribuciones.SelectedIndex = -1
        CmbDistribuciones.Focus()


    End Sub


    Private Sub BtnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerar.Click
        inicializarChart()
        BtnGenerar.Enabled = True
        For index = 1 To Integer.Parse(txtCantidad.Text)

            If CmbDistribuciones.SelectedIndex = 0 Then
                ListaAleatorios.Items.Add(random.generarUniforme(Integer.Parse(txtA.Text), Integer.Parse(txtB.Text)))
            End If

            If CmbDistribuciones.SelectedIndex = 1 Then
                ListaAleatorios.Items.Add(random.generarExponencialNegativa(1 / (Double.Parse(TxtLambda.Text.Replace(".", ",")))))

            End If

            If CmbDistribuciones.SelectedIndex = 2 Then
                ListaAleatorios.Items.Add(random.generarNormal(Double.Parse(TxtMedia.Text.Replace(".", ",")), Double.Parse(TxtDesv.Text.Replace(".", ","))))

            End If
        Next index

        graficar()
        BtnGenerar.Enabled = False

    End Sub

    ' inicializarChart(): grafica las opciones generales del grafico, titulos y a agregar las frecuencias observadas 
    '                    para cada distribucion
    Private Sub inicializarChart()
        grafico.ChartAreas.Clear()
        grafico.ChartAreas.Add(0)
        grafico.ChartAreas(0).Axes(0).MajorGrid.LineColor = Color.Transparent
        grafico.ChartAreas(0).Axes(0).MajorTickMark.LineColor = Color.Transparent
        grafico.ChartAreas(0).Axes(0).ScaleView.Size = 3
        grafico.ChartAreas(0).Axes(0).Title = "Intervalos"
        grafico.ChartAreas(0).Axes(1).Title = "Frecuencias"

        'SERIE
        grafico.Series.Clear()
        grafico.Series.Add("Frec. Observadas")
        grafico.Series(0).CustomProperties = "PointWidth=1"
        grafico.Series(0).BorderColor = Color.Black

    End Sub

    ' graficar(): esta funcion va a llamar a las funciones de graficar distribucion, segun el combo de distribuciones
    '            que haya seleccionado el usuario
    Private Sub graficar()

        Select Case CmbDistribuciones.SelectedIndex
            Case 0
                graficarDistribucionesUniforme(Double.Parse(txtA.Text), Double.Parse(txtB.Text), False)
            Case 1
                graficarDistribucionesExponencial(0, obtenerMax(), False)
            Case 2
                graficarDistribucionesNormal(obtenerMin(), obtenerMax(), False, media(), desviacionEstandar())
        End Select


    End Sub

    'graficarDistribucionesUniforme(): funcion que nos ayuda a graficar la distribucion Uniforme y a llenar la tabla
    '                                  de datos de las frecuencias y los limites. Recibe como parametros el minimo,
    '                                  maximo y el boolean sinIntervalos
    Private Sub graficarDistribucionesUniforme(ByVal min As Double, ByVal max As Double, ByVal sinIntervalos As Boolean)
        Dim minimo As Double = min
        Dim maximo As Double = max
        Dim acum As Integer
        Dim a As Double = Math.Round(Double.Parse(txtA.Text), 4)
        Dim b As Double = Math.Round(Double.Parse(txtB.Text), 4)
        Dim fe As Double = Math.Round(((a + b) / 2), 4)


        If sinIntervalos = False Then
            'la variable sim es para delimitar el final de los limites en el grafico
            Dim sim As String = ")"
            ancho = Math.Round((maximo - minimo) / Double.Parse(CmbIntervalos.Text), 4)


            For index = 0 To CmbIntervalos.Text - 1
                acum = 0 'son las frecuencias observadas
                Dim num As Double = (ancho * index) + minimo

                For Each item As Double In ListaAleatorios.Items

                    If (index < CmbIntervalos.Text - 1) Then
                        If (num <= item) And ((num + ancho) > item) Then
                            acum += 1

                        End If
                    Else
                        If (num <= item) And ((num + ancho) >= item) Then
                            acum += 1
                            sim = "]"
                        End If
                    End If


                Next

                grafico.Series(0).Points.AddXY("[ " & String.Format("{0:C4}", num).Replace("$", "").Replace("€", "") & " _ " & String.Format("{0:C4}", (num + ancho)).Replace("$", "").Replace("€", "") & sim, acum)
                TablaDatos.Rows.Add(num, num + ancho, acum, fe)
            Next



        Else

            For index = min To max
                acum = 0
                For Each item As Integer In ListaAleatorios.Items
                    If item = index Then
                        acum += 1
                    End If
                Next

                grafico.Series(0).Points.AddXY(index, acum)

            Next



        End If
        For index = 0 To grafico.Series(0).Points.Count - 1
            grafico.Series(0).Points(index).Label = grafico.Series(0).Points(index).YValues(0)

        Next


    End Sub



    Private Sub graficarDistribucionesExponencial(ByVal min As Double, ByVal max As Double, ByVal sinIntervalos As Boolean)
        Dim minimo As Double = min
        Dim maximo As Double = max
        Dim acum As Integer
        Dim n As Double = Double.Parse(txtCantidad.Text)
        Dim lambda As Double = Double.Parse(TxtLambda.Text)
        Dim marca As Double


        If sinIntervalos = False Then

            Dim sim As String = ")"
            ancho = Math.Round((maximo - minimo) / Double.Parse(CmbIntervalos.Text), 4)


            For index = 0 To CmbIntervalos.Text - 1
                acum = 0
                'num es el limite inferior
                Dim num As Double = (ancho * index) + minimo

                For Each item As Double In ListaAleatorios.Items

                    If (index < CmbIntervalos.Text - 1) Then
                        If (num <= item) And ((num + ancho) > item) Then
                            acum += 1

                        End If
                    Else
                        If (num <= item) And ((num + ancho) >= item) Then
                            acum += 1
                            sim = "]"
                        End If
                    End If


                Next
                'num+ancho es el limite superior
                marca = Math.Round((num + num + ancho) / 2, 4)
                Dim fd As Double = (lambda * Math.Pow(Math.E, -lambda * marca)) * num
                Dim fa As Double = ((1 - Math.Pow(Math.E, -lambda * (num + ancho))) - (1 - Math.Pow(Math.E, -lambda * num)))
                Dim fe As Double = Math.Round(fa / n, 4)
                grafico.Series(0).Points.AddXY("[ " & String.Format("{0:C4}", num).Replace("$", "").Replace("€", "") & " _ " & String.Format("{0:C4}", (num + ancho)).Replace("$", "").Replace("€", "") & sim, acum)
                TablaDatos.Rows.Add(num, num + ancho, acum, fe)
            Next



        Else

            For index = min To max
                acum = 0
                For Each item As Integer In ListaAleatorios.Items
                    If item = index Then
                        acum += 1
                    End If
                Next

                grafico.Series(0).Points.AddXY(index, acum)

            Next



        End If
        For index = 0 To grafico.Series(0).Points.Count - 1
            grafico.Series(0).Points(index).Label = grafico.Series(0).Points(index).YValues(0)

        Next


    End Sub

    Private Sub graficarDistribucionesNormal(ByVal min As Double, ByVal max As Double, ByVal sinIntervalos As Boolean, ByVal media As Double, ByVal desviacion As Double)
        Dim minimo As Double = min
        Dim maximo As Double = max
        Dim acum As Integer
        Dim marca As Double '= (maximo + minimo) / 2
        Dim n As Double = Double.Parse(txtCantidad.Text) - 1
        Dim m As Double = media
        Dim desv As Double = desviacion
        Dim numerador As Double
        Dim denominador As Double = (desv * Math.Sqrt(2 * Math.PI))
        Dim fd As Double
        Dim fe As Double

        If sinIntervalos = False Then

            Dim sim As String = ")"
            ancho = Math.Round((maximo - minimo) / Double.Parse(CmbIntervalos.Text), 4)

            For index = 0 To CmbIntervalos.Text - 1
                acum = 0
                Dim num As Double = Math.Round((ancho * index) + minimo, 4)

                For Each item As Double In ListaAleatorios.Items
                    If (index < CmbIntervalos.Text - 1) Then
                        If (num <= item) And ((num + ancho) > item) Then
                            acum += 1

                        End If
                    Else
                        If (num <= item) And ((num + ancho) >= item) Then
                            acum += 1
                            sim = "]"
                        End If
                    End If

                Next
                marca = Math.Round((num + num + ancho) / 2, 4)
                numerador = Math.Exp(-0.5) * Math.Pow((marca - m) / desv, 2)
                grafico.Series(0).Points.AddXY("[ " & String.Format("{0:C4}", num).Replace("$", "").Replace("€", "") & " _ " & String.Format("{0:C4}", (num + ancho)).Replace("$", "").Replace("€", "") & sim, acum)
                fd = Math.Round((numerador / denominador) * ancho ,4)
                fe = Math.Round((n + 1) * fd, 4)
                TablaDatos.Rows.Add(num, num + ancho, acum, fe)
            Next



        Else

            For index = min To max
                acum = 0
                For Each item As Integer In ListaAleatorios.Items
                    If item = index Then
                        acum += 1
                    End If
                Next

                grafico.Series(0).Points.AddXY(index, acum)

            Next



        End If
        For index = 0 To grafico.Series(0).Points.Count - 1
            grafico.Series(0).Points(index).Label = grafico.Series(0).Points(index).YValues(0)

        Next


    End Sub
    Private Sub CmbDistribuciones_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmbDistribuciones.SelectedIndexChanged
        limpiarCmb()
        inicializarChart()
        ListaAleatorios.Items.Clear()
        BtnGenerar.Enabled = True
        txtCantidad.Enabled = True
        CmbIntervalos.Enabled = True
        Select Case CmbDistribuciones.SelectedIndex
            Case 0

                txtA.Enabled = True
                txtA.Focus()
                txtB.Enabled = True
                TxtLambda.Enabled = False
                TxtMedia.Enabled = False
                TxtDesv.Enabled = False

            Case 1
                TxtLambda.Enabled = True
                TxtLambda.Focus()
                txtA.Enabled = False
                txtB.Enabled = False
                TxtMedia.Enabled = False
                TxtDesv.Enabled = False

            Case 2
                TxtMedia.Enabled = True
                TxtDesv.Enabled = True
                TxtMedia.Focus()
                txtA.Enabled = False
                txtB.Enabled = False
                TxtLambda.Enabled = False
        End Select

    End Sub

    Private Sub limpiarCmb()

        txtA.Text = ""
        txtB.Text = ""
        txtCantidad.Text = ""
        TxtDesv.Text = ""
        TxtLambda.Text = ""
        TxtMedia.Text = ""
        CmbIntervalos.SelectedIndex = -1
        TablaDatos.Rows.Clear()

    End Sub
    Private Function obtenerMax() As Double
        Dim max As Double = ListaAleatorios.Items(0)

        For Each item As Double In ListaAleatorios.Items
            If (item > max) Then
                max = item
            End If
        Next
        Return max
    End Function

    Private Function obtenerMin() As Double
        Dim min As Double = ListaAleatorios.Items(0)

        For Each item As Double In ListaAleatorios.Items
            If (item < min) Then
                min = item
            End If
        Next
        Return min
    End Function

    Private Function desviacionEstandar() As Double
        Dim m As Double = media()
        Dim sumatoria As Double
        Dim cantidad As Double = Double.Parse(txtCantidad.Text) - 1
        Dim resta As Double
        Dim desvEst As Double
        For Each item As Double In ListaAleatorios.Items
            resta = item - m
            sumatoria = Math.Pow(resta, 2)
        Next
        desvEst = Math.Round(sumatoria / cantidad, 4)
        Return desvEst
    End Function

    Private Function media() As Double
        Dim acum As Double
        Dim cantidad As Double = Double.Parse(txtCantidad.Text)
        Dim m As Double
        For Each item As Double In ListaAleatorios.Items
            acum = +item
        Next
        m = Math.Round(acum / cantidad)
        Return m
    End Function
End Class

