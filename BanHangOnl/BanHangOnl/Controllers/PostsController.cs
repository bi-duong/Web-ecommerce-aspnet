using BanHangOnl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanHangOnl.Controllers
{
    public class PostsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Posts
        public ActionResult Index()
        {
            var items = db.Posts.ToList();
            return View(items);
        }
        public ActionResult Detail(int id)
        {
            var item = db.Posts.Find(id);
            if (item != null)
            {
                db.Posts.Attach(item);
                db.SaveChanges();
            }

            return View(item);
        }
    }
}