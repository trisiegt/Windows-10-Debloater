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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_TailoredExperiences = New System.Windows.Forms.Button()
        Me.btn_ActionCenter = New System.Windows.Forms.Button()
        Me.btn_SearchBoxSuggestions = New System.Windows.Forms.Button()
        Me.btn_reboot = New System.Windows.Forms.Button()
        Me.btn_LogOff = New System.Windows.Forms.Button()
        Me.btn_WindowsInk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Windows 10 Debloater"
        '
        'btn_TailoredExperiences
        '
        Me.btn_TailoredExperiences.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_TailoredExperiences.Location = New System.Drawing.Point(12, 93)
        Me.btn_TailoredExperiences.Name = "btn_TailoredExperiences"
        Me.btn_TailoredExperiences.Size = New System.Drawing.Size(170, 35)
        Me.btn_TailoredExperiences.TabIndex = 1
        Me.btn_TailoredExperiences.Text = "Disable tailored experiences"
        Me.btn_TailoredExperiences.UseVisualStyleBackColor = True
        '
        'btn_ActionCenter
        '
        Me.btn_ActionCenter.BackColor = System.Drawing.SystemColors.Control
        Me.btn_ActionCenter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_ActionCenter.Location = New System.Drawing.Point(248, 93)
        Me.btn_ActionCenter.Name = "btn_ActionCenter"
        Me.btn_ActionCenter.Size = New System.Drawing.Size(139, 35)
        Me.btn_ActionCenter.TabIndex = 2
        Me.btn_ActionCenter.Text = "Disable Action Center"
        Me.btn_ActionCenter.UseVisualStyleBackColor = False
        '
        'btn_SearchBoxSuggestions
        '
        Me.btn_SearchBoxSuggestions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_SearchBoxSuggestions.Location = New System.Drawing.Point(12, 157)
        Me.btn_SearchBoxSuggestions.Name = "btn_SearchBoxSuggestions"
        Me.btn_SearchBoxSuggestions.Size = New System.Drawing.Size(170, 43)
        Me.btn_SearchBoxSuggestions.TabIndex = 3
        Me.btn_SearchBoxSuggestions.Text = "Disable search box suggestions"
        Me.btn_SearchBoxSuggestions.UseVisualStyleBackColor = True
        '
        'btn_reboot
        '
        Me.btn_reboot.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_reboot.Location = New System.Drawing.Point(15, 563)
        Me.btn_reboot.Name = "btn_reboot"
        Me.btn_reboot.Size = New System.Drawing.Size(75, 23)
        Me.btn_reboot.TabIndex = 4
        Me.btn_reboot.Text = "Restart"
        Me.btn_reboot.UseVisualStyleBackColor = True
        '
        'btn_LogOff
        '
        Me.btn_LogOff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_LogOff.Location = New System.Drawing.Point(382, 561)
        Me.btn_LogOff.Name = "btn_LogOff"
        Me.btn_LogOff.Size = New System.Drawing.Size(79, 26)
        Me.btn_LogOff.TabIndex = 5
        Me.btn_LogOff.Text = "Log out"
        Me.btn_LogOff.UseVisualStyleBackColor = True
        '
        'btn_WindowsInk
        '
        Me.btn_WindowsInk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_WindowsInk.Location = New System.Drawing.Point(248, 157)
        Me.btn_WindowsInk.Name = "btn_WindowsInk"
        Me.btn_WindowsInk.Size = New System.Drawing.Size(153, 43)
        Me.btn_WindowsInk.TabIndex = 6
        Me.btn_WindowsInk.Text = "Disable Pen menu (Windows Ink Workspace)"
        Me.btn_WindowsInk.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(505, 600)
        Me.Controls.Add(Me.btn_WindowsInk)
        Me.Controls.Add(Me.btn_LogOff)
        Me.Controls.Add(Me.btn_reboot)
        Me.Controls.Add(Me.btn_SearchBoxSuggestions)
        Me.Controls.Add(Me.btn_ActionCenter)
        Me.Controls.Add(Me.btn_TailoredExperiences)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Name = "Form1"
        Me.Text = "Windows 10 Debloater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_TailoredExperiences As Button
    Friend WithEvents btn_ActionCenter As Button
    Friend WithEvents btn_SearchBoxSuggestions As Button
    Friend WithEvents btn_reboot As Button
    Friend WithEvents btn_LogOff As Button
    Friend WithEvents btn_WindowsInk As Button
End Class
