using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAttMgtSystems.Entities
{
    public class EmployeeView
    {
        public Guid EmployeeId { get; set; }
        public string? FullName { get; set; }
        public string? Position { get; set; }
        public string? CardNo { get; set; }
        public string? UserName { get; set; }

    }
}
