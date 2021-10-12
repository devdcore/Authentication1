using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication1.Models
{
    public class Register
    {
        [Required]
        public string Country { get; set; }
        [Required]
        public string CID { get; set; }
        public string Treatment { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string LastName2 { get; set; }
        [Required]
        public DateTime? BirthDate { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Address2 { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public string TaxResidence { get; set; }
        public string TaxResidence2 { get; set; }
        [Required]
        public Int32 NumberSecurity { get; set; }
        public bool ReceiveOffers { get; set; }
        [Required]
        public bool TermsConditions { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Password no match")]
        public string ConfirmPassword { get; set; }
    }
}
