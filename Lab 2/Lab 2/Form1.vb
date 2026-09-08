Public Class Form1

    ' Botón "Calcular"
    ' Realiza las validaciones de entrada y calcula las soluciones de la ecuación.

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        ' 1. VALIDACIÓN: Verificar que los campos no estén vacíos usando If
        If txtA.Text.Trim() = "" OrElse txtB.Text.Trim() = "" OrElse txtC.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingrese los valores para A, B y C.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 2. VALIDACIÓN: Verificar que los datos ingresados sean numéricos usando If
        If Not IsNumeric(txtA.Text) OrElse Not IsNumeric(txtB.Text) OrElse Not IsNumeric(txtC.Text) Then
            MessageBox.Show("Por favor, ingrese únicamente números válidos en los coeficientes.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' 3. DECLARACIÓN DE VARIABLES (Utilizando tipo Double)
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim discriminante As Double
        Dim x1 As Double
        Dim x2 As Double

        ' Conversión del texto a tipo de dato Double
        a = Convert.ToDouble(txtA.Text)
        b = Convert.ToDouble(txtB.Text)
        c = Convert.ToDouble(txtC.Text)

        ' 4. ESTRUCTURA CONDICIONAL: Verificar si A = 0
        If a = 0 Then
            ' Si A = 0, no es una ecuación de segundo grado
            lblDiscriminante.Text = "N/A"
            lblResultado.Text = "No es una ecuación cuadrática (A no puede ser 0)."
            lblX1.Text = "-"
            lblX2.Text = "-"
            MessageBox.Show("El valor de A no puede ser 0 para una ecuación cuadrática.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            ' 5. CÁLCULO DEL DISCRIMINANTE: D = b² - 4ac
            discriminante = (b * b) - (4 * a * c)
            lblDiscriminante.Text = discriminante.ToString("N4")

            ' 6. ESTRUCTURA CONDICIONAL: Evaluar los casos del discriminante
            If discriminante > 0 Then
                ' CASO 1: Discriminante > 0 -> Dos soluciones reales distintas
                x1 = (-b + Math.Sqrt(discriminante)) / (2 * a)
                x2 = (-b - Math.Sqrt(discriminante)) / (2 * a)

                lblResultado.Text = "Tiene dos soluciones reales diferentes."
                lblX1.Text = x1.ToString("N4")
                lblX2.Text = x2.ToString("N4")

            ElseIf discriminante = 0 Then
                ' CASO 2: Discriminante = 0 -> Única solución real
                x1 = -b / (2 * a)

                lblResultado.Text = "Tiene una única solución real."
                lblX1.Text = x1.ToString("N4")
                lblX2.Text = "No aplica (Única solución)"

            Else
                ' CASO 3: Discriminante < 0 -> Sin soluciones reales
                lblResultado.Text = "La ecuación no tiene soluciones reales."
                lblX1.Text = "Sin solución real"
                lblX2.Text = "Sin solución real"

            End If

        End If

    End Sub

    ' EVENTO: Botón "Limpiar"
    ' Vacía los campos de texto, limpia los resultados y devuelve el foco a txtA.
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        ' Vaciar los TextBox de A, B y C
        txtA.Clear()
        txtB.Clear()
        txtC.Clear()

        ' Limpiar los Labels de resultados
        lblDiscriminante.Text = "-"
        lblResultado.Text = "-"
        lblX1.Text = "-"
        lblX2.Text = "-"

        ' Colocar el cursor nuevamente en el campo A
        txtA.Focus()
    End Sub

    ' Botón "Salir"
    ' Solicita confirmación mediante MessageBox 
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim respuesta As DialogResult

        ' Mostrar mensaje de confirmación
        respuesta = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Usar estructura If para cerrar la aplicación solo si responde Sí
        If respuesta = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class

