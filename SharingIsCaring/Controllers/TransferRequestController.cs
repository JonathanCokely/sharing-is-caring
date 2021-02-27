using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SharingIsCaring.Data;
using SharingIsCaring.Models;

namespace SharingIsCaring.Controllers
{
    public class TransferRequestController : Controller
    {
        private readonly SharingDbContext _context;

        public TransferRequestController(SharingDbContext context)
        {
            _context = context;
        }

        //Displays pending TransferRequest list and completed Transfers
        public IActionResult Index()
        {
            List<TransferRequest> requestList = _context.TransferRequests.ToList();
            return View(requestList);
        }

        //Displays the selected TransferRequest
        public IActionResult ViewPendingTransferRequest(string viewRequest)
        {
            TransferRequest theRequest = _context.TransferRequests.FirstOrDefault(x => x.Id.ToString() == viewRequest);
            return View(theRequest);
        }
        
        //Complete Transfer Request and update Asset info
        [HttpPost]
        public IActionResult TransferAsset(string acceptId)
        {
            TransferRequest theRequest = _context.TransferRequests.FirstOrDefault(x => x.Id.ToString() == acceptId);
            theRequest.TransferDate = DateTime.Now;
            theRequest.Complete = true;
            _context.Assets.FirstOrDefault(x => x.Id == theRequest.AssetId).LastTransferDate = DateTime.Now;
            _context.Assets.FirstOrDefault(x => x.Id == theRequest.AssetId).BorrowerId = theRequest.BorrowerId;
            _context.Assets.FirstOrDefault(x => x.Id == theRequest.AssetId).Availabile = false;
            _context.SaveChanges();
            return Redirect("Index");
        }

        //Reject Transfer Request and return to Index
        [HttpPost]
        public IActionResult RejectTransfer(string rejectId)
        {
            TransferRequest theRequest = _context.TransferRequests.FirstOrDefault(x => x.Id.ToString() == rejectId);
            _context.TransferRequests.Remove(theRequest);
            _context.SaveChanges();
            return Redirect("Index");
        }
    }
}
