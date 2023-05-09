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
            Description = new ColumnHeader();
            deleteBtn = new Button();
            searchBox = new TextBox();
            searchLbl = new Label();
            SuspendLayout();
            // 
            // newOrderBtnMgr
            // 
            newOrderBtnMgr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            newOrderBtnMgr.AutoSize = true;
            newOrderBtnMgr.Location = new Point(779, 39);
            newOrderBtnMgr.Name = "newOrderBtnMgr";
            newOrderBtnMgr.Size = new Size(112, 35);
            newOrderBtnMgr.TabIndex = 2;
            newOrderBtnMgr.Text = "New Order";
            newOrderBtnMgr.UseVisualStyleBackColor = true;
            newOrderBtnMgr.Click += newOrderBtnMgr_Click;
            // 
            // editBtn
            // 
            editBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editBtn.AutoSize = true;
            editBtn.Enabled = false;
            editBtn.Location = new Point(782, 383);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(112, 35);
            editBtn.TabIndex = 3;
            editBtn.Text = "Edit Order";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top;
            listView1.Columns.AddRange(new ColumnHeader[] { ID, FirstName, LastName, PhoneNumber, Price, DatePlaced, Paid, Placed, Description });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 80);
            listView1.Name = "listView1";
            listView1.Size = new Size(882, 297);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ColumnClick += listView1_ColumnClick;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.DoubleClick += listView1_DoubleClick;
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
            Price.Width = 70;
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
            // Description
            // 
            Description.Text = "Description";
            Description.TextAlign = HorizontalAlignment.Center;
            Description.Width = 145;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            deleteBtn.AutoSize = true;
            deleteBtn.Enabled = false;
            deleteBtn.Location = new Point(12, 383);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(112, 35);
            deleteBtn.TabIndex = 5;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top;
            searchBox.Location = new Point(281, 46);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(346, 23);
            searchBox.TabIndex = 6;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // searchLbl
            // 
            searchLbl.AutoSize = true;
            searchLbl.Location = new Point(225, 49);
            searchLbl.Name = "searchLbl";
            searchLbl.Size = new Size(45, 15);
            searchLbl.TabIndex = 7;
            searchLbl.Text = "Search:";
            // 
            // manageForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(903, 442);
            Controls.Add(searchLbl);
            Controls.Add(searchBox);
            Controls.Add(deleteBtn);
            Controls.Add(listView1);
            Controls.Add(editBtn);
            Controls.Add(newOrderBtnMgr);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(919, 481);
            Name = "manageForm";
            Text = "Manage";
            FormClosing += manageForm_FormClosing;
            Load += manageForm_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private ColumnHeader Description;
        private Button deleteBtn;
        private TextBox searchBox;
        private Label searchLbl;
    }
}