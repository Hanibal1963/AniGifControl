'
'****************************************************************************************************************
'FormMain.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'


Public Class FormMain


	Private Const ANINAME = "Anim{0}"
	Private Const MESSAGE = "Animation {0} wird gezeigt."


	Private _Aninumber As Integer = 0

	Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load

		'automatisch abspielen aktivieren
		AniGif1.AutoPlay = True
		CheckBox1.CheckState = CheckState.Checked

		'Rahmenart "ohne" auswählen
		AniGif1.BorderStyle = BorderStyle.None
		ComboBox1.SelectedIndex = 0

		'Anzeigeart "normal" auswählen
		AniGif1.GifSizeMode = SchlumpfSoft.Controls.GifSizeMode.Normal
		ComboBox2.SelectedIndex = 0

		'Animation wechseln
		ChangeAnimation(_Aninumber)

	End Sub

	Private Sub ChangeAnimation(Aninumber As Integer)

		If Aninumber = 0 Then
			AniGif1.Gif = Nothing
			Label1.Text = "Standardanimation wird angezeigt"
			Exit Sub
		End If

		Dim resname As String = String.Format(ANINAME, _Aninumber + 100)
		AniGif1.Gif = CType(My.Resources.ResourceManager.GetObject(resname), Bitmap)

		Label1.Text = String.Format(MESSAGE, _Aninumber.ToString)

	End Sub

	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
		AniGif1.AutoPlay = CType(sender, CheckBox).Checked
	End Sub


	Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

		Select Case CType(sender, ComboBox).SelectedIndex

			Case 0 : AniGif1.BorderStyle = BorderStyle.None
			Case 1 : AniGif1.BorderStyle = BorderStyle.FixedSingle
			Case 2 : AniGif1.BorderStyle = BorderStyle.Fixed3D

		End Select

	End Sub


	Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

		Select Case CType(sender, ComboBox).SelectedIndex

			Case 0 : AniGif1.GifSizeMode = SchlumpfSoft.Controls.GifSizeMode.Normal
			Case 1 : AniGif1.GifSizeMode = SchlumpfSoft.Controls.GifSizeMode.CenterImage
			Case 2 : AniGif1.GifSizeMode = SchlumpfSoft.Controls.GifSizeMode.Zoom

		End Select

	End Sub


	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		_Aninumber -= 1
		If _Aninumber < 0 Then _Aninumber = 0
		ChangeAnimation(_Aninumber)

	End Sub


	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

		_Aninumber += 1
		If _Aninumber > 17 Then _Aninumber = 17
		ChangeAnimation(_Aninumber)

	End Sub


End Class
