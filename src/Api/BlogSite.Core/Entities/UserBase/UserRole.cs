﻿using BlogSite.Core.Entities.Base;

namespace BlogSite.Core.Entities.UserBase
{
    public class UserRole : BaseEntity
    {
        public int Role_ID { get; set; }
        public Role Role { get; set; }

        public int User_ID { get; set; }
        public User User { get; set; }
    }
}
