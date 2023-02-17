using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TL_LT_Web_14.Models;

namespace TL_LT_Web_14.Controllers
{
    public class NgoaiNguController : Controller
    {
        Dan_So_Mot_Quan_14Entities db = new Dan_So_Mot_Quan_14Entities();
        public ActionResult Index()
        {

            List<NgoaiNgu> nn = db.NgoaiNgus.ToList();
            return View(nn);
        }

        public ActionResult Details(String id)
        {
            var detailsNN = db.NgoaiNgus.Find(id);
            return View(detailsNN);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(NgoaiNgu nn)
        {
            db.NgoaiNgus.Add(nn);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(String id)
        {
            var nnModel = db.NgoaiNgus.Find(id);
            return View(nnModel);
        }

        [HttpPost]
        public ActionResult Edit(NgoaiNgu nn)
        {
            var updateNN = db.NgoaiNgus.Find(nn.MaNgoaiNgu);
            updateNN.TenNgoaiNgu = nn.TenNgoaiNgu;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(String id)
        {
            var removeNN = db.NgoaiNgus.Find(id);
            db.NgoaiNgus.Remove(removeNN);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}