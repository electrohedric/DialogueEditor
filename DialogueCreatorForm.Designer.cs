namespace DialogueCreator {
    partial class DialogueCreatorForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TreeView = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.DialogueTable = new System.Windows.Forms.DataGridView();
            this.CharacterSelect = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ConvDialogue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteConvoRowButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ChoiceTable = new System.Windows.Forms.DataGridView();
            this.ChooseButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ChoiceDialogue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteChoiceRowButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ChoiceList = new System.Windows.Forms.ListBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.beginNewConvoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeItemContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findReferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteChoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChoiceContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.jumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeJumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WinTooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DialogueTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceTable)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.TreeContextMenuStrip.SuspendLayout();
            this.TreeItemContextMenuStrip.SuspendLayout();
            this.ChoiceContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TreeView);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1107, 767);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.TabIndex = 0;
            // 
            // TreeView
            // 
            this.TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeView.HideSelection = false;
            this.TreeView.Location = new System.Drawing.Point(0, 24);
            this.TreeView.Name = "TreeView";
            this.TreeView.PathSeparator = "/";
            this.TreeView.Size = new System.Drawing.Size(390, 743);
            this.TreeView.TabIndex = 0;
            this.TreeView.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.TreeView_NodeMouseHover);
            this.TreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            this.TreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseDoubleClick);
            this.TreeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseUp);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.DialogueTable);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ChoiceTable);
            this.splitContainer2.Panel2.Controls.Add(this.ChoiceList);
            this.splitContainer2.Size = new System.Drawing.Size(713, 767);
            this.splitContainer2.SplitterDistance = 473;
            this.splitContainer2.TabIndex = 0;
            // 
            // DialogueTable
            // 
            this.DialogueTable.AllowUserToResizeColumns = false;
            this.DialogueTable.AllowUserToResizeRows = false;
            this.DialogueTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DialogueTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DialogueTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CharacterSelect,
            this.ConvDialogue,
            this.DeleteConvoRowButton});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DialogueTable.DefaultCellStyle = dataGridViewCellStyle12;
            this.DialogueTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DialogueTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DialogueTable.Location = new System.Drawing.Point(0, 24);
            this.DialogueTable.MultiSelect = false;
            this.DialogueTable.Name = "DialogueTable";
            this.DialogueTable.RowHeadersVisible = false;
            this.DialogueTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DialogueTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DialogueTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DialogueTable.ShowRowErrors = false;
            this.DialogueTable.Size = new System.Drawing.Size(713, 449);
            this.DialogueTable.TabIndex = 1;
            this.DialogueTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DialogueTable_CellContentClick);
            this.DialogueTable.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellEnter);
            this.DialogueTable.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.DialogueTable_CellLeave);
            this.DialogueTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DialogueTable_CellValueChanged);
            this.DialogueTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DialogueTable_RowsAdded);
            // 
            // CharacterSelect
            // 
            this.CharacterSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CharacterSelect.DefaultCellStyle = dataGridViewCellStyle9;
            this.CharacterSelect.HeaderText = "Character";
            this.CharacterSelect.MinimumWidth = 100;
            this.CharacterSelect.Name = "CharacterSelect";
            this.CharacterSelect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ConvDialogue
            // 
            this.ConvDialogue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ConvDialogue.DefaultCellStyle = dataGridViewCellStyle10;
            this.ConvDialogue.HeaderText = "Dialogue";
            this.ConvDialogue.MinimumWidth = 80;
            this.ConvDialogue.Name = "ConvDialogue";
            this.ConvDialogue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ConvDialogue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DeleteConvoRowButton
            // 
            this.DeleteConvoRowButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteConvoRowButton.DefaultCellStyle = dataGridViewCellStyle11;
            this.DeleteConvoRowButton.HeaderText = "X";
            this.DeleteConvoRowButton.MinimumWidth = 25;
            this.DeleteConvoRowButton.Name = "DeleteConvoRowButton";
            this.DeleteConvoRowButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteConvoRowButton.Text = "X";
            this.DeleteConvoRowButton.ToolTipText = "Delete Row";
            this.DeleteConvoRowButton.UseColumnTextForButtonValue = true;
            this.DeleteConvoRowButton.Width = 25;
            // 
            // ChoiceTable
            // 
            this.ChoiceTable.AllowUserToResizeColumns = false;
            this.ChoiceTable.AllowUserToResizeRows = false;
            this.ChoiceTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ChoiceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChoiceTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChooseButton,
            this.ChoiceDialogue,
            this.DeleteChoiceRowButton});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ChoiceTable.DefaultCellStyle = dataGridViewCellStyle16;
            this.ChoiceTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChoiceTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ChoiceTable.Location = new System.Drawing.Point(0, 0);
            this.ChoiceTable.MultiSelect = false;
            this.ChoiceTable.Name = "ChoiceTable";
            this.ChoiceTable.RowHeadersVisible = false;
            this.ChoiceTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ChoiceTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChoiceTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ChoiceTable.ShowRowErrors = false;
            this.ChoiceTable.Size = new System.Drawing.Size(713, 290);
            this.ChoiceTable.TabIndex = 1;
            this.ChoiceTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChoiceTable_CellContentClick);
            this.ChoiceTable.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellEnter);
            this.ChoiceTable.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ChoiceTable_CellMouseUp);
            this.ChoiceTable.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChoiceTable_CellLeave);
            this.ChoiceTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChoiceTable_CellValueChanged);
            this.ChoiceTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ChoiceTable_RowsAdded);
            // 
            // ChooseButton
            // 
            this.ChooseButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseButton.DefaultCellStyle = dataGridViewCellStyle13;
            this.ChooseButton.HeaderText = "Go";
            this.ChooseButton.MinimumWidth = 30;
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ChooseButton.Text = "Go";
            this.ChooseButton.UseColumnTextForButtonValue = true;
            this.ChooseButton.Width = 30;
            // 
            // ChoiceDialogue
            // 
            this.ChoiceDialogue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ChoiceDialogue.DefaultCellStyle = dataGridViewCellStyle14;
            this.ChoiceDialogue.HeaderText = "Dialogue";
            this.ChoiceDialogue.Name = "ChoiceDialogue";
            this.ChoiceDialogue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ChoiceDialogue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DeleteChoiceRowButton
            // 
            this.DeleteChoiceRowButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteChoiceRowButton.DefaultCellStyle = dataGridViewCellStyle15;
            this.DeleteChoiceRowButton.HeaderText = "X";
            this.DeleteChoiceRowButton.MinimumWidth = 25;
            this.DeleteChoiceRowButton.Name = "DeleteChoiceRowButton";
            this.DeleteChoiceRowButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteChoiceRowButton.Text = "X";
            this.DeleteChoiceRowButton.ToolTipText = "Delete row";
            this.DeleteChoiceRowButton.UseColumnTextForButtonValue = true;
            this.DeleteChoiceRowButton.Width = 25;
            // 
            // ChoiceList
            // 
            this.ChoiceList.CausesValidation = false;
            this.ChoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChoiceList.FormattingEnabled = true;
            this.ChoiceList.Location = new System.Drawing.Point(0, 0);
            this.ChoiceList.Name = "ChoiceList";
            this.ChoiceList.Size = new System.Drawing.Size(713, 290);
            this.ChoiceList.TabIndex = 0;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1107, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem,
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.charactersToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // charactersToolStripMenuItem
            // 
            this.charactersToolStripMenuItem.Name = "charactersToolStripMenuItem";
            this.charactersToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.charactersToolStripMenuItem.Text = "Characters";
            this.charactersToolStripMenuItem.Click += new System.EventHandler(this.CharactersToolStripMenuItem_Click);
            // 
            // TreeContextMenuStrip
            // 
            this.TreeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginNewConvoToolStripMenuItem});
            this.TreeContextMenuStrip.Name = "TreeContextMenuStrip";
            this.TreeContextMenuStrip.Size = new System.Drawing.Size(170, 26);
            // 
            // beginNewConvoToolStripMenuItem
            // 
            this.beginNewConvoToolStripMenuItem.Name = "beginNewConvoToolStripMenuItem";
            this.beginNewConvoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.beginNewConvoToolStripMenuItem.Text = "Begin New Convo";
            // 
            // TreeItemContextMenuStrip
            // 
            this.TreeItemContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expandAllToolStripMenuItem,
            this.contractAllToolStripMenuItem,
            this.findReferencesToolStripMenuItem,
            this.deleteChoiceToolStripMenuItem});
            this.TreeItemContextMenuStrip.Name = "TreeItemContextMenuStrip";
            this.TreeItemContextMenuStrip.Size = new System.Drawing.Size(158, 92);
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.expandAllToolStripMenuItem.Text = "Expand All";
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.ExpandAllToolStripMenuItem_Click);
            // 
            // contractAllToolStripMenuItem
            // 
            this.contractAllToolStripMenuItem.Name = "contractAllToolStripMenuItem";
            this.contractAllToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.contractAllToolStripMenuItem.Text = "Collapse All";
            this.contractAllToolStripMenuItem.Click += new System.EventHandler(this.CollapseAllToolStripMenuItem_Click);
            // 
            // findReferencesToolStripMenuItem
            // 
            this.findReferencesToolStripMenuItem.Name = "findReferencesToolStripMenuItem";
            this.findReferencesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.findReferencesToolStripMenuItem.Text = "Find References";
            this.findReferencesToolStripMenuItem.Click += new System.EventHandler(this.FindReferencesToolStripMenuItem_Click);
            // 
            // deleteChoiceToolStripMenuItem
            // 
            this.deleteChoiceToolStripMenuItem.Name = "deleteChoiceToolStripMenuItem";
            this.deleteChoiceToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deleteChoiceToolStripMenuItem.Text = "Delete Choice";
            this.deleteChoiceToolStripMenuItem.Click += new System.EventHandler(this.DeleteChoiceToolStripMenuItem_Click);
            // 
            // ChoiceContextMenuStrip
            // 
            this.ChoiceContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jumpToolStripMenuItem,
            this.removeJumpToolStripMenuItem});
            this.ChoiceContextMenuStrip.Name = "ChoiceContextMenuStrip";
            this.ChoiceContextMenuStrip.Size = new System.Drawing.Size(150, 48);
            // 
            // jumpToolStripMenuItem
            // 
            this.jumpToolStripMenuItem.Name = "jumpToolStripMenuItem";
            this.jumpToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.jumpToolStripMenuItem.Text = "Jump";
            this.jumpToolStripMenuItem.Click += new System.EventHandler(this.JumpToolStripMenuItem_Click);
            // 
            // removeJumpToolStripMenuItem
            // 
            this.removeJumpToolStripMenuItem.Name = "removeJumpToolStripMenuItem";
            this.removeJumpToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.removeJumpToolStripMenuItem.Text = "Remove Jump";
            this.removeJumpToolStripMenuItem.Click += new System.EventHandler(this.RemoveJumpToolStripMenuItem_Click);
            // 
            // DialogueCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1107, 767);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "DialogueCreatorForm";
            this.Text = "Dialogue Creator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DialogueTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiceTable)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.TreeContextMenuStrip.ResumeLayout(false);
            this.TreeItemContextMenuStrip.ResumeLayout(false);
            this.ChoiceContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView TreeView;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView DialogueTable;
        private System.Windows.Forms.DataGridViewComboBoxColumn CharacterSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConvDialogue;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteConvoRowButton;
        private System.Windows.Forms.DataGridView ChoiceTable;
        private System.Windows.Forms.DataGridViewButtonColumn ChooseButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChoiceDialogue;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteChoiceRowButton;
        private System.Windows.Forms.ListBox ChoiceList;
        private System.Windows.Forms.ContextMenuStrip TreeContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem beginNewConvoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip TreeItemContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteChoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractAllToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ChoiceContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem jumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeJumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findReferencesToolStripMenuItem;
        private System.Windows.Forms.ToolTip WinTooltip;
    }
}

