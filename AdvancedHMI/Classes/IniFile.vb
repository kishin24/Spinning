Imports System.Text
Imports System.Runtime.InteropServices
    Public Class IniFile

        Private Declare Ansi Function GetPrivateProfileString2 Lib "kernel32.dll" Alias "GetPrivateProfileStringA" _
            (ByVal lpApplicationName As String,
             ByVal lpKeyName As String,
             ByVal lpDefault As String,
             ByVal lpReturnedString As System.Text.StringBuilder,
             ByVal nSize As Integer,
             ByVal lpFileName As String) As Integer

        Private Declare Ansi Function WritePrivateProfileString Lib "kernel32.dll" Alias "WritePrivateProfileStringA" _
            (ByVal lpApplicationName As String,
             ByVal lpKeyName As String,
             ByVal lpString As String,
             ByVal lpFileName As String) As Integer

        <DllImport("kernel32")>
        Private Shared Function GetPrivateProfileString(Section As String, Key As String, Value As String, Result As StringBuilder, Size As Integer, FileName As String) As Integer
        End Function


        <DllImport("kernel32")>
        Private Shared Function GetPrivateProfileString(Section As String, Key As Integer, Value As String, <MarshalAs(UnmanagedType.LPArray)> Result As Byte(), Size As Integer, FileName As String) As Integer
        End Function

        <DllImport("kernel32")>
        Private Shared Function GetPrivateProfileString(Section As Integer, Key As String, Value As String, <MarshalAs(UnmanagedType.LPArray)> Result As Byte(), Size As Integer, FileName As String) As Integer
        End Function

        Public Property Path As String

        ''' <summary>
        ''' IniFile Constructor
        ''' </summary>
        ''' <param name="IniPath">The path to the INI file.</param>
        Public Sub New(ByVal IniPath As String)
            Path = IniPath
        End Sub

        ''' <summary>
        ''' Read value from INI file
        ''' </summary>
        ''' <param name="section">The section of the file to look in</param>
        ''' <param name="key">The key in the section to look for</param>
        Public Function ReadValue(ByVal section As String, ByVal key As String) As String
            Dim sb As New System.Text.StringBuilder(255)
            Dim i = GetPrivateProfileString(section, key, "", sb, 255, Path)
            Return sb.ToString()
        End Function

        ''' <summary>
        ''' Write value to INI file
        ''' </summary>
        ''' <param name="section">The section of the file to write in</param>
        ''' <param name="key">The key in the section to write</param>
        ''' <param name="value">The value to write for the key</param>
        Public Sub WriteValue(ByVal section As String, ByVal key As String, ByVal value As String)
            WritePrivateProfileString(section, key, value, Path)
        End Sub

    'Public Function GetSectionNames() As String()
    '    Dim maxsize As Integer = 500
    '    While True
    '        Dim bytes As Byte() = New Byte(maxsize - 1) {}
    '        Dim size As Integer = GetPrivateProfileString(0, "", "", bytes, maxsize, Path)
    '        If size < maxsize - 2 Then
    '            Dim Selected As String = Encoding.ASCII.GetString(bytes, 0, size - (If(size > 0, 1, 0)))
    '            Return Selected.Split(New Char() {ControlChars.NullChar})
    '        End If
    '        maxsize *= 2
    '    End While
    'End Function
    'Public Function GetEntryNames(section As String) As String()
    '    Dim maxsize As Integer = 500
    '    While True
    '        Dim bytes As Byte() = New Byte(maxsize - 1) {}
    '        Dim size As Integer = GetPrivateProfileString(section, 0, "", bytes, maxsize, Path)
    '        If size < maxsize - 2 Then
    '            Dim entries As String = Encoding.ASCII.GetString(bytes, 0, size - (If(size > 0, 1, 0)))
    '            Return entries.Split(New Char() {ControlChars.NullChar})
    '        End If
    '        maxsize *= 2
    '    End While
    'End Function
    'Public Function GetEntryValue(section As String, entry As String) As Object
    '    Dim maxsize As Integer = 250
    '    While True
    '        Dim result As New StringBuilder(maxsize)
    '        Dim size As Integer = GetPrivateProfileString(section, entry, "", result, maxsize, Path)
    '        If size < maxsize - 1 Then
    '            Return result.ToString()
    '        End If
    '        maxsize *= 2
    '    End While
    'End Function


End Class
