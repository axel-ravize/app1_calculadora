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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BotonMas = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BotonMenos = New System.Windows.Forms.Button()
        Me.BotonPor = New System.Windows.Forms.Button()
        Me.BotonEntre = New System.Windows.Forms.Button()
        Me.Boton0 = New System.Windows.Forms.Button()
        Me.Boton1 = New System.Windows.Forms.Button()
        Me.Boton2 = New System.Windows.Forms.Button()
        Me.Boton3 = New System.Windows.Forms.Button()
        Me.Boton4 = New System.Windows.Forms.Button()
        Me.Boton5 = New System.Windows.Forms.Button()
        Me.Boton6 = New System.Windows.Forms.Button()
        Me.Boton7 = New System.Windows.Forms.Button()
        Me.Boton9 = New System.Windows.Forms.Button()
        Me.Boton8 = New System.Windows.Forms.Button()
        Me.BotonBorrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número 1"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(226, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(163, 34)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "0"
        '
        'BotonMas
        '
        Me.BotonMas.Font = New System.Drawing.Font("Ebrima", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonMas.Location = New System.Drawing.Point(756, 25)
        Me.BotonMas.Name = "BotonMas"
        Me.BotonMas.Size = New System.Drawing.Size(59, 55)
        Me.BotonMas.TabIndex = 2
        Me.BotonMas.Text = "+"
        Me.BotonMas.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Número 2"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(226, 126)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(163, 34)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 32)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Resultado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria Math", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(255, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 134)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "0"
        '
        'BotonMenos
        '
        Me.BotonMenos.Font = New System.Drawing.Font("Ebrima", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonMenos.Location = New System.Drawing.Point(756, 99)
        Me.BotonMenos.Name = "BotonMenos"
        Me.BotonMenos.Size = New System.Drawing.Size(59, 55)
        Me.BotonMenos.TabIndex = 7
        Me.BotonMenos.Text = "-"
        Me.BotonMenos.UseVisualStyleBackColor = True
        '
        'BotonPor
        '
        Me.BotonPor.Font = New System.Drawing.Font("Ebrima", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonPor.Location = New System.Drawing.Point(756, 177)
        Me.BotonPor.Name = "BotonPor"
        Me.BotonPor.Size = New System.Drawing.Size(59, 54)
        Me.BotonPor.TabIndex = 8
        Me.BotonPor.Text = "x"
        Me.BotonPor.UseVisualStyleBackColor = True
        '
        'BotonEntre
        '
        Me.BotonEntre.Font = New System.Drawing.Font("Ebrima", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonEntre.Location = New System.Drawing.Point(756, 248)
        Me.BotonEntre.Name = "BotonEntre"
        Me.BotonEntre.Size = New System.Drawing.Size(59, 55)
        Me.BotonEntre.TabIndex = 9
        Me.BotonEntre.Text = "÷"
        Me.BotonEntre.UseVisualStyleBackColor = True
        '
        'Boton0
        '
        Me.Boton0.Font = New System.Drawing.Font("Ebrima", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton0.Location = New System.Drawing.Point(593, 248)
        Me.Boton0.Name = "Boton0"
        Me.Boton0.Size = New System.Drawing.Size(59, 55)
        Me.Boton0.TabIndex = 10
        Me.Boton0.Text = "0"
        Me.Boton0.UseVisualStyleBackColor = True
        '
        'Boton1
        '
        Me.Boton1.Font = New System.Drawing.Font("Ebrima", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton1.Location = New System.Drawing.Point(516, 177)
        Me.Boton1.Name = "Boton1"
        Me.Boton1.Size = New System.Drawing.Size(59, 55)
        Me.Boton1.TabIndex = 11
        Me.Boton1.Text = "1"
        Me.Boton1.UseVisualStyleBackColor = True
        '
        'Boton2
        '
        Me.Boton2.Font = New System.Drawing.Font("Ebrima", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton2.Location = New System.Drawing.Point(593, 177)
        Me.Boton2.Name = "Boton2"
        Me.Boton2.Size = New System.Drawing.Size(59, 55)
        Me.Boton2.TabIndex = 12
        Me.Boton2.Text = "2"
        Me.Boton2.UseVisualStyleBackColor = True
        '
        'Boton3
        '
        Me.Boton3.Font = New System.Drawing.Font("Ebrima", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton3.Location = New System.Drawing.Point(670, 177)
        Me.Boton3.Name = "Boton3"
        Me.Boton3.Size = New System.Drawing.Size(59, 55)
        Me.Boton3.TabIndex = 13
        Me.Boton3.Text = "3"
        Me.Boton3.UseVisualStyleBackColor = True
        '
        'Boton4
        '
        Me.Boton4.Font = New System.Drawing.Font("Ebrima", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton4.Location = New System.Drawing.Point(516, 99)
        Me.Boton4.Name = "Boton4"
        Me.Boton4.Size = New System.Drawing.Size(59, 55)
        Me.Boton4.TabIndex = 14
        Me.Boton4.Text = "4"
        Me.Boton4.UseVisualStyleBackColor = True
        '
        'Boton5
        '
        Me.Boton5.Font = New System.Drawing.Font("Ebrima", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton5.Location = New System.Drawing.Point(593, 99)
        Me.Boton5.Name = "Boton5"
        Me.Boton5.Size = New System.Drawing.Size(59, 55)
        Me.Boton5.TabIndex = 15
        Me.Boton5.Text = "5"
        Me.Boton5.UseVisualStyleBackColor = True
        '
        'Boton6
        '
        Me.Boton6.Font = New System.Drawing.Font("Ebrima", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton6.Location = New System.Drawing.Point(670, 99)
        Me.Boton6.Name = "Boton6"
        Me.Boton6.Size = New System.Drawing.Size(59, 55)
        Me.Boton6.TabIndex = 16
        Me.Boton6.Text = "6"
        Me.Boton6.UseVisualStyleBackColor = True
        '
        'Boton7
        '
        Me.Boton7.Font = New System.Drawing.Font("Ebrima", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton7.Location = New System.Drawing.Point(516, 25)
        Me.Boton7.Name = "Boton7"
        Me.Boton7.Size = New System.Drawing.Size(59, 55)
        Me.Boton7.TabIndex = 17
        Me.Boton7.Text = "7"
        Me.Boton7.UseVisualStyleBackColor = True
        '
        'Boton9
        '
        Me.Boton9.Font = New System.Drawing.Font("Ebrima", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton9.Location = New System.Drawing.Point(670, 25)
        Me.Boton9.Name = "Boton9"
        Me.Boton9.Size = New System.Drawing.Size(59, 55)
        Me.Boton9.TabIndex = 18
        Me.Boton9.Text = "9"
        Me.Boton9.UseVisualStyleBackColor = True
        '
        'Boton8
        '
        Me.Boton8.Font = New System.Drawing.Font("Ebrima", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton8.Location = New System.Drawing.Point(593, 25)
        Me.Boton8.Name = "Boton8"
        Me.Boton8.Size = New System.Drawing.Size(59, 55)
        Me.Boton8.TabIndex = 19
        Me.Boton8.Text = "8"
        Me.Boton8.UseVisualStyleBackColor = True
        '
        'BotonBorrar
        '
        Me.BotonBorrar.Font = New System.Drawing.Font("Ebrima", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonBorrar.Location = New System.Drawing.Point(670, 248)
        Me.BotonBorrar.Name = "BotonBorrar"
        Me.BotonBorrar.Size = New System.Drawing.Size(59, 55)
        Me.BotonBorrar.TabIndex = 20
        Me.BotonBorrar.Text = "C"
        Me.BotonBorrar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Ebrima", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(516, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 55)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(395, 50)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 22
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(395, 137)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 23
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(838, 359)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BotonBorrar)
        Me.Controls.Add(Me.Boton8)
        Me.Controls.Add(Me.Boton9)
        Me.Controls.Add(Me.Boton7)
        Me.Controls.Add(Me.Boton6)
        Me.Controls.Add(Me.Boton5)
        Me.Controls.Add(Me.Boton4)
        Me.Controls.Add(Me.Boton3)
        Me.Controls.Add(Me.Boton2)
        Me.Controls.Add(Me.Boton1)
        Me.Controls.Add(Me.Boton0)
        Me.Controls.Add(Me.BotonEntre)
        Me.Controls.Add(Me.BotonPor)
        Me.Controls.Add(Me.BotonMenos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BotonMas)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BotonMas As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BotonMenos As Button
    Friend WithEvents BotonPor As Button
    Friend WithEvents BotonEntre As Button
    Friend WithEvents Boton0 As Button
    Friend WithEvents Boton1 As Button
    Friend WithEvents Boton2 As Button
    Friend WithEvents Boton3 As Button
    Friend WithEvents Boton4 As Button
    Friend WithEvents Boton5 As Button
    Friend WithEvents Boton6 As Button
    Friend WithEvents Boton7 As Button
    Friend WithEvents Boton9 As Button
    Friend WithEvents Boton8 As Button
    Friend WithEvents BotonBorrar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
