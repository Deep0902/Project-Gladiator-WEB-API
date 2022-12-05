using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Banking_API.Models
{
    public partial class Transactions
    {
        public int TransactionId { get; set; }
        public int AccountId { get; set; }
        public int? BeneficiaryAccount { get; set; }
        public string TransactionMode { get; set; }
        public string TransactionType { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Remarks { get; set; }

        public virtual UserAccountDetails Account { get; set; }
    }
}
