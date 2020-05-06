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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTablename = New System.Windows.Forms.TextBox()
        Me.dgvFieldSelection = New System.Windows.Forms.DataGridView()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDatasetName = New System.Windows.Forms.TextBox()
        Me.lstFields = New System.Windows.Forms.ListBox()
        Me.btnMoveSelectFieldsUP = New System.Windows.Forms.Button()
        Me.btnMoveSelectFieldsDOWN = New System.Windows.Forms.Button()
        Me.btnSelectFields = New System.Windows.Forms.Button()
        Me.stsQueryBuilder = New System.Windows.Forms.StatusStrip()
        Me.stsQueryBuilderLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsQueryBuilderLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnIncludeCount = New System.Windows.Forms.Button()
        Me.lblDataElementsLabel = New System.Windows.Forms.Label()
        Me.cbAudioClick = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnHideColumns = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRunSQLQuery = New System.Windows.Forms.Button()
        Me.btnSaveQuery = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnShowSQLQuery = New System.Windows.Forms.Button()
        Me.btnLoadQuery = New System.Windows.Forms.Button()
        CType(Me.dgvFieldSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stsQueryBuilder.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(243, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tablename:"
        '
        'txtTablename
        '
        Me.txtTablename.Location = New System.Drawing.Point(308, 13)
        Me.txtTablename.Name = "txtTablename"
        Me.txtTablename.ReadOnly = True
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
        Me.dgvFieldSelection.Location = New System.Drawing.Point(6, 69)
        Me.dgvFieldSelection.MinimumSize = New System.Drawing.Size(0, 170)
        Me.dgvFieldSelection.Name = "dgvFieldSelection"
        Me.dgvFieldSelection.Size = New System.Drawing.Size(470, 578)
        Me.dgvFieldSelection.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClear.Location = New System.Drawing.Point(6, 39)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dataset Name:"
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
        Me.stsQueryBuilder.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsQueryBuilderLabel1, Me.stsQueryBuilderLabel2})
        Me.stsQueryBuilder.Location = New System.Drawing.Point(0, 677)
        Me.stsQueryBuilder.Name = "stsQueryBuilder"
        Me.stsQueryBuilder.Size = New System.Drawing.Size(1316, 22)
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
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Data Elements to be displayed:"
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
        Me.lblMessage.Location = New System.Drawing.Point(564, 405)
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
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(13, 651)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 23)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtINvalues)
        Me.GroupBox3.Controls.Add(Me.rbOR)
        Me.GroupBox3.Controls.Add(Me.lstConditions)
        Me.GroupBox3.Controls.Add(Me.cbIgnoreCase)
        Me.GroupBox3.Controls.Add(Me.rbAND)
        Me.GroupBox3.Controls.Add(Me.dtp2)
        Me.GroupBox3.Controls.Add(Me.lblFilterRecords)
        Me.GroupBox3.Controls.Add(Me.lblValue2)
        Me.GroupBox3.Controls.Add(Me.btnAddCondition)
        Me.GroupBox3.Controls.Add(Me.btnRemoveCondition)
        Me.GroupBox3.Controls.Add(Me.dtp1)
        Me.GroupBox3.Controls.Add(Me.cboWhereFields)
        Me.GroupBox3.Controls.Add(Me.txtOperator)
        Me.GroupBox3.Controls.Add(Me.txtValue2)
        Me.GroupBox3.Controls.Add(Me.cboOperators)
        Me.GroupBox3.Controls.Add(Me.lblOperator)
        Me.GroupBox3.Controls.Add(Me.lblColumn)
        Me.GroupBox3.Controls.Add(Me.txtValue)
        Me.GroupBox3.Controls.Add(Me.lblValue)
        Me.GroupBox3.Location = New System.Drawing.Point(489, 383)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(773, 267)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
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
        Me.cbIgnoreCase.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.btnAddCondition.Location = New System.Drawing.Point(483, 109)
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
        Me.Label7.Location = New System.Drawing.Point(264, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Rows"
        '
        'txtFirstRows
        '
        Me.txtFirstRows.Location = New System.Drawing.Point(181, 130)
        Me.txtFirstRows.Name = "txtFirstRows"
        Me.txtFirstRows.Size = New System.Drawing.Size(70, 20)
        Me.txtFirstRows.TabIndex = 26
        Me.txtFirstRows.Text = "0"
        Me.txtFirstRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(100, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Return First"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.btnIncludeCount)
        Me.GroupBox4.Controls.Add(Me.lblDataElementsLabel)
        Me.GroupBox4.Controls.Add(Me.lstFields)
        Me.GroupBox4.Controls.Add(Me.btnMoveSelectFieldsUP)
        Me.GroupBox4.Controls.Add(Me.btnMoveSelectFieldsDOWN)
        Me.GroupBox4.Controls.Add(Me.btnSelectFields)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.btnRemoveSelectedFields)
        Me.GroupBox4.Location = New System.Drawing.Point(489, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(426, 180)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
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
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.cbAudioClick)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.chklstOrderBY)
        Me.GroupBox5.Controls.Add(Me.btnMoveOrderByFieldsUp)
        Me.GroupBox5.Controls.Add(Me.btnMoveOrderByFieldsDown)
        Me.GroupBox5.Controls.Add(Me.btnSelectOrderBy)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.btnRemoveOrderByFields)
        Me.GroupBox5.Location = New System.Drawing.Point(489, 198)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(426, 180)
        Me.GroupBox5.TabIndex = 25
        Me.GroupBox5.TabStop = False
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
        Me.btnRefresh.Location = New System.Drawing.Point(104, 39)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 23)
        Me.btnRefresh.TabIndex = 26
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnHideColumns
        '
        Me.btnHideColumns.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnHideColumns.Location = New System.Drawing.Point(215, 39)
        Me.btnHideColumns.Name = "btnHideColumns"
        Me.btnHideColumns.Size = New System.Drawing.Size(19, 23)
        Me.btnHideColumns.TabIndex = 27
        Me.btnHideColumns.Text = "+"
        Me.btnHideColumns.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnRunSQLQuery)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnSaveQuery)
        Me.GroupBox1.Controls.Add(Me.txtFirstRows)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnShowSQLQuery)
        Me.GroupBox1.Controls.Add(Me.btnLoadQuery)
        Me.GroupBox1.Location = New System.Drawing.Point(931, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 210)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'btnRunSQLQuery
        '
        Me.btnRunSQLQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRunSQLQuery.Location = New System.Drawing.Point(14, 94)
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
        Me.btnSaveQuery.Location = New System.Drawing.Point(14, 64)
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
        Me.Label9.Location = New System.Drawing.Point(2, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Execution and Save Options"
        '
        'btnShowSQLQuery
        '
        Me.btnShowSQLQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowSQLQuery.Location = New System.Drawing.Point(14, 172)
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
        Me.btnLoadQuery.Location = New System.Drawing.Point(14, 34)
        Me.btnLoadQuery.MinimumSize = New System.Drawing.Size(140, 0)
        Me.btnLoadQuery.Name = "btnLoadQuery"
        Me.btnLoadQuery.Size = New System.Drawing.Size(140, 23)
        Me.btnLoadQuery.TabIndex = 5
        Me.btnLoadQuery.Text = "Load Query"
        Me.btnLoadQuery.UseVisualStyleBackColor = True
        '
        'ColumnSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1316, 699)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHideColumns)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.stsQueryBuilder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDatasetName)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTablename)
        Me.Controls.Add(Me.dgvFieldSelection)
        Me.MinimumSize = New System.Drawing.Size(580, 515)
        Me.Name = "ColumnSelect"
        Me.Text = "SQL Builder"
        CType(Me.dgvFieldSelection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stsQueryBuilder.ResumeLayout(False)
        Me.stsQueryBuilder.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTablename As TextBox
    Friend WithEvents dgvFieldSelection As DataGridView
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDatasetName As TextBox
    Friend WithEvents lstFields As ListBox
    Friend WithEvents btnMoveSelectFieldsUP As Button
    Friend WithEvents btnMoveSelectFieldsDOWN As Button
    Friend WithEvents btnSelectFields As Button
    Friend WithEvents stsQueryBuilder As StatusStrip
    Friend WithEvents Label2 As Label
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
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lstConditions As ListBox
    Friend WithEvents rbOR As RadioButton
    Friend WithEvents rbAND As RadioButton
    Friend WithEvents btnAddCondition As Button
    Friend WithEvents btnRemoveCondition As Button
    Friend WithEvents cboWhereFields As ComboBox
    Friend WithEvents txtOperator As TextBox
    Friend WithEvents cbIgnoreCase As CheckBox
    Friend WithEvents lblValue2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRunSQLQuery As Button
    Friend WithEvents btnSaveQuery As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnShowSQLQuery As Button
    Friend WithEvents btnLoadQuery As Button
End Class
