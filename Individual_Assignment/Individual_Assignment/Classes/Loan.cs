using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Assignment.Classes
{
    public class Loan
    {
        public string Id { get; }
        public Book book { get; }
        public Member member { get; }

        public bool returned = false;

        public Loan(string id, Book book, Member member)
        {
            Id = id;
            this.book = book;
            this.member = member;
            createLoan(member);
        }

        private void createLoan(Member member)
        {
            book.isBeingLended(member);
        }

        public void returnBook()
        {
            returned = true;
            book.ReturnBook();
        }

        public override string ToString()
        {
            return member.Name + "," + Id;
        }
    }
}
