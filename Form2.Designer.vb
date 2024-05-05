<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Panel1 = New Panel()
        Label1 = New Label()
        Panel5 = New Panel()
        Panel4 = New Panel()
        Panel2 = New Panel()
        Label2 = New Label()
        Label3 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(39, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(721, 397)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Leelawadee UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(29, 176)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 30)
        Label1.TabIndex = 4
        Label1.Text = "Activities"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(53), CByte(59), CByte(72))
        Panel5.Location = New Point(26, 209)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(670, 135)
        Panel5.TabIndex = 3
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(232), CByte(65), CByte(24))
        Panel4.Location = New Point(496, 57)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(200, 116)
        Panel4.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(168), CByte(255))
        Panel2.Location = New Point(26, 57)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(454, 116)
        Panel2.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Leelawadee UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(496, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 30)
        Label2.TabIndex = 5
        Label2.Text = "Total Members"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Leelawadee UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(26, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(156, 30)
        Label3.TabIndex = 6
        Label3.Text = "Announcement"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
