namespace IsochronDrafter
{
    partial class ServerWindow
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
            this.btnLaunchServer = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnStartDraft = new System.Windows.Forms.Button();
            this.txtServerLog = new System.Windows.Forms.TextBox();
            this.lblSetFilePath = new System.Windows.Forms.Label();
            this.lblImageFolderPath = new System.Windows.Forms.Label();
            this.txtSetFilePath = new System.Windows.Forms.TextBox();
            this.btnSetFileBrowse = new System.Windows.Forms.Button();
            this.txtImageFolderPath = new System.Windows.Forms.TextBox();
            this.lblCommonsCount = new System.Windows.Forms.Label();
            this.txtCommonsCount = new System.Windows.Forms.TextBox();
            this.lblUncommonsCount = new System.Windows.Forms.Label();
            this.txtUncommonsCount = new System.Windows.Forms.TextBox();
            this.lblRaresCount = new System.Windows.Forms.Label();
            this.txtRaresCount = new System.Windows.Forms.TextBox();
            this.lblMythicsPercent = new System.Windows.Forms.Label();
            this.txtMythicsPercent = new System.Windows.Forms.TextBox();
            this.lblPacksCount = new System.Windows.Forms.Label();
            this.txtPacksCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLaunchServer
            // 
            this.btnLaunchServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLaunchServer.Location = new System.Drawing.Point(278, 478);
            this.btnLaunchServer.Name = "btnLaunchServer";
            this.btnLaunchServer.Size = new System.Drawing.Size(101, 23);
            this.btnLaunchServer.TabIndex = 3;
            this.btnLaunchServer.Text = "Launch Server";
            this.btnLaunchServer.UseVisualStyleBackColor = true;
            this.btnLaunchServer.Click += new System.EventHandler(this.btnLaunchServer_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Isochron Drafter text files|*.txt";
            // 
            // btnStartDraft
            // 
            this.btnStartDraft.Enabled = false;
            this.btnStartDraft.Location = new System.Drawing.Point(385, 478);
            this.btnStartDraft.Name = "btnStartDraft";
            this.btnStartDraft.Size = new System.Drawing.Size(85, 23);
            this.btnStartDraft.TabIndex = 4;
            this.btnStartDraft.Text = "Start Draft";
            this.btnStartDraft.UseVisualStyleBackColor = true;
            this.btnStartDraft.Click += new System.EventHandler(this.btnStartDraft_Click);
            // 
            // txtServerLog
            // 
            this.txtServerLog.BackColor = System.Drawing.SystemColors.Window;
            this.txtServerLog.Location = new System.Drawing.Point(12, 12);
            this.txtServerLog.Multiline = true;
            this.txtServerLog.Name = "txtServerLog";
            this.txtServerLog.ReadOnly = true;
            this.txtServerLog.Size = new System.Drawing.Size(725, 385);
            this.txtServerLog.TabIndex = 0;
            // 
            // lblSetFilePath
            // 
            this.lblSetFilePath.AutoSize = true;
            this.lblSetFilePath.Location = new System.Drawing.Point(51, 404);
            this.lblSetFilePath.Name = "lblSetFilePath";
            this.lblSetFilePath.Size = new System.Drawing.Size(45, 13);
            this.lblSetFilePath.TabIndex = 3;
            this.lblSetFilePath.Text = "Set File:";
            // 
            // lblImageFolderPath
            // 
            this.lblImageFolderPath.AutoSize = true;
            this.lblImageFolderPath.Location = new System.Drawing.Point(12, 429);
            this.lblImageFolderPath.Name = "lblImageFolderPath";
            this.lblImageFolderPath.Size = new System.Drawing.Size(84, 13);
            this.lblImageFolderPath.TabIndex = 4;
            this.lblImageFolderPath.Text = "Image Directory:";
            // 
            // txtSetFilePath
            // 
            this.txtSetFilePath.Location = new System.Drawing.Point(102, 401);
            this.txtSetFilePath.Name = "txtSetFilePath";
            this.txtSetFilePath.Size = new System.Drawing.Size(554, 20);
            this.txtSetFilePath.TabIndex = 0;
            this.txtSetFilePath.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnSetFileBrowse
            // 
            this.btnSetFileBrowse.Location = new System.Drawing.Point(662, 399);
            this.btnSetFileBrowse.Name = "btnSetFileBrowse";
            this.btnSetFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnSetFileBrowse.TabIndex = 1;
            this.btnSetFileBrowse.Text = "Browse...";
            this.btnSetFileBrowse.UseVisualStyleBackColor = true;
            this.btnSetFileBrowse.Click += new System.EventHandler(this.btnSetFileBrowse_Click);
            // 
            // txtImageFolderPath
            // 
            this.txtImageFolderPath.Location = new System.Drawing.Point(102, 426);
            this.txtImageFolderPath.Name = "txtImageFolderPath";
            this.txtImageFolderPath.Size = new System.Drawing.Size(554, 20);
            this.txtImageFolderPath.TabIndex = 2;
            // 
            // lblCommonsCount
            // 
            this.lblCommonsCount.AutoSize = true;
            this.lblCommonsCount.Location = new System.Drawing.Point(185, 455);
            this.lblCommonsCount.Name = "lblCommonsCount";
            this.lblCommonsCount.Size = new System.Drawing.Size(103, 13);
            this.lblCommonsCount.TabIndex = 5;
            this.lblCommonsCount.Text = "Commons Per Pack:";
            // 
            // txtCommonsCount
            // 
            this.txtCommonsCount.Location = new System.Drawing.Point(294, 452);
            this.txtCommonsCount.Name = "txtCommonsCount";
            this.txtCommonsCount.Size = new System.Drawing.Size(25, 20);
            this.txtCommonsCount.TabIndex = 6;
            // 
            // lblUncommonsCount
            // 
            this.lblUncommonsCount.AutoSize = true;
            this.lblUncommonsCount.Location = new System.Drawing.Point(325, 455);
            this.lblUncommonsCount.Name = "lblUncommonsCount";
            this.lblUncommonsCount.Size = new System.Drawing.Size(69, 13);
            this.lblUncommonsCount.TabIndex = 5;
            this.lblUncommonsCount.Text = "Uncommons:";
            // 
            // txtUncommonsCount
            // 
            this.txtUncommonsCount.Location = new System.Drawing.Point(400, 452);
            this.txtUncommonsCount.Name = "txtUncommonsCount";
            this.txtUncommonsCount.Size = new System.Drawing.Size(25, 20);
            this.txtUncommonsCount.TabIndex = 6;
            // 
            // lblRaresCount
            // 
            this.lblRaresCount.AutoSize = true;
            this.lblRaresCount.Location = new System.Drawing.Point(431, 455);
            this.lblRaresCount.Name = "lblRaresCount";
            this.lblRaresCount.Size = new System.Drawing.Size(38, 13);
            this.lblRaresCount.TabIndex = 5;
            this.lblRaresCount.Text = "Rares:";
            // 
            // txtRaresCount
            // 
            this.txtRaresCount.Location = new System.Drawing.Point(475, 452);
            this.txtRaresCount.Name = "txtRaresCount";
            this.txtRaresCount.Size = new System.Drawing.Size(25, 20);
            this.txtRaresCount.TabIndex = 6;
            // 
            // lblMythicsPercent
            // 
            this.lblMythicsPercent.AutoSize = true;
            this.lblMythicsPercent.Location = new System.Drawing.Point(506, 455);
            this.lblMythicsPercent.Name = "lblMythicsPercent";
            this.lblMythicsPercent.Size = new System.Drawing.Size(99, 13);
            this.lblMythicsPercent.TabIndex = 5;
            this.lblMythicsPercent.Text = "Mythic Percentage:";
            // 
            // txtMythicsPercent
            // 
            this.txtMythicsPercent.Location = new System.Drawing.Point(603, 452);
            this.txtMythicsPercent.Name = "txtMythicsPercent";
            this.txtMythicsPercent.Size = new System.Drawing.Size(37, 20);
            this.txtMythicsPercent.TabIndex = 6;
            // 
            // lblPacksCount
            // 
            this.lblPacksCount.AutoSize = true;
            this.lblPacksCount.Location = new System.Drawing.Point(108, 455);
            this.lblPacksCount.Name = "lblPacksCount";
            this.lblPacksCount.Size = new System.Drawing.Size(40, 13);
            this.lblPacksCount.TabIndex = 5;
            this.lblPacksCount.Text = "Packs:";
            // 
            // txtPacksCount
            // 
            this.txtPacksCount.Location = new System.Drawing.Point(154, 452);
            this.txtPacksCount.Name = "txtPacksCount";
            this.txtPacksCount.Size = new System.Drawing.Size(25, 20);
            this.txtPacksCount.TabIndex = 6;
            // 
            // ServerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 507);
            this.Controls.Add(this.txtMythicsPercent);
            this.Controls.Add(this.txtRaresCount);
            this.Controls.Add(this.txtUncommonsCount);
            this.Controls.Add(this.txtPacksCount);
            this.Controls.Add(this.txtCommonsCount);
            this.Controls.Add(this.lblMythicsPercent);
            this.Controls.Add(this.lblRaresCount);
            this.Controls.Add(this.lblPacksCount);
            this.Controls.Add(this.lblUncommonsCount);
            this.Controls.Add(this.lblCommonsCount);
            this.Controls.Add(this.btnSetFileBrowse);
            this.Controls.Add(this.txtImageFolderPath);
            this.Controls.Add(this.txtSetFilePath);
            this.Controls.Add(this.lblImageFolderPath);
            this.Controls.Add(this.lblSetFilePath);
            this.Controls.Add(this.btnStartDraft);
            this.Controls.Add(this.btnLaunchServer);
            this.Controls.Add(this.txtServerLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ServerWindow";
            this.Text = "Isochron Drafter Server";
            this.Load += new System.EventHandler(this.ServerWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaunchServer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnStartDraft;
        private System.Windows.Forms.TextBox txtServerLog;
        private System.Windows.Forms.Label lblSetFilePath;
        private System.Windows.Forms.Label lblImageFolderPath;
        private System.Windows.Forms.TextBox txtSetFilePath;
        private System.Windows.Forms.Button btnSetFileBrowse;
        private System.Windows.Forms.TextBox txtImageFolderPath;
        private System.Windows.Forms.Label lblCommonsCount;
        private System.Windows.Forms.TextBox txtCommonsCount;
        private System.Windows.Forms.Label lblUncommonsCount;
        private System.Windows.Forms.TextBox txtUncommonsCount;
        private System.Windows.Forms.Label lblRaresCount;
        private System.Windows.Forms.TextBox txtRaresCount;
        private System.Windows.Forms.Label lblMythicsPercent;
        private System.Windows.Forms.TextBox txtMythicsPercent;
        private System.Windows.Forms.Label lblPacksCount;
        private System.Windows.Forms.TextBox txtPacksCount;
    }
}