Public Class EventClass

    Dim WithEvents Eclass As New EventClass

    Sub TestEvents()
        Eclass.RaiseEvents()
    End Sub

    Sub EClass_EventHandler() Handles Eclass.LoggedIn, Eclass.LoggedOut
        MsgBox("Received Event.")
    End Sub


    Public Event LoggedIn()
    Public Event LoggedOut()
    Sub RaiseEvents()
        RaiseEvent LoggedIn()
        RaiseEvent LoggedOut()
    End Sub

End Class
