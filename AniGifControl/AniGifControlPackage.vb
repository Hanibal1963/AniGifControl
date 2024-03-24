' ****************************************************************************************************************
' AniGifControlPackage.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System
Imports System.Runtime.InteropServices
Imports System.Threading
Imports Microsoft.VisualStudio.Shell
Imports System.Threading.Tasks


''' <summary>Dies ist die Klasse, die das von dieser Assembly bereitgestellte Paket implementiert.</summary>
''' <remarks>
''' <para>
''' Die Mindestanforderung dafür, dass eine Klasse als gültiges Paket für Visual Studio betrachtet wird, 
''' besteht darin, die IVs-Paketschnittstelle zu implementieren und sich bei der Shell zu registrieren. 
''' Dieses Paket verwendet dazu die im Managed Package Framework (MPF) definierten Hilfsklassen: 
''' Es leitet sich von der Paketklasse ab, die die Implementierung der IVs-Paketschnittstelle bereitstellt, 
''' und verwendet die im Framework definierten Registrierungsattribute, 
''' um sich selbst und seine Komponenten zu registrieren die Muschel. 
''' Diese Attribute teilen dem pkgdef-Erstellungsdienstprogramm mit, welche Daten in die .pkgdef-Datei 
''' eingefügt werden sollen.
''' </para>
''' <para>
''' Um in VS geladen zu werden, muss in der .vsixmanifest-Datei auf das Paket mit 
''' &lt;Asset Type="Microsoft.Visual Studio.Vs Package" ...&gt; verwiesen werden.
''' </para>
''' </remarks>
<PackageRegistration(UseManagedResourcesOnly:=True, AllowsBackgroundLoading:=True)>
<Guid(AniGifControlPackage.PackageGuidString)>
Public NotInheritable Class AniGifControlPackage

    Inherits AsyncPackage

    ''' <summary>Package guid</summary>
    Public Const PackageGuidString As String = "3d2e432d-b0c9-4669-864b-c590b7b66371"

    ''' <summary>
    ''' Initialisierung des Pakets; 
    ''' Diese Methode wird direkt nach der Platzierung des Pakets aufgerufen. 
    ''' Daher können Sie hier den gesamten Initialisierungscode ablegen, der auf den von Visual Studio 
    ''' bereitgestellten Diensten basiert.
    ''' </summary>
    ''' <param name="cancellationToken">
    ''' Ein Abbruchtoken zur Überwachung des Initialisierungsabbruchs, 
    ''' der beim Herunterfahren von VS auftreten kann.
    ''' </param>
    ''' <param name="progress">
    ''' Ein Anbieter für Fortschrittsaktualisierungen.
    ''' </param>
    ''' <returns>
    ''' Eine Aufgabe, die die asynchrone Arbeit der Paketinitialisierung darstellt, 
    ''' oder eine bereits abgeschlossene Aufgabe, wenn keine vorhanden ist. 
    ''' Geben Sie von dieser Methode nicht null zurück.
    ''' </returns>
    Protected Overrides Async Function InitializeAsync(
              cancellationToken As CancellationToken,
              progress As IProgress(Of ServiceProgressData)) As Task

        'Bei asynchroner Initialisierung kann der aktuelle Thread zu diesem Zeitpunkt
        'ein Hintergrundthread sein.
        'Führen Sie alle Initialisierungen durch, die den UI-Thread erfordern,
        'nachdem Sie zum UI-Thread gewechselt haben.
        Await Me.JoinableTaskFactory.SwitchToMainThreadAsync()

    End Function

End Class
