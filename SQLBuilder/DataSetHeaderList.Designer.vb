<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataSetHeaderList
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
        Me.gbTOP = New System.Windows.Forms.GroupBox()
        Me.dgvHeaderList = New System.Windows.Forms.DataGridView()
        Me.HeaderListCRUD = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.stsDataSetList = New System.Windows.Forms.StatusStrip()
        Me.stsDataSetListLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gbTOP.SuspendLayout()
        CType(Me.dgvHeaderList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderListCRUD.SuspendLayout()
        Me.stsDataSetList.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbTOP
        '
        Me.gbTOP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbTOP.Controls.Add(Me.btnClose)
        Me.gbTOP.Controls.Add(Me.btnRefresh)
        Me.gbTOP.Location = New System.Drawing.Point(3, 2)
        Me.gbTOP.Name = "gbTOP"
        Me.gbTOP.Size = New System.Drawing.Size(1112, 52)
        Me.gbTOP.TabIndex = 1
        Me.gbTOP.TabStop = False
        '
        'dgvHeaderList
        '
        Me.dgvHeaderList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvHeaderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHeaderList.Location = New System.Drawing.Point(3, 60)
        Me.dgvHeaderList.Name = "dgvHeaderList"
        Me.dgvHeaderList.ReadOnly = True
        Me.dgvHeaderList.Size = New System.Drawing.Size(1112, 468)
        Me.dgvHeaderList.TabIndex = 12
        '
        'HeaderListCRUD
        '
        Me.HeaderListCRUD.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectToolStripMenuItem})
        Me.HeaderListCRUD.Name = "HeaderListCRUD"
        Me.HeaderListCRUD.Size = New System.Drawing.Size(106, 26)
        '
        'SelectToolStripMenuItem
        '
        Me.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem"
        Me.SelectToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.SelectToolStripMenuItem.Text = "Select"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(9, 19)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 23)
        Me.btnRefresh.TabIndex = 27
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(108, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 23)
        Me.btnClose.TabIndex = 28
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'stsDataSetList
        '
        Me.stsDataSetList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsDataSetListLabel1})
        Me.stsDataSetList.Location = New System.Drawing.Point(0, 512)
        Me.stsDataSetList.Name = "stsDataSetList"
        Me.stsDataSetList.Size = New System.Drawing.Size(1127, 22)
        Me.stsDataSetList.TabIndex = 13
        Me.stsDataSetList.Text = "StatusStrip1"
        '
        'stsDataSetListLabel1
        '
        Me.stsDataSetListLabel1.Name = "stsDataSetListLabel1"
        Me.stsDataSetListLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'DataSetHeaderList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 534)
        Me.Controls.Add(Me.stsDataSetList)
        Me.Controls.Add(Me.dgvHeaderList)
        Me.Controls.Add(Me.gbTOP)
        Me.Name = "DataSetHeaderList"
        Me.Text = "Data Set List"
        Me.gbTOP.ResumeLayout(False)
        CType(Me.dgvHeaderList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderListCRUD.ResumeLayout(False)
        Me.stsDataSetList.ResumeLayout(False)
        Me.stsDataSetList.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbTOP As GroupBox
    Friend WithEvents dgvHeaderList As DataGridView
    Friend WithEvents HeaderListCRUD As ContextMenuStrip
    Friend WithEvents SelectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClose As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents stsDataSetList As StatusStrip
    Friend WithEvents stsDataSetListLabel1 As ToolStripStatusLabel
End Class
