using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Winvent.Application.Dtos.Admin.Request;
using Winvent.Application.Interfaces;
using Winvent.Domain.Models;

namespace Winvent.Application.Services
{
    public class AdminService:IAdminService
    {
        private readonly IAdminService _service;
        public AdminService(IAdminService service)
        {
            _service = service;
            
        }

        public async Task<Admin> AdminLogin(Admin dto){
   
            var admin=await _service.AdminLogin(dto);
            return admin;
        }


        public Task<bool> AdminLogout(Guid AdminId)
        {
            throw new NotImplementedException();
        }
    }
}