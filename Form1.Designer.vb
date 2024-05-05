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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Btn_Settings = New Button()
        Btn_Communication = New Button()
        Btn_Events = New Button()
        Btn_Members = New Button()
        Btn_Dashboard = New Button()
        Panel4 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel5 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(68), CByte(189), CByte(50))
        Panel1.Controls.Add(Btn_Settings)
        Panel1.Controls.Add(Btn_Communication)
        Panel1.Controls.Add(Btn_Events)
        Panel1.Controls.Add(Btn_Members)
        Panel1.Controls.Add(Btn_Dashboard)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 461)
        Panel1.TabIndex = 0
        ' 
        ' Btn_Settings
        ' 
        Btn_Settings.Cursor = Cursors.Hand
        Btn_Settings.Dock = DockStyle.Top
        Btn_Settings.FlatAppearance.BorderSize = 0
        Btn_Settings.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(76), CByte(209), CByte(55))
        Btn_Settings.FlatStyle = FlatStyle.Flat
        Btn_Settings.ForeColor = Color.Transparent
        Btn_Settings.Image = CType(resources.GetObject("Btn_Settings.Image"), Image)
        Btn_Settings.ImageAlign = ContentAlignment.MiddleLeft
        Btn_Settings.Location = New Point(0, 238)
        Btn_Settings.Name = "Btn_Settings"
        Btn_Settings.Padding = New Padding(5, 0, 0, 0)
        Btn_Settings.Size = New Size(200, 23)
        Btn_Settings.TabIndex = 6
        Btn_Settings.Text = "  Settings"
        Btn_Settings.TextAlign = ContentAlignment.MiddleLeft
        Btn_Settings.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn_Settings.UseVisualStyleBackColor = True
        ' 
        ' Btn_Communication
        ' 
        Btn_Communication.Cursor = Cursors.Hand
        Btn_Communication.Dock = DockStyle.Top
        Btn_Communication.FlatAppearance.BorderSize = 0
        Btn_Communication.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(76), CByte(209), CByte(55))
        Btn_Communication.FlatStyle = FlatStyle.Flat
        Btn_Communication.ForeColor = Color.Transparent
        Btn_Communication.Image = CType(resources.GetObject("Btn_Communication.Image"), Image)
        Btn_Communication.ImageAlign = ContentAlignment.MiddleLeft
        Btn_Communication.Location = New Point(0, 215)
        Btn_Communication.Name = "Btn_Communication"
        Btn_Communication.Padding = New Padding(5, 0, 0, 0)
        Btn_Communication.Size = New Size(200, 23)
        Btn_Communication.TabIndex = 5
        Btn_Communication.Text = "  Communication"
        Btn_Communication.TextAlign = ContentAlignment.MiddleLeft
        Btn_Communication.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn_Communication.UseVisualStyleBackColor = True
        ' 
        ' Btn_Events
        ' 
        Btn_Events.Cursor = Cursors.Hand
        Btn_Events.Dock = DockStyle.Top
        Btn_Events.FlatAppearance.BorderSize = 0
        Btn_Events.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(76), CByte(209), CByte(55))
        Btn_Events.FlatStyle = FlatStyle.Flat
        Btn_Events.ForeColor = Color.Transparent
        Btn_Events.Image = CType(resources.GetObject("Btn_Events.Image"), Image)
        Btn_Events.ImageAlign = ContentAlignment.MiddleLeft
        Btn_Events.Location = New Point(0, 192)
        Btn_Events.Name = "Btn_Events"
        Btn_Events.Padding = New Padding(5, 0, 0, 0)
        Btn_Events.Size = New Size(200, 23)
        Btn_Events.TabIndex = 4
        Btn_Events.Text = "  Events"
        Btn_Events.TextAlign = ContentAlignment.MiddleLeft
        Btn_Events.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn_Events.UseVisualStyleBackColor = True
        ' 
        ' Btn_Members
        ' 
        Btn_Members.Cursor = Cursors.Hand
        Btn_Members.Dock = DockStyle.Top
        Btn_Members.FlatAppearance.BorderSize = 0
        Btn_Members.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(76), CByte(209), CByte(55))
        Btn_Members.FlatStyle = FlatStyle.Flat
        Btn_Members.ForeColor = Color.Transparent
        Btn_Members.Image = CType(resources.GetObject("Btn_Members.Image"), Image)
        Btn_Members.ImageAlign = ContentAlignment.MiddleLeft
        Btn_Members.Location = New Point(0, 169)
        Btn_Members.Name = "Btn_Members"
        Btn_Members.Padding = New Padding(5, 0, 0, 0)
        Btn_Members.Size = New Size(200, 23)
        Btn_Members.TabIndex = 3
        Btn_Members.Text = "  Members"
        Btn_Members.TextAlign = ContentAlignment.MiddleLeft
        Btn_Members.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn_Members.UseVisualStyleBackColor = True
        ' 
        ' Btn_Dashboard
        ' 
        Btn_Dashboard.Cursor = Cursors.Hand
        Btn_Dashboard.Dock = DockStyle.Top
        Btn_Dashboard.FlatAppearance.BorderSize = 0
        Btn_Dashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(76), CByte(209), CByte(55))
        Btn_Dashboard.FlatStyle = FlatStyle.Flat
        Btn_Dashboard.ForeColor = Color.Transparent
        Btn_Dashboard.Image = CType(resources.GetObject("Btn_Dashboard.Image"), Image)
        Btn_Dashboard.ImageAlign = ContentAlignment.MiddleLeft
        Btn_Dashboard.Location = New Point(0, 146)
        Btn_Dashboard.Name = "Btn_Dashboard"
        Btn_Dashboard.Padding = New Padding(5, 0, 0, 0)
        Btn_Dashboard.Size = New Size(200, 23)
        Btn_Dashboard.TabIndex = 2
        Btn_Dashboard.Text = "  Dashboard"
        Btn_Dashboard.TextAlign = ContentAlignment.MiddleLeft
        Btn_Dashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn_Dashboard.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 46)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(200, 100)
        Panel4.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(113), CByte(128), CByte(147))
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 46)
        Panel2.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(127), CByte(143), CByte(166))
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(200, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(784, 46)
        Panel3.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(200, 46)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(784, 415)
        Panel5.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 461)
        Controls.Add(Panel5)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btn_Dashboard As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Btn_Communication As Button
    Friend WithEvents Btn_Events As Button
    Friend WithEvents Btn_Members As Button
    Friend WithEvents Btn_Settings As Button
    Friend WithEvents Panel5 As Panel

End Class
