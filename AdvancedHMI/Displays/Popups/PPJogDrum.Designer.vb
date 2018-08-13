<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PPJogDrum
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PPJogDrum))
        Me.Motor1 = New AdvancedHMIControls.Motor()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.LblJogDrum = New System.Windows.Forms.Label()
        Me.MBJogDrum = New AdvancedHMIControls.MomentaryButton()
        Me.LblMainSpeedMan = New AdvancedHMIControls.BasicLabel()
        Me.BtnJogDrumExit = New AdvancedHMIControls.BasicButton()
        Me.BasicLabel1 = New AdvancedHMIControls.BasicLabel()
        Me.BtnJogDirection = New AdvancedHMIControls.BasicButton()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Motor1
        '
        Me.Motor1.ComComponent = Me.EthernetIPforCLXCom1
        Me.Motor1.LightColor = MfgControl.AdvancedHMI.Controls.Motor.LightColors.Green
        Me.Motor1.Location = New System.Drawing.Point(12, 116)
        Me.Motor1.Name = "Motor1"
        Me.Motor1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.Motor1.PLCAddressClick = ""
        Me.Motor1.PLCAddressText = ""
        Me.Motor1.PLCAddressValue = "Spiral_Drum.VFD_Feedback_Active"
        Me.Motor1.PLCAddressVisible = ""
        Me.Motor1.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.Motor1.Size = New System.Drawing.Size(230, 156)
        Me.Motor1.TabIndex = 9
        Me.Motor1.Value = False
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
        'LblJogDrum
        '
        Me.LblJogDrum.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblJogDrum.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJogDrum.Location = New System.Drawing.Point(0, 0)
        Me.LblJogDrum.Name = "LblJogDrum"
        Me.LblJogDrum.Size = New System.Drawing.Size(800, 43)
        Me.LblJogDrum.TabIndex = 10
        Me.LblJogDrum.Text = "JOG DRUM"
        Me.LblJogDrum.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MBJogDrum
        '
        Me.MBJogDrum.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Green
        Me.MBJogDrum.ComComponent = Me.EthernetIPforCLXCom1
        Me.MBJogDrum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MBJogDrum.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Small
        Me.MBJogDrum.Location = New System.Drawing.Point(277, 137)
        Me.MBJogDrum.MaximumHoldTime = 10000
        Me.MBJogDrum.MinimumHoldTime = 100
        Me.MBJogDrum.Name = "MBJogDrum"
        Me.MBJogDrum.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet
        Me.MBJogDrum.PLCAddressClick = "HMI_Jog_Drum"
        Me.MBJogDrum.PLCAddressVisible = ""
        Me.MBJogDrum.Size = New System.Drawing.Size(133, 140)
        Me.MBJogDrum.TabIndex = 11
        Me.MBJogDrum.Text = "JOG"
        '
        'LblMainSpeedMan
        '
        Me.LblMainSpeedMan.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblMainSpeedMan.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.LblMainSpeedMan.ComComponent = Me.EthernetIPforCLXCom1
        Me.LblMainSpeedMan.DisplayAsTime = False
        Me.LblMainSpeedMan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMainSpeedMan.ForeColor = System.Drawing.Color.White
        Me.LblMainSpeedMan.Highlight = False
        Me.LblMainSpeedMan.HighlightColor = System.Drawing.Color.Green
        Me.LblMainSpeedMan.HighlightForeColor = System.Drawing.Color.White
        Me.LblMainSpeedMan.HighlightKeyCharacter = "!"
        Me.LblMainSpeedMan.InterpretValueAsBCD = False
        Me.LblMainSpeedMan.KeypadAlphaNumeric = False
        Me.LblMainSpeedMan.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.LblMainSpeedMan.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.LblMainSpeedMan.KeypadMaxValue = 80.0R
        Me.LblMainSpeedMan.KeypadMinValue = 0R
        Me.LblMainSpeedMan.KeypadScaleFactor = 1.0R
        Me.LblMainSpeedMan.KeypadShowCurrentValue = False
        Me.LblMainSpeedMan.KeypadText = Nothing
        Me.LblMainSpeedMan.KeypadWidth = 300
        Me.LblMainSpeedMan.Location = New System.Drawing.Point(35, 275)
        Me.LblMainSpeedMan.Name = "LblMainSpeedMan"
        Me.LblMainSpeedMan.NumericFormat = "F"
        Me.LblMainSpeedMan.PLCAddressKeypad = "HMI_Drum_Output_Frequency"
        Me.LblMainSpeedMan.PLCAddressValue = "HMI_Drum_Output_Frequency"
        Me.LblMainSpeedMan.PollRate = 0
        Me.LblMainSpeedMan.Size = New System.Drawing.Size(147, 75)
        Me.LblMainSpeedMan.SuppressErrorDisplay = True
        Me.LblMainSpeedMan.TabIndex = 13
        Me.LblMainSpeedMan.Text = " Hz"
        Me.LblMainSpeedMan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblMainSpeedMan.Value = ""
        Me.LblMainSpeedMan.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.LblMainSpeedMan.ValueLeftPadLength = 0
        Me.LblMainSpeedMan.ValuePrefix = Nothing
        Me.LblMainSpeedMan.ValueScaleFactor = 1.0R
        Me.LblMainSpeedMan.ValueSuffix = " Hz"
        Me.LblMainSpeedMan.ValueToSubtractFrom = 0!
        '
        'BtnJogDrumExit
        '
        Me.BtnJogDrumExit.BackColor = System.Drawing.Color.Black
        Me.BtnJogDrumExit.ComComponent = Me.EthernetIPforCLXCom1
        Me.BtnJogDrumExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJogDrumExit.ForeColor = System.Drawing.Color.Black
        Me.BtnJogDrumExit.ForeColorAltername = System.Drawing.Color.Black
        Me.BtnJogDrumExit.Highlight = False
        Me.BtnJogDrumExit.HighlightColor = System.Drawing.Color.Green
        Me.BtnJogDrumExit.Location = New System.Drawing.Point(342, 390)
        Me.BtnJogDrumExit.MaximumHoldTime = 3000
        Me.BtnJogDrumExit.MinimumHoldTime = 500
        Me.BtnJogDrumExit.Name = "BtnJogDrumExit"
        Me.BtnJogDrumExit.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BtnJogDrumExit.PLCAddressClick = ""
        Me.BtnJogDrumExit.SelectTextAlternate = False
        Me.BtnJogDrumExit.Size = New System.Drawing.Size(131, 48)
        Me.BtnJogDrumExit.TabIndex = 260
        Me.BtnJogDrumExit.Text = "EXIT"
        Me.BtnJogDrumExit.TextAlternate = Nothing
        Me.BtnJogDrumExit.UseVisualStyleBackColor = True
        Me.BtnJogDrumExit.ValueToWrite = 0
        '
        'BasicLabel1
        '
        Me.BasicLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BasicLabel1.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel1.DisplayAsTime = False
        Me.BasicLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicLabel1.ForeColor = System.Drawing.Color.White
        Me.BasicLabel1.Highlight = False
        Me.BasicLabel1.HighlightColor = System.Drawing.Color.Green
        Me.BasicLabel1.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel1.HighlightKeyCharacter = "!"
        Me.BasicLabel1.InterpretValueAsBCD = False
        Me.BasicLabel1.KeypadAlphaNumeric = False
        Me.BasicLabel1.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel1.KeypadMaxValue = 80.0R
        Me.BasicLabel1.KeypadMinValue = 0R
        Me.BasicLabel1.KeypadScaleFactor = 1.0R
        Me.BasicLabel1.KeypadShowCurrentValue = True
        Me.BasicLabel1.KeypadText = Nothing
        Me.BasicLabel1.KeypadWidth = 300
        Me.BasicLabel1.Location = New System.Drawing.Point(641, 176)
        Me.BasicLabel1.Name = "BasicLabel1"
        Me.BasicLabel1.NumericFormat = "F"
        Me.BasicLabel1.PLCAddressKeypad = "HMI.Jog_Speed"
        Me.BasicLabel1.PLCAddressValue = "HMI.Jog_Speed"
        Me.BasicLabel1.PollRate = 0
        Me.BasicLabel1.Size = New System.Drawing.Size(147, 75)
        Me.BasicLabel1.SuppressErrorDisplay = True
        Me.BasicLabel1.TabIndex = 261
        Me.BasicLabel1.Text = " Hz"
        Me.BasicLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BasicLabel1.Value = ""
        Me.BasicLabel1.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel1.ValueLeftPadLength = 0
        Me.BasicLabel1.ValuePrefix = Nothing
        Me.BasicLabel1.ValueScaleFactor = 1.0R
        Me.BasicLabel1.ValueSuffix = " Hz"
        Me.BasicLabel1.ValueToSubtractFrom = 0!
        '
        'BtnJogDirection
        '
        Me.BtnJogDirection.BackColor = System.Drawing.Color.Black
        Me.BtnJogDirection.ComComponent = Me.EthernetIPforCLXCom1
        Me.BtnJogDirection.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJogDirection.ForeColor = System.Drawing.Color.White
        Me.BtnJogDirection.ForeColorAltername = System.Drawing.Color.OrangeRed
        Me.BtnJogDirection.Highlight = False
        Me.BtnJogDirection.HighlightColor = System.Drawing.Color.Green
        Me.BtnJogDirection.Location = New System.Drawing.Point(443, 151)
        Me.BtnJogDirection.MaximumHoldTime = 3000
        Me.BtnJogDirection.MinimumHoldTime = 500
        Me.BtnJogDirection.Name = "BtnJogDirection"
        Me.BtnJogDirection.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BtnJogDirection.PLCAddressClick = "HMI_Drum_Direction"
        Me.BtnJogDirection.PLCAddressHighlightX = "HMI_Drum_Direction"
        Me.BtnJogDirection.PLCAddressSelectTextAlternate = "Drum_Reverse_Direction_Latch"
        Me.BtnJogDirection.SelectTextAlternate = False
        Me.BtnJogDirection.Size = New System.Drawing.Size(166, 126)
        Me.BtnJogDirection.TabIndex = 262
        Me.BtnJogDirection.Text = "Forward"
        Me.BtnJogDirection.TextAlternate = "Reverse"
        Me.BtnJogDirection.UseVisualStyleBackColor = False
        Me.BtnJogDirection.ValueToWrite = 0
        '
        'PPJogDrum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnJogDirection)
        Me.Controls.Add(Me.BasicLabel1)
        Me.Controls.Add(Me.BtnJogDrumExit)
        Me.Controls.Add(Me.LblMainSpeedMan)
        Me.Controls.Add(Me.MBJogDrum)
        Me.Controls.Add(Me.LblJogDrum)
        Me.Controls.Add(Me.Motor1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PPJogDrum"
        Me.Text = "PPJogDrum"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Motor1 As AdvancedHMIControls.Motor
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents LblJogDrum As Label
    Friend WithEvents MBJogDrum As AdvancedHMIControls.MomentaryButton
    Friend WithEvents LblMainSpeedMan As AdvancedHMIControls.BasicLabel
    Friend WithEvents BtnJogDrumExit As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicLabel1 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BtnJogDirection As AdvancedHMIControls.BasicButton
End Class
