Imports System.Data.SQLite

Public Class LogIn

    Public Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub InitializeMyControl()
        ' Set to no text.  
        txtPassword.Text = ""
        ' The password character is an asterisk.  
        txtPassword.PasswordChar = "*"
        ' The control will allow no more than 14 characters.  
        txtPassword.MaxLength = 14

        txtUsername.Text = ""
        ' The control will allow no more than 14 characters.  
        txtUsername.MaxLength = 14


    End Sub





    Public Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim password As String = ""
        If txtPassword.Text = “” Or txtUsername.Text = “” Then
            MessageBox.Show(“Please complete the required fields…”, “Authentication Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'ElseIf Security.Credentials.TryGetValue(txtUsername.Text, password) Then
        Else
            Dim FormSecurity As New Security(txtUsername.Text, txtPassword.Text)
            If FormSecurity.Validate_Credentials() Then
                Globals.Login_Level = FormSecurity.Current_User()
                Debug.Print(Globals.Login_Level.ToString())
                
                'Debug.Print(ToString("value for login level at this point:" & ToString(loginlevel)))
                MessageBox.Show("User " & FormSecurity.Username & "Logged In!, Access level is:" & FormSecurity.Current_User().ToString())

                Me.Close()
                aaMain.BtnLogin.Text = "Log Out"
                'aaMain.tbMachineActivity.Text = "Welcome " & FormSecurity.Username & "!"
                Globals.Login_Level = FormSecurity.Current_User()
            Else
                MessageBox.Show(“Incorrect Username or Password”, “Authentication Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        ' Security.Credentials.ContainsValue("")
        '    ' Connect to DB
        '    Try
        '        Dim conn As New SQLiteConnection
        '        Dim cnnstring As String = "C:\Users\ealvaren\Desktop\Advanced HMI\Database\Reports.db"

        '        ' Build connection string
        '        conn.ConnectionString = "Data Source=" & cnnstring & ""
        '        conn.Open()

        '        Dim mycommand As New SQLiteCommand(conn)

        '        'Build Query 
        '        Dim tblName As String = "Users"
        '        Dim query As String = "Select * from" & tblName & " WHERE User='" & txtUsername.Text & " AND Password= '" & txtPassword.Text & "'"

        '        mycommand.CommandText = query

        '        Dim sqlreader As SQLiteDataReader
        '        mycommand.ExecuteReader()

        '        Dim dt = New DataTable
        '        dt.Load(sqlreader)

        '        mycommand.Dispose()
        '        conn.Close()

        '    Catch ex As SQLiteException
        '        MessageBox.Show(ToString(ex.Message), MessageBoxButtons.OK, MessageBoxIcon.Error)

        '    End Try

        'End If








        '        'Open Database Connection

        '        If sqlRead.Read() Then
        '            Dim FirstName As String
        '            Dim LastName As String
        '            Dim UserLevel As Integer
        '            FirstName = sqlRead(“First_Name”)
        '            LastName = sqlRead(“Last_Name”)
        '            UserLevel = sqlRead(“User_Level”)
        '            'MainForm.ModbusTCPCom1.Write(“40005”, UserLevel)
        '            'MainForm.Button1.Text = “Logout”
        '            'MainForm.Label6.Text = FirstName & ” “ & LastName & ” Level = “ & UserLevel
        '            'MainForm.MomentaryButton1.Enabled = True 'Start

        '            aaMain.Show()
        '            Me.Hide()
        '        Else
        '            ' If user enter wrong username and password combination show error
        '            MessageBox.Show(“Username and Password do not match..”, “Authentication Failure”, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '            'Clear all fields
        '            txtPassword.Text = “”
        '            txtUsername.Text = “”
        '            'Focus on Username field
        '            txtUsername.Focus()
        '        End If
        '        conn.Close()
        '    Catch ex As SQLiteException
        '        MessageBox.Show(“Failed to connect to Database.. System Error Message: “ & ex.Message, “Database Connection Error”, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End Try
        'End If
    End Sub




    Public Sub Security_eventhandler()
        If Globals.Login_Level = 0 Then
            aaMain.MbStart.Visible = False
            aaMain.MbStart.Enabled = False
            aaMain.LblMainSpeedMan.Visible = False
            aaMain.ThreeButtonPLC1.Enabled = False
            aaMain.ThreeButtonPLC1.Visible = False
            My.Application.DoEvents()
        ElseIf Globals.Login_Level = 1 Then
            aaMain.MbStart.Visible = False
            aaMain.MbStart.Enabled = False
            aaMain.LblMainSpeedMan.Visible = True
            aaMain.ThreeButtonPLC1.Enabled = False
            aaMain.ThreeButtonPLC1.Visible = False
            My.Application.DoEvents()
        ElseIf Globals.Login_Level = 2 Then
            aaMain.MbStart.Visible = False
            aaMain.MbStart.Enabled = False
            aaMain.LblMainSpeedMan.Visible = False
            aaMain.ThreeButtonPLC1.Enabled = False
            aaMain.ThreeButtonPLC1.Visible = True
            My.Application.DoEvents()
        ElseIf Globals.Login_Level = 3 Then
            aaMain.MbStart.Visible = True
            aaMain.MbStart.Enabled = True
            aaMain.LblMainSpeedMan.Visible = True
            aaMain.ThreeButtonPLC1.Enabled = True
            My.Application.DoEvents()
        End If

        Debug.Print(Globals.Login_Level.ToString())

    End Sub


    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class