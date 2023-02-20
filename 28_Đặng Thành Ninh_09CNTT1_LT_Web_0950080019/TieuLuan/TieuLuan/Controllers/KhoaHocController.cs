using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TieuLuan.Models;

namespace TieuLuan.Controllers
{
    public class KhoaHocController : Controller
    {
        //
        // GET: /KhoaHoc/
        QL_Diem_SinhVienEntities1 db = new QL_Diem_SinhVienEntities1();
        public ActionResult Index()
        {
            List<KhoaHoc> kh = db.KhoaHocs.ToList();
            return View(kh);
        }

        public ActionResult Details(String id)
        {
            var detailsKH = db.KhoaHocs.Find(id);
            return View(detailsKH);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(KhoaHoc kh)
        {
            db.KhoaHocs.Add(kh);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(String id)
        {
            var khModel = db.KhoaHocs.Find(id);
            return View(khModel);
        }

        [HttpPost]
        public ActionResult Edit(KhoaHoc kh)
        {
            var updateKH = db.KhoaHocs.Find(kh.MaKhoaHoc);
            updateKH.MaKhoaHoc = kh.MaKhoaHoc;
            updateKH.MaGiaoVien = kh.MaGiaoVien;
            updateKH.MaMonHoc = kh.MaMonHoc;
            updateKH.NgayBatDau = kh.NgayBatDau;
            updateKH.NgayKetThuc = kh.NgayKetThuc;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(String id)
        {
            var removeKH = db.KhoaHocs.Find(id);
            db.KhoaHocs.Remove(removeKH);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	
	}
}