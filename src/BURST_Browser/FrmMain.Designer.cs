namespace BURST_Browser
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSettings = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRemoveTab = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNewTab = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtUrl = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnGo = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnForward = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbcBrowsers = new System.Windows.Forms.TabControl();
            this.btnOpenWallet = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenWallet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnRemoveTab);
            this.panel1.Controls.Add(this.btnNewTab);
            this.panel1.Controls.Add(this.txtUrl);
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.btnForward);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 30);
            this.panel1.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageActive = null;
            this.btnSettings.Location = new System.Drawing.Point(1227, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(25, 25);
            this.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSettings.TabIndex = 8;
            this.btnSettings.TabStop = false;
            this.btnSettings.Zoom = 10;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnRemoveTab
            // 
            this.btnRemoveTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveTab.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveTab.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveTab.Image")));
            this.btnRemoveTab.ImageActive = null;
            this.btnRemoveTab.Location = new System.Drawing.Point(1199, 3);
            this.btnRemoveTab.Name = "btnRemoveTab";
            this.btnRemoveTab.Size = new System.Drawing.Size(25, 25);
            this.btnRemoveTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRemoveTab.TabIndex = 7;
            this.btnRemoveTab.TabStop = false;
            this.btnRemoveTab.Zoom = 10;
            this.btnRemoveTab.Click += new System.EventHandler(this.btnRemoveTab_Click);
            // 
            // btnNewTab
            // 
            this.btnNewTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewTab.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTab.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTab.Image")));
            this.btnNewTab.ImageActive = null;
            this.btnNewTab.Location = new System.Drawing.Point(1171, 3);
            this.btnNewTab.Name = "btnNewTab";
            this.btnNewTab.Size = new System.Drawing.Size(25, 25);
            this.btnNewTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNewTab.TabIndex = 6;
            this.btnNewTab.TabStop = false;
            this.btnNewTab.Zoom = 10;
            this.btnNewTab.Click += new System.EventHandler(this.btnNewTab_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtUrl.Location = new System.Drawing.Point(94, 5);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(1044, 20);
            this.txtUrl.TabIndex = 5;
            this.txtUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrl_KeyPress);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.BackColor = System.Drawing.Color.Transparent;
            this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
            this.btnGo.ImageActive = null;
            this.btnGo.Location = new System.Drawing.Point(1144, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(25, 25);
            this.btnGo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGo.TabIndex = 4;
            this.btnGo.TabStop = false;
            this.btnGo.Zoom = 10;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageActive = null;
            this.btnForward.Location = new System.Drawing.Point(63, 2);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(25, 25);
            this.btnForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnForward.TabIndex = 3;
            this.btnForward.TabStop = false;
            this.btnForward.Zoom = 10;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageActive = null;
            this.btnBack.Location = new System.Drawing.Point(36, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 25);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 2;
            this.btnBack.TabStop = false;
            this.btnBack.Zoom = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.panel2.Controls.Add(this.btnOpenWallet);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 56);
            this.panel2.TabIndex = 2;
            // 
            // tbcBrowsers
            // 
            this.tbcBrowsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcBrowsers.Location = new System.Drawing.Point(0, 31);
            this.tbcBrowsers.Name = "tbcBrowsers";
            this.tbcBrowsers.SelectedIndex = 0;
            this.tbcBrowsers.Size = new System.Drawing.Size(1264, 650);
            this.tbcBrowsers.TabIndex = 2;
            this.tbcBrowsers.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcBrowsers_Selected);
            // 
            // btnOpenWallet
            // 
            this.btnOpenWallet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnOpenWallet.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenWallet.Image")));
            this.btnOpenWallet.ImageActive = null;
            this.btnOpenWallet.Location = new System.Drawing.Point(4, 2);
            this.btnOpenWallet.Name = "btnOpenWallet";
            this.btnOpenWallet.Size = new System.Drawing.Size(25, 25);
            this.btnOpenWallet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOpenWallet.TabIndex = 0;
            this.btnOpenWallet.TabStop = false;
            this.btnOpenWallet.Zoom = 10;
            this.btnOpenWallet.Click += new System.EventHandler(this.btnOpenWallet_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tbcBrowsers);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BURST Browser";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenWallet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnBack;
        private Bunifu.Framework.UI.BunifuImageButton btnForward;
        private Bunifu.Framework.UI.BunifuImageButton btnGo;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtUrl;
        private Bunifu.Framework.UI.BunifuImageButton btnNewTab;
        private System.Windows.Forms.TabControl tbcBrowsers;
        private Bunifu.Framework.UI.BunifuImageButton btnRemoveTab;
        private Bunifu.Framework.UI.BunifuImageButton btnSettings;
        private Bunifu.Framework.UI.BunifuImageButton btnOpenWallet;
    }
}

