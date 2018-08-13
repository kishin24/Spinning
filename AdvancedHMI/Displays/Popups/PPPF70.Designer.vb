<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PPPF70
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PPPF70))
        Me.AxPF70 = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.AxPF70, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxPF70
        '
        Me.AxPF70.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxPF70.Enabled = True
        Me.AxPF70.Location = New System.Drawing.Point(0, 0)
        Me.AxPF70.Name = "AxPF70"
        Me.AxPF70.OcxState = CType(resources.GetObject("AxPF70.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxPF70.Size = New System.Drawing.Size(1219, 687)
        Me.AxPF70.TabIndex = 0
        '
        'PPPF70
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 687)
        Me.Controls.Add(Me.AxPF70)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PPPF70"
        Me.Text = "PowerFlex 70 User Manual"
        CType(Me.AxPF70, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxPF70 As AxAcroPDFLib.AxAcroPDF
End Class
