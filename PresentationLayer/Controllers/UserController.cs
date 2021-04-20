using AutoMapper;
using Common;
using Entities.Entities;
using Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models.InsertViewModels;
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
        public async Task<IActionResult> Insert([FromBody] UserInsertViewModel model)
        {
            User user = mapper.Map<User>(model);
            Response response = await userBLL.Insert(user);
            return View();
        }
    }
}
