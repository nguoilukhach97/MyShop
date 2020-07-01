using System;
using System.Collections.Generic;

namespace MyShop.Data.Entities
{
    public partial class ProductInCategory
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Products Product { get; set; }
    }
}
