﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Plus = New System.Windows.Forms.Button()
        Me.Minus = New System.Windows.Forms.Button()
        Me.First = New System.Windows.Forms.TextBox()
        Me.Second = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.result = New System.Windows.Forms.TextBox()
        Me.Multiply = New System.Windows.Forms.Button()
        Me.Divide = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Plus
        '
        Me.Plus.Location = New System.Drawing.Point(125, 241)
        Me.Plus.Name = "Plus"
        Me.Plus.Size = New System.Drawing.Size(112, 34)
        Me.Plus.TabIndex = 0
        Me.Plus.Text = "+"
        Me.Plus.UseVisualStyleBackColor = True
        '
        'Minus
        '
        Me.Minus.Location = New System.Drawing.Point(125, 354)
        Me.Minus.Name = "Minus"
        Me.Minus.Size = New System.Drawing.Size(112, 34)
        Me.Minus.TabIndex = 1
        Me.Minus.Text = "-"
        Me.Minus.UseVisualStyleBackColor = True
        '
        'First
        '
        Me.First.Location = New System.Drawing.Point(106, 75)
        Me.First.Name = "First"
        Me.First.Size = New System.Drawing.Size(150, 31)
        Me.First.TabIndex = 2
        '
        'Second
        '
        Me.Second.Location = New System.Drawing.Point(340, 75)
        Me.Second.Name = "Second"
        Me.Second.Size = New System.Drawing.Size(150, 31)
        Me.Second.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(562, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "="
        '
        'result
        '
        Me.result.Location = New System.Drawing.Point(656, 75)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(150, 31)
        Me.result.TabIndex = 5
        '
        'Multiply
        '
        Me.Multiply.Location = New System.Drawing.Point(340, 241)
        Me.Multiply.Name = "Multiply"
        Me.Multiply.Size = New System.Drawing.Size(112, 34)
        Me.Multiply.TabIndex = 6
        Me.Multiply.Text = "*"
        Me.Multiply.UseVisualStyleBackColor = True
        '
        'Divide
        '
        Me.Divide.Location = New System.Drawing.Point(340, 354)
        Me.Divide.Name = "Divide"
        Me.Divide.Size = New System.Drawing.Size(112, 34)
        Me.Divide.TabIndex = 7
        Me.Divide.Text = "/"
        Me.Divide.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 477)
        Me.Controls.Add(Me.Divide)
        Me.Controls.Add(Me.Multiply)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Second)
        Me.Controls.Add(Me.First)
        Me.Controls.Add(Me.Minus)
        Me.Controls.Add(Me.Plus)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Plus As Button
    Friend WithEvents Minus As Button
    Friend WithEvents First As TextBox
    Friend WithEvents Second As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents result As TextBox
    Friend WithEvents Multiply As Button
    Friend WithEvents Divide As Button
End Class
