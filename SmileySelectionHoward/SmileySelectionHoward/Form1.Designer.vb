<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnHappy = New System.Windows.Forms.Button()
        Me.btnSad = New System.Windows.Forms.Button()
        Me.picHappy = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picSad = New System.Windows.Forms.PictureBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        CType(Me.picHappy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHappy
        '
        Me.btnHappy.Location = New System.Drawing.Point(95, 317)
        Me.btnHappy.Name = "btnHappy"
        Me.btnHappy.Size = New System.Drawing.Size(177, 29)
        Me.btnHappy.TabIndex = 0
        Me.btnHappy.Text = "Happy Face Selection"
        Me.btnHappy.UseVisualStyleBackColor = True
        '
        'btnSad
        '
        Me.btnSad.Location = New System.Drawing.Point(557, 317)
        Me.btnSad.Name = "btnSad"
        Me.btnSad.Size = New System.Drawing.Size(150, 29)
        Me.btnSad.TabIndex = 1
        Me.btnSad.Text = "Sad Face Selection"
        Me.btnSad.UseVisualStyleBackColor = True
        '
        'picHappy
        '
        Me.picHappy.Image = Global.SmileySelectionHoward.My.Resources.Resources.A_grade_happy_face
        Me.picHappy.Location = New System.Drawing.Point(54, 27)
        Me.picHappy.Name = "picHappy"
        Me.picHappy.Size = New System.Drawing.Size(264, 182)
        Me.picHappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHappy.TabIndex = 2
        Me.picHappy.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(378, 393)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 29)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picSad
        '
        Me.picSad.Image = Global.SmileySelectionHoward.My.Resources.Resources.F_sad_face
        Me.picSad.Location = New System.Drawing.Point(495, 27)
        Me.picSad.Name = "picSad"
        Me.picSad.Size = New System.Drawing.Size(264, 182)
        Me.picSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSad.TabIndex = 4
        Me.picSad.TabStop = False
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(378, 358)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(94, 29)
        Me.btnConfirm.TabIndex = 5
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.picSad)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picHappy)
        Me.Controls.Add(Me.btnSad)
        Me.Controls.Add(Me.btnHappy)
        Me.Name = "Form1"
        Me.Text = "SmileySelectionHoward"
        CType(Me.picHappy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHappy As Button
    Friend WithEvents btnSad As Button
    Friend WithEvents picHappy As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents picSad As PictureBox
    Friend WithEvents btnConfirm As Button
End Class
