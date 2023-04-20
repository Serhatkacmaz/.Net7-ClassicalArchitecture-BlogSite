﻿using BlogSite.Core.Entities.Base;
using BlogSite.Core.Entities.UserBase;

namespace BlogSite.Core.Entities.Transaction
{
    public class TComment : BlogSiteMasterBaseEntity
    {
        public string Comment { get; set; }
        public int ParentId { get; set; }

        public int Blog_ID { get; set; }
        public TBlog Blog { get; set; }

        public int User_ID { get; set; }
        public User User { get; set; }
    }
}
