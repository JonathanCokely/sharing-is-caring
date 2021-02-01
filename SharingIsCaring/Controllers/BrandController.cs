using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SharingIsCaring.Data;
using SharingIsCaring.Models;

namespace SharingIsCaring.Controllers
{
    public class BrandController : Controller
    {
        private readonly SharingDbContext context;
        public BrandController(SharingDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            List<Brand> brands = context.Brands.ToList();
            return View(brands);
        }

        public IActionResult Add()
        {
            Brand brand = new Brand();
            return View(brand);
        }

        [HttpPost]
        public IActionResult Add(Brand brand)
        {
            if (ModelState.IsValid)
            {
                context.Brands.Add(brand);
                context.SaveChanges();
                return Redirect("/Brand/");
            }

            return View("Add", brand);
        }
    }
}
