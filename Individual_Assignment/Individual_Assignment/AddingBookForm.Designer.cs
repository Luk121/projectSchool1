namespace Individual_Assignment
{
    partial class AddingBookForm
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
            this.TitletextBox = new System.Windows.Forms.TextBox();
            this.AuthortextBox = new System.Windows.Forms.TextBox();
            this.ISBNtextBox = new System.Windows.Forms.TextBox();
            this.DescriptiontextBox = new System.Windows.Forms.TextBox();
            this.PublishDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownOfBookPieces = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOfBookPieces)).BeginInit();
            this.SuspendLayout();
            // 
            // TitletextBox
            // 
            this.TitletextBox.Location = new System.Drawing.Point(144, 97);
            this.TitletextBox.Name = "TitletextBox";
            this.TitletextBox.Size = new System.Drawing.Size(431, 27);
            this.TitletextBox.TabIndex = 0;
            // 
            // AuthortextBox
            // 
            this.AuthortextBox.Location = new System.Drawing.Point(144, 148);
            this.AuthortextBox.Name = "AuthortextBox";
            this.AuthortextBox.Size = new System.Drawing.Size(431, 27);
            this.AuthortextBox.TabIndex = 1;
            // 
            // ISBNtextBox
            // 
            this.ISBNtextBox.Location = new System.Drawing.Point(144, 197);
            this.ISBNtextBox.Name = "ISBNtextBox";
            this.ISBNtextBox.Size = new System.Drawing.Size(431, 27);
            this.ISBNtextBox.TabIndex = 2;
            // 
            // DescriptiontextBox
            // 
            this.DescriptiontextBox.Location = new System.Drawing.Point(144, 303);
            this.DescriptiontextBox.Multiline = true;
            this.DescriptiontextBox.Name = "DescriptiontextBox";
            this.DescriptiontextBox.Size = new System.Drawing.Size(431, 128);
            this.DescriptiontextBox.TabIndex = 3;
            // 
            // PublishDatePicker
            // 
            this.PublishDatePicker.Location = new System.Drawing.Point(144, 250);
            this.PublishDatePicker.Name = "PublishDatePicker";
            this.PublishDatePicker.Size = new System.Drawing.Size(256, 27);
            this.PublishDatePicker.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(53, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pub. Date.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description";
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Location = new System.Drawing.Point(189, 448);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(336, 48);
            this.AddBookBtn.TabIndex = 10;
            this.AddBookBtn.Text = "Add a Book";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(304, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Add a Book ";
            // 
            // numericUpDownOfBookPieces
            // 
            this.numericUpDownOfBookPieces.Location = new System.Drawing.Point(425, 250);
            this.numericUpDownOfBookPieces.Name = "numericUpDownOfBookPieces";
            this.numericUpDownOfBookPieces.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownOfBookPieces.TabIndex = 12;
            // 
            // AddingBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 536);
            this.Controls.Add(this.numericUpDownOfBookPieces);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddBookBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PublishDatePicker);
            this.Controls.Add(this.DescriptiontextBox);
            this.Controls.Add(this.ISBNtextBox);
            this.Controls.Add(this.AuthortextBox);
            this.Controls.Add(this.TitletextBox);
            this.Name = "AddingBookForm";
            this.Text = "AddingBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOfBookPieces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TitletextBox;
        private TextBox AuthortextBox;
        private TextBox ISBNtextBox;
        private TextBox DescriptiontextBox;
        private DateTimePicker PublishDatePicker;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button AddBookBtn;
        private Label label6;
        private NumericUpDown numericUpDownOfBookPieces;
    }
}