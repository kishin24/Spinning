<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PPTestComplete
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnPPTestExit = New AdvancedHMIControls.BasicButton()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BtnPPMailReport = New AdvancedHMIControls.BasicButton()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(561, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Test Completed Sucessfully! Would you like to e-mail a report?"
        '
        'BtnPPTestExit
        '
        Me.BtnPPTestExit.BackColor = System.Drawing.Color.Black
        Me.BtnPPTestExit.ComComponent = Me.EthernetIPforCLXCom1
        Me.BtnPPTestExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPPTestExit.ForeColor = System.Drawing.Color.Black
        Me.BtnPPTestExit.ForeColorAltername = System.Drawing.Color.Black
        Me.BtnPPTestExit.Highlight = False
        Me.BtnPPTestExit.HighlightColor = System.Drawing.Color.Green
        Me.BtnPPTestExit.Location = New System.Drawing.Point(341, 81)
        Me.BtnPPTestExit.MaximumHoldTime = 3000
        Me.BtnPPTestExit.MinimumHoldTime = 500
        Me.BtnPPTestExit.Name = "BtnPPTestExit"
        Me.BtnPPTestExit.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BtnPPTestExit.PLCAddressClick = ""
        Me.BtnPPTestExit.SelectTextAlternate = False
        Me.BtnPPTestExit.Size = New System.Drawing.Size(188, 51)
        Me.BtnPPTestExit.TabIndex = 1
        Me.BtnPPTestExit.Text = "EXIT"
        Me.BtnPPTestExit.TextAlternate = Nothing
        Me.BtnPPTestExit.UseVisualStyleBackColor = True
        Me.BtnPPTestExit.ValueToWrite = 0
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
        'BtnPPMailReport
        '
        Me.BtnPPMailReport.BackColor = System.Drawing.Color.Black
        Me.BtnPPMailReport.ComComponent = Me.EthernetIPforCLXCom1
        Me.BtnPPMailReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPPMailReport.ForeColor = System.Drawing.Color.Black
        Me.BtnPPMailReport.ForeColorAltername = System.Drawing.Color.Black
        Me.BtnPPMailReport.Highlight = False
        Me.BtnPPMailReport.HighlightColor = System.Drawing.Color.Green
        Me.BtnPPMailReport.Location = New System.Drawing.Point(12, 81)
        Me.BtnPPMailReport.MaximumHoldTime = 3000
        Me.BtnPPMailReport.MinimumHoldTime = 500
        Me.BtnPPMailReport.Name = "BtnPPMailReport"
        Me.BtnPPMailReport.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BtnPPMailReport.PLCAddressClick = ""
        Me.BtnPPMailReport.SelectTextAlternate = False
        Me.BtnPPMailReport.Size = New System.Drawing.Size(188, 51)
        Me.BtnPPMailReport.TabIndex = 2
        Me.BtnPPMailReport.Text = "E-Mail Report"
        Me.BtnPPMailReport.TextAlternate = Nothing
        Me.BtnPPMailReport.UseVisualStyleBackColor = True
        Me.BtnPPMailReport.ValueToWrite = 0
        '
        'PPTestComplete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 147)
        Me.Controls.Add(Me.BtnPPMailReport)
        Me.Controls.Add(Me.BtnPPTestExit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PPTestComplete"
        Me.Text = "PPTestComplete"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnPPTestExit As AdvancedHMIControls.BasicButton
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BtnPPMailReport As AdvancedHMIControls.BasicButton
End Class
