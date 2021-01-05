using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HandsonEFUsingCodeFirst.Entities
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int Eid { get; set; }
        [Required]
        [StringLength(20)]
        public string Ename { get; set; }
        public DateTime? JoinDate { get; set; }
        public string Designation { get; set; }
        public double? Salary { get; set; }
       // [ForeignKey("Dept")]
        public string Did { get; set; }
        //navigation property
        [ForeignKey("Did")]
        public Dept Dept { get; set; }
    }
}
