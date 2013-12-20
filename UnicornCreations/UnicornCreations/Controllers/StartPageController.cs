using System.Web.Mvc;
using N2.Web;
using N2.Web.Mvc;
using UnicornCreations.Models.Pages;

namespace UnicornCreations.Controllers
{
    [Controls(typeof(StartPage))]
    public class StartPageController : ContentController<StartPage>
    {
        //
        // GET: /StartPage/

        public ActionResult Index()
        {
            return View();
        }

    }
}
