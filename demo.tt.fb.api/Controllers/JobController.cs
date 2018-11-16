using System.Threading.Tasks;
using System.Web.Http;

namespace demo.fmc.api.Controllers
{
    [RoutePrefix("api/jobs")]
    public class JobController : ApiBaseController
    {        
        /// <summary>
        /// Get Job Status
        /// </summary>
        /// <returns></returns>
        [Route("")]
        [HttpGet]
        public async Task<IHttpActionResult> GetJobStatus()
        {
            return await Task.FromResult(Ok("jobs-success"));
        }
    }
}
