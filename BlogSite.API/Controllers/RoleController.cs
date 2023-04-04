﻿using AutoMapper;
using BlogSite.Core.DTOs.UserBase;
using BlogSite.Core.Entities.UserBase;
using BlogSite.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : BaseController
    {
        private readonly IService<Role, RoleDto, int> _service;

        public RoleController(IService<Role, RoleDto, int> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResult(await _service.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Save(RoleDto roleDto)
        {
            return CreateActionResult(await _service.AddAsync(roleDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(RoleDto roleDto)
        {
            return CreateActionResult(await _service.UpdateAsync(roleDto));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            return CreateActionResult(await _service.RemoveAsync(id));
        }
    }
}