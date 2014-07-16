using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiView.Controllers
{
    public class LeftController : Controller
    {
        //
        // GET: /Left/

        public PartialViewResult Index()
        {
            return PartialView();
        }

    }
}
