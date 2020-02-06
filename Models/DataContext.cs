﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PhoneApplication.Models;

namespace PhoneAppliation.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

    }


}