Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_TailoredExperiences.Click
        Shell("reg add HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Privacy /v TailoredExperiencesWithDiagnosticDataEnabled /t REG_DWORD /d 0")
    End Sub

    Private Sub btn_ActionCenter_Click(sender As Object, e As EventArgs) Handles btn_ActionCenter.Click
        Shell("reg add HKCU\SOFTWARE\Policies\Microsoft\Windows\Explorer /v DisableActionCenter /t REG_DWORD /d 1")
    End Sub

    Private Sub btn_SearchBoxSuggestions_Click(sender As Object, e As EventArgs) Handles btn_SearchBoxSuggestions.Click
        Shell("reg add HKCU\SOFTWARE\Policies\Microsoft\Windows\Explorer /v DisableSearchBoxSuggestions /t REG_DWORD /d 1")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_reboot.Click
        Shell("shutdown.exe -r -t 0")
    End Sub

    Private Sub btn_LogOff_Click(sender As Object, e As EventArgs) Handles btn_LogOff.Click
        Shell("shutdown -l -t 0")
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btn_WindowsInk.Click
        Shell("reg add HKLM\SOFTWARE\Policies\Microsoft\WindowsInkWorkspace /v AllowWindowsInkWorkspace /t REG_DWORD /d 0")
    End Sub
End Class
