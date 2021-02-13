using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SharingIsCaring.Data;
using SharingIsCaring.Models;
using SharingIsCaring.Hubs.ChatHub;

namespace SharingIsCaring.Controllers
{
    [Authorize]
    public class MessagingController : Controller
    {
        private readonly SharingDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHubContext<MessageHub> _messageHubContext;

        public MessagingController(SharingDbContext dbcontext, UserManager<IdentityUser> userManager, IHubContext<MessageHub> hubContext)
        {
            _context = dbcontext;
            _userManager = userManager;
            _messageHubContext = hubContext;
        }
        
        //Renders view containing all messages in the user's messaging hub
        public IActionResult Index()
        {
            List<Messaging> messages = _context.Messages.ToList();
            return View(messages);
        }

        [HttpPost]
        public async Task<IActionResult> Index(Messaging message)
        {
            await _messageHubContext.Clients.All.SendAsync("sendToUser",
                message.MessageSubject, message.MessageBody);
            return View();
        }

        //Renders view containing selected message information
        public IActionResult ViewMessage(Messaging message)
        {
            return View(message);
        }

        //Renders view to create new message to send to another user
        public IActionResult CreateMessage(Messaging message)
        {
            if (ModelState.IsValid)
            {
                message.SenderId = _userManager.GetUserId(User);
                _context.Messages.Add(message);
                _context.SaveChanges();
                return Redirect("Index");
            }

            return View(message);
        }
    }
}
