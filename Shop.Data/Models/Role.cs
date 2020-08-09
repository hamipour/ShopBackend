using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Data.Models
{
    public class Role
    {
        [MaxLength(50)]
        public string RoleId { get; set; }
        [MaxLength(50)]
        public string RoleName { get; set; }
        [MaxLength(50)]
        public string RoleTitle { get; set; }

        public bool IsActive { get; set; }

        [MaxLength(50)]
        public string UserRoleId { get; set; }
        public UserRoles UserRoles { get; set; }
    }
}
