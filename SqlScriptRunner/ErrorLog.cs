using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlScriptRunner
{
    public partial class ErrorLog : Form
    {
        public string ErrorMessage
        {
            set {
                txtErrorLog.Text = value;
            }
        }

        public ErrorLog()
        {
            InitializeComponent();
        }

        private void ErrorLog_Load(object sender, EventArgs e)
        {

        }

        private void ErrorLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            ErrorMessage = "";
        }
    }
}
