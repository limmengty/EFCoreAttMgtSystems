using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAttMgtSystems.Entities
{
    public class Log
    {
        public int LogId  {get;set;}
        public DateTime? TimeStamp { get;set;}
        public uint TimeShift { get;set;}
    }
}
