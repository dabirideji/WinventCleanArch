using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Winvent.Domain.Models;

namespace Winvent.Infrastructure.Data
{
    public class WinventDbContext : DbContext
    {
        public WinventDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Admin> Admins { get; set; }
    }
}