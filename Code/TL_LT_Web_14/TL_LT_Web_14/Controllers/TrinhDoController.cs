using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TL_LT_Web_14.Models;

namespace TL_LT_Web_14.Controllers
{
    public class TrinhDoController : Controller
    {
        Dan_So_Mot_Quan_14Entities db = new Dan_So_Mot_Quan_14Entities();
        public ActionResult Index()
        {

            List<TrinhDo> td = db.TrinhDoes.ToList();
            return View(td);
        }

        public ActionResult Details(String id)
        {
            var detailsTD = db.TrinhDoes.Find(id);
            return View(detailsTD);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TrinhDo td)
        {
            db.TrinhDoes.Add(td);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(String id)
        {
            var tdModel = db.TrinhDoes.Find(id);
            return View(tdModel);
        }

        [HttpPost]
        public ActionResult Edit(TrinhDo td)
        {
            var updateTD = db.TrinhDoes.Find(td.MaTrinhDoVanHoa);
            updateTD.TenTrinhDoVanHoa = td.TenTrinhDoVanHoa;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(String id)
        {
            var removeTD = db.TrinhDoes.Find(id);
            db.TrinhDoes.Remove(removeTD);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}