Imports Microsoft.Win32
Public Class frmMain

    Dim programName As String = "Maplestory"
    Dim programFileName As String = "\Maplestory.exe"
    Dim programShortcutPath As String = "\Microsoft\Windows\Start Menu\Programs\Wizet\MapleStorySEA\MapleStorySEA.lnk"
    Dim regPath As String = "ExecPath"
    Dim getPath As String
    Dim regKey64 As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\WIZET\Maplestory"
    Dim regKey86 As String = "HKEY_LOCAL_MACHINE\SOFTWARE\WIZET\Maplestory"
    Dim regProcessorArchitecturePath As String = "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment"
    Dim regProcessorArchitecture As String = "PROCESSOR_ARCHITECTURE"
    Dim regGameKey64 As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\WIZET\Maplestory"
    Dim newGameKey64 As String = "SOFTWARE\Wow6432Node\WIZET\Maplestory"
    Dim isWindowed As String = "soScreenMode"
    Dim resolutionMode As String = "soResolutionMode"
    Dim regGameKey86 As String = "HKEY_LOCAL_MACHINE\SOFTWARE\WIZET\Maplestory"
    Dim newGameKey86 As String = "SOFTWARE\WIZET\Maplestory"
    'Dim regValue86 As String = "soScreenMode"

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If PrevInstance() = True Then
            MsgBox(Me.Text + " is running.", MsgBoxStyle.Exclamation, "Running")
            Application.Exit()
        End If

        If Registry.LocalMachine.OpenSubKey(newGameKey64) Is Nothing _
            Or Registry.LocalMachine.OpenSubKey(newGameKey86) Is Nothing Then
            With statusMode
                .Text = "Maplestory is not found."
                .ForeColor = Color.Red
            End With
            MsgBox("Maplestory is not found on your computer.", MsgBoxStyle.Critical, "Error")
            grpScreenResolution.Enabled = False
            btnSetWindowed.Enabled = False
            btnSetFullScreen.Enabled = False
            btnLaunch.Enabled = False
        Else
            If Not Registry.GetValue(regProcessorArchitecturePath, regProcessorArchitecture, "").contains("86") Then
                getPath = Registry.GetValue(regKey64, regPath, "")
                Call validateWindowed()
                Call validateFullScreen()
                Call validateResolution()
            Else
                getPath = Registry.GetValue(regKey86, regPath, "")
                Call validateWindowed()
                Call validateFullScreen()
                Call validateResolution()
            End If
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLaunch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaunch.Click
        Call startProcess()
    End Sub

    Private Sub btnSetWindowed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetWindowed.Click
        If Not Registry.GetValue(regProcessorArchitecturePath, regProcessorArchitecture, "").contains("86") Then
            Call setWindowed64()
            btnSetWindowed.Enabled = False
            btnSetFullScreen.Enabled = True
            With statusMode
                .Text = "Windowed Mode"
                .ForeColor = Color.Red
            End With
            Call queryLaunch()
        Else
            Call setWindowed86()
            btnSetWindowed.Enabled = False
            btnSetFullScreen.Enabled = True
            With statusMode
                .Text = "Windowed Mode"
                .ForeColor = Color.Red
            End With
            Call queryLaunch()
        End If
    End Sub

    Private Sub btnSetFullScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetFullScreen.Click
        If Not Registry.GetValue(regProcessorArchitecturePath, regProcessorArchitecture, "").contains("86") Then
            Call setFullScreen64()
            btnSetWindowed.Enabled = True
            btnSetFullScreen.Enabled = False
            With statusMode
                .Text = "Full Screen Mode"
                .ForeColor = Color.Green
            End With
            Call queryLaunch()
        Else
            Call setFullScreen86()
            btnSetWindowed.Enabled = True
            btnSetFullScreen.Enabled = False
            With statusMode
                .Text = "Full Screen Mode"
                .ForeColor = Color.Green
            End With
            Call queryLaunch()
        End If
    End Sub

    Private Sub startProcess()
        Try
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + programShortcutPath)
            Call CheckIfRunning()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        statusMode.Text = "Launching Maplestory..."
    End Sub

    Private Sub queryLaunch()
        Select Case MsgBox("Do you want to start Maplestory now?", vbQuestion + vbYesNo, "Do you want to start " + programName + "?")
            Case vbYes
                Call startProcess()
            Case vbNo
                'MsgBox("Application will now exit.", MsgBoxStyle.Information, "Exit Application!")
                'Application.Exit()
        End Select
    End Sub

    Private Sub radioResolutions_Click(sender As Object, e As EventArgs) Handles radio800x600.Click,
        radio1024x768.Click,
        radio1366x768.Click
        If Not Registry.GetValue(regProcessorArchitecturePath, regProcessorArchitecture, "").contains("86") Then
            Call setResolution64()
        Else
            Call setResolution86()
        End If
    End Sub
End Class
