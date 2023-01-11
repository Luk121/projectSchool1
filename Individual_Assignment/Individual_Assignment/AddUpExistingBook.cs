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
    public partial class AddUpExistingBook : Form
    {
        Library _library;
        public AddUpExistingBook(Library library)
        {
            _library = library;
            InitializeComponent();
        }

        private void AddUpBooks_Click(object sender, EventArgs e)
        {
            if(_library.GetShowcaseBooks().Count >= 1)
            {
                Book selectedBook = (Book)CollectionOfDatabase.SelectedItem;
                int numberOfCopies = (int)Math.Floor(numericUpDownStock.Value);
                _library.AddBook(selectedBook, numberOfCopies);
            }
        }

        private void AddUpExistingBook_Load(object sender, EventArgs e)
        {
            if(_library.GetShowcaseBooks().Count >= 1)
            {
                foreach (Book book in _library.GetShowcaseBooks())
                {
                    CollectionOfDatabase.Items.Add(book);
                }
                CollectionOfDatabase.SelectedIndex = 0;
            }
        }
    }
}
