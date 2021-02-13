using Microsoft.AspNetCore.SignalR;
using SharingIsCaring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.Hubs.ChatHub
{
    public class MessageHub : Hub
    {
        public async Task SendMessage(Messaging message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
