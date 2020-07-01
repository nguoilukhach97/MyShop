using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.Application.PageViews
{
    public class GetProductPagingView : PagingRequestBase
    {
        public int CategoryId { get; set; }
    }
}
