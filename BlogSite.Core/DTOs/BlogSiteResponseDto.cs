﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlogSite.Core.DTOs
{
    public class BlogSiteResponseDto<T>
    {
        public T Data { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }

        public List<string> Errors { get; set; }

        //Static Factory Design Pattern
        #region Success
        public static BlogSiteResponseDto<T> Success(int statusCode, T data)
        {
            return new BlogSiteResponseDto<T> { Data = data, StatusCode = statusCode };
        }

        public static BlogSiteResponseDto<T> Success(int statusCode)
        {
            return new BlogSiteResponseDto<T> { StatusCode = statusCode };
        }
        #endregion

        #region Fail
        public static BlogSiteResponseDto<T> Fail(int statusCode, List<string> errors)
        {
            return new BlogSiteResponseDto<T> { StatusCode = statusCode, Errors = errors };
        }

        public static BlogSiteResponseDto<T> Fail(int statusCode, string error)
        {
            return new BlogSiteResponseDto<T> { StatusCode = statusCode, Errors = new List<string> { error } };
        }
        #endregion

    }
}
