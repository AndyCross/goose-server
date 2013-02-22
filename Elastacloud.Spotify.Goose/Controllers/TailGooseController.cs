using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Elastacloud.Spotify.Goose.Connections;
using Microsoft.AspNet.SignalR;

namespace Elastacloud.Spotify.Goose.Controllers
{
    public class TailGooseController : ApiController
    {
        // GET api/tailgoose
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/tailgoose/5
        public string Get(int id)
        {
            var context = GlobalHost.ConnectionManager.GetConnectionContext<GooseConnection>();
            context.Connection.Broadcast("this was a hack");

            return "value";
        }

        // POST api/tailgoose
        public void Post([FromBody]string value)
        {
        }

        // PUT api/tailgoose/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/tailgoose/5
        public void Delete(int id)
        {
        }
    }
}
