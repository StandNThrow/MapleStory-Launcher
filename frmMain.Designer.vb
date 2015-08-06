<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.groupSelection = New System.Windows.Forms.GroupBox()
        Me.btnSetFullScreen = New System.Windows.Forms.Button()
        Me.btnSetWindowed = New System.Windows.Forms.Button()
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.statusBar = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusMode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusResolution = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grpScreenResolution = New System.Windows.Forms.GroupBox()
        Me.radio1366x768 = New System.Windows.Forms.RadioButton()
        Me.radio1024x768 = New System.Windows.Forms.RadioButton()
        Me.radio800x600 = New System.Windows.Forms.RadioButton()
        Me.groupSelection.SuspendLayout()
        Me.statusBar.SuspendLayout()
        Me.grpScreenResolution.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 246)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(306, 46)
        Me.btnExit.TabIndex = 0
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'groupSelection
        '
        Me.groupSelection.Controls.Add(Me.btnSetFullScreen)
        Me.groupSelection.Controls.Add(Me.btnSetWindowed)
        Me.groupSelection.Location = New System.Drawing.Point(12, 12)
        Me.groupSelection.Name = "groupSelection"
        Me.groupSelection.Size = New System.Drawing.Size(306, 125)
        Me.groupSelection.TabIndex = 0
        Me.groupSelection.TabStop = False
        Me.groupSelection.Text = "Selection"
        '
        'btnSetFullScreen
        '
        Me.btnSetFullScreen.Location = New System.Drawing.Point(6, 74)
        Me.btnSetFullScreen.Name = "btnSetFullScreen"
        Me.btnSetFullScreen.Size = New System.Drawing.Size(292, 46)
        Me.btnSetFullScreen.TabIndex = 0
        Me.btnSetFullScreen.TabStop = False
        Me.btnSetFullScreen.Text = "Set Full Screen Mode"
        Me.btnSetFullScreen.UseVisualStyleBackColor = True
        '
        'btnSetWindowed
        '
        Me.btnSetWindowed.Location = New System.Drawing.Point(6, 22)
        Me.btnSetWindowed.Name = "btnSetWindowed"
        Me.btnSetWindowed.Size = New System.Drawing.Size(294, 46)
        Me.btnSetWindowed.TabIndex = 0
        Me.btnSetWindowed.TabStop = False
        Me.btnSetWindowed.Text = "Set Windowed Mode"
        Me.btnSetWindowed.UseVisualStyleBackColor = True
        '
        'btnLaunch
        '
        Me.btnLaunch.Location = New System.Drawing.Point(12, 194)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(306, 46)
        Me.btnLaunch.TabIndex = 0
        Me.btnLaunch.TabStop = False
        Me.btnLaunch.Text = "Launch Maplestory"
        Me.btnLaunch.UseVisualStyleBackColor = True
        '
        'statusBar
        '
        Me.statusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus, Me.statusMode, Me.statusResolution})
        Me.statusBar.Location = New System.Drawing.Point(0, 296)
        Me.statusBar.Name = "statusBar"
        Me.statusBar.Size = New System.Drawing.Size(330, 22)
        Me.statusBar.TabIndex = 1
        Me.statusBar.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(45, 17)
        Me.lblStatus.Text = "Status: "
        '
        'statusMode
        '
        Me.statusMode.Name = "statusMode"
        Me.statusMode.Size = New System.Drawing.Size(22, 17)
        Me.statusMode.Text = "     "
        '
        'statusResolution
        '
        Me.statusResolution.Name = "statusResolution"
        Me.statusResolution.Size = New System.Drawing.Size(22, 17)
        Me.statusResolution.Text = "     "
        '
        'grpScreenResolution
        '
        Me.grpScreenResolution.Controls.Add(Me.radio1366x768)
        Me.grpScreenResolution.Controls.Add(Me.radio1024x768)
        Me.grpScreenResolution.Controls.Add(Me.radio800x600)
        Me.grpScreenResolution.Location = New System.Drawing.Point(12, 143)
        Me.grpScreenResolution.Name = "grpScreenResolution"
        Me.grpScreenResolution.Size = New System.Drawing.Size(306, 45)
        Me.grpScreenResolution.TabIndex = 0
        Me.grpScreenResolution.TabStop = False
        Me.grpScreenResolution.Text = "Screen Resolution"
        '
        'radio1366x768
        '
        Me.radio1366x768.AutoSize = True
        Me.radio1366x768.Location = New System.Drawing.Point(202, 19)
        Me.radio1366x768.Name = "radio1366x768"
        Me.radio1366x768.Size = New System.Drawing.Size(96, 20)
        Me.radio1366x768.TabIndex = 0
        Me.radio1366x768.Text = "1366 x 768"
        Me.radio1366x768.UseVisualStyleBackColor = True
        '
        'radio1024x768
        '
        Me.radio1024x768.AutoSize = True
        Me.radio1024x768.Location = New System.Drawing.Point(100, 19)
        Me.radio1024x768.Name = "radio1024x768"
        Me.radio1024x768.Size = New System.Drawing.Size(96, 20)
        Me.radio1024x768.TabIndex = 0
        Me.radio1024x768.Text = "1024 x 768"
        Me.radio1024x768.UseVisualStyleBackColor = True
        '
        'radio800x600
        '
        Me.radio800x600.AutoSize = True
        Me.radio800x600.Location = New System.Drawing.Point(6, 19)
        Me.radio800x600.Name = "radio800x600"
        Me.radio800x600.Size = New System.Drawing.Size(88, 20)
        Me.radio800x600.TabIndex = 0
        Me.radio800x600.Text = "800 x 600"
        Me.radio800x600.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 318)
        Me.Controls.Add(Me.grpScreenResolution)
        Me.Controls.Add(Me.statusBar)
        Me.Controls.Add(Me.groupSelection)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLaunch)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maplestory Launcher"
        Me.groupSelection.ResumeLayout(False)
        Me.statusBar.ResumeLayout(False)
        Me.statusBar.PerformLayout()
        Me.grpScreenResolution.ResumeLayout(False)
        Me.grpScreenResolution.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents groupSelection As System.Windows.Forms.GroupBox
    Friend WithEvents btnSetFullScreen As System.Windows.Forms.Button
    Friend WithEvents btnSetWindowed As System.Windows.Forms.Button
    Friend WithEvents btnLaunch As System.Windows.Forms.Button
    Friend WithEvents statusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusMode As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents grpScreenResolution As System.Windows.Forms.GroupBox
    Friend WithEvents radio1024x768 As System.Windows.Forms.RadioButton
    Friend WithEvents radio800x600 As System.Windows.Forms.RadioButton
    Friend WithEvents statusResolution As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents radio1366x768 As System.Windows.Forms.RadioButton

End Class
