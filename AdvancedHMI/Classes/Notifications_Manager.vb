Imports System.Net.Mail

Public Class Notifications_Manager
    Dim starttime As System.DateTime
    Dim User As String
    Public Event SpiralStarted(ByVal user As String, ByVal email As String)

    Sub CauseSpiralStarted(ByVal StartTrigger As Boolean)
        While True
            If StartTrigger = True Then
                User = Globals.currentuser
                Dim email As String
                email = User + Globals.emailsuffix
                RaiseEvent SpiralStarted(User, email)
            End If
        End While





    End Sub

    Dim WithEvents StartNotif As New Notifications_Manager

    Public Sub EmailMe(ByVal User As String, ByVal email As String) Handles StartNotif.SpiralStarted

        starttime = DateTime.Now.ToString("yyy/MM/dd HH:mm:ss")

        Dim message = "Spiral was started by" + User + "at" + starttime

        Dim Mail As New MailMessage
        Mail.Subject = "CCC Structure Supported Spiral Notifications"
        Mail.To.Add(email)
        Mail.From = New MailAddress("test.spiral.ccc@gmail.com")
        Mail.Body = message

        Dim smtp As New SmtpClient("smtp.gmail.com")
        smtp.EnableSsl = True
        smtp.UseDefaultCredentials = False
        smtp.Credentials = New System.Net.NetworkCredential("test.spiral.ccc@gmail.com", "mevviarwzeewqigw")
        smtp.Port = "587"
        Try
            smtp.Send(Mail)
        Catch ex As SmtpException
            MessageBox.Show(ex.Message.ToString)

        Catch ex1 As SystemException
            MessageBox.Show(ex1.Message.ToString)

        End Try

    End Sub







End Class
