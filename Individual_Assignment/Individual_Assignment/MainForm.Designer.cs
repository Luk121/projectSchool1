namespace Individual_Assignment
{
    partial class MainForm
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
            this.LogOut = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Button();
            this.SearchLibrary = new System.Windows.Forms.Button();
            this.ChildFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.childPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(15, 473);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(229, 58);
            this.LogOut.TabIndex = 8;
            this.LogOut.Text = "Log out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Profile
            // 
            this.Profile.Location = new System.Drawing.Point(15, 166);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(229, 58);
            this.Profile.TabIndex = 6;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // SearchLibrary
            // 
            this.SearchLibrary.Location = new System.Drawing.Point(15, 90);
            this.SearchLibrary.Name = "SearchLibrary";
            this.SearchLibrary.Size = new System.Drawing.Size(229, 58);
            this.SearchLibrary.TabIndex = 5;
            this.SearchLibrary.Text = "Search Library";
            this.SearchLibrary.UseVisualStyleBackColor = true;
            this.SearchLibrary.Click += new System.EventHandler(this.SearchLibrary_Click);
            // 
            // ChildFlowPanel
            // 
            this.ChildFlowPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChildFlowPanel.Location = new System.Drawing.Point(250, 1);
            this.ChildFlowPanel.Name = "ChildFlowPanel";
            this.ChildFlowPanel.Size = new System.Drawing.Size(0, 0);
            this.ChildFlowPanel.TabIndex = 9;
            // 
            // childPanel
            // 
            this.childPanel.Location = new System.Drawing.Point(250, 0);
            this.childPanel.Name = "childPanel";
            this.childPanel.Size = new System.Drawing.Size(748, 583);
            this.childPanel.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 582);
            this.Controls.Add(this.childPanel);
            this.Controls.Add(this.ChildFlowPanel);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.SearchLibrary);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button LogOut;
        private Button Profile;
        private Button SearchLibrary;
        private FlowLayoutPanel ChildFlowPanel;
        private Panel childPanel;
    }
}