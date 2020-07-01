using System;
using System.Collections.Generic;

namespace MyShop.Data.Entities
{
    public partial class ProductSize
    {
        public int ProductId { get; set; }
        public int SizeId { get; set; }

        public virtual Products Product { get; set; }
        public virtual Sizes Size { get; set; }
    }
}
