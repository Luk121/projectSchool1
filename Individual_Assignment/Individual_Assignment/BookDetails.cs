using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Individual_Assignment.Classes;

namespace Individual_Assignment
{
    public partial class BookDetails : Form
    {
        Book book;
        Member member;
        Library library;
        MainAdminForm? mainAdminForm;
        MainForm? mainForm;
        private int availabilityBook = 0;
        public BookDetails(Book book, Member member, Library library, MainAdminForm adminForm)
        {
            this.book = book;
            this.member = member;
            this.library = library;
            this.mainAdminForm = adminForm;
            InitializeComponent();
        }

        public BookDetails(Book book, Member member, Library library, MainForm mainForm)
        {
            this.book = book;
            this.member = member;
            this.library = library;
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void SetLabels()
        {
            Title.Text = book.Title;
            Author.Text = book.Author;
            isbn.Text = book.ISBN;
            PubDate.Text = book.Publication_Date;
            Description.Text = book.Description;
            availability.Text = "Availability: " + availabilityBook;
        }

        private void BookDetails_Load(object sender, EventArgs e)
        {
            //book availability
            int counter = 0;
            foreach(Book bookAvailable in library.GetAvailableBooks())
            {
                if(book.ISBN == bookAvailable.ISBN && bookAvailable.lended == false)
                {
                    counter++;
                }
            }
            availabilityBook = counter;

            // loan history
            foreach(Book bookLoan in library.GetShowcaseBooks())
            {
                if(book.ISBN == bookLoan.ISBN && bookLoan.GetListOfLoans().Count > 0)
                {
                    foreach(Loan bookLoanLoan in bookLoan.GetListOfLoans())
                    {
                        HistoryLoans.Items.Add(bookLoanLoan);
                    }
                }
            }
            SetLabels();
        }

        private void LendBtn_Click(object sender, EventArgs e)
        {
            foreach(Book availBook in library.GetAvailableBooks())
            {
                if(availBook.ISBN == book.ISBN && !availBook.lended)
                {
                    string id = Guid.NewGuid().ToString();
                    Loan loan = new Loan(id, availBook, member);
                    member.AddLoan(loan);
                    book.AddLoan(loan);
                    availabilityBook--;
                    availability.Text = "Availability: " + availabilityBook;
                    break;
                }
            }
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            if(mainForm != null)
            {
                mainForm.OpenChildForm(new SearchLibrary(library, mainForm, member));
            } else if(mainAdminForm != null)
            {
                mainAdminForm.OpenChildForm(new SearchLibrary(library, mainAdminForm, member));
            }
        }
    }
}
