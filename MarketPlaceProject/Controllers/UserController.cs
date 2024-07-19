using AutoMapper;
using ServiceLayer.DTOs;
using ServiceLayer.Interfaces;
using ServiceLayer.Services;
using MarketPlaceProject.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MarketPlaceProject.Controllers
{
    public class UserController : Controller
    {
        public IUserService userService;
        private Mapper DTOMapper;

        public UserController()
        {
            userService = new UserService();
            var DTOConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserDTO, UserVM>();
                cfg.CreateMap<UserVM, UserDTO>();
            });
            DTOMapper = new Mapper(DTOConfig);
        }

        public ActionResult UserList()
        {
            var users = DTOMapper.Map<List<UserVM>>(userService.GetAllUsers());
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
                var userDTO = DTOMapper.Map<UserDTO>(userVM);
                userService.CreateUser(userDTO);
                return RedirectToAction("UserList");
            }
            return View(userVM);
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}