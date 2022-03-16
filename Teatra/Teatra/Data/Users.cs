using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teatra.Data
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }

        public RolesType Role { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
