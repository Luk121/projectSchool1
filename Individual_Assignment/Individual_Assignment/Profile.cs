﻿using System;
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
    public partial class Profile : Form
    {
        Classes.Member member;
        public Profile(Classes.Member member)
        {
            this.member = member;
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            updateLoans();
        }

        public void updateLoans()
        {
            Currentloans.Controls.Clear();
            foreach (Classes.Loan loan in member.Loans)
            {
                if (loan.returned == false)
                {
                    Currentloans.Controls.Add(new UserControls.CurrentLoanUserControl(loan, this));
                }
                else
                {
                    HistoryLoans.Items.Add(loan);
                }
            }
        }
    }
}
