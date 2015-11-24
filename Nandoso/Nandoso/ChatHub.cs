using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Nandoso
{
    public class ChatHub : Hub
    {
        public void Send(string username, string message)
        {
            //broadcast what we pass across the network so everyone in it will be able to see it
            Clients.All.broadcastMessage(username, message);
        }
    }
}