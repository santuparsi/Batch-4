using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnAPIUsingEF.Models
{
    public partial class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public decimal? Salary { get; set; }
        public DateTime? JoinDate { get; set; }
        public string Did { get; set; }

        public virtual Department DidNavigation { get; set; }
    }
}
