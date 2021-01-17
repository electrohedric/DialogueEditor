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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.TreeView.Location = new System.Drawing.Point(0, 24);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(390, 743);
            this.TreeView.TabIndex = 0;
            this.TreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DialogueTable.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CharacterSelect.DefaultCellStyle = dataGridViewCellStyle1;
            this.CharacterSelect.HeaderText = "Character";
            this.CharacterSelect.MinimumWidth = 100;
            this.CharacterSelect.Name = "CharacterSelect";
            this.CharacterSelect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ConvDialogue
            // 
            this.ConvDialogue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ConvDialogue.DefaultCellStyle = dataGridViewCellStyle2;
            this.ConvDialogue.HeaderText = "Dialogue";
            this.ConvDialogue.MinimumWidth = 80;
            this.ConvDialogue.Name = "ConvDialogue";
            this.ConvDialogue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ConvDialogue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DeleteConvoRowButton
            // 
            this.DeleteConvoRowButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteConvoRowButton.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ChoiceTable.DefaultCellStyle = dataGridViewCellStyle8;
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
            this.ChoiceTable.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChoiceTable_CellLeave);
            this.ChoiceTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChoiceTable_CellValueChanged);
            this.ChoiceTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ChoiceTable_RowsAdded);
            // 
            // ChooseButton
            // 
            this.ChooseButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseButton.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ChoiceDialogue.DefaultCellStyle = dataGridViewCellStyle6;
            this.ChoiceDialogue.HeaderText = "Dialogue";
            this.ChoiceDialogue.Name = "ChoiceDialogue";
            this.ChoiceDialogue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ChoiceDialogue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DeleteChoiceRowButton
            // 
            this.DeleteChoiceRowButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteChoiceRowButton.DefaultCellStyle = dataGridViewCellStyle7;
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
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
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
            // DialogueCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1107, 767);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.splitContainer1);
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
    }
}

