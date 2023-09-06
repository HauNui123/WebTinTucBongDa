using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WedTinTucBongDa_2001207127.Models;

namespace WedTinTucBongDa_2001207127.Controllers
{
    public class LichDauController : Controller
    {
        // GET: LichDau
        public ActionResult LichDauY(string search = "", string SortColumn = "NgayTao", string IconClass = "fa-sort-asc",int page=1)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            List<Tin> lichdauy = db.Tins.Where(row => row.MaLoaiTin == 2 && row.MaGiaiDau==2 && row.TomTat.Contains(search)).ToList();
            ViewBag.tk = search;
            ViewBag.url = "/LichDau/LichDauY";
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (IconClass == "fa-sort-asc")
            {
                lichdauy = lichdauy.OrderBy(row => row.NgayTao).ToList();
            }
            else
            {
                lichdauy = lichdauy.OrderByDescending(row => row.NgayTao).ToList();

            }
            int NoOfRecordPerPage = 5;
            int NoOfPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(lichdauy.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int NoOfRecorToSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.page = page;
            ViewBag.NoOfpage = NoOfPage;
            lichdauy = lichdauy.Skip(NoOfRecorToSkip).Take(NoOfRecordPerPage).ToList();
            return View(lichdauy);
        }
        public ActionResult LichDauAnh(string search = "", string SortColumn = "NgayTao", string IconClass = "fa-sort-asc",int page=1)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            List<Tin> lichdauAnh = db.Tins.Where(row => row.MaLoaiTin == 2 && row.MaGiaiDau == 1 && row.TomTat.Contains(search)).ToList();
            ViewBag.tk = search;
            ViewBag.url = "/LichDau/LichDauAnh";
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (IconClass == "fa-sort-asc")
            {
                lichdauAnh = lichdauAnh.OrderBy(row => row.NgayTao).ToList();
            }
            else
            {
                lichdauAnh = lichdauAnh.OrderByDescending(row => row.NgayTao).ToList();

            }
            int NoOfRecordPerPage = 5;
            int NoOfPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(lichdauAnh.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int NoOfRecorToSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.page = page;
            ViewBag.NoOfpage = NoOfPage;
            lichdauAnh = lichdauAnh.Skip(NoOfRecorToSkip).Take(NoOfRecordPerPage).ToList();
            return View(lichdauAnh);
        }
        public ActionResult LichDauPhap(string search = "", string SortColumn = "NgayTao", string IconClass = "fa-sort-asc",int page =1)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            List<Tin> lichdauPhap = db.Tins.Where(row => row.MaLoaiTin == 2 && row.MaGiaiDau == 3 && row.TomTat.Contains(search)).ToList();
            ViewBag.tk = search;
            ViewBag.url = "/LichDau/LichDauPhap";
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (IconClass == "fa-sort-asc")
            {
                lichdauPhap = lichdauPhap.OrderBy(row => row.NgayTao).ToList();
            }
            else
            {
                lichdauPhap = lichdauPhap.OrderByDescending(row => row.NgayTao).ToList();

            }
            int NoOfRecordPerPage = 5;
            int NoOfPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(lichdauPhap.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int NoOfRecorToSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.page = page;
            ViewBag.NoOfpage = NoOfPage;
            lichdauPhap = lichdauPhap.Skip(NoOfRecorToSkip).Take(NoOfRecordPerPage).ToList();
            return View(lichdauPhap);
        }
        public ActionResult LichDauDuc(string search = "", string SortColumn = "NgayTao", string IconClass = "fa-sort-asc", int page = 1)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            List<Tin> lichdauDuc = db.Tins.Where(row => row.MaLoaiTin == 2 && row.MaGiaiDau == 4 && row.TomTat.Contains(search)).ToList();
            ViewBag.tk = search;
            ViewBag.url = "/LichDau/LichDauDuc";
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (IconClass == "fa-sort-asc")
            {
                lichdauDuc = lichdauDuc.OrderBy(row => row.NgayTao).ToList();
            }
            else
            {
                lichdauDuc = lichdauDuc.OrderByDescending(row => row.NgayTao).ToList();

            }
            int NoOfRecordPerPage = 5;
            int NoOfPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(lichdauDuc.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int NoOfRecorToSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.page = page;
            ViewBag.NoOfpage = NoOfPage;
            lichdauDuc = lichdauDuc.Skip(NoOfRecorToSkip).Take(NoOfRecordPerPage).ToList();
            return View(lichdauDuc);
        }
        public ActionResult LichDauTBN(string search = "", string SortColumn = "NgayTao", string IconClass = "fa-sort-asc", int page = 1)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            List<Tin> lichdauTBN = db.Tins.Where(row => row.MaLoaiTin == 2 && row.MaGiaiDau == 5 && row.TomTat.Contains(search)).ToList();
            ViewBag.tk = search;
            ViewBag.url = "/LichDau/LichDauTBN";
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (IconClass == "fa-sort-asc")
            {
                lichdauTBN = lichdauTBN.OrderBy(row => row.NgayTao).ToList();
            }
            else
            {
                lichdauTBN = lichdauTBN.OrderByDescending(row => row.NgayTao).ToList();

            }
            int NoOfRecordPerPage = 5;
            int NoOfPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(lichdauTBN.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int NoOfRecorToSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.page = page;
            ViewBag.NoOfpage = NoOfPage;
            lichdauTBN = lichdauTBN.Skip(NoOfRecorToSkip).Take(NoOfRecordPerPage).ToList();
            return View(lichdauTBN);
        }
        public ActionResult LichDauC1(string search = "", string SortColumn = "NgayTao", string IconClass = "fa-sort-asc", int page = 1)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            List<Tin> lichdauC1 = db.Tins.Where(row => row.MaLoaiTin == 2 && row.MaGiaiDau == 6 && row.TomTat.Contains(search)).ToList();
            ViewBag.tk = search;
            ViewBag.url = "/LichDau/LichDauC1";
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (IconClass == "fa-sort-asc")
            {
                lichdauC1 = lichdauC1.OrderBy(row => row.NgayTao).ToList();
            }
            else
            {
                lichdauC1 = lichdauC1.OrderByDescending(row => row.NgayTao).ToList();

            }
            int NoOfRecordPerPage = 5;
            int NoOfPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(lichdauC1.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int NoOfRecorToSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.page = page;
            ViewBag.NoOfpage = NoOfPage;
            lichdauC1 = lichdauC1.Skip(NoOfRecorToSkip).Take(NoOfRecordPerPage).ToList();
            return View(lichdauC1);
        }
        public ActionResult LichDauC2(string search = "", string SortColumn = "NgayTao", string IconClass = "fa-sort-asc", int page = 1)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            List<Tin> lichdauC2 = db.Tins.Where(row => row.MaLoaiTin == 2 && row.MaGiaiDau == 7 && row.TomTat.Contains(search)).ToList();
            ViewBag.tk = search;
            ViewBag.url = "/LichDau/LichDauC2";
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (IconClass == "fa-sort-asc")
            {
                lichdauC2 = lichdauC2.OrderBy(row => row.NgayTao).ToList();
            }
            else
            {
                lichdauC2 = lichdauC2.OrderByDescending(row => row.NgayTao).ToList();

            }
            int NoOfRecordPerPage = 5;
            int NoOfPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(lichdauC2.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int NoOfRecorToSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.page = page;
            ViewBag.NoOfpage = NoOfPage;
            lichdauC2 = lichdauC2.Skip(NoOfRecorToSkip).Take(NoOfRecordPerPage).ToList();
            return View(lichdauC2);
        }
    }
}