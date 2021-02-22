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

        //Displays Asset Request lists on Request View
        public IActionResult Index()
        {
            List<AssetRequest> assetRequestList = _context.AssetRequests.ToList();
            List<Asset> assetList = _context.Assets.ToList();
            AssetRequestIndexViewModel viewModel = new AssetRequestIndexViewModel(assetList, assetRequestList);
            return View(viewModel);
        }

        //Displays Asset Request form data in form fields
        public IActionResult RequestAsset(string searchAsset)
        {
            RequestAssetViewModel requestAsset = new RequestAssetViewModel ();
            Asset targetAsset = _context.Assets.Where(x => x.Id.ToString() == searchAsset).FirstOrDefault();
            requestAsset.AssetId = targetAsset.Id;
            requestAsset.Subject = $"Request to Borrow: {targetAsset.Description}";
            return View(requestAsset);
        }

        //Posts Asset Request to the database
        [HttpPost]
        public IActionResult ProcessAssetRequest(RequestAssetViewModel requestAsset)
        {
            if (ModelState.IsValid)
            {
                AssetRequest theRequest = new AssetRequest()
                {
                    Subject = requestAsset.Subject,
                    Body = requestAsset.Body,
                    AssetId = requestAsset.AssetId,
                    BorrowerId = _userManager.GetUserId(User),
                    FromDate = DateTime.Parse(requestAsset.FromDate),
                    ToDate = DateTime.Parse(requestAsset.ToDate)
                };
                _context.AssetRequests.Add(theRequest);
                _context.SaveChanges();
                return Redirect("Index");
            }

            return View("RequestAsset", requestAsset);
        }

        //View the details of a particular request
        public IActionResult ViewAssetRequest(string viewRequest)
        {
            AssetRequest theRequest = _context.AssetRequests.FirstOrDefault(x => x.Id.ToString() == viewRequest);
            return View(theRequest);
        }

        //Convert Asset Request to Transfer Request
        [HttpPost]
        public IActionResult ApproveAssetRequest(string acceptId)
        {
            TransferRequest theRequest = new TransferRequest();
            return Redirect("Index");
        }

        //Reject Asset Request and return to Index
        [HttpPost]
        public IActionResult RejectAssetRequest(string rejectId)
        {
            AssetRequest theRequest = _context.AssetRequests.FirstOrDefault(x=>x.Id.ToString()==rejectId);
            _context.AssetRequests.Remove(theRequest);
            _context.SaveChanges();
            return Redirect("Index");
        }

    }
}
