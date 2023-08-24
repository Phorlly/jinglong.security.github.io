using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_Application.Controllers.API
{
    public class RandomStringController : ApiController
    {
        [Route("api/RandomString/Item/{rd}")]
        [HttpGet]
        public IHttpActionResult RandomStringById(int rd)
        {
            List<string> list = new List<string>();
            for(int i = 0; i < rd; i++)
            {
                Guid guid = Guid.NewGuid();
                list.Add(guid.ToString());
            }
            return Ok(list);
            //Testing 123
        }

        [HttpGet]
        public IHttpActionResult RandomString()
        {
            List<string> list = new List<string>();
            Random random = new Random();

            int rd = random.Next(10);

            for (int i = 0; i < rd; i++)
            {
                Guid guid = Guid.NewGuid();
                list.Add(guid.ToString());
            }

            return Ok(list);
        }
    }
}
