using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WedTinTucBongDa_2001207127.Models;

namespace WedTinTucBongDa_2001207127.Controllers
{
    public class KetQuaController : Controller
    {
        // GET: KetQua
        public ActionResult KetQuaY(string search="", string SortColumn = "NgayTao", string IconClass = "fa-sort-asc",int page=1)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            List<Tin> KQY = db.Tins.Where(row => row.MaLoaiTin == 3 && row.MaGiaiDau == 2 && row.TomTat.Contains(search)).ToList();
            ViewBag.tk = search;
            ViewBag.url = "/KetQua/KetQuaY";
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (IconClass == "fa-sort-asc")
            {
                KQY = KQY.OrderBy(row => row.NgayTao).ToList();
            }
            else
            {
                KQY = KQY.OrderByDescending(row => row.NgayTao).ToList();

            }
            int NoOfRecordPerPage = 5;
            int NoOfPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(KQY.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int NoOfRecorToSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.page = page;
            ViewBag.NoOfpage = NoOfPage;
            KQY = KQY.Skip(NoOfRecorToSkip).Take(NoOfRecordPerPage).ToList();
            return View(KQY);
        }
        public ActionResult KetQuaAnh(string search = "", string SortColumn = "NgayTao", string IconClass = "fa-sort-asc", int page = 1)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            List<Tin> KQAnh = db.Tins.Where(row => row.MaLoaiTin == 3 && row.MaGiaiDau == 1 && row.TomTat.Contains(search)).ToList();
            ViewBag.tk = search;
            ViewBag.url = "/KetQua/KetQuaAnh";
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (IconClass == "fa-sort-asc")
            {
                KQAnh = KQAnh.OrderBy(row => row.NgayTao).ToList();
            }
            else
            {
                KQAnh = KQAnh.OrderByDescending(row => row.NgayTao).ToList();

            }
            int NoOfRecordPerPage = 5;
            int NoOfPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(KQAnh.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int NoOfRecorToSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.page = page;
            ViewBag.NoOfpage = NoOfPage;
            KQAnh = KQAnh.Skip(NoOfRecorToSkip).Take(NoOfRecordPerPage).ToList();
            return View(KQAnh);
        }
        public ActionResult KetQuaPhap(string search = "", string SortColumn = "NgayTao", string IconClass = "fa-sort-asc", int page = 1)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            List<Tin> KQPhap = db.Tins.Where(row => row.MaLoaiTin == 3 && row.MaGiaiDau == 3 && row.TomTat.Contains(search)).ToList();
            ViewBag.tk = search;
            ViewBag.url = "/KetQua/KetQuaPhap";
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (IconClass == "fa-sort-asc")
            {
                KQPhap = KQPhap.OrderBy(row => row.NgayTao).ToList();
            }
            else
            {
                KQPhap = KQPhap.OrderByDescending(row => row.NgayTao).ToList();

            }
            int NoOfRecordPerPage = 5;
            int NoOfPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(KQPhap.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int NoOfRecorToSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.page = page;
            ViewBag.NoOfpage = NoOfPage;
            KQPhap = KQPhap.Skip(NoOfRecorToSkip).Take(NoOfRecordPerPage).ToList();
            return View(KQPhap);
        }
        public ActionResult KetQuaDuc(string search = "", string SortColumn = "NgayTao", string IconClass = "fa-sort-asc", int page = 1)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            List<Tin> KQDuc = db.Tins.Where(row => row.MaLoaiTin == 3 && row.MaGiaiDau == 4 && row.TomTat.Contains(search)).ToList();
            ViewBag.tk = search;
            ViewBag.url = "/KetQua/KetQuaDuc";
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (IconClass == "fa-sort-asc")
            {
                KQDuc = KQDuc.OrderBy(row => row.NgayTao).ToList();
            }
            else
            {
                KQDuc = KQDuc.OrderByDescending(row => row.NgayTao).ToList();

            }
            int NoOfRecordPerPage = 5;
            int NoOfPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(KQDuc.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int NoOfRecorToSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.page = page;
            ViewBag.NoOfpage = NoOfPage;
            KQDuc = KQDuc.Skip(NoOfRecorToSkip).Take(NoOfRecordPerPage).ToList();
            return View(KQDuc);
        }
        public ActionResult KetQuaTBN(string search = "", string SortColumn = "NgayTao", string IconClass = "fa-sort-asc", int page = 1)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            List<Tin> KQTBN = db.Tins.Where(row => row.MaLoaiTin == 3 && row.MaGiaiDau == 5 && row.TomTat.Contains(search)).ToList();
            ViewBag.tk = search;
            ViewBag.url = "/KetQua/KetQuaTBN";
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (IconClass == "fa-sort-asc")
            {
                KQTBN = KQTBN.OrderBy(row => row.NgayTao).ToList();
            }
            else
            {
                KQTBN = KQTBN.OrderByDescending(row => row.NgayTao).ToList();

            }
            int NoOfRecordPerPage = 5;
            int NoOfPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(KQTBN.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int NoOfRecorToSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.page = page;
            ViewBag.NoOfpage = NoOfPage;
            KQTBN = KQTBN.Skip(NoOfRecorToSkip).Take(NoOfRecordPerPage).ToList();
            return View(KQTBN);
        }
        public ActionResult KetQuaC1(string search = "", string SortColumn = "NgayTao", string IconClass = "fa-sort-asc", int page = 1)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            List<Tin> KQC1 = db.Tins.Where(row => row.MaLoaiTin == 3 && row.MaGiaiDau == 6 && row.TomTat.Contains(search)).ToList();
            ViewBag.tk = search;
            ViewBag.url = "/KetQua/KetQuaC1";
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (IconClass == "fa-sort-asc")
            {
                KQC1 = KQC1.OrderBy(row => row.NgayTao).ToList();
            }
            else
            {
                KQC1 = KQC1.OrderByDescending(row => row.NgayTao).ToList();

            }
            int NoOfRecordPerPage = 5;
            int NoOfPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(KQC1.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int NoOfRecorToSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.page = page;
            ViewBag.NoOfpage = NoOfPage;
            KQC1 = KQC1.Skip(NoOfRecorToSkip).Take(NoOfRecordPerPage).ToList();
            return View(KQC1);
        }
        public ActionResult KetQuaC2(string search = "", string SortColumn = "NgayTao", string IconClass = "fa-sort-asc", int page = 1)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            List<Tin> KQC2 = db.Tins.Where(row => row.MaLoaiTin == 3 && row.MaGiaiDau == 7 && row.TomTat.Contains(search)).ToList();
            ViewBag.tk = search;
            ViewBag.url = "/KetQua/KetQuaC2";
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (IconClass == "fa-sort-asc")
            {
                KQC2 = KQC2.OrderBy(row => row.NgayTao).ToList();
            }
            else
            {
                KQC2 = KQC2.OrderByDescending(row => row.NgayTao).ToList();

            }
            int NoOfRecordPerPage = 5;
            int NoOfPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(KQC2.Count) / Convert.ToDouble(NoOfRecordPerPage)));
            int NoOfRecorToSkip = (page - 1) * NoOfRecordPerPage;
            ViewBag.page = page;
            ViewBag.NoOfpage = NoOfPage;
            KQC2 = KQC2.Skip(NoOfRecorToSkip).Take(NoOfRecordPerPage).ToList();
            return View(KQC2);
        }
        public ActionResult Detail(int id)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            Tin pro = db.Tins.Where(row => row.MaTin == id).FirstOrDefault();
            return View(pro);
        }
    }
}