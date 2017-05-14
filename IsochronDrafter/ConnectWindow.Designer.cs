namespace IsochronDrafter
{
    partial class ConnectWindow
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
            System.Windows.Forms.Button btnConnect;
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.lblServerAddress = new System.Windows.Forms.Label();
            this.txtUserAlias = new System.Windows.Forms.TextBox();
            this.lblUserAlias = new System.Windows.Forms.Label();
            this.btnStartServer = new System.Windows.Forms.Button();
            btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new System.Drawing.Point(55, 60);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new System.Drawing.Size(129, 23);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Location = new System.Drawing.Point(74, 12);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(149, 20);
            this.txtServerAddress.TabIndex = 0;
            // 
            // lblServerAddress
            // 
            this.lblServerAddress.AutoSize = true;
            this.lblServerAddress.Location = new System.Drawing.Point(14, 15);
            this.lblServerAddress.Name = "lblServerAddress";
            this.lblServerAddress.Size = new System.Drawing.Size(41, 13);
            this.lblServerAddress.TabIndex = 1;
            this.lblServerAddress.Text = "Server:";
            // 
            // txtUserAlias
            // 
            this.txtUserAlias.Location = new System.Drawing.Point(74, 34);
            this.txtUserAlias.Name = "txtUserAlias";
            this.txtUserAlias.Size = new System.Drawing.Size(149, 20);
            this.txtUserAlias.TabIndex = 1;
            // 
            // lblUserAlias
            // 
            this.lblUserAlias.AutoSize = true;
            this.lblUserAlias.Location = new System.Drawing.Point(14, 37);
            this.lblUserAlias.Name = "lblUserAlias";
            this.lblUserAlias.Size = new System.Drawing.Size(32, 13);
            this.lblUserAlias.TabIndex = 1;
            this.lblUserAlias.Text = "Alias:";
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(55, 89);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(129, 23);
            this.btnStartServer.TabIndex = 3;
            this.btnStartServer.Text = "Start Server...";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // ConnectWindow
            // 
            this.AcceptButton = btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 122);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(btnConnect);
            this.Controls.Add(this.lblUserAlias);
            this.Controls.Add(this.txtUserAlias);
            this.Controls.Add(this.lblServerAddress);
            this.Controls.Add(this.txtServerAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConnectWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerAddress;
        private System.Windows.Forms.Label lblServerAddress;
        private System.Windows.Forms.TextBox txtUserAlias;
        private System.Windows.Forms.Label lblUserAlias;
        private System.Windows.Forms.Button btnStartServer;
    }
}