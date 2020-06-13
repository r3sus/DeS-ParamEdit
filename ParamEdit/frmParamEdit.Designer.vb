<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmParamEdit
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
        Me.txtParamdef = New System.Windows.Forms.TextBox()
        Me.lblGAFile = New System.Windows.Forms.Label()
        Me.btnBrowseParamdef = New System.Windows.Forms.Button()
        Me.txtParam = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBrowseParam = New System.Windows.Forms.Button()
        Me.dgvParams = New System.Windows.Forms.DataGridView()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblVer = New System.Windows.Forms.Label()
        Me.txtParamName = New System.Windows.Forms.TextBox()
        Me.lblParamName = New System.Windows.Forms.Label()
        Me.txtUnk0x8 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUnk0x6 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExportCSV = New System.Windows.Forms.Button()
        Me.btnImportCSV = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.pdf = New System.Windows.Forms.Button()
        Me.Debak = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bnd = New System.Windows.Forms.TextBox()
        Me.bn = New System.Windows.Forms.TextBox()
        Me.prm = New System.Windows.Forms.Button()
        Me.Draw = New System.Windows.Forms.CheckBox()
        Me.ccn = New System.Windows.Forms.CheckBox()
        CType(Me.dgvParams, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtParamdef
        '
        Me.txtParamdef.AllowDrop = True
        Me.txtParamdef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtParamdef.Location = New System.Drawing.Point(102, 83)
        Me.txtParamdef.Name = "txtParamdef"
        Me.txtParamdef.Size = New System.Drawing.Size(383, 20)
        Me.txtParamdef.TabIndex = 29
        Me.txtParamdef.Visible = False
        '
        'lblGAFile
        '
        Me.lblGAFile.AutoSize = True
        Me.lblGAFile.BackColor = System.Drawing.Color.Transparent
        Me.lblGAFile.Location = New System.Drawing.Point(34, 85)
        Me.lblGAFile.Name = "lblGAFile"
        Me.lblGAFile.Size = New System.Drawing.Size(52, 13)
        Me.lblGAFile.TabIndex = 31
        Me.lblGAFile.Text = "Paramdef"
        Me.lblGAFile.Visible = False
        '
        'btnBrowseParamdef
        '
        Me.btnBrowseParamdef.Location = New System.Drawing.Point(519, 239)
        Me.btnBrowseParamdef.Name = "btnBrowseParamdef"
        Me.btnBrowseParamdef.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseParamdef.TabIndex = 30
        Me.btnBrowseParamdef.Text = "Browse"
        Me.btnBrowseParamdef.UseVisualStyleBackColor = True
        Me.btnBrowseParamdef.Visible = False
        '
        'txtParam
        '
        Me.txtParam.AllowDrop = True
        Me.txtParam.Location = New System.Drawing.Point(819, 9)
        Me.txtParam.Name = "txtParam"
        Me.txtParam.Size = New System.Drawing.Size(383, 20)
        Me.txtParam.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(776, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Param"
        '
        'btnBrowseParam
        '
        Me.btnBrowseParam.Location = New System.Drawing.Point(519, 268)
        Me.btnBrowseParam.Name = "btnBrowseParam"
        Me.btnBrowseParam.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseParam.TabIndex = 33
        Me.btnBrowseParam.Text = "Browse"
        Me.btnBrowseParam.UseVisualStyleBackColor = True
        Me.btnBrowseParam.Visible = False
        '
        'dgvParams
        '
        Me.dgvParams.AllowDrop = True
        Me.dgvParams.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgvParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParams.Location = New System.Drawing.Point(12, 33)
        Me.dgvParams.Name = "dgvParams"
        Me.dgvParams.Size = New System.Drawing.Size(1264, 577)
        Me.dgvParams.TabIndex = 36
        '
        'btnOpen
        '
        Me.btnOpen.Enabled = False
        Me.btnOpen.Location = New System.Drawing.Point(184, 7)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(57, 22)
        Me.btnOpen.TabIndex = 37
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(247, 7)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.TabIndex = 38
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(34, 247)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(182, 23)
        Me.btnUpdate.TabIndex = 78
        Me.btnUpdate.Text = "Update Param Editor"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'lblVer
        '
        Me.lblVer.AutoSize = True
        Me.lblVer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVer.Location = New System.Drawing.Point(518, 211)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.Size = New System.Drawing.Size(76, 13)
        Me.lblVer.TabIndex = 77
        Me.lblVer.Text = "2018.03.23.22"
        Me.lblVer.Visible = False
        '
        'txtParamName
        '
        Me.txtParamName.AllowDrop = True
        Me.txtParamName.Location = New System.Drawing.Point(102, 211)
        Me.txtParamName.Name = "txtParamName"
        Me.txtParamName.Size = New System.Drawing.Size(75, 20)
        Me.txtParamName.TabIndex = 79
        Me.txtParamName.Visible = False
        '
        'lblParamName
        '
        Me.lblParamName.AutoSize = True
        Me.lblParamName.Location = New System.Drawing.Point(25, 214)
        Me.lblParamName.Name = "lblParamName"
        Me.lblParamName.Size = New System.Drawing.Size(68, 13)
        Me.lblParamName.TabIndex = 80
        Me.lblParamName.Text = "Param Name"
        Me.lblParamName.Visible = False
        '
        'txtUnk0x8
        '
        Me.txtUnk0x8.AllowDrop = True
        Me.txtUnk0x8.Location = New System.Drawing.Point(354, 211)
        Me.txtUnk0x8.Name = "txtUnk0x8"
        Me.txtUnk0x8.Size = New System.Drawing.Size(64, 20)
        Me.txtUnk0x8.TabIndex = 81
        Me.txtUnk0x8.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(318, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "(0x8?)"
        Me.Label2.Visible = False
        '
        'txtUnk0x6
        '
        Me.txtUnk0x6.AllowDrop = True
        Me.txtUnk0x6.Location = New System.Drawing.Point(354, 185)
        Me.txtUnk0x6.Name = "txtUnk0x6"
        Me.txtUnk0x6.Size = New System.Drawing.Size(64, 20)
        Me.txtUnk0x6.TabIndex = 83
        Me.txtUnk0x6.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(318, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "(0x6?)"
        Me.Label3.Visible = False
        '
        'btnExportCSV
        '
        Me.btnExportCSV.Enabled = False
        Me.btnExportCSV.Location = New System.Drawing.Point(519, 7)
        Me.btnExportCSV.Name = "btnExportCSV"
        Me.btnExportCSV.Size = New System.Drawing.Size(75, 22)
        Me.btnExportCSV.TabIndex = 86
        Me.btnExportCSV.Text = "Export CSV"
        Me.btnExportCSV.UseVisualStyleBackColor = True
        '
        'btnImportCSV
        '
        Me.btnImportCSV.Enabled = False
        Me.btnImportCSV.Location = New System.Drawing.Point(686, 8)
        Me.btnImportCSV.Name = "btnImportCSV"
        Me.btnImportCSV.Size = New System.Drawing.Size(75, 22)
        Me.btnImportCSV.TabIndex = 85
        Me.btnImportCSV.Text = "Import CSV"
        Me.btnImportCSV.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Folder", "File"})
        Me.ComboBox1.Location = New System.Drawing.Point(265, 305)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(51, 21)
        Me.ComboBox1.TabIndex = 89
        Me.ComboBox1.Text = "Mode"
        Me.ComboBox1.Visible = False
        '
        'btnRestore
        '
        Me.btnRestore.Enabled = False
        Me.btnRestore.Location = New System.Drawing.Point(345, 7)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(87, 22)
        Me.btnRestore.TabIndex = 90
        Me.btnRestore.Text = "Restore param"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(214, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "FilePath"
        Me.Label4.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(64, 8)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(114, 21)
        Me.ComboBox2.TabIndex = 92
        '
        'pdf
        '
        Me.pdf.Location = New System.Drawing.Point(1208, 8)
        Me.pdf.Name = "pdf"
        Me.pdf.Size = New System.Drawing.Size(68, 22)
        Me.pdf.TabIndex = 93
        Me.pdf.Text = "p-def folder"
        Me.pdf.UseVisualStyleBackColor = True
        '
        'Debak
        '
        Me.Debak.Location = New System.Drawing.Point(438, 7)
        Me.Debak.Name = "Debak"
        Me.Debak.Size = New System.Drawing.Size(50, 22)
        Me.Debak.TabIndex = 94
        Me.Debak.Text = "Debak"
        Me.Debak.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(663, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 95
        Me.Button1.Text = "Restore dcx"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'bnd
        '
        Me.bnd.AllowDrop = True
        Me.bnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bnd.Location = New System.Drawing.Point(407, 123)
        Me.bnd.Name = "bnd"
        Me.bnd.Size = New System.Drawing.Size(177, 20)
        Me.bnd.TabIndex = 96
        Me.bnd.Visible = False
        '
        'bn
        '
        Me.bn.AllowDrop = True
        Me.bn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bn.Location = New System.Drawing.Point(783, 98)
        Me.bn.Name = "bn"
        Me.bn.Size = New System.Drawing.Size(51, 20)
        Me.bn.TabIndex = 99
        Me.bn.Visible = False
        '
        'prm
        '
        Me.prm.Location = New System.Drawing.Point(1145, 152)
        Me.prm.Name = "prm"
        Me.prm.Size = New System.Drawing.Size(68, 22)
        Me.prm.TabIndex = 100
        Me.prm.Text = "param"
        Me.prm.UseVisualStyleBackColor = True
        Me.prm.Visible = False
        '
        'Draw
        '
        Me.Draw.AutoSize = True
        Me.Draw.Location = New System.Drawing.Point(17, 10)
        Me.Draw.Name = "Draw"
        Me.Draw.Size = New System.Drawing.Size(46, 17)
        Me.Draw.TabIndex = 98
        Me.Draw.Text = "oldp"
        Me.Draw.UseVisualStyleBackColor = True
        '
        'ccn
        '
        Me.ccn.AutoSize = True
        Me.ccn.Location = New System.Drawing.Point(625, 10)
        Me.ccn.Name = "ccn"
        Me.ccn.Size = New System.Drawing.Size(44, 17)
        Me.ccn.TabIndex = 101
        Me.ccn.Text = "ccn"
        Me.ccn.UseVisualStyleBackColor = True
        '
        'frmParamEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1286, 618)
        Me.Controls.Add(Me.ccn)
        Me.Controls.Add(Me.prm)
        Me.Controls.Add(Me.txtParam)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblGAFile)
        Me.Controls.Add(Me.txtParamdef)
        Me.Controls.Add(Me.bn)
        Me.Controls.Add(Me.Draw)
        Me.Controls.Add(Me.bnd)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Debak)
        Me.Controls.Add(Me.btnBrowseParam)
        Me.Controls.Add(Me.btnBrowseParamdef)
        Me.Controls.Add(Me.pdf)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnExportCSV)
        Me.Controls.Add(Me.btnImportCSV)
        Me.Controls.Add(Me.txtUnk0x6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUnk0x8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtParamName)
        Me.Controls.Add(Me.lblParamName)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblVer)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.dgvParams)
        Me.Name = "frmParamEdit"
        Me.Text = "Wulf's Souls Series Parameter Editor"
        CType(Me.dgvParams, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtParamdef As System.Windows.Forms.TextBox
    Friend WithEvents lblGAFile As System.Windows.Forms.Label
    Friend WithEvents btnBrowseParamdef As System.Windows.Forms.Button
    Friend WithEvents txtParam As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseParam As System.Windows.Forms.Button
    Friend WithEvents dgvParams As System.Windows.Forms.DataGridView
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblVer As Label
    Friend WithEvents txtParamName As TextBox
    Friend WithEvents lblParamName As Label
    Friend WithEvents txtUnk0x8 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUnk0x6 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExportCSV As Button
    Friend WithEvents btnImportCSV As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnRestore As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents pdf As Button
    Friend WithEvents Debak As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents bnd As TextBox
    Friend WithEvents bn As TextBox
    Friend WithEvents prm As Button
    Friend WithEvents Draw As CheckBox
    Friend WithEvents ccn As CheckBox
End Class
