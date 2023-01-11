namespace Individual_Assignment
{
    partial class Register
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
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.password1Textbox = new System.Windows.Forms.TextBox();
            this.password2Textbox = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.BackToLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextbox.Location = new System.Drawing.Point(75, 50);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(306, 27);
            this.nameTextbox.TabIndex = 0;
            // 
            // password1Textbox
            // 
            this.password1Textbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password1Textbox.Location = new System.Drawing.Point(75, 111);
            this.password1Textbox.Name = "password1Textbox";
            this.password1Textbox.Size = new System.Drawing.Size(306, 27);
            this.password1Textbox.TabIndex = 1;
            // 
            // password2Textbox
            // 
            this.password2Textbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password2Textbox.Location = new System.Drawing.Point(75, 168);
            this.password2Textbox.Name = "password2Textbox";
            this.password2Textbox.Size = new System.Drawing.Size(306, 27);
            this.password2Textbox.TabIndex = 2;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterBtn.Location = new System.Drawing.Point(128, 231);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(201, 47);
            this.RegisterBtn.TabIndex = 3;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // BackToLogin
            // 
            this.BackToLogin.AutoSize = true;
            this.BackToLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.BackToLogin.Location = new System.Drawing.Point(165, 296);
            this.BackToLogin.Name = "BackToLogin";
            this.BackToLogin.Size = new System.Drawing.Size(126, 20);
            this.BackToLogin.TabIndex = 4;
            this.BackToLogin.Text = "Go back to Log in";
            this.BackToLogin.Click += new System.EventHandler(this.BackToLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(77, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(75, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(77, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Repeat password";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(381, 244);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 20);
            this.warningLabel.TabIndex = 8;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(663, 348);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackToLogin);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.password2Textbox);
            this.Controls.Add(this.password1Textbox);
            this.Controls.Add(this.nameTextbox);
            this.Name = "Register";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameTextbox;
        private TextBox password1Textbox;
        private TextBox password2Textbox;
        private Button RegisterBtn;
        private Label BackToLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label warningLabel;
    }
}