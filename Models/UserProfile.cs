using SQLite;

namespace GreenITBlazor.Models
{
    public class UserProfile
    {
        [PrimaryKey]
        public string UserName { get; set; }

        public string Postcode { get; set; }

        public int HouseMembers { get; set; }

    }
}
