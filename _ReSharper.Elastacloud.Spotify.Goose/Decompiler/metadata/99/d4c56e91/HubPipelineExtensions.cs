// Type: Microsoft.AspNet.SignalR.HubPipelineExtensions
// Assembly: Microsoft.AspNet.SignalR.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: c:\dev\Elastacloud\spotify\Elastacloud.Spotify.Goose\packages\Microsoft.AspNet.SignalR.Core.1.0.0-rc2\lib\net40\Microsoft.AspNet.SignalR.Core.dll

using Microsoft.AspNet.SignalR.Hubs;

namespace Microsoft.AspNet.SignalR
{
  public static class HubPipelineExtensions
  {
    public static void EnableAutoRejoiningGroups(this IHubPipeline pipeline);
    public static void RequireAuthentication(this IHubPipeline pipeline);
  }
}
