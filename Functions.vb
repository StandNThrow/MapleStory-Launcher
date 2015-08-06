Imports Microsoft.Win32
Partial Public Class frmMain : Inherits Form

    Dim p() As Process

    Function PrevInstance() As Boolean
        If UBound(Diagnostics.Process.GetProcessesByName(Diagnostics.Process.GetCurrentProcess.ProcessName)) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub validateWindowed()
        'If Not Registry.GetValue(regProcessorArchitecturePath, regProcessorArchitecture, "").contains("64") Then
        If Registry.GetValue(regGameKey86, isWindowed, "") = 1 Or Registry.GetValue(regGameKey64, isWindowed, "") = 1 Then
            btnSetWindowed.Enabled = False
            btnSetFullScreen.Enabled = True
            With statusMode
                .Text = "Windowed Mode"
                .ForeColor = Color.Red
            End With
        Else
            btnSetWindowed.Enabled = True
            btnSetFullScreen.Enabled = False
        End If
        'End If
    End Sub

    Private Sub validateFullScreen()
        'If Not Registry.GetValue(regProcessorArchitecturePath, regProcessorArchitecture, "").contains("64") Then
        If Registry.GetValue(regGameKey86, isWindowed, "") = 0 Or _
            Registry.GetValue(regGameKey64, isWindowed, "") = 0 Then
            btnSetFullScreen.Enabled = False
            btnSetWindowed.Enabled = True
            With statusMode
                .Text = "Full Screen Mode"
                .ForeColor = Color.Green
            End With
        Else
            btnSetFullScreen.Enabled = True
            btnSetWindowed.Enabled = False
        End If
        'End If
    End Sub

    Private Sub validateResolution()
        '0 = 800 x 600
        '1 = 1024 x 768
        '2 = 1366 x 768
        Dim getResolution86 = Registry.GetValue(regGameKey86, resolutionMode, "")
        Dim getResolution64 = Registry.GetValue(regGameKey64, resolutionMode, "")

        If (getResolution86 Or getResolution64) = 0 Then
            radio800x600.Checked = True
        ElseIf (getResolution86 Or getResolution64) = 1 Then
            radio1024x768.Checked = True
        ElseIf (getResolution86 Or getResolution64) = 2 Then
            radio1366x768.Checked = True
        End If
    End Sub

    Private Sub CheckIfRunning()
        p = Process.GetProcessesByName(programName)
        If p.Count > 0 Then
            Threading.Thread.Sleep(3000)
            Application.Exit()
        Else
            Threading.Thread.Sleep(3000)
            MsgBox(programName + " did not launch.", MsgBoxStyle.Critical, "Error launching application!")
        End If
    End Sub
End Class