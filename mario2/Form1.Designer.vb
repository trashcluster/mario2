<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonLeft = New System.Windows.Forms.Button()
        Me.ButtonDown = New System.Windows.Forms.Button()
        Me.ButtonRight = New System.Windows.Forms.Button()
        Me.ButtonUp = New System.Windows.Forms.Button()
        Me.ImageMario = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonLeft
        '
        Me.ButtonLeft.Location = New System.Drawing.Point(44, 61)
        Me.ButtonLeft.Name = "ButtonLeft"
        Me.ButtonLeft.Size = New System.Drawing.Size(30, 30)
        Me.ButtonLeft.TabIndex = 0
        Me.ButtonLeft.Text = "<"
        Me.ButtonLeft.UseVisualStyleBackColor = True
        '
        'ButtonDown
        '
        Me.ButtonDown.Location = New System.Drawing.Point(80, 61)
        Me.ButtonDown.Name = "ButtonDown"
        Me.ButtonDown.Size = New System.Drawing.Size(30, 30)
        Me.ButtonDown.TabIndex = 1
        Me.ButtonDown.Text = "v"
        Me.ButtonDown.UseVisualStyleBackColor = True
        '
        'ButtonRight
        '
        Me.ButtonRight.Location = New System.Drawing.Point(116, 61)
        Me.ButtonRight.Name = "ButtonRight"
        Me.ButtonRight.Size = New System.Drawing.Size(30, 30)
        Me.ButtonRight.TabIndex = 2
        Me.ButtonRight.Text = ">"
        Me.ButtonRight.UseVisualStyleBackColor = True
        '
        'ButtonUp
        '
        Me.ButtonUp.Location = New System.Drawing.Point(80, 25)
        Me.ButtonUp.Name = "ButtonUp"
        Me.ButtonUp.Size = New System.Drawing.Size(30, 30)
        Me.ButtonUp.TabIndex = 3
        Me.ButtonUp.Text = "^"
        Me.ButtonUp.UseVisualStyleBackColor = True
        '
        'ImageMario
        '
        Me.ImageMario.BackColor = System.Drawing.Color.Red
        Me.ImageMario.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ImageMario.Location = New System.Drawing.Point(182, 208)
        Me.ImageMario.Name = "ImageMario"
        Me.ImageMario.Size = New System.Drawing.Size(20, 20)
        Me.ImageMario.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 431)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Touches ZQSD pour bouger mario"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonUp)
        Me.GroupBox1.Controls.Add(Me.ButtonLeft)
        Me.GroupBox1.Controls.Add(Me.ButtonDown)
        Me.GroupBox1.Controls.Add(Me.ButtonRight)
        Me.GroupBox1.Location = New System.Drawing.Point(109, 332)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 96)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contrôles"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ImageMario)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonLeft As Button
    Friend WithEvents ButtonDown As Button
    Friend WithEvents ButtonRight As Button
    Friend WithEvents ButtonUp As Button
    Friend WithEvents ImageMario As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
