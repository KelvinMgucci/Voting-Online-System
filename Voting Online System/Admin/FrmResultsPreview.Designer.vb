<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmResultsPreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmResultsPreview))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PcBxClose = New System.Windows.Forms.PictureBox()
        Me.GrpBxResults = New System.Windows.Forms.GroupBox()
        Me.TextBoxFR2 = New System.Windows.Forms.TextBox()
        Me.TextBoxFR1 = New System.Windows.Forms.TextBox()
        Me.TextBoxPresi2 = New System.Windows.Forms.TextBox()
        Me.TextBoxPresi1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBarFR2 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBarFR1 = New System.Windows.Forms.ProgressBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProgressBarPresi2 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBarPresi1 = New System.Windows.Forms.ProgressBar()
        Me.BtnResults = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.PcBxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBxResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Voting System"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(36, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "IFM"
        '
        'PcBxClose
        '
        Me.PcBxClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PcBxClose.Image = CType(resources.GetObject("PcBxClose.Image"), System.Drawing.Image)
        Me.PcBxClose.Location = New System.Drawing.Point(747, 6)
        Me.PcBxClose.Name = "PcBxClose"
        Me.PcBxClose.Size = New System.Drawing.Size(41, 36)
        Me.PcBxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcBxClose.TabIndex = 16
        Me.PcBxClose.TabStop = False
        '
        'GrpBxResults
        '
        Me.GrpBxResults.Controls.Add(Me.TextBoxFR2)
        Me.GrpBxResults.Controls.Add(Me.TextBoxFR1)
        Me.GrpBxResults.Controls.Add(Me.TextBoxPresi2)
        Me.GrpBxResults.Controls.Add(Me.TextBoxPresi1)
        Me.GrpBxResults.Controls.Add(Me.Label2)
        Me.GrpBxResults.Controls.Add(Me.Label1)
        Me.GrpBxResults.Controls.Add(Me.ProgressBarFR2)
        Me.GrpBxResults.Controls.Add(Me.ProgressBarFR1)
        Me.GrpBxResults.Controls.Add(Me.Label6)
        Me.GrpBxResults.Controls.Add(Me.Label5)
        Me.GrpBxResults.Controls.Add(Me.ProgressBarPresi2)
        Me.GrpBxResults.Controls.Add(Me.ProgressBarPresi1)
        Me.GrpBxResults.Controls.Add(Me.BtnResults)
        Me.GrpBxResults.Location = New System.Drawing.Point(61, 77)
        Me.GrpBxResults.Name = "GrpBxResults"
        Me.GrpBxResults.Size = New System.Drawing.Size(688, 297)
        Me.GrpBxResults.TabIndex = 17
        Me.GrpBxResults.TabStop = False
        Me.GrpBxResults.Text = "Results"
        '
        'TextBoxFR2
        '
        Me.TextBoxFR2.Enabled = False
        Me.TextBoxFR2.Location = New System.Drawing.Point(557, 213)
        Me.TextBoxFR2.Name = "TextBoxFR2"
        Me.TextBoxFR2.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxFR2.TabIndex = 17
        '
        'TextBoxFR1
        '
        Me.TextBoxFR1.Enabled = False
        Me.TextBoxFR1.Location = New System.Drawing.Point(557, 165)
        Me.TextBoxFR1.Name = "TextBoxFR1"
        Me.TextBoxFR1.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxFR1.TabIndex = 16
        '
        'TextBoxPresi2
        '
        Me.TextBoxPresi2.Enabled = False
        Me.TextBoxPresi2.Location = New System.Drawing.Point(557, 91)
        Me.TextBoxPresi2.Name = "TextBoxPresi2"
        Me.TextBoxPresi2.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxPresi2.TabIndex = 15
        '
        'TextBoxPresi1
        '
        Me.TextBoxPresi1.Enabled = False
        Me.TextBoxPresi1.Location = New System.Drawing.Point(557, 45)
        Me.TextBoxPresi1.Name = "TextBoxPresi1"
        Me.TextBoxPresi1.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxPresi1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Jamila Mgunda"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Vanessa Fransis"
        '
        'ProgressBarFR2
        '
        Me.ProgressBarFR2.Location = New System.Drawing.Point(182, 211)
        Me.ProgressBarFR2.Name = "ProgressBarFR2"
        Me.ProgressBarFR2.Size = New System.Drawing.Size(296, 23)
        Me.ProgressBarFR2.TabIndex = 11
        '
        'ProgressBarFR1
        '
        Me.ProgressBarFR1.Location = New System.Drawing.Point(182, 163)
        Me.ProgressBarFR1.Name = "ProgressBarFR1"
        Me.ProgressBarFR1.Size = New System.Drawing.Size(296, 23)
        Me.ProgressBarFR1.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "David Shungu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Halima Hamad"
        '
        'ProgressBarPresi2
        '
        Me.ProgressBarPresi2.Location = New System.Drawing.Point(182, 89)
        Me.ProgressBarPresi2.Name = "ProgressBarPresi2"
        Me.ProgressBarPresi2.Size = New System.Drawing.Size(296, 23)
        Me.ProgressBarPresi2.TabIndex = 7
        '
        'ProgressBarPresi1
        '
        Me.ProgressBarPresi1.Location = New System.Drawing.Point(182, 43)
        Me.ProgressBarPresi1.Name = "ProgressBarPresi1"
        Me.ProgressBarPresi1.Size = New System.Drawing.Size(296, 23)
        Me.ProgressBarPresi1.TabIndex = 6
        '
        'BtnResults
        '
        Me.BtnResults.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnResults.Location = New System.Drawing.Point(119, 256)
        Me.BtnResults.Name = "BtnResults"
        Me.BtnResults.Size = New System.Drawing.Size(108, 35)
        Me.BtnResults.TabIndex = 4
        Me.BtnResults.Text = "View Results"
        Me.BtnResults.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FrmResultsPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GrpBxResults)
        Me.Controls.Add(Me.PcBxClose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmResultsPreview"
        Me.Text = "FrmResultsPreview"
        CType(Me.PcBxClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBxResults.ResumeLayout(False)
        Me.GrpBxResults.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PcBxClose As PictureBox
    Friend WithEvents GrpBxResults As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBarFR2 As ProgressBar
    Friend WithEvents ProgressBarFR1 As ProgressBar
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ProgressBarPresi2 As ProgressBar
    Friend WithEvents ProgressBarPresi1 As ProgressBar
    Friend WithEvents BtnResults As Button
    Friend WithEvents TextBoxFR2 As TextBox
    Friend WithEvents TextBoxFR1 As TextBox
    Friend WithEvents TextBoxPresi2 As TextBox
    Friend WithEvents TextBoxPresi1 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
