using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnMVCUsingDependencyInjection.Models
{
    public partial class Login
    {
        public string Username { get; set; }
        public string Pwd { get; set; }
        public int? EmpId { get; set; }

        public virtual Employee Emp { get; set; }
    }
}
