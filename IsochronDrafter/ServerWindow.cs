using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace IsochronDrafter
{
    public partial class ServerWindow : Form
    {
        private DraftServer server;

        public ServerWindow()
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            InitializeComponent();
            MaximizeBox = false;
            txtSetFilePath.Text = isochron.Default.SetFile;
            txtImageFolderPath.Text = isochron.Default.ImageDirectory;
            txtPacksCount.Text = isochron.Default.Packs;
            txtCommonsCount.Text = isochron.Default.CommonsPerPack;
            txtUncommonsCount.Text = isochron.Default.UncommonPerPack;
            txtRaresCount.Text = isochron.Default.RaresPerPack;
            txtMythicsPercent.Text = isochron.Default.MythicPercentage;
        }

        public void PrintLine(string text)
        {
            txtServerLog.Invoke(new MethodInvoker(delegate
            {
                if (txtServerLog.Text.Length != 0)
                    txtServerLog.Text += "\r\n";
                txtServerLog.Text += text;
                txtServerLog.SelectionStart = txtServerLog.Text.Length;
                txtServerLog.ScrollToCaret();
            }));
        }
        public void DraftButtonEnabled(bool enabled)
        {
            btnStartDraft.Invoke(new MethodInvoker(delegate
            {
                btnStartDraft.Enabled = enabled;
            }));
        }

        //Browse click event
        private void btnSetFileBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtSetFilePath.Text = openFileDialog1.FileName;
            }
        }

        //Launch click event
        private void btnLaunchServer_Click(object sender, EventArgs e)
        {
            if (txtSetFilePath.Text.Length == 0)
            {
                MessageBox.Show("You must choose a set file.");
                return;
            }
            if (txtImageFolderPath.Text.Length == 0)
            {
                MessageBox.Show("You must enter a remote image directory.");
                return;
            }
            int packs, commons, uncommons, rares;
            float mythicPercentage;
            if (!int.TryParse(txtPacksCount.Text, out packs) || packs < 0)
            {
                MessageBox.Show("You must enter a positive integer number of packs.");
                return;
            }
            if (!int.TryParse(txtCommonsCount.Text, out commons) || commons < 0)
            {
                MessageBox.Show("You must enter a positive integer number of commons.");
                return;
            }
            if (!int.TryParse(txtUncommonsCount.Text, out uncommons) || uncommons < 0)
            {
                MessageBox.Show("You must enter a positive integer number of uncommons.");
                return;
            }
            if (!int.TryParse(txtRaresCount.Text, out rares) || rares < 0)
            {
                MessageBox.Show("You must enter a positive integer number of rares.");
                return;
            }
            if (!float.TryParse(txtMythicsPercent.Text, out mythicPercentage) || mythicPercentage < 0 || mythicPercentage > 1)
            {
                MessageBox.Show("You must enter a mythic percentage between 0 and 1.");
                return;
            }
            Util.imageDirectory = txtImageFolderPath.Text;
            if (!Util.imageDirectory.EndsWith("/"))
                Util.imageDirectory += "/";
            server = new DraftServer(this, txtSetFilePath.Text, packs, commons, uncommons, rares, mythicPercentage);
            if (server.IsValidSet())
            {
                isochron.Default.SetFile = txtSetFilePath.Text;
                isochron.Default.ImageDirectory = txtImageFolderPath.Text;
                isochron.Default.Packs = txtPacksCount.Text;
                isochron.Default.CommonsPerPack = txtCommonsCount.Text;
                isochron.Default.UncommonPerPack = txtUncommonsCount.Text;
                isochron.Default.RaresPerPack = txtRaresCount.Text;
                isochron.Default.MythicPercentage = txtMythicsPercent.Text;
                isochron.Default.Save();
                btnLaunchServer.Enabled = false;
                btnSetFileBrowse.Enabled = false;
                txtSetFilePath.Enabled = false;
                txtImageFolderPath.Enabled = false;
                txtCommonsCount.Enabled = false;
                txtUncommonsCount.Enabled = false;
                txtRaresCount.Enabled = false;
                txtMythicsPercent.Enabled = false;
                txtPacksCount.Enabled = false;
                server.PrintServerStartMessage();
            }
            else
                server.server.Close();
        }

        //Start draft click event
        private void btnStartDraft_Click(object sender, EventArgs e)
        {
            PrintLine("Starting draft with " + server.aliases.Count + " players.");
            server.StartNextPack();
            btnStartDraft.Enabled = false;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Environment.Exit(0);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ServerWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
