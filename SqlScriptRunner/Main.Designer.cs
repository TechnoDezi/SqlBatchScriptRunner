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
            this.txtConnString = new System.Windows.Forms.TextBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.lvFilesToRun = new System.Windows.Forms.ListView();
            this.chFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFullPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String";
            // 
            // txtConnString
            // 
            this.txtConnString.Location = new System.Drawing.Point(145, 18);
            this.txtConnString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConnString.Name = "txtConnString";
            this.txtConnString.Size = new System.Drawing.Size(943, 22);
            this.txtConnString.TabIndex = 1;
            this.txtConnString.Text = "server=(localdb)\\mssqllocaldb;database=[DBName];Integrated Security=true;";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(1097, 16);
            this.btnTestConnection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(100, 28);
            this.btnTestConnection.TabIndex = 2;
            this.btnTestConnection.Text = "Test";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // lvFilesToRun
            // 
            this.lvFilesToRun.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFolder,
            this.chFileName,
            this.chFullPath});
            this.lvFilesToRun.FullRowSelect = true;
            this.lvFilesToRun.GridLines = true;
            this.lvFilesToRun.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvFilesToRun.Location = new System.Drawing.Point(20, 96);
            this.lvFilesToRun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvFilesToRun.MultiSelect = false;
            this.lvFilesToRun.Name = "lvFilesToRun";
            this.lvFilesToRun.Size = new System.Drawing.Size(1068, 512);
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
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Open Folder";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(145, 50);
            this.txtFolderPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new System.Drawing.Size(943, 22);
            this.txtFolderPath.TabIndex = 5;
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(1097, 48);
            this.btnBrowseFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(100, 28);
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
            this.ssStatus.Location = new System.Drawing.Point(0, 632);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ssStatus.Size = new System.Drawing.Size(1213, 24);
            this.ssStatus.TabIndex = 9;
            this.ssStatus.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(850, 19);
            this.lblStatus.Text = "Status: ";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // btnRunScripts
            // 
            this.btnRunScripts.Location = new System.Drawing.Point(1097, 96);
            this.btnRunScripts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRunScripts.Name = "btnRunScripts";
            this.btnRunScripts.Size = new System.Drawing.Size(100, 28);
            this.btnRunScripts.TabIndex = 10;
            this.btnRunScripts.Text = "Run";
            this.btnRunScripts.UseVisualStyleBackColor = true;
            this.btnRunScripts.Click += new System.EventHandler(this.btnRunScripts_Click);
            // 
            // lblPercComplete
            // 
            this.lblPercComplete.AutoSize = true;
            this.lblPercComplete.Location = new System.Drawing.Point(1116, 143);
            this.lblPercComplete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercComplete.Name = "lblPercComplete";
            this.lblPercComplete.Size = new System.Drawing.Size(28, 17);
            this.lblPercComplete.TabIndex = 11;
            this.lblPercComplete.Text = "0%";
            this.lblPercComplete.Visible = false;
            // 
            // btnExportLog
            // 
            this.btnExportLog.Location = new System.Drawing.Point(1097, 581);
            this.btnExportLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportLog.Name = "btnExportLog";
            this.btnExportLog.Size = new System.Drawing.Size(100, 28);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 656);
            this.Controls.Add(this.btnExportLog);
            this.Controls.Add(this.lblPercComplete);
            this.Controls.Add(this.btnRunScripts);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.btnBrowseFolder);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvFilesToRun);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.txtConnString);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sql Script Runner";
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnString;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.ListView lvFilesToRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFolderPath;
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

