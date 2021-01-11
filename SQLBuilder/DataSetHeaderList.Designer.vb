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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataSetHeaderList))
        Me.gbTOP = New System.Windows.Forms.GroupBox()
        Me.btnEditTable = New System.Windows.Forms.Button()
        Me.btnAddTable = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvHeaderList = New System.Windows.Forms.DataGridView()
        Me.HeaderListCRUD = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsDataSetList = New System.Windows.Forms.StatusStrip()
        Me.stsDataSetListLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDataSet = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.gbTOP.Controls.Add(Me.txtDataSet)
        Me.gbTOP.Controls.Add(Me.Label1)
        Me.gbTOP.Controls.Add(Me.txtUser)
        Me.gbTOP.Controls.Add(Me.Label6)
        Me.gbTOP.Controls.Add(Me.btnEditTable)
        Me.gbTOP.Controls.Add(Me.btnAddTable)
        Me.gbTOP.Controls.Add(Me.btnClose)
        Me.gbTOP.Controls.Add(Me.btnRefresh)
        Me.gbTOP.Location = New System.Drawing.Point(3, 2)
        Me.gbTOP.Name = "gbTOP"
        Me.gbTOP.Size = New System.Drawing.Size(877, 52)
        Me.gbTOP.TabIndex = 1
        Me.gbTOP.TabStop = False
        '
        'btnEditTable
        '
        Me.btnEditTable.Location = New System.Drawing.Point(181, 19)
        Me.btnEditTable.Name = "btnEditTable"
        Me.btnEditTable.Size = New System.Drawing.Size(80, 23)
        Me.btnEditTable.TabIndex = 30
        Me.btnEditTable.Text = "Edit Table"
        Me.btnEditTable.UseVisualStyleBackColor = True
        '
        'btnAddTable
        '
        Me.btnAddTable.Location = New System.Drawing.Point(95, 19)
        Me.btnAddTable.Name = "btnAddTable"
        Me.btnAddTable.Size = New System.Drawing.Size(80, 23)
        Me.btnAddTable.TabIndex = 29
        Me.btnAddTable.Text = "Add Table"
        Me.btnAddTable.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(791, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 23)
        Me.btnClose.TabIndex = 28
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
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
        'dgvHeaderList
        '
        Me.dgvHeaderList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvHeaderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHeaderList.Location = New System.Drawing.Point(3, 60)
        Me.dgvHeaderList.Name = "dgvHeaderList"
        Me.dgvHeaderList.ReadOnly = True
        Me.dgvHeaderList.Size = New System.Drawing.Size(877, 468)
        Me.dgvHeaderList.TabIndex = 12
        '
        'HeaderListCRUD
        '
        Me.HeaderListCRUD.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectToolStripMenuItem, Me.ToolStripMenuItem1, Me.AddTableToolStripMenuItem, Me.EditTableToolStripMenuItem, Me.ToolStripSeparator1, Me.RemoveTableToolStripMenuItem})
        Me.HeaderListCRUD.Name = "HeaderListCRUD"
        Me.HeaderListCRUD.Size = New System.Drawing.Size(148, 104)
        '
        'SelectToolStripMenuItem
        '
        Me.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem"
        Me.SelectToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.SelectToolStripMenuItem.Text = "Select"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(144, 6)
        '
        'AddTableToolStripMenuItem
        '
        Me.AddTableToolStripMenuItem.Name = "AddTableToolStripMenuItem"
        Me.AddTableToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.AddTableToolStripMenuItem.Text = "Add Table"
        '
        'EditTableToolStripMenuItem
        '
        Me.EditTableToolStripMenuItem.Name = "EditTableToolStripMenuItem"
        Me.EditTableToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.EditTableToolStripMenuItem.Text = "Edit Table"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(144, 6)
        '
        'RemoveTableToolStripMenuItem
        '
        Me.RemoveTableToolStripMenuItem.Name = "RemoveTableToolStripMenuItem"
        Me.RemoveTableToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.RemoveTableToolStripMenuItem.Text = "Remove Table"
        '
        'stsDataSetList
        '
        Me.stsDataSetList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsDataSetListLabel1})
        Me.stsDataSetList.Location = New System.Drawing.Point(0, 512)
        Me.stsDataSetList.Name = "stsDataSetList"
        Me.stsDataSetList.Size = New System.Drawing.Size(892, 22)
        Me.stsDataSetList.TabIndex = 13
        Me.stsDataSetList.Text = "StatusStrip1"
        '
        'stsDataSetListLabel1
        '
        Me.stsDataSetListLabel1.Name = "stsDataSetListLabel1"
        Me.stsDataSetListLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(656, 20)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(70, 20)
        Me.txtUser.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(621, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "User"
        '
        'txtDataSet
        '
        Me.txtDataSet.Location = New System.Drawing.Point(441, 20)
        Me.txtDataSet.Name = "txtDataSet"
        Me.txtDataSet.Size = New System.Drawing.Size(70, 20)
        Me.txtDataSet.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(386, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Data Set"
        '
        'DataSetHeaderList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 534)
        Me.Controls.Add(Me.stsDataSetList)
        Me.Controls.Add(Me.dgvHeaderList)
        Me.Controls.Add(Me.gbTOP)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DataSetHeaderList"
        Me.Text = "Data Set List"
        Me.gbTOP.ResumeLayout(False)
        Me.gbTOP.PerformLayout()
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
    Friend WithEvents btnEditTable As Button
    Friend WithEvents btnAddTable As Button
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents RemoveTableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddTableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditTableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDataSet As TextBox
    Friend WithEvents Label1 As Label
End Class
