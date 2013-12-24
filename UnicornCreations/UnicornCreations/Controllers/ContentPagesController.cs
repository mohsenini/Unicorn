using System.Web.Mvc;
using N2.Web;
using N2.Web.Mvc;
using UnicornCreations.Models.Pages;

namespace UnicornCreations.Controllers
{
	[Controls(typeof(ContentPage))]
	public class ContentPagesController : ContentController<ContentPage>
	{

		public override ActionResult Index()
		{
			return View(CurrentItem.TemplateKey, CurrentItem);
		}
	}
}
