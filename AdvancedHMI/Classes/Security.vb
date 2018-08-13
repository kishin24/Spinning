Public Class Security
    Public Sub New(ByVal user As String, ByVal password As String, Optional ByVal level As Integer = 0)
        Me.Access_Level = level
        Me.Username = user
        Me.Password = password
    End Sub


#Region "Login"

    Public Shared ReadOnly Credentials As Dictionary(Of String, String) = New Dictionary(Of String, String) From
        {{"ealvaren", "Setsuna30"}, {"atyler", "spiral1"}, {"bswick", "spiral1"}, {"lmills", "spiral1"}}

#End Region

    Public Function Validate_Credentials() As Boolean
        Try
            If Credentials.TryGetValue(Username, Password) = True Then

                Return True
            Else

                Return False
            End If
        Catch ex As ArgumentNullException
            Return False
        End Try



    End Function


    ReadOnly ListUsers As New List(Of String)(New String() {"ealvaren", "atyler", "bswick", "lmills"})

    Public Property Username As String
    Public Property Password As String
    Public Property Access_Level As Integer

    ReadOnly Property Current_User() As Integer
        Get
            Select Case Me.Username
                Case ListUsers(0)
                    RaiseEvent LoggedIn(3)
                    Globals.Login_Level = 3
                    Return 3
                Case ListUsers(1)
                    RaiseEvent LoggedIn(2)
                    Globals.Login_Level = 2
                    Return 2
                Case ListUsers(2)
                    RaiseEvent LoggedIn(2)
                    Globals.Login_Level = 2
                    Return 2
                Case ListUsers(3)
                    RaiseEvent LoggedIn(1)
                    Globals.Login_Level = 1
                    Return 1
                Case Else
                    me_LoggedIn(0)
                    Return 99
            End Select
        End Get

    End Property


#Region "Events"

    Public Event LoggedIn(ByVal accesslevel As Integer)
    Public Event LoggedOut(ByVal accesslevel As Integer)

    Private Sub me_LoggedIn(ByVal accesslevel As Integer) Handles Me.LoggedIn
        Call LogIn.Security_eventhandler()
    End Sub
    Private Sub me_LoggedOut(ByVal accesslevel As Integer) Handles Me.LoggedOut
        Call aaMain.LoggedOutHandler()
    End Sub

#End Region






End Class
