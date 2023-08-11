using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAttMgtSystems.Entities
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string? FullName { get; set; }
        public string? Position { get; set;}
        public string? CardNo { get; set;}
        public ICollection<Log>? Logs { get; set; }
        public UserAccount? UserAccount { get; set; }  
        
    }
}
