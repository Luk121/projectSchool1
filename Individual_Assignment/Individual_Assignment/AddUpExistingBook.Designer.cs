namespace Individual_Assignment
{
    partial class AddUpExistingBook
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
            this.CollectionOfDatabase = new System.Windows.Forms.ComboBox();
            this.numericUpDownStock = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddUpBooks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).BeginInit();
            this.SuspendLayout();
            // 
            // CollectionOfDatabase
            // 
            this.CollectionOfDatabase.FormattingEnabled = true;
            this.CollectionOfDatabase.Location = new System.Drawing.Point(56, 165);
            this.CollectionOfDatabase.Name = "CollectionOfDatabase";
            this.CollectionOfDatabase.Size = new System.Drawing.Size(608, 28);
            this.CollectionOfDatabase.TabIndex = 0;
            // 
            // numericUpDownStock
            // 
            this.numericUpDownStock.Location = new System.Drawing.Point(56, 262);
            this.numericUpDownStock.Name = "numericUpDownStock";
            this.numericUpDownStock.Size = new System.Drawing.Size(266, 27);
            this.numericUpDownStock.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a book from collection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of pieces";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // AddUpBooks
            // 
            this.AddUpBooks.Location = new System.Drawing.Point(202, 386);
            this.AddUpBooks.Name = "AddUpBooks";
            this.AddUpBooks.Size = new System.Drawing.Size(288, 67);
            this.AddUpBooks.TabIndex = 5;
            this.AddUpBooks.Text = "Add To stock";
            this.AddUpBooks.UseVisualStyleBackColor = true;
            this.AddUpBooks.Click += new System.EventHandler(this.AddUpBooks_Click);
            // 
            // AddUpExistingBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 536);
            this.Controls.Add(this.AddUpBooks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownStock);
            this.Controls.Add(this.CollectionOfDatabase);
            this.Name = "AddUpExistingBook";
            this.Text = "AddUpExistingBook";
            this.Load += new System.EventHandler(this.AddUpExistingBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox CollectionOfDatabase;
        private NumericUpDown numericUpDownStock;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button AddUpBooks;
    }
}