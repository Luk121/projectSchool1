using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Individual_Assignment.Classes
{
    public class Library
    {
        private List<Member> members = new List<Member>();
        private List<Book> books = new List<Book>();
        private List<Book> showcaseBooks = new List<Book>();
        
        public bool AddMember(string password, string name, string id)
        {
            Regex validateGuidRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            if (!validateGuidRegex.IsMatch(password))
            {
                return false;
            }
            Member member = new Member(name, id, password);
            members.Add(member);
            return true;
        }

        //first initialization of book to database
        public void AddBook(string ISBN, string Title, string Author, string Pub_Date, string Description, int NumberOfCopies)
        {
            Book Showcasebook = new Book(ISBN, Title, Author, Pub_Date, Description);
            showcaseBooks.Add(Showcasebook);
            for(int i = 0; i < NumberOfCopies; i++)
            {
                Book book = new Book(ISBN, Title, Author, Pub_Date, Description);
                books.Add(book);
            }
        }
        //for existing 
        public void AddBook(Book book, int NumberOfCopies)
        {
            string ISBN = book.ISBN;
            string Title = book.Title;
            string Author = book.Author;
            string Pub_Date = book.Publication_Date;
            string Description = book.Description;
            for (int i = 0; i < NumberOfCopies; i++)
            {
                Book bookcopy = new Book(ISBN, Title, Author, Pub_Date, Description);
                books.Add(bookcopy);
            }
        }

        public void DeleteBookFromDatabase(Book book)
        {
            foreach(Book bookdelete in this.books.ToList())
            {
                if(bookdelete.ISBN == book.ISBN)
                {
                    books.Remove(bookdelete);
                }
            }
            foreach(Book bookdelete in this.showcaseBooks)
            {
                if (bookdelete.ISBN == book.ISBN)
                {
                    books.Remove(bookdelete);
                }
                break;
            }
        }


        public List<Member> GetMembers()
        {
            return members;
        }

        public List<Book> GetShowcaseBooks()
        {
            return showcaseBooks;
        }

        public List<Book> GetAvailableBooks()
        {
            return books;
        }


    }
}
