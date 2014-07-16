using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiView.Controllers
{
    public class RightController : Controller
    {
        //
        // GET: /Right/

        public PartialViewResult Index(string title)
        {
            ViewBag.Title = title;
            return PartialView();
        }

    }
}
