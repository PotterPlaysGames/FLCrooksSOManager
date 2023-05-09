using System.Windows.Forms.VisualStyles;

namespace FLCrooksSOManager
{
    partial class settingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            bw_updateChecker = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            button1 = new Button();
            buildLbl = new Label();
            authorNameLbl = new Label();
            titleLbl = new Label();
            authorLbl = new Label();
            versionLbl = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // bw_updateChecker
            // 
            bw_updateChecker.DoWork += bw_updateChecker_DoWork;
            bw_updateChecker.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(buildLbl);
            groupBox1.Controls.Add(authorNameLbl);
            groupBox1.Controls.Add(titleLbl);
            groupBox1.Controls.Add(authorLbl);
            groupBox1.Controls.Add(versionLbl);
            groupBox1.Location = new Point(48, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 166);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "App Info";
            // 
            // button1
            // 
            button1.Location = new Point(109, 112);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 5;
            button1.Text = "Check for updates?";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // buildLbl
            // 
            buildLbl.AutoSize = true;
            buildLbl.Location = new Point(151, 94);
            buildLbl.Name = "buildLbl";
            buildLbl.Size = new Size(0, 15);
            buildLbl.TabIndex = 4;
            buildLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authorNameLbl
            // 
            authorNameLbl.AutoSize = true;
            authorNameLbl.Location = new Point(132, 70);
            authorNameLbl.Name = "authorNameLbl";
            authorNameLbl.Size = new Size(69, 15);
            authorNameLbl.TabIndex = 3;
            authorNameLbl.Text = "Aidan Potter";
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Location = new Point(67, 29);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(172, 15);
            titleLbl.TabIndex = 2;
            titleLbl.Text = "FL Crooks Speical Order Manager";
            // 
            // authorLbl
            // 
            authorLbl.AutoSize = true;
            authorLbl.Location = new Point(41, 70);
            authorLbl.Name = "authorLbl";
            authorLbl.Size = new Size(45, 15);
            authorLbl.TabIndex = 1;
            authorLbl.Text = "Author:";
            // 
            // versionLbl
            // 
            versionLbl.AutoSize = true;
            versionLbl.Location = new Point(41, 94);
            versionLbl.Name = "versionLbl";
            versionLbl.Size = new Size(46, 15);
            versionLbl.TabIndex = 0;
            versionLbl.Text = "Version:";
            // 
            // settingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(401, 450);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "settingsForm";
            Text = "Settings";
            Load += settingsForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker bw_updateChecker;
        private GroupBox groupBox1;
        private Label buildLbl;
        private Label authorNameLbl;
        private Label titleLbl;
        private Label authorLbl;
        private Label versionLbl;
        private Button button1;
    }
}