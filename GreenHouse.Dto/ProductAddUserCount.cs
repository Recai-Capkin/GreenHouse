﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.Dto
{
    public class ProductAddUserCount
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public int AddedProductCount { get; set; }
    }
}
