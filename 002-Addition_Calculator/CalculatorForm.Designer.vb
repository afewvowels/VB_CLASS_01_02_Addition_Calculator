<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatorForm
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
        Me.FirstIntegerLabel = New System.Windows.Forms.Label()
        Me.SecondIntegerLabel = New System.Windows.Forms.Label()
        Me.FirstTextBox = New System.Windows.Forms.TextBox()
        Me.SecondTextBox = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.SolutionLabel = New System.Windows.Forms.Label()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FirstIntegerLabel
        '
        Me.FirstIntegerLabel.Location = New System.Drawing.Point(12, 9)
        Me.FirstIntegerLabel.Name = "FirstIntegerLabel"
        Me.FirstIntegerLabel.Size = New System.Drawing.Size(114, 23)
        Me.FirstIntegerLabel.TabIndex = 0
        Me.FirstIntegerLabel.Text = "First Integer:"
        '
        'SecondIntegerLabel
        '
        Me.SecondIntegerLabel.Location = New System.Drawing.Point(132, 9)
        Me.SecondIntegerLabel.Name = "SecondIntegerLabel"
        Me.SecondIntegerLabel.Size = New System.Drawing.Size(140, 23)
        Me.SecondIntegerLabel.TabIndex = 1
        Me.SecondIntegerLabel.Text = "Second Integer:"
        '
        'FirstTextBox
        '
        Me.FirstTextBox.Location = New System.Drawing.Point(13, 36)
        Me.FirstTextBox.Name = "FirstTextBox"
        Me.FirstTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstTextBox.TabIndex = 2
        '
        'SecondTextBox
        '
        Me.SecondTextBox.Location = New System.Drawing.Point(135, 35)
        Me.SecondTextBox.Name = "SecondTextBox"
        Me.SecondTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SecondTextBox.TabIndex = 3
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(15, 63)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(220, 23)
        Me.AddButton.TabIndex = 4
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'SolutionLabel
        '
        Me.SolutionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SolutionLabel.Location = New System.Drawing.Point(15, 128)
        Me.SolutionLabel.Name = "SolutionLabel"
        Me.SolutionLabel.Size = New System.Drawing.Size(222, 23)
        Me.SolutionLabel.TabIndex = 5
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.Location = New System.Drawing.Point(15, 155)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.ReadOnly = True
        Me.AnswerTextBox.Size = New System.Drawing.Size(222, 20)
        Me.AnswerTextBox.TabIndex = 6
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(15, 92)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(220, 23)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CalculatorForm
        '
        Me.AcceptButton = Me.AddButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(247, 187)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.AnswerTextBox)
        Me.Controls.Add(Me.SolutionLabel)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.SecondTextBox)
        Me.Controls.Add(Me.FirstTextBox)
        Me.Controls.Add(Me.SecondIntegerLabel)
        Me.Controls.Add(Me.FirstIntegerLabel)
        Me.Name = "CalculatorForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FirstIntegerLabel As System.Windows.Forms.Label
    Friend WithEvents SecondIntegerLabel As System.Windows.Forms.Label
    Friend WithEvents FirstTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SecondTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents SolutionLabel As System.Windows.Forms.Label
    Friend WithEvents AnswerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button

End Class
