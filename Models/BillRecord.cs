
using SQLite;

namespace GreenITBlazor.Models
{
    public class BillRecord
    {
        [PrimaryKey]
        public int Year { get; set; }
        public double ElectricityUsage { get; set; }
        public double GasUsage { get; set; }
    }
}
