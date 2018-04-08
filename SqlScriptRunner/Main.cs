using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlScriptRunner
{
    public partial class Main : Form
    {
        const string statusFormat = "Status: {0}";
        StringBuilder outputLog = new StringBuilder();
        StringBuilder messageLog = new StringBuilder();
        int errors = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            fbdFolderBrowserDialog.SelectedPath = Application.StartupPath;

            if (fbdFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = fbdFolderBrowserDialog.SelectedPath;
                lvFilesToRun.Items.Clear();
                lblPercComplete.Visible = false;
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = "Status: ";
                LoadFiles();
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (txtConnString.Text != "")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(txtConnString.Text);
                    conn.Open();

                    lblStatus.Text = string.Format(statusFormat, "Connection Successful");

                    conn.Close();
                }
                catch (Exception ex)
                {
                    lblStatus.Text = string.Format(statusFormat, ex.Message);
                }
            }
            else
            {
                lblStatus.Text = string.Format(statusFormat, "No connection string specified");
            }
        }

        private void LoadFiles()
        {
            lblStatus.Text = string.Format(statusFormat, "Loading Files...");

            Task.Run(() =>
            {
                DirectoryInfo di = new DirectoryInfo(txtFolderPath.Text);
                FileInfo[] files = di.GetFiles("*.sql", SearchOption.AllDirectories);

                int itemCount = 0;
                foreach (FileInfo file in files)
                {
                    if (!file.Name.ToLowerInvariant().EndsWith(".sql"))
                        continue;

                    itemCount++;
                    string directory = file.Directory.Name;

                    ListViewItem item1 = new ListViewItem(directory);
                    item1.SubItems.Add(file.Name);
                    item1.SubItems.Add(file.FullName);

                    lvFilesToRun.BeginInvoke(new Action(() =>
                    {
                        lvFilesToRun.Items.Add(item1);
                        lblStatus.Text = string.Format(statusFormat, "Loaded file: " + itemCount);
                    }));
                }
                this.BeginInvoke(new Action(() =>
                {
                    lblStatus.Text = string.Format(statusFormat, "Files Loaded");
                }));
            });
        }

        private void btnRunScripts_Click(object sender, EventArgs e)
        {
            lblStatus.Text = string.Format(statusFormat, "Running scripts on database...");
            outputLog = new StringBuilder();
            messageLog = new StringBuilder();
            errors = 0;
            lblPercComplete.Visible = true;
            lblStatus.ForeColor = Color.Black;

            List<string> files = new List<string>();
            foreach (ListViewItem file in lvFilesToRun.Items)
            {
                string filePath = file.SubItems[2].Text;

                files.Add(filePath);
            }

            Task.Run(() =>
            {
                int index = 0;
                foreach (string file in files)
                {
                    index++;

                    if (File.Exists(file))
                    {
                        string sqlData = File.ReadAllText(file);

                        //Run Sql againast database
                        try
                        {
                            this.BeginInvoke(new Action(() =>
                            {
                                lblStatus.Text = string.Format(statusFormat, "Running script: " + file);

                                lblPercComplete.Text = (((decimal)index / (decimal)files.Count) * 100).ToString("#.00") + "%";
                            }));

                            using (SqlConnection sqlConnection = new SqlConnection(txtConnString.Text))
                            {
                                ServerConnection svrConnection = new ServerConnection(sqlConnection);
                                Server server = new Server(svrConnection);

                                server.ConnectionContext.InfoMessage += ConnectionContext_InfoMessage;

                                server.ConnectionContext.ExecuteNonQuery(sqlData);
                            }
                        }
                        catch (Exception ex)
                        {
                            errors++;
                            outputLog.Append("Error in file: " + file + Environment.NewLine);
                            outputLog.Append(ex.Message.ToString() + Environment.NewLine);
                            outputLog.Append("----------------------------------------------------------------------------------------------------------" + Environment.NewLine);

                            messageLog.Append("Error in file: " + file + Environment.NewLine);
                            messageLog.Append(ex.ToString() + Environment.NewLine);
                        }
                    }
                    else
                    {
                        this.BeginInvoke(new Action(() =>
                        {
                            lblStatus.Text = string.Format(statusFormat, "File does not exists: " + file);
                        }));
                        break;
                    }
                }

                this.BeginInvoke(new Action(() =>
                {
                    if(errors == 0)
                    {
                        lblStatus.Text = string.Format(statusFormat, "Completed Successfully");
                    }
                    else
                    {
                        lblStatus.Text = string.Format(statusFormat, errors + " Errors, click here to see log");
                        lblStatus.ForeColor = Color.Red;
                    }
                }));
            });
        }

        private void ConnectionContext_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            if (e.Message.Contains("ERROR"))
            {
                errors++;
                outputLog.Append(e.Message + Environment.NewLine);
                outputLog.Append("----------------------------------------------------------------------------------------------------------" + Environment.NewLine);
            }

            messageLog.Append(e.Message + Environment.NewLine);
            messageLog.Append("----------------------------------------------------------------------------------------------------------" + Environment.NewLine);
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            ErrorLog frmErr = new ErrorLog();
            frmErr.Text = "Error Log";
            frmErr.ErrorMessage = outputLog.ToString();
            frmErr.ShowDialog();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            sfdSaveFileDialog.FileName = "Message Log";
            if (sfdSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfdSaveFileDialog.FileName, messageLog.ToString());
                MessageBox.Show("Message log exported");
            }
        }
    }
}
