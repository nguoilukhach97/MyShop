using System;
using System.Collections.Generic;

namespace MyShop.Data.Entities
{
    public partial class Sizes
    {
        public Sizes()
        {
            ProductSize = new HashSet<ProductSize>();
        }

        public int Id { get; set; }
        public int SizeName { get; set; }
        public string Description { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<ProductSize> ProductSize { get; set; }
    }
}
