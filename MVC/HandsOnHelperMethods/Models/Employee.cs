using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HandsOnHelperMethods.Models
{
    public class Employee
    {
       [Required(ErrorMessage ="Enter ID")]
        public int Eid { get; set; }
        [Required(ErrorMessage ="Name is Required")]
        public string Ename { get; set; }
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
    }
}
