using System;
using System.Collections.Generic;

namespace MyShop.Data.Entities
{
    public partial class ProductInOrder
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
    }
}
