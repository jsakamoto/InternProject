using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace MvcApplication2.SignalR
{
    public class GPIOHub : Hub
    {
        public void UpdateButtonStatus(string status)
        {
            Clients.All.updateStatus(status);
        }
    }
}