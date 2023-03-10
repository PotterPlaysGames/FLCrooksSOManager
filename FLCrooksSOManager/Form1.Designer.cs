namespace FLCrooksSOManager
{
    partial class Form1
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
            mainPageLabel = new Label();
            SuspendLayout();
            // 
            // mainPageLabel
            // 
            mainPageLabel.AutoSize = true;
            mainPageLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            mainPageLabel.Location = new Point(165, 52);
            mainPageLabel.Name = "mainPageLabel";
            mainPageLabel.Size = new Size(502, 26);
            mainPageLabel.TabIndex = 0;
            mainPageLabel.Text = "F.L. Crooks Special Order Management System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainPageLabel);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "F.L. Crooks S.O.M.S";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainPageLabel;
    }
}