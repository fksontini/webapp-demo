using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webapp.Models;

namespace Webapp.Controllers
{
    public class EquipeController : Controller
    {
        // GET: Equipe
        public ActionResult Index()
        {
            List<Equipe> list = Session["equipe"] as List<Equipe>;
            return View(list);
        }

        // GET: Equipe/Details/5
        public ActionResult Details(int id)
        {

            List<Equipe> list = Session["equipe"] as List<Equipe>;

            Equipe eq = list.Where(a => a.EquipeIds == id).Single();

            return View(eq);
        }

        // GET: Equipe/Create
        public ActionResult Create()
        {
            List<Equipe> list = Session["equipe"] as List<Equipe>;

            return View();
        }

        // POST: Equipe/Create
        [HttpPost]
        public ActionResult Create(Equipe equipe)
        {
            

            try
            {
                List<Equipe> list = Session["equipe"] as List<Equipe>;
                if (list == null)
                {
                    list = new List<Equipe>();
                }
                list.Add(equipe);
                Session["equipe"] = list;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Equipe/Edit/5
        public ActionResult Edit(int id)
        {
            List<Equipe> list = Session["equipe"] as List<Equipe>;

            Equipe eq = list.Where(a => a.EquipeIds == id).Single();
            return View(eq);
        }

        // POST: Equipe/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Equipe equipe)
        {
            try
            {
                List<Equipe> list = Session["equipe"] as List<Equipe>;

                Equipe eq = list.Where(a => a.EquipeIds == id).Single();
                foreach (var item in list)
                {if (item.EquipeIds == equipe.EquipeIds)
                    {
                        item.Nom = equipe.Nom;
                        item.Pays = equipe.Pays;
                        item.datecreation = equipe.datecreation;
                    }
                }
                Session["equipe"] = list;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Equipe/Delete/5
        public ActionResult Delete(int id)
        {
            List<Equipe> list = Session["equipe"] as List<Equipe>;

            Equipe eq = list.Where(a => a.EquipeIds == id).Single();
            return View(eq);
          
        }

        // POST: Equipe/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                List<Equipe> list = Session["equipe"] as List<Equipe>;

                Equipe eq = list.Where(a => a.EquipeIds == id).Single();
                list.Remove(eq);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
