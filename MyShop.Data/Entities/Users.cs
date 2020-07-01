using System;
using System.Collections.Generic;

namespace MyShop.Data.Entities
{
    public partial class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int GroupId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public bool? Status { get; set; }

        public virtual UserGroups Group { get; set; }
    }
}
