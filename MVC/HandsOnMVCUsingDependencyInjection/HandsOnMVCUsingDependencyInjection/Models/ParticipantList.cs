﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnMVCUsingDependencyInjection.Models
{
    public partial class ParticipantList
    {
        public long ParticipantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OfficialEmail { get; set; }
    }
}
