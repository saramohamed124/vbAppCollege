Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        MsgBox("Hello World!")
        MsgBox("Hello World!2")
        MsgBox("Hack@")

    End Sub

    Private Sub varLesson_Click(sender As Object, e As EventArgs) Handles varLesson.Click
        Dim stFirstName As String ' 1 byte in memory
        'Dim stLastName As String ' 1 byte in memory
        stFirstName = "Sara"

        'Declare Variable String
        Dim stLastName As String ' 1 byte in memory
        stLastName = " Mohammed!"
        MessageBox.Show(stFirstName)
        MessageBox.Show("Hello" & stFirstName & stLastName & "I hope good time for you")
        'Content of Variable can be changed when Program Running
        stFirstName = "Fatma"
        stLastName = " Samir"
        MessageBox.Show("Hello" & stFirstName & stLastName & "I hope good time for you")

    End Sub
End Class
