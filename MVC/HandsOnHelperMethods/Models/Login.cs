using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HandsOnHelperMethods.Models
{
    public class Login
    {
       [Required(ErrorMessage="Plese Enter Username")]
        public string Uname { get; set; }
        [Required(ErrorMessage="Please Enter Password")]
        public string Pwd { get; set; }
    }
}
