using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TL_LT_Web_14.Models;

namespace TL_LT_Web_14.Controllers
{
    public class ChiTietPhieuDiChuyenController : Controller
    {
        Dan_So_Mot_Quan_14Entities db = new Dan_So_Mot_Quan_14Entities();
        public ActionResult Index()
        {

            List<ChiTietPhieuDiChuyen> ct = db.ChiTietPhieuDiChuyens.ToList();
            return View(ct);
        }

        public ActionResult Details(String id)
        {
            var detailsCT = db.ChiTietPhieuDiChuyens.Find(id);
            return View(detailsCT);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ChiTietPhieuDiChuyen ct)
        {
            db.ChiTietPhieuDiChuyens.Add(ct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(String id)
        {
            var ctModel = db.ChiTietPhieuDiChuyens.Find(id);
            return View(ctModel);
        }

        [HttpPost]
        public ActionResult Edit(ChiTietPhieuDiChuyen ct)
        {
            var updateCT = db.ChiTietPhieuDiChuyens.Find(ct.SoPhieu);
            updateCT.STT = ct.STT;
            updateCT.MaNhanKhau = ct.MaNhanKhau;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(String id)
        {
            var removeCT = db.ChiTietPhieuDiChuyens.Find(id);
            db.ChiTietPhieuDiChuyens.Remove(removeCT);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}