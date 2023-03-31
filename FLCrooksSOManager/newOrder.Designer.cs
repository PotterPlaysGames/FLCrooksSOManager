namespace FLCrooksSOManager
{
    partial class newOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newOrderForm));
            custInfo = new GroupBox();
            example = new Label();
            pNumberTxtBox = new TextBox();
            pNumberLbl = new Label();
            lNameTxtBox = new TextBox();
            lNameLbl = new Label();
            fNameTxtBox = new TextBox();
            fNameLbl = new Label();
            servicesAndDesc = new GroupBox();
            descLbl2 = new Label();
            descLbl = new Label();
            descBox = new RichTextBox();
            orderInfo = new GroupBox();
            orderPlacedCheck = new CheckBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            paidCheck = new CheckBox();
            priceTxtBox = new TextBox();
            priceLbl = new Label();
            Cancel = new Button();
            createOrder = new Button();
            label2 = new Label();
            label3 = new Label();
            custInfo.SuspendLayout();
            servicesAndDesc.SuspendLayout();
            orderInfo.SuspendLayout();
            SuspendLayout();
            // 
            // custInfo
            // 
            custInfo.Controls.Add(example);
            custInfo.Controls.Add(pNumberTxtBox);
            custInfo.Controls.Add(pNumberLbl);
            custInfo.Controls.Add(lNameTxtBox);
            custInfo.Controls.Add(lNameLbl);
            custInfo.Controls.Add(fNameTxtBox);
            custInfo.Controls.Add(fNameLbl);
            custInfo.Location = new Point(35, 30);
            custInfo.Name = "custInfo";
            custInfo.Size = new Size(398, 172);
            custInfo.TabIndex = 0;
            custInfo.TabStop = false;
            custInfo.Text = "Customer Information";
            // 
            // example
            // 
            example.AutoSize = true;
            example.Location = new Point(104, 111);
            example.Name = "example";
            example.Size = new Size(152, 15);
            example.TabIndex = 6;
            example.Text = "(ex. 8885558888 or 8885555)";
            // 
            // pNumberTxtBox
            // 
            pNumberTxtBox.Location = new Point(198, 82);
            pNumberTxtBox.Name = "pNumberTxtBox";
            pNumberTxtBox.Size = new Size(100, 23);
            pNumberTxtBox.TabIndex = 5;
            // 
            // pNumberLbl
            // 
            pNumberLbl.AutoSize = true;
            pNumberLbl.Location = new Point(92, 85);
            pNumberLbl.Name = "pNumberLbl";
            pNumberLbl.Size = new Size(96, 15);
            pNumberLbl.TabIndex = 4;
            pNumberLbl.Text = "*Phone Number:";
            // 
            // lNameTxtBox
            // 
            lNameTxtBox.Location = new Point(270, 28);
            lNameTxtBox.Name = "lNameTxtBox";
            lNameTxtBox.Size = new Size(100, 23);
            lNameTxtBox.TabIndex = 3;
            // 
            // lNameLbl
            // 
            lNameLbl.AutoSize = true;
            lNameLbl.Location = new Point(198, 31);
            lNameLbl.Name = "lNameLbl";
            lNameLbl.Size = new Size(71, 15);
            lNameLbl.TabIndex = 2;
            lNameLbl.Text = "*Last Name:";
            // 
            // fNameTxtBox
            // 
            fNameTxtBox.Location = new Point(92, 28);
            fNameTxtBox.Name = "fNameTxtBox";
            fNameTxtBox.Size = new Size(100, 23);
            fNameTxtBox.TabIndex = 1;
            // 
            // fNameLbl
            // 
            fNameLbl.AutoSize = true;
            fNameLbl.Location = new Point(19, 31);
            fNameLbl.Name = "fNameLbl";
            fNameLbl.Size = new Size(72, 15);
            fNameLbl.TabIndex = 0;
            fNameLbl.Text = "*First Name:";
            // 
            // servicesAndDesc
            // 
            servicesAndDesc.Controls.Add(descLbl2);
            servicesAndDesc.Controls.Add(descLbl);
            servicesAndDesc.Controls.Add(descBox);
            servicesAndDesc.Location = new Point(35, 226);
            servicesAndDesc.Name = "servicesAndDesc";
            servicesAndDesc.Size = new Size(398, 186);
            servicesAndDesc.TabIndex = 1;
            servicesAndDesc.TabStop = false;
            servicesAndDesc.Text = "*Description";
            // 
            // descLbl2
            // 
            descLbl2.AutoSize = true;
            descLbl2.Location = new Point(56, 33);
            descLbl2.Name = "descLbl2";
            descLbl2.Size = new Size(291, 15);
            descLbl2.TabIndex = 2;
            descLbl2.Text = "(Ex. Brand, Item Type, Style, Color, Style Number, Size)";
            descLbl2.Click += descLbl2_Click;
            // 
            // descLbl
            // 
            descLbl.AutoSize = true;
            descLbl.Location = new Point(43, 19);
            descLbl.Name = "descLbl";
            descLbl.Size = new Size(304, 15);
            descLbl.TabIndex = 1;
            descLbl.Text = "Please enter the description of the order you are placing.";
            // 
            // descBox
            // 
            descBox.Location = new Point(19, 51);
            descBox.Name = "descBox";
            descBox.Size = new Size(351, 119);
            descBox.TabIndex = 0;
            descBox.Text = "";
            // 
            // orderInfo
            // 
            orderInfo.Controls.Add(orderPlacedCheck);
            orderInfo.Controls.Add(label1);
            orderInfo.Controls.Add(dateTimePicker1);
            orderInfo.Controls.Add(paidCheck);
            orderInfo.Controls.Add(priceTxtBox);
            orderInfo.Controls.Add(priceLbl);
            orderInfo.Location = new Point(461, 30);
            orderInfo.Name = "orderInfo";
            orderInfo.Size = new Size(327, 172);
            orderInfo.TabIndex = 2;
            orderInfo.TabStop = false;
            orderInfo.Text = "Order Info";
            // 
            // orderPlacedCheck
            // 
            orderPlacedCheck.AutoSize = true;
            orderPlacedCheck.Location = new Point(222, 121);
            orderPlacedCheck.Name = "orderPlacedCheck";
            orderPlacedCheck.Size = new Size(99, 19);
            orderPlacedCheck.TabIndex = 5;
            orderPlacedCheck.Text = "Order Placed?";
            orderPlacedCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 85);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 4;
            label1.Text = "Date order entered:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(121, 82);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.Value = new DateTime(2023, 3, 31, 0, 0, 0, 0);
            // 
            // paidCheck
            // 
            paidCheck.AutoSize = true;
            paidCheck.Location = new Point(222, 30);
            paidCheck.Name = "paidCheck";
            paidCheck.Size = new Size(54, 19);
            paidCheck.TabIndex = 2;
            paidCheck.Text = "Paid?";
            paidCheck.UseVisualStyleBackColor = true;
            // 
            // priceTxtBox
            // 
            priceTxtBox.Location = new Point(78, 28);
            priceTxtBox.Name = "priceTxtBox";
            priceTxtBox.Size = new Size(100, 23);
            priceTxtBox.TabIndex = 1;
            priceTxtBox.TextAlign = HorizontalAlignment.Right;
            // 
            // priceLbl
            // 
            priceLbl.AutoSize = true;
            priceLbl.Location = new Point(19, 31);
            priceLbl.Name = "priceLbl";
            priceLbl.Size = new Size(58, 15);
            priceLbl.TabIndex = 0;
            priceLbl.Text = "*Price ($):";
            // 
            // Cancel
            // 
            Cancel.Location = new Point(653, 341);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(129, 55);
            Cancel.TabIndex = 3;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // createOrder
            // 
            createOrder.Location = new Point(468, 341);
            createOrder.Name = "createOrder";
            createOrder.Size = new Size(129, 55);
            createOrder.TabIndex = 4;
            createOrder.Text = "Create Order";
            createOrder.UseVisualStyleBackColor = true;
            createOrder.Click += createOrder_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(572, 277);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 5;
            label2.Text = "REMINDER:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(466, 307);
            label3.Name = "label3";
            label3.Size = new Size(322, 15);
            label3.TabIndex = 6;
            label3.Text = "All items with an \" * \" next to is required to create an order!";
            // 
            // newOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(createOrder);
            Controls.Add(Cancel);
            Controls.Add(orderInfo);
            Controls.Add(servicesAndDesc);
            Controls.Add(custInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "newOrderForm";
            Text = "New Order";
            Load += newOrderForm_Load;
            custInfo.ResumeLayout(false);
            custInfo.PerformLayout();
            servicesAndDesc.ResumeLayout(false);
            servicesAndDesc.PerformLayout();
            orderInfo.ResumeLayout(false);
            orderInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox custInfo;
        private Label example;
        private TextBox pNumberTxtBox;
        private Label pNumberLbl;
        private TextBox lNameTxtBox;
        private Label lNameLbl;
        private TextBox fNameTxtBox;
        private Label fNameLbl;
        private GroupBox servicesAndDesc;
        private Label descLbl2;
        private Label descLbl;
        private RichTextBox descBox;
        private GroupBox orderInfo;
        private TextBox priceTxtBox;
        private Label priceLbl;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private CheckBox paidCheck;
        private CheckBox orderPlacedCheck;
        private Button Cancel;
        private Button createOrder;
        private Label label2;
        private Label label3;
    }
}