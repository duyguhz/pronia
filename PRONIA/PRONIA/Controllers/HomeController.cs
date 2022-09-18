using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pronia.DAL;
using PRONIA.Models;
using PRONIA.ViewModels.Home;

namespace PRONIA.Controllers
{
    public class HomeController : Controller

    {

        ProniaContext _context;
        public HomeController(ProniaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVm vm = new HomeVm();
            vm.Sliders = _context.Sliders.OrderBy(x => x.Order);
            vm.Services = _context.Services;
            return View(vm);
        }

     
    }
}
