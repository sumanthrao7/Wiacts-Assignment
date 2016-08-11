using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Weacts
{
    public class MyHub : Hub
    {
        public void Hello()
        {
            //to delay 5 seconds
            System.Threading.Thread.Sleep(5000);
            string userName = "";
            if(HttpContext.Current != null && HttpContext.Current.User.Identity.IsAuthenticated)
            {
                userName = HttpContext.Current.User.Identity.Name;
            }
            Clients.All.showEmail("Hello! Your email id: " + userName);
        }
    }
}