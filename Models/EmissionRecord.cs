using SQLite;

namespace GreenITBlazor.Models
{
    public class EmissionRecord
    {
        [PrimaryKey]
        public int Year { get; set; }

        public string YearStr { get; set; }

        public double AnimalBased { get; set; }

        public double PlantBased { get; set; }

        public int Cars { get; set; }
    }
}
