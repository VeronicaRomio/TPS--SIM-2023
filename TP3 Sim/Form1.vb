

Imports TP3_Sim.GeneradorVariables
Public Class Form1
    Dim random As GeneradorVariables
    Dim ancho As Double
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        random = New GeneradorVariables
        inicializarChart()
        CmbDistribuciones.SelectedIndex = -1
        CmbDistribuciones.Focus()


    End Sub

    Private Sub BtnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerar.Click

        inicializarChart()
            BtnGenerar.Enabled = True
            For index = 1 To Integer.Parse(TxtCantidad.Text)

                If CmbDistribuciones.SelectedIndex = 0 Then
                    LstAleatorios.Items.Add(random.generarUniforme(Integer.Parse(TxtA.Text), Integer.Parse(TxtB.Text)))
                End If

                If CmbDistribuciones.SelectedIndex = 1 Then
                    LstAleatorios.Items.Add(random.generarExponencialNegativa(1 / (Double.Parse(TxtLambda.Text.Replace(".", ",")))))

                End If

            If CmbDistribuciones.SelectedIndex = 3 Then
                LstAleatorios.Items.Add(random.generarNormal(Double.Parse(TxtMedia.Text.Replace(".", ",")), Double.Parse(TxtDesv.Text.Replace(".", ","))))

            End If
        Next index

            graficar()
            calcularChiCuadrado()
            BtnGenerar.Enabled = False

    End Sub

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

    Private Sub graficar()

        Select Case CmbDistribuciones.SelectedIndex
            Case 0
                graficarDistribuciones(Double.Parse(TxtA.Text), Double.Parse(TxtB.Text), False)
            Case 1
                graficarDistribuciones(0, obtenerMax(), False)
            Case 2
                graficarDistribuciones(obtenerMin(), obtenerMax(), True)
            Case 3
                graficarDistribuciones(obtenerMin(), obtenerMax(), False)
        End Select


    End Sub

    Private Sub graficarDistribuciones(ByVal min As Double, ByVal max As Double, ByVal sinIntervalos As Boolean)
        Dim minimo As Double = min
        Dim maximo As Double = max
        Dim acum As Integer
        If sinIntervalos = False Then

            Dim sim As String = ")"
            ancho = (maximo - minimo) / Double.Parse(txtIntervalos.Text)



            For index = 0 To txtIntervalos.Text - 1
                acum = 0
                Dim num As Double = (ancho * index) + minimo

                For Each item As Double In LstAleatorios.Items

                    If (index < txtIntervalos.Text - 1) Then
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

            Next



        Else

            For index = min To max
                acum = 0
                For Each item As Integer In LstAleatorios.Items
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
        limpiar()
        inicializarChart()
        LstAleatorios.Items.Clear()
        BtnGenerar.Enabled = True
        TxtCantidad.Enabled = True
        txtIntervalos.Enabled = True
        Select Case CmbDistribuciones.SelectedIndex
            Case 0

                TxtA.Enabled = True
                TxtA.Focus()
                TxtB.Enabled = True

            Case 1
                TxtLambda.Enabled = True
                TxtLambda.Focus()

            Case 2
                TxtLambda.Enabled = True
                TxtLambda.Focus()
                txtIntervalos.Enabled = False

            Case 3
                TxtMedia.Enabled = True
                TxtDesv.Enabled = True
                TxtMedia.Focus()
        End Select

    End Sub

    Private Sub limpiar()

        For Each item As Control In Me.Controls
            If (item.GetType.ToString = "System.Windows.Forms.MaskedTextBox") Or (item.GetType.ToString = "System.Windows.Forms.TextBox") Then
                item.Text = ""

            End If
        Next

    End Sub
    Private Function obtenerMax() As Double
        Dim max As Double = LstAleatorios.Items(0)

        For Each item As Double In LstAleatorios.Items
            If (item > max) Then
                max = item
            End If
        Next
        Return max
    End Function

    Private Function obtenerMin() As Double
        Dim min As Double = LstAleatorios.Items(0)

        For Each item As Double In LstAleatorios.Items
            If (item < min) Then
                min = item
            End If
        Next
        Return min
    End Function

    Private Sub calcularChiCuadrado()
        Select Case CmbDistribuciones.SelectedIndex
            Case 0
                ChiCuadradoUniforme()
            Case 1
                ChiCuadradoExponencialNegativa()
            Case 2
                ChiCuadradoPoisson()
            Case 3
                ChiCuadradoNormal()

        End Select
    End Sub

    Private Sub ChiCuadradoUniforme()
        Dim valor As Double
        Dim fe As Double = Double.Parse(txtCantidad.Text) / Double.Parse(txtIntervalos.Text)

        For index = 0 To Integer.Parse(txtIntervalos.Text) - 1
            valor += ((fe - grafico.Series(0).Points(index).YValues(0)) ^ 2) / fe
        Next

        TxtChiCuadrado.Text = String.Format("{0:C4}", valor).Replace("$", "").Replace("€", "")
        txtV.Text = String.Format("{0:C0}", (txtIntervalos.Text - 1)).Replace("$", "").Replace("€", "")
    End Sub

    Private Sub ChiCuadradoExponencialNegativa()

        Dim valor As Double
        Dim frecObservada() As Double = frecuenciaObs()


        Dim marcaClase(frecObservada.Length - 1) As Double

        For index = 0 To Integer.Parse(txtIntervalos.Text) - 1

            Dim limInf As Double = Double.Parse(Split(grafico.Series(0).Points(index).AxisLabel.Replace("[", "").Replace(".", ","), "_", 2)(0))
            Dim limsup As Double = Double.Parse(Split(grafico.Series(0).Points(index).AxisLabel.Replace(")", "").Replace("]", "").Replace(".", ","), "_", 2)(1))
            marcaClase(index) = (limInf + limsup) / 2
        Next

        Dim frecEsperada(frecObservada.Length - 1) As Double


        For index = 0 To frecEsperada.Length - 1


            frecEsperada(index) = Double.Parse(TxtLambda.Text.Replace(".", ",")) * Math.Exp(Double.Parse(TxtLambda.Text.Replace(".", ",") * -1 * marcaClase(index))) * Integer.Parse(TxtCantidad.Text)

        Next


        Dim nuevosVectores As List(Of Double()) = tratarFrecuencias(frecObservada, frecEsperada)

        frecObservada = nuevosVectores.Item(0)
        frecEsperada = nuevosVectores.Item(1)

        For index = 0 To frecEsperada.Length - 1

            valor += (Math.Pow((frecEsperada(index) - frecObservada(index)), 2) / frecEsperada(index))

        Next

        TxtChiCuadrado.Text = String.Format("{0:C4}", valor).Replace("$", "").Replace("€", "")

    End Sub

    Private Function frecuenciaObs() As Double()
        Dim frecObservada(Double.Parse(grafico.Series(0).Points.Count) - 1) As Double


        For index = 0 To Integer.Parse(grafico.Series(0).Points.Count) - 1
            frecObservada(index) = Double.Parse(grafico.Series(0).Points(index).Label)
        Next

        Return frecObservada
    End Function

    Private Sub ChiCuadradoPoisson()

        Dim valor As Double
        Dim frecObservada() As Double = frecuenciaObs()

        Dim frecEsperada(frecObservada.Length - 1) As Double


        Dim suma As Double = 0
        For index = 0 To frecEsperada.Length - 2

            Dim factorial As Double = 1
            For i = 0 To Integer.Parse(grafico.Series(0).Points(index).XValue)
                If (i <> 0) Then
                    factorial *= i
                End If
            Next
            frecEsperada(index) = (Math.Pow(Double.Parse(TxtLambda.Text.Replace(".", ",")), Double.Parse(grafico.Series(0).Points(index).XValue)) * Math.Exp(-1 * TxtLambda.Text.Replace(".", ",")) / (factorial))
            suma += frecEsperada(index)
        Next


        frecEsperada(frecEsperada.Length - 1) = 1 - suma
        For index = 0 To frecEsperada.Length - 1
            frecEsperada(index) = frecEsperada(index) * Double.Parse(TxtCantidad.Text)
        Next


        Dim lista As List(Of Double()) = tratarFrecuencias(frecObservada, frecEsperada)

        frecObservada = lista.Item(0)
        frecEsperada = lista.Item(1)

        For index = 0 To frecEsperada.Length - 1

            valor += (Math.Pow((frecEsperada(index) - frecObservada(index)), 2) / frecEsperada(index))

        Next

        TxtChiCuadrado.Text = String.Format("{0:C4}", valor).Replace("$", "").Replace("€", "")
    End Sub

    Private Sub ChiCuadradoNormal()


        Dim frecObservada() As Double = frecuenciaObs()

        Dim frecEsperada(frecObservada.Length - 1) As Double
        For index = 0 To frecEsperada.Length - 1
            Dim limInf As Double = Double.Parse(Split(grafico.Series(0).Points(index).AxisLabel.Replace("[", "").Replace(".", ","), "_", 2)(0))

            Dim limsup As Double = Double.Parse(Split(grafico.Series(0).Points(index).AxisLabel.Replace(")", "").Replace("]", "").Replace(".", ","), "_", 2)(1))

            frecEsperada(index) = (((PrPuntualNormal(limInf) + PrPuntualNormal(limsup)) / 2) * ancho) * Double.Parse(TxtCantidad.Text)

        Next

        Dim nuevosVectores As List(Of Double()) = tratarFrecuencias(frecObservada, frecEsperada)

        frecObservada = nuevosVectores.Item(0)
        frecEsperada = nuevosVectores.Item(1)


        Dim valor As Double = 0
        For index = 0 To frecEsperada.Length - 1

            valor += (Math.Pow((frecEsperada(index) - frecObservada(index)), 2) / frecEsperada(index))

        Next


        TxtChiCuadrado.Text = String.Format("{0:C4}", valor).Replace("$", "").Replace("€", "")



    End Sub

    Private Function tratarFrecuencias(ByVal frecObservada As Double(), ByVal frecEsperada As Double()) As List(Of Double())

        Dim nuevosVectores As List(Of Double()) = New List(Of Double())

        Dim largo As Integer = frecEsperada.Length - 1
        For index = 0 To largo

            If index <= largo Then

                If (frecEsperada(index) < 5) Then

                    If (index = 0 Or (index > 0 And index < (frecEsperada.Length - 1))) Then

                        frecEsperada(index) = frecEsperada(index) + frecEsperada(index + 1)
                        frecEsperada(index + 1) = -1
                        frecObservada(index) = frecObservada(index) + frecObservada(index + 1)
                        frecObservada(index + 1) = -1
                    Else
                        frecEsperada(index) = frecEsperada(index) + frecEsperada(index - 1)
                        frecEsperada(index - 1) = -1
                        frecObservada(index) = frecObservada(index) + frecObservada(index - 1)
                        frecObservada(index - 1) = -1

                    End If

                    frecEsperada = obtenerVectorSinNulos(frecEsperada)
                    frecObservada = obtenerVectorSinNulos(frecObservada)
                    largo -= 1
                    index = -1

                End If
            Else
                Exit For

            End If


        Next


        nuevosVectores.Add(frecObservada)
        nuevosVectores.Add(frecEsperada)
        If (CmbDistribuciones.SelectedIndex = 1 Or CmbDistribuciones.SelectedIndex = 2) Then
            txtV.Text = String.Format("{0:C0}", frecEsperada.Length - 2).Replace("$", "").Replace("€", "")
        End If
        If (CmbDistribuciones.SelectedIndex = 3) Then
            txtV.Text = String.Format("{0:C0}", frecEsperada.Length - 3).Replace("$", "").Replace("€", "")
        End If
        Return nuevosVectores
    End Function

    Private Function obtenerVectorSinNulos(ByVal vector As Double()) As Double()
        Dim count As Integer = 0

        For index = 0 To vector.Length - 1

            If vector(index) <> -1 Then
                count += 1

            End If
        Next

        Dim nuevoVector(count - 1) As Double

        Dim j As Integer = 0
        For index = 0 To vector.Length - 1
            If vector(index) <> -1 Then
                nuevoVector(j) = vector(index)
                j += 1

            End If
        Next

        Return nuevoVector
    End Function

    Private Function PrPuntualNormal(x As Double) As Double
        Dim desvEstandar As Double = Double.Parse(TxtDesv.Text.Replace(".", ","))
        Dim media As Double = Double.Parse(TxtMedia.Text.Replace(".", ","))
        Return ((1 / (desvEstandar * Math.Sqrt(2 * Math.PI))) * Math.Exp(-1 * 0.5 * Math.Pow((x - media) / desvEstandar, 2)))
    End Function

    Private Sub txtIntervalos_TextChanged(sender As Object, e As EventArgs) Handles txtIntervalos.TextChanged

    End Sub

    Private Sub label2_Click(sender As Object, e As EventArgs)

    End Sub
End Class

