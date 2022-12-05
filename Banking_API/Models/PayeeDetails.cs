using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Banking_API.Models
{
    public partial class PayeeDetails
    {
        public int PayeeId { get; set; }
        public int? BeneficiaryAccount { get; set; }
        public string BeneficiaryName { get; set; }
        public string NickName { get; set; }
        public int AccountId { get; set; }

        public virtual UserAccountDetails Account { get; set; }
    }
}
