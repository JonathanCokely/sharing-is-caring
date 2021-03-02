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
        private readonly SharingDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public AssetController(SharingDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            _context = dbContext;
            _userManager = userManager;
        }

        //Returns Asset Index view
        public IActionResult Index()
        {
            List<Asset> assets = _context.Assets.ToList();
            return View(assets);
        }

        //User submits an asset to be added to their profile. Processed by ProcessAddAssetForm method
        public IActionResult Add()
        {
            List<Brand> brands = _context.Brands.ToList();
            List<AssetType> assetTypes = _context.AssetTypes.ToList();
            AddAssetViewModel addAssetViewModel = new AddAssetViewModel(brands, assetTypes);
            return View(addAssetViewModel);
        }

        //Performs model validation and posts valid model to the database
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

                _context.Assets.Add(theAsset);
                _context.SaveChanges();

                return Redirect("/Asset");
            }

            List<Brand> brands = _context.Brands.ToList();
            List<AssetType> assetTypes = _context.AssetTypes.ToList();
            AddAssetViewModel addNewViewModel = new AddAssetViewModel(brands, assetTypes);

            return View("Add", addNewViewModel);
        }

        //View the selected Asset
        public IActionResult ViewAsset(string assetId)
        {
            Asset theAsset = _context.Assets.FirstOrDefault(x => x.Id.ToString() == assetId);
            Brand theBrand = _context.Brands.FirstOrDefault(x => x.Id == theAsset.BrandId);
            AssetType theAssetType = _context.AssetTypes.FirstOrDefault(x => x.Id == theAsset.ItemTypeId);
            ViewAssetViewModel viewAssetViewModel = new ViewAssetViewModel(theAsset,theAssetType,theBrand);
            return View(viewAssetViewModel);
        }

        //Shifts the asset status between available and unavailable
        public IActionResult ChangeAssetStatus(string assetId)
        {
            Asset theAsset = _context.Assets.FirstOrDefault(x => x.Id.ToString() == assetId);
            if (theAsset.Available)
            {
                theAsset.Available = false;
            }
            else
            {
                theAsset.Available = true;
            }
            _context.SaveChanges();
            return Redirect("Index");
        }

        //Displays view of inactive assets
        public IActionResult InactiveAssets()
        {
            List<Asset> assets = _context.Assets.ToList();
            return View(assets);
        }

        //Activates an asset from the user's inactive asset library
        public IActionResult ActivateAsset(string assetId)
        {
            Asset theAsset = _context.Assets.FirstOrDefault(x => x.Id.ToString() == assetId);
            theAsset.ActiveInd = true;
            _context.SaveChanges();
            return Redirect("./InactiveAssets");
        }

        //Inactivates an asset from the user's inactive asset library
        public IActionResult InactivateAsset(string assetId)
        {
            Asset theAsset = _context.Assets.FirstOrDefault(x => x.Id.ToString() == assetId);
            theAsset.ActiveInd = false;
            _context.SaveChanges();
            return Redirect("Index");
        }

        //Returns search window
        public IActionResult Search()
        {
            List<Brand> brands = _context.Brands.ToList();
            List<AssetType> assetTypes = _context.AssetTypes.ToList();
            List<Asset> assets = new List<Asset>();
            SearchAssetViewModel searchAssetViewModel = new SearchAssetViewModel(brands, assetTypes, assets);
            return View(searchAssetViewModel);
        }

        //Returns a list of available assets meeting the criteria of the search
        public IActionResult Results(string searchSerialNumber, string searchDescription, string searchBrand, string searchItemType)
        {
            List<Brand> brands = _context.Brands.ToList();
            List<AssetType> assetTypes = _context.AssetTypes.ToList();
            List<Asset> assets = _context.Assets.Where(x => x.Available == true).ToList();

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

        //Generate request to return borrowed asset to owner
        [HttpPost]
        public IActionResult ReturnAsset(string assetId)
        {
            Asset theAsset = _context.Assets.FirstOrDefault(x => x.Id.ToString() == assetId);
            TransferRequest theRequest = new TransferRequest
            {
                Asset = theAsset,
                AssetId = theAsset.Id,
                TransferDate = DateTime.Now,
                ExpectedReturnDate = DateTime.Now,
                BorrowerId = _userManager.GetUserId(User),
                OwnerId = theAsset.OwnerId,
                Complete = false,
                ReturnRequest = true
            };
            _context.TransferRequests.Add(theRequest);
            _context.SaveChanges();
            return Redirect("Index");
        }
    }
}
