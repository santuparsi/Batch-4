using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnMVCUsingJsonAndAjax.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public string Did { get; set; }
        public string Dname { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
