﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        public User User { get; set; }

        public ICollection<Property> Properties { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}
