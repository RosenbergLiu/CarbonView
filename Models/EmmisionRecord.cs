using SQLite;

namespace GreenITBlazor.Models
{
    public class EmmisionRecord
    {
        [PrimaryKey]
        public int Year { get; set; }
        public double Carbon { get; set; }
    }
}
