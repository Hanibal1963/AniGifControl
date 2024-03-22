' ****************************************************************************************************************
' HelperMethods.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Module HelperMethods

    ''' <summary>Stellt die Variablen mit den Startbedingungen ein.</summary>
    Friend Sub InitializeValues()
        _Gif = My.Resources.Standard 'Standardanimation laden
        _Autoplay = False 'Standardeinstellung für AutoPlay
        _GifSizeMode = SizeMode.Normal 'Standarddarstellung für Grafik
        _CustomDisplaySpeed = False
        _FramesPerSecond = 6
        _ZoomFactor = 100  'Standardeinstellung für Zoomfaktor
    End Sub

    ''' <summary>Prüft den Wert für Bilder/Sekunde</summary>
    Friend Function CheckFramesPerSecondValue(Value As Decimal) As Decimal
        Select Case Value
            Case Is < 1 : Return 1
            Case Is > 50 : Return 50
            Case Else : Return Value
        End Select
    End Function

    ''' <summary>Püft den Zoomfaktor</summary>
    Friend Function CheckZoomFactorValue(value As Decimal) As Decimal
        Select Case value
            Case Is < 0 : Return 1
            Case Is > 100 : Return 100
            Case Else : Return value
        End Select
    End Function

End Module
