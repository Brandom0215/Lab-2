<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitulo = New Label()
        lblSubtitulo = New Label()
        lblEcuacion = New Label()
        grpDatos = New GroupBox()
        txtC = New TextBox()
        lblC = New Label()
        txtB = New TextBox()
        lblB = New Label()
        txtA = New TextBox()
        lblA = New Label()
        btnCalcular = New Button()
        grpResultados = New GroupBox()
        lblX2 = New Label()
        lblX2Titulo = New Label()
        lblX1 = New Label()
        lblX1Titulo = New Label()
        lblResultado = New Label()
        lblTipoTitulo = New Label()
        lblDiscriminante = New Label()
        lblDiscTitulo = New Label()
        btnLimpiar = New Button()
        btnSalir = New Button()
        grpDatos.SuspendLayout()
        grpResultados.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitulo.ForeColor = Color.FromArgb(24, 43, 73)
        lblTitulo.Location = New Point(12, 15)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(460, 35)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Ecuación Cuadrática"
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSubtitulo
        ' 
        lblSubtitulo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblSubtitulo.ForeColor = Color.FromArgb(100, 116, 139)
        lblSubtitulo.Location = New Point(12, 48)
        lblSubtitulo.Name = "lblSubtitulo"
        lblSubtitulo.Size = New Size(460, 20)
        lblSubtitulo.TabIndex = 1
        lblSubtitulo.Text = "LAB 2 - CICLO IF"
        lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblEcuacion
        ' 
        lblEcuacion.BackColor = Color.FromArgb(226, 232, 240)
        lblEcuacion.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblEcuacion.ForeColor = Color.FromArgb(30, 41, 59)
        lblEcuacion.Location = New Point(110, 78)
        lblEcuacion.Name = "lblEcuacion"
        lblEcuacion.Size = New Size(264, 32)
        lblEcuacion.TabIndex = 2
        lblEcuacion.Text = "ax² + bx + c = 0"
        lblEcuacion.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' grpDatos
        ' 
        grpDatos.Controls.Add(txtC)
        grpDatos.Controls.Add(lblC)
        grpDatos.Controls.Add(txtB)
        grpDatos.Controls.Add(lblB)
        grpDatos.Controls.Add(txtA)
        grpDatos.Controls.Add(lblA)
        grpDatos.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        grpDatos.ForeColor = Color.FromArgb(30, 41, 59)
        grpDatos.Location = New Point(40, 120)
        grpDatos.Name = "grpDatos"
        grpDatos.Size = New Size(404, 115)
        grpDatos.TabIndex = 3
        grpDatos.TabStop = False
        grpDatos.Text = " Ingreso de Coeficientes "
        ' 
        ' txtC
        ' 
        txtC.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        txtC.Location = New Point(280, 50)
        txtC.Name = "txtC"
        txtC.Size = New Size(85, 25)
        txtC.TabIndex = 5
        txtC.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblC
        ' 
        lblC.AutoSize = True
        lblC.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        lblC.Location = New Point(255, 53)
        lblC.Name = "lblC"
        lblC.Size = New Size(22, 19)
        lblC.TabIndex = 4
        lblC.Text = "C:"
        ' 
        ' txtB
        ' 
        txtB.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        txtB.Location = New Point(155, 50)
        txtB.Name = "txtB"
        txtB.Size = New Size(85, 25)
        txtB.TabIndex = 3
        txtB.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblB
        ' 
        lblB.AutoSize = True
        lblB.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        lblB.Location = New Point(130, 53)
        lblB.Name = "lblB"
        lblB.Size = New Size(22, 19)
        lblB.TabIndex = 2
        lblB.Text = "B:"
        ' 
        ' txtA
        ' 
        txtA.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        txtA.Location = New Point(33, 50)
        txtA.Name = "txtA"
        txtA.Size = New Size(85, 25)
        txtA.TabIndex = 1
        txtA.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblA
        ' 
        lblA.AutoSize = True
        lblA.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        lblA.Location = New Point(10, 53)
        lblA.Name = "lblA"
        lblA.Size = New Size(22, 19)
        lblA.TabIndex = 0
        lblA.Text = "A:"
        ' 
        ' btnCalcular
        ' 
        btnCalcular.BackColor = Color.FromArgb(37, 99, 235)
        btnCalcular.Cursor = Cursors.Hand
        btnCalcular.FlatStyle = FlatStyle.Flat
        btnCalcular.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point)
        btnCalcular.ForeColor = Color.White
        btnCalcular.Location = New Point(160, 245)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(164, 40)
        btnCalcular.TabIndex = 4
        btnCalcular.Text = "CALCULAR"
        btnCalcular.UseVisualStyleBackColor = False
        ' 
        ' grpResultados
        ' 
        grpResultados.Controls.Add(lblX2)
        grpResultados.Controls.Add(lblX2Titulo)
        grpResultados.Controls.Add(lblX1)
        grpResultados.Controls.Add(lblX1Titulo)
        grpResultados.Controls.Add(lblResultado)
        grpResultados.Controls.Add(lblTipoTitulo)
        grpResultados.Controls.Add(lblDiscriminante)
        grpResultados.Controls.Add(lblDiscTitulo)
        grpResultados.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        grpResultados.ForeColor = Color.FromArgb(30, 41, 59)
        grpResultados.Location = New Point(40, 295)
        grpResultados.Name = "grpResultados"
        grpResultados.Size = New Size(404, 185)
        grpResultados.TabIndex = 5
        grpResultados.TabStop = False
        grpResultados.Text = " Resultados "
        ' 
        ' lblX2
        ' 
        lblX2.BackColor = Color.White
        lblX2.BorderStyle = BorderStyle.FixedSingle
        lblX2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblX2.ForeColor = Color.FromArgb(15, 23, 42)
        lblX2.Location = New Point(140, 142)
        lblX2.Name = "lblX2"
        lblX2.Size = New Size(245, 26)
        lblX2.TabIndex = 7
        lblX2.Text = "-"
        lblX2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblX2Titulo
        ' 
        lblX2Titulo.AutoSize = True
        lblX2Titulo.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblX2Titulo.Location = New Point(18, 146)
        lblX2Titulo.Name = "lblX2Titulo"
        lblX2Titulo.Size = New Size(28, 17)
        lblX2Titulo.TabIndex = 6
        lblX2Titulo.Text = "X2:"
        ' 
        ' lblX1
        ' 
        lblX1.BackColor = Color.White
        lblX1.BorderStyle = BorderStyle.FixedSingle
        lblX1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblX1.ForeColor = Color.FromArgb(15, 23, 42)
        lblX1.Location = New Point(140, 106)
        lblX1.Name = "lblX1"
        lblX1.Size = New Size(245, 26)
        lblX1.TabIndex = 5
        lblX1.Text = "-"
        lblX1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblX1Titulo
        ' 
        lblX1Titulo.AutoSize = True
        lblX1Titulo.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblX1Titulo.Location = New Point(18, 110)
        lblX1Titulo.Name = "lblX1Titulo"
        lblX1Titulo.Size = New Size(28, 17)
        lblX1Titulo.TabIndex = 4
        lblX1Titulo.Text = "X1:"
        ' 
        ' lblResultado
        ' 
        lblResultado.BackColor = Color.White
        lblResultado.BorderStyle = BorderStyle.FixedSingle
        lblResultado.Font = New Font("Segoe UI", 9.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblResultado.ForeColor = Color.FromArgb(15, 23, 42)
        lblResultado.Location = New Point(140, 68)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(245, 28)
        lblResultado.TabIndex = 3
        lblResultado.Text = "-"
        lblResultado.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTipoTitulo
        ' 
        lblTipoTitulo.AutoSize = True
        lblTipoTitulo.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblTipoTitulo.Location = New Point(18, 73)
        lblTipoTitulo.Name = "lblTipoTitulo"
        lblTipoTitulo.Size = New Size(116, 17)
        lblTipoTitulo.TabIndex = 2
        lblTipoTitulo.Text = "Tipo de Solución:"
        ' 
        ' lblDiscriminante
        ' 
        lblDiscriminante.BackColor = Color.White
        lblDiscriminante.BorderStyle = BorderStyle.FixedSingle
        lblDiscriminante.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblDiscriminante.ForeColor = Color.FromArgb(15, 23, 42)
        lblDiscriminante.Location = New Point(140, 32)
        lblDiscriminante.Name = "lblDiscriminante"
        lblDiscriminante.Size = New Size(245, 26)
        lblDiscriminante.TabIndex = 1
        lblDiscriminante.Text = "-"
        lblDiscriminante.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDiscTitulo
        ' 
        lblDiscTitulo.AutoSize = True
        lblDiscTitulo.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblDiscTitulo.Location = New Point(18, 36)
        lblDiscTitulo.Name = "lblDiscTitulo"
        lblDiscTitulo.Size = New Size(99, 17)
        lblDiscTitulo.TabIndex = 0
        lblDiscTitulo.Text = "Discriminante:"
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = Color.FromArgb(71, 85, 105)
        btnLimpiar.Cursor = Cursors.Hand
        btnLimpiar.FlatStyle = FlatStyle.Flat
        btnLimpiar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnLimpiar.ForeColor = Color.White
        btnLimpiar.Location = New Point(90, 495)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(140, 36)
        btnLimpiar.TabIndex = 6
        btnLimpiar.Text = "LIMPIAR"
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.FromArgb(225, 29, 72)
        btnSalir.Cursor = Cursors.Hand
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnSalir.ForeColor = Color.White
        btnSalir.Location = New Point(254, 495)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(140, 36)
        btnSalir.TabIndex = 7
        btnSalir.Text = "SALIR"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(245, 247, 250)
        ClientSize = New Size(484, 551)
        Controls.Add(btnSalir)
        Controls.Add(btnLimpiar)
        Controls.Add(grpResultados)
        Controls.Add(btnCalcular)
        Controls.Add(grpDatos)
        Controls.Add(lblEcuacion)
        Controls.Add(lblSubtitulo)
        Controls.Add(lblTitulo)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LAB 2 - Ecuación Cuadrática"
        grpDatos.ResumeLayout(False)
        grpDatos.PerformLayout()
        grpResultados.ResumeLayout(False)
        grpResultados.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSubtitulo As Label
    Friend WithEvents lblEcuacion As Label
    Friend WithEvents grpDatos As GroupBox
    Friend WithEvents lblA As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents lblB As Label
    Friend WithEvents txtB As TextBox
    Friend WithEvents lblC As Label
    Friend WithEvents txtC As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents grpResultados As GroupBox
    Friend WithEvents lblDiscTitulo As Label
    Friend WithEvents lblDiscriminante As Label
    Friend WithEvents lblTipoTitulo As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents lblX1Titulo As Label
    Friend WithEvents lblX1 As Label
    Friend WithEvents lblX2Titulo As Label
    Friend WithEvents lblX2 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
End Class
