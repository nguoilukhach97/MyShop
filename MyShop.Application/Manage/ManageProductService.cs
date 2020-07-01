using MyShop.Application.DTOs;
using MyShop.Application.Interfaces;
using MyShop.Application.PageViews;
using MyShop.Data.Entities;
using MyShop.Utilities.Exceptions;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyShop.Application.Manage
{
    public class ManageProductService : IManageProductService
    {
        private readonly MyShopContext _context;
        public ManageProductService(MyShopContext context)
        {
            _context = context;
        }
        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Products()
            {

                Name = request.Name,
                CatalogId = request.CatalogId,
                BrandId = request.BrandId,
                Description = request.Description,
                Details = request.Details,
                Price = request.Price,
                PromotionPrice = request.PromotionPrice,
                Image = request.Image,
                ImageThumb = request.ImageThumb,
                Warranty = request.Warranty,
                Status = request.Status

            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new ShopException($"Cannot find a product : {productId}");
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

       
        public async Task<PageResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request)
        {
            //1. select 
            var query = from a in _context.Products
                        join b in _context.ProductInCategory on a.Id equals b.ProductId
                        join c in _context.Categories on b.CategoryId equals c.Id
                        join d in _context.Brands on a.BrandId equals d.Id
                        select new { a, c, d };

            // 2 . filter
            if (!string.IsNullOrEmpty(request.KeyWord))
            {
                query = query.Where(x => x.a.Name.Contains(request.KeyWord) || x.c.Name.Contains(request.KeyWord) || x.d.Name.Contains(request.KeyWord));
            }
            if (request.CategoryId.Count() > 0)
                query = query.Where(p => request.CategoryId.Contains(p.c.Id));

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
                    Image = p.a.Image,
                    ImageThumb = p.a.ImageThumb,
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

        public async Task SubViewCount(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            product.ViewCount += 1;
            await _context.SaveChangesAsync();
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(request);
            if (product == null) throw new ShopException($"Không thể tìm thấy sản phẩm cần sửa,tôi chắc là đúng : {request.Id} ?");

            product.Name = request.Name;
            product.CatalogId = request.CatalogId;
            product.BrandId = request.BrandId;
            product.Description = request.Description;
            product.Details = request.Details;
            product.Price = request.Price;
            product.PromotionPrice = request.PromotionPrice;
            product.Image = request.Image;
            product.ImageThumb = request.ImageThumb;
            product.Warranty = request.Warranty;
            product.Status = request.Status;

            return await _context.SaveChangesAsync();
        }
    }
}
