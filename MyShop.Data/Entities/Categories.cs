using System;
using System.Collections.Generic;

namespace MyShop.Data.Entities
{
    public partial class Categories
    {
        public Categories()
        {
            ProductInCategory = new HashSet<ProductInCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int? ParentId { get; set; }
        public int? SortOrder { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<ProductInCategory> ProductInCategory { get; set; }
    }
}
