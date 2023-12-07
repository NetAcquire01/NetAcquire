<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmActivityLog
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbFind = New System.Windows.Forms.Button()
        Me.cmdAdvanceFind = New System.Windows.Forms.Button()
        Me.cmbClear = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.g = New System.Windows.Forms.DataGridView()
        Me.frAdvance = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sampleID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.patID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActionType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Action = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.User = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.g, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frAdvance.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Find Log"
        '
        'cmbFind
        '
        Me.cmbFind.Location = New System.Drawing.Point(462, 17)
        Me.cmbFind.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbFind.Name = "cmbFind"
        Me.cmbFind.Size = New System.Drawing.Size(120, 23)
        Me.cmbFind.TabIndex = 1
        Me.cmbFind.Text = "Find"
        Me.cmbFind.UseVisualStyleBackColor = True
        '
        'cmdAdvanceFind
        '
        Me.cmdAdvanceFind.Location = New System.Drawing.Point(714, 17)
        Me.cmdAdvanceFind.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdAdvanceFind.Name = "cmdAdvanceFind"
        Me.cmdAdvanceFind.Size = New System.Drawing.Size(120, 23)
        Me.cmdAdvanceFind.TabIndex = 2
        Me.cmdAdvanceFind.Text = "Advance Find"
        Me.cmdAdvanceFind.UseVisualStyleBackColor = True
        '
        'cmbClear
        '
        Me.cmbClear.Location = New System.Drawing.Point(588, 17)
        Me.cmbClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbClear.Name = "cmbClear"
        Me.cmbClear.Size = New System.Drawing.Size(120, 23)
        Me.cmbClear.TabIndex = 3
        Me.cmbClear.Text = "Clear"
        Me.cmbClear.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(84, 18)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(372, 22)
        Me.TextBox1.TabIndex = 4
        '
        'g
        '
        Me.g.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.g.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dateTime, Me.sampleID, Me.patID, Me.ActionType, Me.Action, Me.Reason, Me.Notes, Me.User})
        Me.g.Location = New System.Drawing.Point(17, 46)
        Me.g.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.g.Name = "g"
        Me.g.RowHeadersWidth = 51
        Me.g.RowTemplate.Height = 29
        Me.g.Size = New System.Drawing.Size(1407, 490)
        Me.g.TabIndex = 5
        '
        'frAdvance
        '
        Me.frAdvance.Controls.Add(Me.Button2)
        Me.frAdvance.Controls.Add(Me.Button1)
        Me.frAdvance.Controls.Add(Me.CheckBox2)
        Me.frAdvance.Controls.Add(Me.CheckBox1)
        Me.frAdvance.Controls.Add(Me.ComboBox7)
        Me.frAdvance.Controls.Add(Me.ComboBox8)
        Me.frAdvance.Controls.Add(Me.ComboBox6)
        Me.frAdvance.Controls.Add(Me.ComboBox5)
        Me.frAdvance.Controls.Add(Me.ComboBox4)
        Me.frAdvance.Controls.Add(Me.ComboBox3)
        Me.frAdvance.Controls.Add(Me.ComboBox2)
        Me.frAdvance.Controls.Add(Me.TextBox7)
        Me.frAdvance.Controls.Add(Me.TextBox8)
        Me.frAdvance.Controls.Add(Me.TextBox5)
        Me.frAdvance.Controls.Add(Me.TextBox3)
        Me.frAdvance.Controls.Add(Me.TextBox2)
        Me.frAdvance.Controls.Add(Me.Label13)
        Me.frAdvance.Controls.Add(Me.Label9)
        Me.frAdvance.Controls.Add(Me.Label10)
        Me.frAdvance.Controls.Add(Me.Label11)
        Me.frAdvance.Controls.Add(Me.Label5)
        Me.frAdvance.Controls.Add(Me.Label6)
        Me.frAdvance.Controls.Add(Me.Label7)
        Me.frAdvance.Controls.Add(Me.Label8)
        Me.frAdvance.Controls.Add(Me.Label4)
        Me.frAdvance.Controls.Add(Me.Label3)
        Me.frAdvance.Controls.Add(Me.Label2)
        Me.frAdvance.Controls.Add(Me.Label)
        Me.frAdvance.Location = New System.Drawing.Point(449, 106)
        Me.frAdvance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.frAdvance.Name = "frAdvance"
        Me.frAdvance.Size = New System.Drawing.Size(447, 370)
        Me.frAdvance.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(335, 339)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 23)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(243, 339)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Find"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(13, 255)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(78, 20)
        Me.CheckBox2.TabIndex = 28
        Me.CheckBox2.Text = "To Date"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 229)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 20)
        Me.CheckBox1.TabIndex = 27
        Me.CheckBox1.Text = "For Date"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox7
        '
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(125, 310)
        Me.ComboBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(294, 24)
        Me.ComboBox7.TabIndex = 26
        '
        'ComboBox8
        '
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Location = New System.Drawing.Point(126, 283)
        Me.ComboBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(294, 24)
        Me.ComboBox8.TabIndex = 25
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(126, 256)
        Me.ComboBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(112, 24)
        Me.ComboBox6.TabIndex = 24
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(126, 229)
        Me.ComboBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(112, 24)
        Me.ComboBox5.TabIndex = 23
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(126, 202)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(294, 24)
        Me.ComboBox4.TabIndex = 22
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(126, 120)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(294, 24)
        Me.ComboBox3.TabIndex = 21
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(127, 93)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(294, 24)
        Me.ComboBox2.TabIndex = 20
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(127, 174)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(295, 22)
        Me.TextBox7.TabIndex = 19
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(126, 148)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(295, 22)
        Me.TextBox8.TabIndex = 18
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(128, 66)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(136, 22)
        Me.TextBox5.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(127, 38)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(136, 22)
        Me.TextBox3.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(128, 9)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(136, 22)
        Me.TextBox2.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 313)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "App. Version"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 286)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Machine"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 16)
        Me.Label10.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(39, 232)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 16)
        Me.Label11.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "User Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Notes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Reason"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Action"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Action Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Patient ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Submission ID"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(13, 10)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(70, 16)
        Me.Label.TabIndex = 0
        Me.Label.Text = "Sample ID"
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(26, 566)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(120, 23)
        Me.btnExcel.TabIndex = 7
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(1068, 566)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 23)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1207, 566)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'dateTime
        '
        Me.dateTime.HeaderText = "Date Time"
        Me.dateTime.MinimumWidth = 6
        Me.dateTime.Name = "dateTime"
        Me.dateTime.Width = 160
        '
        'sampleID
        '
        Me.sampleID.HeaderText = "Sample ID"
        Me.sampleID.MinimumWidth = 6
        Me.sampleID.Name = "sampleID"
        Me.sampleID.Width = 110
        '
        'patID
        '
        Me.patID.HeaderText = "Patient ID"
        Me.patID.MinimumWidth = 6
        Me.patID.Name = "patID"
        Me.patID.Width = 110
        '
        'ActionType
        '
        Me.ActionType.HeaderText = "Action Type"
        Me.ActionType.MinimumWidth = 6
        Me.ActionType.Name = "ActionType"
        Me.ActionType.Width = 250
        '
        'Action
        '
        Me.Action.HeaderText = "Action"
        Me.Action.MinimumWidth = 6
        Me.Action.Name = "Action"
        Me.Action.Width = 150
        '
        'Reason
        '
        Me.Reason.HeaderText = "Reason"
        Me.Reason.MinimumWidth = 6
        Me.Reason.Name = "Reason"
        Me.Reason.Width = 170
        '
        'Notes
        '
        Me.Notes.HeaderText = "Notes"
        Me.Notes.MinimumWidth = 6
        Me.Notes.Name = "Notes"
        Me.Notes.Width = 200
        '
        'User
        '
        Me.User.HeaderText = "User"
        Me.User.MinimumWidth = 6
        Me.User.Name = "User"
        Me.User.Width = 125
        '
        'frmActivityLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1436, 622)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.frAdvance)
        Me.Controls.Add(Me.g)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmbClear)
        Me.Controls.Add(Me.cmdAdvanceFind)
        Me.Controls.Add(Me.cmbFind)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmActivityLog"
        Me.Text = "Activity Log Viewer"
        CType(Me.g, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frAdvance.ResumeLayout(False)
        Me.frAdvance.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbFind As Button
    Friend WithEvents cmdAdvanceFind As Button
    Friend WithEvents cmbClear As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents g As DataGridView
    Friend WithEvents frAdvance As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnExcel As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents dateTime As DataGridViewTextBoxColumn
    Friend WithEvents sampleID As DataGridViewTextBoxColumn
    Friend WithEvents patID As DataGridViewTextBoxColumn
    Friend WithEvents ActionType As DataGridViewTextBoxColumn
    Friend WithEvents Action As DataGridViewTextBoxColumn
    Friend WithEvents Reason As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
    Friend WithEvents User As DataGridViewTextBoxColumn
End Class
