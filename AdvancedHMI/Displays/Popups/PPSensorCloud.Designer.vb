<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PPSensorCloud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PPSensorCloud))
        Me.WebBrowserSensorCloud = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'WebBrowserSensorCloud
        '
        Me.WebBrowserSensorCloud.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowserSensorCloud.Location = New System.Drawing.Point(12, 12)
        Me.WebBrowserSensorCloud.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserSensorCloud.Name = "WebBrowserSensorCloud"
        Me.WebBrowserSensorCloud.Size = New System.Drawing.Size(1256, 797)
        Me.WebBrowserSensorCloud.TabIndex = 0
        Me.WebBrowserSensorCloud.Url = New System.Uri("https://sensorcloud.microstrain.com/SensorCloud/data/nola_freezer_temp/", System.UriKind.Absolute)
        '
        'PPSensorCloud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1293, 839)
        Me.Controls.Add(Me.WebBrowserSensorCloud)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PPSensorCloud"
        Me.Text = "Microstrain Sensor Cloud"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowserSensorCloud As WebBrowser
End Class
