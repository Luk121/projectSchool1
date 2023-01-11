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

namespace Individual_Assignment.UserControls
{
    public partial class CurrentLoanUserControl : UserControl
    {
        Profile profile;
        Classes.Loan loan;
        public CurrentLoanUserControl(Loan loan, Profile profile)
        {
            this.profile = profile;
            this.loan = loan;
            InitializeComponent();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            loan.returnBook();
            profile.updateLoans();
        }

        private void CurrentLoanUserControl_Load(object sender, EventArgs e)
        {
            Title.Text = loan.book.Title;
            Author.Text = loan.book.Author;
        }
    }
}
