using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharingIsCaring.Areas.Identity.Data;
using SharingIsCaring.Data;
using SharingIsCaring.Models;
using SharingIsCaring.ViewModels;


namespace SharingIsCaring.Controllers
{
    public class AssetController : Controller
    {
        private readonly SharingDbContext context;
        private readonly UserManager<IdentityUser> _userManager;
        public AssetController(SharingDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            context = dbContext;
            _userManager = userManager;
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
                    SerialNumber = addAssetViewModel.SerialNumber,
                    OwnerId = _userManager.GetUserId(User)
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
            List<Brand> brands = context.Brands.ToList();
            List<AssetType> assetTypes = context.AssetTypes.ToList();
            List<Asset> assets = new List<Asset>();
            SearchAssetViewModel searchAssetViewModel = new SearchAssetViewModel(brands, assetTypes, assets);
            return View(searchAssetViewModel);
        }

        public IActionResult Results(string searchSerialNumber, string searchDescription, string searchBrand, string searchItemType)
        {
            List<Brand> brands = context.Brands.ToList();
            List<AssetType> assetTypes = context.AssetTypes.ToList();
            List<Asset> assets = context.Assets.ToList();

            //Filter results by searching serial number
            if (!string.IsNullOrEmpty(searchSerialNumber))
            {
                assets = assets.Where(x => x.SerialNumber.ToLower() == searchSerialNumber.ToLower()).ToList();
            }

            //Filter results by searching description
            if (!string.IsNullOrEmpty(searchDescription))
            {
                assets = assets.Where(x => x.Description.ToLower().Contains(searchDescription.ToLower())).ToList();
            }

            //Filter results by brand
            if(!string.IsNullOrEmpty(searchBrand))
            {
                assets = assets.Where(x => x.BrandId.ToString()==searchBrand).ToList();
            }

            //Filter results by item type
            if (!string.IsNullOrEmpty(searchItemType))
            {
                assets = assets.Where(x => x.ItemTypeId.ToString()==searchItemType).ToList();
            }

            SearchAssetViewModel newSearchAssetViewModel = new SearchAssetViewModel(brands, assetTypes, assets);
            return View("Search", newSearchAssetViewModel);
        }
    }
}
