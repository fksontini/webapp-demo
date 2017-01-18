using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webapp.Models;

namespace Webapp.Controllers
{
    public class JoueurController : Controller
    {
        // GET: Joueur
        public ActionResult Index()
        {
            List<joueur> list = Session["joueur"] as List<joueur>;
            return View(list);
        }

        // GET: Joueur/Details/5
        public ActionResult Details(int id)
        {
            List<joueur> list = Session["joueur"] as List<joueur>;

            joueur jo = list.Where(a => a.joueurId == id).Single();
            return View(jo);
        }

        // GET: Joueur/Create
        public ActionResult Create()
        {
            List<joueur> list = Session["joueur"] as List<joueur>;

            return View();
        }

        // POST: Joueur/Create
        [HttpPost]
        public ActionResult Create(joueur joueur)
        {
            try
            {
                joueur.joueurId = DateTime.Now.Millisecond;
                List<joueur> list = Session["joueur"] as List<joueur>;
                if (list == null)
                {
                    list = new List<joueur>();
                }
                list.Add(joueur);
                Session["joueur"] = list;
                return RedirectToAction("Index");

               
            }
            catch
            {
                return View();
            }
        }

        // GET: Joueur/Edit/5
        public ActionResult Edit(int id)
        {
            List<joueur> list = Session["joueur"] as List<joueur>;
            joueur jo = list.Where(a => a.joueurId == id).Single();
            return View(jo);
          
        }

        // POST: Joueur/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, joueur joueur)
        {
            try
            {
                List<joueur> list = Session["joueur"] as List<joueur>;

                joueur eq = list.Where(a => a.joueurId == id).Single();
                foreach (var item in list)
                {
                    if (item.joueurId == joueur.joueurId)
                    {
                        item.Nom = joueur.Nom;
                        item.Prenom = joueur.Prenom;
                        item.DateNaissance = joueur.DateNaissance;
                    }
                }
                Session["joueur"] = list;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Joueur/Delete/5
        public ActionResult Delete(int id)
        {
            List<joueur> list = Session["joueur"] as List<joueur>;

            joueur eq = list.Where(a => a.joueurId == id).Single();
            return View(eq);
         
        }

        // POST: Joueur/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                List<joueur> list = Session["joueur"] as List<joueur>;

                joueur eq = list.Where(a => a.joueurId == id).Single();
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
