using Android.Net.Wifi.Aware;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenITBlazor.Models
{
    public class Tip
    {
        [PrimaryKey]
        public int Id { get; set; }

        public string TipStr { get; set; }
    }
}
