Imports System.Runtime.InteropServices

Public Class Taskleiste

    <DllImport("user32.dll")> _
        Private Shared Function FindWindow(ByVal className As String, ByVal windowText As String) As IntPtr
    End Function
    <DllImport("user32.dll")> _
    Private Shared Function ShowWindow(ByVal hwnd As IntPtr, ByVal command As Integer) As Boolean
    End Function
    Private Const SW_HIDE As Integer = 0
    Private Const SW_SHOW As Integer = 1

    Public Shared Function HideStartButton() As Boolean
        Dim retval = False
        HideTaskBar()
        Dim hwndStartButton = FindWindow("Button", "Start")
        If hwndStartButton <> IntPtr.Zero Then
            retval = ShowWindow(hwndStartButton, SW_HIDE)
        End If
        Return retval
    End Function
    Public Shared Function HideTaskBar() As Boolean
        Dim retval = False
        Dim hwndTaskBar = FindWindow("Shell_TrayWnd", "")
        If hwndTaskBar <> IntPtr.Zero Then
            retval = ShowWindow(hwndTaskBar, SW_HIDE)
        End If
        Return retval
    End Function
    Public Shared Function ShowStartButton() As Boolean
        Dim retval1 = False
        ShowHideTaskBar()
        Dim hwndstartbutton = FindWindow("Button", "Start")
        If hwndstartbutton <> IntPtr.Zero Then
            retval1 = ShowWindow(hwndstartbutton, SW_SHOW)
        End If
        Return retval1
    End Function
    Public Shared Function ShowHideTaskBar() As Boolean
        Dim retval2 = False
        Dim hwndTaskBar = FindWindow("Shell_TrayWnd", "")
        If hwndTaskBar <> IntPtr.Zero Then
            retval2 = ShowWindow(hwndTaskBar, SW_SHOW)
        End If
        Return retval2
    End Function


End Class
