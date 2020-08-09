using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Data.Models
{
    public class User
    {
        [MaxLength(50)]
        public string UserId { get; set; }
        [MaxLength(50)]
        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public bool IsActive { get; set; }
        public bool Status { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }
        [MaxLength(20)]
        public string Mobile { get; set; }
        [MaxLength(30)]
        public string State { get; set; }
        [MaxLength(30)]
        public string City { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(50)]
        public string UserRoleId { get; set; }
        public UserRoles UserRoles { get; set; }
    }
}
