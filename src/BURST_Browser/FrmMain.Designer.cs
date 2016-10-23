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
            this.components = new System.ComponentModel.Container();
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
            this.btnOpenWallet = new Bunifu.Framework.UI.BunifuImageButton();
            this.tbcBrowsers = new System.Windows.Forms.TabControl();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.adBox1 = new System.Windows.Forms.PictureBox();
            this.adBox2 = new System.Windows.Forms.PictureBox();
            this.adBox3 = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenWallet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adBox3)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 23);
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
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click_1);
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
            // tbcBrowsers
            // 
            this.tbcBrowsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcBrowsers.Location = new System.Drawing.Point(0, 54);
            this.tbcBrowsers.Name = "tbcBrowsers";
            this.tbcBrowsers.SelectedIndex = 0;
            this.tbcBrowsers.Size = new System.Drawing.Size(1264, 599);
            this.tbcBrowsers.TabIndex = 2;
            this.tbcBrowsers.SelectedIndexChanged += new System.EventHandler(this.tbcBrowsers_SelectedIndexChanged);
            this.tbcBrowsers.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcBrowsers_Selected);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(5, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(85, 13);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "BURST Browser";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1240, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // adBox1
            // 
            this.adBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.adBox1.BackColor = System.Drawing.Color.White;
            this.adBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adBox1.Image = ((System.Drawing.Image)(resources.GetObject("adBox1.Image")));
            this.adBox1.Location = new System.Drawing.Point(139, 656);
            this.adBox1.Name = "adBox1";
            this.adBox1.Size = new System.Drawing.Size(325, 40);
            this.adBox1.TabIndex = 11;
            this.adBox1.TabStop = false;
            // 
            // adBox2
            // 
            this.adBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adBox2.BackColor = System.Drawing.Color.White;
            this.adBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adBox2.Image = ((System.Drawing.Image)(resources.GetObject("adBox2.Image")));
            this.adBox2.Location = new System.Drawing.Point(470, 656);
            this.adBox2.Name = "adBox2";
            this.adBox2.Size = new System.Drawing.Size(325, 40);
            this.adBox2.TabIndex = 12;
            this.adBox2.TabStop = false;
            // 
            // adBox3
            // 
            this.adBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.adBox3.BackColor = System.Drawing.Color.White;
            this.adBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adBox3.Image = ((System.Drawing.Image)(resources.GetObject("adBox3.Image")));
            this.adBox3.Location = new System.Drawing.Point(801, 656);
            this.adBox3.Name = "adBox3";
            this.adBox3.Size = new System.Drawing.Size(325, 40);
            this.adBox3.TabIndex = 13;
            this.adBox3.TabStop = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Location = new System.Drawing.Point(1220, 1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnMaximize.TabIndex = 14;
            this.btnMaximize.Text = "🗖 ";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Location = new System.Drawing.Point(1200, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 15;
            this.btnMinimize.Text = "🗕 ";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1264, 700);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.adBox3);
            this.Controls.Add(this.adBox2);
            this.Controls.Add(this.adBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.tbcBrowsers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BURST Browser";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
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
            ((System.ComponentModel.ISupportInitialize)(this.adBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox adBox1;
        private System.Windows.Forms.PictureBox adBox2;
        private System.Windows.Forms.PictureBox adBox3;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
    }
}

