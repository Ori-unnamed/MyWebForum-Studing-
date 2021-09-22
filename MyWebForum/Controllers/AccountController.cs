using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyWebForum.Models;
using MyWebForum.Services;
using System;
using System.Threading.Tasks;

namespace MyWebForum.Controllers
{
    public class Tag
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }
    public class AccountController : Controller
    {
        private readonly UserManager<Useraccount> _userManager;
        private readonly SignInManager<Useraccount> _signInManager;
        private readonly IAccountProfileService _profileService;
        public AccountController(UserManager<Useraccount> userManager, SignInManager<Useraccount> siginManager
         , IAccountProfileService profileService)
        {
            _userManager = userManager;
            _signInManager = siginManager;
            _profileService = profileService;
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Reg_in([FromBody] Tag tag)
        {
            try
            {
                var user = new Useraccount
                {
                    RegTime = DateTime.Now,
                    UserName = tag.UserName,
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                };
                var result = await _userManager.CreateAsync(user, tag.PassWord);
                if (result.Succeeded)
                    return Ok("注册成功");
                else
                    return NotFound("注册失败");
            }
            catch (Exception e)
            {
                return NotFound($"注册失败，{e.Message}");
            }
        }
        [HttpPost]
        [AllowAnonymous]

        public async Task<IActionResult> Log_in([FromBody] Tag tag)
        {
            try
            {
                var result = await _signInManager.PasswordSignInAsync(tag.UserName, tag.PassWord, true, false);
                if (result.Succeeded)
                    return Ok("登录成功");
                else
                    return NotFound("登陆失败");
            }
            catch (Exception e)
            {
                return NotFound("登陆失败");
            }
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            Useraccount user = _userManager.GetUserAsync(HttpContext.User).Result;
            var userprofile = _profileService.getProfile(user.UserNo);
            return View("Index", new Tuple<Useraccount,Userprofile>(user,userprofile));
        }
        [AllowAnonymous]
        
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}