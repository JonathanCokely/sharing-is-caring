using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SharingIsCaring.Data;
using SharingIsCaring.Models;

namespace SharingIsCaring.Controllers
{
    public class AssetTypeController : Controller
    {
        private readonly SharingDbContext context;

        public AssetTypeController (SharingDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            List<AssetType> assetTypes = context.AssetTypes.ToList();
            return View(assetTypes);
        }

        public IActionResult Add()
        {
            AssetType assetType = new AssetType();
            return View(assetType);
        }

        [HttpPost]
        public IActionResult Add(AssetType assetType)
        {
            if (ModelState.IsValid)
            {
                context.AssetTypes.Add(assetType);
                context.SaveChanges();
                return Redirect("/AssetType/");
            }

            return View("Add", assetType);
        }
    }
}
