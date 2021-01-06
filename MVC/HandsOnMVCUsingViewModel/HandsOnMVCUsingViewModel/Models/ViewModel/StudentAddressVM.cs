using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingViewModel.Models;
namespace HandsOnMVCUsingViewModel.Models.ViewModel
{
    public class StudentAddressVM
    {
        public Student Student { get; set; }
        public StudentAddress StudentAddress { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }

    }
}
