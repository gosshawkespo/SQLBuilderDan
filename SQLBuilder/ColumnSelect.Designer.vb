<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColumnSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ColumnSelect))
        Me.lblTableName = New System.Windows.Forms.Label()
        Me.txtTablename = New System.Windows.Forms.TextBox()
        Me.dgvFieldSelection = New System.Windows.Forms.DataGridView()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblDataSetName = New System.Windows.Forms.Label()
        Me.txtDatasetName = New System.Windows.Forms.TextBox()
        Me.lstFields = New System.Windows.Forms.ListBox()
        Me.btnMoveSelectFieldsUP = New System.Windows.Forms.Button()
        Me.btnMoveSelectFieldsDOWN = New System.Windows.Forms.Button()
        Me.btnSelectFields = New System.Windows.Forms.Button()
        Me.stsQueryBuilder = New System.Windows.Forms.StatusStrip()
        Me.stsQueryBuilderLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsQueryBuilderLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblElementsToBeDisplayed = New System.Windows.Forms.Label()
        Me.btnSelectOrderBy = New System.Windows.Forms.Button()
        Me.btnMoveOrderByFieldsDown = New System.Windows.Forms.Button()
        Me.btnMoveOrderByFieldsUp = New System.Windows.Forms.Button()
        Me.chklstOrderBY = New System.Windows.Forms.CheckedListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRemoveSelectedFields = New System.Windows.Forms.Button()
        Me.btnRemoveOrderByFields = New System.Windows.Forms.Button()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.txtValue2 = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.lblOperator = New System.Windows.Forms.Label()
        Me.cboOperators = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.gbFilterRecords = New System.Windows.Forms.GroupBox()
        Me.txtINvalues = New System.Windows.Forms.TextBox()
        Me.rbOR = New System.Windows.Forms.RadioButton()
        Me.lstConditions = New System.Windows.Forms.ListBox()
        Me.cbIgnoreCase = New System.Windows.Forms.CheckBox()
        Me.rbAND = New System.Windows.Forms.RadioButton()
        Me.lblFilterRecords = New System.Windows.Forms.Label()
        Me.lblValue2 = New System.Windows.Forms.Label()
        Me.btnAddCondition = New System.Windows.Forms.Button()
        Me.btnRemoveCondition = New System.Windows.Forms.Button()
        Me.cboWhereFields = New System.Windows.Forms.ComboBox()
        Me.txtOperator = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFirstRows = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbDisplayElements = New System.Windows.Forms.GroupBox()
        Me.btnIncludeCount = New System.Windows.Forms.Button()
        Me.lblDataElementsLabel = New System.Windows.Forms.Label()
        Me.cbAudioClick = New System.Windows.Forms.CheckBox()
        Me.gbSortResults = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnHideColumns = New System.Windows.Forms.Button()
        Me.gbExecutionAndSaveOptions = New System.Windows.Forms.GroupBox()
        Me.btnEditQuery = New System.Windows.Forms.Button()
        Me.btnRunSQLQuery = New System.Windows.Forms.Button()
        Me.btnSaveQuery = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnShowSQLQuery = New System.Windows.Forms.Button()
        Me.btnLoadQuery = New System.Windows.Forms.Button()
        Me.lblFilename = New System.Windows.Forms.Label()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.dgvFieldSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stsQueryBuilder.SuspendLayout()
        Me.gbFilterRecords.SuspendLayout()
        Me.gbDisplayElements.SuspendLayout()
        Me.gbSortResults.SuspendLayout()
        Me.gbExecutionAndSaveOptions.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTableName
        '
        Me.lblTableName.AutoSize = True
        Me.lblTableName.Location = New System.Drawing.Point(243, 15)
        Me.lblTableName.Name = "lblTableName"
        Me.lblTableName.Size = New System.Drawing.Size(63, 13)
        Me.lblTableName.TabIndex = 2
        Me.lblTableName.Text = "Tablename:"
        '
        'txtTablename
        '
        Me.txtTablename.Location = New System.Drawing.Point(308, 13)
        Me.txtTablename.Name = "txtTablename"
        Me.txtTablename.Size = New System.Drawing.Size(169, 20)
        Me.txtTablename.TabIndex = 2
        Me.txtTablename.Text = "ECM4120V20"
        '
        'dgvFieldSelection
        '
        Me.dgvFieldSelection.AllowDrop = True
        Me.dgvFieldSelection.AllowUserToAddRows = False
        Me.dgvFieldSelection.AllowUserToDeleteRows = False
        Me.dgvFieldSelection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFieldSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFieldSelection.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvFieldSelection.Location = New System.Drawing.Point(6, 80)
        Me.dgvFieldSelection.MinimumSize = New System.Drawing.Size(0, 170)
        Me.dgvFieldSelection.Name = "dgvFieldSelection"
        Me.dgvFieldSelection.RowHeadersWidth = 62
        Me.dgvFieldSelection.Size = New System.Drawing.Size(462, 616)
        Me.dgvFieldSelection.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClear.Location = New System.Drawing.Point(6, 44)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblDataSetName
        '
        Me.lblDataSetName.AutoSize = True
        Me.lblDataSetName.Location = New System.Drawing.Point(6, 15)
        Me.lblDataSetName.Name = "lblDataSetName"
        Me.lblDataSetName.Size = New System.Drawing.Size(78, 13)
        Me.lblDataSetName.TabIndex = 0
        Me.lblDataSetName.Text = "Dataset Name:"
        '
        'txtDatasetName
        '
        Me.txtDatasetName.Location = New System.Drawing.Point(86, 13)
        Me.txtDatasetName.Name = "txtDatasetName"
        Me.txtDatasetName.ReadOnly = True
        Me.txtDatasetName.Size = New System.Drawing.Size(148, 20)
        Me.txtDatasetName.TabIndex = 1
        '
        'lstFields
        '
        Me.lstFields.AllowDrop = True
        Me.lstFields.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstFields.FormattingEnabled = True
        Me.lstFields.Location = New System.Drawing.Point(164, 34)
        Me.lstFields.MinimumSize = New System.Drawing.Size(165, 140)
        Me.lstFields.Name = "lstFields"
        Me.lstFields.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstFields.Size = New System.Drawing.Size(169, 134)
        Me.lstFields.TabIndex = 8
        Me.lstFields.TabStop = False
        '
        'btnMoveSelectFieldsUP
        '
        Me.btnMoveSelectFieldsUP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMoveSelectFieldsUP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveSelectFieldsUP.Location = New System.Drawing.Point(359, 35)
        Me.btnMoveSelectFieldsUP.Name = "btnMoveSelectFieldsUP"
        Me.btnMoveSelectFieldsUP.Size = New System.Drawing.Size(39, 33)
        Me.btnMoveSelectFieldsUP.TabIndex = 9
        Me.btnMoveSelectFieldsUP.Text = "▲"
        Me.btnMoveSelectFieldsUP.UseVisualStyleBackColor = True
        '
        'btnMoveSelectFieldsDOWN
        '
        Me.btnMoveSelectFieldsDOWN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMoveSelectFieldsDOWN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveSelectFieldsDOWN.Location = New System.Drawing.Point(359, 75)
        Me.btnMoveSelectFieldsDOWN.Name = "btnMoveSelectFieldsDOWN"
        Me.btnMoveSelectFieldsDOWN.Size = New System.Drawing.Size(39, 31)
        Me.btnMoveSelectFieldsDOWN.TabIndex = 10
        Me.btnMoveSelectFieldsDOWN.Text = "▼"
        Me.btnMoveSelectFieldsDOWN.UseVisualStyleBackColor = True
        '
        'btnSelectFields
        '
        Me.btnSelectFields.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectFields.Location = New System.Drawing.Point(14, 34)
        Me.btnSelectFields.MinimumSize = New System.Drawing.Size(140, 0)
        Me.btnSelectFields.Name = "btnSelectFields"
        Me.btnSelectFields.Size = New System.Drawing.Size(140, 23)
        Me.btnSelectFields.TabIndex = 5
        Me.btnSelectFields.Text = "Add Display Fields ->"
        Me.btnSelectFields.UseVisualStyleBackColor = True
        '
        'stsQueryBuilder
        '
        Me.stsQueryBuilder.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.stsQueryBuilder.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsQueryBuilderLabel1, Me.stsQueryBuilderLabel2})
        Me.stsQueryBuilder.Location = New System.Drawing.Point(0, 733)
        Me.stsQueryBuilder.Name = "stsQueryBuilder"
        Me.stsQueryBuilder.Size = New System.Drawing.Size(1266, 22)
        Me.stsQueryBuilder.TabIndex = 22
        Me.stsQueryBuilder.Text = "StatusStrip1"
        '
        'stsQueryBuilderLabel1
        '
        Me.stsQueryBuilderLabel1.Name = "stsQueryBuilderLabel1"
        Me.stsQueryBuilderLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'stsQueryBuilderLabel2
        '
        Me.stsQueryBuilderLabel2.Name = "stsQueryBuilderLabel2"
        Me.stsQueryBuilderLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'lblElementsToBeDisplayed
        '
        Me.lblElementsToBeDisplayed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblElementsToBeDisplayed.AutoSize = True
        Me.lblElementsToBeDisplayed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElementsToBeDisplayed.Location = New System.Drawing.Point(2, 12)
        Me.lblElementsToBeDisplayed.Name = "lblElementsToBeDisplayed"
        Me.lblElementsToBeDisplayed.Size = New System.Drawing.Size(183, 13)
        Me.lblElementsToBeDisplayed.TabIndex = 8
        Me.lblElementsToBeDisplayed.Text = "Data Elements to be displayed:"
        '
        'btnSelectOrderBy
        '
        Me.btnSelectOrderBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectOrderBy.Location = New System.Drawing.Point(14, 34)
        Me.btnSelectOrderBy.MinimumSize = New System.Drawing.Size(140, 0)
        Me.btnSelectOrderBy.Name = "btnSelectOrderBy"
        Me.btnSelectOrderBy.Size = New System.Drawing.Size(140, 23)
        Me.btnSelectOrderBy.TabIndex = 11
        Me.btnSelectOrderBy.Text = "Add Sort Fields ↓"
        Me.btnSelectOrderBy.UseVisualStyleBackColor = True
        '
        'btnMoveOrderByFieldsDown
        '
        Me.btnMoveOrderByFieldsDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMoveOrderByFieldsDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveOrderByFieldsDown.Location = New System.Drawing.Point(359, 75)
        Me.btnMoveOrderByFieldsDown.Name = "btnMoveOrderByFieldsDown"
        Me.btnMoveOrderByFieldsDown.Size = New System.Drawing.Size(39, 31)
        Me.btnMoveOrderByFieldsDown.TabIndex = 15
        Me.btnMoveOrderByFieldsDown.Text = "▼"
        Me.btnMoveOrderByFieldsDown.UseVisualStyleBackColor = True
        '
        'btnMoveOrderByFieldsUp
        '
        Me.btnMoveOrderByFieldsUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMoveOrderByFieldsUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveOrderByFieldsUp.Location = New System.Drawing.Point(359, 35)
        Me.btnMoveOrderByFieldsUp.Name = "btnMoveOrderByFieldsUp"
        Me.btnMoveOrderByFieldsUp.Size = New System.Drawing.Size(39, 33)
        Me.btnMoveOrderByFieldsUp.TabIndex = 14
        Me.btnMoveOrderByFieldsUp.Text = "▲"
        Me.btnMoveOrderByFieldsUp.UseVisualStyleBackColor = True
        '
        'chklstOrderBY
        '
        Me.chklstOrderBY.AllowDrop = True
        Me.chklstOrderBY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chklstOrderBY.FormattingEnabled = True
        Me.chklstOrderBY.Location = New System.Drawing.Point(164, 34)
        Me.chklstOrderBY.MinimumSize = New System.Drawing.Size(165, 140)
        Me.chklstOrderBY.MultiColumn = True
        Me.chklstOrderBY.Name = "chklstOrderBY"
        Me.chklstOrderBY.Size = New System.Drawing.Size(169, 139)
        Me.chklstOrderBY.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(257, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Sort the results into the following sequence:"
        '
        'btnRemoveSelectedFields
        '
        Me.btnRemoveSelectedFields.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveSelectedFields.Location = New System.Drawing.Point(14, 64)
        Me.btnRemoveSelectedFields.MinimumSize = New System.Drawing.Size(140, 0)
        Me.btnRemoveSelectedFields.Name = "btnRemoveSelectedFields"
        Me.btnRemoveSelectedFields.Size = New System.Drawing.Size(140, 23)
        Me.btnRemoveSelectedFields.TabIndex = 6
        Me.btnRemoveSelectedFields.Text = "<- Remove "
        Me.btnRemoveSelectedFields.UseVisualStyleBackColor = True
        '
        'btnRemoveOrderByFields
        '
        Me.btnRemoveOrderByFields.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveOrderByFields.Location = New System.Drawing.Point(14, 63)
        Me.btnRemoveOrderByFields.MinimumSize = New System.Drawing.Size(140, 0)
        Me.btnRemoveOrderByFields.Name = "btnRemoveOrderByFields"
        Me.btnRemoveOrderByFields.Size = New System.Drawing.Size(140, 23)
        Me.btnRemoveOrderByFields.TabIndex = 12
        Me.btnRemoveOrderByFields.Text = "<- Remove "
        Me.btnRemoveOrderByFields.UseVisualStyleBackColor = True
        '
        'dtp2
        '
        Me.dtp2.CustomFormat = "yyyy-MM-dd"
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp2.Location = New System.Drawing.Point(324, 113)
        Me.dtp2.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(140, 20)
        Me.dtp2.TabIndex = 22
        Me.dtp2.Visible = False
        '
        'dtp1
        '
        Me.dtp1.CustomFormat = "yyyy-MM-dd"
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp1.Location = New System.Drawing.Point(174, 113)
        Me.dtp1.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(140, 20)
        Me.dtp1.TabIndex = 21
        Me.dtp1.Value = New Date(2020, 4, 7, 0, 0, 0, 0)
        Me.dtp1.Visible = False
        '
        'txtValue2
        '
        Me.txtValue2.Location = New System.Drawing.Point(324, 112)
        Me.txtValue2.Name = "txtValue2"
        Me.txtValue2.Size = New System.Drawing.Size(140, 20)
        Me.txtValue2.TabIndex = 21
        '
        'lblMessage
        '
        Me.lblMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(564, 461)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblMessage.TabIndex = 23
        Me.lblMessage.Visible = False
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(171, 91)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(34, 13)
        Me.lblValue.TabIndex = 6
        Me.lblValue.Text = "Value"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(174, 112)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(140, 20)
        Me.txtValue.TabIndex = 20
        '
        'lblColumn
        '
        Me.lblColumn.AutoSize = True
        Me.lblColumn.Location = New System.Drawing.Point(14, 35)
        Me.lblColumn.Name = "lblColumn"
        Me.lblColumn.Size = New System.Drawing.Size(29, 13)
        Me.lblColumn.TabIndex = 1
        Me.lblColumn.Text = "Field"
        '
        'lblOperator
        '
        Me.lblOperator.AutoSize = True
        Me.lblOperator.Location = New System.Drawing.Point(13, 91)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(48, 13)
        Me.lblOperator.TabIndex = 4
        Me.lblOperator.Text = "Operator"
        '
        'cboOperators
        '
        Me.cboOperators.FormattingEnabled = True
        Me.cboOperators.Location = New System.Drawing.Point(14, 112)
        Me.cboOperators.Name = "cboOperators"
        Me.cboOperators.Size = New System.Drawing.Size(149, 21)
        Me.cboOperators.TabIndex = 19
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(45, 13)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 23)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'gbFilterRecords
        '
        Me.gbFilterRecords.Controls.Add(Me.txtINvalues)
        Me.gbFilterRecords.Controls.Add(Me.rbOR)
        Me.gbFilterRecords.Controls.Add(Me.lstConditions)
        Me.gbFilterRecords.Controls.Add(Me.cbIgnoreCase)
        Me.gbFilterRecords.Controls.Add(Me.rbAND)
        Me.gbFilterRecords.Controls.Add(Me.dtp2)
        Me.gbFilterRecords.Controls.Add(Me.lblFilterRecords)
        Me.gbFilterRecords.Controls.Add(Me.lblValue2)
        Me.gbFilterRecords.Controls.Add(Me.btnAddCondition)
        Me.gbFilterRecords.Controls.Add(Me.btnRemoveCondition)
        Me.gbFilterRecords.Controls.Add(Me.dtp1)
        Me.gbFilterRecords.Controls.Add(Me.cboWhereFields)
        Me.gbFilterRecords.Controls.Add(Me.txtOperator)
        Me.gbFilterRecords.Controls.Add(Me.txtValue2)
        Me.gbFilterRecords.Controls.Add(Me.cboOperators)
        Me.gbFilterRecords.Controls.Add(Me.lblOperator)
        Me.gbFilterRecords.Controls.Add(Me.lblColumn)
        Me.gbFilterRecords.Controls.Add(Me.txtValue)
        Me.gbFilterRecords.Controls.Add(Me.lblValue)
        Me.gbFilterRecords.Location = New System.Drawing.Point(11, 453)
        Me.gbFilterRecords.Name = "gbFilterRecords"
        Me.gbFilterRecords.Size = New System.Drawing.Size(773, 243)
        Me.gbFilterRecords.TabIndex = 20
        Me.gbFilterRecords.TabStop = False
        '
        'txtINvalues
        '
        Me.txtINvalues.Location = New System.Drawing.Point(174, 112)
        Me.txtINvalues.Multiline = True
        Me.txtINvalues.Name = "txtINvalues"
        Me.txtINvalues.Size = New System.Drawing.Size(140, 95)
        Me.txtINvalues.TabIndex = 25
        Me.txtINvalues.Visible = False
        '
        'rbOR
        '
        Me.rbOR.AutoSize = True
        Me.rbOR.Location = New System.Drawing.Point(228, 58)
        Me.rbOR.Name = "rbOR"
        Me.rbOR.Size = New System.Drawing.Size(41, 17)
        Me.rbOR.TabIndex = 18
        Me.rbOR.Text = "OR"
        Me.rbOR.UseVisualStyleBackColor = True
        '
        'lstConditions
        '
        Me.lstConditions.FormattingEnabled = True
        Me.lstConditions.Location = New System.Drawing.Point(324, 144)
        Me.lstConditions.Name = "lstConditions"
        Me.lstConditions.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstConditions.Size = New System.Drawing.Size(443, 95)
        Me.lstConditions.TabIndex = 26
        '
        'cbIgnoreCase
        '
        Me.cbIgnoreCase.AutoSize = True
        Me.cbIgnoreCase.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbIgnoreCase.Checked = True
        Me.cbIgnoreCase.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbIgnoreCase.Location = New System.Drawing.Point(324, 56)
        Me.cbIgnoreCase.Name = "cbIgnoreCase"
        Me.cbIgnoreCase.Size = New System.Drawing.Size(86, 17)
        Me.cbIgnoreCase.TabIndex = 25
        Me.cbIgnoreCase.Text = "Ignore Case:"
        Me.cbIgnoreCase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbIgnoreCase.UseVisualStyleBackColor = True
        '
        'rbAND
        '
        Me.rbAND.AutoSize = True
        Me.rbAND.Checked = True
        Me.rbAND.Location = New System.Drawing.Point(174, 58)
        Me.rbAND.Name = "rbAND"
        Me.rbAND.Size = New System.Drawing.Size(48, 17)
        Me.rbAND.TabIndex = 17
        Me.rbAND.TabStop = True
        Me.rbAND.Text = "AND"
        Me.rbAND.UseVisualStyleBackColor = True
        '
        'lblFilterRecords
        '
        Me.lblFilterRecords.AutoSize = True
        Me.lblFilterRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilterRecords.Location = New System.Drawing.Point(2, 12)
        Me.lblFilterRecords.Name = "lblFilterRecords"
        Me.lblFilterRecords.Size = New System.Drawing.Size(244, 13)
        Me.lblFilterRecords.TabIndex = 20
        Me.lblFilterRecords.Text = "Filter Records using Following Conditions:"
        '
        'lblValue2
        '
        Me.lblValue2.AutoSize = True
        Me.lblValue2.Location = New System.Drawing.Point(323, 91)
        Me.lblValue2.Name = "lblValue2"
        Me.lblValue2.Size = New System.Drawing.Size(43, 13)
        Me.lblValue2.TabIndex = 8
        Me.lblValue2.Text = "Value 2"
        Me.lblValue2.Visible = False
        '
        'btnAddCondition
        '
        Me.btnAddCondition.Location = New System.Drawing.Point(483, 110)
        Me.btnAddCondition.Name = "btnAddCondition"
        Me.btnAddCondition.Size = New System.Drawing.Size(120, 24)
        Me.btnAddCondition.TabIndex = 22
        Me.btnAddCondition.Text = "Add Condition"
        Me.btnAddCondition.UseVisualStyleBackColor = True
        '
        'btnRemoveCondition
        '
        Me.btnRemoveCondition.Location = New System.Drawing.Point(623, 108)
        Me.btnRemoveCondition.Name = "btnRemoveCondition"
        Me.btnRemoveCondition.Size = New System.Drawing.Size(120, 24)
        Me.btnRemoveCondition.TabIndex = 23
        Me.btnRemoveCondition.Text = "Remove Condition"
        Me.btnRemoveCondition.UseVisualStyleBackColor = True
        '
        'cboWhereFields
        '
        Me.cboWhereFields.FormattingEnabled = True
        Me.cboWhereFields.Location = New System.Drawing.Point(14, 56)
        Me.cboWhereFields.Name = "cboWhereFields"
        Me.cboWhereFields.Size = New System.Drawing.Size(147, 21)
        Me.cboWhereFields.TabIndex = 16
        '
        'txtOperator
        '
        Me.txtOperator.Location = New System.Drawing.Point(14, 140)
        Me.txtOperator.Name = "txtOperator"
        Me.txtOperator.Size = New System.Drawing.Size(150, 20)
        Me.txtOperator.TabIndex = 18
        Me.txtOperator.Text = "="
        Me.txtOperator.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(172, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Rows"
        '
        'txtFirstRows
        '
        Me.txtFirstRows.Location = New System.Drawing.Point(89, 134)
        Me.txtFirstRows.Name = "txtFirstRows"
        Me.txtFirstRows.Size = New System.Drawing.Size(70, 20)
        Me.txtFirstRows.TabIndex = 26
        Me.txtFirstRows.Text = "0"
        Me.txtFirstRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Return First"
        '
        'gbDisplayElements
        '
        Me.gbDisplayElements.Controls.Add(Me.btnIncludeCount)
        Me.gbDisplayElements.Controls.Add(Me.lblDataElementsLabel)
        Me.gbDisplayElements.Controls.Add(Me.lstFields)
        Me.gbDisplayElements.Controls.Add(Me.btnMoveSelectFieldsUP)
        Me.gbDisplayElements.Controls.Add(Me.btnMoveSelectFieldsDOWN)
        Me.gbDisplayElements.Controls.Add(Me.btnSelectFields)
        Me.gbDisplayElements.Controls.Add(Me.lblElementsToBeDisplayed)
        Me.gbDisplayElements.Controls.Add(Me.btnRemoveSelectedFields)
        Me.gbDisplayElements.Location = New System.Drawing.Point(11, 76)
        Me.gbDisplayElements.Name = "gbDisplayElements"
        Me.gbDisplayElements.Size = New System.Drawing.Size(426, 180)
        Me.gbDisplayElements.TabIndex = 24
        Me.gbDisplayElements.TabStop = False
        '
        'btnIncludeCount
        '
        Me.btnIncludeCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIncludeCount.Location = New System.Drawing.Point(14, 145)
        Me.btnIncludeCount.MinimumSize = New System.Drawing.Size(140, 0)
        Me.btnIncludeCount.Name = "btnIncludeCount"
        Me.btnIncludeCount.Size = New System.Drawing.Size(140, 23)
        Me.btnIncludeCount.TabIndex = 28
        Me.btnIncludeCount.Text = "Include Count(*) ->"
        Me.btnIncludeCount.UseVisualStyleBackColor = True
        '
        'lblDataElementsLabel
        '
        Me.lblDataElementsLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataElementsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataElementsLabel.Location = New System.Drawing.Point(344, 113)
        Me.lblDataElementsLabel.Name = "lblDataElementsLabel"
        Me.lblDataElementsLabel.Size = New System.Drawing.Size(72, 55)
        Me.lblDataElementsLabel.TabIndex = 27
        Me.lblDataElementsLabel.Text = "Highlight Item in list to move up or down with arrows."
        '
        'cbAudioClick
        '
        Me.cbAudioClick.AutoSize = True
        Me.cbAudioClick.Location = New System.Drawing.Point(17, 101)
        Me.cbAudioClick.Name = "cbAudioClick"
        Me.cbAudioClick.Size = New System.Drawing.Size(79, 17)
        Me.cbAudioClick.TabIndex = 28
        Me.cbAudioClick.Text = "Audio Click"
        Me.cbAudioClick.UseVisualStyleBackColor = True
        Me.cbAudioClick.Visible = False
        '
        'gbSortResults
        '
        Me.gbSortResults.Controls.Add(Me.cbAudioClick)
        Me.gbSortResults.Controls.Add(Me.Label4)
        Me.gbSortResults.Controls.Add(Me.chklstOrderBY)
        Me.gbSortResults.Controls.Add(Me.btnMoveOrderByFieldsUp)
        Me.gbSortResults.Controls.Add(Me.btnMoveOrderByFieldsDown)
        Me.gbSortResults.Controls.Add(Me.btnSelectOrderBy)
        Me.gbSortResults.Controls.Add(Me.Label5)
        Me.gbSortResults.Controls.Add(Me.btnRemoveOrderByFields)
        Me.gbSortResults.Location = New System.Drawing.Point(11, 263)
        Me.gbSortResults.Name = "gbSortResults"
        Me.gbSortResults.Size = New System.Drawing.Size(426, 180)
        Me.gbSortResults.TabIndex = 25
        Me.gbSortResults.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(344, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 55)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Tick Item in list to indicate reversed sort."
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(104, 44)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 23)
        Me.btnRefresh.TabIndex = 26
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnHideColumns
        '
        Me.btnHideColumns.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnHideColumns.Location = New System.Drawing.Point(215, 44)
        Me.btnHideColumns.Name = "btnHideColumns"
        Me.btnHideColumns.Size = New System.Drawing.Size(19, 23)
        Me.btnHideColumns.TabIndex = 27
        Me.btnHideColumns.Text = "+"
        Me.btnHideColumns.UseVisualStyleBackColor = False
        '
        'gbExecutionAndSaveOptions
        '
        Me.gbExecutionAndSaveOptions.Controls.Add(Me.btnEditQuery)
        Me.gbExecutionAndSaveOptions.Controls.Add(Me.btnRunSQLQuery)
        Me.gbExecutionAndSaveOptions.Controls.Add(Me.Label7)
        Me.gbExecutionAndSaveOptions.Controls.Add(Me.btnSaveQuery)
        Me.gbExecutionAndSaveOptions.Controls.Add(Me.txtFirstRows)
        Me.gbExecutionAndSaveOptions.Controls.Add(Me.Label6)
        Me.gbExecutionAndSaveOptions.Controls.Add(Me.Label9)
        Me.gbExecutionAndSaveOptions.Controls.Add(Me.btnShowSQLQuery)
        Me.gbExecutionAndSaveOptions.Controls.Add(Me.btnLoadQuery)
        Me.gbExecutionAndSaveOptions.Location = New System.Drawing.Point(443, 76)
        Me.gbExecutionAndSaveOptions.Name = "gbExecutionAndSaveOptions"
        Me.gbExecutionAndSaveOptions.Size = New System.Drawing.Size(306, 210)
        Me.gbExecutionAndSaveOptions.TabIndex = 30
        Me.gbExecutionAndSaveOptions.TabStop = False
        '
        'btnEditQuery
        '
        Me.btnEditQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditQuery.Location = New System.Drawing.Point(160, 36)
        Me.btnEditQuery.MinimumSize = New System.Drawing.Size(140, 0)
        Me.btnEditQuery.Name = "btnEditQuery"
        Me.btnEditQuery.Size = New System.Drawing.Size(140, 23)
        Me.btnEditQuery.TabIndex = 31
        Me.btnEditQuery.Text = "Edit Query"
        Me.btnEditQuery.UseVisualStyleBackColor = True
        '
        'btnRunSQLQuery
        '
        Me.btnRunSQLQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRunSQLQuery.Location = New System.Drawing.Point(19, 94)
        Me.btnRunSQLQuery.MinimumSize = New System.Drawing.Size(140, 0)
        Me.btnRunSQLQuery.Name = "btnRunSQLQuery"
        Me.btnRunSQLQuery.Size = New System.Drawing.Size(140, 23)
        Me.btnRunSQLQuery.TabIndex = 29
        Me.btnRunSQLQuery.Text = "Run Query"
        Me.btnRunSQLQuery.UseVisualStyleBackColor = True
        '
        'btnSaveQuery
        '
        Me.btnSaveQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveQuery.Location = New System.Drawing.Point(19, 65)
        Me.btnSaveQuery.MinimumSize = New System.Drawing.Size(140, 0)
        Me.btnSaveQuery.Name = "btnSaveQuery"
        Me.btnSaveQuery.Size = New System.Drawing.Size(140, 23)
        Me.btnSaveQuery.TabIndex = 6
        Me.btnSaveQuery.Text = "Save Query"
        Me.btnSaveQuery.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Execution and Save Options"
        '
        'btnShowSQLQuery
        '
        Me.btnShowSQLQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowSQLQuery.Location = New System.Drawing.Point(28, 173)
        Me.btnShowSQLQuery.MinimumSize = New System.Drawing.Size(140, 0)
        Me.btnShowSQLQuery.Name = "btnShowSQLQuery"
        Me.btnShowSQLQuery.Size = New System.Drawing.Size(140, 23)
        Me.btnShowSQLQuery.TabIndex = 28
        Me.btnShowSQLQuery.Text = "Show Query"
        Me.btnShowSQLQuery.UseVisualStyleBackColor = True
        '
        'btnLoadQuery
        '
        Me.btnLoadQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoadQuery.Location = New System.Drawing.Point(19, 36)
        Me.btnLoadQuery.MinimumSize = New System.Drawing.Size(140, 0)
        Me.btnLoadQuery.Name = "btnLoadQuery"
        Me.btnLoadQuery.Size = New System.Drawing.Size(140, 23)
        Me.btnLoadQuery.TabIndex = 5
        Me.btnLoadQuery.Text = "Load Query"
        Me.btnLoadQuery.UseVisualStyleBackColor = True
        '
        'lblFilename
        '
        Me.lblFilename.AutoSize = True
        Me.lblFilename.Location = New System.Drawing.Point(254, 50)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(52, 13)
        Me.lblFilename.TabIndex = 31
        Me.lblFilename.Text = "Filename:"
        '
        'txtFilename
        '
        Me.txtFilename.Location = New System.Drawing.Point(308, 48)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.ReadOnly = True
        Me.txtFilename.Size = New System.Drawing.Size(169, 20)
        Me.txtFilename.TabIndex = 32
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(12, 50)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(32, 13)
        Me.lblPath.TabIndex = 33
        Me.lblPath.Text = "Path:"
        '
        'txtFilePath
        '
        Me.txtFilePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilePath.Location = New System.Drawing.Point(45, 48)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ReadOnly = True
        Me.txtFilePath.Size = New System.Drawing.Size(698, 20)
        Me.txtFilePath.TabIndex = 34
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(6, 6)
        Me.SplitContainer1.MinimumSize = New System.Drawing.Size(100, 100)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.AutoScrollMargin = New System.Drawing.Size(5, 5)
        Me.SplitContainer1.Panel1.AutoScrollMinSize = New System.Drawing.Size(5, 5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvFieldSelection)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFilename)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblDataSetName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFilename)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTablename)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnHideColumns)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblTableName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRefresh)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnClear)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDatasetName)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.AutoScrollMargin = New System.Drawing.Size(5, 5)
        Me.SplitContainer1.Panel2.AutoScrollMinSize = New System.Drawing.Size(5, 5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblPath)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbDisplayElements)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnClose)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbExecutionAndSaveOptions)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtFilePath)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbSortResults)
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbFilterRecords)
        Me.SplitContainer1.Size = New System.Drawing.Size(1288, 713)
        Me.SplitContainer1.SplitterDistance = 488
        Me.SplitContainer1.SplitterWidth = 10
        Me.SplitContainer1.TabIndex = 35
        '
        'ColumnSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1266, 755)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.stsQueryBuilder)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(578, 454)
        Me.Name = "ColumnSelect"
        Me.Text = "SQL Builder"
        CType(Me.dgvFieldSelection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stsQueryBuilder.ResumeLayout(False)
        Me.stsQueryBuilder.PerformLayout()
        Me.gbFilterRecords.ResumeLayout(False)
        Me.gbFilterRecords.PerformLayout()
        Me.gbDisplayElements.ResumeLayout(False)
        Me.gbDisplayElements.PerformLayout()
        Me.gbSortResults.ResumeLayout(False)
        Me.gbSortResults.PerformLayout()
        Me.gbExecutionAndSaveOptions.ResumeLayout(False)
        Me.gbExecutionAndSaveOptions.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTableName As Label
    Friend WithEvents txtTablename As TextBox
    Friend WithEvents dgvFieldSelection As DataGridView
    Friend WithEvents btnClear As Button
    Friend WithEvents lblDataSetName As Label
    Friend WithEvents txtDatasetName As TextBox
    Friend WithEvents lstFields As ListBox
    Friend WithEvents btnMoveSelectFieldsUP As Button
    Friend WithEvents btnMoveSelectFieldsDOWN As Button
    Friend WithEvents btnSelectFields As Button
    Friend WithEvents stsQueryBuilder As StatusStrip
    Friend WithEvents lblElementsToBeDisplayed As Label
    Friend WithEvents stsQueryBuilderLabel1 As ToolStripStatusLabel
    Friend WithEvents btnSelectOrderBy As Button
    Friend WithEvents btnMoveOrderByFieldsDown As Button
    Friend WithEvents btnMoveOrderByFieldsUp As Button
    Friend WithEvents chklstOrderBY As CheckedListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRemoveSelectedFields As Button
    Friend WithEvents btnRemoveOrderByFields As Button
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents txtValue2 As TextBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblValue As Label
    Friend WithEvents txtValue As TextBox
    Friend WithEvents lblColumn As Label
    Friend WithEvents lblOperator As Label
    Friend WithEvents cboOperators As ComboBox
    Friend WithEvents btnClose As Button
    Friend WithEvents gbFilterRecords As GroupBox
    Friend WithEvents lstConditions As ListBox
    Friend WithEvents rbOR As RadioButton
    Friend WithEvents rbAND As RadioButton
    Friend WithEvents btnAddCondition As Button
    Friend WithEvents btnRemoveCondition As Button
    Friend WithEvents cboWhereFields As ComboBox
    Friend WithEvents txtOperator As TextBox
    Friend WithEvents cbIgnoreCase As CheckBox
    Friend WithEvents lblValue2 As Label
    Friend WithEvents gbDisplayElements As GroupBox
    Friend WithEvents gbSortResults As GroupBox
    Friend WithEvents txtINvalues As TextBox
    Friend WithEvents lblFilterRecords As Label
    Friend WithEvents lblDataElementsLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbAudioClick As CheckBox
    Friend WithEvents stsQueryBuilderLabel2 As ToolStripStatusLabel
    Friend WithEvents btnIncludeCount As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFirstRows As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnHideColumns As Button
    Friend WithEvents gbExecutionAndSaveOptions As GroupBox
    Friend WithEvents btnRunSQLQuery As Button
    Friend WithEvents btnSaveQuery As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnShowSQLQuery As Button
    Friend WithEvents btnLoadQuery As Button
    Friend WithEvents lblFilename As Label
    Friend WithEvents txtFilename As TextBox
    Friend WithEvents lblPath As Label
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnEditQuery As Button
End Class
