using AutoMapper;
using ServiceLayer.DTOs;
using ServiceLayer.Interfaces;
using ServiceLayer.Services;
using MarketPlaceProject.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Security;
using System.IO;
using System.Web;
using System;

namespace MarketPlaceProject.Controllers
{
    public class UserController : Controller
    {
        public IUserService userService;
        private readonly Mapper userMapper;

        public UserController()
        {
            userService = new UserService();
            var UserConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserDTO, UserVM>();
                cfg.CreateMap<UserVM, UserDTO>();
            });
            userMapper = new Mapper(UserConfig);
        }

        public ActionResult UserList()
        {
            var users = userMapper.Map<List<UserVM>>(userService.GetAllUsers());
            return View(users);
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Signup([Bind(Include = "Username,Email,Password,ConfirmedPassword")] UserVM userVM)
        {
            if (ModelState.IsValid)
            {
                var userDTO = userMapper.Map<UserDTO>(userVM);
                userService.CreateUser(userDTO);
                return RedirectToAction("Login");
            }
            return View(userVM);
        }



        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userDTO = userService.GetUserByEmailandPassword(model.EmailOrUsername, model.Password);
                if (userDTO != null)
                {
                    FormsAuthentication.SetAuthCookie(userDTO.Email, false);
                    return RedirectToAction("../Product/MainPage");
                }
                ModelState.AddModelError("", "Invalid email or password.");
            }
            return View(model);
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}