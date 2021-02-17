using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TPLOCAL1.Models;


//Attention, le modèle MVC est un modèle dit de convention plutot que configuration, 
//Le controller doit donc obligatoirement se nommer avec "Controller" à la fin!!!
namespace TPLOCAL1.Controllers
{
    public class HomeController : Controller
    {
        // méthode appelée par la routeur "naturellement"
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                //renvoie vers la vue Index (voir routage dans RouteConfig.cs)
                return View();
            else
            {
                //en fonction du paramètre id, on appelle les différentes pages
                switch (id)
                {
                    case "ListeAvis":
                        //reste à faire : coder la lecture du fichier xml fourni
                        return View(id);
                    case "Formulaire":
                        //reste à faire : appeler la vue Formulaire avec le modèle de données vide
                        return View(id);
                    default:
                        //renvoie vers Index (voir routage dans RouteConfig.cs)
                        return View();
                }
            }
        }

        //méthode pour envoyer les données du formulaire vers la page de validation
        [HttpPost]
        public ActionResult ValidationFormulaire( FormulaireModel formulaire)
        {
            if (ModelState.IsValid)
            {
                return Index("ValidationFormulaire");
            }
            //return Index("ValidationFormulaire");
            return View(formulaire);
            //return View(formulaire);
            //reste à faire : tester de si les champs du modele sont bien remplis
            //s'ils ne sont pas bien remplis, afficher une erreur et rester sur la page formulaire
            //sinon, appeler la page ValidationFormulaire avec les données remplies par l'utilisateur

        }
    }
}