using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace demo.fmc.api.Controllers
{

    [RoutePrefix("api/forms")]
    public class FormController : ApiBaseController
    {
        [Route("")]
        [HttpGet]
        public async Task<IHttpActionResult> GetFormStatus()
        {
            return await Task.FromResult(Ok("form-success"));
        }
    }
}
