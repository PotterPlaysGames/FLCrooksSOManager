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
            orderList = new ListView();
            id = new ColumnHeader();
            fNameColomn = new ColumnHeader();
            lNameColumn = new ColumnHeader();
            pNumColumn = new ColumnHeader();
            priceColumn = new ColumnHeader();
            paidColumn = new ColumnHeader();
            dateColumn = new ColumnHeader();
            placedColumn = new ColumnHeader();
            refreshList = new Button();
            newOrderBtnMgr = new Button();
            editBtn = new Button();
            SuspendLayout();
            // 
            // orderList
            // 
            orderList.Columns.AddRange(new ColumnHeader[] { id, fNameColomn, lNameColumn, pNumColumn, priceColumn, paidColumn, dateColumn, placedColumn });
            orderList.FullRowSelect = true;
            orderList.GridLines = true;
            orderList.Location = new Point(12, 80);
            orderList.Name = "orderList";
            orderList.Size = new Size(776, 308);
            orderList.TabIndex = 0;
            orderList.UseCompatibleStateImageBehavior = false;
            orderList.View = View.Details;
            // 
            // id
            // 
            id.Text = "ID:";
            id.Width = 30;
            // 
            // fNameColomn
            // 
            fNameColomn.Text = "First Name:";
            fNameColomn.TextAlign = HorizontalAlignment.Center;
            fNameColomn.Width = 120;
            // 
            // lNameColumn
            // 
            lNameColumn.Text = "Last Name:";
            lNameColumn.TextAlign = HorizontalAlignment.Center;
            lNameColumn.Width = 120;
            // 
            // pNumColumn
            // 
            pNumColumn.Text = "Phone Number:";
            pNumColumn.TextAlign = HorizontalAlignment.Center;
            pNumColumn.Width = 100;
            // 
            // priceColumn
            // 
            priceColumn.Text = "Price ($):";
            priceColumn.TextAlign = HorizontalAlignment.Center;
            priceColumn.Width = 100;
            // 
            // paidColumn
            // 
            paidColumn.Text = "Paid?";
            paidColumn.TextAlign = HorizontalAlignment.Center;
            paidColumn.Width = 50;
            // 
            // dateColumn
            // 
            dateColumn.Text = "Date Placed:";
            dateColumn.TextAlign = HorizontalAlignment.Center;
            dateColumn.Width = 150;
            // 
            // placedColumn
            // 
            placedColumn.Text = "Order Placed?";
            placedColumn.TextAlign = HorizontalAlignment.Center;
            placedColumn.Width = 100;
            // 
            // refreshList
            // 
            refreshList.Location = new Point(12, 39);
            refreshList.Name = "refreshList";
            refreshList.Size = new Size(112, 35);
            refreshList.TabIndex = 1;
            refreshList.Text = "Refresh";
            refreshList.UseVisualStyleBackColor = true;
            // 
            // newOrderBtnMgr
            // 
            newOrderBtnMgr.Location = new Point(676, 39);
            newOrderBtnMgr.Name = "newOrderBtnMgr";
            newOrderBtnMgr.Size = new Size(112, 35);
            newOrderBtnMgr.TabIndex = 2;
            newOrderBtnMgr.Text = "New Order";
            newOrderBtnMgr.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            editBtn.Enabled = false;
            editBtn.Location = new Point(676, 394);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(112, 35);
            editBtn.TabIndex = 3;
            editBtn.Text = "Edit Order";
            editBtn.UseVisualStyleBackColor = true;
            // 
            // manageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(editBtn);
            Controls.Add(newOrderBtnMgr);
            Controls.Add(refreshList);
            Controls.Add(orderList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "manageForm";
            Text = "Manage";
            Load += manageForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView orderList;
        private ColumnHeader id;
        private ColumnHeader fNameColomn;
        private ColumnHeader lNameColumn;
        private ColumnHeader pNumColumn;
        private ColumnHeader priceColumn;
        private ColumnHeader paidColumn;
        private ColumnHeader dateColumn;
        private ColumnHeader placedColumn;
        private Button refreshList;
        private Button newOrderBtnMgr;
        private Button editBtn;
    }
}