using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETSIBKM2_WebApp.ViewModels
{
    public class Update
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string OldPw { get; set; }

        public string NewPw { get; set; }
    }
}
