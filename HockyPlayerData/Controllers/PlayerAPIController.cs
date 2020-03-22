using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HockyPlayerData.Controllers
{
    public class PlayerAPIController : Controller
    {
        // GET: PlayerAPI
        public ActionResult Index()
        {
            return View();
        }
    }
}