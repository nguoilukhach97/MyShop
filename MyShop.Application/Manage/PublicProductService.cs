using MyShop.Application.DTOs;
using MyShop.Application.Interfaces;
using MyShop.Application.PageViews;

using MyShop.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyShop.Data.Entities;

namespace MyShop.Application.Manage
{
    public class PublicProductService : IPublicProductService
    {
        private readonly MyShopContext _context;
        public PublicProductService(MyShopContext context)
        {
            _context = context;
        }
        public async Task<PageResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingView request)
        {
            //1. select 
            var query = from a in _context.Products
                        join b in _context.ProductInCategory on a.Id equals b.ProductId
                        join c in _context.Categories on b.CategoryId equals c.Id

                        select new { a, c };

            // 2 . filter
            if (request.CategoryId.HasValue && request.CategoryId > 0)
            {
                query = query.Where(p => p.c.Id == request.CategoryId);
            }

            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize)
                .Select(p => new ProductViewModel()
                {
                    Id = p.a.Id,
                    Name = p.a.Name,
                    CatalogId = p.a.CatalogId,
                    BrandId = p.a.BrandId,
                    Description = p.a.Description,
                    Details = p.a.Details,
                    Price = p.a.Price,
                    PromotionPrice = p.a.PromotionPrice,
                    
                    Warranty = p.a.Warranty,
                    DateCreated = p.a.DateCreated,
                    UserCreated = p.a.UserCreated,
                    DateModified = p.a.DateModified,
                    UserModified = p.a.UserModified,
                    ViewCount = p.a.ViewCount,
                    Status = p.a.Status
                }).ToListAsync();

            var pageResult = new PageResult<ProductViewModel>()
            {
                TotalRecord = totalRow,
                Items = data
            };

            return pageResult;
        }
    }
}
