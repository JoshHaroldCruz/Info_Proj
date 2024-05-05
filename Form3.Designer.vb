<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Panel3 = New Panel()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Btn_Members = New Button()
        TextBox1 = New TextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(127), CByte(143), CByte(166))
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(805, 438)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(113), CByte(128), CByte(147))
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(640, 30)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(165, 408)
        Panel3.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(113), CByte(128), CByte(147))
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(TextBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(805, 30)
        Panel2.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Btn_Members)
        Panel4.Location = New Point(640, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(162, 30)
        Panel4.TabIndex = 1
        ' 
        ' Btn_Members
        ' 
        Btn_Members.Cursor = Cursors.Hand
        Btn_Members.Dock = DockStyle.Fill
        Btn_Members.FlatAppearance.BorderSize = 0
        Btn_Members.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(76), CByte(209), CByte(55))
        Btn_Members.FlatStyle = FlatStyle.Flat
        Btn_Members.ForeColor = Color.Transparent
        Btn_Members.Location = New Point(0, 0)
        Btn_Members.Name = "Btn_Members"
        Btn_Members.Size = New Size(162, 30)
        Btn_Members.TabIndex = 4
        Btn_Members.Text = "Search"
        Btn_Members.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn_Members.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(3, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(634, 23)
        TextBox1.TabIndex = 0
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(802, 450)
        Controls.Add(Panel1)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Btn_Members As Button
End Class
