using Octokit;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace FLCrooksSOManager
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            CheckForUpdates();
        }

        private void settingsIcon_Click(object sender, EventArgs e)
        {

            new settingsForm().ShowDialog();
        }

        private void newOrderBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new newOrderForm(this).Show();
        }

        private void manageBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new manageForm(this).Show();
        }

        public void ShowMainForm()
        {
            this.Show();
        }

        public async Task CheckForUpdates()
        {
            // GitHub repository details
            string owner = "PotterPLaysGames";
            string repo = "FLCrooksSOManager";

            // GitHub API client
            var github = new GitHubClient(new ProductHeaderValue("FLCrooksSOManager"));

            try
            {
                // Get the latest release
                var releases = await github.Repository.Release.GetAll(owner, repo);
                var latestRelease = releases[0];

                // Compare versions
                Version latestVersion = new Version(latestRelease.TagName);
                Version currentVersion = new Version("0.1.0");  // Replace with your current version
                if (latestVersion > currentVersion)
                {
                    // An update is available
                    Console.WriteLine("Update available!");

                    // Download the update
                    string downloadUrl = latestRelease.Assets[0].BrowserDownloadUrl;  // Assuming the release has an asset to download
                    string updateFilePath = Path.Combine(Path.GetTempPath(), "Update.msi");
                    using (var client = new WebClient())
                    {
                        await client.DownloadFileTaskAsync(downloadUrl, updateFilePath);
                    }

                    // Install the update
                    InstallUpdate(updateFilePath);
                }
                else
                {
                    Console.WriteLine("No updates available.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please contact developer. Failed to check for updates: {ex.Message}");
            }
        }

        private void InstallUpdate(string updateFilePath)
        {
            try
            {
                // Step 2: Display update prompt
                DialogResult result = MessageBox.Show("New Version Available! Would you like to update?", "Update Available", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Step 1: Close the program
                    this.Close();

                    // Step 3: Start the installation process
                    Process.Start("msiexec.exe", $"/i \"{updateFilePath}\" /norestart").WaitForExit();

                    // Step 4: Restart the program
                    Process.Start(@"C:\Program Files\FLCrooks\FLCrooks Speical Order Manager\FLCrooksSOManager.exe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please contact developer. Failed to install update: {ex.Message}");
            }
        }


    }
}