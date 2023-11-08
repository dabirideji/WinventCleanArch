using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Winvent.Application.Dtos.Admin.Request;
using Winvent.Application.Interfaces;
using Winvent.Domain.Models;
using Winvent.Infrastructure.Data;

namespace Winvent.Infrastructure.Services
{
    public class AdminService : IAdminService
    {
        private readonly WinventDbContext _context;

        public AdminService(WinventDbContext context)
        {
            _context = context;
        }

        public async Task<Admin> AdminLogin(Admin dto)
        {

            var admin=await _context.Admins.FirstOrDefaultAsync(x=>x.AdminUserName==dto.AdminUserName&&x.AdminPassword==dto.AdminPassword);
            if(admin==null){
                return null;
            }
            return admin;
        }

        public Task<bool> AdminLogout(Guid AdminId)
        {
            throw new NotImplementedException();
        }
    }
}
