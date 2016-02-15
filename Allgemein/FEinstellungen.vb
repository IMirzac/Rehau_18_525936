Public Class FEinstellungen

#Region " Deklarationen "

    Private Declare Function GetSystemTime Lib "kernel32.dll" (ByRef stru As SYSTEMTIME) As Int32
    Private Declare Function SetSystemTime Lib "kernel32.dll" (ByRef stru As SYSTEMTIME) As Int32
    Public Declare Function SetLocalTime Lib "kernel32.dll" (ByRef stru As SYSTEMTIME) As Boolean
    Public Declare Function GetLocalTime Lib "kernel32.dll" (ByRef stru As SYSTEMTIME) As Boolean

    Public Structure SYSTEMTIME
        Public wYear As Int16
        Public wMonth As Int16
        Public wDayOfWeek As Int16
        Public wDay As Int16
        Public wHour As Int16
        Public wMinute As Int16
        Public wSecond As Int16
        Public wMilliseconds As Int16
    End Structure

#End Region
#Region " Initialisierung "

    Private Sub FEinstellungen_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        VisiWinNET.Services.AppService.VWSet("SPS Ofen.Kopplung.Bildnummer", 1100)
        dtiDatum_Uhrzeit.VWItem.Value = DateTime.Now
        Me.cmdDatum_Uhrzeit_speichern.Select()
    End Sub

#End Region

#Region " Ereignisse "

    Private Sub cmdDatum_Uhrzeit_speichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDatum_Uhrzeit_speichern.Click
        Dim datum_Zeit As DateTime = dtiDatum_Uhrzeit.VWItem.Value
        SetTime(datum_Zeit)
    End Sub

    Private Sub tiDatum_Uhrzeit_aktuallisieren_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tiDatum_Uhrzeit_aktuallisieren.Tick
        If dtiDatum_Uhrzeit.Focused = False Then
            dtiDatum_Uhrzeit.VWItem.Value = DateTime.Now
        End If
    End Sub

#End Region

#Region " Oeffentliche Prozeduren "

    Public Shared Sub SetTime(ByVal dt As DateTime)
        Dim time As SYSTEMTIME
        Dim result As Int32

        time.wYear = CType(dt.Year, Int16)
        time.wMonth = CType(dt.Month, Int16)
        time.wDay = CType(dt.Day, Int16)
        time.wDayOfWeek = CType(dt.DayOfWeek, Int16)
        time.wHour = CType(dt.Hour, Int16)
        time.wMinute = CType(dt.Minute, Int16)
        time.wSecond = CType(dt.Second, Int16)
        time.wMilliseconds = CType(dt.Millisecond, Int16)
        'Setzt die SystemZeit
        'result = SetSystemTime(time)
        'setzt die locale Systemzeit Zeit inkl. möglicher Zeitverschiebungen 
        result = SetLocalTime(time)
    End Sub

#End Region

End Class
