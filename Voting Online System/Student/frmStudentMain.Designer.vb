<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentMain
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
        Me.BtnExt = New System.Windows.Forms.Button()
        Me.TxtStID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStdLogin = New System.Windows.Forms.Button()
        Me.Btnadmin = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 38)
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
        Me.Label3.Location = New System.Drawing.Point(36, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "IFM"
        '
        'BtnExt
        '
        Me.BtnExt.BackColor = System.Drawing.Color.Red
        Me.BtnExt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExt.FlatAppearance.BorderSize = 0
        Me.BtnExt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExt.Location = New System.Drawing.Point(742, 15)
        Me.BtnExt.Name = "BtnExt"
        Me.BtnExt.Size = New System.Drawing.Size(91, 36)
        Me.BtnExt.TabIndex = 16
        Me.BtnExt.Text = "Exit"
        Me.BtnExt.UseVisualStyleBackColor = False
        '
        'TxtStID
        '
        Me.TxtStID.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtStID.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStID.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TxtStID.Location = New System.Drawing.Point(298, 142)
        Me.TxtStID.Name = "TxtStID"
        Me.TxtStID.Size = New System.Drawing.Size(246, 33)
        Me.TxtStID.TabIndex = 17
        Me.TxtStID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.LblInfo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnStdLogin)
        Me.Panel1.Controls.Add(Me.TxtStID)
        Me.Panel1.Location = New System.Drawing.Point(1, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(846, 341)
        Me.Panel1.TabIndex = 18
        '
        'LblInfo
        '
        Me.LblInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo.Location = New System.Drawing.Point(298, 74)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(246, 42)
        Me.LblInfo.TabIndex = 20
        Me.LblInfo.Text = "Enter Student ID"
        Me.LblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(295, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Enter Student ID"
        '
        'btnStdLogin
        '
        Me.btnStdLogin.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnStdLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStdLogin.Location = New System.Drawing.Point(298, 218)
        Me.btnStdLogin.Name = "btnStdLogin"
        Me.btnStdLogin.Size = New System.Drawing.Size(246, 37)
        Me.btnStdLogin.TabIndex = 18
        Me.btnStdLogin.Text = "Login"
        Me.btnStdLogin.UseVisualStyleBackColor = False
        '
        'Btnadmin
        '
        Me.Btnadmin.BackColor = System.Drawing.SystemColors.Highlight
        Me.Btnadmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnadmin.FlatAppearance.BorderSize = 0
        Me.Btnadmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Btnadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnadmin.Location = New System.Drawing.Point(633, 15)
        Me.Btnadmin.Name = "Btnadmin"
        Me.Btnadmin.Size = New System.Drawing.Size(91, 36)
        Me.Btnadmin.TabIndex = 19
        Me.Btnadmin.Text = "Admin Settings"
        Me.Btnadmin.UseVisualStyleBackColor = False
        '
        'frmStudentMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 414)
        Me.Controls.Add(Me.Btnadmin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnExt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStudentMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnExt As Button
    Friend WithEvents TxtStID As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnStdLogin As Button
    Friend WithEvents LblInfo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btnadmin As Button
End Class
