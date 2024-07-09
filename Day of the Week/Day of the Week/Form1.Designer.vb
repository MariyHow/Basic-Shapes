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
        Me.picStress = New System.Windows.Forms.PictureBox()
        Me.picRelax = New System.Windows.Forms.PictureBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.picStress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRelax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picStress
        '
        Me.picStress.Image = Global.Day_of_the_Week.My.Resources.Resources.Weekday
        Me.picStress.Location = New System.Drawing.Point(415, 1)
        Me.picStress.Name = "picStress"
        Me.picStress.Size = New System.Drawing.Size(373, 251)
        Me.picStress.TabIndex = 0
        Me.picStress.TabStop = False
        Me.picStress.Visible = False
        '
        'picRelax
        '
        Me.picRelax.Image = Global.Day_of_the_Week.My.Resources.Resources.Weekend
        Me.picRelax.Location = New System.Drawing.Point(61, 18)
        Me.picRelax.Name = "picRelax"
        Me.picRelax.Size = New System.Drawing.Size(257, 234)
        Me.picRelax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picRelax.TabIndex = 1
        Me.picRelax.TabStop = False
        Me.picRelax.Visible = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.IndianRed
        Me.btnReset.Location = New System.Drawing.Point(117, 377)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(94, 29)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(268, 297)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(250, 27)
        Me.DateTimePicker1.TabIndex = 5
        Me.DateTimePicker1.Value = New Date(2023, 3, 1, 21, 42, 0, 0)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(590, 377)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 29)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(268, 341)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Day of the Week:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(395, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.picRelax)
        Me.Controls.Add(Me.picStress)
        Me.Name = "Form1"
        Me.Text = "DayoftheWeekHoward"
        CType(Me.picStress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRelax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picStress As PictureBox
    Friend WithEvents picRelax As PictureBox
    Friend WithEvents btnReset As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
