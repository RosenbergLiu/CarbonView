using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GreenITBlazor
{
    public static class Constants
    {
        public const string UserDatabaseFilename = "user.db3";
        public const string SystemDatabaseFilename = "system.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            SQLite.SQLiteOpenFlags.ReadWrite |
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string UserDatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory, UserDatabaseFilename);

        public static string SystemDatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory, SystemDatabaseFilename);

        public static string CityOfCaseyUrl = "https://data.casey.vic.gov.au/api/records/1.0/search/?dataset=summary-residential-community-data&facet=postcode&refine.postcode=";
    }
}
