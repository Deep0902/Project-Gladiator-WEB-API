using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Banking_API.Models
{
    public partial class Customers
    {
        public Customers()
        {
            UserAccountDetails = new HashSet<UserAccountDetails>();
        }
      

        public int CustomerId { get; set; } //data members
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MobileNumber { get; set; }
        public string Gender { get; set; }
        public string EmailId { get; set; }
        public string Aadhar { get; set; }
        public DateTime? Dob { get; set; }
        public string Addressline1 { get; set; }
        public string Addressline2 { get; set; }
        public string Landmark { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int? Pincode { get; set; }
        public string PermanentAddress1 { get; set; }
        public string PermanentAddress2 { get; set; }
        public string PermanentLandmark { get; set; }
        public string PermanentState { get; set; }
        public string PermanentCity { get; set; }
        public int? PermanentPincode { get; set; }
        public string Occupation { get; set; }
        public string SourceOfIncome { get; set; }
        public decimal? GrossAnnualIncome { get; set; }
        public bool? DebitCard { get; set; }
        public bool? NetBanking { get; set; }
        public bool? ApproveStatus { get; set; }

        public virtual ICollection<UserAccountDetails> UserAccountDetails { get; set; }
    }
}
