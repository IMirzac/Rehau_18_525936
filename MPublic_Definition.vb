Imports System.IO
Module MPublic_Definition
#Region "Definitionen"
    Public Protokoll_Pfad As String = VisiWinNET.Project.ProjectInfo.Path & "\Datenbank\Protokoll.mdb"
    'Public Protokoll_Vorlage As String = VisiWinNET.Project.ProjectInfo.Path & "\Protokolle\Vorlage\Protokoll.mdb"

    Public Bildname_aktuell As String ' Bildumschaltung mit "Zurück-Taste"; Bild ausblenden
    Public Bildname_alt As String ' Bildumschaltung mit "Zurück-Taste"; Bild anzeigen
#End Region


End Module
