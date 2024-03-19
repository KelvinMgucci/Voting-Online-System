<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCandidates
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCandidates))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PcBxClose = New System.Windows.Forms.PictureBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtCourse = New System.Windows.Forms.TextBox()
        Me.CmbYear = New System.Windows.Forms.ComboBox()
        Me.CmbPosition = New System.Windows.Forms.ComboBox()
        Me.BtnReg = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PcBxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MANAGE CANDIDATES"
        '
        'PcBxClose
        '
        Me.PcBxClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PcBxClose.Image = CType(resources.GetObject("PcBxClose.Image"), System.Drawing.Image)
        Me.PcBxClose.Location = New System.Drawing.Point(720, 12)
        Me.PcBxClose.Name = "PcBxClose"
        Me.PcBxClose.Size = New System.Drawing.Size(41, 36)
        Me.PcBxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcBxClose.TabIndex = 2
        Me.PcBxClose.TabStop = False
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(283, 88)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(312, 23)
        Me.TxtName.TabIndex = 3
        '
        'TxtCourse
        '
        Me.TxtCourse.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCourse.Location = New System.Drawing.Point(283, 139)
        Me.TxtCourse.Name = "TxtCourse"
        Me.TxtCourse.Size = New System.Drawing.Size(312, 23)
        Me.TxtCourse.TabIndex = 4
        '
        'CmbYear
        '
        Me.CmbYear.FormattingEnabled = True
        Me.CmbYear.Items.AddRange(New Object() {"First Year", "Second Year"})
        Me.CmbYear.Location = New System.Drawing.Point(283, 202)
        Me.CmbYear.Name = "CmbYear"
        Me.CmbYear.Size = New System.Drawing.Size(312, 23)
        Me.CmbYear.TabIndex = 5
        '
        'CmbPosition
        '
        Me.CmbPosition.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPosition.FormattingEnabled = True
        Me.CmbPosition.Items.AddRange(New Object() {"President", "Faculty Representative"})
        Me.CmbPosition.Location = New System.Drawing.Point(283, 266)
        Me.CmbPosition.Name = "CmbPosition"
        Me.CmbPosition.Size = New System.Drawing.Size(312, 23)
        Me.CmbPosition.TabIndex = 6
        '
        'BtnReg
        '
        Me.BtnReg.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReg.Location = New System.Drawing.Point(283, 320)
        Me.BtnReg.Name = "BtnReg"
        Me.BtnReg.Size = New System.Drawing.Size(312, 29)
        Me.BtnReg.TabIndex = 8
        Me.BtnReg.Text = "Register"
        Me.BtnReg.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Course"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(198, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Year"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(201, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Positon"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmCandidates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 394)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnReg)
        Me.Controls.Add(Me.CmbPosition)
        Me.Controls.Add(Me.CmbYear)
        Me.Controls.Add(Me.TxtCourse)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.PcBxClose)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmCandidates"
        Me.Text = "FrmCandidates"
        CType(Me.PcBxClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PcBxClose As PictureBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtCourse As TextBox
    Friend WithEvents CmbYear As ComboBox
    Friend WithEvents CmbPosition As ComboBox
    Friend WithEvents BtnReg As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
