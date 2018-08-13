<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DAlarms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DAlarms))
        Me.label_setup = New System.Windows.Forms.Label()
        Me.BtnAlmAck = New AdvancedHMIControls.BasicButton()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.BtnAlmClr = New AdvancedHMIControls.BasicButton()
        Me.MsgListAlm = New AdvancedHMIControls.MessageListByValue()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_setup
        '
        Me.label_setup.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_setup.AutoSize = True
        Me.label_setup.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_setup.Location = New System.Drawing.Point(581, 0)
        Me.label_setup.Name = "label_setup"
        Me.label_setup.Size = New System.Drawing.Size(148, 37)
        Me.label_setup.TabIndex = 1
        Me.label_setup.Text = "ALARMS"
        Me.label_setup.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnAlmAck
        '
        Me.BtnAlmAck.BackColor = System.Drawing.Color.Black
        Me.BtnAlmAck.ComComponent = Me.EthernetIPforCLXCom1
        Me.BtnAlmAck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlmAck.ForeColor = System.Drawing.Color.Black
        Me.BtnAlmAck.ForeColorAltername = System.Drawing.Color.Black
        Me.BtnAlmAck.Highlight = False
        Me.BtnAlmAck.HighlightColor = System.Drawing.Color.Green
        Me.BtnAlmAck.Location = New System.Drawing.Point(1013, 627)
        Me.BtnAlmAck.MaximumHoldTime = 3000
        Me.BtnAlmAck.MinimumHoldTime = 500
        Me.BtnAlmAck.Name = "BtnAlmAck"
        Me.BtnAlmAck.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BtnAlmAck.PLCAddressClick = ""
        Me.BtnAlmAck.SelectTextAlternate = False
        Me.BtnAlmAck.Size = New System.Drawing.Size(132, 38)
        Me.BtnAlmAck.TabIndex = 4
        Me.BtnAlmAck.Text = "ACKNOWLEDGE"
        Me.BtnAlmAck.TextAlternate = Nothing
        Me.BtnAlmAck.UseVisualStyleBackColor = True
        Me.BtnAlmAck.ValueToWrite = 0
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
        'BtnAlmClr
        '
        Me.BtnAlmClr.BackColor = System.Drawing.Color.Black
        Me.BtnAlmClr.ComComponent = Me.EthernetIPforCLXCom1
        Me.BtnAlmClr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlmClr.ForeColor = System.Drawing.Color.Black
        Me.BtnAlmClr.ForeColorAltername = System.Drawing.Color.Black
        Me.BtnAlmClr.Highlight = False
        Me.BtnAlmClr.HighlightColor = System.Drawing.Color.Green
        Me.BtnAlmClr.Location = New System.Drawing.Point(1151, 627)
        Me.BtnAlmClr.MaximumHoldTime = 3000
        Me.BtnAlmClr.MinimumHoldTime = 500
        Me.BtnAlmClr.Name = "BtnAlmClr"
        Me.BtnAlmClr.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BtnAlmClr.PLCAddressClick = ""
        Me.BtnAlmClr.SelectTextAlternate = False
        Me.BtnAlmClr.Size = New System.Drawing.Size(132, 38)
        Me.BtnAlmClr.TabIndex = 5
        Me.BtnAlmClr.Text = "CLEAR ALL"
        Me.BtnAlmClr.TextAlternate = Nothing
        Me.BtnAlmClr.UseVisualStyleBackColor = True
        Me.BtnAlmClr.ValueToWrite = 0
        '
        'MsgListAlm
        '
        Me.MsgListAlm.AllowDrop = True
        Me.MsgListAlm.ColumnWidth = 5
        Me.MsgListAlm.ComComponent = Me.EthernetIPforCLXCom1
        Me.MsgListAlm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MsgListAlm.FormattingEnabled = True
        Me.MsgListAlm.HorizontalExtent = 2
        Me.MsgListAlm.IniFileName = ".\Alarms.txt"
        Me.MsgListAlm.IntegralHeight = False
        Me.MsgListAlm.Location = New System.Drawing.Point(12, 62)
        Me.MsgListAlm.MaxMessagesInList = 50
        Me.MsgListAlm.MessageNumberToIgnore = 0
        Me.MsgListAlm.Name = "MsgListAlm"
        Me.MsgListAlm.PLCAddressValue = "Alarm_Register"
        Me.MsgListAlm.PLCAddressVisible = ""
        Me.MsgListAlm.RemoveDuplicateMessages = False
        Me.MsgListAlm.ScrollAlwaysVisible = True
        Me.MsgListAlm.ShowMessageNumber = True
        Me.MsgListAlm.ShowTimeStamp = True
        Me.MsgListAlm.Size = New System.Drawing.Size(1280, 559)
        Me.MsgListAlm.TabIndex = 6
        Me.MsgListAlm.TimeStampFormat = "MM/dd/yyyy HH:mm:ss"
        Me.MsgListAlm.Value = 0
        '
        'DAlarms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1413, 590)
        Me.Controls.Add(Me.MsgListAlm)
        Me.Controls.Add(Me.BtnAlmClr)
        Me.Controls.Add(Me.BtnAlmAck)
        Me.Controls.Add(Me.label_setup)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DAlarms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ALARMS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_setup As Label
    Friend WithEvents BtnAlmAck As AdvancedHMIControls.BasicButton
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents BtnAlmClr As AdvancedHMIControls.BasicButton
    Friend WithEvents MsgListAlm As AdvancedHMIControls.MessageListByValue
End Class
