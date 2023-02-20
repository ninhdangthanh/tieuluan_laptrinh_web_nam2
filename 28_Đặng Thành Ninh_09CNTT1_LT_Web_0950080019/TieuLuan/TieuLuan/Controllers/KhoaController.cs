using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TieuLuan.Models;

namespace TieuLuan.Controllers
{
    public class KhoaController : Controller
    {
        //
        // GET: /Khoa/
        QL_Diem_SinhVienEntities1 db = new QL_Diem_SinhVienEntities1();
        public ActionResult Index()
        {
            List<Khoa> k = db.Khoas.ToList();
            return View(k);
        }

        public ActionResult Details(String id)
        {
            var detailsK = db.Khoas.Find(id);
            return View(detailsK);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Khoa k)
        {
            db.Khoas.Add(k);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(String id)
        {
            var kModel = db.Khoas.Find(id);
            return View(kModel);
        }

        [HttpPost]
        public ActionResult Edit(Khoa k)
        {
            var updateK = db.Khoas.Find(k.MaKhoa);
            updateK.MaKhoa = k.MaKhoa;
            updateK.TenKhoa = k.TenKhoa;
            updateK.DiaChi = k.DiaChi;
            updateK.DienThoai = k.DienThoai;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(String id)
        {
            var removeK = db.Khoas.Find(id);
            db.Khoas.Remove(removeK);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}