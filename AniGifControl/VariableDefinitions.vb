' ****************************************************************************************************************
' VariableDefinitions.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

''' <summary>Definition der benötigten internen Variablen</summary>
Module VariableDefinitions

    ''' <summary>Eigenschaftsvariable für das aktuelle Bild.</summary>
    Friend _Gif As System.Drawing.Bitmap

    ''' <summary>Eigenschaftsvariable für den Anzeigemodus des Bildes.</summary>
    Friend _GifSizeMode As SizeMode

    ''' <summary>Eigenschaftsvariable für das ein bzw. ausschalten der benutzerdefinierten Anzeigegeschwindigkeit.</summary>
    Friend _CustomDisplaySpeed As Boolean

    ''' <summary>Eigenschaftsvariable für die benutzerdefinierte Anzeigegeschwindigkeit in Bildern/Sekunde.</summary>
    Friend _FramesPerSecond As Decimal

    ''' <summary>Variable für die Eigenschaften des Bildes.</summary>
    Friend _Dimension As System.Drawing.Imaging.FrameDimension

    ''' <summary>Variable für den Index des aktuellen Bildes.</summary>
    Friend _Frame As Integer

    ''' <summary>Variable für den Index des letzten Bildes.</summary>
    Friend _MaxFrame As Integer

    ''' <summary>Eigenschaftsvariable für automatisches abspielen der Animation.</summary>
    Friend _Autoplay As Boolean

    ''' <summary>Eigenschaftsvariable für Zoomfaktor</summary>
    Friend _ZoomFactor As Decimal

End Module
