using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WedTinTucBongDa_2001207127.Models;

namespace WedTinTucBongDa_2001207127.Controllers
{
    public class TinMoiController : Controller
    {
        // GET: TinMoi
        public ActionResult TinTuc(string search="", string SortColumn = "NgayTao", string IconClass = "fa-sort-asc")
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            //DateTime tg = DateTime.Now; //NGÀY TỪ HỆ THỐNG
            DateTime tg = DateTime.Parse("11/20/2022"); //NGÀY DO  QUẢN TRỊ VIÊN SET
            List<Tin> chuyennhuong = db.Tins.Where(row => row.MaLoaiTin == 1 && row.NgayTao >= tg && row.TomTat.Contains(search)).Take(10).ToList();
            ViewBag.tk = search;
            ViewBag.url = "/TinMoi/TinTuc";
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
            return View(chuyennhuong);
        }
        public ActionResult LichDau(string search = "", string SortColumn = "NgayTao", string IconClass = "fa-sort-asc")
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            //DateTime tg = DateTime.Now; //NGÀY TỪ HỆ THỐNG
            DateTime tg = DateTime.Parse("11/20/2022"); //NGÀY DO  QUẢN TRỊ VIÊN SET
            List<Tin> lichdau = db.Tins.Where(row => row.MaLoaiTin == 2 && row.NgayTao >= tg && row.TomTat.Contains(search)).Take(10).ToList();
            ViewBag.tk = search;
            ViewBag.url = "/TinMoi/LichDau";
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (IconClass == "fa-sort-asc")
            {
                lichdau = lichdau.OrderBy(row => row.NgayTao).ToList();
            }
            else
            {
                lichdau = lichdau.OrderByDescending(row => row.NgayTao).ToList();

            }
            return View(lichdau);
        }
        public ActionResult KetQua(string search = "", string SortColumn = "NgayTao", string IconClass = "fa-sort-asc")
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            //DateTime tg = DateTime.Now; //NGÀY TỪ HỆ THỐNG
            DateTime tg = DateTime.Parse("11/11/2022"); //NGÀY DO  QUẢN TRỊ VIÊN SET
            List<Tin> ketqua = db.Tins.Where(row => row.MaLoaiTin == 3 && row.NgayTao >= tg && row.TomTat.Contains(search)).Take(10).ToList();
            ViewBag.tk = search;
            ViewBag.url = "/TinMoi/KetQua";
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (IconClass == "fa-sort-asc")
            {
                ketqua = ketqua.OrderBy(row => row.NgayTao).ToList();
            }
            else
            {
                ketqua = ketqua.OrderByDescending(row => row.NgayTao).ToList();

            }
            return View(ketqua);
        }
        public ActionResult Detail(int id)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            Tin pro = db.Tins.Where(row => row.MaTin == id).FirstOrDefault();
            return View(pro);
        }
    }
}