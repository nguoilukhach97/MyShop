using MyShop.Application.DTOs;
using MyShop.Application.PageViews;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Application.Interfaces
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);

        Task SubViewCount(int productId);
        

        Task<PageResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
    }
}
