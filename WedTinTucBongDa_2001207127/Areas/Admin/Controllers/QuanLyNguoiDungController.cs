using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WedTinTucBongDa_2001207127.Models;

namespace WedTinTucBongDa_2001207127.Areas.Admin.Controllers
{
    public class QuanLyNguoiDungController : Controller
    {
        // GET: Admin/QuanLyNguoiDung
        public ActionResult QL_User(string search = "", string SortColumn = "Email", string IconClass = "fa-sort-asc")
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            List<User> ds = db.Users.Where(row => row.Email != "Admin1@gmail.com" && row.Email!= "Admin2@gmail.com" && row.Email.Contains(search)).ToList();
            ViewBag.tk = search;
            ViewBag.url = "QL_User";
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (IconClass == "fa-sort-asc")
            {
                ds = ds.OrderBy(row => row.Email).ToList();
            }
            else
            {
                ds = ds.OrderByDescending(row => row.Email).ToList();

            }
            return View(ds);
        }
        public ActionResult Edit(int id)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            User ds = db.Users.Where(row => row.Id == id).FirstOrDefault();
            return View(ds);
        }
        [HttpPost]
        public ActionResult Edit(User p)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            User ds = db.Users.Where(row => row.Id == p.Id).FirstOrDefault();
            ds.Id = p.Id;
            ds.FirstName = p.FirstName;
            ds.LastName = p.LastName;
            ds.Email = p.Email;
            ds.Password = p.Password;
            return RedirectToAction("QL_User");
        }
        public ActionResult Delete(int id)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            User ds = db.Users.Where(row => row.Id == id).FirstOrDefault();
            return View(ds);
        }
        [HttpPost]
        public ActionResult Delete(int id, User p)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            User ds = db.Users.Where(row => row.Id == p.Id).FirstOrDefault();
            db.Users.Remove(ds);
            db.SaveChanges();
            return RedirectToAction("QL_User");
        }
    }
}