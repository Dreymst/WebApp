using BusinessLayer;
using BusinessLayer.Query;
using MaWebApp.Models;
using MonTP;
using MonTP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MaWebApp.Controllers
{
    public class HomeController : Controller
    {
        private BusinessLayer.BusinessManager _bm;
        private MonContexte _monContexte;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MonAction()
        {
            var eleves = GetEleves();
            //var eleves = BusinessManager.GetInstance().GetEleves();
            List<EleveViewModel> eleveViewModels = new List<EleveViewModel>();
            foreach (var eleve in eleves)
            {
                eleveViewModels.Add(new EleveViewModel { Identite = $"{eleve.Nom.ToUpper()} {eleve.Prenom}" });
            }
            
            return View(eleveViewModels);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private List<Eleve> GetEleves()
        {
            var eleves = BusinessManager.GetInstance().GetEleves();

            eleves.Add(new Eleve { Nom = "Deat", Prenom = "Vincent" });
            eleves.Add(new Eleve { Nom = "Jacques", Prenom = "Jean" });
            return eleves;
        }
    }
}