using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public partial class Store
    {
        public Store()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
