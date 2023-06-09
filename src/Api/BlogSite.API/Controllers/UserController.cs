﻿using BlogSite.API.Filters;
using BlogSite.Common.DTOs.UserBase;
using BlogSite.Core.Entities.UserBase;
using BlogSite.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResult(await _userService.GetAllAsync());
        }

        [HttpGet("{id}")]
        [ServiceFilter(typeof(NotFoundFilter<User, UserDto>))]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _userService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save(UserDto userDto)
        {
            return CreateActionResult(await _userService.AddAsync(userDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(UserDto userDto)
        {
            return CreateActionResult(await _userService.UpdateAsync(userDto));
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(NotFoundFilter<User, UserDto>))]
        public async Task<IActionResult> Remove(int id)
        {
            return CreateActionResult(await _userService.RemoveAsync(id));
        }

        [HttpGet("GetUserCount")]
        public IActionResult GetUserCount()
        {
            return CreateActionResult(_userService.Count(x => x.IsActive));
        }

        [Authorize]
        [HttpGet("GetUserByName")]
        public async Task<IActionResult> GetUserByName()
        {
            return CreateActionResult(await _userService.GetUserByNameAsync(HttpContext.User.Identity.Name));
        }

    }
}
