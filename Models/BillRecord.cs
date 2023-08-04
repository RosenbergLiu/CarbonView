using SQLite;

namespace GreenITBlazor.Models
{
    public class BillRecord
    {
        [PrimaryKey]
        public int Year { get; set; }

        public string YearStr { get; set; }

        public double ElectricityUsage { get; set; }

        public double GasUsage { get; set; }

        public double CarbonEmission { get; set; }

        public double? ElectricityUsagePc { get; set; }

        public double? GasUsagePc { get; set; }

        public double? CarbonEmissionPc { get; set; }

    }
}
