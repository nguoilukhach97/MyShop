using System;
using System.Collections.Generic;

namespace MyShop.Data.Entities
{
    public partial class Orders
    {
        public Orders()
        {
            ProductInOrder = new HashSet<ProductInOrder>();
        }

        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public string Note { get; set; }
        public string ReasonCancelation { get; set; }
        public int UserCreated { get; set; }
        public int? UserCancel { get; set; }
        public int Status { get; set; }

        public virtual ICollection<ProductInOrder> ProductInOrder { get; set; }
    }
}
