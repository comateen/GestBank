using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Model
{
    public class Epargne : Compte
    {
        private DateTime _DernierRetrait;
        
        public DateTime DernierRetrait
        {
            get { return _DernierRetrait; }
            private set
            {                
                _DernierRetrait = value;
            }
        }
        
        public Epargne(string Numero, Personne Titulaire) : this(Numero, Titulaire, DateTime.Now, 0D)
        {
                
        }

        public Epargne(string Numero, Personne Titulaire, DateTime DernierRetrait, double Solde) : base(Numero, Titulaire, Solde)
        {
            this.DernierRetrait = DernierRetrait;
        }

        public override void Retrait(double Montant)
        {
            double AncientSolde = Solde;
            base.Retrait(Montant);

            if (Solde != AncientSolde)
            {
                DernierRetrait = DateTime.Now;
            }
        }

        protected override double CalculInteret()
        {
            return Solde * .045;
        }
    }
}
