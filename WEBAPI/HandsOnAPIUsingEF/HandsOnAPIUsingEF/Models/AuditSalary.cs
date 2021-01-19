using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnAPIUsingEF.Models
{
    public partial class AuditSalary
    {
        public int AuditId { get; set; }
        public int? Eid { get; set; }
        public decimal? OldSalary { get; set; }
        public decimal? NewSalary { get; set; }

        public virtual Employee EidNavigation { get; set; }
    }
}
