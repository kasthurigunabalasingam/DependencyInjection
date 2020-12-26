using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DIAsp.Models;

namespace DIAsp.Controllers
{
    public class HomeController : Controller
    {
        public IUserRepo _userRepo;

        public HomeController( IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public string Index()
        {
            return _userRepo.GetUser(1).Name;
        }
    }
}
