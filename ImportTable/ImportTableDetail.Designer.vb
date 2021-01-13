<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImportTableDetail
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTableName = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblESID = New System.Windows.Forms.Label()
        Me.txtLibraryName = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stsLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDataSetName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDataSetHeaderText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTextColumnName = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-40, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 14)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Name"
        '
        'btnImport
        '
        Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImport.Enabled = False
        Me.btnImport.Location = New System.Drawing.Point(22, 224)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 5
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(166, 224)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 14)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Table Name"
        '
        'txtTableName
        '
        Me.txtTableName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTableName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTableName.Location = New System.Drawing.Point(143, 22)
        Me.txtTableName.Name = "txtTableName"
        Me.txtTableName.Size = New System.Drawing.Size(101, 22)
        Me.txtTableName.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtTextColumnName)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtDataSetHeaderText)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtDataSetName)
        Me.GroupBox3.Controls.Add(Me.btnImport)
        Me.GroupBox3.Controls.Add(Me.btnCancel)
        Me.GroupBox3.Controls.Add(Me.lblESID)
        Me.GroupBox3.Controls.Add(Me.txtLibraryName)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtTableName)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(514, 262)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        '
        'lblESID
        '
        Me.lblESID.AutoSize = True
        Me.lblESID.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblESID.Location = New System.Drawing.Point(94, 62)
        Me.lblESID.Name = "lblESID"
        Me.lblESID.Size = New System.Drawing.Size(43, 14)
        Me.lblESID.TabIndex = 28
        Me.lblESID.Text = "Library"
        '
        'txtLibraryName
        '
        Me.txtLibraryName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLibraryName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLibraryName.Location = New System.Drawing.Point(143, 59)
        Me.txtLibraryName.Name = "txtLibraryName"
        Me.txtLibraryName.Size = New System.Drawing.Size(101, 22)
        Me.txtLibraryName.TabIndex = 1
        Me.txtLibraryName.Text = "AULT2F3"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 293)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(541, 22)
        Me.StatusStrip1.TabIndex = 29
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stsLabel1
        '
        Me.stsLabel1.Name = "stsLabel1"
        Me.stsLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 14)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Data Set Name"
        '
        'txtDataSetName
        '
        Me.txtDataSetName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataSetName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataSetName.Location = New System.Drawing.Point(143, 96)
        Me.txtDataSetName.Name = "txtDataSetName"
        Me.txtDataSetName.Size = New System.Drawing.Size(101, 22)
        Me.txtDataSetName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 14)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Data Set Description"
        '
        'txtDataSetHeaderText
        '
        Me.txtDataSetHeaderText.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataSetHeaderText.Location = New System.Drawing.Point(143, 133)
        Me.txtDataSetHeaderText.Name = "txtDataSetHeaderText"
        Me.txtDataSetHeaderText.Size = New System.Drawing.Size(309, 22)
        Me.txtDataSetHeaderText.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 14)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Column Containing Text"
        '
        'txtTextColumnName
        '
        Me.txtTextColumnName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTextColumnName.Location = New System.Drawing.Point(143, 170)
        Me.txtTextColumnName.Name = "txtTextColumnName"
        Me.txtTextColumnName.Size = New System.Drawing.Size(101, 22)
        Me.txtTextColumnName.TabIndex = 4
        Me.txtTextColumnName.Text = "Text"
        '
        'ImportTableDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 315)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label6)
        Me.Name = "ImportTableDetail"
        Me.Text = "Import Table Definition"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents btnImport As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTableName As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblESID As Label
    Friend WithEvents txtLibraryName As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents stsLabel1 As ToolStripStatusLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDataSetName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDataSetHeaderText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTextColumnName As TextBox
End Class
