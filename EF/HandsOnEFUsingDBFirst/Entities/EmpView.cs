using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFUsingDBFirst.Entities
{
    public partial class EmpView
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public decimal? Salary { get; set; }
    }
}
