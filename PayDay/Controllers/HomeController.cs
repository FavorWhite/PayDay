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
        readonly SiteInfomation _siteInfomation = new SiteInfomation();
        // GET: Home

        public ActionResult Index()
        {
            ViewBag.SiteName = _siteInfomation.SiteName;
            ViewBag.SiteAddress = _siteInfomation.SiteAddress;
            ViewBag.SupportEmailAddress = _siteInfomation.SupportEmailAddress;

            List<SelectListItem> loanAmount = new List<SelectListItem>()
            {
                new SelectListItem { Text = "$100", Value = "100" },
                new SelectListItem { Text = "$200", Value = "200" },
                new SelectListItem { Text = "$300", Value = "300" },
                new SelectListItem { Text = "$400", Value = "400" },
                new SelectListItem { Text = "$500", Value = "500", Selected = true },
                new SelectListItem { Text = "$600", Value = "600" },
                new SelectListItem { Text = "$700", Value = "700" },
                new SelectListItem { Text = "$800", Value = "800" },
                new SelectListItem { Text = "$900", Value = "900" },
                new SelectListItem { Text = "$1000", Value = "1000" }
            };

            ViewBag.LoanAmount = loanAmount;


            return View();
        }
        public ActionResult LoanForm(int? RequestedAmount, string Email)
        {
            ViewBag.SiteName = _siteInfomation.SiteName;
            ViewBag.SiteAddress = _siteInfomation.SiteAddress;
            ViewBag.SupportEmailAddress = _siteInfomation.SupportEmailAddress;
            if (Email == null)
            {
                ViewBag.Email = String.Empty;
            }
            if (RequestedAmount == null)
            {
                ViewBag.Amount = 100;
            }
            return View();
        }
    }
}