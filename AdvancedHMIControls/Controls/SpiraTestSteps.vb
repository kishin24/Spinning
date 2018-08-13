Public Class SpiraTestSteps
#Region "PLC Related Properties"

    '*****************************************************
    '* Property - Component to communicate to PLC through
    '*****************************************************
    Private m_ComComponent As MfgControl.AdvancedHMI.Drivers.IComComponent
    <System.ComponentModel.Category("PLC Properties")>
    Public Property ComComponent() As MfgControl.AdvancedHMI.Drivers.IComComponent
        Get
            Return m_ComComponent
        End Get
        Set(ByVal value As MfgControl.AdvancedHMI.Drivers.IComComponent)
            If m_ComComponent IsNot value Then
                If SubScriptions IsNot Nothing Then
                    SubScriptions.UnsubscribeAll()
                End If

                m_ComComponent = value

                SubscribeToComDriver()
            End If
        End Set
    End Property

    Private m_PLCAddressCheckChanged As String = ""
    <System.ComponentModel.Category("PLC Properties")>
    Public Property PLCAddressCheckChanged() As String
        Get
            Return m_PLCAddressCheckChanged
        End Get
        Set(ByVal value As String)
            If m_PLCAddressCheckChanged <> value Then
                If Not String.IsNullOrWhiteSpace(value) Then
                    m_PLCAddressCheckChanged = value
                Else
                    m_PLCAddressCheckChanged = ""
                End If
            End If
        End Set
    End Property

    Private m_PLCAddressCheckChangedTorque As String = ""
    <System.ComponentModel.Category("PLC Properties")>
    Public Property PLCAddressCheckChangedTorque() As String
        Get
            Return m_PLCAddressCheckChangedTorque
        End Get
        Set(ByVal value As String)
            If m_PLCAddressCheckChangedTorque <> value Then
                If Not String.IsNullOrWhiteSpace(value) Then
                    m_PLCAddressCheckChangedTorque = value
                Else
                    m_PLCAddressCheckChangedTorque = ""
                End If
            End If
        End Set
    End Property

    Private m_PLCAddressCheckChangedSpeed As String = ""
    <System.ComponentModel.Category("PLC Properties")>
    Public Property PLCAddressCheckChangedSpeed() As String
        Get
            Return m_PLCAddressCheckChangedSpeed
        End Get
        Set(ByVal value As String)
            If m_PLCAddressCheckChangedSpeed <> value Then
                If Not String.IsNullOrWhiteSpace(value) Then
                    m_PLCAddressCheckChangedSpeed = value
                Else
                    m_PLCAddressCheckChangedSpeed = ""
                End If
            End If
        End Set
    End Property

    Private m_PLCAddressVisible As String = ""
    <System.ComponentModel.Category("PLC Properties")>
    Public Property PLCAddressVisible() As String
        Get
            Return m_PLCAddressVisible
        End Get
        Set(ByVal value As String)
            If m_PLCAddressVisible <> value Then
                m_PLCAddressVisible = value

                '* When address is changed, re-subscribe to new address
                SubscribeToComDriver()
            End If
        End Set
    End Property

    Private m_SuppressErrorDisplay As Boolean
    <System.ComponentModel.DefaultValue(False)>
    Public Property SuppressErrorDisplay As Boolean
        Get
            Return m_SuppressErrorDisplay
        End Get
        Set(value As Boolean)
            m_SuppressErrorDisplay = value
        End Set
    End Property

    Private m_StepName As String = ""
    <System.ComponentModel.Category("Misc")>
    Public Property StepName() As String
        Get
            Return m_StepName
        End Get
        Set(value As String)
            If m_StepName <> value Then
                m_StepName = value
            End If
        End Set
    End Property
#End Region

