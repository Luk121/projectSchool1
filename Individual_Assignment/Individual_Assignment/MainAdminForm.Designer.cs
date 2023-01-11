namespace Individual_Assignment
{
    partial class MainAdminForm
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
            this.AddingBook = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Button();
            this.SearchLibrary = new System.Windows.Forms.Button();
            this.StockUp = new System.Windows.Forms.Button();
            this.childPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(16, 466);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(229, 58);
            this.LogOut.TabIndex = 8;
            this.LogOut.Text = "Log out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // AddingBook
            // 
            this.AddingBook.Location = new System.Drawing.Point(16, 245);
            this.AddingBook.Name = "AddingBook";
            this.AddingBook.Size = new System.Drawing.Size(229, 58);
            this.AddingBook.TabIndex = 7;
            this.AddingBook.Text = "Adding a Book";
            this.AddingBook.UseVisualStyleBackColor = true;
            this.AddingBook.Click += new System.EventHandler(this.AddingBook_Click);
            // 
            // Profile
            // 
            this.Profile.Location = new System.Drawing.Point(16, 169);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(229, 58);
            this.Profile.TabIndex = 6;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // SearchLibrary
            // 
            this.SearchLibrary.Location = new System.Drawing.Point(16, 93);
            this.SearchLibrary.Name = "SearchLibrary";
            this.SearchLibrary.Size = new System.Drawing.Size(229, 58);
            this.SearchLibrary.TabIndex = 5;
            this.SearchLibrary.Text = "Search Library";
            this.SearchLibrary.UseVisualStyleBackColor = true;
            this.SearchLibrary.Click += new System.EventHandler(this.SearchLibrary_Click);
            // 
            // StockUp
            // 
            this.StockUp.Location = new System.Drawing.Point(16, 323);
            this.StockUp.Name = "StockUp";
            this.StockUp.Size = new System.Drawing.Size(229, 58);
            this.StockUp.TabIndex = 9;
            this.StockUp.Text = "Stock up the books";
            this.StockUp.UseVisualStyleBackColor = true;
            this.StockUp.Click += new System.EventHandler(this.StockUp_Click);
            // 
            // childPanel
            // 
            this.childPanel.Location = new System.Drawing.Point(261, 0);
            this.childPanel.Name = "childPanel";
            this.childPanel.Size = new System.Drawing.Size(735, 583);
            this.childPanel.TabIndex = 10;
            // 
            // MainAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 582);
            this.Controls.Add(this.childPanel);
            this.Controls.Add(this.StockUp);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.AddingBook);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.SearchLibrary);
            this.Name = "MainAdminForm";
            this.Text = "MainAdminForm";
            this.ResumeLayout(false);

        }

        #endregion
        private Button LogOut;
        private Button AddingBook;
        private Button Profile;
        private Button SearchLibrary;
        private Button StockUp;
        private Panel childPanel;
    }
}