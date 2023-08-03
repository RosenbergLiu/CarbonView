using SQLite;

namespace GreenITBlazor.Models
{
    public class EmissionRecord
    {
        [PrimaryKey]
        public int Year { get; set; }
        public double Carbon { get; set; }
    }
}