#Region "Individual Tags"
    Private m_PLCAddressTorqueValue As String = ""
    <System.ComponentModel.Category("PLC Properties")>
    Public Property PLCAddressTorqueValue() As String
        Get
            Return m_PLCAddressTorqueValue
        End Get
        Set(ByVal value As String)
            If m_PLCAddressTorqueValue <> value Then
                m_PLCAddressTorqueValue = value

                '* When address is changed, re-subscribe to new address
                SubscribeToComDriver()
            End If
        End Set
    End Property

    Private m_PLCAddressSpeed As String = ""
    <System.ComponentModel.Category("PLC Properties")>
    Public Property PLCAddressSpeed() As String
        Get
            Return m_PLCAddressSpeed
        End Get
        Set(ByVal value As String)
            If m_PLCAddressSpeed <> value Then
                m_PLCAddressSpeed = value

                '* When address is changed, re-subscribe to new address
                SubscribeToComDriver()
            End If
        End Set
    End Property

    Private m_PLCAddressDuration As String = ""
    <System.ComponentModel.Category("PLC Properties")>
    Public Property PLCAddressDuration() As String
        Get
            Return m_PLCAddressDuration
        End Get
        Set(ByVal value As String)
            If m_PLCAddressDuration <> value Then
                m_PLCAddressDuration = value

                '* When address is changed, re-subscribe to new address
                SubscribeToComDriver()
            End If
        End Set
    End Property

    Private m_PLCAddressSpeedScale As String = ""
    <System.ComponentModel.Category("PLC Properties")>
    Public Property PLCAddressSpeedScale() As String
        Get
            Return m_PLCAddressSpeedScale
        End Get
        Set(ByVal value As String)
            If m_PLCAddressSpeedScale <> value Then
                m_PLCAddressSpeedScale = value

                '* When address is changed, re-subscribe to new address
                SubscribeToComDriver()
            End If
        End Set
    End Property
#End Region


#Region "Constructor/Destructor"
    '****************************************************************
    '* UserControl overrides dispose to clean up the component list.
    ''****************************************************************
    'Protected Sub Me.Dispose(ByVal disposing As Boolean) Handle
    '    Try
    '        If disposing Then
    '            If SubScriptions IsNot Nothing Then
    '                SubScriptions.dispose()
    '            End If
    '        End If
    '    Finally
    '        MyBase.Dispose(disposing)
    '    End Try
    'End Sub
#End Region


#Region "Events"

    '********************************************************************
    '* When an instance is added to the form, set the comm component
    '* property. If a comm component does not exist, add one to the form
    '********************************************************************
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()


        If Me.DesignMode Then
            '********************************************************
            '* Search for AdvancedHMIDrivers.IComComponent component in parent form
            '* If one exists, set the client of this component to it
            '********************************************************
            Dim i = 0
            Dim j As Integer = Me.Parent.Site.Container.Components.Count
            While m_ComComponent Is Nothing And i < j
                If Me.Parent.Site.Container.Components(i).GetType.GetInterface("IComComponent") IsNot Nothing Then m_ComComponent = CType(Me.Parent.Site.Container.Components(i), MfgControl.AdvancedHMI.Drivers.IComComponent)
                i += 1
            End While




            '************************************************
            '* If no comm component was found, then add one and
            '* point the ComComponent property to it
            '*********************************************
            If m_ComComponent Is Nothing Then
                m_ComComponent = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.Site.Container)
            End If


        Else
            SubscribeToComDriver()
        End If
    End Sub


    '************************************************
    '*Control Events
    '*********************************************

    'Private Sub RBtnMax_Clicked(sender As Object, e As EventArgs) Handles RBtnMax.Click
    '    RBtnMax.Checked = True
    '    RBtnTrq.Checked = False
    '    RBtnSpeed.Checked = False
    'End Sub
    'Private Sub RBtnSpeed_Clicked(sender As Object, e As EventArgs) Handles RBtnSpeed.Click
    '    RBtnMax.Checked = False
    '    RBtnTrq.Checked = False
    '    RBtnSpeed.Checked = True
    'End Sub
    'Private Sub RBtnTrq_Clicked(sender As Object, e As EventArgs) Handles RBtnTrq.Click
    '    RBtnMax.Checked = False
    '    RBtnTrq.Checked = True
    '    RBtnSpeed.Checked = False
    'End Sub


    'Private Sub Radiobutton3_check(sender As Object, e As EventArgs) Handles RBt


    'Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnMax.CheckedChanged
    '    If Not String.IsNullOrEmpty(m_PLCAddressCheckChanged) Then
    '        Dim WriteValue As String = 0
    '        Try
    '            If RBtnMax.Checked Then
    '                WriteValue = 1
    '                m_ComComponent.Write(m_PLCAddressCheckChanged, WriteValue)
    '            End If
    '            Debug.WriteLine("PLC Address for Check Changed in Max Event" & m_PLCAddressCheckChanged)
    '            Debug.WriteLine("WriteValue for Max Button=" & WriteValue)
    '        Catch ex As Exception
    '            DisplayError(ex.Message)
    '            Debug.WriteLine(ex.Message.ToString)
    '        End Try
    '    End If

    'End Sub


    'Private Sub RBtnTrq_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnTrq.CheckedChanged
    '    If Not String.IsNullOrEmpty(m_PLCAddressCheckChangedTorque) Then
    '        Dim WriteValue As String = 0
    '        Try
    '            If RBtnTrq.Checked Then
    '                WriteValue = 1
    '                m_ComComponent.Write(m_PLCAddressCheckChangedTorque, WriteValue)
    '            End If
    '            Debug.WriteLine("PLC Address for Check Changed in Torque Event" & m_PLCAddressCheckChangedTorque)
    '            Debug.WriteLine("WriteValue for Torque Button=" & WriteValue)
    '        Catch ex As Exception
    '            Debug.WriteLine(ex.Message.ToString)
    '        End Try
    '    End If
    'End Sub


    'Private Sub RBtnSpeed_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnSpeed.CheckedChanged

    'End Sub




