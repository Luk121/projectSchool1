using Individual_Assignment.Classes;
using Individual_Assignment.UserControls;
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
    public partial class SearchLibrary : Form
    {
        Library library;
        MainForm? mainForm;
        MainAdminForm? adminForm;
        Member member;
        public SearchLibrary(Library library, MainForm MemberForm, Member member)
        {
            this.library = library;
            this.mainForm = MemberForm;
            this.member = member;
            InitializeComponent();
        }
        public SearchLibrary(Library library, MainAdminForm adminForm, Member member)
        {
            this.library=library;
            this.adminForm = adminForm;
            this.member = member;
            InitializeComponent();
        }

        public void SearchLibrary_Load(object sender, EventArgs e)
        {
            SearchBookFlow.Controls.Clear();
            if (library.GetShowcaseBooks().Count() >= 1)
            {
                if(mainForm is MainForm)
                {
                    foreach (Book book in library.GetShowcaseBooks())
                    {
                        SearchBookFlow.Controls.Add(new UserControlBook(mainForm, book, member, library));
                    }
                }
                if(adminForm is MainAdminForm)
                {
                    foreach (Book book in library.GetShowcaseBooks())
                    {
                        SearchBookFlow.Controls.Add(new UserControlBookAdmin(adminForm, book, member, library, this));
                    }
                }
            }
        }
    }
}
