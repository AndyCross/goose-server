// Type: Microsoft.AspNet.SignalR.Hub
// Assembly: Microsoft.AspNet.SignalR.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: c:\dev\Elastacloud\spotify\Elastacloud.Spotify.Goose\Elastacloud.Spotify.Goose\bin\Microsoft.AspNet.SignalR.Core.dll

using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Threading.Tasks;

namespace Microsoft.AspNet.SignalR
{
  public abstract class Hub : IHub, IDisposable
  {
    public virtual Task OnDisconnected();
    public virtual Task OnConnected();
    public virtual Task OnReconnected();
    protected virtual void Dispose(bool disposing);
    public void Dispose();
    public HubConnectionContext Clients { get; set; }
    public HubCallerContext Context { get; set; }
    public IGroupManager Groups { get; set; }
  }
}
