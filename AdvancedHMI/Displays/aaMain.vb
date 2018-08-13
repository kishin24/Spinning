Public Class aaMain



    Dim tbtext As String = "Welcome, Please log in to initiate controls"


    Private Sub aaMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EthernetIPforCLXCom1.IPAddress = Globals.AppConfigini.ReadValue("Settings", "IPAddress")
        WindowState = FormWindowState.Maximized
    End Sub



    Private Sub MessageDisplayByValue2_Click(sender As Object, e As EventArgs) Handles MessageDisplayByValue2.Click
    End Sub

    'The following subs open the jog button for the drum and take-up respectively

    Private Sub Motor1_Click(sender As Object, e As EventArgs) Handles Motor1.Click
        PPJogDrum.Show()
        PPJogDrum.BringToFront()
        PPJogDrum.Focus()
    End Sub
    Private Sub Motor2_Click(sender As Object, e As EventArgs) Handles Motor2.Click
        PPJogTU.Show()
        PPJogTU.BringToFront()
        PPJogTU.Focus()
    End Sub
    Private Sub EthernetIPforCLXCom1_DataReceived(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles EthernetIPforCLXCom1.DataReceived

    End Sub

    Private Sub notifications()
        Dim notifmanager As New Notifications_Manager
        Dim emailtrigger As Boolean
        If Me.Ind_Runnign.BackColor = Color.Green Then
            Call notifmanager.CauseSpiralStarted(emailtrigger)
            emailtrigger = False
        End If

    End Sub




    'Friend Sub UpdateTBWithParameters(ByVal pMyParameter1 As String) 'Call this from wherever.
    '    Try
    '        If Me.InvokeRequired Then
    '            Dim lDelagate As New Action(Of String)(AddressOf UpdateTBWithParameters)
    '            Me.Invoke(lDelagate, New Object() {pMyParameter1})
    '        Else
    '            'Update Stuff Here/Call methods on child form here.
    '            Me.tbMachineActivity.AppendText(">> " + DateTime.Now.ToString() + ":   " + pMyParameter1 + Environment.NewLine)
    '            Application.DoEvents()
    '            Me.Refresh()
    '        End If
    '    Catch ex As Exception
    '        'CLSErrorLog.WriteLog(ex.Message.ToString, ex.StackTrace.ToString, gAppSettings.ProcessID, gAppSettings.EquipmentNumber, Now, System.Reflection.Assembly.GetExecutingAssembly.Location, gAppSettings.ApplicationDBConnection.ConnectionString, gAppSettings.UserID)
    '        MsgBox(ex.Message & vbCrLf & ex.StackTrace.ToString, MsgBoxStyle.OkOnly)
    '    End Try
    'End Sub

    Private Sub btnSaveLogToFile_Click(sender As Object, e As EventArgs)
        Dim sfd As New SaveFileDialog

        sfd.DefaultExt = "txt"
        sfd.FileName = "CameraLog"
        sfd.Filter = "Text files (*.txt)|*.txt"
        If (sfd.ShowDialog() = DialogResult.OK) Then
            'Me.tbExcelWorkBookPath.Text = ofd.FileName
            Dim fileStream As IO.StreamWriter
            fileStream = My.Computer.FileSystem.OpenTextFileWriter(sfd.FileName, True)
            'For Each line In Me.tbMachineActivity.Lines
            '    fileStream.WriteLine(line)
            'Next
            fileStream.Close()
        End If
    End Sub

    Private Sub ThreeButtonPLC1_Load(sender As Object, e As EventArgs) Handles ThreeButtonPLC1.Load

    End Sub


    'Dim WithEvents Formsect As New Security("", "", GetCurrentUser())


    Public Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If BtnLogin.Text = “Login” Then
            LogIn.txtUsername.Text = “”
            LogIn.txtPassword.Text = “”
            LogIn.Show()
        ElseIf BtnLogin.Text = "Log Out" Then
            MessageBox.Show(“You Have Logged Out", “Authentication Error”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BtnLogin.Text = "Login"
            MessageBox.Show("Logged Out")
            Globals.Login_Level = 0
            LogIn.txtUsername.Text = ""
            LogIn.txtPassword.Text = ""
            
            'RaiseEvent UserLoggedOut()
        End If
    End Sub


    Public Sub LoggedOutHandler()
        Globals.Login_Level = 0
        MessageBox.Show("Logged out" & "current access level is: " & Globals.Login_Level.ToString)



    End Sub





    Public Function GetCurrentUser() As Integer
        Dim level As String
        level = Globals.Login_Level
        MessageBox.Show(level.ToString())


        Return level
    End Function




    Public Sub usertb()
        If BtnLogin.Text = "Login" Then
            Globals.Login_Level = 0
            tbtext = "Welcome, please log in to use the machine"
        ElseIf BtnLogin.Text = "Log out" Then
            tbtext = "Welcome" & ToString(Globals.Login_Level) & DateTime.Now.ToString()

        End If

        Dim textboxmachine As New TextBox With
            {
        .Name = "TextBoxActivity",
        .Dock = DockStyle.Bottom,
         .Text = tbtext
            }



    End Sub








End Class