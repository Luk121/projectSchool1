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
    public partial class MainForm : Form
    {
        private Login login;
        private Library library;
        private Form? activeForm;
        private Member member;
        public MainForm(Login login, Library library, Member member)
        {
            this.login = login;
            this.library = library;
            this.member = member;
            InitializeComponent();
        }


        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.childPanel.Controls.Add(childForm);
            this.childPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new SearchLibrary(library, this, member));
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void SearchLibrary_Click(object sender, EventArgs e)
        {
            if (!(activeForm is SearchLibrary))
            {
                OpenChildForm(new SearchLibrary(library, this, member));
            }
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            if (!(activeForm is Profile))
            {
                OpenChildForm(new Profile(member));
            }
        }

    }
}
