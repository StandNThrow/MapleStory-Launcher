Imports Microsoft.Win32
Partial Public Class frmMain : Inherits Form

    Private Sub setWindowed86()
        My.Computer.Registry.SetValue(regGameKey86, isWindowed, 1, Microsoft.Win32.RegistryValueKind.DWord)
    End Sub

    Private Sub setFullScreen86()
        My.Computer.Registry.SetValue(regGameKey86, isWindowed, 0, Microsoft.Win32.RegistryValueKind.DWord)
    End Sub

    Private Sub setResolution86()
        If radio800x600.Checked = True Then
            Console.WriteLine("0")
            Registry.SetValue(regGameKey86, resolutionMode, 0)
        ElseIf radio1024x768.Checked = True Then
            Console.WriteLine("1")
            Registry.SetValue(regGameKey86, resolutionMode, 1)
        ElseIf radio1366x768.Checked = True Then
            Console.WriteLine("2")
            Registry.SetValue(regGameKey86, resolutionMode, 2)
        End If
    End Sub
End Class