namespace FLCrooksSOManager
{
    partial class EditOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOrderForm));
            idEditLbl = new Label();
            fNameLbl = new Label();
            lNameLbl = new Label();
            pNumLbl = new Label();
            descLbl = new Label();
            idTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            descriptionTextBox = new RichTextBox();
            priceTextBox = new TextBox();
            label1 = new Label();
            paidCheckBox = new CheckBox();
            orderPlacedCheckBox = new CheckBox();
            label2 = new Label();
            datePlacedDateTimePicker = new DateTimePicker();
            saveButton = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // idEditLbl
            // 
            resources.ApplyResources(idEditLbl, "idEditLbl");
            idEditLbl.Name = "idEditLbl";
            idEditLbl.Click += idEditLbl_Click;
            // 
            // fNameLbl
            // 
            resources.ApplyResources(fNameLbl, "fNameLbl");
            fNameLbl.Name = "fNameLbl";
            // 
            // lNameLbl
            // 
            resources.ApplyResources(lNameLbl, "lNameLbl");
            lNameLbl.Name = "lNameLbl";
            // 
            // pNumLbl
            // 
            resources.ApplyResources(pNumLbl, "pNumLbl");
            pNumLbl.Name = "pNumLbl";
            // 
            // descLbl
            // 
            resources.ApplyResources(descLbl, "descLbl");
            descLbl.Name = "descLbl";
            // 
            // idTextBox
            // 
            resources.ApplyResources(idTextBox, "idTextBox");
            idTextBox.Name = "idTextBox";
            // 
            // firstNameTextBox
            // 
            resources.ApplyResources(firstNameTextBox, "firstNameTextBox");
            firstNameTextBox.Name = "firstNameTextBox";
            // 
            // lastNameTextBox
            // 
            resources.ApplyResources(lastNameTextBox, "lastNameTextBox");
            lastNameTextBox.Name = "lastNameTextBox";
            // 
            // phoneNumberTextBox
            // 
            resources.ApplyResources(phoneNumberTextBox, "phoneNumberTextBox");
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            // 
            // descriptionTextBox
            // 
            resources.ApplyResources(descriptionTextBox, "descriptionTextBox");
            descriptionTextBox.Name = "descriptionTextBox";
            // 
            // priceTextBox
            // 
            resources.ApplyResources(priceTextBox, "priceTextBox");
            priceTextBox.Name = "priceTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // paidCheckBox
            // 
            resources.ApplyResources(paidCheckBox, "paidCheckBox");
            paidCheckBox.Name = "paidCheckBox";
            paidCheckBox.UseVisualStyleBackColor = true;
            // 
            // orderPlacedCheckBox
            // 
            resources.ApplyResources(orderPlacedCheckBox, "orderPlacedCheckBox");
            orderPlacedCheckBox.Name = "orderPlacedCheckBox";
            orderPlacedCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // datePlacedDateTimePicker
            // 
            resources.ApplyResources(datePlacedDateTimePicker, "datePlacedDateTimePicker");
            datePlacedDateTimePicker.Format = DateTimePickerFormat.Short;
            datePlacedDateTimePicker.Name = "datePlacedDateTimePicker";
            // 
            // saveButton
            // 
            resources.ApplyResources(saveButton, "saveButton");
            saveButton.Name = "saveButton";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click_1;
            // 
            // cancelBtn
            // 
            resources.ApplyResources(cancelBtn, "cancelBtn");
            cancelBtn.Name = "cancelBtn";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // EditOrderForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(cancelBtn);
            Controls.Add(saveButton);
            Controls.Add(datePlacedDateTimePicker);
            Controls.Add(label2);
            Controls.Add(orderPlacedCheckBox);
            Controls.Add(paidCheckBox);
            Controls.Add(label1);
            Controls.Add(priceTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(idTextBox);
            Controls.Add(descLbl);
            Controls.Add(pNumLbl);
            Controls.Add(lNameLbl);
            Controls.Add(fNameLbl);
            Controls.Add(idEditLbl);
            Name = "EditOrderForm";
            ResumeLayout(false);
            PerformLayout();
            FormClosing += EditOrderForm_FormClosing;
        }

        #endregion

        private Label idEditLbl;
        private Label fNameLbl;
        private Label lNameLbl;
        private Label pNumLbl;
        private Label descLbl;
        private TextBox idTextBox;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox phoneNumberTextBox;
        private RichTextBox descriptionTextBox;
        private TextBox priceTextBox;
        private Label label1;
        private CheckBox paidCheckBox;
        private CheckBox orderPlacedCheckBox;
        private Label label2;
        private DateTimePicker datePlacedDateTimePicker;
        private Button saveButton;
        private Button cancelBtn;
    }
}