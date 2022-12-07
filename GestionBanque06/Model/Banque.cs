﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Model
{
    public class Banque
    {
        public string Nom { get; set; }

        Dictionary<string, Compte> _Comptes = new Dictionary<string, Compte>();

        public KeyValuePair<string, Compte>[] Comptes
        {
            get { return _Comptes.ToArray(); }
        }

        public Compte this[string Numero]
        {
            get
            {
                Compte c;
                _Comptes.TryGetValue(Numero, out c);
                return c;
            }
        }

        public void Ajouter(Compte c)
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

            foreach (Compte c in _Comptes.Values)
            {
                avoir += c;
            }

            return avoir;
        }
    }
}
