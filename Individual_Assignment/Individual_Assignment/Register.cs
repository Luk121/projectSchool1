using Individual_Assignment.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Assignment
{
    public partial class Register : Form
    {
        Library _library;
        Login login;
        public Register(Library library, Login login)
        {
            this.login = login;
            _library = library;
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }


        private void BackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextbox.Text;
            string password1 = password1Textbox.Text;
            string password2 = password2Textbox.Text;
            if (password1 != password2)
            {
                warningLabel.Text = "Passwords do not match!";
                return;
            }
            string UUID = Guid.NewGuid().ToString();
            bool success =_library.AddMember(password1, name, UUID);
            if (success)
            {
                warningLabel.Text = "Member succesfully created!";
            } else
            {
                warningLabel.Text = "Password is not strong enough!";
            }
        }
    }
}
