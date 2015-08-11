using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebLog.Hubs;

namespace WebLog.Controllers
{
    public class LogController : ApiController
    {
        // GET: api/Log
        public IEnumerable<string> Get()
        {
            LogHub.PublishLog("Info", "LogControllerGet  called");

            return new string[] { "value1", "value2" };
        }

        // GET: api/Log/5
        public string Get(string id)
        {
            LogHub.PublishLog("Info", "LogControllerGet: " + id);
            return "value";
        }

        // POST: api/Log
        public void Post([FromBody]string value)
        {
            LogHub.PublishLog("Info", "LogControllerGet  called");
        }

        // PUT: api/Log/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Log/5
        public void Delete(int id)
        {
        }
    }
}
