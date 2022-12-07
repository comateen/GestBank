using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Model
{
    public abstract class Compte
    {
        public static double operator +(double Solde, Compte c)
        {
            return Solde + ((c.Solde < 0.0) ? 0.0 : c.Solde);
        }

        private string _Numero;
        private double _Solde;
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
        
        public Personne Titulaire
        {
            get { return _Titulaire; }
            set { _Titulaire = value; }
        }

        public virtual void Retrait(double Montant)
        {
            Retrait(Montant, 0.0);
        }

        protected void Retrait(double Montant, double LigneDeCredit)
        {
            if (Montant <= 0)
                return; //à remplacer plus tard par une exception

            if (Solde - Montant < -LigneDeCredit)
                return; //à remplacer plus tard par une exception

            Solde -= Montant;
        }

        public void Depot(double Montant)
        {
            if (Montant <= 0)
                return; //à remplacer plus tard par une exception

            Solde += Montant;
        }

        protected abstract double CalculInteret();

        public void AppliquerInteret()
        {
            this._Solde += CalculInteret();
        }
    }
}
