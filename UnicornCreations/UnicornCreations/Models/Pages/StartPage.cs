using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using N2;
using N2.Definitions;
using N2.Definitions.Runtime;
using N2.Details;
using N2.Engine.Globalization;

namespace UnicornCreations.Models.Pages
{
    [PageDefinition("Startsida")]
    [WithEditableTitle, WithEditableName]
    public class StartPage : ExtendedContentPage
    {
        public const string SiteArea = "siteArea";
        public const string MiscArea = "miscArea";
        public const string FooterArea = "Footer";
        public const string HeaderArea = "Header";

        #region ILanguage Members

        public string FlagUrl
        {
            get
            {
                if (string.IsNullOrEmpty(LanguageCode))
                    return "";

                string[] parts = LanguageCode.Split('-');
                return String.Format("/N2/Resources/img/flags/{0}.png", parts[parts.Length - 1].ToLowerInvariant());
            }
        }

        [EditableLanguagesDropDown("Language", 100, ContainerName = MiscArea)]
        public string LanguageCode
        {
            get { return (string)GetDetail("LanguageCode"); }
            set { SetDetail("LanguageCode", value); }
        }

        public string LanguageTitle
        {
            get
            {
                if (string.IsNullOrEmpty(LanguageCode))
                    return "";
                else
                    return new CultureInfo(LanguageCode).DisplayName;
            }
        }

        #endregion
    }
}