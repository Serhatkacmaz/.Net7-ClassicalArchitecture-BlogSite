﻿using BlogSite.Core.DTOs.JWT;
using BlogSite.Web.ApiServices;
using BlogSite.Web.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace BlogSite.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AuthApiService _authApiService;

        public HomeController(ILogger<HomeController> logger, AuthApiService authApiService)
        {
            _logger = logger;
            _authApiService = authApiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}