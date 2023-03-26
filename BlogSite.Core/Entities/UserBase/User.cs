﻿using BlogSite.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Core.Entities.UserBase
{
    public class User : BlogSiteMasterBaseEntity<int>
    {
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string About { get; set; }
        public byte[] Image { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}