using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WedTinTucBongDa_2001207127.Models;


namespace WedTinTucBongDa_2001207127.Class
{
    public class DanhSachCacTin
    {
        DatabaseTinTucBDEntities1 db = null;
        public DanhSachCacTin()
        {
            db = new DatabaseTinTucBDEntities1();
        }
        public List<Tin> DS_TinChuyenNhuong(int top,string tk)
        {
            return db.Tins.Where(x => x.MaLoaiTin == 1 && x.TomTat.Contains(tk)).Take(top).ToList();
        }
        public List<Tin> DS_TinLichDau(int top, string tk)
        {
            return db.Tins.Where(x => x.MaLoaiTin == 2 && x.TomTat.Contains(tk)).Take(top).ToList();
        }
        public List<Tin> DS_TinKetQua(int top, string tk)
        {
            return db.Tins.Where(x => x.MaLoaiTin == 3 && x.TomTat.Contains(tk)).Take(top).ToList();
        }
        public List<Tin> DS_TinLichC1(int top, string tk)
        {
            return db.Tins.Where(x => x.MaGiaiDau == 6 && x.MaLoaiTin == 2 && x.TomTat.Contains(tk)).Take(top).ToList();
        }
        public List<Tin> DS_TinLichC2(int top, string tk)
        {
            return db.Tins.Where(x => x.MaGiaiDau == 7 && x.MaLoaiTin == 2 && x.TomTat.Contains(tk)).Take(top).ToList();
        }
        public List<Tin> DS_TinKQC1(int top, string tk)
        {
            return db.Tins.Where(x => x.MaGiaiDau == 6 && x.MaLoaiTin == 3 && x.TomTat.Contains(tk)).Take(top).ToList();
        }
        public List<Tin> DS_TinKQC2(int top, string tk)
        {
            return db.Tins.Where(x => x.MaGiaiDau == 7 && x.MaLoaiTin == 3 && x.TomTat.Contains(tk)).Take(top).ToList();
        }
    }
}