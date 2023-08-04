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
        public const string DatabaseFilename = "greenituser.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            SQLite.SQLiteOpenFlags.ReadWrite |
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);

        public static string CityOfCaseyUrl = "https://data.casey.vic.gov.au/api/records/1.0/search/?dataset=summary-residential-community-data&facet=postcode&refine.postcode=";
    }
}
