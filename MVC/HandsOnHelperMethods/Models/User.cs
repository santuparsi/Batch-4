using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using HandsOnHelperMethods.CustomValidations;
namespace HandsOnHelperMethods.Models
{
    public class User
    {
        [Required(ErrorMessage ="Pls Enter FirstName")]
        public string Fname { get; set; }
        [Required(ErrorMessage="Pls Enter LastName")]
        public string Lname { get; set; }
        [EmailAddress(ErrorMessage="Invalid EmailID")]
        public string Email { get; set;}
        [RegularExpression(@"[6789]{1}\d{9}",ErrorMessage="Invalid Mobile No")]
        public string Mobile { get; set; }
        public string Country { get; set; }
        [DOB]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage="Pls Enter Username")]
        [StringLength(10,ErrorMessage="Username not exceed 10 chars long")]
        public string Uname { get; set; }
        [Required(ErrorMessage="Pls Enter Password")]
        [RegularExpression("[0-9a-zA-Z]{8}",ErrorMessage="Password should be 8 chars long")]
        public string Pwd { get; set; }
        [Compare("Pwd",ErrorMessage="Password Mismatch")]
        public string Cpwd { get; set; }
    }
}
