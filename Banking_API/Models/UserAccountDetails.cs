using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Banking_API.Models
{
    public partial class UserAccountDetails
    {
        public UserAccountDetails()
        {
            PayeeDetails = new HashSet<PayeeDetails>();
            Transactions = new HashSet<Transactions>();
            UserLogIn = new HashSet<UserLogIn>();
        }

        public int AccountId { get; set; }
        public int CustomerId { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? AccOpDate { get; set; }
        public bool? AccountStatus { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual ICollection<PayeeDetails> PayeeDetails { get; set; }
        public virtual ICollection<Transactions> Transactions { get; set; }
        public virtual ICollection<UserLogIn> UserLogIn { get; set; }
    }
}
