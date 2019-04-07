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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTEuros = New System.Windows.Forms.TextBox()
        Me.TXT50 = New System.Windows.Forms.TextBox()
        Me.TXT20 = New System.Windows.Forms.TextBox()
        Me.TXT10 = New System.Windows.Forms.TextBox()
        Me.TXT1 = New System.Windows.Forms.TextBox()
        Me.TXT2 = New System.Windows.Forms.TextBox()
        Me.TXT5 = New System.Windows.Forms.TextBox()
        Me.Cambio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "50"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "20"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "10"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "1"
        '
        'TXTEuros
        '
        Me.TXTEuros.Location = New System.Drawing.Point(107, 47)
        Me.TXTEuros.Name = "TXTEuros"
        Me.TXTEuros.Size = New System.Drawing.Size(115, 20)
        Me.TXTEuros.TabIndex = 7
        '
        'TXT50
        '
        Me.TXT50.Location = New System.Drawing.Point(107, 93)
        Me.TXT50.Name = "TXT50"
        Me.TXT50.ReadOnly = True
        Me.TXT50.Size = New System.Drawing.Size(75, 20)
        Me.TXT50.TabIndex = 8
        '
        'TXT20
        '
        Me.TXT20.Location = New System.Drawing.Point(107, 135)
        Me.TXT20.Name = "TXT20"
        Me.TXT20.ReadOnly = True
        Me.TXT20.Size = New System.Drawing.Size(75, 20)
        Me.TXT20.TabIndex = 9
        '
        'TXT10
        '
        Me.TXT10.Location = New System.Drawing.Point(107, 173)
        Me.TXT10.Name = "TXT10"
        Me.TXT10.ReadOnly = True
        Me.TXT10.Size = New System.Drawing.Size(75, 20)
        Me.TXT10.TabIndex = 10
        '
        'TXT1
        '
        Me.TXT1.Location = New System.Drawing.Point(107, 276)
        Me.TXT1.Name = "TXT1"
        Me.TXT1.ReadOnly = True
        Me.TXT1.Size = New System.Drawing.Size(75, 20)
        Me.TXT1.TabIndex = 11
        '
        'TXT2
        '
        Me.TXT2.Location = New System.Drawing.Point(107, 239)
        Me.TXT2.Name = "TXT2"
        Me.TXT2.ReadOnly = True
        Me.TXT2.Size = New System.Drawing.Size(75, 20)
        Me.TXT2.TabIndex = 12
        '
        'TXT5
        '
        Me.TXT5.Location = New System.Drawing.Point(107, 206)
        Me.TXT5.Name = "TXT5"
        Me.TXT5.ReadOnly = True
        Me.TXT5.Size = New System.Drawing.Size(75, 20)
        Me.TXT5.TabIndex = 13
        '
        'Cambio
        '
        Me.Cambio.Location = New System.Drawing.Point(107, 327)
        Me.Cambio.Name = "Cambio"
        Me.Cambio.Size = New System.Drawing.Size(75, 23)
        Me.Cambio.TabIndex = 14
        Me.Cambio.Text = "BTNCambio"
        Me.Cambio.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 379)
        Me.Controls.Add(Me.Cambio)
        Me.Controls.Add(Me.TXT5)
        Me.Controls.Add(Me.TXT2)
        Me.Controls.Add(Me.TXT1)
        Me.Controls.Add(Me.TXT10)
        Me.Controls.Add(Me.TXT20)
        Me.Controls.Add(Me.TXT50)
        Me.Controls.Add(Me.TXTEuros)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TXTEuros As TextBox
    Friend WithEvents TXT50 As TextBox
    Friend WithEvents TXT20 As TextBox
    Friend WithEvents TXT10 As TextBox
    Friend WithEvents TXT1 As TextBox
    Friend WithEvents TXT2 As TextBox
    Friend WithEvents TXT5 As TextBox
    Friend WithEvents Cambio As Button
End Class
