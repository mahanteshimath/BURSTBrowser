using System;
using System.Windows.Forms;

namespace BURST_Browser
{
    public partial class FrmMain : Form
    {
        private const int MaxTitleLength = 30;

        private WebBrowser _currentWebBrowser;

        public FrmMain()
        {
            InitializeComponent();
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CreateNewTabbedPageBrowser();


            _currentWebBrowser.ScriptErrorsSuppressed = true;


        }

        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
            {
                btnGo_Click(this, EventArgs.Empty);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _currentWebBrowser.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            _currentWebBrowser.GoForward();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            _currentWebBrowser.Navigate(txtUrl.Text);
        }

        private void btnNewTab_Click(object sender, EventArgs e)
        {
            CreateNewTabbedPageBrowser();
        }

        private void btnRemoveTab_Click(object sender, EventArgs e)
        {
            if (tbcBrowsers.TabCount >= 2)
            {
                int tabIndex = tbcBrowsers.SelectedIndex;
                tbcBrowsers.TabPages.RemoveAt(tabIndex);
                if (tabIndex == tbcBrowsers.TabCount)
                {
                    tbcBrowsers.SelectTab(tabIndex - 1);
                }
                else
                {
                    tbcBrowsers.SelectTab(tabIndex);
                }
            }
            else
            {
                Close();
            }
        }

        private void CreateNewTabbedPageBrowser(string url = "https://www.burst-team.us/")
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            WebBrowser webBrowser = new WebBrowser() {ScriptErrorsSuppressed = true};
            webBrowser.Parent = tab;
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.Navigate(url);

            webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
            webBrowser.DocumentTitleChanged += webBrowser_DocumentTitleChanged;

            tbcBrowsers.Controls.Add(tab);
            tbcBrowsers.SelectTab(tab);

            tbcBrowsers_Selected(this, new TabControlEventArgs(tab, tab.TabIndex, TabControlAction.Selected));
        }

        void webBrowser_DocumentTitleChanged(object sender, EventArgs e)
        {
            WebBrowser webBrowser = (sender as WebBrowser);
            string title = webBrowser.DocumentTitle;
            webBrowser.Parent.Text = title.Length > MaxTitleLength
                ? string.Concat(title.Substring(0, MaxTitleLength), "...")
                : title;
        }

        void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if ((sender as WebBrowser).Parent.Visible)
            {
                txtUrl.Text = e.Url.AbsoluteUri;
            }
        }

        private void tbcBrowsers_Selected(object sender, TabControlEventArgs e)
        {
            _currentWebBrowser = e.TabPage.Controls[0] as WebBrowser;
            if (_currentWebBrowser != null && _currentWebBrowser.Url != null)
            {
                txtUrl.Text = _currentWebBrowser.Document.Url.AbsoluteUri;
            }
        }

        private void btnOpenWallet_Click(object sender, EventArgs e)
        {
            CreateNewTabbedPageBrowser("http://localhost:8125");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings FrmSettings = new FrmSettings();
            FrmSettings.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _currentWebBrowser.Navigate("www.google.com");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            _currentWebBrowser.Navigate("https://forums.burst-team.us/topic/1284/ann-the-n-e-w-s-asset-launch");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
        }

        private void adBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbcBrowsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
