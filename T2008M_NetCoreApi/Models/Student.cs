﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace T2008M_NetCoreApi.Models
{
    [Table("Students")]
    public record Student
    {
        public long Id { get; set; }
        public string FirstName { get; set; }        
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
