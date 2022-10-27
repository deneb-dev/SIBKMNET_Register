using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETSIBKM2_WebApp.ViewModels
{
    public class ForgotPw
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string DefaultPw { get; set; }
        public string Role { get; set; }
    }
}
