using System.Xml.Linq;

namespace FLCrooksSOManager
{
    public partial class newOrderForm : Form
    {
        private mainForm mainFormRef;

        public newOrderForm(mainForm mainFormRef)
        {
            InitializeComponent();
            this.mainFormRef = mainFormRef;
        }

        public newOrderForm()
        {
            InitializeComponent2();
        }

        private bool isFormatting = false;

        private void pNumberTxtBox_TextChanged(object sender, EventArgs e)
        {
            // Save cursor position before changing the text
            int cursorPosition = pNumberTxtBox.SelectionStart;

            string phoneNumber = pNumberTxtBox.Text.Trim().Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            if (phoneNumber.Length == 7)
            {
                pNumberTxtBox.Text = phoneNumber.Substring(0, 3) + "-" + phoneNumber.Substring(3);
            }
            else if (phoneNumber.Length == 10)
            {
                pNumberTxtBox.Text = "(" + phoneNumber.Substring(0, 3) + ") " + phoneNumber.Substring(3, 3) + "-" + phoneNumber.Substring(6);
            }

            // Restore cursor position after changing the text
            pNumberTxtBox.SelectionStart = pNumberTxtBox.Text.Length;
        }


        public void newOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Prompt the user to confirm that they want to exit
                DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                                                      "Confirm Exit",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Save any unsaved changes here
                    mainFormRef.ShowMainForm();
                    // Close the main form
                    e.Cancel = false;
                }
                else
                {
                    // Cancel the close event
                    e.Cancel = true;
                }
            }
        }

        string paidIsChecked = "No";
        string OrderPlaced = "No";
        public bool CreateFile()
        {
            if (paidCheck.Checked)
            {
                paidIsChecked = "Yes";
            }
            if (orderPlacedCheck.Checked)
            {
                OrderPlaced = "Yes";
            }
            string dataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(dataDirectory))
                Directory.CreateDirectory(dataDirectory);
            string dataSubPath = Path.Combine(dataDirectory, @"FLCrooksSOManager\");
            string createFile = "Customers.xml";
            if (!Directory.Exists(dataSubPath))
                Directory.CreateDirectory(dataSubPath);
            string dataPath = Path.Combine(dataSubPath, createFile);

            // Load the existing customer data, if any
            XDocument dataDoc = null;
            if (File.Exists(dataPath))
            {
                dataDoc = XDocument.Load(dataPath);
            }

            // Get the last used customer ID
            int lastCustomerId = 0;
            if (dataDoc != null && dataDoc.Root.Elements("Customer").Any())
            {
                lastCustomerId = dataDoc.Root.Elements("Customer").Max(x => (int)x.Element("ID"));
            }

            // Generate a new customer ID
            int newCustomerId = lastCustomerId + 1;

            string phoneNumber = pNumberTxtBox.Text.Trim().Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");

            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Phone number cannot be empty");
                return false;
            }

            if (!phoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must contain only digits");
                return false;
            }

            if (phoneNumber.Length != 7 && phoneNumber.Length != 10)
            {
                MessageBox.Show("Phone number must have 7 or 10 digits");
                return false;
            }

            decimal price;
            if (!decimal.TryParse(priceTxtBox.Text, out price))
            {
                MessageBox.Show("Price must be a valid decimal number");
                return false;
            }


            // Create the XDocument with the new customer
            XElement customerElement = new XElement("Customer",
                                new XElement("ID", newCustomerId),
                                new XElement("First_Name", fNameTxtBox.Text),
                                new XElement("Last_Name", lNameTxtBox.Text),
                                new XElement("Phone_Number", pNumberTxtBox.Text),
                                new XElement("Description", descBox.Text),
                                new XElement("Price", "$" + price),
                                new XElement("Paid", paidIsChecked),
                                new XElement("Date", dateTimePicker1.Value.Date.ToString("d")),
                                new XElement("Placed", OrderPlaced));

            if (dataDoc == null)
            {
                dataDoc = new XDocument(new XElement("Customers"));
            }
            dataDoc.Root.Add(customerElement);
            dataDoc.Save(dataPath);

            MessageBox.Show("Customer Created!", "Customer Complete!", MessageBoxButtons.OK);
            var manageFormInstance = Application.OpenForms["manageForm"] as manageForm;
            if (manageFormInstance != null)
            {
                manageFormInstance.UpdateListView();
            }
            return true;
        }

        private void createOrder_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(fNameTxtBox.Text) && !String.IsNullOrEmpty(lNameTxtBox.Text) && !String.IsNullOrEmpty(pNumberTxtBox.Text) && !String.IsNullOrEmpty(descBox.Text) && !String.IsNullOrEmpty(priceTxtBox.Text))
            {
                if (CreateFile())
                {
                    DialogResult anotherOrderAnswer = MessageBox.Show("Would you like to create another order?", "Next Order", MessageBoxButtons.YesNo);

                    if (anotherOrderAnswer == DialogResult.Yes)
                    {
                        fNameTxtBox.Clear();
                        lNameTxtBox.Clear();
                        pNumberTxtBox.Clear();
                        descBox.Clear();
                        priceTxtBox.Clear();
                        paidCheck.Checked = false;
                        dateTimePicker1.Value = DateTime.Now;
                        orderPlacedCheck.Checked = false;
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("You must enter a first name, last name, Phone  number, Price, and a breif description of the order!");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void descLbl2_Click(object sender, EventArgs e)
        {

        }
    }
}
