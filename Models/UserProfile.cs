using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenITBlazor.Models
{
    public class UserProfile
    {
        public string UserName { get; set; }
        public string Postcode { get; set; }
        public int Members { get; set; }
        public int Pin { get; set; }
    }
}
