using N2.Web;
using N2.Web.Mvc;
using UnicornCreations.Models.Pages;

namespace UnicornCreations.Controllers
{
	[Controls(typeof(PageModelBase))]
	public class FallbackController : ContentController
	{
	}
}
