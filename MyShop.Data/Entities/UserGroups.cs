using System;
using System.Collections.Generic;

namespace MyShop.Data.Entities
{
    public partial class UserGroups
    {
        public UserGroups()
        {
            UserRoles = new HashSet<UserRoles>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UserRoles> UserRoles { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
