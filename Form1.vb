Public Class Form1
    Private originalForm2Size As Size
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        'Me.MaximizeBox = False
        'Me.MinimizeBox = False
    End Sub

    Private Sub Btn_Dashboard_Click(sender As Object, e As EventArgs) Handles Btn_Dashboard.Click
        With Form2
            .TopLevel = False
            Panel5.Controls.Add(Form2)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Btn_Members_Click(sender As Object, e As EventArgs) Handles Btn_Members.Click
        With Form3
            .TopLevel = False
            Panel5.Controls.Add(Form3)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
