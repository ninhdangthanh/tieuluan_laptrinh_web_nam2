using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TieuLuan.Models;

namespace TieuLuan.Controllers
{
    public class GiaoVienController : Controller
    {
        //
        // GET: /GiaoVien/
        QL_Diem_SinhVienEntities1 db = new QL_Diem_SinhVienEntities1();
        public ActionResult Index()
        {
            List<GiaoVien> gv = db.GiaoViens.ToList();
            return View(gv);
        }

        public ActionResult Details(String id)
        {
            var detailsGV = db.GiaoViens.Find(id);
            return View(detailsGV);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(GiaoVien gv)
        {
            db.GiaoViens.Add(gv);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(String id)
        {
            var gvModel = db.GiaoViens.Find(id);
            return View(gvModel);
        }

        [HttpPost]
        public ActionResult Edit(GiaoVien gv)
        {
            var updateGV = db.GiaoViens.Find(gv.MaGiaoVien);
            updateGV.MaGiaoVien = gv.MaGiaoVien;
            updateGV.TenGiaoVien = gv.TenGiaoVien;
            updateGV.HocVi = gv.HocVi;
            updateGV.SoDienThoai = gv.SoDienThoai;
            updateGV.MaKhoa = gv.MaKhoa;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(String id)
        {
            var removeGV = db.GiaoViens.Find(id);
            db.GiaoViens.Remove(removeGV);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}