using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Model
{
    public class Banque
    {
        public string Nom { get; set; }

        Dictionary<string, Courant> _Comptes = new Dictionary<string, Courant>();

        public KeyValuePair<string, Courant>[] Comptes
        {
            get { return _Comptes.ToArray(); }
        }

        public Courant this[string Numero]
        {
            get
            {
                Courant c;
                _Comptes.TryGetValue(Numero, out c);
                return c;
            }
        }

        public void Ajouter(Courant c)
        {
            _Comptes.Add(c.Numero, c);
        }

        public void Supprimer(string Numero)
        {
            _Comptes.Remove(Numero);
        }

        public double AvoirDesComptes(Personne p)
        {
            double avoir = 0.0;
            
            foreach(Courant c in _Comptes.Values)
            {
                avoir += c;
            }

            return avoir;
        }
    }
}
