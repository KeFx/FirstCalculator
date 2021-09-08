<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Plus
        '
        Me.Plus.Location = New System.Drawing.Point(244, 333)
        Me.Plus.Name = "Plus"
        Me.Plus.Size = New System.Drawing.Size(39, 34)
        Me.Plus.TabIndex = 0
        Me.Plus.Text = "+"
        Me.Plus.UseVisualStyleBackColor = True
        '
        'Minus
        '
        Me.Minus.Location = New System.Drawing.Point(244, 402)
        Me.Minus.Name = "Minus"
        Me.Minus.Size = New System.Drawing.Size(39, 34)
        Me.Minus.TabIndex = 1
        Me.Minus.Text = "-"
        Me.Minus.UseVisualStyleBackColor = True
        '
        'First
        '
        Me.First.Location = New System.Drawing.Point(12, 141)
        Me.First.Name = "First"
        Me.First.Size = New System.Drawing.Size(150, 31)
        Me.First.TabIndex = 2
        '
        'Second
        '
        Me.Second.Location = New System.Drawing.Point(198, 141)
        Me.Second.Name = "Second"
        Me.Second.Size = New System.Drawing.Size(150, 31)
        Me.Second.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(384, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "="
        '
        'result
        '
        Me.result.Location = New System.Drawing.Point(439, 141)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(150, 31)
        Me.result.TabIndex = 5
        '
        'Multiply
        '
        Me.Multiply.Location = New System.Drawing.Point(319, 333)
        Me.Multiply.Name = "Multiply"
        Me.Multiply.Size = New System.Drawing.Size(39, 34)
        Me.Multiply.TabIndex = 6
        Me.Multiply.Text = "*"
        Me.Multiply.UseVisualStyleBackColor = True
        '
        'Divide
        '
        Me.Divide.Location = New System.Drawing.Point(319, 402)
        Me.Divide.Name = "Divide"
        Me.Divide.Size = New System.Drawing.Size(39, 34)
        Me.Divide.TabIndex = 7
        Me.Divide.Text = "/"
        Me.Divide.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "1st Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "2nd Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(439, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Output"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(244, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Operations:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 480)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
