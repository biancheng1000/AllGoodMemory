using AllGoodMemory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AllGoodMemory.Controllers
{
    public class PhotoController : Controller
    {
        // GET: Photo
        public ActionResult Index()
        {
            myDaughterModel modes = new myDaughterModel();
            IList<mydaughter_photos> allphotos = modes.mydaughter_photos.ToList();
            if (allphotos == null)
            {
                return new HttpNotFoundResult();
            }
            return View(allphotos.First());
        }
    }
}