using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.Models
{
    public class UserRoles
    {
        public string UserRolesId { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public string RoleId { get; set; }
        public Role Role { get; set; }
    }
}
