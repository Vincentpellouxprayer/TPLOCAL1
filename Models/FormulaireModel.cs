using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class FormulaireModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Le nom est requis")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Le prénom est requis")]
        public string Prenom { get; set; }
        [Required(ErrorMessage = "Le sexe est requis")]
        public string Sexe { get; set; }
        [Required(ErrorMessage = "L'adresse est requise")]
        public string Adresse { get; set; }

        [Required(ErrorMessage = "Le code postal est requis")]
        [RegularExpression(@"[0-9]{5}", ErrorMessage = "Entrer un code postal valide")]
        [DataType(DataType.PostalCode)]
        public int CodePostal { get; set; }
        [Required(ErrorMessage = "La ville est requise")]
        public string Ville { get; set; }

        [Required(ErrorMessage = "L'adresse email est requise")]
        [RegularExpression(@"^([\w]+)@([\w]+)\.([\w]+)$", ErrorMessage ="Entrer une adresse email valide")]
        public string AdresseMail { get; set; }

        [Range(typeof(DateTime), "01/01/0001", "01/01/2021")]
        [Required(ErrorMessage = "La date est requise")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        //[DataType(DataType.Date)]
        public DateTime DateDebutFormation { get; set; }

        [Required(ErrorMessage = "Le type de formation est requis")]
        public string TypeFormation { get; set; }

        public string FormationCobol { get; set; }

        public string FormationObjet { get; set; }
    }
}