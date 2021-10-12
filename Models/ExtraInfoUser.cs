using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication1.Models
{
    public class ExtraInfoUser : IdentityUser
    {

        public string Country { get; set; }
        public string CID { get; set; }
        public string Treatment { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LastName2 { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string ZipCode { get; set; }
        public string TaxResidence { get; set; }
        public string TaxResidence2 { get; set; }
        public Int32 NumberSecurity { get; set; }
        public bool ReceiveOffers { get; set; }
        public bool TermsConditions { get; set; }
        public bool TermsConditions2 { get; set; }


    }
}
