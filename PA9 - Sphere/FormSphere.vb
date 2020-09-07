Public Class FormSphere
    Public Bit As New Bitmap(400, 400)
    Public G As Graphics = Graphics.FromImage(Bit)

    Public xCenter, yCenter As Double

    Dim defaultR As Double = 150
    Dim defaultLong As Double = 20
    Dim defaultLat As Double = 10

    Public flagCulling As Boolean

    Public op As New operation

    'Load
    Private Sub FormSphere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim m As New matrix

        Me.KeyPreview = True

        xCenter = PictureBox.Width / 2
        yCenter = PictureBox.Height / 2

        op.dop(0) = 0
        op.dop(1) = 0
        op.dop(2) = -1

        op.radius = defaultR
        op.nLong = defaultLong
        op.nLat = defaultLat

        txtRadius.Text = op.radius
        txtLongitude.Text = op.nLong
        txtLatitude.Text = op.nLat

        For i = 0 To 2
            op.translate(i) = 0
            op.rotate(i) = 0
        Next

        txtTranslateX.Text = op.translate(0)
        txtTranslateY.Text = op.translate(1)
        txtTranslateZ.Text = op.translate(2)

        txtRotateX.Text = op.rotate(0)
        txtRotateY.Text = op.rotate(1)
        txtRotateZ.Text = op.rotate(2)

        rbOn.PerformClick()

        op.main()
    End Sub

    'translate interface
    Private Sub btnTranslatePlusX_Click(sender As Object, e As EventArgs) Handles btnTranslatePlusX.Click
        txtTranslateX.Text += 1
        btnSubmit.PerformClick()
    End Sub

    Private Sub btnTranslateMinX_Click(sender As Object, e As EventArgs) Handles btnTranslateMinX.Click
        txtTranslateX.Text -= 1
        btnSubmit.PerformClick()
    End Sub

    Private Sub btnTranslatePlusY_Click(sender As Object, e As EventArgs) Handles btnTranslatePlusY.Click
        txtTranslateY.Text += 1
        btnSubmit.PerformClick()
    End Sub

    Private Sub btnTranslateMinY_Click(sender As Object, e As EventArgs) Handles btnTranslateMinY.Click
        txtTranslateY.Text -= 1
        btnSubmit.PerformClick()
    End Sub

    Private Sub btnTranslatePlusZ_Click(sender As Object, e As EventArgs) Handles btnTranslatePlusZ.Click
        txtTranslateZ.Text += 1
        btnSubmit.PerformClick()
    End Sub

    Private Sub btnTranslateMinZ_Click(sender As Object, e As EventArgs) Handles btnTranslateMinZ.Click
        txtTranslateZ.Text -= 1
        btnSubmit.PerformClick()
    End Sub

    Private Sub btnResetTranslate_Click(sender As Object, e As EventArgs) Handles btnResetTranslate.Click
        txtTranslateX.Text = 0
        txtTranslateY.Text = 0
        txtTranslateZ.Text = 0

        btnSubmit.PerformClick()
    End Sub

    'rotate interface
    Private Sub btnRotatePlusX_Click(sender As Object, e As EventArgs) Handles btnRotatePlusX.Click
        txtRotateX.Text += 1
        btnSubmit.PerformClick()
    End Sub

    Private Sub btnRotateMinX_Click(sender As Object, e As EventArgs) Handles btnRotateMinX.Click
        txtRotateX.Text -= 1
        btnSubmit.PerformClick()
    End Sub

    Private Sub btnRotatePlusY_Click(sender As Object, e As EventArgs) Handles btnRotatePlusY.Click
        txtRotateY.Text += 1
        btnSubmit.PerformClick()
    End Sub

    Private Sub btnRotateMinY_Click(sender As Object, e As EventArgs) Handles btnRotateMinY.Click
        txtRotateY.Text -= 1
        btnSubmit.PerformClick()
    End Sub

    Private Sub btnRotatePlusZ_Click(sender As Object, e As EventArgs) Handles btnRotatePlusZ.Click
        txtRotateZ.Text += 1
        btnSubmit.PerformClick()
    End Sub

    Private Sub btnRotateMinZ_Click(sender As Object, e As EventArgs) Handles btnRotateMinZ.Click
        txtRotateZ.Text -= 1
        btnSubmit.PerformClick()
    End Sub

    Private Sub btnResetRotate_Click(sender As Object, e As EventArgs) Handles btnResetRotate.Click
        txtRotateX.Text = 0
        txtRotateY.Text = 0
        txtRotateZ.Text = 0

        btnSubmit.PerformClick()
    End Sub

    'radius interface
    Private Sub btnPlusRad_Click(sender As Object, e As EventArgs) Handles btnPlusRad.Click
        txtRadius.Text += 1
        btnSubmit.PerformClick()
    End Sub

    Private Sub btnMinRad_Click(sender As Object, e As EventArgs) Handles btnMinRad.Click
        txtRadius.Text -= 1
        btnSubmit.PerformClick()
    End Sub

    Private Sub btnResetRad_Click(sender As Object, e As EventArgs) Handles btnResetRad.Click
        txtRadius.Text = defaultR
        btnSubmit.PerformClick()
    End Sub

    'latitude interface
    Private Sub btnPlusLat_Click(sender As Object, e As EventArgs) Handles btnPlusLat.Click
        txtLatitude.Text += 1
        btnSubmit.PerformClick()
    End Sub

    Private Sub btnMinLat_Click(sender As Object, e As EventArgs) Handles btnMinLat.Click
        txtLatitude.Text -= 1
        btnSubmit.PerformClick()
    End Sub

    Private Sub btnResetLat_Click(sender As Object, e As EventArgs) Handles btnResetLat.Click
        txtLatitude.Text = defaultLat
        btnSubmit.PerformClick()
    End Sub

    'longitude interface
    Private Sub btnPlusLong_Click(sender As Object, e As EventArgs) Handles btnPlusLong.Click
        txtLongitude.Text += 1
        btnSubmit.PerformClick()
    End Sub

    Private Sub btnMinLong_Click(sender As Object, e As EventArgs) Handles btnMinLong.Click
        txtLongitude.Text -= 1
        btnSubmit.PerformClick()
    End Sub

    Private Sub btnResetLong_Click(sender As Object, e As EventArgs) Handles btnResetLong.Click
        txtLongitude.Text = defaultLong
        btnSubmit.PerformClick()
    End Sub

    'back face culling interface
    Private Sub rbOn_CheckedChanged(sender As Object, e As EventArgs) Handles rbOn.CheckedChanged
        flagCulling = True
        btnSubmit.PerformClick()
    End Sub

    Private Sub rbOff_CheckedChanged(sender As Object, e As EventArgs) Handles rbOff.CheckedChanged
        flagCulling = False
        btnSubmit.PerformClick()
    End Sub

    'submit
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        op.radius = txtRadius.Text
        op.nLat = txtLatitude.Text
        op.nLong = txtLongitude.Text

        op.translate(0) = txtTranslateX.Text
        op.translate(1) = txtTranslateY.Text
        op.translate(2) = txtTranslateZ.Text

        op.rotate(0) = Math.PI * txtRotateX.Text / 180.0
        op.rotate(1) = Math.PI * txtRotateY.Text / 180.0
        op.rotate(2) = Math.PI * txtRotateZ.Text / 180.0

        op.reset()
        op.main()
    End Sub

    Private Sub FormSphere_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnSubmit.PerformClick()
        End If
    End Sub

End Class





