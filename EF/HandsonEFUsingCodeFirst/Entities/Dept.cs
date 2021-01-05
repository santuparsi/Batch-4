using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HandsonEFUsingCodeFirst.Entities
{
    [Table("Depts")]
    public class Dept
    {
        [Key]
        [StringLength(5)]
        public string Did { get; set; }
        [StringLength(20)]
        [Required]
        public string Dname { get; set; }
        public List<Employee> Employees { get; set; }
        
       // public Employee Employee { get; set; }
    }
}
