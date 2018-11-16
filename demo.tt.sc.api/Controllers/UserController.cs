using demo.tt.common.dataaccess.Interfaces;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace demo.mondo.api.Controllers
{
    [RoutePrefix("api/users")]
    public class UserController : ApiController
    {
        private readonly IUserContext userContext;
        public UserController(IUserContext userContext)
        {
            this.userContext = userContext;
        }

        /// <summary>
        /// Get All User
        /// </summary>
        /// <returns></returns>
        [Route("")]
        [HttpGet]
        public async Task<IHttpActionResult> GetAllUser()
        {
            return await Task.FromResult(Ok(userContext.Users));
        }

        /// <summary>
        /// Get All User
        /// </summary>
        /// <returns></returns>
        [Route("posttotest")]
        [HttpPost]
        public async Task<IHttpActionResult> PostWebHooks(JObject test)
        {
            var ddd = Request;
            // return BadRequest("hello bad request");
            return await Task.FromResult(Ok(userContext.Users));
        }

        /// <summary>
        /// Get All User
        /// </summary>
        /// <returns></returns>
        [Route("posttotest")]
        [HttpPatch]
        public async Task<IHttpActionResult> PatchWebHooks(JObject test)
        {
            var ddd = Request;
            // return BadRequest("hello bad request again");
            return await Task.FromResult(Ok(userContext.Users));
        }

        /// <summary>
        /// Get User by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("{id}")]
        [HttpGet]
        public async Task<IHttpActionResult> GetUserById(int id)
        {
            return await Task.FromResult(Ok(userContext.Users.Where(u => u.Id == id).FirstOrDefault()));
        }

        /// <summary>
        /// Get User by Name
        /// </summary>
        /// <param name="name></param>
        /// <returns></returns>
        [Route("{id}")]
        [HttpGet]
        public async Task<IHttpActionResult> GetUserByName(string name)
        {
            var result = await userContext.GetUserByName(name);
            if (result != null)
                return Ok(result);
            else
                return NotFound();
        }

    }
}
