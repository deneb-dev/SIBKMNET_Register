using Microsoft.EntityFrameworkCore;
using NETSIBKM2_WebApp.Context;
using NETSIBKM2_WebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETSIBKM2_WebApp.Repositories.Data
{
    public class AccountRepository
    {
        MyContext myContext;

        public AccountRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }

        public Responselogin Login(Login login)
        {
            var data = myContext.UserRoles
                .Include(x => x.Role)
                .Include(x => x.User)
                .Include(x => x.User.Employee)
                .FirstOrDefault(x => x.User.Employee.Email.Equals(login.Email) &&
                                     x.User.Password.Equals(login.Password));
            if(data !=null)
            {
                var response = new Responselogin()
                {
                    Id = data.User.Employee.Id,
                    Fullname = data.User.Employee.FullName,
                    Email = data.User.Employee.Email,
                    Role = data.Role.Name
                };
                return response;
            }
            return null;
        }
    }
}
