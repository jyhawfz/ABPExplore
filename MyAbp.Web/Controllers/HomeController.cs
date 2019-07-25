using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace MyAbp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyAbpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}