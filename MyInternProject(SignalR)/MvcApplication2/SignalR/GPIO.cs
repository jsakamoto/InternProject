using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.SignalR
{
    public class GPIO
    {
		
		private readonly static Lazy<GPIO> _instance = new Lazy<GPIO>(() => new GPIO(GlobalHost.ConnectionManager.GetHubContext<GPIOHub>().Clients));

		private IHubConnectionContext Clients { get; set; }

		private GPIO(IHubConnectionContext clients)
		{
			Clients = clients;
		}

		public static GPIO Instance
		{
			get { return _instance.Value; }
		}

		public void UpdateButtonStatus(string status)
		{
            Clients.All.updateStatus(status);
		}


    }
}