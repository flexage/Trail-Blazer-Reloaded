namespace TrailBlazerReloaded
{
    partial class Browser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.olvMovies = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.btnFetchAll = new System.Windows.Forms.Button();
            this.btnRefreshCollection = new System.Windows.Forms.Button();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apiTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.olvMovies)).BeginInit();
            this.actionsPanel.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // olvMovies
            // 
            this.olvMovies.AllColumns.Add(this.olvColumn1);
            this.olvMovies.AllColumns.Add(this.olvColumn2);
            this.olvMovies.AllColumns.Add(this.olvColumn3);
            this.olvMovies.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.olvMovies.BackColor = System.Drawing.SystemColors.Window;
            this.olvMovies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.olvMovies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3});
            this.olvMovies.Dock = System.Windows.Forms.DockStyle.Left;
            this.olvMovies.EmptyListMsg = "There are currently no movies to display. Please define your collections in the a" +
                "pplication settings.";
            this.olvMovies.EmptyListMsgFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvMovies.GridLines = true;
            this.olvMovies.Location = new System.Drawing.Point(0, 25);
            this.olvMovies.MultiSelect = false;
            this.olvMovies.Name = "olvMovies";
            this.olvMovies.ShowCommandMenuOnRightClick = true;
            this.olvMovies.ShowItemCountOnGroups = true;
            this.olvMovies.Size = new System.Drawing.Size(300, 537);
            this.olvMovies.TabIndex = 0;
            this.olvMovies.TintSortColumn = true;
            this.olvMovies.UseAlternatingBackColors = true;
            this.olvMovies.UseCompatibleStateImageBehavior = false;
            this.olvMovies.UseExplorerTheme = true;
            this.olvMovies.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Title";
            this.olvColumn1.FillsFreeSpace = true;
            this.olvColumn1.Text = "Title";
            this.olvColumn1.UseInitialLetterForGroup = true;
            this.olvColumn1.Width = 150;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Year";
            this.olvColumn2.MaximumWidth = 38;
            this.olvColumn2.MinimumWidth = 38;
            this.olvColumn2.Text = "Year";
            this.olvColumn2.Width = 38;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "TrailerExists";
            this.olvColumn3.MaximumWidth = 46;
            this.olvColumn3.MinimumWidth = 46;
            this.olvColumn3.Text = "Trailer";
            this.olvColumn3.Width = 46;
            // 
            // actionsPanel
            // 
            this.actionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.actionsPanel.Controls.Add(this.btnFetchAll);
            this.actionsPanel.Controls.Add(this.btnRefreshCollection);
            this.actionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionsPanel.Location = new System.Drawing.Point(300, 25);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Size = new System.Drawing.Size(484, 80);
            this.actionsPanel.TabIndex = 1;
            // 
            // btnFetchAll
            // 
            this.btnFetchAll.Location = new System.Drawing.Point(117, 10);
            this.btnFetchAll.Name = "btnFetchAll";
            this.btnFetchAll.Size = new System.Drawing.Size(100, 60);
            this.btnFetchAll.TabIndex = 1;
            this.btnFetchAll.Text = "Fetch All";
            this.btnFetchAll.UseVisualStyleBackColor = true;
            this.btnFetchAll.Click += new System.EventHandler(this.btnFetchAll_Click);
            // 
            // btnRefreshCollection
            // 
            this.btnRefreshCollection.Location = new System.Drawing.Point(10, 10);
            this.btnRefreshCollection.Name = "btnRefreshCollection";
            this.btnRefreshCollection.Size = new System.Drawing.Size(100, 60);
            this.btnRefreshCollection.TabIndex = 0;
            this.btnRefreshCollection.Text = "Refresh Collection";
            this.btnRefreshCollection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefreshCollection.UseVisualStyleBackColor = true;
            this.btnRefreshCollection.Click += new System.EventHandler(this.btnRefreshCollection_Click);
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(784, 25);
            this.menuMain.TabIndex = 2;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.configToolStripMenuItem.Text = "Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // onlineHelpToolStripMenuItem
            // 
            this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
            this.onlineHelpToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.onlineHelpToolStripMenuItem.Text = "Online Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // apiTextBox
            // 
            this.apiTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.apiTextBox.Location = new System.Drawing.Point(300, 381);
            this.apiTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.apiTextBox.Multiline = true;
            this.apiTextBox.Name = "apiTextBox";
            this.apiTextBox.ReadOnly = true;
            this.apiTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.apiTextBox.Size = new System.Drawing.Size(484, 181);
            this.apiTextBox.TabIndex = 3;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrailBlazerReloaded.Properties.Resources.bgMain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.apiTextBox);
            this.Controls.Add(this.actionsPanel);
            this.Controls.Add(this.olvMovies);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "Browser";
            this.Text = "TrailBlazer Reloaded";
            this.Shown += new System.EventHandler(this.Browser_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.olvMovies)).EndInit();
            this.actionsPanel.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvMovies;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.Button btnRefreshCollection;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox apiTextBox;
        private System.Windows.Forms.Button btnFetchAll;
    }
}

