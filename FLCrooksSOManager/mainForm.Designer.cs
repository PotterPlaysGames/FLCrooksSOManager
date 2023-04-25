namespace FLCrooksSOManager
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            mainPageLabel = new Label();
            flcrooksLogo = new PictureBox();
            settingsIcon = new PictureBox();
            newOrderBtn = new Button();
            manageBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)flcrooksLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settingsIcon).BeginInit();
            SuspendLayout();
            // 
            // mainPageLabel
            // 
            mainPageLabel.Anchor = AnchorStyles.Top;
            mainPageLabel.AutoSize = true;
            mainPageLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            mainPageLabel.Location = new Point(216, 169);
            mainPageLabel.Name = "mainPageLabel";
            mainPageLabel.Size = new Size(375, 26);
            mainPageLabel.TabIndex = 0;
            mainPageLabel.Text = "Special Order Management System";
            // 
            // flcrooksLogo
            // 
            flcrooksLogo.Anchor = AnchorStyles.Top;
            flcrooksLogo.BackColor = SystemColors.Control;
            flcrooksLogo.Image = Properties.Resources.R;
            flcrooksLogo.Location = new Point(216, 12);
            flcrooksLogo.Name = "flcrooksLogo";
            flcrooksLogo.Size = new Size(372, 154);
            flcrooksLogo.SizeMode = PictureBoxSizeMode.Zoom;
            flcrooksLogo.TabIndex = 1;
            flcrooksLogo.TabStop = false;
            // 
            // settingsIcon
            // 
            settingsIcon.Cursor = Cursors.Hand;
            settingsIcon.Enabled = false;
            settingsIcon.Image = Properties.Resources.cogwheel_configuration_options_parameters_properties_settings_1320165735121041526;
            settingsIcon.Location = new Point(731, 388);
            settingsIcon.Name = "settingsIcon";
            settingsIcon.Size = new Size(57, 50);
            settingsIcon.SizeMode = PictureBoxSizeMode.Zoom;
            settingsIcon.TabIndex = 2;
            settingsIcon.TabStop = false;
            settingsIcon.Visible = false;
            settingsIcon.Click += settingsIcon_Click;
            // 
            // newOrderBtn
            // 
            newOrderBtn.Anchor = AnchorStyles.Right;
            newOrderBtn.AutoSize = true;
            newOrderBtn.Cursor = Cursors.Hand;
            newOrderBtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            newOrderBtn.Location = new Point(77, 250);
            newOrderBtn.Name = "newOrderBtn";
            newOrderBtn.Size = new Size(179, 94);
            newOrderBtn.TabIndex = 3;
            newOrderBtn.Text = "New Order";
            newOrderBtn.UseVisualStyleBackColor = true;
            newOrderBtn.Click += newOrderBtn_Click;
            // 
            // manageBtn
            // 
            manageBtn.Anchor = AnchorStyles.Left;
            manageBtn.AutoSize = true;
            manageBtn.Cursor = Cursors.Hand;
            manageBtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            manageBtn.Location = new Point(547, 250);
            manageBtn.Name = "manageBtn";
            manageBtn.Size = new Size(179, 94);
            manageBtn.TabIndex = 4;
            manageBtn.Text = "Manage";
            manageBtn.UseVisualStyleBackColor = true;
            manageBtn.Click += manageBtn_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(manageBtn);
            Controls.Add(newOrderBtn);
            Controls.Add(settingsIcon);
            Controls.Add(flcrooksLogo);
            Controls.Add(mainPageLabel);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MaximumSize = new Size(1000, 500);
            MinimumSize = new Size(816, 489);
            Name = "mainForm";
            Text = "F.L. Crooks S.O.M.S";
            ((System.ComponentModel.ISupportInitialize)flcrooksLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)settingsIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainPageLabel;
        private PictureBox flcrooksLogo;
        private PictureBox settingsIcon;
        private Button newOrderBtn;
        private Button manageBtn;
    }
}