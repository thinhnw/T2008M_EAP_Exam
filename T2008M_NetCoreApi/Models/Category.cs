﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace T2008M_NetCoreApi.Models
{
    [Table("Categories")]
    public record Category
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
