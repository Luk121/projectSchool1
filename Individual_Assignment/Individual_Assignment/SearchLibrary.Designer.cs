namespace Individual_Assignment
{
    partial class SearchLibrary
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
            this.SearchBookFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchBookTextBox = new System.Windows.Forms.TextBox();
            this.SearchBookBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchBookFlow
            // 
            this.SearchBookFlow.Location = new System.Drawing.Point(10, 12);
            this.SearchBookFlow.Name = "SearchBookFlow";
            this.SearchBookFlow.Size = new System.Drawing.Size(695, 468);
            this.SearchBookFlow.TabIndex = 0;
            // 
            // SearchBookTextBox
            // 
            this.SearchBookTextBox.Location = new System.Drawing.Point(12, 493);
            this.SearchBookTextBox.Name = "SearchBookTextBox";
            this.SearchBookTextBox.Size = new System.Drawing.Size(549, 27);
            this.SearchBookTextBox.TabIndex = 1;
            // 
            // SearchBookBtn
            // 
            this.SearchBookBtn.Location = new System.Drawing.Point(572, 488);
            this.SearchBookBtn.Name = "SearchBookBtn";
            this.SearchBookBtn.Size = new System.Drawing.Size(133, 40);
            this.SearchBookBtn.TabIndex = 2;
            this.SearchBookBtn.Text = "Search a book";
            this.SearchBookBtn.UseVisualStyleBackColor = true;
            // 
            // SearchLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 536);
            this.Controls.Add(this.SearchBookBtn);
            this.Controls.Add(this.SearchBookTextBox);
            this.Controls.Add(this.SearchBookFlow);
            this.Name = "SearchLibrary";
            this.Text = "SearchLibrary";
            this.Load += new System.EventHandler(this.SearchLibrary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel SearchBookFlow;
        private TextBox SearchBookTextBox;
        private Button SearchBookBtn;
    }
}