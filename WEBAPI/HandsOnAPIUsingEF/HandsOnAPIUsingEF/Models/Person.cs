﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnAPIUsingEF.Models
{
    public partial class Person
    {
        public int? Pid { get; set; }
        public string PersonName { get; set; }
        public int? Age { get; set; }
    }
}
