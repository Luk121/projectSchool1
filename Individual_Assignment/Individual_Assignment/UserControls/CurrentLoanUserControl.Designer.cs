namespace Individual_Assignment.UserControls
{
    partial class CurrentLoanUserControl
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
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(272, 56);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(104, 38);
            this.ReturnBtn.TabIndex = 0;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(9, 22);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(51, 20);
            this.Title.TabIndex = 1;
            this.Title.Text = "label1";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(9, 65);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(50, 20);
            this.Author.TabIndex = 2;
            this.Author.Text = "label2";
            // 
            // CurrentLoanUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ReturnBtn);
            this.Name = "CurrentLoanUserControl";
            this.Size = new System.Drawing.Size(392, 109);
            this.Load += new System.EventHandler(this.CurrentLoanUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ReturnBtn;
        private Label Title;
        private Label Author;
    }
}
