using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using NewFakeBookMarkIII.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace NewFakeBookMarkIII.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            var currentUser = manager.FindById(User.Identity.GetUserId());
            //ViewBag.EmailID = currentUser.Email;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ProfileView()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("http://maps.googleapis.com/maps/api/geocode/xml?address=1000+Fifth+Avenue,+New+York,+NY&sensor=false");

            var lat = xDoc.SelectSingleNode("/GeocodeResponse/result/geometry/location/lat").InnerText;
            var longitude = xDoc.SelectSingleNode("/GeocodeResponse/result/geometry/location/lng").InnerText;

            ViewData["Lat"] = "lat";
            ViewData["Long"] = "longitude";

            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }
    }
}