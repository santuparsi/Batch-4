using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HandsOnModelBinding.Models
{
    public class User
    {
        [Required(ErrorMessage ="Pls Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Pls Enter Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Pls Enter MobileNo")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Pls Enter Username")]
        public string Uname { get; set; }
        [Required(ErrorMessage = "Pls Enter Password")]
        public string Pwd { get; set; }
    }
}
