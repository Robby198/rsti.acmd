using Assetio.AssetCommander.Web.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assetio.AssetCommander.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
#if DEBUG
            Log.Debug("Debug message");
            Log.Warn("Warn message");
            Log.Error("Error message");
            Log.Info("Info message");
#endif

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
    }
}