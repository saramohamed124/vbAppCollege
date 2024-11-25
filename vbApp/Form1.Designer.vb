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
        SuspendLayout()
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = SystemColors.ActiveCaption
        btnStart.Location = New Point(118, 66)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(161, 67)
        btnStart.TabIndex = 0
        btnStart.Text = "Press Here"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' varLesson
        ' 
        varLesson.Location = New Point(400, 71)
        varLesson.Name = "varLesson"
        varLesson.RightToLeft = RightToLeft.Yes
        varLesson.Size = New Size(182, 56)
        varLesson.TabIndex = 1
        varLesson.Text = "Var Lesson"
        varLesson.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(309, 224)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 52)
        Button1.TabIndex = 2
        Button1.Text = "btnVarTypes"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(varLesson)
        Controls.Add(btnStart)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents varLesson As Button
    Friend WithEvents Button1 As Button

End Class
