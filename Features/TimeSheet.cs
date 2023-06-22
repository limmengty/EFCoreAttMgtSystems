using EFCoreAttMgtSystems.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAttMgtSystems.Features
{
    public class TimeSheet
    {
        public TimeSheetDbContext DbContext { get; }
        public TimeSheet()
        {
            DbContext = new TimeSheetDbContext();
        }
        //Add emp
        public void AddEmployee(Employee emp, string cardNo)
        {
            if (string.IsNullOrEmpty(emp.FullName) || 
                string.IsNullOrEmpty(emp.Position) || 
                string.IsNullOrEmpty(emp.CardNo)|| 
                string.IsNullOrEmpty(emp.UserAccount?.UserName)||
                string.IsNullOrEmpty(emp.UserAccount.Password)
                )
            {
                throw new ArgumentException("Please Provide all Employee data!");
            }
            if(DbContext.Employees!.Any(e =>e.CardNo == cardNo))
            {
                throw new ArgumentException($"Card{cardNo} Already Exist!");
            }
            else
            {
                DbContext.Add(emp);
                DbContext.SaveChanges();
            }
        }
        
        //Update Emp

        public void UpdateEmployee(string EmployeeId, string FullName, string Position)
        {
            if(string.IsNullOrEmpty(FullName) || string.IsNullOrEmpty(Position))
            {
                throw new ArgumentException("Please Provide all Employee data!");
            }

            var emp = DbContext.Employees.Find(new Guid(EmployeeId));
            if(emp == null)
            {
                throw new ArgumentException("Employee NotFound!");
            }

            //Update 
            emp.FullName = FullName;
            emp.Position = Position;
          
            DbContext.SaveChanges();
        }


        //
        public void DeleteEmployee(string IndentityId, string userAccountId)
        {
            if (string.IsNullOrEmpty(IndentityId))
            {
                throw new ArgumentException("Please provide the employee's identity ID!");
            }

            var emp = DbContext.Employees.Find(new Guid(IndentityId));
            var idc = int.Parse(userAccountId);
            var empuser = DbContext.UserAccounts.Find(idc);
            if (emp == null)
            {
                throw new ArgumentException("Employee not found!");
            }

            // Delete the employee
            DbContext.Employees.Remove(emp);
            DbContext.UserAccounts.Remove(empuser);
            DbContext.SaveChanges();
        }
        public void LogEmployee(string cardNo, Log logInfo)
        {
            if(string.IsNullOrEmpty(cardNo))
            {
                throw new ArgumentException("Card No is Empty");
            }
            var emp = DbContext.Employees.Include(l => l.Logs).FirstOrDefault(emp => emp.CardNo == cardNo.Trim());
            if(emp == null)
            {
                throw new ArgumentException($"Card No {cardNo} not found in Employee list");
            }
            emp.Logs!.Add(logInfo);
            DbContext.SaveChanges() ;
        }

        //getAllEmployee
        public List<EmployeeView> GetAllEmployee()
        {
            //using LINQ to select data without log property
            return DbContext.Employees.Select(emp => new EmployeeView
            {
                EmployeeId = emp.EmployeeId,
                FullName = emp.FullName,
                Position = emp.Position,
                CardNo = emp.CardNo,
                UserAccountID = emp.UserAccount.UserAccountId,
                UserName = emp.UserAccount.UserName,
            }).ToList();
        }

        public List<Employee> GetAllEmployee(bool isSimpleVersion)
        {
            return DbContext.Employees.ToList();
        }
    }
}
