' ****************************************************************************************************************
' AniGif.vb
' © 2023 - 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Diagnostics

''' <summary>Control zum anzeigen von animierten Grafiken.</summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<Description("Control zum Anzeigen von animierten Grafiken.")>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(AniGif), "AniGif.bmp")>
Public Class AniGif

    Inherits Control

    ''' <summary>Zeitgeber für Benutzerdefinierte Anzeigegeschwindigkeit</summary>
    Private WithEvents Timer As Timer

    ''' <summary>Container für interne Komponenten.</summary>
    Private components As IContainer

    ''' <summary>Wird ausgelöst wenn die Grafik nicht animiert werden kann.</summary>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Wird ausgelöst wenn die Grafik nicht animiert werden kann.")>
    Public Event NoAnimation(sender As Object, e As EventArgs)

    ''' <summary>Legt fest ob die Animation sofort nach dem laden gestartet wird.</summary>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Legt fest ob die Animation sofort nach dem laden gestartet wird.")>
    Public Property AutoPlay() As Boolean
        Get
            Return _Autoplay
        End Get
        Set(value As Boolean)
            _Autoplay = value
        End Set
    End Property

    ''' <summary>Gibt die animierte Gif-Grafik zurück oder legt diese fest.</summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Gibt die animierte Gif-Grafik zurück oder legt diese fest.")>
    Public Property Gif() As Bitmap
        Get
            Return _Gif
        End Get
        Set(value As Bitmap)
            _Gif = If(value, My.Resources.Standard) 'Standardanimation verwenden wenn keine Auswahl erfolgte
            Me.GifChange()
        End Set
    End Property

    ''' <summary>Gibt die Art wie die Grafik angezeigt wird zurück oder legt diese fest.</summary>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Gibt die Art wie die Grafik angezeigt wird zurück oder legt diese fest.")>
    Public Property GifSizeMode() As SizeMode
        Get
            Return _GifSizeMode
        End Get
        Set(value As SizeMode)
            _GifSizeMode = value
            Me.Invalidate()
        End Set
    End Property

    ''' <summary>Legt fest ob die benutzerdefinierte Anzeigegeschwindigkeit oder die in der Datei festgelegte Geschwindigkeit benutzt wird.</summary>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Legt fest ob die benutzerdefinierte Anzeigegeschwindigkeit oder die in der Datei festgelegte Geschwindigkeit benutzt wird.")>
    Public Property CustomDisplaySpeed As Boolean
        Get
            Return _CustomDisplaySpeed
        End Get
        Set(value As Boolean)
            _CustomDisplaySpeed = value
            Me.CustomDisplaySpeedChanged()
        End Set
    End Property

    ''' <summary>Legt die benutzerdefinierte Anzeigegeschwindigkeit in Bildern/Sekunde fest wenn CustomDisplaySpeed auf True festgelegt ist.</summary>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Legt die benutzerdefinierte Anzeigegeschwindigkeit in Bildern/Sekunde fest wenn CustomDisplaySpeed auf True festgelegt ist.")>
    Public Property FramesPerSecond As Decimal
        Get
            Return _FramesPerSecond
        End Get
        Set(value As Decimal)
            _FramesPerSecond = CheckFramesPerSecondValue(value)
            Me.Timer.Interval = CInt(1000 / _FramesPerSecond)
        End Set
    End Property

    ''' <summary>Legt den Zoomfaktor fest wenn GifSizeMode auf Zoom festgelegt ist.</summary>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Legt den Zoomfaktor fest wenn GifSizeMode auf Zoom festgelegt ist.")>
    Public Property ZoomFactor As Decimal
        Get
            Return _ZoomFactor
        End Get
        Set(value As Decimal)
            _ZoomFactor = CheckZoomFactorValue(value)
            Me.Invalidate() 'neu zeichnen
        End Set
    End Property

    Public Sub New()
        Me.InitializeComponent()
        Me.InitializeStyles() 'Stil und Verhalten des Steuerelements festlegen
        InitializeValues() 'Standardwerte laden
    End Sub

    ''' <summary>Wird ausgeführt wenn das Bild gewechselt wurde.</summary>
    Private Sub GifChange()

        'überprüfen ob das Bild animiert werden kann wenn Autoplay auf True gesetzt ist
        If ImageAnimator.CanAnimate(_Gif) = False And Me.AutoPlay = True Then

            'Timer stoppen und Anzahl der Frames auf 0 setzen (für nicht animiertes bild)
            Me.Timer.Stop()
            _MaxFrame = 0

            'Ereignis auslösen
            RaiseEvent NoAnimation(Me, EventArgs.Empty)

        Else

            'Werte für Benutzerdefinierte Geschwindigkeit speichern
            _Dimension = New FrameDimension(_Gif.FrameDimensionsList(0))
            _MaxFrame = _Gif.GetFrameCount(_Dimension) - 1
            _Frame = 0

            'Timer starten
            If _CustomDisplaySpeed Then Me.Timer.Start()

        End If

        Me.Invalidate() 'neu zeichnen
        Me.Initlayout() 'Animation starten

    End Sub

    ''' <summary>Wird ausgeführt wenn die benutzerdefinierte Anzeigegeschwindigkeit ein oder ausgeschaltet wurde</summary>
    Private Sub CustomDisplaySpeedChanged()
        Me.Timer.Enabled = _CustomDisplaySpeed
        If Me.Timer.Enabled Then
            Me.Timer.Start()
        Else
            Me.Timer.Stop()
        End If
    End Sub

    Private Sub OnNextFrame(o As Object, e As EventArgs)

        Me.Invalidate() 'neu zeichnen

    End Sub

    Protected Overloads Overrides Sub Initlayout()

        MyBase.InitLayout()

        ' Animation starten wenn nicht im Desigmodus und AutoPlay auf True
        If Not Me.DesignMode And ImageAnimator.CanAnimate(_Gif) Then
            ImageAnimator.Animate(_Gif, AddressOf Me.OnNextFrame)
        End If

    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        MyBase.OnPaint(e)

        'variable für Zeichenfläche
        Dim g As Graphics = e.Graphics
        Dim destrec As Rectangle

        'Variablen zur Bildberechnung
        Dim startpoint As Point
        Dim startsize As Size

        'aktuelle Werte des Bildes
        Dim gifw As Integer = _Gif.Size.Width
        Dim gifh As Integer = _Gif.Size.Height
        Dim zoom As Decimal = _ZoomFactor / 100

        'Bildgröße und Startpunkt in Abhängikeit vom Zeichenodus berechnen
        Select Case _GifSizeMode

            Case SizeMode.Normal '(Bild in Originalgröße und links oben)

                'Größe berechnen
                startsize = New Size(gifw, gifh)

                'Startpunkt berechnen 
                startpoint = New Point(0, 0)

            Case SizeMode.CenterImage '(Bild in Originalgröße und zentriert)

                'Größe berechnen
                startsize = New Size(gifw, gifh)

                'Startpunkt berechnen
                startpoint = New Point(CInt((Me.Width - _Gif.Width) / 2), CInt((Me.Height - _Gif.Height) / 2))

            Case SizeMode.Zoom '(Bild angepasst und Seitenverhältnis unverändert)

                'Größe berechnen
                If gifh > gifw Then
                    'Anpassung wenn Bild höher als breit
                    startsize = New Size(CInt(Me.Height / CDec(gifh / gifw) * zoom), CInt(Me.Height * zoom))
                Else
                    'Anpassung wenn Bild breiter als hoch
                    startsize = New Size(CInt(Me.Width * zoom), CInt(Me.Width * CDec(gifh / gifw) * zoom))
                End If

                'Startpunkt berechnen
                startpoint = New Point(CInt((Me.Width - startsize.Width) / 2), CInt((Me.Height - startsize.Height) / 2))

            Case Else

        End Select

        'neue Zeichenfläche festlegen und Bild zeichnen
        destrec = New Rectangle(startpoint, startsize)
        g.DrawImage(_Gif, destrec)

        'Bild animieren wenn AutoPlay aktiv und Benutzerdefinierte Geschwindigkeit deaktiviert
        If Not Me.DesignMode And Me.AutoPlay And Not Me.CustomDisplaySpeed Then
            ImageAnimator.UpdateFrames() 'im Bild gespeicherte Geschwindigkeit verwenden
        End If

    End Sub

    ''' <summary>Initialisiert die Komponenten dieser Klasse</summary>
    Private Sub InitializeComponent()
        Me.components = New Container()
        Me.Timer = New Timer(Me.components)
        Me.SuspendLayout()
        Me.Timer.Interval = 200
        Me.ResumeLayout(False)
    End Sub

    ''' <summary>Initialisiert die Controlstyles dieses Controls</summary>
    Private Sub InitializeStyles()
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    End Sub

    Private Sub Tick(sender As Object, e As EventArgs) Handles _
        Timer.Tick

        'Bild animieren wenn AutoPlay und Benutzerdefinierte Geschwindigkeit aktiv
        If Not Me.DesignMode And Me.AutoPlay Then

            'wenn Frames = 0 ist das Bild nicht animiert -> Ende
            If _MaxFrame = 0 Then Exit Sub

            'Bildzähler zurücksetzen wenn maximale Anzahl überschritten
            If _Frame > _MaxFrame Then _Frame = 0

            'nächstes Bild auswählen
            Dim unused = _Gif.SelectActiveFrame(_Dimension, _Frame)

            'Bildzähler weiterschalten und neu zeichnen
            _Frame += 1
            Me.Invalidate() '

        End If

    End Sub

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property MaximumSize As Size
        Get
            Return MyBase.MaximumSize
        End Get
        Set(value As Size)
            MyBase.MaximumSize = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property MinimumSize As Size
        Get
            Return MyBase.MinimumSize
        End Get
        Set(value As Size)
            MyBase.MinimumSize = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overloads Property Padding As Padding
        Get
            Return MyBase.Padding
        End Get
        Set(value As Padding)
            MyBase.Padding = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property RightToLeft() As RightToLeft
        Get
            Return MyBase.RightToLeft
        End Get
        Set(value As RightToLeft)
            MyBase.RightToLeft = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property AllowDrop() As Boolean
        Get
            Return MyBase.AllowDrop
        End Get
        Set(value As Boolean)
            MyBase.AllowDrop = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property AutoScrollOffset As Point
        Get
            Return MyBase.AutoScrollOffset
        End Get
        Set(value As Point)
            MyBase.AutoScrollOffset = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property AutoSize As Boolean
        Get
            Return MyBase.AutoSize
        End Get
        Set(value As Boolean)
            MyBase.AutoSize = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property BackgroundImage() As Image
        Get
            Return MyBase.BackgroundImage
        End Get
        Set(value As Image)
            MyBase.BackgroundImage = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property BackgroundImageLayout() As ImageLayout
        Get
            Return MyBase.BackgroundImageLayout
        End Get
        Set(value As ImageLayout)
            MyBase.BackgroundImageLayout = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property ContextMenuStrip() As ContextMenuStrip
        Get
            Return MyBase.ContextMenuStrip
        End Get
        Set(value As ContextMenuStrip)
            MyBase.ContextMenuStrip = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property Dock() As DockStyle
        Get
            Return MyBase.Dock
        End Get
        Set(value As DockStyle)
            MyBase.Dock = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property Font() As Font
        Get
            Return MyBase.Font
        End Get
        Set(value As Font)
            MyBase.Font = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property ForeColor() As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(value As Color)
            MyBase.ForeColor = value
        End Set
    End Property

End Class
