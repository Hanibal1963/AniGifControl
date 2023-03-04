<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.ComboBox2 = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.AniGif1 = New SchlumpfSoft.Controls.AniGif()
		Me.SuspendLayout()
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.CheckBox1.Checked = True
		Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
		Me.CheckBox1.Location = New System.Drawing.Point(202, 20)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(180, 17)
		Me.CheckBox1.TabIndex = 1
		Me.CheckBox1.Text = "Animation automatisch abspielen"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(13, 216)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(52, 23)
		Me.Button1.TabIndex = 2
		Me.Button1.Text = "<<"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(330, 216)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(52, 23)
		Me.Button2.TabIndex = 3
		Me.Button2.Text = ">>"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label1.Location = New System.Drawing.Point(71, 216)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(253, 23)
		Me.Label1.TabIndex = 4
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Items.AddRange(New Object() {"kein", "einfach", "3D"})
		Me.ComboBox1.Location = New System.Drawing.Point(274, 57)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(108, 21)
		Me.ComboBox1.TabIndex = 5
		'
		'ComboBox2
		'
		Me.ComboBox2.FormattingEnabled = True
		Me.ComboBox2.Items.AddRange(New Object() {"normal", "zentriert", "zoom"})
		Me.ComboBox2.Location = New System.Drawing.Point(274, 96)
		Me.ComboBox2.Name = "ComboBox2"
		Me.ComboBox2.Size = New System.Drawing.Size(108, 21)
		Me.ComboBox2.TabIndex = 6
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(202, 60)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(59, 13)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "Rahmenart"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(202, 99)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(57, 13)
		Me.Label3.TabIndex = 8
		Me.Label3.Text = "Anzeigeart"
		'
		'AniGif1
		'
		Me.AniGif1.AutoPlay = False
		Me.AniGif1.AutoScrollMargin = New System.Drawing.Size(0, 0)
		Me.AniGif1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
		Me.AniGif1.Gif = CType(resources.GetObject("AniGif1.Gif"), System.Drawing.Bitmap)
		Me.AniGif1.GifSizeMode = SchlumpfSoft.Controls.GifSizeMode.Normal
		Me.AniGif1.Location = New System.Drawing.Point(12, 12)
		Me.AniGif1.Name = "AniGif1"
		Me.AniGif1.Size = New System.Drawing.Size(184, 184)
		Me.AniGif1.TabIndex = 9
		'
		'FormMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(396, 251)
		Me.Controls.Add(Me.AniGif1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.ComboBox2)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.CheckBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FormMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "AniGif Demoprogramm"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents ComboBox2 As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents AniGif1 As Controls.AniGif
End Class
