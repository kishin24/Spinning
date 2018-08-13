<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aaMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aaMain))
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.Odometer1 = New AdvancedHMIControls.Odometer()
        Me.MbReset = New AdvancedHMIControls.MomentaryButton()
        Me.MbStop = New AdvancedHMIControls.MomentaryButton()
        Me.LblMainRetention = New AdvancedHMIControls.BasicLabel()
        Me.MbStart = New AdvancedHMIControls.MomentaryButton()
        Me.LblMainSPDisp = New AdvancedHMIControls.BasicLabel()
        Me.LblMainSpeedMan = New AdvancedHMIControls.BasicLabel()
        Me.ThreeButtonPLC1 = New AdvancedHMIControls.ThreeButtonPLC()
        Me.OrientedTextLabel2 = New AdvancedHMIControls.OrientedTextLabel()
        Me.Motor2 = New AdvancedHMIControls.Motor()
        Me.OrientedTextLabel1 = New AdvancedHMIControls.OrientedTextLabel()
        Me.Motor1 = New AdvancedHMIControls.Motor()
        Me.Ind_Runnign = New AdvancedHMIControls.BasicIndicator()
        Me.BasicLabel2 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel3 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel4 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel5 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel6 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel7 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel8 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel9 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel1 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel10 = New AdvancedHMIControls.BasicLabel()
        Me.MessageDisplayByValue2 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OrientedTextLabel8 = New AdvancedHMIControls.OrientedTextLabel()
        Me.BasicLabel12 = New AdvancedHMIControls.BasicLabel()
        Me.OrientedTextLabel7 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel6 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel5 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel4 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel3 = New AdvancedHMIControls.OrientedTextLabel()
        Me.BasicLabel11 = New AdvancedHMIControls.BasicLabel()
        Me.DataLink1 = New Devart.Data.DataLink()
        Me.DataLink2 = New Devart.Data.DataLink()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataLink1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLink2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Odometer1
        '
        resources.ApplyResources(Me.Odometer1, "Odometer1")
        Me.Odometer1.BackColorAfterDecimal = System.Drawing.Color.Black
        Me.Odometer1.ComComponent = Me.EthernetIPforCLXCom1
        Me.Odometer1.ForeColorAfterDecimal = System.Drawing.Color.White
        Me.Odometer1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.Odometer1.KeypadMaxValue = 0R
        Me.Odometer1.KeypadMinValue = 0R
        Me.Odometer1.KeypadScaleFactor = 1.0R
        Me.Odometer1.KeypadText = Nothing
        Me.Odometer1.KeypadWidth = 300
        Me.Odometer1.Name = "Odometer1"
        Me.Odometer1.NumberOfDigits = 5
        Me.Odometer1.NumberOfDigitsAfterDecimal = 0
        Me.Odometer1.PLCAddressKeypad = ""
        Me.Odometer1.PLCAddressValue = CType(resources.GetObject("Odometer1.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.Odometer1.Value = 0R
        '
        'MbReset
        '
        Me.MbReset.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Blue
        Me.MbReset.ComComponent = Me.EthernetIPforCLXCom1
        resources.ApplyResources(Me.MbReset, "MbReset")
        Me.MbReset.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Small
        Me.MbReset.MaximumHoldTime = 3000
        Me.MbReset.MinimumHoldTime = 500
        Me.MbReset.Name = "MbReset"
        Me.MbReset.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet
        Me.MbReset.PLCAddressClick = "HMI.Fault_Reset_Main"
        Me.MbReset.PLCAddressVisible = ""
        '
        'MbStop
        '
        Me.MbStop.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Red
        Me.MbStop.ComComponent = Me.EthernetIPforCLXCom1
        resources.ApplyResources(Me.MbStop, "MbStop")
        Me.MbStop.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Small
        Me.MbStop.MaximumHoldTime = 3000
        Me.MbStop.MinimumHoldTime = 500
        Me.MbStop.Name = "MbStop"
        Me.MbStop.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet
        Me.MbStop.PLCAddressClick = "HMI.Stop"
        Me.MbStop.PLCAddressVisible = ""
        '
        'LblMainRetention
        '
        Me.LblMainRetention.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LblMainRetention.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.LblMainRetention.ComComponent = Me.EthernetIPforCLXCom1
        Me.LblMainRetention.DisplayAsTime = False
        resources.ApplyResources(Me.LblMainRetention, "LblMainRetention")
        Me.LblMainRetention.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LblMainRetention.Highlight = False
        Me.LblMainRetention.HighlightColor = System.Drawing.Color.Green
        Me.LblMainRetention.HighlightForeColor = System.Drawing.Color.White
        Me.LblMainRetention.HighlightKeyCharacter = "!"
        Me.LblMainRetention.InterpretValueAsBCD = False
        Me.LblMainRetention.KeypadAlphaNumeric = False
        Me.LblMainRetention.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.LblMainRetention.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.LblMainRetention.KeypadMaxValue = 80.0R
        Me.LblMainRetention.KeypadMinValue = 0R
        Me.LblMainRetention.KeypadScaleFactor = 1.0R
        Me.LblMainRetention.KeypadShowCurrentValue = False
        Me.LblMainRetention.KeypadText = Nothing
        Me.LblMainRetention.KeypadWidth = 300
        Me.LblMainRetention.Name = "LblMainRetention"
        Me.LblMainRetention.NumericFormat = "f"
        Me.LblMainRetention.PLCAddressKeypad = "Spiral_Drum.Retention.Target_Retention_Time"
        Me.LblMainRetention.PLCAddressValue = "Spiral_Drum.Retention.Target_Retention_Time"
        Me.LblMainRetention.PLCAddressVisible = "auto_mode"
        Me.LblMainRetention.PollRate = 0
        Me.LblMainRetention.SuppressErrorDisplay = True
        Me.LblMainRetention.Value = ""
        Me.LblMainRetention.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.LblMainRetention.ValueLeftPadLength = 0
        Me.LblMainRetention.ValuePrefix = Nothing
        Me.LblMainRetention.ValueScaleFactor = 1.0R
        Me.LblMainRetention.ValueSuffix = " Minutes"
        Me.LblMainRetention.ValueToSubtractFrom = 0!
        '
        'MbStart
        '
        Me.MbStart.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Green
        Me.MbStart.ComComponent = Me.EthernetIPforCLXCom1
        resources.ApplyResources(Me.MbStart, "MbStart")
        Me.MbStart.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Small
        Me.MbStart.MaximumHoldTime = 3000
        Me.MbStart.MinimumHoldTime = 500
        Me.MbStart.Name = "MbStart"
        Me.MbStart.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet
        Me.MbStart.PLCAddressClick = "HMI.Start"
        Me.MbStart.PLCAddressVisible = ""
        '
        'LblMainSPDisp
        '
        Me.LblMainSPDisp.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LblMainSPDisp.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.LblMainSPDisp.ComComponent = Me.EthernetIPforCLXCom1
        Me.LblMainSPDisp.DisplayAsTime = False
        resources.ApplyResources(Me.LblMainSPDisp, "LblMainSPDisp")
        Me.LblMainSPDisp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LblMainSPDisp.Highlight = False
        Me.LblMainSPDisp.HighlightColor = System.Drawing.Color.Red
        Me.LblMainSPDisp.HighlightForeColor = System.Drawing.Color.White
        Me.LblMainSPDisp.HighlightKeyCharacter = "!"
        Me.LblMainSPDisp.InterpretValueAsBCD = False
        Me.LblMainSPDisp.KeypadAlphaNumeric = False
        Me.LblMainSPDisp.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.LblMainSPDisp.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.LblMainSPDisp.KeypadMaxValue = 200.0R
        Me.LblMainSPDisp.KeypadMinValue = 0R
        Me.LblMainSPDisp.KeypadScaleFactor = 1.0R
        Me.LblMainSPDisp.KeypadShowCurrentValue = False
        Me.LblMainSPDisp.KeypadText = Nothing
        Me.LblMainSPDisp.KeypadWidth = 300
        Me.LblMainSPDisp.Name = "LblMainSPDisp"
        Me.LblMainSPDisp.NumericFormat = "f"
        Me.LblMainSPDisp.PLCAddressKeypad = "Gen_II_Control_Parameters.Torque_Setpoint"
        Me.LblMainSPDisp.PLCAddressValue = "Gen_II_Control_Parameters.Torque_Setpoint"
        Me.LblMainSPDisp.PollRate = 0
        Me.LblMainSPDisp.SuppressErrorDisplay = True
        Me.LblMainSPDisp.Value = ""
        Me.LblMainSPDisp.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.LblMainSPDisp.ValueLeftPadLength = 0
        Me.LblMainSPDisp.ValuePrefix = Nothing
        Me.LblMainSPDisp.ValueScaleFactor = 1.0R
        Me.LblMainSPDisp.ValueSuffix = " %"
        Me.LblMainSPDisp.ValueToSubtractFrom = 0!
        '
        'LblMainSpeedMan
        '
        Me.LblMainSpeedMan.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LblMainSpeedMan.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.LblMainSpeedMan.ComComponent = Me.EthernetIPforCLXCom1
        Me.LblMainSpeedMan.DisplayAsTime = False
        resources.ApplyResources(Me.LblMainSpeedMan, "LblMainSpeedMan")
        Me.LblMainSpeedMan.ForeColor = System.Drawing.Color.MidnightBlue
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
        Me.LblMainSpeedMan.Name = "LblMainSpeedMan"
        Me.LblMainSpeedMan.NumericFormat = "F"
        Me.LblMainSpeedMan.PLCAddressKeypad = "HMI_Frequency_Setting"
        Me.LblMainSpeedMan.PLCAddressValue = "HMI_Frequency_Setting"
        Me.LblMainSpeedMan.PLCAddressVisible = "hand_mode"
        Me.LblMainSpeedMan.PollRate = 0
        Me.LblMainSpeedMan.SuppressErrorDisplay = True
        Me.LblMainSpeedMan.Value = ""
        Me.LblMainSpeedMan.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.LblMainSpeedMan.ValueLeftPadLength = 0
        Me.LblMainSpeedMan.ValuePrefix = Nothing
        Me.LblMainSpeedMan.ValueScaleFactor = 1.0R
        Me.LblMainSpeedMan.ValueSuffix = " Hz"
        Me.LblMainSpeedMan.ValueToSubtractFrom = 0!
        '
        'ThreeButtonPLC1
        '
        resources.ApplyResources(Me.ThreeButtonPLC1, "ThreeButtonPLC1")
        Me.ThreeButtonPLC1.Button1Text = "Manual"
        Me.ThreeButtonPLC1.Button2Text = "Auto"
        Me.ThreeButtonPLC1.Button3Text = "Test"
        Me.ThreeButtonPLC1.ComComponent = Me.EthernetIPforCLXCom1
        Me.ThreeButtonPLC1.Name = "ThreeButtonPLC1"
        Me.ThreeButtonPLC1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.ThreeButtonPLC1.PLCAddressClickAuto = "HMI_Auto_Mode"
        Me.ThreeButtonPLC1.PLCAddressClickHand = "HMI_Hand_Mode"
        Me.ThreeButtonPLC1.PLCAddressClickOff = "HMI_Test_Mode"
        Me.ThreeButtonPLC1.PLCAddressStatusAuto = "Auto_Mode"
        Me.ThreeButtonPLC1.PLCAddressStatusHand = "Hand_Mode"
        Me.ThreeButtonPLC1.PLCAddressStatusOff = "Test_Mode"
        Me.ThreeButtonPLC1.PLCAddressVisible = ""
        '
        'OrientedTextLabel2
        '
        resources.ApplyResources(Me.OrientedTextLabel2, "OrientedTextLabel2")
        Me.OrientedTextLabel2.Name = "OrientedTextLabel2"
        Me.OrientedTextLabel2.RotationAngle = 0R
        Me.OrientedTextLabel2.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel2.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'Motor2
        '
        resources.ApplyResources(Me.Motor2, "Motor2")
        Me.Motor2.ComComponent = Me.EthernetIPforCLXCom1
        Me.Motor2.LightColor = MfgControl.AdvancedHMI.Controls.Motor.LightColors.Green
        Me.Motor2.Name = "Motor2"
        Me.Motor2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.Motor2.PLCAddressClick = ""
        Me.Motor2.PLCAddressText = ""
        Me.Motor2.PLCAddressValue = "HMI_Takeup_Active"
        Me.Motor2.PLCAddressVisible = ""
        Me.Motor2.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.Motor2.Value = False
        '
        'OrientedTextLabel1
        '
        resources.ApplyResources(Me.OrientedTextLabel1, "OrientedTextLabel1")
        Me.OrientedTextLabel1.Name = "OrientedTextLabel1"
        Me.OrientedTextLabel1.RotationAngle = 0R
        Me.OrientedTextLabel1.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel1.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'Motor1
        '
        resources.ApplyResources(Me.Motor1, "Motor1")
        Me.Motor1.ComComponent = Me.EthernetIPforCLXCom1
        Me.Motor1.LightColor = MfgControl.AdvancedHMI.Controls.Motor.LightColors.Green
        Me.Motor1.Name = "Motor1"
        Me.Motor1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.Motor1.PLCAddressClick = ""
        Me.Motor1.PLCAddressText = ""
        Me.Motor1.PLCAddressValue = "HMI_Drum_Active"
        Me.Motor1.PLCAddressVisible = ""
        Me.Motor1.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.Motor1.Value = False
        '
        'Ind_Runnign
        '
        resources.ApplyResources(Me.Ind_Runnign, "Ind_Runnign")
        Me.Ind_Runnign.Color1 = System.Drawing.Color.DarkGray
        Me.Ind_Runnign.Color2 = System.Drawing.Color.Green
        Me.Ind_Runnign.Color3 = System.Drawing.Color.Red
        Me.Ind_Runnign.ComComponent = Me.EthernetIPforCLXCom1
        Me.Ind_Runnign.Name = "Ind_Runnign"
        Me.Ind_Runnign.OutlineColor = System.Drawing.Color.Transparent
        Me.Ind_Runnign.OutlineWidth = 1
        Me.Ind_Runnign.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.Ind_Runnign.PLCAddressSelectColor2 = "Run_Spiral"
        Me.Ind_Runnign.PLCAddressVisible = "Run_Spiral"
        Me.Ind_Runnign.SelectColor2 = False
        Me.Ind_Runnign.SelectColor3 = False
        Me.Ind_Runnign.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle
        '
        'BasicLabel2
        '
        resources.ApplyResources(Me.BasicLabel2, "BasicLabel2")
        Me.BasicLabel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BasicLabel2.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel2.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel2.DisplayAsTime = False
        Me.BasicLabel2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BasicLabel2.Highlight = False
        Me.BasicLabel2.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel2.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel2.HighlightKeyCharacter = "!"
        Me.BasicLabel2.InterpretValueAsBCD = False
        Me.BasicLabel2.KeypadAlphaNumeric = False
        Me.BasicLabel2.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel2.KeypadMaxValue = 0R
        Me.BasicLabel2.KeypadMinValue = 0R
        Me.BasicLabel2.KeypadScaleFactor = 1.0R
        Me.BasicLabel2.KeypadShowCurrentValue = False
        Me.BasicLabel2.KeypadText = Nothing
        Me.BasicLabel2.KeypadWidth = 300
        Me.BasicLabel2.Name = "BasicLabel2"
        Me.BasicLabel2.NumericFormat = "F"
        Me.BasicLabel2.PLCAddressKeypad = ""
        Me.BasicLabel2.PLCAddressValue = "HMI_Drum_Output_Frequency"
        Me.BasicLabel2.PollRate = 0
        Me.BasicLabel2.Value = "0"
        Me.BasicLabel2.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel2.ValueLeftPadLength = 0
        Me.BasicLabel2.ValuePrefix = Nothing
        Me.BasicLabel2.ValueScaleFactor = 1.0R
        Me.BasicLabel2.ValueSuffix = " Hz."
        Me.BasicLabel2.ValueToSubtractFrom = 0!
        '
        'BasicLabel3
        '
        resources.ApplyResources(Me.BasicLabel3, "BasicLabel3")
        Me.BasicLabel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BasicLabel3.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel3.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel3.DisplayAsTime = False
        Me.BasicLabel3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BasicLabel3.Highlight = False
        Me.BasicLabel3.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel3.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel3.HighlightKeyCharacter = "!"
        Me.BasicLabel3.InterpretValueAsBCD = False
        Me.BasicLabel3.KeypadAlphaNumeric = False
        Me.BasicLabel3.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel3.KeypadMaxValue = 0R
        Me.BasicLabel3.KeypadMinValue = 0R
        Me.BasicLabel3.KeypadScaleFactor = 1.0R
        Me.BasicLabel3.KeypadShowCurrentValue = False
        Me.BasicLabel3.KeypadText = Nothing
        Me.BasicLabel3.KeypadWidth = 300
        Me.BasicLabel3.Name = "BasicLabel3"
        Me.BasicLabel3.NumericFormat = "F"
        Me.BasicLabel3.PLCAddressKeypad = ""
        Me.BasicLabel3.PLCAddressValue = "Spiral_Takeup.VFD_Feedback_Current"
        Me.BasicLabel3.PollRate = 0
        Me.BasicLabel3.Value = "0"
        Me.BasicLabel3.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel3.ValueLeftPadLength = 0
        Me.BasicLabel3.ValuePrefix = Nothing
        Me.BasicLabel3.ValueScaleFactor = 1.0R
        Me.BasicLabel3.ValueSuffix = " A"
        Me.BasicLabel3.ValueToSubtractFrom = 0!
        '
        'BasicLabel4
        '
        resources.ApplyResources(Me.BasicLabel4, "BasicLabel4")
        Me.BasicLabel4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BasicLabel4.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel4.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel4.DisplayAsTime = False
        Me.BasicLabel4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BasicLabel4.Highlight = False
        Me.BasicLabel4.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel4.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel4.HighlightKeyCharacter = "!"
        Me.BasicLabel4.InterpretValueAsBCD = False
        Me.BasicLabel4.KeypadAlphaNumeric = False
        Me.BasicLabel4.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel4.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel4.KeypadMaxValue = 0R
        Me.BasicLabel4.KeypadMinValue = 0R
        Me.BasicLabel4.KeypadScaleFactor = 1.0R
        Me.BasicLabel4.KeypadShowCurrentValue = False
        Me.BasicLabel4.KeypadText = Nothing
        Me.BasicLabel4.KeypadWidth = 300
        Me.BasicLabel4.Name = "BasicLabel4"
        Me.BasicLabel4.NumericFormat = "F"
        Me.BasicLabel4.PLCAddressKeypad = ""
        Me.BasicLabel4.PLCAddressValue = "HMI.Tension_Control.Output_Speed"
        Me.BasicLabel4.PollRate = 0
        Me.BasicLabel4.Value = "0"
        Me.BasicLabel4.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel4.ValueLeftPadLength = 0
        Me.BasicLabel4.ValuePrefix = Nothing
        Me.BasicLabel4.ValueScaleFactor = 1.0R
        Me.BasicLabel4.ValueSuffix = " RPM"
        Me.BasicLabel4.ValueToSubtractFrom = 0!
        '
        'BasicLabel5
        '
        resources.ApplyResources(Me.BasicLabel5, "BasicLabel5")
        Me.BasicLabel5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BasicLabel5.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel5.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel5.DisplayAsTime = False
        Me.BasicLabel5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BasicLabel5.Highlight = False
        Me.BasicLabel5.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel5.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel5.HighlightKeyCharacter = "!"
        Me.BasicLabel5.InterpretValueAsBCD = False
        Me.BasicLabel5.KeypadAlphaNumeric = False
        Me.BasicLabel5.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel5.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel5.KeypadMaxValue = 0R
        Me.BasicLabel5.KeypadMinValue = 0R
        Me.BasicLabel5.KeypadScaleFactor = 1.0R
        Me.BasicLabel5.KeypadShowCurrentValue = False
        Me.BasicLabel5.KeypadText = Nothing
        Me.BasicLabel5.KeypadWidth = 300
        Me.BasicLabel5.Name = "BasicLabel5"
        Me.BasicLabel5.NumericFormat = "F"
        Me.BasicLabel5.PLCAddressKeypad = ""
        Me.BasicLabel5.PLCAddressValue = "Spiral_Drum.VFD_Feedback_Current"
        Me.BasicLabel5.PollRate = 0
        Me.BasicLabel5.Value = "0"
        Me.BasicLabel5.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel5.ValueLeftPadLength = 0
        Me.BasicLabel5.ValuePrefix = Nothing
        Me.BasicLabel5.ValueScaleFactor = 1.0R
        Me.BasicLabel5.ValueSuffix = " A"
        Me.BasicLabel5.ValueToSubtractFrom = 0!
        '
        'BasicLabel6
        '
        Me.BasicLabel6.BackColor = System.Drawing.Color.MidnightBlue
        Me.BasicLabel6.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel6.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel6.DisplayAsTime = False
        resources.ApplyResources(Me.BasicLabel6, "BasicLabel6")
        Me.BasicLabel6.ForeColor = System.Drawing.Color.AliceBlue
        Me.BasicLabel6.Highlight = False
        Me.BasicLabel6.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel6.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel6.HighlightKeyCharacter = "!"
        Me.BasicLabel6.InterpretValueAsBCD = False
        Me.BasicLabel6.KeypadAlphaNumeric = False
        Me.BasicLabel6.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel6.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel6.KeypadMaxValue = 0R
        Me.BasicLabel6.KeypadMinValue = 0R
        Me.BasicLabel6.KeypadScaleFactor = 1.0R
        Me.BasicLabel6.KeypadShowCurrentValue = False
        Me.BasicLabel6.KeypadText = Nothing
        Me.BasicLabel6.KeypadWidth = 300
        Me.BasicLabel6.Name = "BasicLabel6"
        Me.BasicLabel6.NumericFormat = Nothing
        Me.BasicLabel6.PLCAddressKeypad = ""
        Me.BasicLabel6.PLCAddressVisible = "auto_mode"
        Me.BasicLabel6.PollRate = 0
        Me.BasicLabel6.Value = "RETENTION TIME"
        Me.BasicLabel6.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel6.ValueLeftPadLength = 0
        Me.BasicLabel6.ValuePrefix = Nothing
        Me.BasicLabel6.ValueScaleFactor = 1.0R
        Me.BasicLabel6.ValueSuffix = Nothing
        Me.BasicLabel6.ValueToSubtractFrom = 0!
        '
        'BasicLabel7
        '
        Me.BasicLabel7.BackColor = System.Drawing.Color.MidnightBlue
        Me.BasicLabel7.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel7.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel7.DisplayAsTime = False
        resources.ApplyResources(Me.BasicLabel7, "BasicLabel7")
        Me.BasicLabel7.ForeColor = System.Drawing.Color.AliceBlue
        Me.BasicLabel7.Highlight = False
        Me.BasicLabel7.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel7.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel7.HighlightKeyCharacter = "!"
        Me.BasicLabel7.InterpretValueAsBCD = False
        Me.BasicLabel7.KeypadAlphaNumeric = False
        Me.BasicLabel7.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel7.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel7.KeypadMaxValue = 0R
        Me.BasicLabel7.KeypadMinValue = 0R
        Me.BasicLabel7.KeypadScaleFactor = 1.0R
        Me.BasicLabel7.KeypadShowCurrentValue = False
        Me.BasicLabel7.KeypadText = Nothing
        Me.BasicLabel7.KeypadWidth = 300
        Me.BasicLabel7.Name = "BasicLabel7"
        Me.BasicLabel7.NumericFormat = Nothing
        Me.BasicLabel7.PLCAddressKeypad = ""
        Me.BasicLabel7.PollRate = 0
        Me.BasicLabel7.Value = "TENSION SETPOINT"
        Me.BasicLabel7.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel7.ValueLeftPadLength = 0
        Me.BasicLabel7.ValuePrefix = Nothing
        Me.BasicLabel7.ValueScaleFactor = 1.0R
        Me.BasicLabel7.ValueSuffix = Nothing
        Me.BasicLabel7.ValueToSubtractFrom = 0!
        '
        'BasicLabel8
        '
        Me.BasicLabel8.BackColor = System.Drawing.Color.MidnightBlue
        Me.BasicLabel8.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel8.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel8.DisplayAsTime = False
        resources.ApplyResources(Me.BasicLabel8, "BasicLabel8")
        Me.BasicLabel8.ForeColor = System.Drawing.Color.AliceBlue
        Me.BasicLabel8.Highlight = False
        Me.BasicLabel8.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel8.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel8.HighlightKeyCharacter = "!"
        Me.BasicLabel8.InterpretValueAsBCD = False
        Me.BasicLabel8.KeypadAlphaNumeric = False
        Me.BasicLabel8.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel8.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel8.KeypadMaxValue = 0R
        Me.BasicLabel8.KeypadMinValue = 0R
        Me.BasicLabel8.KeypadScaleFactor = 1.0R
        Me.BasicLabel8.KeypadShowCurrentValue = False
        Me.BasicLabel8.KeypadText = Nothing
        Me.BasicLabel8.KeypadWidth = 300
        Me.BasicLabel8.Name = "BasicLabel8"
        Me.BasicLabel8.NumericFormat = Nothing
        Me.BasicLabel8.PLCAddressKeypad = ""
        Me.BasicLabel8.PLCAddressVisible = "hand_mode"
        Me.BasicLabel8.PollRate = 0
        Me.BasicLabel8.Value = "MANUAL SPEED"
        Me.BasicLabel8.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel8.ValueLeftPadLength = 0
        Me.BasicLabel8.ValuePrefix = Nothing
        Me.BasicLabel8.ValueScaleFactor = 1.0R
        Me.BasicLabel8.ValueSuffix = Nothing
        Me.BasicLabel8.ValueToSubtractFrom = 0!
        '
        'BasicLabel9
        '
        Me.BasicLabel9.BackColor = System.Drawing.Color.MidnightBlue
        Me.BasicLabel9.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel9.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel9.DisplayAsTime = False
        resources.ApplyResources(Me.BasicLabel9, "BasicLabel9")
        Me.BasicLabel9.ForeColor = System.Drawing.Color.AliceBlue
        Me.BasicLabel9.Highlight = False
        Me.BasicLabel9.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel9.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel9.HighlightKeyCharacter = "!"
        Me.BasicLabel9.InterpretValueAsBCD = False
        Me.BasicLabel9.KeypadAlphaNumeric = False
        Me.BasicLabel9.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel9.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel9.KeypadMaxValue = 0R
        Me.BasicLabel9.KeypadMinValue = 0R
        Me.BasicLabel9.KeypadScaleFactor = 1.0R
        Me.BasicLabel9.KeypadShowCurrentValue = False
        Me.BasicLabel9.KeypadText = Nothing
        Me.BasicLabel9.KeypadWidth = 300
        Me.BasicLabel9.Name = "BasicLabel9"
        Me.BasicLabel9.NumericFormat = Nothing
        Me.BasicLabel9.PLCAddressKeypad = ""
        Me.BasicLabel9.PollRate = 0
        Me.BasicLabel9.Value = "LOAD CELL"
        Me.BasicLabel9.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel9.ValueLeftPadLength = 0
        Me.BasicLabel9.ValuePrefix = Nothing
        Me.BasicLabel9.ValueScaleFactor = 1.0R
        Me.BasicLabel9.ValueSuffix = Nothing
        Me.BasicLabel9.ValueToSubtractFrom = 0!
        '
        'BasicLabel1
        '
        Me.BasicLabel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BasicLabel1.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel1.DisplayAsTime = False
        resources.ApplyResources(Me.BasicLabel1, "BasicLabel1")
        Me.BasicLabel1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BasicLabel1.Highlight = False
        Me.BasicLabel1.HighlightColor = System.Drawing.Color.Green
        Me.BasicLabel1.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel1.HighlightKeyCharacter = "!"
        Me.BasicLabel1.InterpretValueAsBCD = False
        Me.BasicLabel1.KeypadAlphaNumeric = False
        Me.BasicLabel1.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel1.KeypadMaxValue = 0R
        Me.BasicLabel1.KeypadMinValue = 0R
        Me.BasicLabel1.KeypadScaleFactor = 1.0R
        Me.BasicLabel1.KeypadShowCurrentValue = False
        Me.BasicLabel1.KeypadText = Nothing
        Me.BasicLabel1.KeypadWidth = 300
        Me.BasicLabel1.Name = "BasicLabel1"
        Me.BasicLabel1.NumericFormat = "f"
        Me.BasicLabel1.PLCAddressKeypad = ""
        Me.BasicLabel1.PLCAddressValue = "Load_Cell_Percent"
        Me.BasicLabel1.PollRate = 0
        Me.BasicLabel1.SuppressErrorDisplay = True
        Me.BasicLabel1.Value = ""
        Me.BasicLabel1.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel1.ValueLeftPadLength = 0
        Me.BasicLabel1.ValuePrefix = Nothing
        Me.BasicLabel1.ValueScaleFactor = 1.0R
        Me.BasicLabel1.ValueSuffix = " %"
        Me.BasicLabel1.ValueToSubtractFrom = 0!
        '
        'BasicLabel10
        '
        resources.ApplyResources(Me.BasicLabel10, "BasicLabel10")
        Me.BasicLabel10.BackColor = System.Drawing.Color.Black
        Me.BasicLabel10.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel10.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel10.DisplayAsTime = False
        Me.BasicLabel10.ForeColor = System.Drawing.Color.White
        Me.BasicLabel10.Highlight = False
        Me.BasicLabel10.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel10.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel10.HighlightKeyCharacter = "!"
        Me.BasicLabel10.InterpretValueAsBCD = False
        Me.BasicLabel10.KeypadAlphaNumeric = False
        Me.BasicLabel10.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel10.KeypadMaxValue = 0R
        Me.BasicLabel10.KeypadMinValue = 0R
        Me.BasicLabel10.KeypadScaleFactor = 1.0R
        Me.BasicLabel10.KeypadShowCurrentValue = False
        Me.BasicLabel10.KeypadText = Nothing
        Me.BasicLabel10.KeypadWidth = 300
        Me.BasicLabel10.Name = "BasicLabel10"
        Me.BasicLabel10.NumericFormat = Nothing
        Me.BasicLabel10.PLCAddressKeypad = ""
        Me.BasicLabel10.PollRate = 0
        Me.BasicLabel10.Value = "TOTAL RUN HOURS"
        Me.BasicLabel10.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel10.ValueLeftPadLength = 0
        Me.BasicLabel10.ValuePrefix = Nothing
        Me.BasicLabel10.ValueScaleFactor = 1.0R
        Me.BasicLabel10.ValueSuffix = Nothing
        Me.BasicLabel10.ValueToSubtractFrom = 0!
        '
        'MessageDisplayByValue2
        '
        resources.ApplyResources(Me.MessageDisplayByValue2, "MessageDisplayByValue2")
        Me.MessageDisplayByValue2.BackColor = System.Drawing.Color.DarkRed
        Me.MessageDisplayByValue2.ComComponent = Me.EthernetIPforCLXCom1
        Me.MessageDisplayByValue2.ForeColor = System.Drawing.Color.Black
        Me.MessageDisplayByValue2.HighlightColor = System.Drawing.Color.Red
        Me.MessageDisplayByValue2.HighlightColor2 = System.Drawing.Color.Red
        Me.MessageDisplayByValue2.HighlightKeyCharacter = "!"
        Me.MessageDisplayByValue2.HighlightKeyCharacter2 = "."
        Me.MessageDisplayByValue2.IniFileName = ".\Alarms.txt"
        Me.MessageDisplayByValue2.Name = "MessageDisplayByValue2"
        Me.MessageDisplayByValue2.PLCAddressValue = "Fault.Alarm_Register"
        Me.MessageDisplayByValue2.PLCAddressVisible = "Fault_Major_Fault"
        Me.MessageDisplayByValue2.ShowMessageNumber = False
        Me.MessageDisplayByValue2.SpeakMessage = False
        Me.MessageDisplayByValue2.TextPrefix = Nothing
        Me.MessageDisplayByValue2.Value = 0
        '
        'BtnLogin
        '
        resources.ApplyResources(Me.BtnLogin, "BtnLogin")
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.SteelBlue
        Me.FlowLayoutPanel3.Controls.Add(Me.MessageDisplayByValue2)
        Me.FlowLayoutPanel3.Controls.Add(Me.GroupBox2)
        resources.ApplyResources(Me.FlowLayoutPanel3, "FlowLayoutPanel3")
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Controls.Add(Me.OrientedTextLabel8)
        Me.GroupBox2.Controls.Add(Me.BasicLabel12)
        Me.GroupBox2.Controls.Add(Me.OrientedTextLabel7)
        Me.GroupBox2.Controls.Add(Me.BtnLogin)
        Me.GroupBox2.Controls.Add(Me.OrientedTextLabel6)
        Me.GroupBox2.Controls.Add(Me.OrientedTextLabel5)
        Me.GroupBox2.Controls.Add(Me.Ind_Runnign)
        Me.GroupBox2.Controls.Add(Me.OrientedTextLabel4)
        Me.GroupBox2.Controls.Add(Me.OrientedTextLabel3)
        Me.GroupBox2.Controls.Add(Me.BasicLabel11)
        Me.GroupBox2.Controls.Add(Me.Odometer1)
        Me.GroupBox2.Controls.Add(Me.BasicLabel7)
        Me.GroupBox2.Controls.Add(Me.BasicLabel5)
        Me.GroupBox2.Controls.Add(Me.BasicLabel3)
        Me.GroupBox2.Controls.Add(Me.BasicLabel10)
        Me.GroupBox2.Controls.Add(Me.OrientedTextLabel1)
        Me.GroupBox2.Controls.Add(Me.BasicLabel1)
        Me.GroupBox2.Controls.Add(Me.BasicLabel4)
        Me.GroupBox2.Controls.Add(Me.Motor1)
        Me.GroupBox2.Controls.Add(Me.OrientedTextLabel2)
        Me.GroupBox2.Controls.Add(Me.LblMainSPDisp)
        Me.GroupBox2.Controls.Add(Me.BasicLabel2)
        Me.GroupBox2.Controls.Add(Me.Motor2)
        Me.GroupBox2.Controls.Add(Me.LblMainSpeedMan)
        Me.GroupBox2.Controls.Add(Me.LblMainRetention)
        Me.GroupBox2.Controls.Add(Me.BasicLabel6)
        Me.GroupBox2.Controls.Add(Me.BasicLabel8)
        Me.GroupBox2.Controls.Add(Me.ThreeButtonPLC1)
        Me.GroupBox2.Controls.Add(Me.MbStop)
        Me.GroupBox2.Controls.Add(Me.BasicLabel9)
        Me.GroupBox2.Controls.Add(Me.MbStart)
        Me.GroupBox2.Controls.Add(Me.MbReset)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'OrientedTextLabel8
        '
        resources.ApplyResources(Me.OrientedTextLabel8, "OrientedTextLabel8")
        Me.OrientedTextLabel8.Name = "OrientedTextLabel8"
        Me.OrientedTextLabel8.RotationAngle = 0R
        Me.OrientedTextLabel8.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel8.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'BasicLabel12
        '
        resources.ApplyResources(Me.BasicLabel12, "BasicLabel12")
        Me.BasicLabel12.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BasicLabel12.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel12.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel12.DisplayAsTime = False
        Me.BasicLabel12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BasicLabel12.Highlight = False
        Me.BasicLabel12.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel12.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel12.HighlightKeyCharacter = "!"
        Me.BasicLabel12.InterpretValueAsBCD = False
        Me.BasicLabel12.KeypadAlphaNumeric = False
        Me.BasicLabel12.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel12.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel12.KeypadMaxValue = 0R
        Me.BasicLabel12.KeypadMinValue = 0R
        Me.BasicLabel12.KeypadScaleFactor = 1.0R
        Me.BasicLabel12.KeypadShowCurrentValue = False
        Me.BasicLabel12.KeypadText = Nothing
        Me.BasicLabel12.KeypadWidth = 300
        Me.BasicLabel12.Name = "BasicLabel12"
        Me.BasicLabel12.NumericFormat = "F"
        Me.BasicLabel12.PLCAddressKeypad = ""
        Me.BasicLabel12.PLCAddressValue = "Load_Cell_Percent"
        Me.BasicLabel12.PollRate = 0
        Me.BasicLabel12.Value = "0"
        Me.BasicLabel12.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel12.ValueLeftPadLength = 0
        Me.BasicLabel12.ValuePrefix = Nothing
        Me.BasicLabel12.ValueScaleFactor = 1.0R
        Me.BasicLabel12.ValueSuffix = "%"
        Me.BasicLabel12.ValueToSubtractFrom = 0!
        '
        'OrientedTextLabel7
        '
        resources.ApplyResources(Me.OrientedTextLabel7, "OrientedTextLabel7")
        Me.OrientedTextLabel7.Name = "OrientedTextLabel7"
        Me.OrientedTextLabel7.RotationAngle = 0R
        Me.OrientedTextLabel7.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel7.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel6
        '
        resources.ApplyResources(Me.OrientedTextLabel6, "OrientedTextLabel6")
        Me.OrientedTextLabel6.Name = "OrientedTextLabel6"
        Me.OrientedTextLabel6.RotationAngle = 0R
        Me.OrientedTextLabel6.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel6.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel5
        '
        resources.ApplyResources(Me.OrientedTextLabel5, "OrientedTextLabel5")
        Me.OrientedTextLabel5.Name = "OrientedTextLabel5"
        Me.OrientedTextLabel5.RotationAngle = 0R
        Me.OrientedTextLabel5.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel5.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel4
        '
        resources.ApplyResources(Me.OrientedTextLabel4, "OrientedTextLabel4")
        Me.OrientedTextLabel4.Name = "OrientedTextLabel4"
        Me.OrientedTextLabel4.RotationAngle = 0R
        Me.OrientedTextLabel4.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel4.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel3
        '
        resources.ApplyResources(Me.OrientedTextLabel3, "OrientedTextLabel3")
        Me.OrientedTextLabel3.Name = "OrientedTextLabel3"
        Me.OrientedTextLabel3.RotationAngle = 0R
        Me.OrientedTextLabel3.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel3.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'BasicLabel11
        '
        resources.ApplyResources(Me.BasicLabel11, "BasicLabel11")
        Me.BasicLabel11.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BasicLabel11.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel11.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel11.DisplayAsTime = False
        Me.BasicLabel11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BasicLabel11.Highlight = False
        Me.BasicLabel11.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel11.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel11.HighlightKeyCharacter = "!"
        Me.BasicLabel11.InterpretValueAsBCD = False
        Me.BasicLabel11.KeypadAlphaNumeric = False
        Me.BasicLabel11.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel11.KeypadMaxValue = 0R
        Me.BasicLabel11.KeypadMinValue = 0R
        Me.BasicLabel11.KeypadScaleFactor = 1.0R
        Me.BasicLabel11.KeypadShowCurrentValue = False
        Me.BasicLabel11.KeypadText = Nothing
        Me.BasicLabel11.KeypadWidth = 300
        Me.BasicLabel11.Name = "BasicLabel11"
        Me.BasicLabel11.NumericFormat = "F"
        Me.BasicLabel11.PLCAddressKeypad = ""
        Me.BasicLabel11.PLCAddressValue = "HMI_Commanded_Torque"
        Me.BasicLabel11.PollRate = 0
        Me.BasicLabel11.Value = "0"
        Me.BasicLabel11.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel11.ValueLeftPadLength = 0
        Me.BasicLabel11.ValuePrefix = Nothing
        Me.BasicLabel11.ValueScaleFactor = 1.0R
        Me.BasicLabel11.ValueSuffix = "%"
        Me.BasicLabel11.ValueToSubtractFrom = 0!
        '
        'DataLink1
        '
        Me.DataLink1.Name = "DataLink1"
        Me.DataLink1.Owner = Me
        '
        'DataLink2
        '
        Me.DataLink2.Name = "DataLink2"
        Me.DataLink2.Owner = Me
        '
        'aaMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ControlBox = False
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aaMain"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataLink1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLink2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents Odometer1 As AdvancedHMIControls.Odometer
    Friend WithEvents MbReset As AdvancedHMIControls.MomentaryButton
    Friend WithEvents MbStop As AdvancedHMIControls.MomentaryButton
    Friend WithEvents LblMainRetention As AdvancedHMIControls.BasicLabel
    Friend WithEvents MbStart As AdvancedHMIControls.MomentaryButton
    Friend WithEvents LblMainSPDisp As AdvancedHMIControls.BasicLabel
    Friend WithEvents LblMainSpeedMan As AdvancedHMIControls.BasicLabel
    Friend WithEvents OrientedTextLabel2 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents Motor2 As AdvancedHMIControls.Motor
    Friend WithEvents OrientedTextLabel1 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents Motor1 As AdvancedHMIControls.Motor
    Friend WithEvents ThreeButtonPLC1 As AdvancedHMIControls.ThreeButtonPLC
    Friend WithEvents Ind_Runnign As AdvancedHMIControls.BasicIndicator
    Friend WithEvents BasicLabel2 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel3 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel4 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel5 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel6 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel7 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel8 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel9 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel1 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel10 As AdvancedHMIControls.BasicLabel
    Friend WithEvents MessageDisplayByValue2 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents tbMachineActivity As TextBox
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents OrientedTextLabel7 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel6 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel5 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel4 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel3 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents BasicLabel11 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BtnLogin As Button
    Friend WithEvents DataLink1 As Devart.Data.DataLink
    Friend WithEvents DataLink2 As Devart.Data.DataLink
    Friend WithEvents OrientedTextLabel8 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents BasicLabel12 As AdvancedHMIControls.BasicLabel
    Friend WithEvents TB_Activity As TextBox
End Class
