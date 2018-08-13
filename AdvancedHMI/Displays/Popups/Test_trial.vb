Public Class Test_trial




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

    Public Property MyName As String = Me.Name
    Public Property TrialNumbers As Int32


    Private Sub Test_trial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Prefix As String = "BoxStep"
        Dim BaseSettings As String = "TestSettingsHMI"
        Dim StepLocation As New Point(3, 90)
        Dim Stepbox() As AdvancedHMIControls.SpiraTestSteps

        Dim StepNum As Integer = TrialNumbers
        Debug.WriteLine("Debug information-product starting")
        Debug.Indent()
        Debug.WriteLine("StepNum = convert.toint32(me.numberofsteps.value) = " & StepNum)
        Try
            ReDim Stepbox(StepNum)
            For index As Integer = 1 To StepNum
                Dim ArrayNum As String = "[" & index.ToString & "]"
                Debug.WriteLine("StepLocation=" & StepLocation.ToString)
                Debug.WriteLine("Index=" & index)
                Debug.WriteLine("StepNumtype " & StepNum.GetType.ToString)

                Dim xoffset = 0
                Dim yoffset = index + 150
                Dim newstep As New AdvancedHMIControls.SpiraTestSteps
                With newstep
                    .Name = Prefix & index.ToString
                    .StepName = Prefix & index.ToString
                    .Location = StepLocation
                    .Size = New Size(691, 111)
                    .PLCAddressTorqueValue = BaseSettings & "[" & index.ToString & "]" & ".Torque_Setpoint"
                    .PLCAddressDuration = BaseSettings & ArrayNum & ".Duration"
                    .PLCAddressSpeed = BaseSettings & ArrayNum & ".Speed_Hz"
                    .PLCAddressSpeedScale = "Test_mode_speed_scale"
                    .PLCAddressCheckChanged = BaseSettings & ArrayNum & ".Mode.0"
                    .PLCAddressCheckChangedTorque = BaseSettings & ArrayNum & ".Mode.1"
                    .PLCAddressCheckChangedSpeed = BaseSettings & ArrayNum & ".Mode.2"
                End With
                Stepbox(index) = newstep
                FlowLayoutPanel1.Visible = True
                FlowLayoutPanel1.AutoScroll = True
                FlowLayoutPanel1.AutoSize = True

                FlowLayoutPanel1.Controls.Add(Stepbox(index))
                ' Me.Controls.Add(Stepbox(index))
                StepLocation.Offset(xoffset, yoffset)



                Debug.WriteLine(Stepbox(index).PLCAddressTorqueValue)
                Debug.WriteLine(Stepbox(index).PLCAddressSpeed)
                Debug.WriteLine(Stepbox(index).PLCAddressTorqueValue)
                Debug.WriteLine(Stepbox(index).PLCAddressCheckChanged)
                Debug.WriteLine(Stepbox(index).PLCAddressSpeedScale)
                Debug.WriteLine("Name=" + Stepbox(index).Name)
                Debug.WriteLine("Stepname=" + Stepbox(index).StepName)


            Next
        Catch ex As NullReferenceException
            MessageBox.Show(ex.Message.ToString & "...../n" & ex.Source.ToString)



        End Try


    End Sub


    Private Sub Test_Trial_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Me.components.Dispose()

    End Sub



    Private Sub BtnCloseTest_Click(sender As Object, e As EventArgs) Handles BtnCloseTest.Click
        BSetup.CloseTrial(Me)
        Me.Close()

    End Sub

    'Private Sub DataSubscriber1_DataReturned(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles DataSubscriber1.DataReturned
    '    Dim box As New AdvancedHMIControls.SpiraTestSteps
    '    Debug.WriteLine("e values" & e.Values.ToString)
    '    For Each cntrl As Control In FlowLayoutPanel1.Controls
    '        If cntrl.GetType() Is GetType(AdvancedHMIControls.SpiraTestSteps) Then
    '            Debug.WriteLine("cntrl.name = " & cntrl.Name.ToString)
    '            Try

    '                If cntrl.Name = "BoxStep" & e.Values.ToString Then
    '                    cntrl.BackColor = Color.Lime
    '                Else
    '                    cntrl.BackColor = Color.Gray

    '                End If

    '            Catch ex As InvalidCastException
    '                MessageBox.Show(ex.Message())
    '            End Try
    '        End If





    '    Next

    'End Sub


    Private Sub DataSubscriber1_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles DataSubscriber1.DataChanged

    End Sub
End Class