
using Fiorello.DAL;
using Fiorello.Models;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Sliders = _db.Sliders.Take(3).ToList(),
                SliderData = _db.SliderDatas.FirstOrDefault(),
                Categories= _db.Categories.ToList(),
                Products= _db.Products.OrderByDescending(x=>x.Id).Skip(3).Take(8).ToList()
                
            };
            return View(homeVM);
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
