namespace FLCrooksSOManager
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
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
    }
}