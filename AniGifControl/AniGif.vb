'
'****************************************************************************************************************
'AniGif.vb
'Copyright (c) 2023 Andreas Sauer
'****************************************************************************************************************


<ProvideToolboxControl("SchlumpfSoft", False)>
<System.ComponentModel.Description("Control zum anzeigen von animierten Grafiken.")>
Public Class AniGif


#Region "Fields"

	<System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0032:Automatisch generierte Eigenschaft verwenden", Justification:="<Ausstehend>")>
	Private _AutoPlay As Boolean
	Private _Gif As System.Drawing.Bitmap
	Private _GifSizeMode As GifSizeMode

#End Region


#Region "Public Constructors"

	Public Sub New()

		' Dieser Aufruf ist für den Designer erforderlich.
		InitializeComponent()

		' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

		'Stil und Verhalten des Steuerelements festlegen
		InitializeStyles()

		'Standardanimation laden
		_Gif = My.Resources.Standard

		'Standardeinstellung für AutoPlay
		_AutoPlay = False

		'Standarddarstellung für Grafik
		_GifSizeMode = GifSizeMode.Normal

	End Sub

#End Region


#Region "Properties"


	''' <summary>
	''' Ruft einen Wert ab, der angibt, ob das Steuerelement Daten annehmen kann, 
	''' die vom Benutzer darauf gezogen wurden, oder legt diesen fest.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
	<System.ComponentModel.Browsable(False)>
	<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>
	Public Overrides Property AllowDrop() As Boolean
		Get
			Return MyBase.AllowDrop
		End Get
		Set(value As Boolean)
			MyBase.AllowDrop = value
		End Set
	End Property

	''' <summary>
	''' Legt fest ob die Animation sofort nach dem laden gestartet wird.
	''' </summary>
	''' <remarks>
	''' </remarks>
	<System.ComponentModel.Browsable(True)>
	<System.ComponentModel.Category("Behavior")>
	<System.ComponentModel.Description("Legt fest ob die Animation sofort nach dem laden gestartet wird.")>
	Public Property AutoPlay() As Boolean
		Get
			Return _AutoPlay
		End Get
		Set
			_AutoPlay = Value
		End Set
	End Property

	''' <summary>
	''' Ruft das im Steuerelement angezeigte Hintergrundbild ab oder legt dieses fest.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
	<System.ComponentModel.Browsable(False)>
	<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>
	Public Overrides Property BackgroundImage() As System.Drawing.Image
		Get
			Return MyBase.BackgroundImage
		End Get
		Set(value As System.Drawing.Image)
			MyBase.BackgroundImage = value
		End Set
	End Property

	''' <summary>
	''' Ruft ab oder legt fest, welches Hintergrundbildlayout gemäß der Definition 
	''' in der ImageLayout-Enumeration verwendet wird.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
	<System.ComponentModel.Browsable(False)>
	<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>
	Public Overrides Property BackgroundImageLayout() As System.Windows.Forms.ImageLayout
		Get
			Return MyBase.BackgroundImageLayout
		End Get
		Set(value As System.Windows.Forms.ImageLayout)
			MyBase.BackgroundImageLayout = value
		End Set
	End Property

	''' <summary>
	''' Ruft die diesem Steuerelement zugeordnete ContextMenuStrip-Klasse ab oder legt diese fest.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
	<System.ComponentModel.Browsable(False)>
	<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>
	Public Overrides Property ContextMenuStrip() As System.Windows.Forms.ContextMenuStrip
		Get
			Return MyBase.ContextMenuStrip
		End Get
		Set(value As System.Windows.Forms.ContextMenuStrip)
			MyBase.ContextMenuStrip = value
		End Set
	End Property

	''' <summary>
	''' Ruft ab oder legt fest, welche Steuerelementrahmen am übergeordneten Steuerelement angedockt sind, 
	''' und bestimmt, wie die Größe eines Steuerelements mit dem übergeordneten Steuerelement geändert wird.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
	<System.ComponentModel.Browsable(False)>
	<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>
	Public Overrides Property Dock() As System.Windows.Forms.DockStyle
		Get
			Return MyBase.Dock
		End Get
		Set(value As System.Windows.Forms.DockStyle)
			MyBase.Dock = value
		End Set
	End Property

	''' <summary>
	''' Ruft die Schriftart für die Anzeige von Text im Steuerelement ab oder legt diese fest.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
	<System.ComponentModel.Browsable(False)>
	<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>
	Public Overrides Property Font() As System.Drawing.Font
		Get
			Return MyBase.Font
		End Get
		Set(value As System.Drawing.Font)
			MyBase.Font = value
		End Set
	End Property

	''' <summary>
	''' Ruft die Vordergrundfarbe des Steuerelements ab oder legt diese fest.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
	<System.ComponentModel.Browsable(False)>
	<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>
	Public Overrides Property ForeColor() As System.Drawing.Color
		Get
			Return MyBase.ForeColor
		End Get
		Set(value As System.Drawing.Color)
			MyBase.ForeColor = value
		End Set
	End Property

	''' <summary>
	''' Gibt die animierte Gif-Grafik zurück oder legt diese fest.
	''' </summary>
	''' <remarks>
	''' 
	''' </remarks>
	<System.ComponentModel.Browsable(True)>
	<System.ComponentModel.Category("Appearance")>
	<System.ComponentModel.Description("Gibt die animierte Gif-Grafik zurück oder legt diese fest.")>
	Public Property Gif() As System.Drawing.Bitmap
		Get
			Return _Gif
		End Get
		Set(value As System.Drawing.Bitmap)
			_Gif = value
			GifChanged()
		End Set
	End Property

	''' <summary>
	''' Gibt die Art wie die Grafik angezeigt wird zurück oder legt diese fest.
	''' </summary>
	''' <remarks>
	''' 
	''' </remarks>
	<System.ComponentModel.Browsable(True)>
	<System.ComponentModel.Category("Behavior")>
	<System.ComponentModel.Description("Gibt die Art wie die Grafik angezeigt wird zurück oder legt diese fest.")>
	Public Property GifSizeMode() As GifSizeMode
		Get
			Return _GifSizeMode
		End Get
		Set(value As GifSizeMode)
			_GifSizeMode = value
			GifSizeModeChanged()
		End Set
	End Property

	''' <summary>
	''' Ruft einen Wert ab, der angibt, ob Elemente des Steuerelements für die Unterstützung 
	''' von Gebietsschemas ausgerichtet sind, die von rechts nach links geschriebene Schriftarten verwenden, 
	''' oder legt diesen fest.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
	<System.ComponentModel.Browsable(False)>
	<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>
	Public Overrides Property RightToLeft() As System.Windows.Forms.RightToLeft
		Get
			Return MyBase.RightToLeft
		End Get
		Set(value As System.Windows.Forms.RightToLeft)
			MyBase.RightToLeft = value
		End Set
	End Property

	''' <summary>
	''' Ruft den diesem Steuerelement zugeordneten Text ab oder legt diesen fest.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
	<System.ComponentModel.Browsable(False)>
	<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>
	Public Overrides Property Text() As String
		Get
			Return MyBase.Text
		End Get
		Set(value As String)
			MyBase.Text = value
		End Set
	End Property

