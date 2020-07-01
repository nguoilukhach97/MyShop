using System;
using System.Collections.Generic;

namespace MyShop.Data.Entities
{
    public partial class UserRoles
    {
        public int RoleId { get; set; }
        public int GroupId { get; set; }

        public virtual UserGroups Group { get; set; }
        public virtual Roles Role { get; set; }
    }
}
