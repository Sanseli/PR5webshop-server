﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PR5webshopAPI.Models
{
    public class Customer
    {
        public int ID { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }

        public string Telnr { get; set; }

        public string Address { get; set; }
    }
}
