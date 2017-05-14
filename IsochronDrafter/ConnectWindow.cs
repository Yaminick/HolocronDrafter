using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IsochronDrafter
{
    public partial class ConnectWindow : Form
    {
        public ConnectWindow()
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            InitializeComponent();
            MaximizeBox = false;
            txtServerAddress.Text = isochron.Default.HostName;
            txtUserAlias.Text = isochron.Default.Alias;
            if (txtServerAddress.Text.Length > 0)
                ActiveControl = txtUserAlias;
        }

        // Connect.
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtServerAddress.Text.Length == 0)
                MessageBox.Show("You must enter a server.");
            else if (txtUserAlias.Text.Length == 0)
                MessageBox.Show("You must enter an alias.");
            else if (txtUserAlias.Text.Length > 16)
                MessageBox.Show("Please use an alias with sixteen or fewer characters.");
            else if (txtUserAlias.Text.Contains('|') || txtUserAlias.Text.Contains(';'))
                MessageBox.Show("Your alias contains disallowed characters.");
            else
            {
                isochron.Default.HostName = txtServerAddress.Text;
                isochron.Default.Alias = txtUserAlias.Text;
                isochron.Default.Save();
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        // Start Server.
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            ServerWindow serverWindow = new ServerWindow();
            DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.Hide();
            Owner.Owner = serverWindow;
            serverWindow.Show();
        }

        public string GetHostname()
        {
            return txtServerAddress.Text;
        }

        public string GetAlias()
        {
            return txtUserAlias.Text;
        }
    }
}
