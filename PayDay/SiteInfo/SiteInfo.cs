using System.Web.Configuration;

namespace PayDay.SiteInfo
{
    public class SiteInfomation
    {
        public string SiteName { get; set; }
        public string SiteAddress { get; set; }

        public string SupportEmailAddress { get; set; }

        public SiteInfomation()
        {
            SiteName = WebConfigurationManager.AppSettings["siteName"];
            SiteAddress = WebConfigurationManager.AppSettings["siteAddress"];
            SupportEmailAddress = WebConfigurationManager.AppSettings["supportEmailAddress"];
        }
    }
}