using System.Web.Mvc;
using N2.Web.Mvc;
using N2.Web;
using UnicornCreations.Models.Parts;

namespace UnicornCreations.Controllers
{
	[Controls(typeof(ContentPart))]
	public class ContentPartsController : ContentController<ContentPart>
	{

		public override ActionResult Index()
		{
			return PartialView((string)CurrentItem.TemplateKey, CurrentItem);
		}

	}

	[Controls(typeof(Slideshow))]
	public class SlideshowController : ContentController<Slideshow>
	{
		public override ActionResult Index()
		{
			return PartialView((string)CurrentItem.TemplateKey, CurrentItem);
		}
	}

}
