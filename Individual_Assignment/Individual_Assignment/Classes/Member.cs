using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Individual_Assignment.Classes
{
    public class Member
    {
        public string Name { get; private set; }
        public string Id { get; } 
        public string Password { get; private set; }
        public Book? CurrentBook { get; private set; }
        public List<Loan> Loans = new List<Loan>();

        public Member(string Name, string Id, string Password)
        {
            this.Name = Name;
            this.Id = Id;
            this.Password = Password;
        }

        public void AddLoan(Loan loan)
        {
            Loans.Add(loan);
        }

        public void ReturnBook()
        {
            if(CurrentBook != null)
            {
                CurrentBook = null;
            }
        }

        public void ChangeName(string name)
        {
            Name = name;
        }

        public bool SetPassword(string password)
        {
            Regex validateGuidRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            if (validateGuidRegex.IsMatch(password))
            {
                Password = password;
                return true;
            }
            return false;
        }
    }
}
