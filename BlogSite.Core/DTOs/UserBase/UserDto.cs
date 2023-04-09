﻿using BlogSite.Core.DTOs.Base;

namespace BlogSite.Core.DTOs.UserBase
{
    public class UserDto : BlogSiteMasterBaseDto
    {
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string About { get; set; }
    }
}
