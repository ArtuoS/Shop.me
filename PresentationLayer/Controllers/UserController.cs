using AutoMapper;
using Common;
using Entities.Entities;
using Entities.Enums;
using Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using PresentationLayer.Models.InsertViewModels;
using PresentationLayer.Models.QueryViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userBLL;
        private readonly IMapper mapper;

        public UserController(IUserService userBLL, IMapper mapper)
        {
            this.userBLL = userBLL;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(UserInsertViewModel model)
        {
            User user = mapper.Map<User>(model);
            var response = await userBLL.Insert(user);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id)
        {
            var user = await userBLL.GetById(id);
            if (user.Data != null)
            {
                var response = await userBLL.Update(user.Data);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            var response = await userBLL.Delete(id);
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Users()
        {
            var response = await userBLL.GetAll();

            if (!response.IsSuccess())
            {
                return View();
            }
            else
            {
                var users = mapper.Map<List<UserQueryViewModel>>(response.Data);
                return View(users);
            }
        }
    }
}