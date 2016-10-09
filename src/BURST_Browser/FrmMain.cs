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

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CreateNewTabbedPageBrowser();
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

        private void CreateNewTabbedPageBrowser(string url = "https://www.google.com")
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
    }
}
