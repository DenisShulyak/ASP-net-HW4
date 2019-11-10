using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationHW4.DataAccess;

namespace WebApplicationHW4.Areas.AdminPanel.Controllers
{
    public class HomeAdminController : Controller
    {
        // GET: AdminPanel/AddNews
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddData(string pathImg, string description)
        {

            using (ArticleContext context = new ArticleContext())
            {
                Article article = new Article
                {
                    PathImg = pathImg,
                    Description = description
                };

                context.Articles.Add(article);

                context.SaveChanges();

            }
            return View("Index");
        }
    }
}