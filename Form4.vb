Public Class Form4
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Dim a As Integer = MsgBox("This will reset the game. Are you sure?", vbOKCancel)
        If a = DialogResult.OK Then
            If RadioButton1.Checked = True Then
                GameStyle = 1
                Form1.GameLabel.Text = "Standard/Open"
            End If
            If RadioButton2.Checked = True Then
                GameStyle = 2
                Form1.GameLabel.Text = "Retro"
            End If
            If RadioButton3.Checked = True Then
                GameStyle = 3
                Form1.GameLabel.Text = "Keysanity"
            End If
            If RadioButton4.Checked = True Then
                GameStyle = 4
                Form1.GameLabel.Text = "Checklist"
            End If
            If SwordlessCheck.Checked = True Then
                Form1.GameLabel.Text = Form1.GameLabel.Text & " Swordless"
                Swordless = True
            Else
                Swordless = False
            End If
            If InvertedCheck.Checked = True Then
                Form1.GameLabel.Text = Form1.GameLabel.Text & " Inverted"
                Inverted = True
            Else
                Inverted = False
            End If
            If EnemizerCheck.Checked = True Then
                Form1.GameLabel.Text = Form1.GameLabel.Text & " Enemizer"
                Enemizer = True
            Else
                Enemizer = False
            End If
            ResetGame()
            Me.Close()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles NopeButton.Click
        Me.Close()
    End Sub

End Class