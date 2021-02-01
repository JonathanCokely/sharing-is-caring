using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SharingIsCaring.Data;
using SharingIsCaring.Models;
using SharingIsCaring.ViewModels;

namespace SharingIsCaring.Controllers
{
    public class AssetController : Controller
    {
        private readonly SharingDbContext context;

        public AssetController(SharingDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            List<Asset> assets = context.Assets.ToList();
            return View(assets);
        }

        
        public IActionResult Add()
        {
            List<Brand> brands = context.Brands.ToList();
            List<AssetType> assetTypes = context.AssetTypes.ToList();
            AddAssetViewModel addAssetViewModel = new AddAssetViewModel(brands, assetTypes);
            return View(addAssetViewModel);
        }

        [HttpPost]
        public IActionResult ProcessAddAssetForm(AddAssetViewModel addAssetViewModel)
        {

            if (ModelState.IsValid)
            {
                Asset theAsset = new Asset
                {
                    Description = addAssetViewModel.Description,
                    SerialNumber = addAssetViewModel.SerialNumber
                };

                context.Assets.Add(theAsset);
                context.SaveChanges();

                return Redirect("/Asset");
            }

            List<Brand> brands = context.Brands.ToList();
            List<AssetType> assetTypes = context.AssetTypes.ToList();
            AddAssetViewModel addNewViewModel = new AddAssetViewModel(brands, assetTypes);

            return View("Add", addNewViewModel);
        }

        public IActionResult Search()
        {
            return View();
        }
    }
}
