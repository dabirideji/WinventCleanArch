using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Winvent.Application.Dtos.Admin.Request;
using Winvent.Domain.Models;

namespace Winvent.Application.Interfaces
{
    public interface IAdminService
    {
        Task<Admin> AdminLogin(Admin dto);

        Task<bool> AdminLogout(Guid AdminId);
    }
}