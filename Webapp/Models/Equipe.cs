using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Webapp.Models
{
    public class Equipe
    {
        public int EquipeIds { get; set; }
        public string Nom { get; set; }
        public string Pays { get; set; }
        [DataType(DataType.Date)]
        [Display(Name  ="Date de création ")]
        public DateTime datecreation { get; set; }
    }
}