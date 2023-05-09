using System.ComponentModel;
using System.Diagnostics;
using System.Net;

namespace FLCrooksSOManager
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
            newVerLblTxt.Hide();
        }

        private void checkUpdate()
        {
            var urlVersion = "";
            var newVersion = (new WebClient().DownloadString(urlVersion));
            var currentVersion = Application.ProductVersion.ToString();

            prevVerLblTxt.Text = currentVersion;

            newVersion = newVersion.Replace(".", "");
            currentVersion = currentVersion.Replace(".", "");

            if (Convert.ToInt32(newVersion) > Convert.ToInt32(currentVersion))
            {
                updateAvTxt.Text = "A new version is available. \r\nDo you want to update? \r\n";
                newVerLblTxt.Text = (new WebClient().DownloadString(urlVersion));
                updateBtn.Enabled = true;
                newVerLblTxt.Show();

            }
            else
            {
                updateAvTxt.Text = "This is the current Verion available.";
                updateBtn.Enabled = false;
                newVerLblTxt.Hide();
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            WebClient web = new WebClient();
            web.DownloadFileCompleted += Web_DownloadFileCompleted;
            web.DownloadFileAsync(new Uri("server link"), "path");
        }

        private void Web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            initScript();
        }

        private void initScript()
        {
            string path = Application.StartupPath + @"\bat";

            Process p = new Process();
            p.StartInfo.FileName = path;
            p.StartInfo.Arguments = "";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.Verb = "runas";
            p.Start();
            Environment.Exit(1);
        }

        private void bw_updateChecker_DoWork(object sender, DoWorkEventArgs e)
        {
            checkUpdate();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bw_updateChecker.RunWorkerAsync();
        }
    }
}
