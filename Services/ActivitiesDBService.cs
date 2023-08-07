using GreenITBlazor.Models;
using Microsoft.Data.Sqlite;
using SQLite;

namespace GreenITBlazor.Services
{
    public class ActivitiesDBService
    {
        SQLiteAsyncConnection Database;

        public ActivitiesDBService()
        { }

        async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(Constants.UserDatabasePath, Constants.Flags);
            await Database.CreateTableAsync<ActivityRecord>();
        }

        public async Task<List<ActivityRecord>> GetActivityRecordsAsync(bool isDescending)
        {
            await Init();
            if (isDescending)
            {
                return await Database.Table<ActivityRecord>().OrderByDescending(r => r.Year).ToListAsync();
            }
            else
            {
                return await Database.Table<ActivityRecord>().OrderBy(r => r.Year).ToListAsync();
            }
        }

        public async Task CreateActivityRecordAsync(ActivityRecord activityRecord)
        {
            await Init();
            string validator = Validator(activityRecord);
            if (validator != "OK")
            {
                throw new Exception(validator);
            }
            else
            {
                try
                {
                    await Database.InsertAsync(activityRecord);
                }
                catch (SqliteException sqle) { throw new Exception(sqle.Message); }
            }
        }

        public async Task<string> DeletetActivityRecordAsync(ActivityRecord activityRecord)
        {
            try
            {
                await Init();
                await Database.DeleteAsync(activityRecord);
                return "OK";
            }
            catch (SqliteException sqle)
            {
                return sqle.Message;
            }
        }

        public async Task<ActivityRecord> GetActivityRecordAsync(int year)
        {
            await Init();
            return await Database.Table<ActivityRecord>().Where(b => b.Year == year).FirstOrDefaultAsync();
        }

        public async Task UpdateActivityRecordAsync(ActivityRecord activityRecord)
        {
            await Init();
            string validator = Validator(activityRecord);
            if (validator != "OK")
            {
                throw new Exception(validator);
            }
            else
            {
                try
                {
                    await Database.UpdateAsync(activityRecord);
                }
                catch (SqliteException sqle) { throw new Exception(sqle.Message); }
            }
        }

        public static string Validator(ActivityRecord activityRecord)
        {
            string result = "OK";
            int currentYear = DateTime.Now.Year;

            if (activityRecord.Year < 2000)
            {
                result = "Year must later than 2000";
            }

            if (activityRecord.Year > currentYear)
            {
                result = "The year entered cannot be in the future.";
            }

            return result;
        }
    }
}
