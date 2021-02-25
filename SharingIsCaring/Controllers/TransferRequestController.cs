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

        public IActionResult TransferAsset()
        {
            return View();
        }

        public IActionResult RejectTransfer()
        {
            return View();
        }
    }
}
