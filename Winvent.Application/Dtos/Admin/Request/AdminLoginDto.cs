using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Winvent.Application.Dtos.Admin.Request
{
    public class AdminLoginDto
    {
        public String AdminUserName { get; set; }
        public String AdminPassword { get; set; }
    }
}
