using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TL_LT_Web_14.Models;

namespace TL_LT_Web_14.Controllers
{
    public class PhieuDiChuyenController : Controller
    {
        Dan_So_Mot_Quan_14Entities db = new Dan_So_Mot_Quan_14Entities();
        public ActionResult Index()
        {

            List<PhieuDiChuyen> dc = db.PhieuDiChuyens.ToList();
            return View(dc);
        }

        public ActionResult Details(String id)
        {
            var detailsDC = db.PhieuDiChuyens.Find(id);
            return View(detailsDC);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PhieuDiChuyen dc)
        {
            db.PhieuDiChuyens.Add(dc);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(String id)
        {
            var dcModel = db.PhieuDiChuyens.Find(id);
            return View(dcModel);
        }

        [HttpPost]
        public ActionResult Edit(PhieuDiChuyen dc)
        {
            var updateDC = db.PhieuDiChuyens.Find(dc.SoPhieu);
            updateDC.NgayLapPhieu = dc.NgayLapPhieu;
            updateDC.DiaChiNoiDen = dc.DiaChiNoiDen;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(String id)
        {
            var removeDC = db.PhieuDiChuyens.Find(id);
            db.PhieuDiChuyens.Remove(removeDC);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}