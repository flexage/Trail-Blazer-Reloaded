namespace TrailBlazerReloaded
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listboxCollectionFolders = new System.Windows.Forms.ListBox();
            this.btnTop10Browse = new System.Windows.Forms.Button();
            this.txtTop10 = new System.Windows.Forms.TextBox();
            this.labelLatestTrailersFolder = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCollectionFolders = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.down_btn = new System.Windows.Forms.Button();
            this.Up_btn = new System.Windows.Forms.Button();
            this.checkedlistboxDefinitions = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.folderTop10 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MoveDownWebsite = new System.Windows.Forms.Button();
            this.MoveUpWebsite = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DefinitionDescription = new System.Windows.Forms.Label();
            this.ProviderDescription = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.listboxCollectionFolders);
            this.groupBox1.Controls.Add(this.btnTop10Browse);
            this.groupBox1.Controls.Add(this.txtTop10);
            this.groupBox1.Controls.Add(this.labelLatestTrailersFolder);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.labelCollectionFolders);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paths";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // listboxCollectionFolders
            // 
            this.listboxCollectionFolders.FormattingEnabled = true;
            this.listboxCollectionFolders.Location = new System.Drawing.Point(147, 20);
            this.listboxCollectionFolders.Name = "listboxCollectionFolders";
            this.listboxCollectionFolders.Size = new System.Drawing.Size(325, 56);
            this.listboxCollectionFolders.TabIndex = 6;
            // 
            // btnTop10Browse
            // 
            this.btnTop10Browse.Location = new System.Drawing.Point(488, 93);
            this.btnTop10Browse.Name = "btnTop10Browse";
            this.btnTop10Browse.Size = new System.Drawing.Size(75, 23);
            this.btnTop10Browse.TabIndex = 5;
            this.btnTop10Browse.Text = "Browse...";
            this.btnTop10Browse.UseVisualStyleBackColor = true;
            this.btnTop10Browse.Click += new System.EventHandler(this.BtnTop10BrowseClick);
            // 
            // txtTop10
            // 
            this.txtTop10.Location = new System.Drawing.Point(145, 93);
            this.txtTop10.Multiline = true;
            this.txtTop10.Name = "txtTop10";
            this.txtTop10.Size = new System.Drawing.Size(327, 23);
            this.txtTop10.TabIndex = 4;
            // 
            // labelLatestTrailersFolder
            // 
            this.labelLatestTrailersFolder.AutoSize = true;
            this.labelLatestTrailersFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatestTrailersFolder.Location = new System.Drawing.Point(8, 96);
            this.labelLatestTrailersFolder.Name = "labelLatestTrailersFolder";
            this.labelLatestTrailersFolder.Size = new System.Drawing.Size(131, 13);
            this.labelLatestTrailersFolder.TabIndex = 3;
            this.labelLatestTrailersFolder.Text = "Latest Trailers Folder:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // labelCollectionFolders
            // 
            this.labelCollectionFolders.AutoSize = true;
            this.labelCollectionFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCollectionFolders.Location = new System.Drawing.Point(27, 20);
            this.labelCollectionFolders.Name = "labelCollectionFolders";
            this.labelCollectionFolders.Size = new System.Drawing.Size(112, 13);
            this.labelCollectionFolders.TabIndex = 0;
            this.labelCollectionFolders.Text = "Collection Folders:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DefinitionDescription);
            this.groupBox2.Controls.Add(this.down_btn);
            this.groupBox2.Controls.Add(this.Up_btn);
            this.groupBox2.Controls.Add(this.checkedlistboxDefinitions);
            this.groupBox2.Location = new System.Drawing.Point(13, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 145);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trailer Definition Settings";
            // 
            // down_btn
            // 
            this.down_btn.Location = new System.Drawing.Point(159, 102);
            this.down_btn.Name = "down_btn";
            this.down_btn.Size = new System.Drawing.Size(79, 23);
            this.down_btn.TabIndex = 5;
            this.down_btn.Text = "Move Down";
            this.down_btn.UseVisualStyleBackColor = true;
            this.down_btn.Click += new System.EventHandler(this.DownBtnClick);
            // 
            // Up_btn
            // 
            this.Up_btn.Location = new System.Drawing.Point(158, 72);
            this.Up_btn.Name = "Up_btn";
            this.Up_btn.Size = new System.Drawing.Size(80, 23);
            this.Up_btn.TabIndex = 4;
            this.Up_btn.Text = "Move Up";
            this.Up_btn.UseVisualStyleBackColor = true;
            this.Up_btn.Click += new System.EventHandler(this.UpBtnClick);
            // 
            // checkedlistboxDefinitions
            // 
            this.checkedlistboxDefinitions.FormattingEnabled = true;
            this.checkedlistboxDefinitions.Location = new System.Drawing.Point(48, 66);
            this.checkedlistboxDefinitions.Name = "checkedlistboxDefinitions";
            this.checkedlistboxDefinitions.Size = new System.Drawing.Size(104, 64);
            this.checkedlistboxDefinitions.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(13, 66);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(170, 64);
            this.checkedListBox1.TabIndex = 3;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveConfig.Location = new System.Drawing.Point(502, 328);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(88, 36);
            this.btnSaveConfig.TabIndex = 1;
            this.btnSaveConfig.Text = "Save Config";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.BtnSaveConfigClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ProviderDescription);
            this.groupBox3.Controls.Add(this.MoveDownWebsite);
            this.groupBox3.Controls.Add(this.MoveUpWebsite);
            this.groupBox3.Controls.Add(this.checkedListBox1);
            this.groupBox3.Location = new System.Drawing.Point(310, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 145);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trailer Provider Settings";
            // 
            // MoveDownWebsite
            // 
            this.MoveDownWebsite.Location = new System.Drawing.Point(190, 102);
            this.MoveDownWebsite.Name = "MoveDownWebsite";
            this.MoveDownWebsite.Size = new System.Drawing.Size(79, 23);
            this.MoveDownWebsite.TabIndex = 7;
            this.MoveDownWebsite.Text = "Move Down";
            this.MoveDownWebsite.UseVisualStyleBackColor = true;
            this.MoveDownWebsite.Click += new System.EventHandler(this.MoveDownWebsite_Click);
            // 
            // MoveUpWebsite
            // 
            this.MoveUpWebsite.Location = new System.Drawing.Point(189, 72);
            this.MoveUpWebsite.Name = "MoveUpWebsite";
            this.MoveUpWebsite.Size = new System.Drawing.Size(80, 23);
            this.MoveUpWebsite.TabIndex = 6;
            this.MoveUpWebsite.Text = "Move Up";
            this.MoveUpWebsite.UseVisualStyleBackColor = true;
            this.MoveUpWebsite.Click += new System.EventHandler(this.MoveUpWebsite_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(399, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 36);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DefinitionDescription
            // 
            this.DefinitionDescription.Location = new System.Drawing.Point(7, 20);
            this.DefinitionDescription.Name = "DefinitionDescription";
            this.DefinitionDescription.Size = new System.Drawing.Size(277, 34);
            this.DefinitionDescription.TabIndex = 6;
            this.DefinitionDescription.Text = "Check the trailer definitions you would like to download. Use the arrows to set y" +
                "our preferred order.";
            this.DefinitionDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProviderDescription
            // 
            this.ProviderDescription.Location = new System.Drawing.Point(2, 20);
            this.ProviderDescription.Name = "ProviderDescription";
            this.ProviderDescription.Size = new System.Drawing.Size(277, 34);
            this.ProviderDescription.TabIndex = 8;
            this.ProviderDescription.Text = "Check the trailer definitions you would like to download. Use the arrows to set y" +
                "our preferred order.";
            this.ProviderDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 376);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trail Blazer Config";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCollectionFolders;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTop10Browse;
        private System.Windows.Forms.TextBox txtTop10;
        private System.Windows.Forms.Label labelLatestTrailersFolder;
        private System.Windows.Forms.FolderBrowserDialog folderTop10;
        private System.Windows.Forms.CheckedListBox checkedlistboxDefinitions;
        private System.Windows.Forms.ListBox listboxCollectionFolders;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button down_btn;
        private System.Windows.Forms.Button Up_btn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button MoveDownWebsite;
        private System.Windows.Forms.Button MoveUpWebsite;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label DefinitionDescription;
        private System.Windows.Forms.Label ProviderDescription;
    }
}