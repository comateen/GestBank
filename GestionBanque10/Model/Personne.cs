using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Model
{
    public class Personne
    {
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public DateTime DateNaiss { get; private set; }

        public Personne(string Nom, string Prenom, DateTime DateNaiss)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.DateNaiss = DateNaiss;
        }
    }
}