#End Region

#Region "Subscriptions"

    Private SubScriptions As AdvancedHMIControls.SubscriptionHandler
    '**************************************************
    '* Subscribe to addresses in the Comm(PLC) Driver
    '**************************************************
    Private Sub SubscribeToComDriver()
        If Not DesignMode And IsHandleCreated Then
            '* Create a subscription handler object
            If SubScriptions Is Nothing Then
                SubScriptions = New AdvancedHMIControls.SubscriptionHandler
                SubScriptions.Parent = Me
                AddHandler SubScriptions.DisplayError, AddressOf DisplaySubscribeError
            End If
            SubScriptions.ComComponent = m_ComComponent

            SubScriptions.SubscribeAutoProperties()
        End If
    End Sub
    '***************************************
    '* Call backs for returned data
    '***************************************
    Private OriginalText As String
    Private Sub PolledDataReturned(ByVal sender As Object, ByVal e As AdvancedHMIControls.SubscriptionHandlerEventArgs)
    End Sub

    Private Sub DisplaySubscribeError(ByVal sender As Object, ByVal e As MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs)
        DisplayError(e.ErrorMessage)
    End Sub
#End Region

#Region "Error Display"

    '********************************************************
    '* Show an error via the text property for a short time
    '********************************************************
    Private WithEvents ErrorDisplayTime As System.Windows.Forms.Timer
    Private Sub DisplayError(ByVal ErrorMessage As String)
        If Not m_SuppressErrorDisplay Then
            If ErrorDisplayTime Is Nothing Then
                ErrorDisplayTime = New System.Windows.Forms.Timer
                AddHandler ErrorDisplayTime.Tick, AddressOf ErrorDisplay_Tick
                ErrorDisplayTime.Interval = 5000
            End If

            '* Save the text to return to
            If Not ErrorDisplayTime.Enabled Then
                OriginalText = Me.Text
            End If

            ErrorDisplayTime.Enabled = True

            Me.Text = ErrorMessage
        End If
    End Sub

    '**************************************************************************************
    '* Return the text back to its original after displaying the error for a few seconds.
    '**************************************************************************************
    Private Sub ErrorDisplay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ErrorDisplayTime.Tick
        Text = OriginalText

        If ErrorDisplayTime IsNot Nothing Then
            ErrorDisplayTime.Enabled = False
            ErrorDisplayTime.Dispose()
            ErrorDisplayTime = Nothing
        End If
    End Sub

    Private Sub SpiraTestSteps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StepLabel As New Label
        With StepLabel
            .Text = m_StepName
            .Location = New Point(0, 0)
            .AutoSize = True

        End With
        Me.RBtnMax.PLCAddressCheckChanged = m_PLCAddressCheckChanged
        Me.RBtnSpeed.PLCAddressCheckChanged = m_PLCAddressCheckChangedSpeed
        Me.RBtnTrq.PLCAddressCheckChanged = m_PLCAddressCheckChangedTorque
        Me.LblStepsDuration.PLCAddressValue = m_PLCAddressDuration
        Me.LblStepsDuration.PLCAddressKeypad = m_PLCAddressDuration
        Me.LblStepsScaling.PLCAddressValue = m_PLCAddressSpeedScale
        Me.LblStepsScaling.PLCAddressKeypad = m_PLCAddressSpeedScale
        Me.LblStepsSpeed.PLCAddressValue = m_PLCAddressSpeed
        Me.LblStepsSpeed.PLCAddressKeypad = m_PLCAddressSpeed
        Me.Lblstepstorque.PLCAddressKeypad = m_PLCAddressTorqueValue
        Me.Lblstepstorque.PLCAddressValue = m_PLCAddressTorqueValue
        Me.Controls.Add(StepLabel)
    End Sub







#End Region

End Class
