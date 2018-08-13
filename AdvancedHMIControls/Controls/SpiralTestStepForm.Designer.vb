<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpiralTestStepForm
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BasicLabel8 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel7 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel6 = New AdvancedHMIControls.BasicLabel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BasicLabel1 = New AdvancedHMIControls.BasicLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadioButton6 = New AdvancedHMIControls.RadioButton()
        Me.RadioButton5 = New AdvancedHMIControls.RadioButton()
        Me.RadioButton3 = New AdvancedHMIControls.RadioButton()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        'BasicLabel8
        '
        Me.BasicLabel8.BackColor = System.Drawing.Color.Black
        Me.BasicLabel8.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel8.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel8.DisplayAsTime = False
        Me.BasicLabel8.ForeColor = System.Drawing.Color.White
        Me.BasicLabel8.Highlight = False
        Me.BasicLabel8.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel8.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel8.HighlightKeyCharacter = "!"
        Me.BasicLabel8.InterpretValueAsBCD = False
        Me.BasicLabel8.KeypadAlphaNumeric = False
        Me.BasicLabel8.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel8.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel8.KeypadMaxValue = 7500.0R
        Me.BasicLabel8.KeypadMinValue = 0R
        Me.BasicLabel8.KeypadScaleFactor = 1.0R
        Me.BasicLabel8.KeypadShowCurrentValue = False
        Me.BasicLabel8.KeypadText = Nothing
        Me.BasicLabel8.KeypadWidth = 300
        Me.BasicLabel8.Location = New System.Drawing.Point(292, 32)
        Me.BasicLabel8.Name = "BasicLabel8"
        Me.BasicLabel8.NumericFormat = "F"
        Me.BasicLabel8.PLCAddressKeypad = ""
        Me.BasicLabel8.PollRate = 0
        Me.BasicLabel8.Size = New System.Drawing.Size(99, 36)
        Me.BasicLabel8.TabIndex = 380
        Me.BasicLabel8.Value = ""
        Me.BasicLabel8.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel8.ValueLeftPadLength = 0
        Me.BasicLabel8.ValuePrefix = Nothing
        Me.BasicLabel8.ValueScaleFactor = 1.0R
        Me.BasicLabel8.ValueSuffix = Nothing
        Me.BasicLabel8.ValueToSubtractFrom = 0!
        '
        'BasicLabel7
        '
        Me.BasicLabel7.BackColor = System.Drawing.Color.Black
        Me.BasicLabel7.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel7.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel7.DisplayAsTime = False
        Me.BasicLabel7.ForeColor = System.Drawing.Color.White
        Me.BasicLabel7.Highlight = False
        Me.BasicLabel7.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel7.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel7.HighlightKeyCharacter = "!"
        Me.BasicLabel7.InterpretValueAsBCD = False
        Me.BasicLabel7.KeypadAlphaNumeric = False
        Me.BasicLabel7.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel7.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel7.KeypadMaxValue = 80.0R
        Me.BasicLabel7.KeypadMinValue = 0R
        Me.BasicLabel7.KeypadScaleFactor = 1.0R
        Me.BasicLabel7.KeypadShowCurrentValue = False
        Me.BasicLabel7.KeypadText = Nothing
        Me.BasicLabel7.KeypadWidth = 300
        Me.BasicLabel7.Location = New System.Drawing.Point(156, 32)
        Me.BasicLabel7.Name = "BasicLabel7"
        Me.BasicLabel7.NumericFormat = "F"
        Me.BasicLabel7.PLCAddressKeypad = "TestSettingsHMI[0].Speed_Hz"
        Me.BasicLabel7.PLCAddressValue = "TestSettingsHMI[0].Speed_Hz"
        Me.BasicLabel7.PollRate = 0
        Me.BasicLabel7.Size = New System.Drawing.Size(99, 36)
        Me.BasicLabel7.TabIndex = 379
        Me.BasicLabel7.Value = ""
        Me.BasicLabel7.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel7.ValueLeftPadLength = 0
        Me.BasicLabel7.ValuePrefix = Nothing
        Me.BasicLabel7.ValueScaleFactor = 1.0R
        Me.BasicLabel7.ValueSuffix = Nothing
        Me.BasicLabel7.ValueToSubtractFrom = 0!
        '
        'BasicLabel6
        '
        Me.BasicLabel6.BackColor = System.Drawing.Color.Black
        Me.BasicLabel6.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel6.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel6.DisplayAsTime = False
        Me.BasicLabel6.ForeColor = System.Drawing.Color.White
        Me.BasicLabel6.Highlight = False
        Me.BasicLabel6.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel6.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel6.HighlightKeyCharacter = "!"
        Me.BasicLabel6.InterpretValueAsBCD = False
        Me.BasicLabel6.KeypadAlphaNumeric = False
        Me.BasicLabel6.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel6.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel6.KeypadMaxValue = 200.0R
        Me.BasicLabel6.KeypadMinValue = 0R
        Me.BasicLabel6.KeypadScaleFactor = 1.0R
        Me.BasicLabel6.KeypadShowCurrentValue = False
        Me.BasicLabel6.KeypadText = Nothing
        Me.BasicLabel6.KeypadWidth = 300
        Me.BasicLabel6.Location = New System.Drawing.Point(20, 32)
        Me.BasicLabel6.Name = "BasicLabel6"
        Me.BasicLabel6.NumericFormat = "F"
        Me.BasicLabel6.PLCAddressKeypad = ""
        Me.BasicLabel6.PollRate = 0
        Me.BasicLabel6.Size = New System.Drawing.Size(99, 36)
        Me.BasicLabel6.TabIndex = 373
        Me.BasicLabel6.Value = ""
        Me.BasicLabel6.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel6.ValueLeftPadLength = 0
        Me.BasicLabel6.ValuePrefix = Nothing
        Me.BasicLabel6.ValueScaleFactor = 1.0R
        Me.BasicLabel6.ValueSuffix = Nothing
        Me.BasicLabel6.ValueToSubtractFrom = 0!
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
        'BasicLabel1
        '
        Me.BasicLabel1.BackColor = System.Drawing.Color.Black
        Me.BasicLabel1.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel1.DisplayAsTime = False
        Me.BasicLabel1.ForeColor = System.Drawing.Color.White
        Me.BasicLabel1.Highlight = False
        Me.BasicLabel1.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel1.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel1.HighlightKeyCharacter = "!"
        Me.BasicLabel1.InterpretValueAsBCD = False
        Me.BasicLabel1.KeypadAlphaNumeric = False
        Me.BasicLabel1.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel1.KeypadMaxValue = 7500.0R
        Me.BasicLabel1.KeypadMinValue = 0R
        Me.BasicLabel1.KeypadScaleFactor = 1.0R
        Me.BasicLabel1.KeypadShowCurrentValue = False
        Me.BasicLabel1.KeypadText = Nothing
        Me.BasicLabel1.KeypadWidth = 300
        Me.BasicLabel1.Location = New System.Drawing.Point(428, 32)
        Me.BasicLabel1.Name = "BasicLabel1"
        Me.BasicLabel1.NumericFormat = "F"
        Me.BasicLabel1.PLCAddressKeypad = ""
        Me.BasicLabel1.PollRate = 0
        Me.BasicLabel1.Size = New System.Drawing.Size(99, 36)
        Me.BasicLabel1.TabIndex = 381
        Me.BasicLabel1.Value = ""
        Me.BasicLabel1.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel1.ValueLeftPadLength = 0
        Me.BasicLabel1.ValuePrefix = Nothing
        Me.BasicLabel1.ValueScaleFactor = 1.0R
        Me.BasicLabel1.ValueSuffix = Nothing
        Me.BasicLabel1.ValueToSubtractFrom = 0!
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RadioButton6)
        Me.Panel2.Controls.Add(Me.RadioButton5)
        Me.Panel2.Controls.Add(Me.RadioButton3)
        Me.Panel2.Location = New System.Drawing.Point(589, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(90, 71)
        Me.Panel2.TabIndex = 379
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.ComComponent = Me.EthernetIPforCLXCom1
        Me.RadioButton6.Location = New System.Drawing.Point(3, 52)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.PLCAddressCheckChanged = ""
        Me.RadioButton6.PLCAddressChecked = ""
        Me.RadioButton6.PLCAddressText = ""
        Me.RadioButton6.PLCAddressVisible = ""
        Me.RadioButton6.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton6.TabIndex = 2
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Torque"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.ComComponent = Me.EthernetIPforCLXCom1
        Me.RadioButton5.Location = New System.Drawing.Point(3, 29)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.PLCAddressCheckChanged = ""
        Me.RadioButton5.PLCAddressChecked = ""
        Me.RadioButton5.PLCAddressText = ""
        Me.RadioButton5.PLCAddressVisible = ""
        Me.RadioButton5.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton5.TabIndex = 1
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Torque"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ComComponent = Me.EthernetIPforCLXCom1
        Me.RadioButton3.Location = New System.Drawing.Point(3, 6)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.PLCAddressCheckChanged = ""
        Me.RadioButton3.PLCAddressChecked = ""
        Me.RadioButton3.PLCAddressText = ""
        Me.RadioButton3.PLCAddressVisible = ""
        Me.RadioButton3.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton3.TabIndex = 0
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Max"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'SpiraTestSteps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BasicLabel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BasicLabel7)
        Me.Controls.Add(Me.BasicLabel6)
        Me.Controls.Add(Me.BasicLabel8)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Name = "SpiraTestSteps"
        Me.Size = New System.Drawing.Size(687, 133)
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents BasicLabel8 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel7 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel6 As AdvancedHMIControls.BasicLabel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents BasicLabel1 As AdvancedHMIControls.BasicLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButton6 As AdvancedHMIControls.RadioButton
    Friend WithEvents RadioButton5 As AdvancedHMIControls.RadioButton
    Friend WithEvents RadioButton3 As AdvancedHMIControls.RadioButton
End Class
