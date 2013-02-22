using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Elastacloud.Spotify.Goose.Connections
{
    public class GooseConnection : PersistentConnection
    {
        protected override Task OnConnected(IRequest request, string connectionId)
        {
            var group = request.QueryString["group"];

            return Groups.Add(connectionId, group);
        }


        protected override IEnumerable<string> OnRejoiningGroups(IRequest request, IEnumerable<string> groups, string connectionId)
        {
            return groups;
        }

        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            var group = request.QueryString["group"];

            // Send a message to the specified
            return Groups.Send(group, data);
        }

        protected override Task OnDisconnected(IRequest request, string connectionId)
        {
            return Groups.Remove(connectionId, request.QueryString["group"]);
        }

    }
}