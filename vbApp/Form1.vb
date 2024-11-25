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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColor As String
        Dim bTaxed As Boolean
        Dim isEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDataRegistered As Date

        stMake = "Ola"
        stModel = "Escort"
        iDoors = 5
        stColor = "red"
        bTaxed = True
        isEngineSize = 1200
        decPrice = 999.99
        dtDataRegistered = #1/3/2000#

        'MsgBox To Desplay All These Data


        MsgBox(stMake & " " & stModel & " " & iDoors & " " & stColor & " " &
               bTaxed & " " & isEngineSize & " " & decPrice & " " & dtDataRegistered)

        'Print New Line
        MsgBox(stMake & vbNewLine & stModel & vbNewLine &
               iDoors & vbNewLine & stColor & vbNewLine & bTaxed & vbNewLine &
               isEngineSize & vbNewLine & decPrice & vbNewLine & dtDataRegistered)

    End Sub
End Class
