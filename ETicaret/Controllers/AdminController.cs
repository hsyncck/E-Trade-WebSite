﻿using ETicaret.Entity;
using ETicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETicaret.Controllers
{
    public class AdminController : Controller
    {
        DataContext db = new DataContext();
        [Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            StateModel model = new StateModel();
            model.BekleyenSiparisSayisi = db.Orders.Where(i => i.OrderState == OrderState.Bekleniyor).ToList().Count();
            model.TamamlananSiparisSayisi = db.Orders.Where(i => i.OrderState == OrderState.Tamamlandı).ToList().Count();
            model.PaketlenenSiparisSayisi = db.Orders.Where(i => i.OrderState == OrderState.Paketlendi).ToList().Count();
            model.KargolanSiparisSayisi = db.Orders.Where(i => i.OrderState == OrderState.Kargolandı).ToList().Count();
            model.UrunSayisi = db.Products.Count();
            model.SiparisSayisi = db.Orders.Count();
            return View(model);
        }
        public PartialViewResult BildirimMenusu()
        {
            var bildirim = db.Orders.Where(i => i.OrderState == OrderState.Bekleniyor).ToList();
            return PartialView(bildirim);
        }
    }
}