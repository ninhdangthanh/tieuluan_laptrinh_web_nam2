using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TieuLuan.Models;

namespace TieuLuan.Controllers
{
    public class KetQuaController : Controller
    {
        //
        // GET: /KetQua/
        QL_Diem_SinhVienEntities1 db = new QL_Diem_SinhVienEntities1();
        public ActionResult Index()
        {
            List<KetQua> kq = db.KetQuas.ToList();
            return View(kq);
        }

        public ActionResult Details(String id)
        {
            var detailsKQ = db.KetQuas.Find(id);
            return View(detailsKQ);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(KetQua kq)
        {
            db.KetQuas.Add(kq);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(String id)
        {
            var kqModel = db.KetQuas.Find(id);
            return View(kqModel);
        }

        [HttpPost]
        public ActionResult Edit(KetQua kq)
        {
            var updateKQ = db.KetQuas.Find(kq.MaSinhVien);
            updateKQ.MaSinhVien = kq.MaSinhVien;
            updateKQ.MaKhoaHoc = kq.MaKhoaHoc;
            updateKQ.LanThi = kq.LanThi;
            updateKQ.Diem = kq.Diem;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(String id)
        {
            var removeKQ = db.KetQuas.Find(id);
            db.KetQuas.Remove(removeKQ);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}