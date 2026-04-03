using Proyecto_Web_VLR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Web_VLR.Controllers
{
    public class VlrController : Controller
    {
        // GET: vlr
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Player.ToList());
            }    
            
        }

        // GET: vlr/Details/5
        public ActionResult Details(int id)
        {

            using (DbModels context = new DbModels())
            {
                return View(context.Player.Where(x=>x.ID == id).FirstOrDefault());
            }
            
        }

        // GET: vlr/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: vlr/Create
        [HttpPost]
        public ActionResult Create(Player player)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Player.Add(player);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: vlr/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Player.Where(x => x.ID == id).FirstOrDefault());
            }

        }

        // POST: vlr/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Player player)
        {
            try
            {
                using(DbModels context = new DbModels())
                {
                    context.Entry(player).State = System.Data.EntityState.Modified;
                    context.SaveChanges();
                }    
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: vlr/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Player.Where(x => x.ID == id).FirstOrDefault());
            }
        }

        // POST: vlr/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using(DbModels context = new DbModels())
                {
                   Player player = context.Player.Where(x=> x.ID == id).FirstOrDefault();
                    context.Player.Remove(player);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
