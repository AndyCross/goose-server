using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Elastacloud.Spotify.Goose.Hubs
{
    public class GooseHub : Hub
    {

        public override Task OnConnected()
        {
            var group = Context.Request.QueryString["group"];

            return Groups.Add(Context.ConnectionId, group);
        }

        public Task Send(string data)
        {
            // Messages are sent with the following format
            // group:message
            string[] decoded = data.Split(':');
            string groupName = decoded[0];
            string message = decoded[1];

            // Send a message to the specified
            return Clients.Group(groupName).addMessage(message);
        }
    }
}