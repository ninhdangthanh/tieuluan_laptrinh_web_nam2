using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TL_LT_Web_14.Models;

namespace TL_LT_Web_14.Controllers
{
    public class HoKhauController : Controller
    {
        Dan_So_Mot_Quan_14Entities db = new Dan_So_Mot_Quan_14Entities();
        public ActionResult Index()
        {

            List<HoKhau> hk = db.HoKhaus.ToList();
            return View(hk);
        }

        public ActionResult Details(String id)
        {
            var detailsHK = db.HoKhaus.Find(id);
            return View(detailsHK);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(HoKhau hk)
        {
            db.HoKhaus.Add(hk);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(String id)
        {
            var hkModel = db.HoKhaus.Find(id);
            return View(hkModel);
        }

        [HttpPost]
        public ActionResult Edit(HoKhau hk)
        {
            var updateHK = db.HoKhaus.Find(hk.SoSoHoKhau);
            updateHK.DiaChi = hk.DiaChi;
            updateHK.MaPhuong = hk.MaPhuong;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(String id)
        {
            var removeHK = db.HoKhaus.Find(id);
            db.HoKhaus.Remove(removeHK);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}