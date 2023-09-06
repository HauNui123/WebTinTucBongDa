using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WedTinTucBongDa_2001207127.Models;
using WedTinTucBongDa_2001207127.Class;
using System.Security.Cryptography;
using System.Text;

namespace WedTinTucBongDa_2001207127.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult TrangChu(string search = "", string SortColumn = "NgayTao", string IconClass = "fa-sort-asc")
        {

            ViewBag.tk = search;
            ViewBag.SortColumn = SortColumn;
            ViewBag.IconClass = IconClass;
            if (IconClass == "fa-sort-asc")
            {
                var DanhSachCacTin = new DanhSachCacTin();
                ViewBag.DS_ChuyenNhuong = DanhSachCacTin.DS_TinChuyenNhuong(10, search).OrderBy(row => row.NgayTao).ToList();
                ViewBag.DS_LichDau = DanhSachCacTin.DS_TinLichDau(10, search).OrderBy(row => row.NgayTao).ToList();
                ViewBag.DS_KetQua = DanhSachCacTin.DS_TinKetQua(10, search).OrderBy(row => row.NgayTao).ToList();
                ViewBag.DS_LichC1 = DanhSachCacTin.DS_TinLichC1(10, search).OrderBy(row => row.NgayTao).ToList();
                ViewBag.DS_LichC2 = DanhSachCacTin.DS_TinLichC2(10, search).OrderBy(row => row.NgayTao).ToList();
                ViewBag.DS_KQC1 = DanhSachCacTin.DS_TinKQC1(5, search).OrderBy(row => row.NgayTao).ToList();
                ViewBag.DS_KQC2 = DanhSachCacTin.DS_TinKQC2(5, search).OrderBy(row => row.NgayTao).ToList();
            }
            else
            {
                var DanhSachCacTin = new DanhSachCacTin();
                ViewBag.DS_ChuyenNhuong = DanhSachCacTin.DS_TinChuyenNhuong(10, search).OrderByDescending(row => row.NgayTao).ToList();
                ViewBag.DS_LichDau = DanhSachCacTin.DS_TinLichDau(10, search).OrderByDescending(row => row.NgayTao).ToList();
                ViewBag.DS_KetQua = DanhSachCacTin.DS_TinKetQua(10, search).OrderByDescending(row => row.NgayTao).ToList();
                ViewBag.DS_LichC1 = DanhSachCacTin.DS_TinLichC1(10, search).OrderByDescending(row => row.NgayTao).ToList();
                ViewBag.DS_LichC2 = DanhSachCacTin.DS_TinLichC2(10, search).OrderByDescending(row => row.NgayTao).ToList();
                ViewBag.DS_KQC1 = DanhSachCacTin.DS_TinKQC1(5, search).OrderByDescending(row => row.NgayTao).ToList();
                ViewBag.DS_KQC2 = DanhSachCacTin.DS_TinKQC2(5, search).OrderByDescending(row => row.NgayTao).ToList();
            }
            ViewBag.url = "/Home/TrangChu";
            return View();
        }
        public ActionResult ChuyenNhuong(string search = "", string SortColumn = "NgayTao", string IconClass = "fa-sort-asc",int page=1)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            List<Tin> chuyennhuong = db.Tins.Where(row => row.MaLoaiTin == 1 && row.TomTat.Contains(search)).Take(20).ToList();
            ViewBag.tk = search;
            ViewBag.url = "/Home/ChuyenNhuong";
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
        public ActionResult Detail(int id)
        {
            DatabaseTinTucBDEntities1 db = new DatabaseTinTucBDEntities1();
            Tin pro = db.Tins.Where(row => row.MaTin == id).FirstOrDefault();
            return View(pro);
        }
     
        //GET: Register
        DatabaseTinTucBDEntities1 tech = new DatabaseTinTucBDEntities1();
        public ActionResult Register()
        {
            return View();
        }

        //POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User _user)
        {
            if (ModelState.IsValid)
            {
                var check = tech.Users.FirstOrDefault(s => s.Email == _user.Email);
                if (check == null)
                {
                    _user.Password = GetMD5(_user.Password);
                    tech.Configuration.ValidateOnSaveEnabled = false;
                    tech.Users.Add(_user);
                    tech.SaveChanges();
                    return RedirectToAction("Login");
                }
                else
                {
                    ViewBag.error = "Email Đã Tồn Tại!";
                    return View();
                }


            }
            return View();


        }

        //create a string MD5
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string email, string password)
        {
            if (ModelState.IsValid)
            {
                var f_password = GetMD5(password);
                if (email == "Admin1@gmail.com" && f_password == "202cb962ac59075b964b07152d234b70"|| email == "Admin2@gmail.com" && f_password == "202cb962ac59075b964b07152d234b70")
                {
                    Session["admin"] = "Admin";
                    return RedirectToAction("TrangChu");
                }
                else
                {
                    var data = tech.Users.Where(s => s.Email.Equals(email) && s.Password.Equals(f_password)).ToList();
                    if (data.Count() > 0)
                    {
                        //add session
                        Session["HoTen"] = data.FirstOrDefault().FirstName + " " + data.FirstOrDefault().LastName;
                        Session["Email"] = data.FirstOrDefault().Email;

                        Session["idUser"] = data.FirstOrDefault().Id;
                        return RedirectToAction("TrangChu");
                    }
                    else
                    {
                        ViewBag.error = "Đăng Nhập Thất Bại";
                        return RedirectToAction("Login");
                    }
                }
            }
            return View();
        }


        //Logout
        public ActionResult Logout()
        {
            Session.Clear();//remove session
            return RedirectToAction("Login");
        }
    }
}