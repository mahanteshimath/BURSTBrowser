using System.Diagnostics;
using System.Windows.Forms;

namespace BURST_Browser
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void btnFullscreen_Click(object sender, System.EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new System.Drawing.Point(0, 0);
            this.Size = new System.Drawing.Size(w, h);
        }

        private void btnSettings_Click(object sender, System.EventArgs e)
        {
            AboutUs about = new AboutUs();
            about.Show();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmSettings_Load(object sender, System.EventArgs e)
        {
            lblTime.Text = System.DateTime.Now.ToShortTimeString();
        }

        private void lblTime_Click(object sender, System.EventArgs e)
        {
            
        }

        private void btnQuestion_Click(object sender, System.EventArgs e)
        {
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Navigate("http://forums.burst-team.us/");
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
        }
    }
}
