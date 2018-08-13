Imports System.IO

Public Class DAlarms

    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private NotFirstShow As Boolean

    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        '* Do not start comms on first show in case it was set to disable in design mode
        If NotFirstShow Then
            AdvancedHMIDrivers.Utilities.StopComsOnHidden(components, Me)
        Else
            NotFirstShow = True
        End If
    End Sub

    Private Sub DAlarms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EthernetIPforCLXCom1.IPAddress = Globals.AppConfigini.ReadValue("Settings", "IPAddress")
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ControlBox = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    End Sub

    Private Sub DAlarms_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ControlBox = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    End Sub

    Private Sub DAlarms_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        System.Threading.Thread.Sleep(100)
        Me.components.Dispose()
    End Sub



    Private Sub MessageListByValue1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MsgListAlm.SelectedIndexChanged

    End Sub
End Class