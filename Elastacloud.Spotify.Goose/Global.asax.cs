using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Elastacloud.Spotify.Goose.Connections;
using Microsoft.AspNet.SignalR;

namespace Elastacloud.Spotify.Goose
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RouteTable.Routes.MapConnection<GooseConnection>("goose", "/goose");
            RouteTable.Routes.MapConnection<GooseSyncConnection>("gooseSync", "/goosesync");
            RouteTable.Routes.MapHubs("/gosling", new HubConfiguration() { EnableCrossDomain = true });
            RouteTable.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new {id = RouteParameter.Optional});
        }
    }
}