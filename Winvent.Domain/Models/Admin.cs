using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Winvent.Domain.Models
{
    public class Admin
    {
        [Key]
        public Guid AdminId { get; set; }
        public String? AdminFirstName { get; set; }
        public String? AdminLastName { get; set; }
        public String? AdminUserName { get; set; }
        public String? AdminPhone { get; set; }
        public String? AdminEmail { get; set; }
        public String? AdminPassword { get; set; }
    }
}
