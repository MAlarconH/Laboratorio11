﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVSCodeFirst.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

    }
}