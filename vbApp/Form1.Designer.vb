<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnStart = New Button()
        varLesson = New Button()
        Button1 = New Button()
        inputLesson = New Button()
        txtFirstName = New TextBox()
        Label1 = New Label()
        txtLastName = New TextBox()
        Label2 = New Label()
        txtGender = New TextBox()
        txtGenderLabel = New Label()
        btnGo = New Button()
        lsOccupation = New ListBox()
        Label3 = New Label()
        labelNumberOne = New Label()
        labelNumberTwo = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        btnCalc = New Button()
        SuspendLayout()
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = SystemColors.ActiveCaption
        btnStart.Location = New Point(627, 226)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(161, 67)
        btnStart.TabIndex = 0
        btnStart.Text = "Press Here"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' varLesson
        ' 
        varLesson.Location = New Point(606, 310)
        varLesson.Name = "varLesson"
        varLesson.RightToLeft = RightToLeft.Yes
        varLesson.Size = New Size(182, 56)
        varLesson.TabIndex = 1
        varLesson.Text = "Var Lesson"
        varLesson.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(650, 373)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 52)
        Button1.TabIndex = 2
        Button1.Text = "btnVarTypes"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' inputLesson
        ' 
        inputLesson.Location = New Point(533, 388)
        inputLesson.Name = "inputLesson"
        inputLesson.Size = New Size(75, 23)
        inputLesson.TabIndex = 3
        inputLesson.Text = "btnInput"
        inputLesson.UseVisualStyleBackColor = True
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(106, 12)
        txtFirstName.Multiline = True
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(276, 47)
        txtFirstName.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 5
        Label1.Text = "First Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(107, 85)
        txtLastName.Multiline = True
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(276, 47)
        txtLastName.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(35, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 5
        Label2.Text = "Last Name"
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(106, 164)
        txtGender.Multiline = True
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(276, 47)
        txtGender.TabIndex = 4
        ' 
        ' txtGenderLabel
        ' 
        txtGenderLabel.AutoSize = True
        txtGenderLabel.Location = New Point(34, 178)
        txtGenderLabel.Name = "txtGenderLabel"
        txtGenderLabel.Size = New Size(45, 15)
        txtGenderLabel.TabIndex = 5
        txtGenderLabel.Text = "Gender"
        ' 
        ' btnGo
        ' 
        btnGo.Location = New Point(553, 99)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(75, 44)
        btnGo.TabIndex = 3
        btnGo.Text = "GO"
        btnGo.UseVisualStyleBackColor = True
        ' 
        ' lsOccupation
        ' 
        lsOccupation.FormattingEnabled = True
        lsOccupation.ItemHeight = 15
        lsOccupation.Items.AddRange(New Object() {"Programmer", "Designer", "Engineer", "HR"})
        lsOccupation.Location = New Point(409, 41)
        lsOccupation.Name = "lsOccupation"
        lsOccupation.Size = New Size(120, 169)
        lsOccupation.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(409, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 15)
        Label3.TabIndex = 7
        Label3.Text = "Occupation"
        ' 
        ' labelNumberOne
        ' 
        labelNumberOne.AutoSize = True
        labelNumberOne.Location = New Point(116, 302)
        labelNumberOne.Name = "labelNumberOne"
        labelNumberOne.Size = New Size(60, 15)
        labelNumberOne.TabIndex = 8
        labelNumberOne.Text = "Number 1"
        ' 
        ' labelNumberTwo
        ' 
        labelNumberTwo.AutoSize = True
        labelNumberTwo.Location = New Point(116, 332)
        labelNumberTwo.Name = "labelNumberTwo"
        labelNumberTwo.Size = New Size(60, 15)
        labelNumberTwo.TabIndex = 9
        labelNumberTwo.Text = "Number 2"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(187, 298)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 10
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(187, 328)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 11
        ' 
        ' btnCalc
        ' 
        btnCalc.Location = New Point(308, 328)
        btnCalc.Name = "btnCalc"
        btnCalc.Size = New Size(75, 23)
        btnCalc.TabIndex = 12
        btnCalc.Text = "Calculate"
        btnCalc.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCalc)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(labelNumberTwo)
        Controls.Add(labelNumberOne)
        Controls.Add(Label3)
        Controls.Add(lsOccupation)
        Controls.Add(txtGenderLabel)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtGender)
        Controls.Add(txtLastName)
        Controls.Add(txtFirstName)
        Controls.Add(btnGo)
        Controls.Add(inputLesson)
        Controls.Add(Button1)
        Controls.Add(varLesson)
        Controls.Add(btnStart)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents varLesson As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents inputLesson As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtGenderLabel As Label
    Friend WithEvents btnGo As Button
    Friend WithEvents lsOccupation As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents labelNumberOne As Label
    Friend WithEvents labelNumberTwo As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnCalc As Button

End Class
