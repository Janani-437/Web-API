﻿using System;
using System.Collections.Generic;

namespace LocalWebAPI_myProject_.Models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string? Role1 { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
