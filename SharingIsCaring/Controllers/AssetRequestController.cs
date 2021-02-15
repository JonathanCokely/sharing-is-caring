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
    public class AssetRequestController : Controller
    {
        private readonly SharingDbContext _context;

        public AssetRequestController(SharingDbContext dbContext)
        {
            _context = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult RequestAsset(string searchAsset)
        {
            AssetRequest assetRequest = new AssetRequest();
            assetRequest.Asset = _context.Assets.Where(x => x.Id.ToString()==searchAsset).FirstOrDefault();
            return View(assetRequest);
        }

        [HttpPost]
        public IActionResult ProcessAssetRequest(AssetRequest assetRequest)
        {
            if (ModelState.IsValid)
            {
                return Redirect("Index");
            }

            return View("RequestAsset", assetRequest);
        }
    }
}
