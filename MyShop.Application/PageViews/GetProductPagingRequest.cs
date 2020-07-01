using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.Application.PageViews
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string KeyWord { get; set; }
        public List<int> CategoryId { get; set; }
    }
}
