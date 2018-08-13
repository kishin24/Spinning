Public Class CTools
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

    Private Sub CModes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EthernetIPforCLXCom1.IPAddress = Globals.AppConfigini.ReadValue("Settings", "IPAddress")

    End Sub

    Private Sub BtnToolsSchem_Click(sender As Object, e As EventArgs) Handles BtnToolsSchem.Click
        PPSchematics.Show()
        PPSchematics.BringToFront()
        PPSchematics.Focus()
        PPSchematics.AxSchem.src = Globals.MachineSchematics

    End Sub

    Private Sub BtnToolsSensorCloud_Click(sender As Object, e As EventArgs) Handles BtnToolsSensorCloud.Click
        PPSensorCloud.Show()
        PPSensorCloud.BringToFront()
        PPSensorCloud.Focus()
    End Sub

    Private Sub BtnToolsIlox_Click(sender As Object, e As EventArgs) Handles BtnToolsIlox.Click
        PPIntraloxData.Show()
        PPIntraloxData.BringToFront()
        PPIntraloxData.Focus()
    End Sub

    Private Sub BtnToolsTCS_Click(sender As Object, e As EventArgs) Handles BtnToolsTCS.Click
        PPTCS.Show()
        PPTCS.BringToFront()
        PPTCS.Focus()
        PPTCS.AxTCS.src = Globals.TCSCommissioning
    End Sub

    Private Sub BtnToolsABBManual_Click(sender As Object, e As EventArgs) Handles BtnToolsABBManual.Click
        PPABB.Show()
        PPABB.BringToFront()
        PPABB.Focus()
        PPABB.AxABB.src = Globals.ABBManual
    End Sub

    Private Sub BtnToolsPF70Manual_Click(sender As Object, e As EventArgs) Handles BtnToolsPF70Manual.Click
        PPPF70.Show()
        PPPF70.BringToFront()
        PPPF70.Focus()
        PPPF70.AxPF70.src = Globals.PF70Manual
    End Sub

    Private Sub CTools_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Me.components.Dispose()
    End Sub
End Class