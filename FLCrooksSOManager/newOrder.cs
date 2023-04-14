using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public void CreateFile()
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
            var countFiles = Directory.GetFiles(dataSubPath, "*.*", SearchOption.AllDirectories).Count();
            long uniqueFileNum = countFiles + 1;
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

            // Create the XDocument with the new customer
            XElement customerElement = new XElement("Customer",
                                new XElement("ID", newCustomerId),
                                new XElement("First_Name", fNameTxtBox.Text),
                                new XElement("Last_Name", lNameTxtBox.Text),
                                new XElement("Phone_Number", pNumberTxtBox.Text),
                                new XElement("Description", descBox.Text),
                                new XElement("Price", "$" + priceTxtBox.Text),
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
        }

        private void createOrder_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(fNameTxtBox.Text) && !String.IsNullOrEmpty(lNameTxtBox.Text) && !String.IsNullOrEmpty(pNumberTxtBox.Text) && !String.IsNullOrEmpty(descBox.Text) && !String.IsNullOrEmpty(priceTxtBox.Text))
            {
                CreateFile();
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
