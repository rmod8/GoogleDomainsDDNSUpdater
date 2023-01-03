namespace GoogleDomainsDDNSUpdater
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboIPChoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textDomain = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.nDelayInMinutes = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.checkStartOn = new System.Windows.Forms.CheckBox();
            this.hyperlFam = new System.Windows.Forms.LinkLabel();
            this.buttonLock = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDelayInMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // comboIPChoice
            // 
            this.comboIPChoice.FormattingEnabled = true;
            this.comboIPChoice.Items.AddRange(new object[] {
            "IPv4",
            "IPv6"});
            this.comboIPChoice.Location = new System.Drawing.Point(18, 85);
            this.comboIPChoice.Name = "comboIPChoice";
            this.comboIPChoice.Size = new System.Drawing.Size(162, 21);
            this.comboIPChoice.TabIndex = 0;
            this.comboIPChoice.SelectedIndexChanged += new System.EventHandler(this.comboIPChoice_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP to Provide:";
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(18, 36);
            this.textUsername.Name = "textUsername";
            this.textUsername.PasswordChar = '*';
            this.textUsername.Size = new System.Drawing.Size(162, 20);
            this.textUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username:";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(202, 36);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(162, 20);
            this.textPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Domain:";
            // 
            // textDomain
            // 
            this.textDomain.Location = new System.Drawing.Point(202, 85);
            this.textDomain.Name = "textDomain";
            this.textDomain.Size = new System.Drawing.Size(162, 20);
            this.textDomain.TabIndex = 7;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 233);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(376, 22);
            this.statusStrip.TabIndex = 10;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(81, 17);
            this.tsStatus.Text = "Status: Offline";
            // 
            // nDelayInMinutes
            // 
            this.nDelayInMinutes.Location = new System.Drawing.Point(202, 130);
            this.nDelayInMinutes.Maximum = new decimal(new int[] {
            2880,
            0,
            0,
            0});
            this.nDelayInMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nDelayInMinutes.Name = "nDelayInMinutes";
            this.nDelayInMinutes.Size = new System.Drawing.Size(162, 20);
            this.nDelayInMinutes.TabIndex = 11;
            this.nDelayInMinutes.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Refresh Delay (in Minutes:)";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(18, 168);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(162, 23);
            this.buttonStart.TabIndex = 13;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(202, 168);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(162, 23);
            this.buttonStop.TabIndex = 14;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // checkStartOn
            // 
            this.checkStartOn.AutoSize = true;
            this.checkStartOn.Location = new System.Drawing.Point(28, 130);
            this.checkStartOn.Name = "checkStartOn";
            this.checkStartOn.Size = new System.Drawing.Size(146, 17);
            this.checkStartOn.TabIndex = 15;
            this.checkStartOn.Text = "Start Refresh when Open";
            this.checkStartOn.UseVisualStyleBackColor = true;
            // 
            // hyperlFam
            // 
            this.hyperlFam.AutoSize = true;
            this.hyperlFam.Location = new System.Drawing.Point(2, 217);
            this.hyperlFam.Name = "hyperlFam";
            this.hyperlFam.Size = new System.Drawing.Size(130, 13);
            this.hyperlFam.TabIndex = 16;
            this.hyperlFam.TabStop = true;
            this.hyperlFam.Text = "Silk Icons by FamFamFam";
            this.hyperlFam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hyperlFam_LinkClicked);
            // 
            // buttonLock
            // 
            this.buttonLock.BackgroundImage = global::GoogleDomainsDDNSUpdater.Properties.Resources.lock_open;
            this.buttonLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLock.Location = new System.Drawing.Point(324, 193);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(40, 40);
            this.buttonLock.TabIndex = 17;
            this.buttonLock.UseVisualStyleBackColor = true;
            this.buttonLock.Click += new System.EventHandler(this.buttonLock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 255);
            this.Controls.Add(this.buttonLock);
            this.Controls.Add(this.hyperlFam);
            this.Controls.Add(this.checkStartOn);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nDelayInMinutes);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textDomain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboIPChoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Domains DDNS Updater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StopThread);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDelayInMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboIPChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDomain;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.NumericUpDown nDelayInMinutes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.CheckBox checkStartOn;
        private System.Windows.Forms.LinkLabel hyperlFam;
        private System.Windows.Forms.Button buttonLock;
    }
}

