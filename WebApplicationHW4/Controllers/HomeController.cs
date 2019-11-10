using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationHW4.DataAccess;

namespace WebApplicationHW4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (var context = new ArticleContext())
            {
                var news = context.Articles.ToList();
                ViewBag.News = news;

            }

            return View();
        }
        
    }
}