using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Assignment.Classes
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }

        public string? Id = null;
        public string Publication_Date { get; }
        public string ISBN { get; }
        public string Description { get; }
        public bool lended = false;
        public string? Current_Borrower { get; private set; } = null;
        private  List<Loan> Loans = new List<Loan>();

        public Book(string ISBN, string Title, string Author, string Publication_Date,
            string Description)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
            this.Author = Author;
            this.Publication_Date = Publication_Date;
            this.Description = Description;
            createId();
        }

        private void createId()
        {
           string id = Guid.NewGuid().ToString();
           this.Id = id;
        }
        public void AddId(string Id)
        {
            this.Id = Id;
        }

        //showcase books
        public void AddLoan(Loan loan)
        {
            Loans.Add(loan);
        }

        #region loanTheBook
        public void isBeingLended(Member member)
        {
            Current_Borrower = member.Name + member.Id;
            lended = true;
        }

        public void ReturnBook()
        {
            lended = false;
            Current_Borrower = null;
        }

        public void AddCurrentBorrower(Member member)
        {
            this.Current_Borrower = member.ToString();
        }
        #endregion

        public List<Loan> GetListOfLoans()
        {
            return Loans;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
