<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.EnemizerCheck = New System.Windows.Forms.CheckBox()
        Me.InvertedCheck = New System.Windows.Forms.CheckBox()
        Me.SwordlessCheck = New System.Windows.Forms.CheckBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.NopeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EnemizerCheck
        '
        Me.EnemizerCheck.AutoSize = True
        Me.EnemizerCheck.ForeColor = System.Drawing.Color.White
        Me.EnemizerCheck.Location = New System.Drawing.Point(112, 48)
        Me.EnemizerCheck.Name = "EnemizerCheck"
        Me.EnemizerCheck.Size = New System.Drawing.Size(69, 17)
        Me.EnemizerCheck.TabIndex = 945
        Me.EnemizerCheck.Text = "Enemizer"
        Me.EnemizerCheck.UseVisualStyleBackColor = True
        '
        'InvertedCheck
        '
        Me.InvertedCheck.AutoSize = True
        Me.InvertedCheck.ForeColor = System.Drawing.Color.White
        Me.InvertedCheck.Location = New System.Drawing.Point(112, 30)
        Me.InvertedCheck.Name = "InvertedCheck"
        Me.InvertedCheck.Size = New System.Drawing.Size(65, 17)
        Me.InvertedCheck.TabIndex = 944
        Me.InvertedCheck.Text = "Inverted"
        Me.InvertedCheck.UseVisualStyleBackColor = True
        '
        'SwordlessCheck
        '
        Me.SwordlessCheck.AutoSize = True
        Me.SwordlessCheck.ForeColor = System.Drawing.Color.White
        Me.SwordlessCheck.Location = New System.Drawing.Point(112, 12)
        Me.SwordlessCheck.Name = "SwordlessCheck"
        Me.SwordlessCheck.Size = New System.Drawing.Size(74, 17)
        Me.SwordlessCheck.TabIndex = 946
        Me.SwordlessCheck.Text = "Swordless"
        Me.SwordlessCheck.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(11, 12)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(99, 17)
        Me.RadioButton1.TabIndex = 947
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Standard/Open"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(12, 30)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(51, 17)
        Me.RadioButton2.TabIndex = 948
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Retro"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.White
        Me.RadioButton3.Location = New System.Drawing.Point(12, 48)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton3.TabIndex = 949
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Keysanity"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.Color.White
        Me.RadioButton4.Location = New System.Drawing.Point(12, 66)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(117, 17)
        Me.RadioButton4.TabIndex = 950
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Checklist (All Open)"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(21, 89)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 951
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'NopeButton
        '
        Me.NopeButton.Location = New System.Drawing.Point(95, 89)
        Me.NopeButton.Name = "NopeButton"
        Me.NopeButton.Size = New System.Drawing.Size(75, 23)
        Me.NopeButton.TabIndex = 952
        Me.NopeButton.Text = "Cancel"
        Me.NopeButton.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(192, 121)
        Me.ControlBox = False
        Me.Controls.Add(Me.NopeButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.SwordlessCheck)
        Me.Controls.Add(Me.EnemizerCheck)
        Me.Controls.Add(Me.InvertedCheck)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form4"
        Me.Text = "Game Mode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EnemizerCheck As CheckBox
    Friend WithEvents InvertedCheck As CheckBox
    Friend WithEvents SwordlessCheck As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents OKButton As Button
    Friend WithEvents NopeButton As Button
End Class
