using System;
using System.Collections.Generic;

namespace MyShop.Data.Entities
{
    public partial class Brands
    {
        public Brands()
        {
            Products = new HashSet<Products>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
