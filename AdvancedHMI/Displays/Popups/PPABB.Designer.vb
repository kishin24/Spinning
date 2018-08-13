<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PPABB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PPABB))
        Me.AxABB = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.AxABB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxABB
        '
        Me.AxABB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxABB.Enabled = True
        Me.AxABB.Location = New System.Drawing.Point(0, 0)
        Me.AxABB.Name = "AxABB"
        Me.AxABB.OcxState = CType(resources.GetObject("AxABB.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxABB.Size = New System.Drawing.Size(1177, 658)
        Me.AxABB.TabIndex = 0
        '
        'PPABB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 658)
        Me.Controls.Add(Me.AxABB)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PPABB"
        Me.Text = "ACS880-01 User Manual"
        CType(Me.AxABB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxABB As AxAcroPDFLib.AxAcroPDF
End Class
