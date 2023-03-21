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

        }
        public static void itemListAdder()
        {
            string dataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(dataDirectory))
                Directory.CreateDirectory(dataDirectory);
            string dataSubPath = Path.Combine(dataDirectory, @"FLCrooksSOManager\");
            if (!Directory.Exists(dataSubPath))
                Directory.CreateDirectory(dataSubPath);
            if(Directory.GetFiles(dataSubPath).Length > 0)
            {
                var files = Directory.GetFiles(dataSubPath, "*.xml", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    var doc = XDocument.Load(file);
                }
            }

        }
    }
}
