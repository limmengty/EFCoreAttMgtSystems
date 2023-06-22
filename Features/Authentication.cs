using EFCoreAttMgtSystems.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAttMgtSystems.Features
{
    public  class Authentication
    {
        private TimeSheetDbContext _context;
        private string username;
        private string password;
        public Authentication(TimeSheetDbContext context, string username, string password)
        {
            _context = context;
            this.username = username;
            this.password = password;
        }

        public bool IsAuthenticated { get; private set; } = false;
        public bool ValidateLogin()
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Please provid username and password");

            }
            var user = _context.UserAccounts.Where(u => u.UserName == username.Trim() && u.Password == password.Trim()).FirstOrDefault();
            if(user == null)
            {
                return IsAuthenticated = false;
            }
            return IsAuthenticated = true;
        }
    }
}
