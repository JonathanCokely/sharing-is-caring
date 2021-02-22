using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SharingIsCaring.Controllers
{
    public class TransferRequestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewTransferRequest()
        {
            return View();
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
