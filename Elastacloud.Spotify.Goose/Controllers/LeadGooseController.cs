using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Elastacloud.Spotify.Goose.Connections;
using Elastacloud.Spotify.Goose.Hubs;
using Microsoft.AspNet.SignalR;

namespace Elastacloud.Spotify.Goose.Controllers
{
    public class LeadGooseController : ApiController
    {
        // GET api/leadgoose
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/leadgoose/5
        public string Get(int id)
        {
            var context = GlobalHost.ConnectionManager.GetConnectionContext<GooseConnection>();
            context.Groups.Send(id.ToString(), "this was a hack");

            return "value";
        }

        // POST api/leadgoose
        public void Post([FromBody]string value)
        {
        }

        // PUT api/leadgoose/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/leadgoose/5
        public void Delete(int id)
        {
        }
    }
}
