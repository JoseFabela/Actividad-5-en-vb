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
        Me.txtNumeros = New System.Windows.Forms.TextBox()
        Me.btnIdentificar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNumeros
        '
        Me.txtNumeros.Location = New System.Drawing.Point(326, 112)
        Me.txtNumeros.Name = "txtNumeros"
        Me.txtNumeros.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeros.TabIndex = 0
        '
        'btnIdentificar
        '
        Me.btnIdentificar.Location = New System.Drawing.Point(153, 66)
        Me.btnIdentificar.Name = "btnIdentificar"
        Me.btnIdentificar.Size = New System.Drawing.Size(75, 23)
        Me.btnIdentificar.TabIndex = 1
        Me.btnIdentificar.Text = "Button1"
        Me.btnIdentificar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnIdentificar)
        Me.Controls.Add(Me.txtNumeros)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumeros As TextBox
    Friend WithEvents btnIdentificar As Button
End Class
