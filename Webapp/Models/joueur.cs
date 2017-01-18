using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webapp.Models
{
    public class joueur
    {
        public int joueurId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
      
    }
}