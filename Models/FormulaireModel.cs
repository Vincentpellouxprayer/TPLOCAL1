using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class ListeFormulaire
    {
        private static int id = 0;
        private List<FormulaireModel> listFormulaire;

        public ListeFormulaire()
        {
            listFormulaire = new List<FormulaireModel>();
        }

        public void AddFormulaire(FormulaireModel formulaire)
        {
            formulaire.Id = id + 1;
            listFormulaire.Add(formulaire);
        }
        public FormulaireModel GetFormulaire(int id)
        {
            return listFormulaire[id - 1];
        }
    }
    public class FormulaireModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Le nom est requis")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Le prénom est requis")]
        public string Prenom { get; set; }
        [Required]
        public string Sexe { get; set; }
        [Required(ErrorMessage = "L'adresse est requise")]
        public string Adresse { get; set; }

        [Required(ErrorMessage = "Le code postal est requis")]
        [RegularExpression(@"[0-9]{5}", ErrorMessage = "Entrer un code postal valide")]
        public int CodePostal { get; set; }
        [Required(ErrorMessage = "La ville est requise")]
        public string Ville { get; set; }

        [Required(ErrorMessage = "L'adresse email est requise")]
        [RegularExpression(@"^([\w]+)@([\w]+)\.([\w]+)$", ErrorMessage ="Entrer une adresse email valide")]
        public string AdresseMail { get; set; }

        [Required(ErrorMessage = "La date est requise")]
        [DataType(DataType.Date)]
        public String DateDebutFormation { get; set; }

        [Required(ErrorMessage = "Le type de formation est requis")]
        public string TypeFormation { get; set; }

        public string FormationCobol { get; set; }

        public string FormationObjet { get; set; }
    }
}