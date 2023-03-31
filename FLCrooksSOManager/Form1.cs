using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLCrooksSOManager
{
    public partial class OrderDetailsForm : Form
    {
        private string id;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string price;
        private string datePlaced;
        private string orderPlaced;
        private string paid;

        public OrderDetailsForm()
        {
            InitializeComponent();
        }

        public OrderDetailsForm(string id, string firstName, string lastName, string phoneNumber, string price, string datePlaced, string orderPlaced, string paid)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.price = price;
            this.datePlaced = datePlaced;
            this.orderPlaced = orderPlaced;
            this.paid = paid;
        }
    }
}
