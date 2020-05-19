namespace SqlScriptRunner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.lvFilesToRun = new System.Windows.Forms.ListView();
            this.chFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFullPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtScriptFolderPath = new System.Windows.Forms.TextBox();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.fbdFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRunScripts = new System.Windows.Forms.Button();
            this.lblPercComplete = new System.Windows.Forms.Label();
            this.btnExportLog = new System.Windows.Forms.Button();
            this.sfdSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ssStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnectionString.Location = new System.Drawing.Point(109, 15);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(708, 20);
            this.txtConnectionString.TabIndex = 1;
            this.txtConnectionString.Text = "server=(localdb)\\mssqllocaldb;database=[DBName];Integrated Security=true;";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestConnection.Location = new System.Drawing.Point(823, 13);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(75, 23);
            this.btnTestConnection.TabIndex = 2;
            this.btnTestConnection.Text = "Test";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // lvFilesToRun
            // 
            this.lvFilesToRun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFilesToRun.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFolder,
            this.chFileName,
            this.chFullPath});
            this.lvFilesToRun.FullRowSelect = true;
            this.lvFilesToRun.GridLines = true;
            this.lvFilesToRun.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvFilesToRun.Location = new System.Drawing.Point(15, 78);
            this.lvFilesToRun.MultiSelect = false;
            this.lvFilesToRun.Name = "lvFilesToRun";
            this.lvFilesToRun.Size = new System.Drawing.Size(802, 417);
            this.lvFilesToRun.TabIndex = 3;
            this.lvFilesToRun.UseCompatibleStateImageBehavior = false;
            this.lvFilesToRun.View = System.Windows.Forms.View.Details;
            // 
            // chFolder
            // 
            this.chFolder.Text = "Folder";
            this.chFolder.Width = 150;
            // 
            // chFileName
            // 
            this.chFileName.Text = "File Name";
            this.chFileName.Width = 200;
            // 
            // chFullPath
            // 
            this.chFullPath.Text = "Path";
            this.chFullPath.Width = 300;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Open Folder";
            // 
            // txtScriptFolderPath
            // 
            this.txtScriptFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScriptFolderPath.Location = new System.Drawing.Point(109, 41);
            this.txtScriptFolderPath.Name = "txtScriptFolderPath";
            this.txtScriptFolderPath.ReadOnly = true;
            this.txtScriptFolderPath.Size = new System.Drawing.Size(708, 20);
            this.txtScriptFolderPath.TabIndex = 5;
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseFolder.Location = new System.Drawing.Point(823, 39);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFolder.TabIndex = 6;
            this.btnBrowseFolder.Text = "Browse...";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // fbdFolderBrowserDialog
            // 
            this.fbdFolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // ssStatus
            // 
            this.ssStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 503);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(910, 30);
            this.ssStatus.TabIndex = 9;
            this.ssStatus.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(850, 25);
            this.lblStatus.Text = "Status: ";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // btnRunScripts
            // 
            this.btnRunScripts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunScripts.Location = new System.Drawing.Point(823, 78);
            this.btnRunScripts.Name = "btnRunScripts";
            this.btnRunScripts.Size = new System.Drawing.Size(75, 23);
            this.btnRunScripts.TabIndex = 10;
            this.btnRunScripts.Text = "Run";
            this.btnRunScripts.UseVisualStyleBackColor = true;
            this.btnRunScripts.Click += new System.EventHandler(this.btnRunScripts_Click);
            // 
            // lblPercComplete
            // 
            this.lblPercComplete.AutoSize = true;
            this.lblPercComplete.Location = new System.Drawing.Point(837, 116);
            this.lblPercComplete.Name = "lblPercComplete";
            this.lblPercComplete.Size = new System.Drawing.Size(21, 13);
            this.lblPercComplete.TabIndex = 11;
            this.lblPercComplete.Text = "0%";
            this.lblPercComplete.Visible = false;
            // 
            // btnExportLog
            // 
            this.btnExportLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportLog.Location = new System.Drawing.Point(823, 472);
            this.btnExportLog.Name = "btnExportLog";
            this.btnExportLog.Size = new System.Drawing.Size(75, 23);
            this.btnExportLog.TabIndex = 12;
            this.btnExportLog.Text = "Export Log";
            this.btnExportLog.UseVisualStyleBackColor = true;
            this.btnExportLog.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // sfdSaveFileDialog
            // 
            this.sfdSaveFileDialog.FileName = "Message Log";
            this.sfdSaveFileDialog.Filter = "Log Files|*.log";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 533);
            this.Controls.Add(this.btnExportLog);
            this.Controls.Add(this.lblPercComplete);
            this.Controls.Add(this.btnRunScripts);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.btnBrowseFolder);
            this.Controls.Add(this.txtScriptFolderPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvFilesToRun);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sql Script Runner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.ListView lvFilesToRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScriptFolderPath;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.ColumnHeader chFolder;
        private System.Windows.Forms.ColumnHeader chFileName;
        private System.Windows.Forms.FolderBrowserDialog fbdFolderBrowserDialog;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ColumnHeader chFullPath;
        private System.Windows.Forms.Button btnRunScripts;
        private System.Windows.Forms.Label lblPercComplete;
        private System.Windows.Forms.Button btnExportLog;
        private System.Windows.Forms.SaveFileDialog sfdSaveFileDialog;
    }
}

