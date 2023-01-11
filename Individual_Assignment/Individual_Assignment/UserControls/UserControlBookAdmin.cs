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

namespace Individual_Assignment.UserControls
{
    public partial class UserControlBookAdmin : UserControl
    {
        MainAdminForm AdminForm;
        Book book;
        Library library;
        Member member;
        SearchLibrary searchLibrary;
        public UserControlBookAdmin(MainAdminForm Form, Book book, Member member, Library library, SearchLibrary searchLibrary)
        {
            this.AdminForm = Form;
            this.book = book;
            this.library = library;
            this.member = member;
            this.searchLibrary = searchLibrary;
            InitializeComponent();
        }


        private void UserControlBookAdmin_Load(object sender, EventArgs e)
        {
            Title.Text = book.Title;
            Author.Text = book.Author;
        }

        private void ShowPageBtn_Click(object sender, EventArgs e)
        {
            if (AdminForm != null)
            {
                AdminForm.OpenChildForm(new BookDetails(book, member, library, AdminForm));
            }
        }

        private void DeleteBookBtn_Click(object sender, EventArgs e)
        {
            library.DeleteBookFromDatabase(book);
            searchLibrary.SearchLibrary_Load(sender, EventArgs.Empty);
        }
    }
}
