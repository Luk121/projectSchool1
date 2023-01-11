namespace Individual_Assignment.UserControls
{
    partial class UserControlBookAdmin
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
            this.ShowPageBtn = new System.Windows.Forms.Button();
            this.Author = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.DeleteBookBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowPageBtn
            // 
            this.ShowPageBtn.Location = new System.Drawing.Point(441, 3);
            this.ShowPageBtn.Name = "ShowPageBtn";
            this.ShowPageBtn.Size = new System.Drawing.Size(193, 58);
            this.ShowPageBtn.TabIndex = 5;
            this.ShowPageBtn.Text = "Show more";
            this.ShowPageBtn.UseVisualStyleBackColor = true;
            this.ShowPageBtn.Click += new System.EventHandler(this.ShowPageBtn_Click);
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Author.Location = new System.Drawing.Point(35, 33);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(52, 19);
            this.Author.TabIndex = 4;
            this.Author.Text = "Author";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(33, 2);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(55, 28);
            this.Title.TabIndex = 3;
            this.Title.Text = "Title";
            // 
            // DeleteBookBtn
            // 
            this.DeleteBookBtn.Location = new System.Drawing.Point(15, 69);
            this.DeleteBookBtn.Name = "DeleteBookBtn";
            this.DeleteBookBtn.Size = new System.Drawing.Size(158, 30);
            this.DeleteBookBtn.TabIndex = 8;
            this.DeleteBookBtn.Text = "Delete Book";
            this.DeleteBookBtn.UseVisualStyleBackColor = true;
            this.DeleteBookBtn.Click += new System.EventHandler(this.DeleteBookBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(277, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(211, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 6;
            // 
            // UserControlBookAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteBookBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShowPageBtn);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Title);
            this.Name = "UserControlBookAdmin";
            this.Size = new System.Drawing.Size(651, 105);
            this.Load += new System.EventHandler(this.UserControlBookAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ShowPageBtn;
        private Label Author;
        private Label Title;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button DeleteBookBtn;
    }
}
