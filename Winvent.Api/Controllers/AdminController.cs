using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Winvent.Application.Dtos.Admin.Request;
using Winvent.Application.Interfaces;
using Winvent.Domain.Models;

namespace Winvent.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _service ;

        public AdminController(IAdminService service)
        {
            _service=service;
            
        }
        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<Admin>> AdminLogin(AdminLoginDto dto){
            try
            {
                Admin adm=new Admin();
                adm.AdminUserName=dto.AdminUserName;
                adm.AdminPassword=dto.AdminPassword;
                var admin=await _service.AdminLogin(adm);
                if (admin==null){
                    return BadRequest("INVALID LOGIN CREDENTIALS");
                }
                return Ok(admin);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
        
    }
}