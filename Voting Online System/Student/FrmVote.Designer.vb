<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVote
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GrpBxVote = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.fr1 = New System.Windows.Forms.RadioButton()
        Me.fr2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.presi2 = New System.Windows.Forms.RadioButton()
        Me.presi1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.GrpBxVote.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(171, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Voting System"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(194, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "IFM"
        '
        'GrpBxVote
        '
        Me.GrpBxVote.Controls.Add(Me.GroupBox2)
        Me.GrpBxVote.Controls.Add(Me.GroupBox1)
        Me.GrpBxVote.Controls.Add(Me.Button1)
        Me.GrpBxVote.Location = New System.Drawing.Point(31, 75)
        Me.GrpBxVote.Name = "GrpBxVote"
        Me.GrpBxVote.Size = New System.Drawing.Size(354, 268)
        Me.GrpBxVote.TabIndex = 13
        Me.GrpBxVote.TabStop = False
        Me.GrpBxVote.Text = "Voting"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.fr1)
        Me.GroupBox2.Controls.Add(Me.fr2)
        Me.GroupBox2.Location = New System.Drawing.Point(203, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 96)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choose FR"
        '
        'fr1
        '
        Me.fr1.AutoSize = True
        Me.fr1.Location = New System.Drawing.Point(6, 21)
        Me.fr1.Name = "fr1"
        Me.fr1.Size = New System.Drawing.Size(103, 17)
        Me.fr1.TabIndex = 7
        Me.fr1.TabStop = True
        Me.fr1.Tag = "5"
        Me.fr1.Text = "Vanessa Fransis"
        Me.fr1.UseVisualStyleBackColor = True
        '
        'fr2
        '
        Me.fr2.AutoSize = True
        Me.fr2.Location = New System.Drawing.Point(6, 54)
        Me.fr2.Name = "fr2"
        Me.fr2.Size = New System.Drawing.Size(102, 17)
        Me.fr2.TabIndex = 8
        Me.fr2.TabStop = True
        Me.fr2.Tag = "6"
        Me.fr2.Text = "Jamila Mgunda"
        Me.fr2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.presi2)
        Me.GroupBox1.Controls.Add(Me.presi1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 96)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose President"
        '
        'presi2
        '
        Me.presi2.AutoSize = True
        Me.presi2.Location = New System.Drawing.Point(7, 21)
        Me.presi2.Name = "presi2"
        Me.presi2.Size = New System.Drawing.Size(101, 17)
        Me.presi2.TabIndex = 6
        Me.presi2.TabStop = True
        Me.presi2.Tag = "1"
        Me.presi2.Text = "Halima Hamad"
        Me.presi2.UseVisualStyleBackColor = True
        '
        'presi1
        '
        Me.presi1.AutoSize = True
        Me.presi1.Location = New System.Drawing.Point(7, 44)
        Me.presi1.Name = "presi1"
        Me.presi1.Size = New System.Drawing.Size(95, 17)
        Me.presi1.TabIndex = 5
        Me.presi1.TabStop = True
        Me.presi1.Tag = "2"
        Me.presi1.Text = "David Shungu"
        Me.presi1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Location = New System.Drawing.Point(80, 181)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Vote"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'FrmVote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 404)
        Me.Controls.Add(Me.GrpBxVote)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmVote"
        Me.Text = "FrmVote"
        Me.GrpBxVote.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GrpBxVote As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents fr2 As RadioButton
    Friend WithEvents presi2 As RadioButton
    Friend WithEvents presi1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents fr1 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
End Class
