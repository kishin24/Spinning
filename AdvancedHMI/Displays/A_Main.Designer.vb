<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class A_Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_Main))
        Me.frmParentDataSubscriber = New AdvancedHMIControls.DataSubscriber(Me.components)
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.IntraloxLogo = New System.Windows.Forms.PictureBox()
        Me.btnMain8 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.btnsetup8 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.btnalarms8 = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.btnTools = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.btnABout = New MfgControl.AdvancedHMI.FormChangeButton()
        Me.BtnJogDrumExit = New AdvancedHMIControls.BasicButton()
        CType(Me.frmParentDataSubscriber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.IntraloxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frmParentDataSubscriber
        '
        Me.frmParentDataSubscriber.ComComponent = Me.EthernetIPforCLXCom1
        Me.frmParentDataSubscriber.PLCAddressValue = Nothing
        Me.frmParentDataSubscriber.Value = ""
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "172.16.30.55"
        Me.EthernetIPforCLXCom1.PollRateOverride = 500
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.IntraloxLogo)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnMain8)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnsetup8)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnalarms8)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnTools)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnABout)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnJogDrumExit)
        resources.ApplyResources(Me.FlowLayoutPanel1, "FlowLayoutPanel1")
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        '
        'IntraloxLogo
        '
        Me.IntraloxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IntraloxLogo.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.intralox
        resources.ApplyResources(Me.IntraloxLogo, "IntraloxLogo")
        Me.IntraloxLogo.Name = "IntraloxLogo"
        Me.IntraloxLogo.TabStop = False
        '
        'btnMain8
        '
        Me.btnMain8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMain8.ComComponent = Nothing
        resources.ApplyResources(Me.btnMain8, "btnMain8")
        Me.btnMain8.ForeColor = System.Drawing.Color.Black
        Me.btnMain8.FormToOpen = Nothing
        Me.btnMain8.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.home_icon
        Me.btnMain8.KeypadWidth = 300
        Me.btnMain8.Name = "btnMain8"
        Me.btnMain8.Passcode = Nothing
        Me.btnMain8.PasswordChar = False
        Me.btnMain8.PLCAddressVisible = ""
        Me.btnMain8.UseVisualStyleBackColor = False
        '
        'btnsetup8
        '
        Me.btnsetup8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnsetup8.ComComponent = Nothing
        resources.ApplyResources(Me.btnsetup8, "btnsetup8")
        Me.btnsetup8.ForeColor = System.Drawing.Color.Black
        Me.btnsetup8.FormToOpen = Nothing
        Me.btnsetup8.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.GearIcon_64x64
        Me.btnsetup8.KeypadWidth = 300
        Me.btnsetup8.Name = "btnsetup8"
        Me.btnsetup8.Passcode = Nothing
        Me.btnsetup8.PasswordChar = False
        Me.btnsetup8.PLCAddressVisible = ""
        Me.btnsetup8.UseVisualStyleBackColor = False
        '
        'btnalarms8
        '
        Me.btnalarms8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnalarms8.ComComponent = Nothing
        resources.ApplyResources(Me.btnalarms8, "btnalarms8")
        Me.btnalarms8.ForeColor = System.Drawing.Color.Black
        Me.btnalarms8.FormToOpen = Nothing
        Me.btnalarms8.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.alarm1
        Me.btnalarms8.KeypadWidth = 300
        Me.btnalarms8.Name = "btnalarms8"
        Me.btnalarms8.Passcode = Nothing
        Me.btnalarms8.PasswordChar = False
        Me.btnalarms8.PLCAddressVisible = ""
        Me.btnalarms8.UseVisualStyleBackColor = False
        '
        'btnTools
        '
        Me.btnTools.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTools.ComComponent = Nothing
        resources.ApplyResources(Me.btnTools, "btnTools")
        Me.btnTools.ForeColor = System.Drawing.Color.Black
        Me.btnTools.FormToOpen = Nothing
        Me.btnTools.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.WrenchIcon_64x64
        Me.btnTools.KeypadWidth = 300
        Me.btnTools.Name = "btnTools"
        Me.btnTools.Passcode = Nothing
        Me.btnTools.PasswordChar = False
        Me.btnTools.PLCAddressVisible = ""
        Me.btnTools.UseVisualStyleBackColor = False
        '
        'btnABout
        '
        Me.btnABout.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnABout.ComComponent = Nothing
        resources.ApplyResources(Me.btnABout, "btnABout")
        Me.btnABout.ForeColor = System.Drawing.Color.Black
        Me.btnABout.FormToOpen = Nothing
        Me.btnABout.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.intralox_l9x_1
        Me.btnABout.KeypadWidth = 300
        Me.btnABout.Name = "btnABout"
        Me.btnABout.Passcode = Nothing
        Me.btnABout.PasswordChar = False
        Me.btnABout.PLCAddressVisible = ""
        Me.btnABout.UseVisualStyleBackColor = False
        '
        'BtnJogDrumExit
        '
        resources.ApplyResources(Me.BtnJogDrumExit, "BtnJogDrumExit")
        Me.BtnJogDrumExit.BackColor = System.Drawing.Color.Black
        Me.BtnJogDrumExit.ComComponent = Me.EthernetIPforCLXCom1
        Me.BtnJogDrumExit.ForeColor = System.Drawing.Color.Black
        Me.BtnJogDrumExit.ForeColorAltername = System.Drawing.Color.Black
        Me.BtnJogDrumExit.Highlight = False
        Me.BtnJogDrumExit.HighlightColor = System.Drawing.Color.Green
        Me.BtnJogDrumExit.MaximumHoldTime = 3000
        Me.BtnJogDrumExit.MinimumHoldTime = 500
        Me.BtnJogDrumExit.Name = "BtnJogDrumExit"
        Me.BtnJogDrumExit.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BtnJogDrumExit.PLCAddressClick = ""
        Me.BtnJogDrumExit.SelectTextAlternate = False
        Me.BtnJogDrumExit.TextAlternate = Nothing
        Me.BtnJogDrumExit.UseVisualStyleBackColor = True
        Me.BtnJogDrumExit.ValueToWrite = 0
        '
        'A_Main
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.IsMdiContainer = True
        Me.Name = "A_Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.frmParentDataSubscriber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.IntraloxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents IntraloxLogo As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BtnAlarms As FormChangeImage
    Friend WithEvents BtnModes As FormChangeImage
    Friend WithEvents BtnSetup As FormChangeImage
    Friend WithEvents btnMain8 As FormChangeButton
    Friend WithEvents btnsetup8 As FormChangeButton
    Friend WithEvents btnalarms8 As FormChangeButton
    Friend WithEvents btnTools As FormChangeButton
    Friend WithEvents frmParentDataSubscriber As AdvancedHMIControls.DataSubscriber
    Friend WithEvents btnABout As FormChangeButton
    Friend WithEvents BtnJogDrumExit As AdvancedHMIControls.BasicButton
End Class
