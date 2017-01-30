using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PayDay.SiteInfo;

namespace PayDay.Controllers
{
    public class HomeController : Controller
    {
        readonly SiteInfomation _siteInfomation =new SiteInfomation();
        // GET: Home

        public ActionResult Index()
        {
            ViewBag.SiteName = _siteInfomation.SiteName;
            ViewBag.SiteAddress = _siteInfomation.SiteAddress;
            ViewBag.SupportEmailAddress = _siteInfomation.SupportEmailAddress;
            return View();
        }
        public ActionResult LoanForm(int Amount, string Email )
        {
            if (Email ==null)
            {
                ViewBag.Email = String.Empty;
            }
            ViewBag.Amount = Amount;
            ViewBag.Email = Email;
            return View();
        }
    }
}