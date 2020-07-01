using System;
using System.Collections.Generic;

namespace MyShop.Data.Entities
{
    public partial class Products
    {
        public Products()
        {
            Evalutes = new HashSet<Evalutes>();
            ProductImages = new HashSet<ProductImages>();
            ProductInCategory = new HashSet<ProductInCategory>();
            ProductInOrder = new HashSet<ProductInOrder>();
            ProductSize = new HashSet<ProductSize>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CatalogId { get; set; }
        public int? BrandId { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public decimal Price { get; set; }
        public decimal PromotionPrice { get; set; }
        public int? Warranty { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? UserModified { get; set; }
        public int? ViewCount { get; set; }
        public bool? Status { get; set; }

        public virtual Brands Brand { get; set; }
        public virtual ICollection<Evalutes> Evalutes { get; set; }
        public virtual ICollection<ProductImages> ProductImages { get; set; }
        public virtual ICollection<ProductInCategory> ProductInCategory { get; set; }
        public virtual ICollection<ProductInOrder> ProductInOrder { get; set; }
        public virtual ICollection<ProductSize> ProductSize { get; set; }
    }
}
