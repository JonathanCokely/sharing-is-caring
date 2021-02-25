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

        public IActionResult Index()
        {
            List<TransferRequest> requestList = _context.TransferRequests.ToList();
            return View(requestList);
        }

        public IActionResult ViewTransferRequest(string viewRequest)
        {
            TransferRequest theRequest = _context.TransferRequests.FirstOrDefault(x => x.Id.ToString() == viewRequest);
            return View(theRequest);
        }
        
        //Complete Transfer Request and update Asset info
        [HttpPost]
        public IActionResult TransferAsset()
        {
            return View();
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
