namespace Individual_Assignment
{
    partial class BookDetails
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
            this.Title = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PubDate = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.HistoryLoans = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.availability = new System.Windows.Forms.Label();
            this.LendBtn = new System.Windows.Forms.Button();
            this.GoBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(25, 34);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(55, 28);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Author.Location = new System.Drawing.Point(29, 67);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(52, 20);
            this.Author.TabIndex = 1;
            this.Author.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ISBN:";
            // 
            // isbn
            // 
            this.isbn.AutoSize = true;
            this.isbn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.isbn.Location = new System.Drawing.Point(83, 106);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(40, 20);
            this.isbn.TabIndex = 3;
            this.isbn.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pub. Date.:";
            // 
            // PubDate
            // 
            this.PubDate.AutoSize = true;
            this.PubDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.PubDate.Location = new System.Drawing.Point(125, 137);
            this.PubDate.Name = "PubDate";
            this.PubDate.Size = new System.Drawing.Size(75, 20);
            this.PubDate.TabIndex = 5;
            this.PubDate.Text = "Pub. Date.";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(32, 207);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Size = new System.Drawing.Size(636, 116);
            this.Description.TabIndex = 6;
            // 
            // HistoryLoans
            // 
            this.HistoryLoans.FormattingEnabled = true;
            this.HistoryLoans.ItemHeight = 20;
            this.HistoryLoans.Location = new System.Drawing.Point(34, 365);
            this.HistoryLoans.Name = "HistoryLoans";
            this.HistoryLoans.Size = new System.Drawing.Size(422, 164);
            this.HistoryLoans.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "History of loans";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(551, 122);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(104, 20);
            this.label.TabIndex = 10;
            this.label.Text = "Lend the book";
            // 
            // availability
            // 
            this.availability.AutoSize = true;
            this.availability.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.availability.Location = new System.Drawing.Point(555, 160);
            this.availability.Name = "availability";
            this.availability.Size = new System.Drawing.Size(103, 20);
            this.availability.TabIndex = 11;
            this.availability.Text = "Availability: x";
            // 
            // LendBtn
            // 
            this.LendBtn.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LendBtn.Location = new System.Drawing.Point(528, 53);
            this.LendBtn.Name = "LendBtn";
            this.LendBtn.Size = new System.Drawing.Size(152, 61);
            this.LendBtn.TabIndex = 12;
            this.LendBtn.Text = "Lend";
            this.LendBtn.UseVisualStyleBackColor = true;
            this.LendBtn.Click += new System.EventHandler(this.LendBtn_Click);
            // 
            // GoBack
            // 
            this.GoBack.AutoSize = true;
            this.GoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBack.Font = new System.Drawing.Font("Segoe UI", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.GoBack.Location = new System.Drawing.Point(10, 9);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(74, 19);
            this.GoBack.TabIndex = 13;
            this.GoBack.Text = "< Go Back";
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // BookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 536);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.LendBtn);
            this.Controls.Add(this.availability);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HistoryLoans);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.PubDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Title);
            this.Name = "BookDetails";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BookDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Label Author;
        private Label label1;
        private Label isbn;
        private Label label2;
        private Label PubDate;
        private TextBox Description;
        private ListBox HistoryLoans;
        private Label label3;
        private Label label4;
        private Label label;
        private Label availability;
        private Label GoBack;
        private Button LendBtn;
    }
}