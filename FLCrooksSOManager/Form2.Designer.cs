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
            settingsTabs = new TabControl();
            appInfo = new TabPage();
            updateTab = new TabPage();
            updateAvTxt = new Label();
            newVerLblTxt = new Label();
            newVersionLbl = new Label();
            updateBtn = new Button();
            prevVerLblTxt = new Label();
            curVersionLbl = new Label();
            bw_updateChecker = new System.ComponentModel.BackgroundWorker();
            settingsTabs.SuspendLayout();
            updateTab.SuspendLayout();
            SuspendLayout();
            // 
            // settingsTabs
            // 
            settingsTabs.Controls.Add(appInfo);
            settingsTabs.Controls.Add(updateTab);
            settingsTabs.Location = new Point(12, 12);
            settingsTabs.Name = "settingsTabs";
            settingsTabs.SelectedIndex = 0;
            settingsTabs.Size = new Size(377, 426);
            settingsTabs.TabIndex = 1;
            // 
            // appInfo
            // 
            appInfo.Location = new Point(4, 24);
            appInfo.Name = "appInfo";
            appInfo.Size = new Size(369, 398);
            appInfo.TabIndex = 0;
            appInfo.Text = "App Info";
            appInfo.UseVisualStyleBackColor = true;
            // 
            // updateTab
            // 
            updateTab.Controls.Add(updateAvTxt);
            updateTab.Controls.Add(newVerLblTxt);
            updateTab.Controls.Add(newVersionLbl);
            updateTab.Controls.Add(updateBtn);
            updateTab.Controls.Add(prevVerLblTxt);
            updateTab.Controls.Add(curVersionLbl);
            updateTab.Location = new Point(4, 24);
            updateTab.Name = "updateTab";
            updateTab.Size = new Size(369, 398);
            updateTab.TabIndex = 1;
            updateTab.Text = "Update";
            updateTab.UseVisualStyleBackColor = true;
            // 
            // updateAvTxt
            // 
            updateAvTxt.AutoSize = true;
            updateAvTxt.Location = new Point(81, 283);
            updateAvTxt.Name = "updateAvTxt";
            updateAvTxt.Size = new Size(0, 15);
            updateAvTxt.TabIndex = 5;
            // 
            // newVerLblTxt
            // 
            newVerLblTxt.AutoSize = true;
            newVerLblTxt.Location = new Point(129, 172);
            newVerLblTxt.Name = "newVerLblTxt";
            newVerLblTxt.Size = new Size(0, 15);
            newVerLblTxt.TabIndex = 4;
            // 
            // newVersionLbl
            // 
            newVersionLbl.AutoSize = true;
            newVersionLbl.Location = new Point(132, 117);
            newVersionLbl.Name = "newVersionLbl";
            newVersionLbl.Size = new Size(72, 15);
            newVersionLbl.TabIndex = 3;
            newVersionLbl.Text = "New Version:";
            // 
            // updateBtn
            // 
            updateBtn.Enabled = false;
            updateBtn.Location = new Point(129, 227);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 23);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // prevVerLblTxt
            // 
            prevVerLblTxt.AutoSize = true;
            prevVerLblTxt.Location = new Point(129, 63);
            prevVerLblTxt.Name = "prevVerLblTxt";
            prevVerLblTxt.Size = new Size(0, 15);
            prevVerLblTxt.TabIndex = 1;
            // 
            // curVersionLbl
            // 
            curVersionLbl.AutoSize = true;
            curVersionLbl.Location = new Point(129, 42);
            curVersionLbl.Name = "curVersionLbl";
            curVersionLbl.Size = new Size(86, 15);
            curVersionLbl.TabIndex = 0;
            curVersionLbl.Text = "Current Version:";
            // 
            // bw_updateChecker
            // 
            bw_updateChecker.DoWork += bw_updateChecker_DoWork;
            bw_updateChecker.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // settingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(401, 450);
            Controls.Add(settingsTabs);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            Name = "settingsForm";
            Text = "Settings";
            Load += settingsForm_Load;
            settingsTabs.ResumeLayout(false);
            updateTab.ResumeLayout(false);
            updateTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl settingsTabs;
        private TabPage appInfo;
        private TabPage updateTab;
        private Label prevVerLblTxt;
        private Label curVersionLbl;
        private Label newVerLblTxt;
        private Label newVersionLbl;
        private Button updateBtn;
        private Label updateAvTxt;
        private System.ComponentModel.BackgroundWorker bw_updateChecker;
    }
}