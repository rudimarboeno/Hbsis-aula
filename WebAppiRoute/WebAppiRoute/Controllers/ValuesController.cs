using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppiRoute.Controllers
{
    public class ValuesController : ApiController
    {
        [Route("Api/Values/{filter}/contendo")]
        [HttpGet]
        public IEnumerable<string> ObterPorTipo(string filter)
        {
            var listaInfo = new List<string>()
            {
                "Contem 1",
                "Contem 1.1",
                "Contem 1.2",
                "Contem 1.3",
                "Contem 1.4",
                "Contem 1.5",
                "Contem 1.6",
                "Contem 1.3",
                "Contem 1.6",
            };

            return listaInfo.Where(x => x.Contains(filter));
        }

        [NonAction]
        public IEnumerable<string> ObtemSenhas(string filter)
        {
            return new string[] { "admin", "123" };
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
