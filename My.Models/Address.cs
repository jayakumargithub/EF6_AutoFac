﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Models
{
   public  class Address
    { 
        public int AddressId { get; set; }
        public string HouseNo_Name { get; set; }
        public string Street { get; set; }
        public string Area { get; set; }
        public string Country { get; set; }
    }
}
