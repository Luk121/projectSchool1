namespace Individual_Assignment.UserControls
{
    partial class UserControlBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.ShowPageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(34, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(55, 28);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Author.Location = new System.Drawing.Point(34, 40);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(52, 19);
            this.Author.TabIndex = 1;
            this.Author.Text = "Author";
            // 
            // ShowPageBtn
            // 
            this.ShowPageBtn.Location = new System.Drawing.Point(423, 12);
            this.ShowPageBtn.Name = "ShowPageBtn";
            this.ShowPageBtn.Size = new System.Drawing.Size(193, 58);
            this.ShowPageBtn.TabIndex = 2;
            this.ShowPageBtn.Text = "Show more";
            this.ShowPageBtn.UseVisualStyleBackColor = true;
            this.ShowPageBtn.Click += new System.EventHandler(this.ShowPageBtn_Click);
            // 
            // UserControlBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShowPageBtn);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Title);
            this.Name = "UserControlBook";
            this.Size = new System.Drawing.Size(651, 83);
            this.Load += new System.EventHandler(this.UserControlBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Label Author;
        private Button ShowPageBtn;
    }
}
