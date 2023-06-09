﻿using BlogSite.Common.DTOs;
using BlogSite.Common.DTOs.Transaction;

namespace BlogSite.Web.ApiServices
{
    public class MovementApiService
    {
        private readonly HttpClient _httpClient;

        public MovementApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<int> GetTotalBlogLikeCountAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<BlogSiteResponseDto<int>>("movement/GetTotalBlogLikeCount");
            return response.Data;
        }

        public async Task<bool> Remove(int id)
        {
            var response = await _httpClient.DeleteAsync($"movement/{id}");
            return response.IsSuccessStatusCode;
        }

        public async Task<int> GetTotalBlogLikeCountByUserIdAsync(int userId)
        {
            var response = await _httpClient.GetFromJsonAsync<BlogSiteResponseDto<int>>($"movement/GetTotalBlogLikeCountByUserId/{userId}");
            return response.Data;
        }

        public async Task<int> GetTotalBlogDisLikeCountAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<BlogSiteResponseDto<int>>("movement/GetTotalBlogDisLikeCount");
            return response.Data;
        }

        public async Task<int> GetTotalBlogDisLikeCountByUserIdAsync(int userId)
        {
            var response = await _httpClient.GetFromJsonAsync<BlogSiteResponseDto<int>>($"movement/GetTotalBlogDisLikeCountByUserId/{userId}");
            return response.Data;
        }


        public async Task<int> GetTotalFavoriteCountAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<BlogSiteResponseDto<int>>("movement/GetTotalFavoriteCount");
            return response.Data;
        }

        public async Task<BlogSiteResponseDto<TMovementDto>> SaveAsync(TMovementDto movementDto)
        {
            var response = await _httpClient.PostAsJsonAsync("movement", movementDto);
            return await response.Content.ReadFromJsonAsync<BlogSiteResponseDto<TMovementDto>>();
        }

        public async Task<List<TMovementDto>> GetAllByBlogIdAndUserId(int blogId, int userId)
        {
            var response = await _httpClient.GetFromJsonAsync<BlogSiteResponseDto<List<TMovementDto>>>($"movement/GetAllByBlogIdAndUserId/{blogId}/{userId}");
            return response.Data;
        }

        public async Task<List<TMovementDto>> GetLikeBlogId(int userId)
        {
            var response = await _httpClient.GetFromJsonAsync<BlogSiteResponseDto<List<TMovementDto>>>($"movement/GetLikeBlogId/{userId}");
            return response.Data;
        }

        public async Task<List<TMovementDto>> GetDislikeBlogId(int userId)
        {
            var response = await _httpClient.GetFromJsonAsync<BlogSiteResponseDto<List<TMovementDto>>>($"movement/GetDislikeBlogId/{userId}");
            return response.Data;
        }
    }
}
