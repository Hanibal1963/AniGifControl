' ****************************************************************************************************************
' Form1.vb
' © 2023 - 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports SchlumpfSoft.Controls.AniGifControl

Public Class Form1

    Private _Ani As Integer = 0

    Public Sub New()

        'Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()

        'Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Me.AniGif1.AutoPlay = False 'kein automatischer Start
        Me.AniGif1.GifSizeMode = SizeMode.Normal 'normale Ansicht
        Me.AniGif1.CustomDisplaySpeed = False 'keine Benutzerdefinierte Geschwindigkeit
        Me.AniGif1.FramesPerSecond = 6 'vordefinierter Wert für Bilder/Sekunde
        Me.ComboBoxAnsicht.SelectedIndex = 0 'Standardanimation
        Me.NumericUpDownFramesPerSecond.Value = 6 'Standardwert für benutzerdefinierte Anzeigegeschwindigkeit 
        Me.NumericUpDownZoomFactor.Value = Me.AniGif1.ZoomFactor 'Standardwert für Zoom
        Me.CheckBoxAutoplay.Checked = False 'kein automatischer Start
        Me.ButtonBack.Enabled = False
        Me.ChangeAni()

    End Sub

    Private Sub CheckBoxAutoPlay_CheckedChanged(sender As Object, e As EventArgs) Handles _
        CheckBoxAutoplay.CheckedChanged

        'Autoplay umschalten
        Me.AniGif1.AutoPlay = CType(sender, CheckBox).Checked

    End Sub

    Private Sub CheckBoxCustomDisplaySpeed_CheckStateChanged(sender As Object, e As EventArgs) Handles _
        CheckBoxCustomDisplaySpeed.CheckStateChanged

        'Benutzerdefinierte geschwindigkeit umschalten
        Me.AniGif1.CustomDisplaySpeed = CType(sender, CheckBox).Checked

    End Sub

    Private Sub NumericUpDownFramesPerSecond_ValueChanged(sender As Object, e As EventArgs) Handles _
        NumericUpDownFramesPerSecond.ValueChanged

        'benutzerdefinierte Anzeigegeschwindigkeit einstellen
        Me.AniGif1.FramesPerSecond = CInt(CType(sender, NumericUpDown).Value)

    End Sub

    Private Sub NumericUpDownZoomFactor_ValueChanged(sender As Object, e As EventArgs) Handles _
        NumericUpDownZoomFactor.ValueChanged

        'Zoom ändern
        Me.AniGif1.ZoomFactor = CInt(CType(sender, NumericUpDown).Value)

    End Sub

    Private Sub ComboBoxAnsicht_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _
        ComboBoxAnsicht.SelectedIndexChanged

        'Anzeigemodus umschalten
        Select Case CType(sender, ComboBox).SelectedIndex
            Case 0 : Me.AniGif1.GifSizeMode = SizeMode.Normal
            Case 1 : Me.AniGif1.GifSizeMode = SizeMode.CenterImage
            Case 2 : Me.AniGif1.GifSizeMode = SizeMode.Zoom
        End Select

    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles _
        ButtonBack.Click

        If Me._Ani > 0 Then Me._Ani -= 1 'Animationsnummer verringern solange > 0
        Me.ButtonForward.Enabled = True 'Vor-Button aktivieren
        If Me._Ani = 0 Then Me.ButtonBack.Enabled = False 'Zurück-Button deaktivieren wenn Animationsnummer = 0
        Me.ChangeAni() 'Animation umschalten

    End Sub

    Private Sub ButtonForward_Click(sender As Object, e As EventArgs) Handles _
        ButtonForward.Click

        If Me._Ani < 20 Then Me._Ani += 1  'Animationsnummer erhöhen solange < 20
        Me.ButtonBack.Enabled = True 'Zurück-Button aktivieren
        If Me._Ani = 20 Then Me.ButtonForward.Enabled = False 'Vor-Button deaktivieren wenn Animationsnummer = 20
        Me.ChangeAni() 'Animation umschalten

    End Sub

    Private Sub AniGif1_NoAnimation(sender As Object, e As EventArgs) Handles _
        AniGif1.NoAnimation

        Dim prompt As String = $"Das Bild kann nicht animiert werden."
        Dim title As String = $"Keine Animation"
        Dim unused = MsgBox(prompt,, title)

    End Sub

    Private Sub ChangeAni()

        'Animationsnummer anzeigen
        Select Case Me._Ani
            Case Is <> 0 : Me.LabelAni.Text = String.Format("Animation Nr.: {0}", Me._Ani.ToString)
            Case Else : Me.LabelAni.Text = $"Standardanimation"
        End Select
        'Animation schalten
        Select Case Me._Ani
            Case Is <> 0 : Me.AniGif1.Gif = CType(My.Resources.ResourceManager.GetObject("Anim" & CStr(100 + Me._Ani - 1)), Bitmap)
            Case Else : Me.AniGif1.Gif = Nothing
        End Select

    End Sub

End Class

