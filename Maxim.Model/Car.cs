﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxim.Model
{
    public class Car
    {
        public string Make { get; set; }
        public string Model{ get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public double? TCCRating { get; set; }
        public int? HwyMPG { get; set; }


    }
}
