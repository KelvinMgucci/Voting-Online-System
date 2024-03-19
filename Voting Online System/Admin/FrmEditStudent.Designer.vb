<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditStudent))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.TxtStName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PcBxClose = New System.Windows.Forms.PictureBox()
        Me.CmbYear = New System.Windows.Forms.ComboBox()
        Me.CmbCourse = New System.Windows.Forms.ComboBox()
        CType(Me.PcBxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Year"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Course"
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.Location = New System.Drawing.Point(182, 279)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(337, 33)
        Me.BtnEdit.TabIndex = 24
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'TxtStName
        '
        Me.TxtStName.Location = New System.Drawing.Point(182, 133)
        Me.TxtStName.Name = "TxtStName"
        Me.TxtStName.Size = New System.Drawing.Size(337, 22)
        Me.TxtStName.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Student Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Student ID"
        '
        'TxtSID
        '
        Me.TxtSID.Location = New System.Drawing.Point(182, 81)
        Me.TxtSID.Name = "TxtSID"
        Me.TxtSID.Size = New System.Drawing.Size(337, 22)
        Me.TxtSID.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Voting System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(31, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "IFM"
        '
        'PcBxClose
        '
        Me.PcBxClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PcBxClose.Image = CType(resources.GetObject("PcBxClose.Image"), System.Drawing.Image)
        Me.PcBxClose.Location = New System.Drawing.Point(560, 3)
        Me.PcBxClose.Name = "PcBxClose"
        Me.PcBxClose.Size = New System.Drawing.Size(39, 30)
        Me.PcBxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcBxClose.TabIndex = 29
        Me.PcBxClose.TabStop = False
        '
        'CmbYear
        '
        Me.CmbYear.FormattingEnabled = True
        Me.CmbYear.Items.AddRange(New Object() {"First Year", "Second Year", "Third Year"})
        Me.CmbYear.Location = New System.Drawing.Point(182, 229)
        Me.CmbYear.Name = "CmbYear"
        Me.CmbYear.Size = New System.Drawing.Size(337, 21)
        Me.CmbYear.TabIndex = 31
        '
        'CmbCourse
        '
        Me.CmbCourse.FormattingEnabled = True
        Me.CmbCourse.Items.AddRange(New Object() {"BTCA", "BTCT", "BTCCIT", "BTCISP", "BTCBF", "ODAC", "ODTM", "ODIT", "ODCS", "ODBF", "ODIRM", "ODSP", "BAC", "BTX", "BEF", "BAIT", "BIT", "BAS", "BCS", "BIRM", "BBF", "BSP", "BDCS"})
        Me.CmbCourse.Location = New System.Drawing.Point(182, 178)
        Me.CmbCourse.Name = "CmbCourse"
        Me.CmbCourse.Size = New System.Drawing.Size(337, 21)
        Me.CmbCourse.TabIndex = 30
        '
        'FrmEditStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 340)
        Me.Controls.Add(Me.CmbYear)
        Me.Controls.Add(Me.CmbCourse)
        Me.Controls.Add(Me.PcBxClose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.TxtStName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSID)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEditStudent"
        Me.Text = "FrmEditStudent"
        CType(Me.PcBxClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnEdit As Button
    Friend WithEvents TxtStName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PcBxClose As PictureBox
    Friend WithEvents CmbYear As ComboBox
    Friend WithEvents CmbCourse As ComboBox
End Class
