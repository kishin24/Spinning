Public Class PPJogTU

    Private Sub PPJogTU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EthernetIPforCLXCom1.IPAddress = Globals.AppConfigini.ReadValue("Settings", "IPAddress")

    End Sub



    Private Sub BtnJogDrumExit_Click(sender As Object, e As EventArgs) Handles BtnJogTakeupExit.Click
        Me.Close()
    End Sub
End Class