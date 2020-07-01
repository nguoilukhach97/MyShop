using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.Application.PageViews
{
    public class PageResult<T>
    {
        public int TotalRecord { get; set; }
        public List<T> Items { get; set; }
    }
}
