using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Model
{
    public class Epargne
    {
        public static double operator +(double Solde, Epargne c)
        {
            return Solde + ((c.Solde < 0.0) ? 0.0 : c.Solde);
        }

        private string _Numero;
        private double _Solde;
        private DateTime _DernierRetrait;
        private Personne _Titulaire;

        public string Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }

        public double Solde
        {
            get { return _Solde; }
            private set { _Solde = value; }
        }

        public DateTime DernierRetrait
        {
            get { return _DernierRetrait; }
            private set
            {                
                _DernierRetrait = value;
            }
        }

        public Personne Titulaire
        {
            get { return _Titulaire; }
            set { _Titulaire = value; }
        }

        public void Retrait(double Montant)
        {
            if (Montant <= 0)
                return; //à remplacer plus tard par une exception

            if (Solde - Montant < 0)
                return; //à remplacer plus tard par une exception

            Solde -= Montant;
            DernierRetrait = DateTime.Now;
        }

        public void Depot(double Montant)
        {
            if (Montant <= 0)
                return; //à remplacer plus tard par une exception

            Solde += Montant;
        }
    }
}
