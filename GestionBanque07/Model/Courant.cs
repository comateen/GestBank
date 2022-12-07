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
                    return; //à remplacer plus tard par une exception

                _LigneDeCredit = value;                
            }
        }

        public override void Retrait(double Montant)
        {
            Retrait(Montant, LigneDeCredit);
        }

        protected override double CalculInteret()
        {
            return (Solde < 0) ? Solde * .0975 : Solde * .03;
        }
    }
}
