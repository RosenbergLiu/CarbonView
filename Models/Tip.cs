using SQLite;

namespace GreenITBlazor.Models
{
    public class Tip
    {
        [PrimaryKey]
        public int Id { get; set; }

        public string TipStr { get; set; }
    }
}
