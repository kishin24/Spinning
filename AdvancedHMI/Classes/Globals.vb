Public Class Globals


#Region "Configuration"

    Public Shared AppConfigini As IniFile
    Public Shared AppConfigPath As String =
        "C:\Users\ealvaren\Desktop\Advanced HMI\AdvancedHMI\Data\App_Config.ini" '(Application.StartupPath & "\Data\App_Config.ini")

    Public Shared Login_Level As Integer


#End Region



#Region " Alarms "
    Public Shared ReadOnly emailsuffix As String = "@intralox.com"
    Public Shared ReadOnly MajorFaultWord As Integer
    Public Shared currentuser As String = "erick.alvarenga"
#End Region


#Region "File Names"
    Public Shared ReadOnly MachineSchematics As String = "C:\Documents and Settings\aero\My Documents\Manuals\Stacker_Drawings_021317.pdf"
    Public Shared ReadOnly TCSCommissioning As String = "C:\Documents and Settings\aero\My Documents\Manuals\Commissioning Procedure_ILOX-STCS V2.0A-CP-REV000.pdf"
    Public Shared ReadOnly ABBManual As String = "C:\Documents and Settings\aero\My Documents\Manuals\acs880_manual.pdf"
    Public Shared ReadOnly PF70Manual As String = "C:\Documents and Settings\aero\My Documents\Manuals\PowerFlex 70 VFD Manual.pdf"




#End Region


#Region "PLC Address"



#End Region









End Class
