using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TL_LT_Web_14.Models;

namespace TL_LT_Web_14.Controllers
{
    public class NhanKhauController : Controller
    {
        Dan_So_Mot_Quan_14Entities db = new Dan_So_Mot_Quan_14Entities();
        public ActionResult Index()
        {

            List<NhanKhau> nk = db.NhanKhaus.ToList();
            return View(nk);
        }

        public ActionResult Details(String id)
        {
            var detailsNK = db.NhanKhaus.Find(id);
            return View(detailsNK);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(NhanKhau nk)
        {
            db.NhanKhaus.Add(nk);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(String id)
        {
            var nkModel = db.NhanKhaus.Find(id);
            return View(nkModel);
        }

        [HttpPost]
        public ActionResult Edit(NhanKhau nk)
        {
            var updateNK = db.NhanKhaus.Find(nk.MaNhanKhau);
            updateNK.TenNhanKhau = nk.TenNhanKhau;
            updateNK.PhaiNu = nk.PhaiNu;
            updateNK.NgaySinh = nk.NgaySinh;
            updateNK.SoCMND = nk.SoCMND;
            updateNK.MaTrinhDoVanHoa = nk.MaTrinhDoVanHoa;
            updateNK.MaNgoaiNgu = nk.MaNgoaiNgu;
            updateNK.SoSoHoKhau = nk.SoSoHoKhau;
            updateNK.GhiChu = nk.GhiChu;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(String id)
        {
            var removeNK = db.NhanKhaus.Find(id);
            db.NhanKhaus.Remove(removeNK);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}