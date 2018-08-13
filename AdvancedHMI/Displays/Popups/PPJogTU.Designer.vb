<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PPJogTU
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
        Me.BtnJogDirection = New AdvancedHMIControls.BasicButton()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BasicLabel1 = New AdvancedHMIControls.BasicLabel()
        Me.BtnJogTakeupExit = New AdvancedHMIControls.BasicButton()
        Me.LblTUSpeedMan = New AdvancedHMIControls.BasicLabel()
        Me.MBJogDrum = New AdvancedHMIControls.MomentaryButton()
        Me.LblJogDrum = New System.Windows.Forms.Label()
        Me.Motor1 = New AdvancedHMIControls.Motor()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BtnJogDirection.Location = New System.Drawing.Point(443, 157)
        Me.BtnJogDirection.MaximumHoldTime = 10000
        Me.BtnJogDirection.MinimumHoldTime = 500
        Me.BtnJogDirection.Name = "BtnJogDirection"
        Me.BtnJogDirection.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.BtnJogDirection.PLCAddressClick = "HMI_Takeup_Direction"
        Me.BtnJogDirection.PLCAddressHighlightX = "HMI_Takeup_Direction"
        Me.BtnJogDirection.PLCAddressSelectTextAlternate = "Takeup_Reverse_Direction_Latch"
        Me.BtnJogDirection.SelectTextAlternate = False
        Me.BtnJogDirection.Size = New System.Drawing.Size(166, 126)
        Me.BtnJogDirection.TabIndex = 269
        Me.BtnJogDirection.Text = "Forward"
        Me.BtnJogDirection.TextAlternate = "Reverse"
        Me.BtnJogDirection.UseVisualStyleBackColor = False
        Me.BtnJogDirection.ValueToWrite = 0
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "192.168.0.10"
        Me.EthernetIPforCLXCom1.PollRateOverride = 500
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
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
        Me.BasicLabel1.Location = New System.Drawing.Point(641, 182)
        Me.BasicLabel1.Name = "BasicLabel1"
        Me.BasicLabel1.NumericFormat = "F"
        Me.BasicLabel1.PLCAddressKeypad = "HMI.Jog_Speed"
        Me.BasicLabel1.PLCAddressValue = "HMI.Jog_Speed"
        Me.BasicLabel1.PollRate = 0
        Me.BasicLabel1.Size = New System.Drawing.Size(147, 75)
        Me.BasicLabel1.SuppressErrorDisplay = True
        Me.BasicLabel1.TabIndex = 268
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
        'BtnJogTakeupExit
        '
        Me.BtnJogTakeupExit.BackColor = System.Drawing.Color.Black
        Me.BtnJogTakeupExit.ComComponent = Me.EthernetIPforCLXCom1
        Me.BtnJogTakeupExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJogTakeupExit.ForeColor = System.Drawing.Color.Black
        Me.BtnJogTakeupExit.ForeColorAltername = System.Drawing.Color.Black
        Me.BtnJogTakeupExit.Highlight = False
        Me.BtnJogTakeupExit.HighlightColor = System.Drawing.Color.Green
        Me.BtnJogTakeupExit.Location = New System.Drawing.Point(342, 396)
        Me.BtnJogTakeupExit.MaximumHoldTime = 5000
        Me.BtnJogTakeupExit.MinimumHoldTime = 500
        Me.BtnJogTakeupExit.Name = "BtnJogTakeupExit"
        Me.BtnJogTakeupExit.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BtnJogTakeupExit.PLCAddressClick = ""
        Me.BtnJogTakeupExit.SelectTextAlternate = False
        Me.BtnJogTakeupExit.Size = New System.Drawing.Size(131, 48)
        Me.BtnJogTakeupExit.TabIndex = 267
        Me.BtnJogTakeupExit.Text = "EXIT"
        Me.BtnJogTakeupExit.TextAlternate = Nothing
        Me.BtnJogTakeupExit.UseVisualStyleBackColor = True
        Me.BtnJogTakeupExit.ValueToWrite = 0
        '
        'LblTUSpeedMan
        '
        Me.LblTUSpeedMan.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblTUSpeedMan.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.LblTUSpeedMan.ComComponent = Me.EthernetIPforCLXCom1
        Me.LblTUSpeedMan.DisplayAsTime = False
        Me.LblTUSpeedMan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTUSpeedMan.ForeColor = System.Drawing.Color.White
        Me.LblTUSpeedMan.Highlight = False
        Me.LblTUSpeedMan.HighlightColor = System.Drawing.Color.Green
        Me.LblTUSpeedMan.HighlightForeColor = System.Drawing.Color.White
        Me.LblTUSpeedMan.HighlightKeyCharacter = "!"
        Me.LblTUSpeedMan.InterpretValueAsBCD = False
        Me.LblTUSpeedMan.KeypadAlphaNumeric = False
        Me.LblTUSpeedMan.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.LblTUSpeedMan.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.LblTUSpeedMan.KeypadMaxValue = 80.0R
        Me.LblTUSpeedMan.KeypadMinValue = 0R
        Me.LblTUSpeedMan.KeypadScaleFactor = 1.0R
        Me.LblTUSpeedMan.KeypadShowCurrentValue = False
        Me.LblTUSpeedMan.KeypadText = Nothing
        Me.LblTUSpeedMan.KeypadWidth = 300
        Me.LblTUSpeedMan.Location = New System.Drawing.Point(35, 281)
        Me.LblTUSpeedMan.Name = "LblTUSpeedMan"
        Me.LblTUSpeedMan.NumericFormat = "F"
        Me.LblTUSpeedMan.PLCAddressKeypad = ""
        Me.LblTUSpeedMan.PLCAddressValue = "HMI.Tension_Control.Output_Speed"
        Me.LblTUSpeedMan.PollRate = 0
        Me.LblTUSpeedMan.Size = New System.Drawing.Size(147, 75)
        Me.LblTUSpeedMan.SuppressErrorDisplay = True
        Me.LblTUSpeedMan.TabIndex = 266
        Me.LblTUSpeedMan.Text = " Hz"
        Me.LblTUSpeedMan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblTUSpeedMan.Value = ""
        Me.LblTUSpeedMan.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.LblTUSpeedMan.ValueLeftPadLength = 0
        Me.LblTUSpeedMan.ValuePrefix = Nothing
        Me.LblTUSpeedMan.ValueScaleFactor = 1.0R
        Me.LblTUSpeedMan.ValueSuffix = " Hz"
        Me.LblTUSpeedMan.ValueToSubtractFrom = 0!
        '
        'MBJogDrum
        '
        Me.MBJogDrum.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Green
        Me.MBJogDrum.ComComponent = Me.EthernetIPforCLXCom1
        Me.MBJogDrum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MBJogDrum.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Small
        Me.MBJogDrum.Location = New System.Drawing.Point(277, 143)
        Me.MBJogDrum.MaximumHoldTime = 10000
        Me.MBJogDrum.MinimumHoldTime = 100
        Me.MBJogDrum.Name = "MBJogDrum"
        Me.MBJogDrum.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet
        Me.MBJogDrum.PLCAddressClick = "HMI.Jog_Takeup"
        Me.MBJogDrum.PLCAddressVisible = ""
        Me.MBJogDrum.Size = New System.Drawing.Size(133, 140)
        Me.MBJogDrum.TabIndex = 265
        Me.MBJogDrum.Text = "JOG"
        '
        'LblJogDrum
        '
        Me.LblJogDrum.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblJogDrum.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJogDrum.Location = New System.Drawing.Point(0, 0)
        Me.LblJogDrum.Name = "LblJogDrum"
        Me.LblJogDrum.Size = New System.Drawing.Size(800, 43)
        Me.LblJogDrum.TabIndex = 264
        Me.LblJogDrum.Text = "JOG TAKE-UP"
        Me.LblJogDrum.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Motor1
        '
        Me.Motor1.ComComponent = Me.EthernetIPforCLXCom1
        Me.Motor1.LightColor = MfgControl.AdvancedHMI.Controls.Motor.LightColors.Green
        Me.Motor1.Location = New System.Drawing.Point(12, 122)
        Me.Motor1.Name = "Motor1"
        Me.Motor1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.Motor1.PLCAddressClick = ""
        Me.Motor1.PLCAddressText = ""
        Me.Motor1.PLCAddressValue = "HMI_Takeup_Active"
        Me.Motor1.PLCAddressVisible = ""
        Me.Motor1.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.Motor1.Size = New System.Drawing.Size(230, 156)
        Me.Motor1.TabIndex = 263
        Me.Motor1.Value = False
        '
        'PPJogTU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnJogDirection)
        Me.Controls.Add(Me.BasicLabel1)
        Me.Controls.Add(Me.BtnJogTakeupExit)
        Me.Controls.Add(Me.LblTUSpeedMan)
        Me.Controls.Add(Me.MBJogDrum)
        Me.Controls.Add(Me.LblJogDrum)
        Me.Controls.Add(Me.Motor1)
        Me.Name = "PPJogTU"
        Me.Text = "PPJogTU"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnJogDirection As AdvancedHMIControls.BasicButton
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BasicLabel1 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BtnJogTakeupExit As AdvancedHMIControls.BasicButton
    Friend WithEvents LblTUSpeedMan As AdvancedHMIControls.BasicLabel
    Friend WithEvents MBJogDrum As AdvancedHMIControls.MomentaryButton
    Friend WithEvents LblJogDrum As Label
    Friend WithEvents Motor1 As AdvancedHMIControls.Motor
End Class
