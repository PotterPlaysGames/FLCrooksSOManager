using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FLCrooksSOManager
{
    public partial class manageForm : Form
    {
        public manageForm()
        {
            InitializeComponent();
        }


        private void manageForm_Load(object sender, EventArgs e)
        {
            string dataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string dataSubPath = Path.Combine(dataDirectory, @"FLCrooksSOManager\");
            // Read the orders from the XML files
            List<Order> orderList = ReadOrdersFromXmlFiles(dataSubPath);

            // Add the orders to the ListBox
            foreach (Order order in orderList)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    order.ID.ToString(),
                    order.FirstName,
                    order.LastName,
                    order.PhoneNumber,
                    order.Price.ToString("C2"),
                    order.DatePlaced.ToString("MM-dd-yyyy"),
                    order.OrderPlaced ? "Yes" : "No",
                    order.Paid ? "Yes" : "No"
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

        private List<Order> ReadOrdersFromXmlFiles(string directoryPath)
        {
            List<Order> orderList = new List<Order>();

            foreach (string filePath in Directory.EnumerateFiles(directoryPath, "*.xml"))
            {
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(filePath);

                    Order order = new Order();
                    order.ID = int.Parse(xmlDoc.SelectSingleNode("//ID").InnerText);
                    order.FirstName = xmlDoc.SelectSingleNode("//First_Name").InnerText;
                    order.LastName = xmlDoc.SelectSingleNode("//Last_Name").InnerText;
                    order.PhoneNumber = xmlDoc.SelectSingleNode("//Phone_Number").InnerText;
                    order.Description = xmlDoc.SelectSingleNode("//Description").InnerText;
                    order.Price = decimal.Parse(xmlDoc.SelectSingleNode("//Price").InnerText.Replace("$", ""));
                    order.Paid = xmlDoc.SelectSingleNode("//Paid").InnerText.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                    order.DatePlaced = DateTime.Parse(xmlDoc.SelectSingleNode("//Date").InnerText);
                    order.OrderPlaced = xmlDoc.SelectSingleNode("//Placed").InnerText.Equals("Yes", StringComparison.OrdinalIgnoreCase);

                    orderList.Add(order);
                }
                catch (Exception ex)
                {
                    // Log the error or display an error message
                    Console.WriteLine($"Error loading file {filePath}: {ex.Message}");
                }
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
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                editBtn.Enabled = true;
            }
            else
            {
                editBtn.Enabled = false;
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Extract the details from the selected item
                string id = selectedItem.SubItems[0].Text;
                string firstName = selectedItem.SubItems[1].Text;
                string lastName = selectedItem.SubItems[2].Text;
                string phoneNumber = selectedItem.SubItems[3].Text;
                string price = selectedItem.SubItems[4].Text;
                string datePlaced = selectedItem.SubItems[5].Text;
                string orderPlaced = selectedItem.SubItems[6].Text;
                string paid = selectedItem.SubItems[7].Text;

                // Create a new form to show the details
                OrderDetailsForm orderDetailsForm = new OrderDetailsForm(id, firstName, lastName, phoneNumber, price, datePlaced, orderPlaced, paid);
                orderDetailsForm.ShowDialog();
            }
        }
    }
}
