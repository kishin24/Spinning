Imports System



#Region "Page Setup"
Public Class A_Main

    Private Sub A_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Globals.AppConfigini Is Nothing Then
            Globals.AppConfigini = New IniFile(Globals.AppConfigPath)
        End If

        EthernetIPforCLXCom1.IPAddress = Globals.AppConfigini.ReadValue("Settings", "IPAddress")
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None

        aaMain.MdiParent = Me
        BSetup.MdiParent = Me               'Sets all of the application forms as MDI Children 
        CTools.MdiParent = Me
        DAlarms.MdiParent = Me
        XAbout.MdiParent = Me
        YHelp.MdiParent = Me
        PPSchematics.MdiParent = Me
        PPCalendar.MdiParent = Me
        PPSensorCloud.MdiParent = Me
        PPIntraloxData.MdiParent = Me
        PPTCS.MdiParent = Me
        PPABB.MdiParent = Me
        PPPF70.MdiParent = Me
        aaMain.Show()
        aaMain.BringToFront()
        BSetup.Show()
        CTools.Show()
        DAlarms.Show()
        XAbout.Show()
        YHelp.Show()
        BSetup.Hide()
        CTools.Hide()
        DAlarms.Hide()
        XAbout.Hide()
        YHelp.Hide()
        MakeFullScreen()
    End Sub


    Private Sub MDIParent_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        components.Dispose()
        If Me.HasChildren = True Then
            For Each f As Form In Me.MdiChildren
                f.Dispose()


                'If (f.Controls.GetType()) Is IDisposable Then

                'End If
                'idispos = 
            Next
        End If

    End Sub



    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Public Sub MakeFullScreen()
        ' Hide the window borders.
        Me.FormBorderStyle = FormBorderStyle.None

        ' Change the size and location of the form so that it fills entire screen.
        ' (This works correctly with multiple monitors; the form fills the screen that it is on or closest to.)
        Dim rect As Rectangle = Screen.GetBounds(Me)
        Me.Location = rect.Location
        Me.Size = rect.Size
    End Sub

#End Region

#Region " Buttons "

    Private Sub BtnMain_Click(sender As Object, e As EventArgs)
        If Me.HasChildren = True Then
            For Each frm As Form In Me.MdiChildren
                If TypeOf (frm) Is aaMain Then
                    CType(frm, aaMain).BringToFront()
                    CType(frm, aaMain).Focus()
                    Me.Refresh()
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub BtnMain_Click_1(sender As Object, e As EventArgs) Handles btnMain8.Click
        If Me.HasChildren = True Then
            For Each frm As Form In Me.MdiChildren
                If TypeOf (frm) Is aaMain Then
                    CType(frm, aaMain).BringToFront()
                    CType(frm, aaMain).Focus()
                    Me.Refresh()
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub setupbtn_Click(sender As Object, e As EventArgs) Handles btnsetup8.Click
        If Me.HasChildren = True Then
            For Each frm As Form In Me.MdiChildren
                If TypeOf (frm) Is BSetup Then
                    CType(frm, BSetup).Show()
                    CType(frm, BSetup).BringToFront()
                    CType(frm, BSetup).Focus()
                    Me.Refresh()
                    Exit Sub
                End If

            Next
        End If
    End Sub

    Private Sub btnalarms8_Click(sender As Object, e As EventArgs) Handles btnalarms8.Click
        If Me.HasChildren = True Then
            For Each frm As Form In Me.MdiChildren
                If TypeOf (frm) Is DAlarms Then
                    CType(frm, DAlarms).Show()
                    CType(frm, DAlarms).BringToFront()
                    CType(frm, DAlarms).Focus()
                    Me.Refresh()
                    Exit Sub
                End If

            Next
        End If
    End Sub

    Private Sub btnTools_Click(sender As Object, e As EventArgs) Handles btnTools.Click
        If Me.HasChildren = True Then
            For Each frm As Form In Me.MdiChildren
                If TypeOf (frm) Is CTools Then
                    CType(frm, CTools).Show()
                    CType(frm, CTools).BringToFront()
                    CType(frm, CTools).Focus()
                    Me.Refresh()
                    Exit Sub
                End If

            Next
        End If
    End Sub

    Private Sub btnABout_Click(sender As Object, e As EventArgs) Handles btnABout.Click
        If Me.HasChildren = True Then
            For Each frm As Form In Me.MdiChildren
                If TypeOf (frm) Is XAbout Then
                    CType(frm, XAbout).Show()
                    CType(frm, XAbout).BringToFront()
                    CType(frm, XAbout).Focus()
                    Me.Refresh()
                    Exit Sub
                End If

            Next
        End If
    End Sub

    Private Sub frmParentDataSubscriber_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles frmParentDataSubscriber.DataChanged

    End Sub

    Private Sub BtnJogDrumExit_Click(sender As Object, e As EventArgs) Handles BtnJogDrumExit.Click
        Me.Close()

    End Sub

    Private Sub BtnMainHelp_Click(sender As Object, e As EventArgs) 
        If Me.HasChildren = True Then
            For Each frm As Form In Me.MdiChildren
                If TypeOf (frm) Is YHelp Then
                    CType(frm, YHelp).Show()
                    CType(frm, YHelp).BringToFront()
                    CType(frm, YHelp).Focus()
                    Me.Refresh()
                    Exit Sub
                End If
            Next
        End If
    End Sub







#End Region

End Class