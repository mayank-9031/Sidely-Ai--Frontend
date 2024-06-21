<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

'Form overrides dispose to clean up the component list.
<System.Diagnostics.DebuggerNonUserCode()>
Protected Overrides Sub Dispose(disposing As Boolean)
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
    Me.components = New System.ComponentModel.Container()
    Me.txtName = New System.Windows.Forms.TextBox()
    Me.txtEmail = New System.Windows.Forms.TextBox()
    Me.txtPhoneNum = New System.Windows.Forms.TextBox()
    Me.txtGithubLink = New System.Windows.Forms.TextBox()
    Me.lblStopwatchTime = New System.Windows.Forms.Label()
    Me.btnToggleStopwatch = New System.Windows.Forms.Button()
    Me.btnSubmit = New System.Windows.Forms.Button()
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.SuspendLayout()
    '
    'txtName
    '
    Me.txtName.Location = New System.Drawing.Point(30, 30)
    Me.txtName.Name = "txtName"
    Me.txtName.Size = New System.Drawing.Size(200, 20)
    Me.txtName.TabIndex = 0
    '
    'txtEmail
    '
    Me.txtEmail.Location = New System.Drawing.Point(30, 60)
    Me.txtEmail.Name = "txtEmail"
    Me.txtEmail.Size = New System.Drawing.Size(200, 20)
    Me.txtEmail.TabIndex = 1
    '
    'txtPhoneNum
    '
    Me.txtPhoneNum.Location = New System.Drawing.Point(30, 90)
    Me.txtPhoneNum.Name = "txtPhoneNum"
    Me.txtPhoneNum.Size = New System.Drawing.Size(200, 20)
    Me.txtPhoneNum.TabIndex = 2
    '
    'txtGithubLink
    '
    Me.txtGithubLink.Location = New System.Drawing.Point(30, 120)
    Me.txtGithubLink.Name = "txtGithubLink"
    Me.txtGithubLink.Size = New System.Drawing.Size(200, 20)
    Me.txtGithubLink.TabIndex = 3
    '
    'lblStopwatchTime
    '
    Me.lblStopwatchTime.AutoSize = True
    Me.lblStopwatchTime.Location = New System.Drawing.Point(30, 150)
    Me.lblStopwatchTime.Name = "lblStopwatchTime"
    Me.lblStopwatchTime.Size = New System.Drawing.Size(49, 13)
    Me.lblStopwatchTime.TabIndex = 4
    Me.lblStopwatchTime.Text = "00:00:00"
    '
    'btnToggleStopwatch
    '
    Me.btnToggleStopwatch.Location = New System.Drawing.Point(30, 180)
    Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
    Me.btnToggleStopwatch.Size = New System.Drawing.Size(75, 23)
    Me.btnToggleStopwatch.TabIndex = 5
    Me.btnToggleStopwatch.Text = "Toggle Stopwatch (Ctrl + T)"
    Me.btnToggleStopwatch.UseVisualStyleBackColor = True
    '
    'btnSubmit
    '
    Me.btnSubmit.Location = New System.Drawing.Point(155, 180)
    Me.btnSubmit.Name = "btnSubmit"
    Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
    Me.btnSubmit.TabIndex = 6
    Me.btnSubmit.Text = "Submit (Ctrl + S)"
    Me.btnSubmit.UseVisualStyleBackColor = True
    '
    'Timer1
    '
    Me.Timer1.Interval = 1000
    '
    'CreateSubmissionForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(284, 221)
    Me.Controls.Add(Me.btnSubmit)
    Me.Controls.Add(Me.btnToggleStopwatch)
    Me.Controls.Add(Me.lblStopwatchTime)
    Me.Controls.Add(Me.txtGithubLink)
    Me.Controls.Add(Me.txtPhoneNum)
    Me.Controls.Add(Me.txtEmail)
    Me.Controls.Add(Me.txtName)
    Me.Name = "CreateSubmissionForm"
    Me.Text = "Create Submission"
    Me.ResumeLayout(False)
    Me.PerformLayout()

End Sub

Friend WithEvents txtName As TextBox
Friend WithEvents txtEmail As TextBox
Friend WithEvents txtPhoneNum As TextBox
Friend WithEvents txtGithubLink As TextBox
Friend WithEvents lblStopwatchTime As Label
Friend WithEvents btnToggleStopwatch As Button
Friend WithEvents btnSubmit As Button
Friend WithEvents Timer1 As Timer
End Class
