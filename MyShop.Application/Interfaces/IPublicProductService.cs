 using MyShop.Application.DTOs;
using MyShop.Application.PageViews;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.Application.Interfaces
{
    public interface IPublicProductService
    {
        PageResult<ProductViewModel> GetAllByCategoryId(GetProductPagingView request);
    }
}
