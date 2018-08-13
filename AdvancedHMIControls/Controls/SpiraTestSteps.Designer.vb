<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SpiraTestSteps
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RBtnTrq = New AdvancedHMIControls.RadioButton()
        Me.RBtnSpeed = New AdvancedHMIControls.RadioButton()
        Me.RBtnMax = New AdvancedHMIControls.RadioButton()
        Me.LblStepsScaling = New AdvancedHMIControls.BasicLabel()
        Me.LblStepsSpeed = New AdvancedHMIControls.BasicLabel()
        Me.Lblstepstorque = New AdvancedHMIControls.BasicLabel()
        Me.LblStepsDuration = New AdvancedHMIControls.BasicLabel()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "172.16.30.51"
        Me.EthernetIPforCLXCom1.PollRateOverride = 500
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(427, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 20)
        Me.Label10.TabIndex = 371
        Me.Label10.Text = "Speed Scaling"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(291, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 20)
        Me.Label13.TabIndex = 369
        Me.Label13.Text = "Duration (Min)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 20)
        Me.Label14.TabIndex = 365
        Me.Label14.Text = "Torque Setpoint"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(155, 77)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 20)
        Me.Label15.TabIndex = 367
        Me.Label15.Text = "Speed (Hz)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RBtnTrq
        '
        Me.RBtnTrq.AutoSize = True
        Me.RBtnTrq.ComComponent = Me.EthernetIPforCLXCom1
        Me.RBtnTrq.Location = New System.Drawing.Point(591, 51)
        Me.RBtnTrq.Name = "RBtnTrq"
        Me.RBtnTrq.PLCAddressCheckChanged = ""
        Me.RBtnTrq.PLCAddressChecked = ""
        Me.RBtnTrq.PLCAddressText = ""
        Me.RBtnTrq.PLCAddressVisible = ""
        Me.RBtnTrq.Size = New System.Drawing.Size(59, 17)
        Me.RBtnTrq.TabIndex = 1
        Me.RBtnTrq.Text = "Torque"
        Me.RBtnTrq.UseVisualStyleBackColor = True
        '
        'RBtnSpeed
        '
        Me.RBtnSpeed.AutoSize = True
        Me.RBtnSpeed.ComComponent = Me.EthernetIPforCLXCom1
        Me.RBtnSpeed.Location = New System.Drawing.Point(591, 74)
        Me.RBtnSpeed.Name = "RBtnSpeed"
        Me.RBtnSpeed.PLCAddressCheckChanged = ""
        Me.RBtnSpeed.PLCAddressChecked = ""
        Me.RBtnSpeed.PLCAddressText = ""
        Me.RBtnSpeed.PLCAddressVisible = ""
        Me.RBtnSpeed.Size = New System.Drawing.Size(56, 17)
        Me.RBtnSpeed.TabIndex = 2
        Me.RBtnSpeed.Text = "Speed"
        Me.RBtnSpeed.UseVisualStyleBackColor = True
        '
        'RBtnMax
        '
        Me.RBtnMax.AutoSize = True
        Me.RBtnMax.ComComponent = Me.EthernetIPforCLXCom1
        Me.RBtnMax.Location = New System.Drawing.Point(591, 30)
        Me.RBtnMax.Name = "RBtnMax"
        Me.RBtnMax.PLCAddressCheckChanged = ""
        Me.RBtnMax.PLCAddressChecked = ""
        Me.RBtnMax.PLCAddressText = ""
        Me.RBtnMax.PLCAddressVisible = ""
        Me.RBtnMax.Size = New System.Drawing.Size(45, 17)
        Me.RBtnMax.TabIndex = 0
        Me.RBtnMax.Text = "Max"
        Me.RBtnMax.UseVisualStyleBackColor = True
        '
        'LblStepsScaling
        '
        Me.LblStepsScaling.BackColor = System.Drawing.Color.Black
        Me.LblStepsScaling.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.LblStepsScaling.ComComponent = Me.EthernetIPforCLXCom1
        Me.LblStepsScaling.DisplayAsTime = False
        Me.LblStepsScaling.ForeColor = System.Drawing.Color.White
        Me.LblStepsScaling.Highlight = False
        Me.LblStepsScaling.HighlightColor = System.Drawing.Color.Red
        Me.LblStepsScaling.HighlightForeColor = System.Drawing.Color.White
        Me.LblStepsScaling.HighlightKeyCharacter = "!"
        Me.LblStepsScaling.InterpretValueAsBCD = False
        Me.LblStepsScaling.KeypadAlphaNumeric = False
        Me.LblStepsScaling.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.LblStepsScaling.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.LblStepsScaling.KeypadMaxValue = 3000.0R
        Me.LblStepsScaling.KeypadMinValue = 0R
        Me.LblStepsScaling.KeypadScaleFactor = 1.0R
        Me.LblStepsScaling.KeypadShowCurrentValue = False
        Me.LblStepsScaling.KeypadText = Nothing
        Me.LblStepsScaling.KeypadWidth = 300
        Me.LblStepsScaling.Location = New System.Drawing.Point(428, 32)
        Me.LblStepsScaling.Name = "LblStepsScaling"
        Me.LblStepsScaling.NumericFormat = "F"
        Me.LblStepsScaling.PLCAddressKeypad = ""
        Me.LblStepsScaling.PollRate = 0
        Me.LblStepsScaling.Size = New System.Drawing.Size(99, 36)
        Me.LblStepsScaling.TabIndex = 381
        Me.LblStepsScaling.Value = ""
        Me.LblStepsScaling.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.LblStepsScaling.ValueLeftPadLength = 0
        Me.LblStepsScaling.ValuePrefix = Nothing
        Me.LblStepsScaling.ValueScaleFactor = 1.0R
        Me.LblStepsScaling.ValueSuffix = Nothing
        Me.LblStepsScaling.ValueToSubtractFrom = 0!
        '
        'LblStepsSpeed
        '
        Me.LblStepsSpeed.BackColor = System.Drawing.Color.Black
        Me.LblStepsSpeed.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.LblStepsSpeed.ComComponent = Me.EthernetIPforCLXCom1
        Me.LblStepsSpeed.DisplayAsTime = False
        Me.LblStepsSpeed.ForeColor = System.Drawing.Color.White
        Me.LblStepsSpeed.Highlight = False
        Me.LblStepsSpeed.HighlightColor = System.Drawing.Color.Red
        Me.LblStepsSpeed.HighlightForeColor = System.Drawing.Color.White
        Me.LblStepsSpeed.HighlightKeyCharacter = "!"
        Me.LblStepsSpeed.InterpretValueAsBCD = False
        Me.LblStepsSpeed.KeypadAlphaNumeric = False
        Me.LblStepsSpeed.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.LblStepsSpeed.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.LblStepsSpeed.KeypadMaxValue = 80.0R
        Me.LblStepsSpeed.KeypadMinValue = 0R
        Me.LblStepsSpeed.KeypadScaleFactor = 1.0R
        Me.LblStepsSpeed.KeypadShowCurrentValue = False
        Me.LblStepsSpeed.KeypadText = Nothing
        Me.LblStepsSpeed.KeypadWidth = 300
        Me.LblStepsSpeed.Location = New System.Drawing.Point(156, 32)
        Me.LblStepsSpeed.Name = "LblStepsSpeed"
        Me.LblStepsSpeed.NumericFormat = "F"
        Me.LblStepsSpeed.PLCAddressKeypad = ""
        Me.LblStepsSpeed.PollRate = 0
        Me.LblStepsSpeed.Size = New System.Drawing.Size(99, 36)
        Me.LblStepsSpeed.TabIndex = 379
        Me.LblStepsSpeed.Value = ""
        Me.LblStepsSpeed.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.LblStepsSpeed.ValueLeftPadLength = 0
        Me.LblStepsSpeed.ValuePrefix = Nothing
        Me.LblStepsSpeed.ValueScaleFactor = 1.0R
        Me.LblStepsSpeed.ValueSuffix = Nothing
        Me.LblStepsSpeed.ValueToSubtractFrom = 0!
        '
        'Lblstepstorque
        '
        Me.Lblstepstorque.BackColor = System.Drawing.Color.Black
        Me.Lblstepstorque.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.Lblstepstorque.ComComponent = Me.EthernetIPforCLXCom1
        Me.Lblstepstorque.DisplayAsTime = False
        Me.Lblstepstorque.ForeColor = System.Drawing.Color.White
        Me.Lblstepstorque.Highlight = False
        Me.Lblstepstorque.HighlightColor = System.Drawing.Color.Red
        Me.Lblstepstorque.HighlightForeColor = System.Drawing.Color.White
        Me.Lblstepstorque.HighlightKeyCharacter = "!"
        Me.Lblstepstorque.InterpretValueAsBCD = False
        Me.Lblstepstorque.KeypadAlphaNumeric = False
        Me.Lblstepstorque.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.Lblstepstorque.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.Lblstepstorque.KeypadMaxValue = 150.0R
        Me.Lblstepstorque.KeypadMinValue = 0R
        Me.Lblstepstorque.KeypadScaleFactor = 1.0R
        Me.Lblstepstorque.KeypadShowCurrentValue = False
        Me.Lblstepstorque.KeypadText = Nothing
        Me.Lblstepstorque.KeypadWidth = 300
        Me.Lblstepstorque.Location = New System.Drawing.Point(20, 32)
        Me.Lblstepstorque.Name = "Lblstepstorque"
        Me.Lblstepstorque.NumericFormat = "F"
        Me.Lblstepstorque.PLCAddressKeypad = ""
        Me.Lblstepstorque.PollRate = 0
        Me.Lblstepstorque.Size = New System.Drawing.Size(99, 36)
        Me.Lblstepstorque.TabIndex = 373
        Me.Lblstepstorque.Value = ""
        Me.Lblstepstorque.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.Lblstepstorque.ValueLeftPadLength = 0
        Me.Lblstepstorque.ValuePrefix = Nothing
        Me.Lblstepstorque.ValueScaleFactor = 1.0R
        Me.Lblstepstorque.ValueSuffix = Nothing
        Me.Lblstepstorque.ValueToSubtractFrom = 0!
        '
        'LblStepsDuration
        '
        Me.LblStepsDuration.BackColor = System.Drawing.Color.Black
        Me.LblStepsDuration.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.LblStepsDuration.ComComponent = Me.EthernetIPforCLXCom1
        Me.LblStepsDuration.DisplayAsTime = False
        Me.LblStepsDuration.ForeColor = System.Drawing.Color.White
        Me.LblStepsDuration.Highlight = False
        Me.LblStepsDuration.HighlightColor = System.Drawing.Color.Red
        Me.LblStepsDuration.HighlightForeColor = System.Drawing.Color.White
        Me.LblStepsDuration.HighlightKeyCharacter = "!"
        Me.LblStepsDuration.InterpretValueAsBCD = False
        Me.LblStepsDuration.KeypadAlphaNumeric = False
        Me.LblStepsDuration.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.LblStepsDuration.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.LblStepsDuration.KeypadMaxValue = 7500.0R
        Me.LblStepsDuration.KeypadMinValue = 0R
        Me.LblStepsDuration.KeypadScaleFactor = 1.0R
        Me.LblStepsDuration.KeypadShowCurrentValue = False
        Me.LblStepsDuration.KeypadText = Nothing
        Me.LblStepsDuration.KeypadWidth = 300
        Me.LblStepsDuration.Location = New System.Drawing.Point(292, 32)
        Me.LblStepsDuration.Name = "LblStepsDuration"
        Me.LblStepsDuration.NumericFormat = "F"
        Me.LblStepsDuration.PLCAddressKeypad = ""
        Me.LblStepsDuration.PollRate = 0
        Me.LblStepsDuration.Size = New System.Drawing.Size(99, 36)
        Me.LblStepsDuration.TabIndex = 380
        Me.LblStepsDuration.Value = ""
        Me.LblStepsDuration.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.LblStepsDuration.ValueLeftPadLength = 0
        Me.LblStepsDuration.ValuePrefix = Nothing
        Me.LblStepsDuration.ValueScaleFactor = 1.0R
        Me.LblStepsDuration.ValueSuffix = Nothing
        Me.LblStepsDuration.ValueToSubtractFrom = 0!
        '
        'SpiraTestSteps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RBtnSpeed)
        Me.Controls.Add(Me.RBtnTrq)
        Me.Controls.Add(Me.LblStepsScaling)
        Me.Controls.Add(Me.RBtnMax)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LblStepsSpeed)
        Me.Controls.Add(Me.Lblstepstorque)
        Me.Controls.Add(Me.LblStepsDuration)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Name = "SpiraTestSteps"
        Me.Size = New System.Drawing.Size(671, 111)
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    'Friend WithEvents RadioButton2 As RadioButton
    'Friend WithEvents RadioButton1 As RadioButton
    'Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents LblStepsDuration As AdvancedHMIControls.BasicLabel
    Friend WithEvents LblStepsSpeed As AdvancedHMIControls.BasicLabel
    Friend WithEvents Lblstepstorque As AdvancedHMIControls.BasicLabel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LblStepsScaling As AdvancedHMIControls.BasicLabel
    Friend WithEvents RBtnSpeed As AdvancedHMIControls.RadioButton
    Friend WithEvents RBtnTrq As AdvancedHMIControls.RadioButton
    Friend WithEvents RBtnMax As AdvancedHMIControls.RadioButton
End Class
