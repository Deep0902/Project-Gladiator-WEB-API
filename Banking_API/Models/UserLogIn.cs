using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Banking_API.Models
{
    public partial class UserLogIn
    {
        public int LogId { get; set; }
        public int AccountId { get; set; }
        public string LogInPassword { get; set; }
        public string TransactionPassword { get; set; }

        public virtual UserAccountDetails Account { get; set; }
    }
}
