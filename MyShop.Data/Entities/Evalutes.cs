using System;
using System.Collections.Generic;

namespace MyShop.Data.Entities
{
    public partial class Evalutes
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] Email { get; set; }
        public int Rate { get; set; }
        public string ContentEvalute { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Status { get; set; }

        public virtual Products Product { get; set; }
    }
}
