
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim LabelAnsicht As System.Windows.Forms.Label
        Dim LabelFramesPerSecond As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim LabelZoomFactor As System.Windows.Forms.Label
        Me.ComboBoxAnsicht = New System.Windows.Forms.ComboBox()
        Me.CheckBoxAutoplay = New System.Windows.Forms.CheckBox()
        Me.LabelAni = New System.Windows.Forms.Label()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.ButtonForward = New System.Windows.Forms.Button()
        Me.CheckBoxCustomDisplaySpeed = New System.Windows.Forms.CheckBox()
        Me.NumericUpDownFramesPerSecond = New System.Windows.Forms.NumericUpDown()
        Me.AniGif1 = New SchlumpfSoft.Controls.AniGifControl.AniGif()
        Me.NumericUpDownZoomFactor = New System.Windows.Forms.NumericUpDown()
        LabelAnsicht = New System.Windows.Forms.Label()
        LabelFramesPerSecond = New System.Windows.Forms.Label()
        LabelZoomFactor = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownFramesPerSecond, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownZoomFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelAnsicht
        '
        LabelAnsicht.AutoSize = True
        LabelAnsicht.ImeMode = System.Windows.Forms.ImeMode.NoControl
        LabelAnsicht.Location = New System.Drawing.Point(256, 16)
        LabelAnsicht.Name = "LabelAnsicht"
        LabelAnsicht.Size = New System.Drawing.Size(42, 13)
        LabelAnsicht.TabIndex = 2
        LabelAnsicht.Text = "Ansicht"
        '
        'LabelFramesPerSecond
        '
        LabelFramesPerSecond.AutoSize = True
        LabelFramesPerSecond.Location = New System.Drawing.Point(256, 105)
        LabelFramesPerSecond.Name = "LabelFramesPerSecond"
        LabelFramesPerSecond.Size = New System.Drawing.Size(81, 13)
        LabelFramesPerSecond.TabIndex = 10
        LabelFramesPerSecond.Text = "Bilder/Sekunde"
        '
        'ComboBoxAnsicht
        '
        Me.ComboBoxAnsicht.FormattingEnabled = True
        Me.ComboBoxAnsicht.Items.AddRange(New Object() {"Normal", "Zentriert", "Zoom"})
        Me.ComboBoxAnsicht.Location = New System.Drawing.Point(316, 12)
        Me.ComboBoxAnsicht.Name = "ComboBoxAnsicht"
        Me.ComboBoxAnsicht.Size = New System.Drawing.Size(116, 21)
        Me.ComboBoxAnsicht.TabIndex = 1
        '
        'CheckBoxAutoplay
        '
        Me.CheckBoxAutoplay.AutoSize = True
        Me.CheckBoxAutoplay.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBoxAutoplay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CheckBoxAutoplay.Location = New System.Drawing.Point(256, 44)
        Me.CheckBoxAutoplay.Name = "CheckBoxAutoplay"
        Me.CheckBoxAutoplay.Size = New System.Drawing.Size(67, 17)
        Me.CheckBoxAutoplay.TabIndex = 3
        Me.CheckBoxAutoplay.Text = "Autoplay"
        Me.CheckBoxAutoplay.UseVisualStyleBackColor = True
        '
        'LabelAni
        '
        Me.LabelAni.AutoSize = True
        Me.LabelAni.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelAni.Location = New System.Drawing.Point(256, 155)
        Me.LabelAni.Name = "LabelAni"
        Me.LabelAni.Size = New System.Drawing.Size(50, 13)
        Me.LabelAni.TabIndex = 4
        Me.LabelAni.Text = "Standard"
        '
        'ButtonBack
        '
        Me.ButtonBack.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonBack.Location = New System.Drawing.Point(259, 182)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(81, 24)
        Me.ButtonBack.TabIndex = 5
        Me.ButtonBack.Text = "zurück"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'ButtonForward
        '
        Me.ButtonForward.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonForward.Location = New System.Drawing.Point(354, 182)
        Me.ButtonForward.Name = "ButtonForward"
        Me.ButtonForward.Size = New System.Drawing.Size(78, 24)
        Me.ButtonForward.TabIndex = 6
        Me.ButtonForward.Text = "Vorwärts"
        Me.ButtonForward.UseVisualStyleBackColor = True
        '
        'CheckBoxCustomDisplaySpeed
        '
        Me.CheckBoxCustomDisplaySpeed.AutoSize = True
        Me.CheckBoxCustomDisplaySpeed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBoxCustomDisplaySpeed.Location = New System.Drawing.Point(256, 67)
        Me.CheckBoxCustomDisplaySpeed.Name = "CheckBoxCustomDisplaySpeed"
        Me.CheckBoxCustomDisplaySpeed.Size = New System.Drawing.Size(140, 30)
        Me.CheckBoxCustomDisplaySpeed.TabIndex = 8
        Me.CheckBoxCustomDisplaySpeed.Text = "Benutzerdefinierte" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Anzeigegeschwindigkeit"
        Me.CheckBoxCustomDisplaySpeed.UseVisualStyleBackColor = True
        '
        'NumericUpDownFramesPerSecond
        '
        Me.NumericUpDownFramesPerSecond.Location = New System.Drawing.Point(355, 103)
        Me.NumericUpDownFramesPerSecond.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericUpDownFramesPerSecond.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownFramesPerSecond.Name = "NumericUpDownFramesPerSecond"
        Me.NumericUpDownFramesPerSecond.Size = New System.Drawing.Size(41, 20)
        Me.NumericUpDownFramesPerSecond.TabIndex = 9
        Me.NumericUpDownFramesPerSecond.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.NumericUpDownFramesPerSecond.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'AniGif1
        '
        Me.AniGif1.AutoPlay = False
        Me.AniGif1.CustomDisplaySpeed = False
        Me.AniGif1.FramesPerSecond = New Decimal(New Integer() {6, 0, 0, 0})
        Me.AniGif1.Gif = CType(resources.GetObject("AniGif1.Gif"), System.Drawing.Bitmap)
        Me.AniGif1.GifSizeMode = SchlumpfSoft.Controls.AniGifControl.SizeMode.Normal
        Me.AniGif1.Location = New System.Drawing.Point(11, 12)
        Me.AniGif1.Name = "AniGif1"
        Me.AniGif1.Size = New System.Drawing.Size(229, 237)
        Me.AniGif1.TabIndex = 7
        Me.AniGif1.ZoomFactor = 50
        '
        'LabelZoomFactor
        '
        LabelZoomFactor.AutoSize = True
        LabelZoomFactor.Location = New System.Drawing.Point(256, 132)
        LabelZoomFactor.Name = "LabelZoomFactor"
        LabelZoomFactor.Size = New System.Drawing.Size(61, 13)
        LabelZoomFactor.TabIndex = 11
        LabelZoomFactor.Text = "Zoomfaktor"
        '
        'NumericUpDownZoomFactor
        '
        Me.NumericUpDownZoomFactor.Location = New System.Drawing.Point(355, 129)
        Me.NumericUpDownZoomFactor.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownZoomFactor.Name = "NumericUpDownZoomFactor"
        Me.NumericUpDownZoomFactor.Size = New System.Drawing.Size(41, 20)
        Me.NumericUpDownZoomFactor.TabIndex = 12
        Me.NumericUpDownZoomFactor.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.NumericUpDownZoomFactor.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 265)
        Me.Controls.Add(Me.NumericUpDownZoomFactor)
        Me.Controls.Add(LabelZoomFactor)
        Me.Controls.Add(LabelFramesPerSecond)
        Me.Controls.Add(Me.NumericUpDownFramesPerSecond)
        Me.Controls.Add(Me.CheckBoxCustomDisplaySpeed)
        Me.Controls.Add(Me.AniGif1)
        Me.Controls.Add(Me.ButtonForward)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.LabelAni)
        Me.Controls.Add(Me.CheckBoxAutoplay)
        Me.Controls.Add(LabelAnsicht)
        Me.Controls.Add(Me.ComboBoxAnsicht)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NumericUpDownFramesPerSecond, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownZoomFactor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelAni As Label
    Friend WithEvents ButtonBack As Button
    Friend WithEvents ButtonForward As Button
    Friend WithEvents AniGif1 As Controls.AniGifControl.AniGif
    Private WithEvents CheckBoxCustomDisplaySpeed As CheckBox
    Private WithEvents NumericUpDownFramesPerSecond As NumericUpDown
    Private WithEvents ComboBoxAnsicht As ComboBox
    Private WithEvents CheckBoxAutoplay As CheckBox
    Private WithEvents NumericUpDownZoomFactor As NumericUpDown
End Class
