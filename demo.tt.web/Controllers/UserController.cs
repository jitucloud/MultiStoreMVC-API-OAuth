using demo.tt.common.dataaccess.Interfaces;
using System.Linq;
using System.Web.Mvc;

namespace demo.fmc.web.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserContext userContext;
        public UserController(IUserContext userContext)
        {
            this.userContext = userContext;
        }

        // GET: User
        public ActionResult Index()
        {
            var ddd = userContext.Users.ToList();
            return View(ddd);
        }
    }
}