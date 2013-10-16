Option Strict On

Public Class Form1

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        ' Read the input from the user
        Dim st As String
        st = InputBox("Please type the initial string")

        ' Compute the 

        Dim result As String = ""
        Dim i As Integer = 0

        For i = st.Length - 1 To 0 Step -1 'st.length-1 how we get the last char in the string because it is 0 based counting'
            Dim c As Char
            c = st.Chars(i)

            result = result & c

        Next
        MessageBox.Show(result)



        ' Report the output to the user
        MessageBox.Show("Not implemented yet", "Result")

    End Sub
End Class
