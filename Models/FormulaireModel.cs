using System;
using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class FormulaireModel
    {
        public int Id { get; set; }
        //Format voulu pour le nom et message d'erreur si non conforme
        [Required(ErrorMessage ="Le nom est requis")]
        public string Nom { get; set; }
        //Format voulu pour le prénom et message d'erreur si non conforme
        [Required(ErrorMessage = "Le prénom est requis")]
        public string Prenom { get; set; }
        //Format voulu pour le sexe et message d'erreur si non conforme
        [Required(ErrorMessage = "Le sexe est requis")]
        public string Sexe { get; set; }
        //Format voulu pour l'adresse et message d'erreur si non conforme
        [Required(ErrorMessage = "L'adresse est requise")]
        public string Adresse { get; set; }
        //Format voulu pour le code postal et message d'erreur si non conforme
        [Required(ErrorMessage = "Le code postal est requis")]
        [RegularExpression(@"[0-9]{5}", ErrorMessage = "Entrer un code postal valide")]
        [DataType(DataType.PostalCode)]
        public int CodePostal { get; set; }
        //Format voulu pour la ville et message d'erreur si non conforme
        [Required(ErrorMessage = "La ville est requise")]
        public string Ville { get; set; }
        //Format voulu pour l'adresse mail et message d'erreur si non conforme
        [Required(ErrorMessage = "L'adresse email est requise")]
        [RegularExpression(@"^([\w]+)@([\w]+)\.([\w]+)$", ErrorMessage ="Entrer une adresse email valide")]
        public string AdresseMail { get; set; }
        //Format voulu pour la date de début de formation et message d'erreur si non conforme
        [Range(typeof(DateTime), "01/01/0001", "01/01/2021")]
        [Required(ErrorMessage = "La date est requise")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DateDebutFormation { get; set; }
        //Format voulu pour le type de formation et message d'erreur si non conforme
        [Required(ErrorMessage = "Le type de formation est requis")]
        public string TypeFormation { get; set; }
        //Format voulu pour l'avis sur la formation Cobol
        public string FormationCobol { get; set; }
        //Format voulu pour l'avis sur la formation Objet
        public string FormationObjet { get; set; }
    }
}