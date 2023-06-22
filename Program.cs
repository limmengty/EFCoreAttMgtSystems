using EFCoreAttMgtSystems.Entities;
using EFCoreAttMgtSystems.Features;

namespace EFCoreAttMgtSystems
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            TimeSheet AppTimeSheet = new TimeSheet();
            AppTimeSheet.DbContext.Database.EnsureCreated();
            var emp = AppTimeSheet.DbContext.Employees.FirstOrDefault();
            if (emp == null)
            {
                var aEmp = new Employee()
                {
                    FullName = "Admin",
                    Position = "Admin",
                    CardNo = "001",
                    UserAccount = new UserAccount()
                    {
                        UserName = "Admin",
                        Password = "1234"
                    }
                };
                AppTimeSheet.DbContext.Employees.Add(aEmp);
                AppTimeSheet.DbContext.SaveChanges();

            }
            Application.Run(new ClockManagement(AppTimeSheet));
            /*        Application.Run(new MainForm(AppTimeSheet));
            */
        }
    }
}