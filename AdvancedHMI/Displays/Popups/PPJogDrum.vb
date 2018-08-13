Public Class PPJogDrum
    Private Sub PPJogDrum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EthernetIPforCLXCom1.IPAddress = Globals.AppConfigini.ReadValue("Settings", "IPAddress")

        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ControlBox = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.Dock = DockStyle.Fill
    End Sub

    Private NotFirstShow As Boolean
    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        '* Do not start comms on first show in case it was set to disable in design mode
        If NotFirstShow Then
            AdvancedHMIDrivers.Utilities.StopComsOnHidden(components, Me)
        Else
            NotFirstShow = True
        End If
    End Sub

    Private Sub BtnJogDrumExit_Click(sender As Object, e As EventArgs) Handles BtnJogDrumExit.Click
        Me.Close()
        Me.components.Dispose()
    End Sub


End Class