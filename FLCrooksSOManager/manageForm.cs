using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static FLCrooksSOManager.manageForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FLCrooksSOManager
{
    public partial class manageForm : Form
    {
        private mainForm mainFormRef;

        public manageForm(mainForm mainFormRef)
        {
            InitializeComponent();
            this.mainFormRef = mainFormRef;
        }

        public manageForm()
        {
            InitializeComponent();
        }

        private void manageForm_FormClosing(object sender, EventArgs e)
        {
            mainFormRef.ShowMainForm();
        }

        private void manageForm_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        public void UpdateListView(string searchTerm = "")
        {
            listView1.Items.Clear();

            string dataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string dataSubPath = Path.Combine(dataDirectory, @"FLCrooksSOManager\");
            string customersFilePath = Path.Combine(dataSubPath, "customers.xml");

            // Read the orders from the customers file
            List<Order> orderList = ReadOrdersFromCustomersFile(customersFilePath);

            if (!string.IsNullOrEmpty(searchTerm))
            {
                int id;
                long phoneNumber;
                bool isNumericId = false;
                if (searchTerm.StartsWith("ID:"))
                {
                    isNumericId = int.TryParse(searchTerm.Substring(3), out id);
                }
                else
                {
                    isNumericId = int.TryParse(searchTerm, out id);
                }

                orderList = orderList.Where(order =>
                    (isNumericId && order.ID == id) ||                            // Search by ID
                    (long.TryParse(searchTerm, out phoneNumber) && order.PhoneNumber.Contains(searchTerm)) ||  // Search by phone number
                    order.FirstName.Contains(searchTerm) ||
                    order.LastName.Contains(searchTerm) ||
                    order.Description.Contains(searchTerm)
                ).ToList();
            }



            // Add the orders to the ListBox
            foreach (Order order in orderList)
            {
                ListViewItem item = new ListViewItem(new string[] {
            order.ID.ToString(),
            order.FirstName,
            order.LastName,
            order.PhoneNumber,
            //String.Format("{0:(###) ###-####}", double.Parse(order.PhoneNumber)),
            order.Price.ToString("C2"),
            order.DatePlaced.ToString("MM-dd-yyyy"),
            order.OrderPlaced ? "Yes" : "No",
            order.Paid ? "Yes" : "No",
            order.Description
            });

                listView1.Items.Add(item);
            }
        }

        public class Order
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public bool Paid { get; set; }
            public DateTime DatePlaced { get; set; }
            public bool OrderPlaced { get; set; }
        }

        private List<Order> ReadOrdersFromCustomersFile(string filePath)
        {
            List<Order> orderList = new List<Order>();

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                XmlNodeList customerList = xmlDoc.SelectNodes("//Customers/Customer");

                foreach (XmlNode customerNode in customerList)
                {
                    Order order = new Order();
                    order.ID = int.Parse(customerNode.SelectSingleNode("ID").InnerText);
                    order.FirstName = customerNode.SelectSingleNode("First_Name").InnerText;
                    order.LastName = customerNode.SelectSingleNode("Last_Name").InnerText;
                    order.PhoneNumber = customerNode.SelectSingleNode("Phone_Number").InnerText;
                    order.Description = customerNode.SelectSingleNode("Description").InnerText;
                    order.Price = decimal.Parse(customerNode.SelectSingleNode("Price").InnerText.Replace("$", ""));
                    order.Paid = customerNode.SelectSingleNode("Paid").InnerText.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                    order.DatePlaced = DateTime.Parse(customerNode.SelectSingleNode("Date").InnerText);
                    order.OrderPlaced = customerNode.SelectSingleNode("Placed").InnerText.Equals("Yes", StringComparison.OrdinalIgnoreCase);

                    orderList.Add(order);
                }
            }
            catch (Exception ex)
            {
                // Log the error or display an error message
                Console.WriteLine($"Error loading file {filePath}: {ex.Message}");
            }

            return orderList;
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int sortColumn = -1;
        private bool ascending = true;

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // If the clicked column is the same as the previous sort column, reverse the sort order
            if (e.Column == sortColumn)
            {
                ascending = !ascending;
            }
            else
            {
                sortColumn = e.Column;
                ascending = true;
            }

            // Set the ListViewItemSorter property to a new ListViewItemComparer object
            // that sorts the items based on the clicked column and sort order
            listView1.ListViewItemSorter = new ListViewItemComparer(sortColumn, ascending);

            // Sort the items in the ListView
            listView1.Sort();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string description = listView1.SelectedItems[0].SubItems[8].Text;
                MessageBox.Show(description, "Product Description");
            }
        }


        class ListViewItemComparer : IComparer
        {
            private int column;
            private bool ascending;

            public ListViewItemComparer(int column, bool ascending)
            {
                this.column = column;
                this.ascending = ascending;
            }

            public int Compare(object x, object y)
            {
                ListViewItem item1 = (ListViewItem)x;
                ListViewItem item2 = (ListViewItem)y;

                string text1 = item1.SubItems[column].Text;
                string text2 = item2.SubItems[column].Text;

                int result;

                if (decimal.TryParse(text1, out decimal decimal1) && decimal.TryParse(text2, out decimal decimal2))
                {
                    result = decimal1.CompareTo(decimal2);
                }
                else if (DateTime.TryParse(text1, out DateTime date1) && DateTime.TryParse(text2, out DateTime date2))
                {
                    result = date1.CompareTo(date2);
                }
                else
                {
                    result = string.Compare(text1, text2);
                }

                if (!ascending)
                {
                    result = -result;
                }

                return result;
            }
        }

        private void newOrderBtnMgr_Click(object sender, EventArgs e)
        {
            new newOrderForm().Show();
            editBtn.Enabled = false;
            deleteBtn.Enabled = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEditButton();
        }

        private void UpdateEditButton()
        {
            if (listView1.InvokeRequired)
            {
                listView1.Invoke(new Action(() => UpdateEditButton()));
                return;
            }

            if (listView1.SelectedItems.Count > 0)
            {
                deleteBtn.Enabled = true;
                editBtn.Enabled = true;
            }
            else
            {
                editBtn.Enabled = false;
                deleteBtn.Enabled = false;
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            // Get the selected item in the ListView
            ListViewItem selectedItem = listView1.SelectedItems[0];

            // Extract the customer data from the ListViewItem
            int id = int.Parse(selectedItem.SubItems[0].Text);
            string firstName = selectedItem.SubItems[1].Text;
            string lastName = selectedItem.SubItems[2].Text;
            string phoneNumber = selectedItem.SubItems[3].Text;
            decimal price = decimal.Parse(selectedItem.SubItems[4].Text.Replace("$", ""));
            DateTime datePlaced = DateTime.ParseExact(selectedItem.SubItems[5].Text, "MM-dd-yyyy", null);
            bool orderPlaced = selectedItem.SubItems[6].Text == "Yes";
            bool paid = selectedItem.SubItems[7].Text == "Yes";
            string description = selectedItem.SubItems[8].Text;

            // Create a new editOrderForm and pass the customer data to it
            EditOrderForm editForm = new EditOrderForm(id, firstName, lastName, phoneNumber, price, datePlaced, orderPlaced, paid, description);
            editForm.ShowDialog();

            editBtn.Enabled = false;
            deleteBtn.Enabled = false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Get the ID of the selected order
                int selectedID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

                // Get the path to the customers.xml file
                string dataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string dataSubPath = Path.Combine(dataDirectory, @"FLCrooksSOManager\");
                string customersFilePath = Path.Combine(dataSubPath, "customers.xml");

                // Load the customers.xml file into an XDocument
                XDocument customersDoc = XDocument.Load(customersFilePath);

                // Find the customer element with the matching ID
                XElement customerToDelete = customersDoc.Descendants("Customer")
                    .Where(customer => customer.Element("ID").Value == selectedID.ToString())
                    .FirstOrDefault();

                if (customerToDelete != null)
                {
                    // Ask the user to confirm the deletion
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this customer? This can't be undone.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Remove the customer element from the XDocument
                        customerToDelete.Remove();

                        // Save the changes to the customers.xml file
                        customersDoc.Save(customersFilePath);

                        UpdateListView();
                    }

                    editBtn.Enabled = false;
                    deleteBtn.Enabled = false;
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            UpdateListView(searchBox.Text);
        }
    }
}
