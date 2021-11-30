using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace T2008M_NetCoreApi.Models
{
    [Table("Users")]
    public record User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}