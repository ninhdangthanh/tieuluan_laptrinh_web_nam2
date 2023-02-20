using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TieuLuan.Models;

namespace TieuLuan.Controllers
{
    public class SinhVienController : Controller
    {
        //
        // GET: /SinhVien/
        QL_Diem_SinhVienEntities1 db = new QL_Diem_SinhVienEntities1();
        public ActionResult Index()
        {
            
            List<SinhVien> sv = db.SinhViens.ToList();
            return View(sv);
        }

        public ActionResult Details(String id)
        {
            var detailsSV = db.SinhViens.Find(id);
            return View(detailsSV);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(SinhVien sv)
        {
            db.SinhViens.Add(sv);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(String id)
        {
            var svModel = db.SinhViens.Find(id);
            return View(svModel);
        }

        [HttpPost]
        public ActionResult Edit(SinhVien sv)
        {
            var updateSV = db.SinhViens.Find(sv.MaSinhVien);
            updateSV.MaSinhVien = sv.MaSinhVien;
            updateSV.HoSinhVien = sv.HoSinhVien;
            updateSV.TenSinhVien = sv.TenSinhVien;
            updateSV.NgaySinh = sv.NgaySinh;
            updateSV.Phai = sv.Phai;
            updateSV.DienThoai = sv.DienThoai;
            updateSV.DiaChi = sv.DiaChi;
            updateSV.MaKhoa = sv.MaKhoa;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(String id)
        {
            var removeSV = db.SinhViens.Find(id);
            db.SinhViens.Remove(removeSV);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}