#End Region


#Region "Protected Methods"

	Protected Overloads Overrides Sub Initlayout()

		MyBase.InitLayout()

		' Animation starten wenn nicht im Desigmodus und AutoPlay auf True
		If Not DesignMode And System.Drawing.ImageAnimator.CanAnimate(_Gif) Then

			System.Drawing.ImageAnimator.Animate(_Gif, AddressOf OnNextFrame)

		End If

	End Sub

	Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)

		MyBase.OnPaint(e)
		Dim g As System.Drawing.Graphics = e.Graphics

		'Variablen zur Bildberechnung
		Dim startpoint As System.Drawing.Point
		Dim startsize As System.Drawing.Size
		Dim destrec As System.Drawing.Rectangle

		'Bildgröße und Startpunkt in Abhängikeit vom Zeichenodus berechnen
		Select Case _GifSizeMode

			'wenn Bild unverändert angezeigt wird (Bild in Originalgröße und links oben)
			Case GifSizeMode.Normal
				startpoint = New System.Drawing.Point(0, 0)
				startsize = _Gif.Size
				destrec = New System.Drawing.Rectangle(startpoint, startsize)

			'wenn Bild zentriert wird (Bild in Originalgröße und zentriert)
			Case GifSizeMode.CenterImage
				startpoint = New System.Drawing.Point(CInt((Width - _Gif.Width) / 2), CInt((Height - _Gif.Height) / 2))
				startsize = _Gif.Size
				destrec = New System.Drawing.Rectangle(startpoint, startsize)

			'wenn das Bild gezoomt wird (Bild angepasst und Seitenverhältnis unverändert)
			Case GifSizeMode.Zoom
				startpoint = New System.Drawing.Point(0, 0)
				startsize = If(_Gif.Height > _Gif.Width,
					New System.Drawing.Size(CInt(Height / CDec(_Gif.Height / _Gif.Width)), Height),
					New System.Drawing.Size(Width, CInt(Width * CDec(_Gif.Height / _Gif.Width))))
				destrec = New System.Drawing.Rectangle(startpoint, startsize)

		End Select

		'Bild zeichnen
		g.DrawImage(_Gif, destrec)

		'Bild animieren wenn AutoPlay aktiv
		If Not DesignMode And AutoPlay Then System.Drawing.ImageAnimator.UpdateFrames()

	End Sub

#End Region


#Region "Private Methods"

	Private Sub GifChanged()

		' Standardanimation verwenden wenn keine Auswahl erfolgte
		If _Gif Is Nothing Then

			_Gif = My.Resources.Standard

		End If

		'neu zeichnen
		Invalidate()

		' Animation starten
		Initlayout()

	End Sub

	Private Sub InitializeStyles()

		SetStyle(System.Windows.Forms.ControlStyles.UserPaint, True)
		SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, True)
		SetStyle(System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, True)
		SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, True)

	End Sub

	Private Sub OnNextFrame(o As Object, e As System.EventArgs)

		'neu zeichnen
		Invalidate()

	End Sub

	Private Sub GifSizeModeChanged()

		'neu zeichnen
		Invalidate()

	End Sub

#End Region


#Region "Enums"


#End Region


End Class

