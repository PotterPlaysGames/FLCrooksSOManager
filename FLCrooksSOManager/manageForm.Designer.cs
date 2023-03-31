namespace FLCrooksSOManager
{
    partial class manageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageForm));
            newOrderBtnMgr = new Button();
            editBtn = new Button();
            listView1 = new ListView();
            ID = new ColumnHeader();
            FirstName = new ColumnHeader();
            LastName = new ColumnHeader();
            PhoneNumber = new ColumnHeader();
            Price = new ColumnHeader();
            DatePlaced = new ColumnHeader();
            Paid = new ColumnHeader();
            Placed = new ColumnHeader();
            SuspendLayout();
            // 
            // newOrderBtnMgr
            // 
            newOrderBtnMgr.Location = new Point(633, 39);
            newOrderBtnMgr.Name = "newOrderBtnMgr";
            newOrderBtnMgr.Size = new Size(112, 35);
            newOrderBtnMgr.TabIndex = 2;
            newOrderBtnMgr.Text = "New Order";
            newOrderBtnMgr.UseVisualStyleBackColor = true;
            newOrderBtnMgr.Click += newOrderBtnMgr_Click;
            // 
            // editBtn
            // 
            editBtn.Enabled = false;
            editBtn.Location = new Point(633, 383);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(112, 35);
            editBtn.TabIndex = 3;
            editBtn.Text = "Edit Order";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ID, FirstName, LastName, PhoneNumber, Price, DatePlaced, Paid, Placed });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 80);
            listView1.Name = "listView1";
            listView1.Size = new Size(733, 297);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ColumnClick += listView1_ColumnClick;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 30;
            // 
            // FirstName
            // 
            FirstName.Text = "First Name";
            FirstName.TextAlign = HorizontalAlignment.Center;
            FirstName.Width = 120;
            // 
            // LastName
            // 
            LastName.Text = "Last Name";
            LastName.TextAlign = HorizontalAlignment.Center;
            LastName.Width = 120;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Text = "Phone Number";
            PhoneNumber.TextAlign = HorizontalAlignment.Center;
            PhoneNumber.Width = 110;
            // 
            // Price
            // 
            Price.Text = "Price";
            Price.TextAlign = HorizontalAlignment.Center;
            // 
            // DatePlaced
            // 
            DatePlaced.Text = "Date Added";
            DatePlaced.TextAlign = HorizontalAlignment.Center;
            DatePlaced.Width = 120;
            // 
            // Paid
            // 
            Paid.Text = "Paid?";
            Paid.TextAlign = HorizontalAlignment.Center;
            // 
            // Placed
            // 
            Placed.Text = "Order Placed?";
            Placed.TextAlign = HorizontalAlignment.Center;
            Placed.Width = 100;
            // 
            // manageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(754, 442);
            Controls.Add(listView1);
            Controls.Add(editBtn);
            Controls.Add(newOrderBtnMgr);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "manageForm";
            Text = "Manage";
            Load += manageForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button newOrderBtnMgr;
        private Button editBtn;
        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private ColumnHeader PhoneNumber;
        private ColumnHeader Price;
        private ColumnHeader DatePlaced;
        private ColumnHeader Placed;
        private ColumnHeader Paid;
    }
}