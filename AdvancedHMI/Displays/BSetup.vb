Imports System.ComponentModel
Imports System.Speech.Synthesis
Imports Microsoft.Office.Interop


Public Class BSetup
    Implements IDisposable
    Dim TestSteps1 As Int16







#Region "Form Settings"

    '*********************************************************************************
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


    '****************************************************************
    '**Start with Windows Maximze and intialize all variables 
    '**
    '*****************************************************************

    Private Sub BSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EthernetIPforCLXCom1.IPAddress = Globals.AppConfigini.ReadValue("Settings", "IPAddress")

        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ControlBox = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    End Sub


    Private Sub BSetup_Close(sender As Object, e As EventArgs) Handles Me.FormClosing
        EthernetIPforCLXCom1.Unsubscribe(subscriptionid)


        MyBase.Dispose(Disposing)
        If Disposing Then
            Try
                m_comcomponent.UnSubscribe("Test_Mode")
                m_comcomponent.UnSubscribe(NotificationIDOffStatus)
                components.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)

            End Try


        End If


        ' TODO: free unmanaged resources (unmanaged objects).



    End Sub

#End Region


#Region "Setup Tension Control"
    Dim TU_Mode As String

    Private Sub Rbtn_Changed(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TU_Mode = "Maximum"
        Me.BasicIndicator1.Text = TU_Mode
    End Sub
    Private Sub Rbtn2_Changed(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TU_Mode = "Torque"
        Me.BasicIndicator1.Text = TU_Mode
    End Sub
    Private Sub Rbtn3_Changed(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TU_Mode = "Speed"
        Me.BasicIndicator1.Text = TU_Mode
    End Sub


#End Region

    'Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    'End Sub

#Region "Auto Mode Setup"



#End Region


#Region "Manual Mode Setup"

    Private Sub BasicButton2_Click(sender As Object, e As EventArgs)
        PPTestComplete.Show()
        PPTestComplete.BringToFront()
        PPTestComplete.Focus()
    End Sub

#End Region


#Region "Test Mode"
    '***********************************************
    '* Definitions  
    '***********************************************
    'Public Event TestLoaded(ByVal test As Test_trial)
    'Public Event TestLoaded(ByVal sender As Object, ByVal e As EventArgs)
    'Public Event TestFinished(ByVal sender As Object, ByVal e As EventArgs)
    Dim Tests() As Test_trial
    Dim CurrentTestNumber As Integer = 0
    Dim CurrentTestName As String
    Dim testingcomplete As Boolean = False


    '***********************************************
    '* Use synthesizer speech library to say steps 
    '***********************************************
    Private Sub MessageDisplayByValue1_ValueChanged(sender As Object, e As Controls.ValueChangedEventArgs) Handles MessageDisplayByValue1.ValueChanged
        Using synthesizer As New SpeechSynthesizer
            synthesizer.Volume = 100
            synthesizer.SelectVoice("Microsoft Anna")
            synthesizer.Rate = -4
            synthesizer.SpeakAsync(sender.Messages(e.NewValue).Message.ToString)
        End Using
    End Sub

    Public Function LoadTrial()
        Dim ThisTest As New Test_trial
        Dim Retry As Boolean = True
        With ThisTest
            If Retry Then
                Try
                    .MyName = TextBox3.Text
                    .TrialNumbers = Convert.ToInt32(NumberofSteps.Value)
                    Retry = False
                Catch ex As NullReferenceException
                    MessageBox.Show(ex.Message.ToString & "      You must set a name for the test, and selecty the number of test!")

                    Retry = False
                End Try
            Else
                MessageBox.Show("You didn't select a name so default settings will be used.")
                .MyName = "Test_Default" & Date.Now.ToString
                .TrialNumbers = 5
            End If

        End With

        ThisTest.Show()

        'RaiseEvent TestLoaded(ThisTest)

        Return ThisTest
    End Function


    Dim Current_test As New Test_trial

    '***********************************************
    '* Buttons 
    '***********************************************


    Public Sub BtnLoadSteps_Click(sender As Object, e As EventArgs) Handles BtnLoadSteps.Click
        Current_test = LoadTrial()

        Try

            If Current_test IsNot Nothing Then
                CurrentTestNumber = CurrentTestNumber + 1
                CurrentTestName = Current_test.Name.ToString()
                MessageBox.Show("Test Loaded with the following settings:/n
                       Test Name:" & Current_test.MyName)
            Else
                Current_test.Dispose()
            End If

        Catch ex As NullReferenceException
            MessageBox.Show(ex.Message.ToString)

        End Try

    End Sub

    Public Sub BtnCloseTest_Click(sender As Object, e As EventArgs) Handles BtnCloseTest.Click
        'RaiseEvent ExitTest(Current_test)
        testingcomplete = CloseTrial(Current_test)
    End Sub






    '**************************************************************
    '* Subroutine and event handling
    '* 
    '**************************************************************



    Public Function CloseTrial(ByVal test As Component) ' (ByVal test As Component) Handles Me.ExitTest
        CurrentTestNumber = 0
        CurrentTestName = ""
        If test IsNot Nothing Then
            Try
                test.Dispose()
                MessageBox.Show("Test Completed!")
            Catch ex As System.InvalidOperationException
                MessageBox.Show(ex.Message)
            Finally
            End Try

            Return True

        Else
            MessageBox.Show("current test variable was empty. Current_test = " & Current_test.Name.ToString)

            Return False
        End If

    End Function

    Dim m_comcomponent = EthernetIPforCLXCom1
    Dim mytestbool = "test_mode"
    Dim mytestbool1 = "test_bool2"
    Private Sub SubscribeTo(ByVal PLCAddress As String, ByRef SubscribedPLCAddress As String, ByRef NotificationID As Integer, ByVal callBack As EventHandler(Of MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs))
        If SubscribedPLCAddress <> PLCAddress Then
            '* If already subscribed, but address is changed, then unsubscribe first
            If NotificationID > 0 Then
                m_comcomponent.UnSubscribe(NotificationID)
            End If
            '* Is there an address to subscribe to?
            If PLCAddress IsNot Nothing AndAlso (String.Compare(PLCAddress, "") <> 0) Then
                Try
                    If m_comcomponent IsNot Nothing Then
                        NotificationID = m_comcomponent.Subscribe(PLCAddress, 1, 250, callBack)

                        '* If subscription succeedded, save the address
                        SubscribedPLCAddress = PLCAddress
                    Else
                        MessageBox.Show("ComComponent Property not set")
                    End If
                Catch ex As MfgControl.AdvancedHMI.Drivers.Common.PLCDriverException
                    '* If subscribe fails, set up for retry
                    'InitializeSubscribeRetry(ex, PLCAddress)
                End Try
            End If
        End If

    End Sub
    Private NotificationIDOffStatus As Integer
    Private SubscribedPLCAddressOffStatus As String
    Private Sub SubscribeToComDriver()
        If Not DesignMode And IsHandleCreated Then
            '*******************************
            '* Subscription for Auto Status
            '*******************************

            SubscribeTo(mytestbool, SubscribedPLCAddressOffStatus, NotificationIDOffStatus, AddressOf PolledDataReturnedTestModeStatus)

            '*******************************

        End If
    End Sub


    Private Sub PolledDataReturnedTestModeStatus(ByVal sender As Object, ByVal e As MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs)
        Try
            If e.Values(0) Then
                MessageBox.Show("sucesss")
            Else
                MessageBox.Show("failed")
            End If
        Catch
            MessageBox.Show("Hi There, you are in sub PolledDatReturned")
        End Try
    End Sub


    Private Sub BasicButton4_Click(sender As Object, e As EventArgs) Handles BtnTestStart.Click
        If suchlabel.Text = "True" Then
            MessageBox.Show("Starting Test!")
        Else
            MessageBox.Show("Must be in Test Mode! Go to the main screen and switch the machine mode to Test. Remember to hold the start button!")
        End If


    End Sub
    'Dim status As Boolean 
    'Public Sub CheckSub()
    '    status = True 
    '    While status
    '        subscriptionid = EthernetIPforCLXCom1.Subscribe("test_start1", 1, 500, AddressOf Subscription_DataReceived)
    '    End While
    'End Sub

    '*****************************************
    '* Property - What to do to bit in PLC
    '*****************************************
    Private subscriptionid As Integer


    Private Sub Subscription_DataReceived(sender As Object, e As Drivers.Common.PlcComEventArgs)
        If e.ErrorId = 0 AndAlso e.Values IsNot Nothing AndAlso e.Values.Count > 0 Then
            suchlabel.Text = e.Values(0)
        End If
    End Sub



    Dim Test_Mode As Boolean

    Private Sub DataSubscriber1_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles DataSubscriber1.DataChanged

    End Sub

    Private Sub btnBrowseWrkBkDir_Click(sender As Object, e As EventArgs)
        Dim ofd As New OpenFileDialog
        ofd.AddExtension = True
        If (ofd.ShowDialog() = DialogResult.OK) Then
            Me.tbExcelWorkBookPath.Text = ofd.FileName
        End If

    End Sub
#End Region


















End Class