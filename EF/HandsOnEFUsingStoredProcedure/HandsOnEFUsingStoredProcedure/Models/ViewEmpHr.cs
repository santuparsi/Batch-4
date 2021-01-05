using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFUsingStoredProcedure.Models
{
    public partial class ViewEmpHr
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public decimal? Salary { get; set; }
        public string Did { get; set; }
    }
}
