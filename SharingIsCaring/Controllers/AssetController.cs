using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using SharingIsCaring.Areas.Identity.Data;
using SharingIsCaring.Data;
using SharingIsCaring.Models;
using SharingIsCaring.ViewModels;

namespace SharingIsCaring.Controllers
{
    public class AssetController : Controller
    {
        private readonly SharingDbContext context;
        private readonly UserManager<SharingIsCaringUser> _userManager;

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
                    BrandId = addAssetViewModel.BrandId,
                    Description = addAssetViewModel.Description,
                    ItemTypeId = addAssetViewModel.ItemTypeId,
                    SerialNumber = addAssetViewModel.SerialNumber
                    //OwnerId = _userManager.GetUserAsync(User).Id
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
