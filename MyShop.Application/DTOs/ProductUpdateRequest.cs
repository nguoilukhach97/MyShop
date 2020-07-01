﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.Application.DTOs
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CatalogId { get; set; }
        public int? BrandId { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public decimal Price { get; set; }
        public decimal PromotionPrice { get; set; }
        public string Image { get; set; }
        public string ImageThumb { get; set; }
        public int? Warranty { get; set; }
        
        public DateTime? DateModified { get; set; }
        public int? UserModified { get; set; }
        
        public bool? Status { get; set; }
    }
}
