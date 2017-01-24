using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PayDay.SiteInfo;

namespace PayDay.Controllers
{
    public class DisclaimerController : Controller
    {

        // GET: Disclaimer
        readonly SiteInfomation _siteInfomation = new SiteInfomation();
        public ActionResult Index()
        {
            ViewBag.SiteName = _siteInfomation.SiteName;
            ViewBag.SiteAddress = _siteInfomation.SiteAddress;
            ViewBag.SupportEmailAddress = _siteInfomation.SupportEmailAddress;
            return View();
        }
    }
}