' ****************************************************************************************************************
' SizeMode.vb
' © 2023 - 2024 by Andreas Sauer
' ****************************************************************************************************************
'

''' <summary>Auflistung der Anzeigemodi</summary>
Public Enum SizeMode

	''' <summary>Die Grafik wird in Originalgröße angezeigt.</summary>
	''' <remarks>Ausrichtung oben links.</remarks>
	Normal = 0

	''' <summary>Die Grafik wird in Originalgröße angezeigt.</summary>
	''' <remarks>zentrierte Ausrichtung.</remarks>
	CenterImage = 1

	''' <summary>Die Grafik wird an die Größe des Controls angepasst.</summary>
	''' <remarks>zentrierte Ausrichtung.</remarks>
	Zoom = 2

End Enum
