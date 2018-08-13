<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CTools
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CTools))
        Me.LblTools = New System.Windows.Forms.Label()
        Me.BtnToolsSchem = New System.Windows.Forms.Button()
        Me.BtnToolsPF70Manual = New System.Windows.Forms.Button()
        Me.BtnToolsTCS = New System.Windows.Forms.Button()
        Me.BtnToolsABBManual = New System.Windows.Forms.Button()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.LblToolsRef = New System.Windows.Forms.Label()
        Me.LblToolsSTG = New System.Windows.Forms.Label()
        Me.BtnToolsSensorCloud = New System.Windows.Forms.Button()
        Me.BtnToolsIlox = New System.Windows.Forms.Button()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTools
        '
        Me.LblTools.AutoSize = True
        Me.LblTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblTools.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTools.Location = New System.Drawing.Point(0, 0)
        Me.LblTools.Name = "LblTools"
        Me.LblTools.Size = New System.Drawing.Size(126, 37)
        Me.LblTools.TabIndex = 1
        Me.LblTools.Text = "TOOLS"
        Me.LblTools.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnToolsSchem
        '
        Me.BtnToolsSchem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnToolsSchem.Location = New System.Drawing.Point(10, 153)
        Me.BtnToolsSchem.Name = "BtnToolsSchem"
        Me.BtnToolsSchem.Size = New System.Drawing.Size(239, 70)
        Me.BtnToolsSchem.TabIndex = 2
        Me.BtnToolsSchem.Text = "Schematics"
        Me.BtnToolsSchem.UseVisualStyleBackColor = True
        '
        'BtnToolsPF70Manual
        '
        Me.BtnToolsPF70Manual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnToolsPF70Manual.Location = New System.Drawing.Point(12, 381)
        Me.BtnToolsPF70Manual.Name = "BtnToolsPF70Manual"
        Me.BtnToolsPF70Manual.Size = New System.Drawing.Size(239, 70)
        Me.BtnToolsPF70Manual.TabIndex = 3
        Me.BtnToolsPF70Manual.Text = "PowerFlex 70 Manual"
        Me.BtnToolsPF70Manual.UseVisualStyleBackColor = True
        '
        'BtnToolsTCS
        '
        Me.BtnToolsTCS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnToolsTCS.Location = New System.Drawing.Point(12, 229)
        Me.BtnToolsTCS.Name = "BtnToolsTCS"
        Me.BtnToolsTCS.Size = New System.Drawing.Size(239, 70)
        Me.BtnToolsTCS.TabIndex = 5
        Me.BtnToolsTCS.Text = "Tension Control Commissioning Procedures"
        Me.BtnToolsTCS.UseVisualStyleBackColor = True
        '
        'BtnToolsABBManual
        '
        Me.BtnToolsABBManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnToolsABBManual.Location = New System.Drawing.Point(12, 305)
        Me.BtnToolsABBManual.Name = "BtnToolsABBManual"
        Me.BtnToolsABBManual.Size = New System.Drawing.Size(239, 70)
        Me.BtnToolsABBManual.TabIndex = 6
        Me.BtnToolsABBManual.Text = "ACS880 Manual"
        Me.BtnToolsABBManual.UseVisualStyleBackColor = True
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
        'LblToolsRef
        '
        Me.LblToolsRef.AutoSize = True
        Me.LblToolsRef.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblToolsRef.Location = New System.Drawing.Point(57, 92)
        Me.LblToolsRef.Name = "LblToolsRef"
        Me.LblToolsRef.Size = New System.Drawing.Size(154, 34)
        Me.LblToolsRef.TabIndex = 7
        Me.LblToolsRef.Text = "References"
        '
        'LblToolsSTG
        '
        Me.LblToolsSTG.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblToolsSTG.AutoSize = True
        Me.LblToolsSTG.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblToolsSTG.Location = New System.Drawing.Point(645, 92)
        Me.LblToolsSTG.Name = "LblToolsSTG"
        Me.LblToolsSTG.Size = New System.Drawing.Size(325, 34)
        Me.LblToolsSTG.TabIndex = 8
        Me.LblToolsSTG.Text = "Spiral Technical Group"
        Me.LblToolsSTG.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnToolsSensorCloud
        '
        Me.BtnToolsSensorCloud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnToolsSensorCloud.Location = New System.Drawing.Point(631, 153)
        Me.BtnToolsSensorCloud.Name = "BtnToolsSensorCloud"
        Me.BtnToolsSensorCloud.Size = New System.Drawing.Size(239, 70)
        Me.BtnToolsSensorCloud.TabIndex = 9
        Me.BtnToolsSensorCloud.Text = "Sensor Cloud"
        Me.BtnToolsSensorCloud.UseVisualStyleBackColor = True
        '
        'BtnToolsIlox
        '
        Me.BtnToolsIlox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnToolsIlox.Location = New System.Drawing.Point(631, 229)
        Me.BtnToolsIlox.Name = "BtnToolsIlox"
        Me.BtnToolsIlox.Size = New System.Drawing.Size(239, 70)
        Me.BtnToolsIlox.TabIndex = 10
        Me.BtnToolsIlox.Text = "Intralox Data Portal"
        Me.BtnToolsIlox.UseVisualStyleBackColor = True
        '
        'CTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1417, 710)
        Me.Controls.Add(Me.BtnToolsIlox)
        Me.Controls.Add(Me.BtnToolsSensorCloud)
        Me.Controls.Add(Me.LblToolsSTG)
        Me.Controls.Add(Me.LblToolsRef)
        Me.Controls.Add(Me.BtnToolsABBManual)
        Me.Controls.Add(Me.BtnToolsTCS)
        Me.Controls.Add(Me.BtnToolsPF70Manual)
        Me.Controls.Add(Me.BtnToolsSchem)
        Me.Controls.Add(Me.LblTools)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CTools"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TOOLS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTools As Label
    Friend WithEvents BtnToolsSchem As Button
    Friend WithEvents BtnToolsPF70Manual As Button
    Friend WithEvents BtnToolsTCS As Button
    Friend WithEvents BtnToolsABBManual As Button
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents LblToolsRef As Label
    Friend WithEvents LblToolsSTG As Label
    Friend WithEvents BtnToolsSensorCloud As Button
    Friend WithEvents BtnToolsIlox As Button
End Class
