# AniGif Control

Ein Steuerelement welches zum Anzeigen animierter Grafiken dient.

---

## Einführung

Grundlage und Anregung für dieses Steuerelement stammen aus dem Buch 
**"Visual Basic 2015 - Grundlagen und Profiwissen"** von Walter Dobrenz und Thomas Gewinnus.

Der urspüngliche Quelltext wurde von mir verändert und um weitere Funktionen erweitert.

Dieser Code sollte für mich als Übung dienen und ich denke das er auch für andere Anfänger 
interessant sein dürfte.

Weitere Infos unter: 

[Autoren-Website von Walter Doberenz & Thomas Gewinnus](https://sites.google.com/site/dokobuch/home/dfsfs/vb-net-2015) 

---

## Eigenschaften

-  **Gif** - Gibt die animierte Gif-Grafik zurück oder legt diese fest.
-  **AutoPlay** - Legt fest ob die Animation sofort nach dem laden gestartet wird.
-  **GifSizeMode** - Gibt die Art wie die Grafik angezeigt wird zurück oder legt diese fest.
-  **CustomDisplaySpeed** - Legt fest ob die im Bild gespeicherte Anzeigegeschwindigkeit oder die benutzerdefinierte verwendet werden soll.
-  **FramesPerSecond** - Legt die Anzahl der Bilder pro Sekunde fest (1-50) die angezeigt werden, wenn die Benutzerdefinierte Geschwindigkeit aktiv ist.
-  **ZoomFaktor** - Legt den Zoomfaktor für GifSizeMode "Zoom" in % (1-100) fest.

---

## Anzeigemodi

Die Eigenschaft **"GifSizeMode"** kann folgende Werte annehmen:

-  **Normal** - Die Grafik wird in Originalgröße angezeigt (Ausrichtung oben links)
-  **CenterImage** - Die Grafik wird in Originalgröße angezeigt (zentrierte Ausrichtung)
-  **Zoom** - Die Grafik wird an die Größe des Steuerelementes angepasst (Die größere Ausdehnung der Grafik wird als Anpassung verwendet, die Ausrichtung erfolgt zentriert und das Seitenverhältnis bleibt erhalten)

---

## Ereignisse

-  **NoAnimation** - wird ausgelöst, wenn das Bild nicht animiert werden kann.

---

## geplante Änderungen und Funktionen

- [X] Funktion für das festlegen einer benutzerdefinierten Anzeigegeschwindigkeit.
- [X] Funktion für das ändern des Zoomfaktors wenn der Anzeigemodus Zoom ist.

---

## Weitere Literatur

-  [Erstellen eines Windows Forms-Toolbox-Steuerelements](https://docs.microsoft.com/de-de/visualstudio/extensibility/creating-a-windows-forms-toolbox-control?view=vs-2022)
-  [Infos zur ControlStyles Enumeration](https://learn.microsoft.com/de-de/dotnet/api/system.windows.forms.controlstyles?redirectedfrom=MSDN&view=netframework-4.7.2)
-  [Control-Techniken: Eigenes Toolboxicon für Steuerelement](https://www.vb-paradise.de/index.php/Thread/123746-Control-Techniken-Eigenes-Toolboxicon-f%C3%BCr-Steuerelement/)
-  [FrameDelays von animierter GIF](https://foren.activevb.de/archiv/vb-net/thread-93030/beitrag-93069/FrameDelays-von-animierter-GIF/)

---

## History

### Version 1.2024.0322.00

Datum: 22.03.2024 - 3.Releaseversion

Funktion zum ändern des Zoomfaktors hinzugefügt wenn der Anzeigemodus Zoom aktiv ist.

### Version 1.2024.0317.00

Datum: 17.03.2024 - 2.Releaseversion 

Funktionen zum ändern der Anzeigegeschwindigkeit hinzugefügt.

### Version 1.2024.0128.00 

Datum: 28.01.2024 - 1.Releaseversion

Alle noch eventuell vorherigen versionen sind experimenteller Natur.