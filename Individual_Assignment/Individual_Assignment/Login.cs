using Individual_Assignment.Classes;
using Microsoft.VisualBasic.ApplicationServices;

namespace Individual_Assignment
{
    public partial class Login : Form
    {
        Library _library = new Library();
        MainForm? main;
        MainAdminForm? mainAdmin;
        public Login()
        {
            InitializeComponent();
            _library.AddMember("b7/@W[ZZ=3gEehU", "Lukas Buncak", "124132c24");
            _library.AddMember("b7/@W[ZZ=3gEehU", "Member1", "124e132c24");
            _library.AddMember("b7/@W[ZZ=3gEehU", "Member2", "124e132c242");
            _library.AddMember("b7/@W[ZZ=3gEehU", "Member3", "124e132c243");
        }

        private void ToRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register(_library, this);
            reg.Closed += (s, args) => this.Close();
            reg.Show();
        }

        private Member? GetMember(string username, string userPassword)
        {
            foreach(Member member in _library.GetMembers())
            {
                if(member.Name == username && member.Password == userPassword)
                {
                    return member;
                }
            }
            return null;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameLogin.Text != "" && passwordLogin.Text != "")
            {
                Member? returnedUser = GetMember(usernameLogin.Text, passwordLogin.Text);
                if (returnedUser is Member)
                {
                    if (main is MainForm || mainAdmin is MainAdminForm) { main = null; mainAdmin = null; }
                    if (returnedUser is Member && returnedUser.Id == _library.GetMembers()[0].Id)
                    {
                        usernameLogin.Text = ""; passwordLogin.Text = "";
                        this.Hide();
                        mainAdmin = new MainAdminForm(this, _library, returnedUser);
                        mainAdmin.Closed += (s, args) => this.Close();
                        mainAdmin.Show();
                        return;
                    }
                    if(returnedUser is Member && returnedUser.Id != _library.GetMembers()[0].Id)
                    {
                        usernameLogin.Text = ""; passwordLogin.Text = "";
                        this.Hide();
                        main = new MainForm(this, _library, returnedUser);
                        main.Closed += (s, args) => this.Close();
                        main.Show();
                    }
                   

                }

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //deserialization
        }
    }
}