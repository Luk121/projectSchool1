namespace Individual_Assignment
{
    partial class Profile
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
            this.label1 = new System.Windows.Forms.Label();
            this.HistoryLoans = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Currentloans = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(312, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile";
            // 
            // HistoryLoans
            // 
            this.HistoryLoans.FormattingEnabled = true;
            this.HistoryLoans.ItemHeight = 20;
            this.HistoryLoans.Location = new System.Drawing.Point(421, 151);
            this.HistoryLoans.Name = "HistoryLoans";
            this.HistoryLoans.Size = new System.Drawing.Size(273, 364);
            this.HistoryLoans.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "History of loans";
            // 
            // Currentloans
            // 
            this.Currentloans.Location = new System.Drawing.Point(12, 151);
            this.Currentloans.Name = "Currentloans";
            this.Currentloans.Size = new System.Drawing.Size(392, 364);
            this.Currentloans.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current loans";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 536);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Currentloans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HistoryLoans);
            this.Controls.Add(this.label1);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox HistoryLoans;
        private Label label2;
        private Panel Currentloans;
        private Label label3;
    }
}