﻿using FinalProject.Web.Models;
using Foundation.Library.Services;
using Membership.Library.Constants;
using Membership.Library.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FinalProject.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmployeeService _employeeService;
        protected readonly IHttpContextAccessor _httpContextAccessor;
        public AccountController(
            SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager,
            IHttpContextAccessor httpContextAccessor,
            IEmployeeService employeeService
            )
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> LoginAsync()
        {
            var model = new LoginModel();

            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByNameAsync(model.Email);
                    var claims = await _userManager.GetClaimsAsync(user);

                    //_httpContextAccessor.HttpContext.Session.Clear();

                    var claimsIdentity = new ClaimsIdentity(
                      claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authProperties = new AuthenticationProperties();

                    await HttpContext.SignInAsync(
                      CookieAuthenticationDefaults.AuthenticationScheme,
                      new ClaimsPrincipal(claimsIdentity),
                      authProperties);

                    if (claims.Where(x => x.Type == MembershipClaims.AdminClaimType).Any())
                        return RedirectToAction("Index", "Home", new { Area = "Admin" });
                    else if(claims.Where(x => x.Type == MembershipClaims.MemberClaimType).Any())
                    {
                        var member = _employeeService.GetAllEmployees().Where(x => x.UserId == user.Id).FirstOrDefault();
                        return RedirectToAction("Profile", "Home", new { Area = "Employee", id =  member.Id});
                    }
                    
                    return RedirectToAction("Index", "Home");
                }

                ViewData["error"] = "Username or Password incorrect";
            }
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }
    }
}
