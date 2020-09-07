<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSphere
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpTranslate = New System.Windows.Forms.GroupBox()
        Me.btnResetTranslate = New System.Windows.Forms.Button()
        Me.btnTranslateMinZ = New System.Windows.Forms.Button()
        Me.btnTranslatePlusZ = New System.Windows.Forms.Button()
        Me.btnTranslateMinY = New System.Windows.Forms.Button()
        Me.btnTranslatePlusY = New System.Windows.Forms.Button()
        Me.btnTranslateMinX = New System.Windows.Forms.Button()
        Me.btnTranslatePlusX = New System.Windows.Forms.Button()
        Me.txtTranslateZ = New System.Windows.Forms.TextBox()
        Me.txtTranslateY = New System.Windows.Forms.TextBox()
        Me.txtTranslateX = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.grpRotate = New System.Windows.Forms.GroupBox()
        Me.btnResetRotate = New System.Windows.Forms.Button()
        Me.btnRotateMinZ = New System.Windows.Forms.Button()
        Me.btnRotatePlusZ = New System.Windows.Forms.Button()
        Me.btnRotateMinY = New System.Windows.Forms.Button()
        Me.btnRotatePlusY = New System.Windows.Forms.Button()
        Me.btnRotateMinX = New System.Windows.Forms.Button()
        Me.btnRotatePlusX = New System.Windows.Forms.Button()
        Me.txtRotateZ = New System.Windows.Forms.TextBox()
        Me.txtRotateY = New System.Windows.Forms.TextBox()
        Me.txtRotateX = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpRadius = New System.Windows.Forms.GroupBox()
        Me.btnResetRad = New System.Windows.Forms.Button()
        Me.btnMinRad = New System.Windows.Forms.Button()
        Me.btnPlusRad = New System.Windows.Forms.Button()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.grpLatitude = New System.Windows.Forms.GroupBox()
        Me.btnResetLat = New System.Windows.Forms.Button()
        Me.btnMinLat = New System.Windows.Forms.Button()
        Me.btnPlusLat = New System.Windows.Forms.Button()
        Me.txtLatitude = New System.Windows.Forms.TextBox()
        Me.grpLongitude = New System.Windows.Forms.GroupBox()
        Me.btnResetLong = New System.Windows.Forms.Button()
        Me.btnMinLong = New System.Windows.Forms.Button()
        Me.btnPlusLong = New System.Windows.Forms.Button()
        Me.txtLongitude = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbOff = New System.Windows.Forms.RadioButton()
        Me.rbOn = New System.Windows.Forms.RadioButton()
        Me.grpTranslate.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRotate.SuspendLayout()
        Me.grpRadius.SuspendLayout()
        Me.grpLatitude.SuspendLayout()
        Me.grpLongitude.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTranslate
        '
        Me.grpTranslate.Controls.Add(Me.btnResetTranslate)
        Me.grpTranslate.Controls.Add(Me.btnTranslateMinZ)
        Me.grpTranslate.Controls.Add(Me.btnTranslatePlusZ)
        Me.grpTranslate.Controls.Add(Me.btnTranslateMinY)
        Me.grpTranslate.Controls.Add(Me.btnTranslatePlusY)
        Me.grpTranslate.Controls.Add(Me.btnTranslateMinX)
        Me.grpTranslate.Controls.Add(Me.btnTranslatePlusX)
        Me.grpTranslate.Controls.Add(Me.txtTranslateZ)
        Me.grpTranslate.Controls.Add(Me.txtTranslateY)
        Me.grpTranslate.Controls.Add(Me.txtTranslateX)
        Me.grpTranslate.Controls.Add(Me.Label3)
        Me.grpTranslate.Controls.Add(Me.Label2)
        Me.grpTranslate.Controls.Add(Me.Label1)
        Me.grpTranslate.Location = New System.Drawing.Point(441, 13)
        Me.grpTranslate.Name = "grpTranslate"
        Me.grpTranslate.Size = New System.Drawing.Size(195, 161)
        Me.grpTranslate.TabIndex = 0
        Me.grpTranslate.TabStop = False
        Me.grpTranslate.Text = "Translate"
        '
        'btnResetTranslate
        '
        Me.btnResetTranslate.Location = New System.Drawing.Point(10, 129)
        Me.btnResetTranslate.Name = "btnResetTranslate"
        Me.btnResetTranslate.Size = New System.Drawing.Size(167, 23)
        Me.btnResetTranslate.TabIndex = 13
        Me.btnResetTranslate.Text = "Reset"
        Me.btnResetTranslate.UseVisualStyleBackColor = True
        '
        'btnTranslateMinZ
        '
        Me.btnTranslateMinZ.Location = New System.Drawing.Point(134, 94)
        Me.btnTranslateMinZ.Name = "btnTranslateMinZ"
        Me.btnTranslateMinZ.Size = New System.Drawing.Size(26, 23)
        Me.btnTranslateMinZ.TabIndex = 11
        Me.btnTranslateMinZ.Text = "-"
        Me.btnTranslateMinZ.UseVisualStyleBackColor = True
        '
        'btnTranslatePlusZ
        '
        Me.btnTranslatePlusZ.Location = New System.Drawing.Point(102, 94)
        Me.btnTranslatePlusZ.Name = "btnTranslatePlusZ"
        Me.btnTranslatePlusZ.Size = New System.Drawing.Size(26, 23)
        Me.btnTranslatePlusZ.TabIndex = 10
        Me.btnTranslatePlusZ.Text = "+"
        Me.btnTranslatePlusZ.UseVisualStyleBackColor = True
        '
        'btnTranslateMinY
        '
        Me.btnTranslateMinY.Location = New System.Drawing.Point(134, 63)
        Me.btnTranslateMinY.Name = "btnTranslateMinY"
        Me.btnTranslateMinY.Size = New System.Drawing.Size(26, 23)
        Me.btnTranslateMinY.TabIndex = 9
        Me.btnTranslateMinY.Text = "-"
        Me.btnTranslateMinY.UseVisualStyleBackColor = True
        '
        'btnTranslatePlusY
        '
        Me.btnTranslatePlusY.Location = New System.Drawing.Point(102, 63)
        Me.btnTranslatePlusY.Name = "btnTranslatePlusY"
        Me.btnTranslatePlusY.Size = New System.Drawing.Size(26, 23)
        Me.btnTranslatePlusY.TabIndex = 8
        Me.btnTranslatePlusY.Text = "+"
        Me.btnTranslatePlusY.UseVisualStyleBackColor = True
        '
        'btnTranslateMinX
        '
        Me.btnTranslateMinX.Location = New System.Drawing.Point(134, 29)
        Me.btnTranslateMinX.Name = "btnTranslateMinX"
        Me.btnTranslateMinX.Size = New System.Drawing.Size(26, 23)
        Me.btnTranslateMinX.TabIndex = 7
        Me.btnTranslateMinX.Text = "-"
        Me.btnTranslateMinX.UseVisualStyleBackColor = True
        '
        'btnTranslatePlusX
        '
        Me.btnTranslatePlusX.Location = New System.Drawing.Point(102, 29)
        Me.btnTranslatePlusX.Name = "btnTranslatePlusX"
        Me.btnTranslatePlusX.Size = New System.Drawing.Size(26, 23)
        Me.btnTranslatePlusX.TabIndex = 6
        Me.btnTranslatePlusX.Text = "+"
        Me.btnTranslatePlusX.UseVisualStyleBackColor = True
        '
        'txtTranslateZ
        '
        Me.txtTranslateZ.Location = New System.Drawing.Point(32, 97)
        Me.txtTranslateZ.Name = "txtTranslateZ"
        Me.txtTranslateZ.Size = New System.Drawing.Size(64, 20)
        Me.txtTranslateZ.TabIndex = 5
        '
        'txtTranslateY
        '
        Me.txtTranslateY.Location = New System.Drawing.Point(32, 63)
        Me.txtTranslateY.Name = "txtTranslateY"
        Me.txtTranslateY.Size = New System.Drawing.Size(64, 20)
        Me.txtTranslateY.TabIndex = 4
        '
        'txtTranslateX
        '
        Me.txtTranslateX.Location = New System.Drawing.Point(32, 29)
        Me.txtTranslateX.Name = "txtTranslateX"
        Me.txtTranslateX.Size = New System.Drawing.Size(64, 20)
        Me.txtTranslateX.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Z: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Y: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X: "
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(400, 400)
        Me.PictureBox.TabIndex = 1
        Me.PictureBox.TabStop = False
        '
        'grpRotate
        '
        Me.grpRotate.Controls.Add(Me.btnResetRotate)
        Me.grpRotate.Controls.Add(Me.btnRotateMinZ)
        Me.grpRotate.Controls.Add(Me.btnRotatePlusZ)
        Me.grpRotate.Controls.Add(Me.btnRotateMinY)
        Me.grpRotate.Controls.Add(Me.btnRotatePlusY)
        Me.grpRotate.Controls.Add(Me.btnRotateMinX)
        Me.grpRotate.Controls.Add(Me.btnRotatePlusX)
        Me.grpRotate.Controls.Add(Me.txtRotateZ)
        Me.grpRotate.Controls.Add(Me.txtRotateY)
        Me.grpRotate.Controls.Add(Me.txtRotateX)
        Me.grpRotate.Controls.Add(Me.Label4)
        Me.grpRotate.Controls.Add(Me.Label5)
        Me.grpRotate.Controls.Add(Me.Label6)
        Me.grpRotate.Location = New System.Drawing.Point(642, 13)
        Me.grpRotate.Name = "grpRotate"
        Me.grpRotate.Size = New System.Drawing.Size(195, 161)
        Me.grpRotate.TabIndex = 1
        Me.grpRotate.TabStop = False
        Me.grpRotate.Text = "Rotate"
        '
        'btnResetRotate
        '
        Me.btnResetRotate.Location = New System.Drawing.Point(26, 129)
        Me.btnResetRotate.Name = "btnResetRotate"
        Me.btnResetRotate.Size = New System.Drawing.Size(154, 23)
        Me.btnResetRotate.TabIndex = 14
        Me.btnResetRotate.Text = "Reset"
        Me.btnResetRotate.UseVisualStyleBackColor = True
        '
        'btnRotateMinZ
        '
        Me.btnRotateMinZ.Location = New System.Drawing.Point(151, 95)
        Me.btnRotateMinZ.Name = "btnRotateMinZ"
        Me.btnRotateMinZ.Size = New System.Drawing.Size(26, 23)
        Me.btnRotateMinZ.TabIndex = 23
        Me.btnRotateMinZ.Text = "-"
        Me.btnRotateMinZ.UseVisualStyleBackColor = True
        '
        'btnRotatePlusZ
        '
        Me.btnRotatePlusZ.Location = New System.Drawing.Point(119, 95)
        Me.btnRotatePlusZ.Name = "btnRotatePlusZ"
        Me.btnRotatePlusZ.Size = New System.Drawing.Size(26, 23)
        Me.btnRotatePlusZ.TabIndex = 22
        Me.btnRotatePlusZ.Text = "+"
        Me.btnRotatePlusZ.UseVisualStyleBackColor = True
        '
        'btnRotateMinY
        '
        Me.btnRotateMinY.Location = New System.Drawing.Point(151, 64)
        Me.btnRotateMinY.Name = "btnRotateMinY"
        Me.btnRotateMinY.Size = New System.Drawing.Size(26, 23)
        Me.btnRotateMinY.TabIndex = 21
        Me.btnRotateMinY.Text = "-"
        Me.btnRotateMinY.UseVisualStyleBackColor = True
        '
        'btnRotatePlusY
        '
        Me.btnRotatePlusY.Location = New System.Drawing.Point(119, 64)
        Me.btnRotatePlusY.Name = "btnRotatePlusY"
        Me.btnRotatePlusY.Size = New System.Drawing.Size(26, 23)
        Me.btnRotatePlusY.TabIndex = 20
        Me.btnRotatePlusY.Text = "+"
        Me.btnRotatePlusY.UseVisualStyleBackColor = True
        '
        'btnRotateMinX
        '
        Me.btnRotateMinX.Location = New System.Drawing.Point(151, 30)
        Me.btnRotateMinX.Name = "btnRotateMinX"
        Me.btnRotateMinX.Size = New System.Drawing.Size(26, 23)
        Me.btnRotateMinX.TabIndex = 19
        Me.btnRotateMinX.Text = "-"
        Me.btnRotateMinX.UseVisualStyleBackColor = True
        '
        'btnRotatePlusX
        '
        Me.btnRotatePlusX.Location = New System.Drawing.Point(119, 30)
        Me.btnRotatePlusX.Name = "btnRotatePlusX"
        Me.btnRotatePlusX.Size = New System.Drawing.Size(26, 23)
        Me.btnRotatePlusX.TabIndex = 18
        Me.btnRotatePlusX.Text = "+"
        Me.btnRotatePlusX.UseVisualStyleBackColor = True
        '
        'txtRotateZ
        '
        Me.txtRotateZ.Location = New System.Drawing.Point(49, 98)
        Me.txtRotateZ.Name = "txtRotateZ"
        Me.txtRotateZ.Size = New System.Drawing.Size(64, 20)
        Me.txtRotateZ.TabIndex = 17
        '
        'txtRotateY
        '
        Me.txtRotateY.Location = New System.Drawing.Point(49, 64)
        Me.txtRotateY.Name = "txtRotateY"
        Me.txtRotateY.Size = New System.Drawing.Size(64, 20)
        Me.txtRotateY.TabIndex = 16
        '
        'txtRotateX
        '
        Me.txtRotateX.Location = New System.Drawing.Point(49, 30)
        Me.txtRotateX.Name = "txtRotateX"
        Me.txtRotateX.Size = New System.Drawing.Size(64, 20)
        Me.txtRotateX.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Z: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Y: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "X: "
        '
        'grpRadius
        '
        Me.grpRadius.Controls.Add(Me.btnResetRad)
        Me.grpRadius.Controls.Add(Me.btnMinRad)
        Me.grpRadius.Controls.Add(Me.btnPlusRad)
        Me.grpRadius.Controls.Add(Me.txtRadius)
        Me.grpRadius.Location = New System.Drawing.Point(441, 180)
        Me.grpRadius.Name = "grpRadius"
        Me.grpRadius.Size = New System.Drawing.Size(279, 88)
        Me.grpRadius.TabIndex = 24
        Me.grpRadius.TabStop = False
        Me.grpRadius.Text = "Radius"
        '
        'btnResetRad
        '
        Me.btnResetRad.Location = New System.Drawing.Point(10, 52)
        Me.btnResetRad.Name = "btnResetRad"
        Me.btnResetRad.Size = New System.Drawing.Size(263, 23)
        Me.btnResetRad.TabIndex = 14
        Me.btnResetRad.Text = "Reset"
        Me.btnResetRad.UseVisualStyleBackColor = True
        '
        'btnMinRad
        '
        Me.btnMinRad.Location = New System.Drawing.Point(247, 22)
        Me.btnMinRad.Name = "btnMinRad"
        Me.btnMinRad.Size = New System.Drawing.Size(26, 23)
        Me.btnMinRad.TabIndex = 19
        Me.btnMinRad.Text = "-"
        Me.btnMinRad.UseVisualStyleBackColor = True
        '
        'btnPlusRad
        '
        Me.btnPlusRad.Location = New System.Drawing.Point(215, 22)
        Me.btnPlusRad.Name = "btnPlusRad"
        Me.btnPlusRad.Size = New System.Drawing.Size(26, 23)
        Me.btnPlusRad.TabIndex = 18
        Me.btnPlusRad.Text = "+"
        Me.btnPlusRad.UseVisualStyleBackColor = True
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(10, 25)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(199, 20)
        Me.txtRadius.TabIndex = 15
        '
        'grpLatitude
        '
        Me.grpLatitude.Controls.Add(Me.btnResetLat)
        Me.grpLatitude.Controls.Add(Me.btnMinLat)
        Me.grpLatitude.Controls.Add(Me.btnPlusLat)
        Me.grpLatitude.Controls.Add(Me.txtLatitude)
        Me.grpLatitude.Location = New System.Drawing.Point(441, 279)
        Me.grpLatitude.Name = "grpLatitude"
        Me.grpLatitude.Size = New System.Drawing.Size(195, 88)
        Me.grpLatitude.TabIndex = 25
        Me.grpLatitude.TabStop = False
        Me.grpLatitude.Text = "Latitude"
        '
        'btnResetLat
        '
        Me.btnResetLat.Location = New System.Drawing.Point(6, 54)
        Me.btnResetLat.Name = "btnResetLat"
        Me.btnResetLat.Size = New System.Drawing.Size(183, 23)
        Me.btnResetLat.TabIndex = 14
        Me.btnResetLat.Text = "Reset"
        Me.btnResetLat.UseVisualStyleBackColor = True
        '
        'btnMinLat
        '
        Me.btnMinLat.Location = New System.Drawing.Point(163, 24)
        Me.btnMinLat.Name = "btnMinLat"
        Me.btnMinLat.Size = New System.Drawing.Size(26, 23)
        Me.btnMinLat.TabIndex = 19
        Me.btnMinLat.Text = "-"
        Me.btnMinLat.UseVisualStyleBackColor = True
        '
        'btnPlusLat
        '
        Me.btnPlusLat.Location = New System.Drawing.Point(131, 24)
        Me.btnPlusLat.Name = "btnPlusLat"
        Me.btnPlusLat.Size = New System.Drawing.Size(26, 23)
        Me.btnPlusLat.TabIndex = 18
        Me.btnPlusLat.Text = "+"
        Me.btnPlusLat.UseVisualStyleBackColor = True
        '
        'txtLatitude
        '
        Me.txtLatitude.Location = New System.Drawing.Point(6, 26)
        Me.txtLatitude.Name = "txtLatitude"
        Me.txtLatitude.Size = New System.Drawing.Size(119, 20)
        Me.txtLatitude.TabIndex = 15
        '
        'grpLongitude
        '
        Me.grpLongitude.Controls.Add(Me.btnResetLong)
        Me.grpLongitude.Controls.Add(Me.btnMinLong)
        Me.grpLongitude.Controls.Add(Me.btnPlusLong)
        Me.grpLongitude.Controls.Add(Me.txtLongitude)
        Me.grpLongitude.Location = New System.Drawing.Point(642, 279)
        Me.grpLongitude.Name = "grpLongitude"
        Me.grpLongitude.Size = New System.Drawing.Size(195, 88)
        Me.grpLongitude.TabIndex = 26
        Me.grpLongitude.TabStop = False
        Me.grpLongitude.Text = "Longitude"
        '
        'btnResetLong
        '
        Me.btnResetLong.Location = New System.Drawing.Point(6, 54)
        Me.btnResetLong.Name = "btnResetLong"
        Me.btnResetLong.Size = New System.Drawing.Size(182, 23)
        Me.btnResetLong.TabIndex = 14
        Me.btnResetLong.Text = "Reset"
        Me.btnResetLong.UseVisualStyleBackColor = True
        '
        'btnMinLong
        '
        Me.btnMinLong.Location = New System.Drawing.Point(162, 24)
        Me.btnMinLong.Name = "btnMinLong"
        Me.btnMinLong.Size = New System.Drawing.Size(26, 23)
        Me.btnMinLong.TabIndex = 19
        Me.btnMinLong.Text = "-"
        Me.btnMinLong.UseVisualStyleBackColor = True
        '
        'btnPlusLong
        '
        Me.btnPlusLong.Location = New System.Drawing.Point(130, 24)
        Me.btnPlusLong.Name = "btnPlusLong"
        Me.btnPlusLong.Size = New System.Drawing.Size(26, 23)
        Me.btnPlusLong.TabIndex = 18
        Me.btnPlusLong.Text = "+"
        Me.btnPlusLong.UseVisualStyleBackColor = True
        '
        'txtLongitude
        '
        Me.txtLongitude.Location = New System.Drawing.Point(8, 26)
        Me.txtLongitude.Name = "txtLongitude"
        Me.txtLongitude.Size = New System.Drawing.Size(116, 20)
        Me.txtLongitude.TabIndex = 15
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(441, 380)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(396, 33)
        Me.btnSubmit.TabIndex = 27
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbOff)
        Me.GroupBox1.Controls.Add(Me.rbOn)
        Me.GroupBox1.Location = New System.Drawing.Point(726, 180)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(111, 88)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Back Face Culling"
        '
        'rbOff
        '
        Me.rbOff.AutoSize = True
        Me.rbOff.Location = New System.Drawing.Point(22, 52)
        Me.rbOff.Name = "rbOff"
        Me.rbOff.Size = New System.Drawing.Size(39, 17)
        Me.rbOff.TabIndex = 1
        Me.rbOff.TabStop = True
        Me.rbOff.Text = "Off"
        Me.rbOff.UseVisualStyleBackColor = True
        '
        'rbOn
        '
        Me.rbOn.AutoSize = True
        Me.rbOn.Location = New System.Drawing.Point(22, 28)
        Me.rbOn.Name = "rbOn"
        Me.rbOn.Size = New System.Drawing.Size(39, 17)
        Me.rbOn.TabIndex = 0
        Me.rbOn.TabStop = True
        Me.rbOn.Text = "On"
        Me.rbOn.UseVisualStyleBackColor = True
        '
        'FormSphere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 432)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.grpLongitude)
        Me.Controls.Add(Me.grpLatitude)
        Me.Controls.Add(Me.grpRadius)
        Me.Controls.Add(Me.grpRotate)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.grpTranslate)
        Me.Name = "FormSphere"
        Me.Text = "Form1"
        Me.grpTranslate.ResumeLayout(False)
        Me.grpTranslate.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRotate.ResumeLayout(False)
        Me.grpRotate.PerformLayout()
        Me.grpRadius.ResumeLayout(False)
        Me.grpRadius.PerformLayout()
        Me.grpLatitude.ResumeLayout(False)
        Me.grpLatitude.PerformLayout()
        Me.grpLongitude.ResumeLayout(False)
        Me.grpLongitude.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpTranslate As GroupBox
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents grpRotate As GroupBox
    Friend WithEvents btnTranslateMinZ As Button
    Friend WithEvents btnTranslatePlusZ As Button
    Friend WithEvents btnTranslateMinY As Button
    Friend WithEvents btnTranslatePlusY As Button
    Friend WithEvents btnTranslateMinX As Button
    Friend WithEvents btnTranslatePlusX As Button
    Friend WithEvents txtTranslateZ As TextBox
    Friend WithEvents txtTranslateY As TextBox
    Friend WithEvents txtTranslateX As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnResetTranslate As Button
    Friend WithEvents btnResetRotate As Button
    Friend WithEvents btnRotateMinZ As Button
    Friend WithEvents btnRotatePlusZ As Button
    Friend WithEvents btnRotateMinY As Button
    Friend WithEvents btnRotatePlusY As Button
    Friend WithEvents btnRotateMinX As Button
    Friend WithEvents btnRotatePlusX As Button
    Friend WithEvents txtRotateZ As TextBox
    Friend WithEvents txtRotateY As TextBox
    Friend WithEvents txtRotateX As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents grpRadius As GroupBox
    Friend WithEvents btnResetRad As Button
    Friend WithEvents btnMinRad As Button
    Friend WithEvents btnPlusRad As Button
    Friend WithEvents txtRadius As TextBox
    Friend WithEvents grpLatitude As GroupBox
    Friend WithEvents btnResetLat As Button
    Friend WithEvents btnMinLat As Button
    Friend WithEvents btnPlusLat As Button
    Friend WithEvents txtLatitude As TextBox
    Friend WithEvents grpLongitude As GroupBox
    Friend WithEvents btnResetLong As Button
    Friend WithEvents btnMinLong As Button
    Friend WithEvents btnPlusLong As Button
    Friend WithEvents txtLongitude As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbOff As RadioButton
    Friend WithEvents rbOn As RadioButton
End Class
