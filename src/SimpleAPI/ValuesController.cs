using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleAPI
{
    [Route("[controller]")]
     public class ValuesController : Controller
    {
        // GET: api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "Pradeep", "Amar" };
        }

        // GET: api/values/5
        public string Get(int id)
        {
            Get obj=new Get();
            return "Amar";
        }

        // POST: api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/values/5
        public void Delete(int id)
        {
        }
    }
}