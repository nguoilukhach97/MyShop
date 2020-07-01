using System;
using System.Collections.Generic;

namespace MyShop.Data.Entities
{
    public partial class ProductImages
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public string Caption { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsDefault { get; set; }
        public bool? Status { get; set; }

        public virtual Products Product { get; set; }
    }
}
