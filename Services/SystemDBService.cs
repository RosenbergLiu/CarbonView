using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenITBlazor.Services
{
    public class SystemDBService
    {
        SQLiteAsyncConnection Database;

        public SystemDBService()
        { }

        async Task Init()
        {
            if (Database is not null)
                return;

            using Stream inputStream = await FileSystem.Current.OpenAppPackageFileAsync(Constants.SystemDatabaseFilename);

            string targetFile = Path.Combine(FileSystem.Current.AppDataDirectory, Constants.SystemDatabaseFilename);

            using FileStream outputStream = File.Create(targetFile);
            await inputStream.CopyToAsync(outputStream);
        }

        public async Task<string> GetRandomTip()
        {
            await Init();
            return await Database.Table<Tip>().OrderBy(r => r.Year).ToListAsync();
        }
    }
}
