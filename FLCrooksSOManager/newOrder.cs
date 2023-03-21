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

            string createFile = fNameTxtBox.Text + "_" + lNameTxtBox.Text + ".xml";
            if (!Directory.Exists(dataSubPath))
                Directory.CreateDirectory(dataSubPath);
            string dataPath = Path.Combine(dataSubPath, createFile);
            if (!Directory.Exists(dataPath))
            {
                XDocument dataDoc = new XDocument(
                    new XElement("Order_Data",
                        new XElement("Info",
                            new XElement("First_Name", fNameTxtBox.Text),
                            new XElement("Last_Name", lNameTxtBox.Text),
                            new XElement("Phone_Number", pNumberTxtBox.Text),
                            new XElement("Description", descBox.Text),
                            new XElement("Price", priceTxtBox.Text),
                            new XElement("Paid", paidIsChecked),
                            new XElement("Date", dateTimePicker1),
                            new XElement("Placed", OrderPlaced))));
                dataDoc.Save(dataPath);
                System.Windows.Forms.MessageBox.Show("Order Created!");
            }
            else
            {
                Console.WriteLine("Error! Please try again.");
            }
        }

        private void createOrder_Click(object sender, EventArgs e)
        {
            CreateFile();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            new mainForm().Show();
        }

        private void newOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
