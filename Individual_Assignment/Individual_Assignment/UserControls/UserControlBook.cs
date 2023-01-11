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
    public partial class UserControlBook : UserControl
    {
        MainForm MainForm;  
        Book book;
        Library library;
        Member member;

        //we need member for creating loan
        public UserControlBook(MainForm Form, Book book, Member member, Library library)
        {
            this.MainForm = Form;
            this.book = book;
            this.library = library; 
            this.member = member;
            InitializeComponent();
        }

        private void ShowPageBtn_Click(object sender, EventArgs e)
        {
            if(MainForm != null)
            {
                MainForm.OpenChildForm(new BookDetails(book, member, library, MainForm));
            }
        }

        private void UserControlBook_Load(object sender, EventArgs e)
        {
            Title.Text = book.Title;
            Author.Text = book.Author;
        }
    }
}
