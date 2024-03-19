<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_manageUsers
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_manageUsers))
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.TxtPasword = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.CmbRole = New System.Windows.Forms.ComboBox()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PcBxClose = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PcBxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(97, 111)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(230, 22)
        Me.TxtName.TabIndex = 2
        '
        'TxtUserName
        '
        Me.TxtUserName.Location = New System.Drawing.Point(97, 160)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(230, 22)
        Me.TxtUserName.TabIndex = 3
        '
        'TxtPasword
        '
        Me.TxtPasword.Location = New System.Drawing.Point(97, 212)
        Me.TxtPasword.Name = "TxtPasword"
        Me.TxtPasword.Size = New System.Drawing.Size(230, 22)
        Me.TxtPasword.TabIndex = 4
        '
        'CmbRole
        '
        Me.CmbRole.FormattingEnabled = True
        Me.CmbRole.Items.AddRange(New Object() {"ADMIN", "USER"})
        Me.CmbRole.Location = New System.Drawing.Point(97, 261)
        Me.CmbRole.Name = "CmbRole"
        Me.CmbRole.Size = New System.Drawing.Size(230, 21)
        Me.CmbRole.TabIndex = 5
        '
        'BtnRegister
        '
        Me.BtnRegister.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegister.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnRegister.Location = New System.Drawing.Point(97, 301)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(230, 23)
        Me.BtnRegister.TabIndex = 6
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.PcBxClose)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(419, 73)
        Me.Panel1.TabIndex = 7
        '
        'PcBxClose
        '
        Me.PcBxClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PcBxClose.Image = CType(resources.GetObject("PcBxClose.Image"), System.Drawing.Image)
        Me.PcBxClose.Location = New System.Drawing.Point(361, 12)
        Me.PcBxClose.Name = "PcBxClose"
        Me.PcBxClose.Size = New System.Drawing.Size(46, 42)
        Me.PcBxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcBxClose.TabIndex = 1
        Me.PcBxClose.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "MANAGE USERS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Role"
        '
        'Frm_manageUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 347)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.CmbRole)
        Me.Controls.Add(Me.TxtPasword)
        Me.Controls.Add(Me.TxtUserName)
        Me.Controls.Add(Me.TxtName)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_manageUsers"
        Me.Text = "Frm_manageUsers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PcBxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtUserName As TextBox
    Friend WithEvents TxtPasword As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CmbRole As ComboBox
    Friend WithEvents BtnRegister As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PcBxClose As PictureBox
    Friend WithEvents BindingSource1 As BindingSource
End Class
