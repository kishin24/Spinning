<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PPIntraloxData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PPIntraloxData))
        Me.WebBrowserIloxData = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'WebBrowserIloxData
        '
        Me.WebBrowserIloxData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowserIloxData.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowserIloxData.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserIloxData.Name = "WebBrowserIloxData"
        Me.WebBrowserIloxData.Size = New System.Drawing.Size(1294, 688)
        Me.WebBrowserIloxData.TabIndex = 0
        Me.WebBrowserIloxData.Url = New System.Uri("https://intraloxsensing.herokuapp.com/sign-in", System.UriKind.Absolute)
        '
        'PPIntraloxData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1294, 688)
        Me.Controls.Add(Me.WebBrowserIloxData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PPIntraloxData"
        Me.Text = "Intralox Data Portal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowserIloxData As WebBrowser
End Class
