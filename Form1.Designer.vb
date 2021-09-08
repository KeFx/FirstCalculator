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
        Me.EqaulSign = New System.Windows.Forms.Label()
        Me.result = New System.Windows.Forms.TextBox()
        Me.Multiply = New System.Windows.Forms.Button()
        Me.Divide = New System.Windows.Forms.Button()
        Me.Num1Lbl = New System.Windows.Forms.Label()
        Me.Num2Lbl = New System.Windows.Forms.Label()
        Me.OutputLbl = New System.Windows.Forms.Label()
        Me.OperationsLbl = New System.Windows.Forms.Label()
        Me.errorForSecond = New System.Windows.Forms.Label()
        Me.errorForFirst = New System.Windows.Forms.Label()
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
        'EqaulSign
        '
        Me.EqaulSign.AutoSize = True
        Me.EqaulSign.Location = New System.Drawing.Point(384, 147)
        Me.EqaulSign.Name = "EqaulSign"
        Me.EqaulSign.Size = New System.Drawing.Size(24, 25)
        Me.EqaulSign.TabIndex = 4
        Me.EqaulSign.Text = "="
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
        'Num1Lbl
        '
        Me.Num1Lbl.AutoSize = True
        Me.Num1Lbl.Location = New System.Drawing.Point(12, 88)
        Me.Num1Lbl.Name = "Num1Lbl"
        Me.Num1Lbl.Size = New System.Drawing.Size(106, 25)
        Me.Num1Lbl.TabIndex = 8
        Me.Num1Lbl.Text = "1st Number"
        '
        'Num2Lbl
        '
        Me.Num2Lbl.AutoSize = True
        Me.Num2Lbl.Location = New System.Drawing.Point(198, 88)
        Me.Num2Lbl.Name = "Num2Lbl"
        Me.Num2Lbl.Size = New System.Drawing.Size(113, 25)
        Me.Num2Lbl.TabIndex = 9
        Me.Num2Lbl.Text = "2nd Number"
        '
        'OutputLbl
        '
        Me.OutputLbl.AutoSize = True
        Me.OutputLbl.Location = New System.Drawing.Point(439, 88)
        Me.OutputLbl.Name = "OutputLbl"
        Me.OutputLbl.Size = New System.Drawing.Size(69, 25)
        Me.OutputLbl.TabIndex = 10
        Me.OutputLbl.Text = "Output"
        '
        'OperationsLbl
        '
        Me.OperationsLbl.AutoSize = True
        Me.OperationsLbl.Location = New System.Drawing.Point(244, 278)
        Me.OperationsLbl.Name = "OperationsLbl"
        Me.OperationsLbl.Size = New System.Drawing.Size(104, 25)
        Me.OperationsLbl.TabIndex = 11
        Me.OperationsLbl.Text = "Operations:"
        '
        'errorForSecond
        '
        Me.errorForSecond.AutoSize = True
        Me.errorForSecond.ForeColor = System.Drawing.Color.Red
        Me.errorForSecond.Location = New System.Drawing.Point(198, 175)
        Me.errorForSecond.Name = "errorForSecond"
        Me.errorForSecond.Size = New System.Drawing.Size(12, 25)
        Me.errorForSecond.TabIndex = 12
        Me.errorForSecond.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'errorForFirst
        '
        Me.errorForFirst.AutoSize = True
        Me.errorForFirst.ForeColor = System.Drawing.Color.Red
        Me.errorForFirst.Location = New System.Drawing.Point(12, 175)
        Me.errorForFirst.Name = "errorForFirst"
        Me.errorForFirst.Size = New System.Drawing.Size(0, 25)
        Me.errorForFirst.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 480)
        Me.Controls.Add(Me.errorForFirst)
        Me.Controls.Add(Me.errorForSecond)
        Me.Controls.Add(Me.OperationsLbl)
        Me.Controls.Add(Me.OutputLbl)
        Me.Controls.Add(Me.Num2Lbl)
        Me.Controls.Add(Me.Num1Lbl)
        Me.Controls.Add(Me.Divide)
        Me.Controls.Add(Me.Multiply)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.EqaulSign)
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
    Friend WithEvents EqaulSign As Label
    Friend WithEvents result As TextBox
    Friend WithEvents Multiply As Button
    Friend WithEvents Divide As Button
    Friend WithEvents Num1Lbl As Label
    Friend WithEvents Num2Lbl As Label
    Friend WithEvents OutputLbl As Label
    Friend WithEvents OperationsLbl As Label
    Friend WithEvents errorForSecond As Label
    Friend WithEvents errorForFirst As Label
End Class
