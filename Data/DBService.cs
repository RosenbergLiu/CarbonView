using GreenITBlazor.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using Radzen;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenITBlazor.Data
{
    public class DBService
    {
        SQLiteAsyncConnection Database;

        public DBService()
        { }

        async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            await Database.CreateTableAsync<BillRecord>();
            await Database.CreateTableAsync<UserProfile>();
            await Database.CreateTableAsync<EmissionRecord>();
        }

        public async Task<List<BillRecord>> GetRecords()
        {
            await Init();
            return await Database.Table<BillRecord>().OrderByDescending(r => r.Year).ToListAsync();
        }

        public async Task CreateRecord(BillRecord billRecord)
        {
            await Init();
            string validator = Validator(billRecord);
            if(validator != "OK")
            {
                throw new Exception(validator);
            }
            else
            {
                try
                {
                    await Database.InsertAsync(billRecord);
                }catch (SqliteException sqle) { throw new Exception(sqle.Message); }
            }
        }

        public async Task<string> DeletetRecord(BillRecord billRecord)
        {
            try
            {
                await Init();
                await Database.DeleteAsync(billRecord);
                return "OK";
            }
            catch (SqliteException sqle)
            {
                return sqle.Message;
            }
        }

        public async Task<BillRecord> GetRecord(int year)
        {
            await Init();
            return await Database.Table<BillRecord>().Where(b => b.Year == year).FirstOrDefaultAsync();
        }

        public async Task UpdateRecord(BillRecord billRecord)
        {
            await Init();
            string validator = Validator(billRecord);
            if (validator != "OK")
            {
                throw new Exception(validator);
            }
            else
            {
                try
                {
                    await Database.UpdateAsync(billRecord);
                }
                catch (SqliteException sqle) { throw new Exception(sqle.Message); }
            }
        }

        public static string Validator(BillRecord billRecord)
        {
            string result = "OK";
            int currentYear = DateTime.Now.Year;

            if(billRecord.Year < 2000){
                result = "Year must later than 2000";
            }

            if (billRecord.Year > currentYear)
            {
                result = "The year entered cannot be in the future.";
            }

            if (billRecord.ElectricityUsage == 0)
            {
                result = "Electricity usage cannot be 0";
            }

            if (billRecord.GasUsage == 0)
            {
                result = "Gas usage cannot be 0";
            }

            return result;
        }
    }
}
