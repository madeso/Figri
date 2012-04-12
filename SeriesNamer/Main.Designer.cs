namespace SeriesNamer
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.dContextAddFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookUpInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributeToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.moveFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dAddFile = new System.Windows.Forms.Button();
            this.dAddFolder = new System.Windows.Forms.Button();
            this.dFolderBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.dFileBrowse = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.dFileObjects = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnPath = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnSeries = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnSeason = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnEpisode = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTitle = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.dContextAddFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dFileObjects)).BeginInit();
            this.SuspendLayout();
            // 
            // dContextAddFiles
            // 
            this.dContextAddFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tagToolStripMenuItem,
            this.lookUpInfoToolStripMenuItem,
            this.attributeToolsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.moveFilesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.removeSelectedToolStripMenuItem});
            this.dContextAddFiles.Name = "dContextAddFiles";
            this.dContextAddFiles.Size = new System.Drawing.Size(182, 148);
            // 
            // tagToolStripMenuItem
            // 
            this.tagToolStripMenuItem.Name = "tagToolStripMenuItem";
            this.tagToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.tagToolStripMenuItem.Text = "From filename...";
            this.tagToolStripMenuItem.Click += new System.EventHandler(this.tagToolStripMenuItem_Click);
            // 
            // lookUpInfoToolStripMenuItem
            // 
            this.lookUpInfoToolStripMenuItem.Name = "lookUpInfoToolStripMenuItem";
            this.lookUpInfoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.lookUpInfoToolStripMenuItem.Text = "Look up info...";
            this.lookUpInfoToolStripMenuItem.Click += new System.EventHandler(this.lookUpInfoToolStripMenuItem_Click);
            // 
            // attributeToolsToolStripMenuItem
            // 
            this.attributeToolsToolStripMenuItem.Name = "attributeToolsToolStripMenuItem";
            this.attributeToolsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.attributeToolsToolStripMenuItem.Text = "Attribute tools...";
            this.attributeToolsToolStripMenuItem.Click += new System.EventHandler(this.attributeToolsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // moveFilesToolStripMenuItem
            // 
            this.moveFilesToolStripMenuItem.Name = "moveFilesToolStripMenuItem";
            this.moveFilesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.moveFilesToolStripMenuItem.Text = "Move files";
            this.moveFilesToolStripMenuItem.Click += new System.EventHandler(this.moveFilesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(178, 6);
            // 
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.removeSelectedToolStripMenuItem.Text = "Remove selected";
            this.removeSelectedToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedToolStripMenuItem_Click);
            // 
            // dAddFile
            // 
            this.dAddFile.Location = new System.Drawing.Point(44, 12);
            this.dAddFile.Name = "dAddFile";
            this.dAddFile.Size = new System.Drawing.Size(75, 23);
            this.dAddFile.TabIndex = 1;
            this.dAddFile.Text = "File...";
            this.dAddFile.UseVisualStyleBackColor = true;
            this.dAddFile.Click += new System.EventHandler(this.dAddFile_Click);
            // 
            // dAddFolder
            // 
            this.dAddFolder.Location = new System.Drawing.Point(125, 12);
            this.dAddFolder.Name = "dAddFolder";
            this.dAddFolder.Size = new System.Drawing.Size(75, 23);
            this.dAddFolder.TabIndex = 0;
            this.dAddFolder.Text = "Folder...";
            this.dAddFolder.UseVisualStyleBackColor = true;
            this.dAddFolder.Click += new System.EventHandler(this.dAddFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add";
            // 
            // dFileObjects
            // 
            this.dFileObjects.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.dFileObjects.AllColumns.Add(this.olvColumnPath);
            this.dFileObjects.AllColumns.Add(this.olvColumnSeries);
            this.dFileObjects.AllColumns.Add(this.olvColumnSeason);
            this.dFileObjects.AllColumns.Add(this.olvColumnEpisode);
            this.dFileObjects.AllColumns.Add(this.olvColumnTitle);
            this.dFileObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dFileObjects.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.dFileObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnPath,
            this.olvColumnSeries,
            this.olvColumnSeason,
            this.olvColumnEpisode,
            this.olvColumnTitle});
            this.dFileObjects.ContextMenuStrip = this.dContextAddFiles;
            this.dFileObjects.FullRowSelect = true;
            this.dFileObjects.GridLines = true;
            this.dFileObjects.HideSelection = false;
            this.dFileObjects.LabelEdit = true;
            this.dFileObjects.LabelWrap = false;
            this.dFileObjects.Location = new System.Drawing.Point(12, 41);
            this.dFileObjects.Name = "dFileObjects";
            this.dFileObjects.Size = new System.Drawing.Size(527, 212);
            this.dFileObjects.TabIndex = 4;
            this.dFileObjects.UseCompatibleStateImageBehavior = false;
            this.dFileObjects.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnPath
            // 
            this.olvColumnPath.AspectName = "FilePath";
            this.olvColumnPath.Groupable = false;
            this.olvColumnPath.IsEditable = false;
            this.olvColumnPath.Text = "Path";
            this.olvColumnPath.Width = 124;
            // 
            // olvColumnSeries
            // 
            this.olvColumnSeries.AspectName = "Series";
            this.olvColumnSeries.Text = "Series";
            this.olvColumnSeries.Width = 85;
            // 
            // olvColumnSeason
            // 
            this.olvColumnSeason.AspectName = "Season";
            this.olvColumnSeason.Text = "Season";
            this.olvColumnSeason.Width = 91;
            // 
            // olvColumnEpisode
            // 
            this.olvColumnEpisode.AspectName = "Episode";
            this.olvColumnEpisode.Text = "Episode";
            // 
            // olvColumnTitle
            // 
            this.olvColumnTitle.AspectName = "Title";
            this.olvColumnTitle.Text = "Title";
            this.olvColumnTitle.Width = 149;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 265);
            this.Controls.Add(this.dFileObjects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dAddFile);
            this.Controls.Add(this.dAddFolder);
            this.DoubleBuffered = true;
            this.Name = "Main";
            this.Text = "TV Series Renamer";
            this.dContextAddFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dFileObjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dAddFile;
        private System.Windows.Forms.Button dAddFolder;
        private System.Windows.Forms.FolderBrowserDialog dFolderBrowse;
        private System.Windows.Forms.OpenFileDialog dFileBrowse;
        private System.Windows.Forms.ContextMenuStrip dContextAddFiles;
        private System.Windows.Forms.ToolStripMenuItem tagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookUpInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attributeToolsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem moveFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem;
        private BrightIdeasSoftware.ObjectListView dFileObjects;
        private BrightIdeasSoftware.OLVColumn olvColumnPath;
        private BrightIdeasSoftware.OLVColumn olvColumnSeries;
        private BrightIdeasSoftware.OLVColumn olvColumnSeason;
        private BrightIdeasSoftware.OLVColumn olvColumnEpisode;
        private BrightIdeasSoftware.OLVColumn olvColumnTitle;

    }
}

