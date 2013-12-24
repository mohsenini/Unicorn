using System.Collections.Generic;
using System.Linq;
using System.Web;
using N2;
using N2.Definitions;
using UnicornCreations.Models.Pages;

namespace UnicornCreations
{
	public static class Defaults
	{
		public static class Containers
		{
			public const string Metadata = "Metadata";
			public const string Content = "Content";
			public const string Site = "Site";
			public const string Advanced = "Advanced";
		}
		
		public static string ImageSize(string preferredSize, string fallbackToZoneNamed)
		{
			if (string.IsNullOrEmpty(preferredSize))
				return ImageSize(fallbackToZoneNamed);
			return preferredSize;
		}

		public static string ImageSize(string zoneName)
		{
			switch (zoneName)
			{
				case "SliderArea":
				case "PreContent":
				case "PostContent":
					return "wide";
				default:
					return "half";
			}
		}


		/// <summary>
		/// Picks the translation best matching the browser-language or the first translation in the list
		/// </summary>
		/// <param name="request"></param>
		/// <param name="currentPage"></param>
		/// <returns></returns>
		public static ContentItem SelectLanguage(this HttpRequestBase request, ContentItem currentPage)
		{
			var start = Find.ClosestOf<IStartPage>(currentPage) ?? N2.Find.StartPage;
			if (start == null) return null;

			return start;
		}

		private static IEnumerable<StartPage> GetTranslations(ContentItem currentPage)
		{
			return currentPage.GetChildren().OfType<StartPage>();
		}
	}
}