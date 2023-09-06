using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WedTinTucBongDa_2001207127.Models;

namespace WedTinTucBongDa_2001207127.Areas.Admin.Controllers
{
    public class HomeAdminController : Controller
    {
        // GET: Admin/HomeAdmin
        public ActionResult ChuyenNhuong (string search = "", string SortColumn = "NgayTao", string IconClass = "fa-sort-asc",int page=1)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            List<Tin> chuyennhuong = db.Tins.Where(row => row.MaLoaiTin == 1 && row.TomTat.Contains(search)).Take(20).ToList();
            ViewBag.tk = search;
            ViewBag.url = "ChuyenNhuong";
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (IconClass == "fa-sort-asc")
            {
                chuyennhuong = chuyennhuong.OrderBy(row => row.NgayTao).ToList();
            }
            else
            {
                chuyennhuong = chuyennhuong.OrderByDescending(row => row.NgayTao).ToList();

            }
            int NoOfRecordPerPage = 5;
            int NoOfPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(chuyennhuong.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int NoOfRecorToSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.page = page;
            ViewBag.NoOfpage = NoOfPage;
            chuyennhuong = chuyennhuong.Skip(NoOfRecorToSkip).Take(NoOfRecordPerPage).ToList();
            return View(chuyennhuong);

        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Tin p)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            db.Tins.Add(p);
            db.SaveChanges();
            return RedirectToAction("ChuyenNhuong");
        }
        public ActionResult Edit(int id)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            Tin tin = db.Tins.Where(row => row.MaTin == id).FirstOrDefault();
            return View(tin);
        }
        [HttpPost]
        public ActionResult Edit(Tin p)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            Tin tin = db.Tins.Where(row => row.MaTin == p.MaTin).FirstOrDefault();
            tin.TieuDe = p.TieuDe;
            tin.TomTat = p.TomTat;
            tin.NoiDung = p.NoiDung;
            tin.NgayTao = p.NgayTao;
            tin.MaLoaiTin = p.MaLoaiTin;
            db.SaveChanges();
            return RedirectToAction("ChuyenNhuong");
        }
        public ActionResult Detail(int id)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            Tin pro = db.Tins.Where(row => row.MaTin == id).FirstOrDefault();
            return View(pro);
        }
        public ActionResult Delete(int id)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            Tin tin = db.Tins.Where(row => row.MaTin == id).FirstOrDefault();
            return View(tin);
        }
        [HttpPost]
        public ActionResult Delete(int id, Tin p)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            Tin tin = db.Tins.Where(row => row.MaTin == id).FirstOrDefault();
            db.Tins.Remove(tin);
            db.SaveChanges();
            return RedirectToAction("ChuyenNhuong");
        }
    }
}