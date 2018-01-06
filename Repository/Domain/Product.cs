﻿using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public int Store { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public virtual Store StoreNavigation { get; set; }
    }
}
