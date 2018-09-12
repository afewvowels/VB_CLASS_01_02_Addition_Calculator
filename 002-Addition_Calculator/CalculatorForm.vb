Option Explicit On
Option Strict On

Public Class CalculatorForm

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        'Dim IntOne As Integer = FirstTextBox.Text
        'Dim IntTwo As Integer = SecondTextBox.Text
        'Dim IntSum As Integer = IntOne + IntTwo

        'SolutionLabel.Text = IntSum

        Dim ErrorString As String

        ' Try to cast textbox contents to integer values and add them,
        ' display error message to user if non-integer values are detected
        Try
            ' Single-line solutions
            ' Dim AnswerString As String = Convert.ToString(Convert.ToInt16(FirstTextBox.Text) + Convert.ToInt16(SecondTextBox.Text))
            ' Dim AnswerString As String = Convert.ToString(Integer.Parse(FirstTextBox.Text) + Integer.Parse(SecondTextBox.Text))

            ' Variable declarations
            Dim FirstInteger As Integer ' Represents the first value
            Dim SecondInteger As Integer ' Represents the second value
            Dim SumInteger As Integer ' Holds the sum of the two integer variables

            ' Parse variables
            FirstInteger = Integer.Parse(FirstTextBox.Text)

            Try
                SecondInteger = Integer.Parse(SecondTextBox.Text)

                ' Add two integers
                SumInteger = FirstInteger + SecondInteger

                SolutionLabel.Text = "The sum is " & SumInteger.ToString
                AnswerTextBox.Text = "The sum is " & SumInteger.ToString
            Catch ex As FormatException
                If SecondTextBox.Text Is String.Empty Then
                    ErrorString = "The second value was empty."
                Else
                    ErrorString = "The second value was a non-integer value."
                End If

                'SolutionLabel.Text = ErrorString
                'AnswerTextBox.Text = ErrorString

                MessageBox.Show(ErrorString,
                                "Data Entry Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
                SecondTextBox.Focus()
                SecondTextBox.SelectAll()
            End Try
        Catch ex As FormatException
            If FirstTextBox.Text Is String.Empty Then
                ErrorString = "The first value was empty."
            Else
                ErrorString = "The first value was a non-integer value."
            End If

            'SolutionLabel.Text = ErrorString
            'AnswerTextBox.Text = ErrorString
            MessageBox.Show(ErrorString,
                            "Data Entry Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

            FirstTextBox.Focus()
            FirstTextBox.SelectAll()
            ' Finally
            ' Regardless of success of operation, reset First and Second Text entry forms
            ' FirstTextBox.Text = ""
            ' SecondTextBox.Text = ""
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        FirstTextBox.Text = ""
        SecondTextBox.Text = ""
    End Sub
End Class
