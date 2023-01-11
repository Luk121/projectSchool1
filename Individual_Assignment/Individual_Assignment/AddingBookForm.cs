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
    public partial class AddingBookForm : Form
    {
        Classes.Library library;
        public AddingBookForm(Classes.Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            string title = TitletextBox.Text;
            string author = AuthortextBox.Text;
            string ISBN = ISBNtextBox.Text;
            string pubDate = PublishDatePicker.Text;
            string description = DescriptiontextBox.Text;
            int Numberofpieces = (int)numericUpDownOfBookPieces.Value;
            library.AddBook(ISBN, title, author, pubDate, description, Numberofpieces);
        }
    }
}
