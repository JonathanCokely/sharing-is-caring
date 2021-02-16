using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SharingIsCaring.Data;
using SharingIsCaring.Models;
using SharingIsCaring.ViewModels;

namespace SharingIsCaring.Controllers
{
    public class AssetRequestController : Controller
    {
        private readonly SharingDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public AssetRequestController(SharingDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            _context = dbContext;
            _userManager = userManager;
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
                assetRequest.BorrowerId = _userManager.GetUserId(User);
                _context.AssetRequests.Add(assetRequest);
                Console.WriteLine(assetRequest);
                _context.SaveChanges();
                return Redirect("Index");
            }

            return View("RequestAsset", assetRequest);
        }
    }
}
