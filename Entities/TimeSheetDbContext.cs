using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAttMgtSystems.Entities
{
    public class TimeSheetDbContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public string DbPath { get;}

        public TimeSheetDbContext()
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "TimeSheetDbs.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source = {DbPath}");
        }
    }
}
