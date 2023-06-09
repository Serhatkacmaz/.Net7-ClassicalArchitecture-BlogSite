﻿using BlogSite.API.Filters;
using BlogSite.Common.DTOs.Transaction;
using BlogSite.Common.Enums;
using BlogSite.Core.Entities.Transaction;
using BlogSite.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.API.Controllers
{
    [Route("api/[controller][action]")]
    [Route("api/[controller]")]
    [ApiController]
    public class MovementController : BaseController
    {
        private readonly IMovementService _movementService;

        public MovementController(IMovementService movementService)
        {
            _movementService = movementService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResult(await _movementService.GetAllAsync());
        }

        [HttpGet("{id}")]
        [ServiceFilter(typeof(NotFoundFilter<TMovement, TMovementDto>))]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _movementService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save(TMovementDto MovementDto)
        {
            return CreateActionResult(await _movementService.AddAsync(MovementDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(TMovementDto MovementDto)
        {
            return CreateActionResult(await _movementService.UpdateAsync(MovementDto));
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(NotFoundFilter<TMovement, TMovementDto>))]
        public async Task<IActionResult> Remove(int id)
        {
            return CreateActionResult(await _movementService.RemoveAsync(id));
        }

        //->
        [HttpGet("GetTotalBlogLikeCount")]
        public IActionResult GetTotalBlogLikeCount()
        {
            return CreateActionResult(_movementService.Count(x => x.EUserReaction == EUserReaction.Like && x.IsActive));
        }

        [HttpGet("GetTotalBlogLikeCountByUserId/{userId}")]
        public IActionResult GetTotalBlogLikeCountByUserId(int userId)
        {
            return CreateActionResult(_movementService.Count(x => x.EUserReaction == EUserReaction.Like && x.User_ID == userId));
        }

        [HttpGet("GetTotalBlogDisLikeCount")]
        public IActionResult GetTotalBlogDisLikeCount()
        {
            return CreateActionResult(_movementService.Count(x => x.EUserReaction == EUserReaction.DisLike && x.IsActive));
        }

        [HttpGet("GetTotalBlogDisLikeCountByUserId/{userId}")]
        public IActionResult GetTotalBlogDisLikeCountByUserId(int userId)
        {
            return CreateActionResult(_movementService.Count(x => x.EUserReaction == EUserReaction.DisLike && x.User_ID == userId));
        }

        [HttpGet("[action]/{userId}/")]
        public async Task<IActionResult> GetLikeBlogId(int userId)
        {
            return CreateActionResult(await _movementService.Where(x => x.EUserReaction == EUserReaction.Like && x.User_ID == userId));
        }


        [HttpGet("[action]/{userId}/")]
        public async Task<IActionResult> GetDisLikeBlogId(int userId)
        {
            return CreateActionResult(await _movementService.Where(x => x.EUserReaction == EUserReaction.DisLike && x.User_ID == userId));
        }

        [HttpGet("GetTotalFavoriteCount")]
        public IActionResult GetTotalFavoriteCount()
        {
            return CreateActionResult(_movementService.Count(x => x.EUserReaction == EUserReaction.Favorite && x.IsActive));
        }

        [HttpGet("GetAllByBlogIdAndUserId/{blogId}/{userId}")]
        public async Task<IActionResult> GetAllByBlogIdAndUserId(int blogId, int userId)
        {
            return CreateActionResult(await _movementService.GetAllByBlogIdAndUserId(blogId, userId));
        }
    }
}
