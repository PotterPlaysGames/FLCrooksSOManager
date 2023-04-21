using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static FLCrooksSOManager.manageForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FLCrooksSOManager
{
    public partial class EditOrderForm : Form
    {


        public EditOrderForm(int id, string firstName, string lastName, string phoneNumber, decimal price, DateTime datePlaced, bool orderPlaced, bool paid, string description)
        {
            InitializeComponent();

            this.Size = new Size(337, 523);

            descriptionTextBox.Size = new Size(248, 105);

            idEditLbl.Text = "ID:";
            idEditLbl.Size = new Size(21, 15);
            idEditLbl.Location = new Point(32, 30);

            fNameLbl.Text = "First Name:";
            fNameLbl.Size = new Size(67, 15);
            fNameLbl.Location = new Point(32, 59);

            lNameLbl.Text = "Last Name:";
            lNameLbl.Size = new Size(66, 15);
            lNameLbl.Location = new Point(32, 88);

            pNumLbl.Text = "Phone Number:";
            pNumLbl.Size = new Size(91, 15);
            pNumLbl.Location = new Point(32, 117);

            descLbl.Text = "Description";
            descLbl.Size = new Size(70, 15);
            descLbl.Location = new Point(115, 155);

            label1.Text = "Price:";
            label1.Size = new Size(36, 15);
            label1.Location = new Point(32, 297);

            paidCheckBox.Text = "Paid?";
            paidCheckBox.Size = new Size(54, 19);
            paidCheckBox.Location = new Point(32, 335);

            orderPlacedCheckBox.Text = "Order Placed?";
            orderPlacedCheckBox.Size = new Size(99, 19);
            orderPlacedCheckBox.Location = new Point(181, 335);

            label2.Text = "Date Entered:";
            label2.Size = new Size(77, 15);
            label2.Location = new Point(32, 386);

            idTextBox.Text = id.ToString();
            idTextBox.Size = new Size(115, 23);
            idTextBox.Location = new Point(165, 27);
            idTextBox.Margin = new Padding(3, 3, 3, 3);
            idTextBox.Enabled = false;

            firstNameTextBox.Text = firstName;
            firstNameTextBox.Size = new Size(115, 23);
            firstNameTextBox.Location = new Point(165, 56);
            firstNameTextBox.Margin = new Padding(3, 3, 3, 3);

            lastNameTextBox.Text = lastName;
            lastNameTextBox.Size = new Size(115, 23);
            lastNameTextBox.Location = new Point(165, 85);
            lastNameTextBox.Margin = new Padding(3, 3, 3, 3);

            phoneNumberTextBox.Text = phoneNumber;
            phoneNumberTextBox.Size = new Size(115, 23);
            phoneNumberTextBox.Location = new Point(165, 114);
            phoneNumberTextBox.Margin = new Padding(3, 3, 3, 3);

            priceTextBox.Text = price.ToString();
            priceTextBox.Size = new Size(115, 23);
            priceTextBox.Location = new Point(165, 294);
            priceTextBox.Margin = new Padding(3, 3, 3, 3);

            datePlacedDateTimePicker.Value = datePlaced;
            datePlacedDateTimePicker.Size = new Size(88, 23);
            datePlacedDateTimePicker.Location = new Point(192, 378);
            datePlacedDateTimePicker.Format = DateTimePickerFormat.Short;
            datePlacedDateTimePicker.Margin = new Padding(3, 3, 3, 3);

            orderPlacedCheckBox.Checked = orderPlaced;
            orderPlacedCheckBox.Size = new Size(99, 19);
            orderPlacedCheckBox.Location = new Point(181, 335);
            orderPlacedCheckBox.Margin = new Padding(3, 3, 3, 3);

            paidCheckBox.Checked = paid;
            paidCheckBox.Size = new Size(54, 19);
            paidCheckBox.Location = new Point(32, 335);
            paidCheckBox.Margin = new Padding(3, 3, 3, 3);

            descriptionTextBox.Text = description;
            descriptionTextBox.Size = new Size(248, 105);
            descriptionTextBox.Location = new Point(32, 173);
            descriptionTextBox.Margin = new Padding(3, 3, 3, 3);

            cancelBtn.Text = "Cancel";
            cancelBtn.Location = new Point(32, 420);
            cancelBtn.Margin = new Padding(3, 3, 3, 3);
            cancelBtn.Size = new Size(115, 52);

            saveButton.Text = "Save";
            saveButton.Location = new Point(165, 420);
            saveButton.Margin = new Padding(3, 3, 3, 3);
            saveButton.Size = new Size(115, 52);
        }
        public bool buttonClicked = false;
        public void EditOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && buttonClicked == false)
            {
                // Prompt the user to confirm that they want to exit
                DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                                                      "Confirm Exit",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
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

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            string dataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(dataDirectory))
                Directory.CreateDirectory(dataDirectory);
            string dataSubPath = Path.Combine(dataDirectory, @"FLCrooksSOManager\");
            string createFile = "Customers.xml";
            if (!Directory.Exists(dataSubPath))
                Directory.CreateDirectory(dataSubPath);
            string dataPath = Path.Combine(dataSubPath, createFile);
            XDocument xDoc = XDocument.Load(dataPath);

            // Find the customer with the matching ID and update its data
            int id = int.Parse(idTextBox.Text);
            XElement customer = xDoc.Descendants("Customer")
                                    .Where(c => (int)c.Element("ID") == id)
                                    .FirstOrDefault();
            if (customer != null)
            {
                customer.Element("First_Name").Value = firstNameTextBox.Text;
                customer.Element("Last_Name").Value = lastNameTextBox.Text;
                customer.Element("Phone_Number").Value = phoneNumberTextBox.Text;
                customer.Element("Description").Value = descriptionTextBox.Text;
                customer.Element("Price").Value = priceTextBox.Text;
                customer.Element("Paid").Value = paidCheckBox.Checked ? "Yes" : "No";
                customer.Element("Date").Value = datePlacedDateTimePicker.Value.ToShortDateString();
                customer.Element("Placed").Value = orderPlacedCheckBox.Checked ? "Yes" : "No";
            }

            xDoc.Save(dataPath);

            buttonClicked = true;
            var manageFormInstance = Application.OpenForms["manageForm"] as manageForm;
            if (manageFormInstance != null)
            {
                manageFormInstance.UpdateListView();
            }

            this.Close();
        }

        private void idEditLbl_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
