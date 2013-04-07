// Type: Microsoft.AspNet.SignalR.GlobalHost
// Assembly: Microsoft.AspNet.SignalR.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: c:\dev\Elastacloud\spotify\Elastacloud.Spotify.Goose\packages\Microsoft.AspNet.SignalR.Core.1.0.0-rc2\lib\net40\Microsoft.AspNet.SignalR.Core.dll

using Microsoft.AspNet.SignalR.Configuration;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.AspNet.SignalR.Infrastructure;

namespace Microsoft.AspNet.SignalR
{
  public static class GlobalHost
  {
    public static IDependencyResolver DependencyResolver { get; set; }
    public static IConfigurationManager Configuration { get; }
    public static IConnectionManager ConnectionManager { get; }
    public static IHubPipeline HubPipeline { get; }
  }
}
