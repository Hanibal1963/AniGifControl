'
'****************************************************************************************************************
'AniGifControlPackage.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'


''' <summary>
''' Dies ist die Klasse, die das von dieser Assembly verfügbar gemachte Paket implementiert.
''' </summary>
''' <remarks>
''' <para>
''' Die Mindestanforderung, damit eine Klasse als gültiges Paket für Visual Studio betrachtet wird
''' Soll die IVs-Paketschnittstelle implementieren und sich bei der Shell registrieren.
''' Dieses Paket verwendet die im Managed Package Framework (MPF) definierten Hilfsklassen
''' um es zu tun: Es leitet sich von der Paketklasse ab, die die Implementierung von bereitstellt
''' IVs Package Interface Und verwendet die im Framework definierten Registrierungsattribute
''' sich selbst und seine Komponenten bei der Shell registrieren.
''' Diese Attribute teilen die Erstellung von pkgdef mit Dienstprogramm, 
''' welche Daten in die .pkgdef-Datei eingefügt werden sollen.
''' </para>
''' <para>
''' Um in VS geladen zu werden, muss das Paket von &lt;Asset Type="Microsoft.Visual Studio.Vs Package" ...&gt; 
''' in der .vsixmanifest-Datei.
''' </para>
''' </remarks>
<Microsoft.VisualStudio.Shell.PackageRegistration(UseManagedResourcesOnly:=True, AllowsBackgroundLoading:=True)>
<System.Runtime.InteropServices.Guid(AniGifControlPackage.PackageGuidString)>
Public NotInheritable Class AniGifControlPackage
    Inherits Microsoft.VisualStudio.Shell.AsyncPackage

    ''' <summary>
    ''' Package guid
    ''' </summary>
    Public Const PackageGuidString As String = "116416ff-4b0d-446c-82a3-dcdb6e0b0611"

#Region "Package Members"

    ''' <summary>
    ''' Initialisierung des Pakets; Diese Methode wird direkt nach der Platzierung des Pakets aufgerufen, 
    ''' also ist dies der richtige Ort wo Sie den gesamten Initialisierungscode einfügen können, 
    ''' der sich auf die von Visual Studio bereitgestellten Dienste stützt.
    ''' </summary>
    ''' <param name="cancellationToken">
    ''' Ein Abbruchtoken zum Überwachen des Initialisierungsabbruchs, der auftreten kann, wenn VS heruntergefahren wird.
    ''' </param>
    ''' <param name="progress">
    ''' Ein Anbieter für Fortschrittsaktualisierungen.
    ''' </param>
    ''' <returns>
    ''' Eine Aufgabe, die die asynchrone Arbeit der Paketinitialisierung darstellt, 
    ''' oder eine bereits abgeschlossene Aufgabe, falls keine vorhanden ist. 
    ''' Geben Sie von dieser Methode nicht null zurück.
    ''' </returns>
    Protected Overrides Async Function InitializeAsync(cancellationToken As System.Threading.CancellationToken,
            progress As System.IProgress(Of Microsoft.VisualStudio.Shell.ServiceProgressData)) As System.Threading.Tasks.Task
        ' Bei asynchroner Initialisierung kann der aktuelle Thread zu diesem Zeitpunkt ein Hintergrundthread sein.
        ' Führen Sie alle Initialisierungen durch, die den UI-Thread erfordern, nachdem Sie zum UI-Thread gewechselt haben.
        Await Me.JoinableTaskFactory.SwitchToMainThreadAsync()
    End Function

#End Region

End Class
