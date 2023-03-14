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
            string createFile = fNameTxtBox.Text + "_" + lNameTxtBox.Text + ".xml";
            string dataSubPath = Path.Combine(dataDirectory, @"FLCrooksSOManager\");
            if (!Directory.Exists(dataSubPath))
                Directory.CreateDirectory(dataSubPath);
            string dataPath = Path.Combine(dataSubPath, createFile);
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

        private void createOrder_Click(object sender, EventArgs e)
        {
            CreateFile();
        }
    }
}
