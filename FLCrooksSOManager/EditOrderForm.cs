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

        public EditOrderForm(Order order, XmlDocument xmlDoc)
        {
            InitializeComponent();
        }


        private void saveButton_Click_1(object sender, EventArgs e)
        {

        }

        private void idEditLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
