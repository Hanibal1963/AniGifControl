# AniGif Control

Ein Steuerelement welches zum Anzeigen animierter Grafiken dient.

---

## Einf�hrung

Grundlage und Anregung f�r dieses Steuerelement stammen aus dem Buch 
**"Visual Basic 2015 - Grundlagen und Profiwissen"** von Walter Dobrenz und Thomas Gewinnus.

Der ursp�ngliche Quelltext wurde von mir ver�ndert und um weitere Funktionen erweitert.

Dieser Code sollte f�r mich als �bung dienen und ich denke das er auch f�r andere Anf�nger 
interessant sein d�rfte.

Weitere Infos unter: 

[Autoren-Website von Walter Doberenz & Thomas Gewinnus](https://sites.google.com/site/dokobuch/home/dfsfs/vb-net-2015) 

---

## Eigenschaften

-  **Gif** - Gibt die animierte Gif-Grafik zur�ck oder legt diese fest.
-  **AutoPlay** - Legt fest ob die Animation sofort nach dem laden gestartet wird.
-  **GifSizeMode** - Gibt die Art wie die Grafik angezeigt wird zur�ck oder legt diese fest.
-  **CustomDisplaySpeed** - Legt fest ob die im Bild gespeicherte Anzeigegeschwindigkeit oder die benutzerdefinierte verwendet werden soll.
-  **FramesPerSecond** - Legt die Anzahl der Bilder pro Sekunde fest (1-50) die angezeigt werden, wenn die Benutzerdefinierte Geschwindigkeit aktiv ist.
-  **ZoomFaktor** - Legt den Zoomfaktor f�r GifSizeMode "Zoom" in % (1-100) fest.

---

## Anzeigemodi

Die Eigenschaft **"GifSizeMode"** kann folgende Werte annehmen:

-  **Normal** - Die Grafik wird in Originalgr��e angezeigt (Ausrichtung oben links)
-  **CenterImage** - Die Grafik wird in Originalgr��e angezeigt (zentrierte Ausrichtung)
-  **Zoom** - Die Grafik wird an die Gr��e des Steuerelementes angepasst (Die gr��ere Ausdehnung der Grafik wird als Anpassung verwendet, die Ausrichtung erfolgt zentriert und das Seitenverh�ltnis bleibt erhalten)

---

## Ereignisse

-  **NoAnimation** - wird ausgel�st, wenn das Bild nicht animiert werden kann.

---

## geplante �nderungen und Funktionen

- [X] Funktion f�r das festlegen einer benutzerdefinierten Anzeigegeschwindigkeit.
- [X] Funktion f�r das �ndern des Zoomfaktors wenn der Anzeigemodus Zoom ist.

---

## Weitere Literatur

-  [Erstellen eines Windows Forms-Toolbox-Steuerelements](https://docs.microsoft.com/de-de/visualstudio/extensibility/creating-a-windows-forms-toolbox-control?view=vs-2022)
-  [Infos zur ControlStyles Enumeration](https://learn.microsoft.com/de-de/dotnet/api/system.windows.forms.controlstyles?redirectedfrom=MSDN&view=netframework-4.7.2)
-  [Control-Techniken: Eigenes Toolboxicon f�r Steuerelement](https://www.vb-paradise.de/index.php/Thread/123746-Control-Techniken-Eigenes-Toolboxicon-f%C3%BCr-Steuerelement/)
-  [FrameDelays von animierter GIF](https://foren.activevb.de/archiv/vb-net/thread-93030/beitrag-93069/FrameDelays-von-animierter-GIF/)

---

## History

### Version 1.2024.0322.00

Datum: 22.03.2024 - 3.Releaseversion

Funktion zum �ndern des Zoomfaktors hinzugef�gt wenn der Anzeigemodus Zoom aktiv ist.

### Version 1.2024.0317.00

Datum: 17.03.2024 - 2.Releaseversion 

Funktionen zum �ndern der Anzeigegeschwindigkeit hinzugef�gt.

### Version 1.2024.0128.00 

Datum: 28.01.2024 - 1.Releaseversion

Alle noch eventuell vorherigen versionen sind experimenteller Natur.