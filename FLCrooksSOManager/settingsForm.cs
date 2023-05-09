using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Reflection;

namespace FLCrooksSOManager
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        private void bw_updateChecker_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
            Version version = Assembly.GetEntryAssembly().GetName().Version;
            buildLbl.Text = version.ToString();
        }
    }
}
