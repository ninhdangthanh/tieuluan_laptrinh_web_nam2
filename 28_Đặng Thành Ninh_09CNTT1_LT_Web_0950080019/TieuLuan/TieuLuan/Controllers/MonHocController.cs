using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TieuLuan.Models;

namespace TieuLuan.Controllers
{
    public class MonHocController : Controller
    {
        //
        // GET: /MonHoc/
        QL_Diem_SinhVienEntities1 db = new QL_Diem_SinhVienEntities1();
        public ActionResult Index()
        {
            List<MonHoc> mh = db.MonHocs.ToList();
            return View(mh);
        }

        public ActionResult Details(String id)
        {
            var detailsMH = db.MonHocs.Find(id);
            return View(detailsMH);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MonHoc mh)
        {
            db.MonHocs.Add(mh);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(String id)
        {
            var mhModel = db.MonHocs.Find(id);
            return View(mhModel);
        }

        [HttpPost]
        public ActionResult Edit(MonHoc mh)
        {
            var updateMH = db.MonHocs.Find(mh.MaMonHoc);
            updateMH.MaMonHoc = mh.MaMonHoc;
            updateMH.TenMonHoc = mh.TenMonHoc;
            updateMH.SoTietLyThuyet = mh.SoTietLyThuyet;
            updateMH.SoTietThucHanh = mh.SoTietThucHanh;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(String id)
        {
            var removeMH = db.MonHocs.Find(id);
            db.MonHocs.Remove(removeMH);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}