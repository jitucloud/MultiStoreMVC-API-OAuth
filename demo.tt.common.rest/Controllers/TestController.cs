using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace demo.tt.common.rest.Controllers
{
    [RoutePrefix("api/test")]

    public class TestController : RestApiController
    {
        [Route("")]
        [HttpGet]
        public async Task<IHttpActionResult> GetFromTest()
        {
            return await Task.FromResult(Ok("form-Test"));
        }
    }
}
