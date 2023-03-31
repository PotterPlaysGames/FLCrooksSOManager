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
        public newOrderForm()
        {
            InitializeComponent();
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
            string createFile = uniqueFileNum + fNameTxtBox.Text + "_" + lNameTxtBox.Text + ".xml";
            if (!Directory.Exists(dataSubPath))
                Directory.CreateDirectory(dataSubPath);
            string dataPath = Path.Combine(dataSubPath, createFile);
            if (!Directory.Exists(dataPath))
            {
                XDocument dataDoc = new XDocument(
                    new XElement("Order_Data",
                        new XElement("Info",
                            new XElement("ID", uniqueFileNum),
                            new XElement("First_Name", fNameTxtBox.Text),
                            new XElement("Last_Name", lNameTxtBox.Text),
                            new XElement("Phone_Number", pNumberTxtBox.Text),
                            new XElement("Description", descBox.Text),
                            new XElement("Price", "$" + priceTxtBox.Text),
                            new XElement("Paid", paidIsChecked),
                            new XElement("Date", dateTimePicker1.Value),
                            new XElement("Placed", OrderPlaced))));
                dataDoc.Save(dataPath);
                MessageBox.Show("Order Created!", "Order Complete!", MessageBoxButtons.OK);
            }
            else
            {
                Console.WriteLine("Error! Please try again.");
            }
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
