using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Model
{
    public class Courant : Compte
    {   
        private double _LigneDeCredit;

        public double LigneDeCredit
        {
            get { return _LigneDeCredit; }
            set 
            {
                if (value < 0)
                    throw new InvalidOperationException("La ligne de crédit est une valeur positive!");

                _LigneDeCredit = value;                
            }
        }

        public Courant(string Numero, Personne Titulaire) : this(Numero, Titulaire, 0D)
        {
                
        }

        public Courant(string Numero, Personne Titulaire, double Solde) : base(Numero, Titulaire, Solde)
        {
            
        }

        public override void Retrait(double Montant)
        {
            double OldSolde = Solde;
            Retrait(Montant, LigneDeCredit);
            
            if (OldSolde >= 0D && Solde < 0)
            {
                RaisePassageEnNegatifEvent();
            }
        }

        protected override double CalculInteret()
        {
            return (Solde < 0) ? Solde * .0975 : Solde * .03;
        }
    }
}
