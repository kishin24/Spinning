<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PPTCS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PPTCS))
        Me.AxTCS = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.AxTCS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxTCS
        '
        Me.AxTCS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxTCS.Enabled = True
        Me.AxTCS.Location = New System.Drawing.Point(0, 0)
        Me.AxTCS.Name = "AxTCS"
        Me.AxTCS.OcxState = CType(resources.GetObject("AxTCS.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxTCS.Size = New System.Drawing.Size(1178, 626)
        Me.AxTCS.TabIndex = 0
        '
        'PPTCS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 626)
        Me.Controls.Add(Me.AxTCS)
        Me.Name = "PPTCS"
        Me.Text = "PPTCS"
        CType(Me.AxTCS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxTCS As AxAcroPDFLib.AxAcroPDF
End Class
