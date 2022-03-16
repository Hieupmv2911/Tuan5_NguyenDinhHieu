using Buoi4_NguyenDinhHieu.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Buoi4_NguyenDinhHieu.Controllers
{
    public class HomeController : Controller
    {

        MyDataDataContext data = new MyDataDataContext();
        public ActionResult Index( int ? page)
        {
            if (page == null) page = 1;
            var all_sach = (from ss in data.Sach1s select ss).OrderBy(m=>m.masach);
            int PageSize = 3;
            int PageNum = page ?? 1;
            return View(all_sach.ToPagedList(PageNum,PageSize));
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