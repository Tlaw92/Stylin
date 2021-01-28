﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Stylin.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        //[ForeignKey("IdentityUser")]
        //public string IdentityUserId { get; set; }
        //public IdentityUser IdentityUser { get; set; }

        //Do I need this above?

    }
}
